using System;
using System.Windows.Forms;

namespace _3d_viewer.Frontend
{
    public partial class InfoControl : UserControl
    {
        MainForm mainForm;

        public InfoControl()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
