using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace CPU_GPU_Namer
{
    public partial class MainForm : Form
    {
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        private List<(string RegPath, string Name)> gpuList;



        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        public MainForm()
        {
            InitializeComponent();
            var darkTheme = 1; // 1 for dark, 0 for light
            DwmSetWindowAttribute(this.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref darkTheme, sizeof(int));

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCPUNames();

            gpuList = GetGPUs();
            gpu_selection_comobox.Items.Clear();
            // Open backup once
            RegistryKey backup = Registry.CurrentUser.OpenSubKey(@"Software\GPUCPUNameTool\Backup");

            for (int i = 0; i < gpuList.Count; i++)
            {
                string backupName = null;

                if (backup != null)
                {
                    backupName = backup.GetValue("OriginalGPUName_" + i, null)?.ToString();
                }

                string displayName = backupName ?? gpuList[i].Name;

                gpu_selection_comobox.Items.Add(displayName);
            }

            backup?.Close();
        }


        private void LoadCPUNames()
        {
            try
            {
                string cpuRegPath = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";
                RegistryKey key = Registry.LocalMachine.OpenSubKey(cpuRegPath);

                if (key == null)
                {
                    original_cpu_name_textbox.Text = "ERROR: Cannot open registry key!";
                    current_cpu_name_textbox.Text = "ERROR";
                    return;
                }

                // read CPU name
                string currentName = key.GetValue("ProcessorNameString", "").ToString();

                current_cpu_name_textbox.Text = currentName;

                // Load backup from HKCU if exists
                RegistryKey backupKey = Registry.CurrentUser.OpenSubKey(@"Software\GPUCPUNameTool\Backup");

                if (backupKey != null && backupKey.GetValue("OriginalCPUName") != null)
                {
                    // Backup exists
                    string originalName = backupKey.GetValue("OriginalCPUName").ToString();
                    original_cpu_name_textbox.Text = originalName;
                }
                else
                {
                    // No backup previously saved → original = current
                    original_cpu_name_textbox.Text = currentName;
                }
            }
            catch (Exception ex)
            {
                original_cpu_name_textbox.Text = "Error: " + ex.Message;
                current_cpu_name_textbox.Text = "Error";
            }
        }


        private void apply_button_Click(object sender, EventArgs e)
        {
            // Backup original if not already saved
            RegistryKey backup = Registry.CurrentUser.CreateSubKey(@"Software\GPUCPUNameTool\Backup");

            if (backup.GetValue("OriginalCPUName") == null)
            {
                backup.SetValue("OriginalCPUName", current_cpu_name_textbox.Text);
            }

            backup.Close();

            try
            {
                string newName = new_cpu_name_textbox.Text.Trim();

                if (string.IsNullOrWhiteSpace(newName))
                {
                    MessageBox.Show("Please enter a valid CPU name.");
                    return;
                }

                // Registry path for CPU name
                string cpuRegPath = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";

                // Open the registry key with write access
                RegistryKey key = Registry.LocalMachine.OpenSubKey(cpuRegPath, writable: true);

                if (key == null)
                {
                    MessageBox.Show("Unable to open registry path. Run the app as Administrator.");
                    return;
                }

                // Write new CPU name
                key.SetValue("ProcessorNameString", newName, RegistryValueKind.String);

                key.Close();
                cpu_status_label.ForeColor = System.Drawing.Color.LightGreen;
                cpu_status_label.Text = "Status: CPU name successfully updated!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            gpunamer();
        }

        private string CleanGPUName(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw))
                return raw;

            // If the name contains a semicolon, take text after the last semicolon
            int index = raw.LastIndexOf(';');
            if (index >= 0 && index < raw.Length - 1)
                return raw.Substring(index + 1).Trim();

            return raw.Trim();
        }


        // Returns all GPU registry paths + names
        private List<(string RegPath, string Name)> GetGPUs()
        {
            List<(string RegPath, string Name)> result = new List<(string, string)>();

            string basePath = @"SYSTEM\CurrentControlSet\Enum\PCI";

            RegistryKey pciRoot = Registry.LocalMachine.OpenSubKey(basePath);

            if (pciRoot == null)
                return result;

            foreach (var deviceKeyName in pciRoot.GetSubKeyNames())
            {
                RegistryKey deviceKey = pciRoot.OpenSubKey(deviceKeyName);
                if (deviceKey == null) continue;

                foreach (var instanceName in deviceKey.GetSubKeyNames())
                {
                    RegistryKey instanceKey = deviceKey.OpenSubKey(instanceName);
                    if (instanceKey == null) continue;

                    // Look for display adapter ClassGUID
                    string classGuid = instanceKey.GetValue("ClassGUID", "").ToString().ToLower();

                    if (classGuid == "{4d36e968-e325-11ce-bfc1-08002be10318}")
                    {
                        // GPU Found
                        string friendly = instanceKey.GetValue("FriendlyName", "").ToString();
                        string deviceDesc = instanceKey.GetValue("DeviceDesc", "").ToString();

                        string name = friendly != "" ? friendly : CleanGPUName(deviceDesc);

                        string fullPath = basePath + "\\" + deviceKeyName + "\\" + instanceName;

                        result.Add((fullPath, name));
                    }
                }
            }

            return result;
        }

        private void gpunamer()
        {
            {
                int index = gpu_selection_comobox.SelectedIndex;
                if (index < 0)
                {
                    MessageBox.Show("Select a GPU first.");
                    return;
                }

                string newName = new_gpu_name_textbox.Text.Trim();
                if (newName == "")
                {
                    MessageBox.Show("Enter a valid GPU name.");
                    return;
                }

                string path = gpuList[index].RegPath;

                RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true);

                // Backup if needed
                RegistryKey backup = Registry.CurrentUser.CreateSubKey(@"Software\GPUCPUNameTool\Backup");

                if (backup.GetValue("OriginalGPUName_" + index) == null)
                {
                    backup.SetValue("OriginalGPUName_" + index, current_gpu_name_textbox.Text);
                }

                // Write friendly name
                key.SetValue("FriendlyName", newName, RegistryValueKind.String);

                key.Close();
                backup.Close();
                gpu_status_label.ForeColor = System.Drawing.Color.LightGreen;
                gpu_status_label.Text = "Status: GPU name Successfully updated!";
            }
        }


        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gpu_selection_comobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gpu_selection_comobox.SelectedIndex;
            if (index < 0) return;

            string path = gpuList[index].RegPath;

            RegistryKey key = Registry.LocalMachine.OpenSubKey(path);

            string friendly = key.GetValue("FriendlyName", "").ToString();
            string deviceDesc = key.GetValue("DeviceDesc", "").ToString();

            string currentName = friendly != "" ? friendly : CleanGPUName(deviceDesc);

            current_gpu_name_textbox.Text = currentName;

            // Backup
            RegistryKey backup = Registry.CurrentUser.CreateSubKey(@"Software\GPUCPUNameTool\Backup");

            string backupName = backup.GetValue("OriginalGPUName_" + index, null)?.ToString();

            original_gpu_name_textbox.Text = backupName ?? currentName;

            backup.Close();
        }

        private void restore_defaults_button_Click(object sender, EventArgs e)
        {
            RestoreCPU();
            RestoreSelectedGPU();
        }
        private void RestoreCPU()
        {
            try
            {
                RegistryKey backup = Registry.CurrentUser.OpenSubKey(@"Software\GPUCPUNameTool\Backup");
                if (backup == null || backup.GetValue("OriginalCPUName") == null)
                {
                    MessageBox.Show("No CPU backup found!");
                    return;
                }

                string originalName = backup.GetValue("OriginalCPUName").ToString();

                // Write to CPU registry
                string cpuRegPath = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";
                RegistryKey cpuKey = Registry.LocalMachine.OpenSubKey(cpuRegPath, writable: true);
                if (cpuKey == null)
                {
                    MessageBox.Show("Unable to open CPU registry key. Run as Administrator.");
                    return;
                }

                cpuKey.SetValue("ProcessorNameString", originalName, RegistryValueKind.String);
                cpuKey.Close();
                backup.Close();

                current_cpu_name_textbox.Text = originalName;
                cpu_status_label.ForeColor = System.Drawing.Color.LightGreen;
                cpu_status_label.Text = "CPU restored to original!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error restoring CPU: " + ex.Message);
            }
        }

        private void RestoreSelectedGPU()
        {
            int index = gpu_selection_comobox.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select a GPU first.");
                return;
            }

            try
            {
                RegistryKey backup = Registry.CurrentUser.OpenSubKey(@"Software\GPUCPUNameTool\Backup");
                string originalName = backup?.GetValue("OriginalGPUName_" + index, null)?.ToString();

                if (string.IsNullOrEmpty(originalName))
                {
                    MessageBox.Show("No backup found for this GPU!");
                    return;
                }

                string path = gpuList[index].RegPath;
                RegistryKey key = Registry.LocalMachine.OpenSubKey(path, writable: true);
                if (key == null)
                {
                    MessageBox.Show("Unable to open GPU registry key. Run as Administrator.");
                    return;
                }

                key.SetValue("FriendlyName", originalName, RegistryValueKind.String);
                key.Close();
                backup.Close();

                current_gpu_name_textbox.Text = originalName;
                gpu_status_label.ForeColor = System.Drawing.Color.LightGreen;
                gpu_status_label.Text = "GPU restored to original!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error restoring GPU: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About AboutForm = new About();
            AboutForm.Show();
        }
    }
}
