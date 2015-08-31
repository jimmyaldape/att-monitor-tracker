using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorTracker
{
    public partial class NoNetworkPrompt : Form
    {
        public NoNetworkPrompt()
        {
            InitializeComponent();
        }

        private void buttonTry_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            
        }
    }
}
