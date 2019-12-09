using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace Kursova
{
    public partial class ServiceForm : MetroForm
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void metroTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (metroTrackBar1.Value == 0) { MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Light; }
            else
            {
                MetroStyleManager.Default.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
