using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace JetpackDowngraderGUI
{
    public partial class MainForm : Form
    {
        const string PATCHES_URL = "https://github.com/MrErenK/test_downgrader/releases/download/patches/patches.zip";

        // All .jpp patch files that must exist for a valid patches install
        static readonly string[] REQUIRED_PATCHES = new[]
        {
            @"patches\game.jpp",
            @"patches\anim\anim.img.jpp",
            @"patches\audio\CONFIG\TrakLkup.dat.jpp",
            @"patches\audio\streams\BEATS.jpp",
            @"patches\audio\streams\CH.jpp",
            @"patches\audio\streams\CR.jpp",
            @"patches\audio\streams\CUTSCENE.jpp",
            @"patches\audio\streams\DS.jpp",
            @"patches\audio\streams\MH.jpp",
            @"patches\audio\streams\MR.jpp",
            @"patches\audio\streams\RE.jpp",
            @"patches\audio\streams\RG.jpp",
            @"patches\data\script\main.scm.jpp",
            @"patches\data\script\script.img.jpp",
            @"patches\models\gta3.img.jpp",
            @"patches\models\gta_int.img.jpp",
        };

        string[] lc = new string[100];
        bool[] appset = new bool[8];
        bool tabFix = false;
        public MainForm() { InitializeComponent(); }
        IniEditor cfg = new IniEditor(@Application.StartupPath + @"\app\jpd.ini");
        IniEditor lang = new IniEditor(@Application.StartupPath + @"\languages\" + Properties.Settings.Default.LanguageCode + ".txt");

        // Returns true if patcher.exe and every required .jpp file exist under app\
        bool PatchesExist()
        {
            string appDir = Path.Combine(Application.StartupPath, "app");
            if (!File.Exists(Path.Combine(appDir, "patcher.exe"))) return false;
            foreach (string rel in REQUIRED_PATCHES)
            {
                if (!File.Exists(Path.Combine(appDir, rel))) return false;
            }
            return true;
        }

        void SetPatchesReady(bool ready)
        {
            button1.Visible = ready;
            buttonDownloadPatches.Visible = !ready;
            buttonDownloadPatches.Enabled = !ready;
            progressLabel.Visible = false;
        }



        void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Localization
                label1.Text = Convert.ToString(lang.GetValue("Interface", "PathLabel"));
                string tab1 = Convert.ToString(lang.GetValue("Interface", "Tab1"));
                string tab2 = Convert.ToString(lang.GetValue("Interface", "Tab2"));
                DSPanelHeaderLabel.Text = tab1;
                button6.Text = "1. " + tab1;
                ModsPanelHeaderLabel.Text = tab2;
                button2.Text = "2. " + tab2;
                button1.Text = "3. " + Convert.ToString(lang.GetValue("Interface", "Downgrade"));
                HelloUser.Text = Convert.ToString(lang.GetValue("Interface", "Stage"));
                // CheckBox loading
                checkBox1.Text = Convert.ToString(lang.GetValue("CheckBox", "Backup"));
                checkBox2.Text = Convert.ToString(lang.GetValue("CheckBox", "Shortcut"));
                checkBox9.Text = Convert.ToString(lang.GetValue("CheckBox", "Reset"));
                checkBox4.Text = Convert.ToString(lang.GetValue("CheckBox", "GarbageCleaning"));
                checkBox6.Text = Convert.ToString(lang.GetValue("CheckBox", "GameReg"));
                checkBox3.Text = Convert.ToString(lang.GetValue("CheckBox", "NoUpdates"));
                checkBox5.Text = Convert.ToString(lang.GetValue("CheckBox", "Forced"));
                checkBox7.Text = Convert.ToString(lang.GetValue("CheckBox", "DirectPlay"));
                // Title loading
                lc[0] = Convert.ToString(lang.GetValue("Title", "Info"));
                lc[1] = Convert.ToString(lang.GetValue("Title", "Error"));
                lc[8] = Convert.ToString(lang.GetValue("Title", "Warning"));
                lc[6] = Convert.ToString(lang.GetValue("Title", "FolderSelectDialog"));
                // InfoMsg loading
                lc[4] = Convert.ToString(lang.GetValue("InfoMsg", "Succes"));
                lc[9] = Convert.ToString(lang.GetValue("InfoMsg", "Version"));
                lc[10] = Convert.ToString(lang.GetValue("InfoMsg", "Author"));
                // ErrorMsg loading
                lc[2] = Convert.ToString(lang.GetValue("ErrorMsg", "ReadINI"));
                lc[3] = Convert.ToString(lang.GetValue("ErrorMsg", "WriteINI"));
                // WarningMsg loading
                lc[7] = Convert.ToString(lang.GetValue("WarningMsg", "PathNotFound"));
                lc[5] = Convert.ToString(lang.GetValue("WarningMsg", "BrowserNotFound"));
            }
            catch { MessageBox.Show("Error loading the localization file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); Application.Exit(); }

            // Settings
            try
            {
                checkBox1.Checked = Convert.ToBoolean(cfg.GetValue("Downgrader", "CreateBackups"));
                checkBox2.Checked = Convert.ToBoolean(cfg.GetValue("Downgrader", "CreateShortcut"));
                checkBox9.Checked = Convert.ToBoolean(cfg.GetValue("Downgrader", "ResetGame"));
                checkBox4.Checked = Convert.ToBoolean(cfg.GetValue("Downgrader", "GarbageCleaning"));
                checkBox6.Checked = Convert.ToBoolean(cfg.GetValue("Downgrader", "RegisterGamePath"));
                checkBox3.Checked = Convert.ToBoolean(cfg.GetValue("Downgrader", "CreateNewGamePath"));
                checkBox5.Checked = Convert.ToBoolean(cfg.GetValue("Downgrader", "Forced"));
                checkBox7.Checked = Convert.ToBoolean(cfg.GetValue("Downgrader", "EnableDirectPlay"));
                appset[0] = Convert.ToBoolean(cfg.GetValue("JPD", "SelectFolder"));
                appset[1] = Convert.ToBoolean(cfg.GetValue("JPD", "ConsoleTransparency"));
                appset[2] = Convert.ToBoolean(cfg.GetValue("JPD", "UseMsg"));
                appset[3] = Convert.ToBoolean(cfg.GetValue("JPD", "UseProgressBar"));
                appset[4] = Convert.ToBoolean(cfg.GetValue("JPD", "Component"));
                appset[5] = Convert.ToBoolean(cfg.GetValue("Only", "GameVersion"));
                appset[6] = Convert.ToBoolean(cfg.GetValue("Only", "NextCheckFiles"));
                appset[7] = Convert.ToBoolean(cfg.GetValue("Only", "NextCheckFilesAndCheckMD5"));
            }
            catch { MsgError(lc[2], lc[1]); }

            // Check if patches are already present
            SetPatchesReady(PatchesExist());
        }

        async void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@GamePath.Text))
            {
                this.Enabled = false;
                cfg.SetValue("JPD", "SelectFolder", "false");
                cfg.SetValue("JPD", "UseMsg", "false");
                cfg.SetValue("JPD", "Component", "true");

                await Task.Run(() =>
                {
                    Process.Start(@Application.StartupPath + @"\app\jpd.exe", "\"" + GamePath.Text + "\"").WaitForExit();
                });

                bool jpdStillRunning = false;
                foreach (Process process2 in Process.GetProcesses())
                {
                    if (process2.ProcessName.ToLower().Contains("jpd")) { jpdStillRunning = true; break; }
                }

                if (!jpdStillRunning)
                {
                    MsgInfo(lc[4], lc[0]);
                }

                this.Enabled = true;
            }
            else { MsgWarning(lc[7], lc[8]); }
        }

        async void buttonDownloadPatches_Click(object sender, EventArgs e)
        {
            buttonDownloadPatches.Enabled = false;
            progressLabel.Visible = true;
            progressLabel.Text = "Connecting...";

            string appDir = Path.Combine(Application.StartupPath, "app");
            string zipPath = Path.Combine(appDir, "patches.zip");

            try
            {
                // Download
                using (var http = new HttpClient())
                {
                    http.DefaultRequestHeaders.Add("User-Agent", "JetpackDowngrader");
                    using (var response = await http.GetAsync(PATCHES_URL, HttpCompletionOption.ResponseHeadersRead))
                    {
                        response.EnsureSuccessStatusCode();
                        long? totalBytes = response.Content.Headers.ContentLength;
                        using (var srcStream = await response.Content.ReadAsStreamAsync())
                        using (var dstStream = new FileStream(zipPath, FileMode.Create, FileAccess.Write, FileShare.None, 81920, true))
                        {
                            byte[] buffer = new byte[81920];
                            long bytesRead = 0;
                            int read;
                            while ((read = await srcStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                            {
                                await dstStream.WriteAsync(buffer, 0, read);
                                bytesRead += read;
                                progressLabel.Text = totalBytes.HasValue
                                    ? $"Downloading... {bytesRead * 100 / totalBytes.Value}%"
                                    : $"Downloading... {bytesRead / 1048576} MB";
                            }
                        }
                    }
                }

                // Validate the zip isn't a tiny error page
                if (new FileInfo(zipPath).Length < 1024)
                {
                    File.Delete(zipPath);
                    MsgError("Download failed: the patches file was not found on the server.\nMake sure the release with tag \"patches\" and asset \"patches.zip\" exists.", lc[1]);
                    buttonDownloadPatches.Enabled = true;
                    progressLabel.Text = "";
                    return;
                }

                // Extract — the zip has a top-level "patches/" folder that contains
                // patcher.exe plus a nested patches/ subfolder with all .jpp files.
                // We strip the leading "patches/" prefix from every entry so that:
                //   patches/patcher.exe          -> app\patcher.exe
                //   patches/patches/game.jpp     -> app\patches\game.jpp  (etc.)
                progressLabel.Text = "Extracting...";
                await Task.Run(() =>
                {
                    using (var archive = ZipFile.OpenRead(zipPath))
                    {
                        foreach (var entry in archive.Entries)
                        {
                            // Skip pure directory entries
                            if (string.IsNullOrEmpty(entry.Name)) continue;

                            // Strip the leading "patches/" segment
                            string relativePath = entry.FullName;
                            const string prefix = "patches/";
                            if (relativePath.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                                relativePath = relativePath.Substring(prefix.Length);

                            // Convert forward slashes to backslashes
                            relativePath = relativePath.Replace('/', Path.DirectorySeparatorChar);

                            string destPath = Path.Combine(appDir, relativePath);
                            Directory.CreateDirectory(Path.GetDirectoryName(destPath));
                            entry.ExtractToFile(destPath, overwrite: true);
                        }
                    }
                });

                // Clean up zip
                File.Delete(zipPath);

                // Verify all files are now present
                if (PatchesExist())
                {
                    progressLabel.Visible = false;
                    SetPatchesReady(true);
                    MsgInfo("Patches downloaded successfully!", lc[0]);
                }
                else
                {
                    MsgError("Extraction completed but some patch files are still missing.\nPlease check the patches.zip structure.", lc[1]);
                    buttonDownloadPatches.Enabled = true;
                    progressLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                if (File.Exists(zipPath)) { try { File.Delete(zipPath); } catch { } }
                MsgError("Failed to download patches:\n" + ex.Message, lc[1]);
                buttonDownloadPatches.Enabled = true;
                progressLabel.Text = "";
            }
        }

        void pictureBox1_Click(object sender, EventArgs e)
        {
            var dialog = new FolderSelectDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                Title = lc[6]
            };
            if (dialog.Show()) { GamePath.Text = dialog.FileName; } else { GamePath.Text = ""; }
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e) { cfg.SetValue("Downgrader", "CreateBackups", Convert.ToString(checkBox1.Checked).Replace("T", "t").Replace("F", "f")); }
        void checkBox2_CheckedChanged(object sender, EventArgs e) { cfg.SetValue("Downgrader", "CreateShortcut", Convert.ToString(checkBox2.Checked).Replace("T", "t").Replace("F", "f")); }
        void checkBox3_CheckedChanged(object sender, EventArgs e) { cfg.SetValue("Downgrader", "CreateNewGamePath", Convert.ToString(checkBox3.Checked).Replace("T", "t").Replace("F", "f")); }
        void checkBox4_CheckedChanged(object sender, EventArgs e) { cfg.SetValue("Downgrader", "GarbageCleaning", Convert.ToString(checkBox4.Checked).Replace("T", "t").Replace("F", "f")); }
        void checkBox5_CheckedChanged(object sender, EventArgs e) { cfg.SetValue("Downgrader", "Forced", Convert.ToString(checkBox5.Checked).Replace("T", "t").Replace("F", "f")); }
        void checkBox6_CheckedChanged(object sender, EventArgs e) { cfg.SetValue("Downgrader", "RegisterGamePath", Convert.ToString(checkBox6.Checked).Replace("T", "t").Replace("F", "f")); }
        void checkBox7_CheckedChanged(object sender, EventArgs e) { cfg.SetValue("Downgrader", "EnableDirectPlay", Convert.ToString(checkBox7.Checked).Replace("T", "t").Replace("F", "f")); }
        void checkBox9_CheckedChanged(object sender, EventArgs e) { cfg.SetValue("Downgrader", "ResetGame", Convert.ToString(checkBox9.Checked).Replace("T", "t").Replace("F", "f")); }

        void pictureBox4_Click(object sender, EventArgs e) { try { Process.Start("https://github.com/Zalexanninev15/Jetpack-Downgrader"); } catch { MsgError(lc[5], lc[1]); } }
        void MsgInfo(string message, string title) { MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information); }
        void MsgError(string message, string title) { MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        void MsgWarning(string message, string title) { MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        void button7_Click(object sender, EventArgs e) { Process.Start("notepad.exe", @Application.StartupPath + @"\app\jpd.ini"); }
        void pictureBox3_Click(object sender, EventArgs e) { MsgInfo("Jetpack GUI\n" + lc[9] + ": " + Convert.ToString(Application.ProductVersion).Replace(".0", "") + "\n" + lc[10] + " Zalexanninev15", lc[0]); }

        void button6_Click(object sender, EventArgs e)
        {
            if (DSPanel.Visible == false) { tabFix = false; ModsPanel.Visible = false; DSPanel.Visible = true; }
            else
            {
                if (tabFix == false) { DSPanel.Visible = false; ModsPanel.Visible = false; }
                else { tabFix = false; ModsPanel.Visible = false; }
            }
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (ModsPanel.Visible == false) { tabFix = true; DSPanel.Visible = true; ModsPanel.Visible = true; }
            else { ModsPanel.Visible = false; DSPanel.Visible = false; tabFix = false; }
        }
    }
}
