using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renomeador
{
    public partial class langMenu : Form
    {
        Form1 janela = new Form1();
        public langMenu()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.lang = "pt";
                    Properties.Settings.Default.Save();
                    this.Hide();
                    janela.Show();
                    break;
                case 1:
                    Properties.Settings.Default.lang = "en";
                    Properties.Settings.Default.Save();
                    this.Hide();
                    janela.Show();
                    break;
                case -1:
                    MessageBox.Show("Select a language");
                    break;
            }

            Properties.Settings.Default.firstStart = false;
            Properties.Settings.Default.Save();

        }
    }
}
