using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_GPU_Namer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            // The URL you want to open
            string url = "https://ahmadmorningstar.github.io";

            try
            {
                // Use Process.Start to open the URL in the default browser.
                // The 'true' argument tells the shell to use the default program.
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening link: {ex.Message}");
            }
        }

        private void github_button_Click(object sender, EventArgs e)
        {
            // The URL you want to open
            string url = "https://github.com/AhmadMorningstar/Easy-CPUGPU-Namer";

            try
            {
                // Use Process.Start to open the URL in the default browser.
                // The 'true' argument tells the shell to use the default program.
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening link: {ex.Message}");
            }
        }
    }
}
