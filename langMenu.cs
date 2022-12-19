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
        public langMenu()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Form1 janela = new Form1();
            janela.Show();
            this.Close();
        }
    }
}
