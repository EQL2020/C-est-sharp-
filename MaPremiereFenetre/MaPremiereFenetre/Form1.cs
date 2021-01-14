using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaPremiereFenetre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Bonjour";
            maListeDeroulante.Items.AddRange(new string[] { "choix 1", "choix 2" });
            maListeDeroulante.SelectedIndex = 0;
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            label1.Text = "Au revoir";
        }

        private void buttonValider_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
    }
}
