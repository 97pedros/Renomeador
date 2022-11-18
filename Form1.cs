using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Renomeador
{
    public partial class Form1 : Form
    {
        string pasta;
        public Form1()
        {
            InitializeComponent();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Janela de informações
        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 sobre = new AboutBox1();
            sobre.Show();
        }
        //Função para a janela de seleção de pastas
        void abrir()
        {
            FolderBrowserDialog navPasta = new FolderBrowserDialog();
            if (navPasta.ShowDialog() == DialogResult.OK)
            {
                pasta = navPasta.SelectedPath;
                toolStripProgressBar1.Value = 0;
            }
        }

        //Função para remover palavras do nome do arquivo
        void renomear()
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(@pasta);
                FileInfo[] infos = d.GetFiles();
                int max = 0;
                foreach (FileInfo f in infos)
                {
                    max++;
                    toolStripProgressBar1.Maximum = max;
                }
                foreach (FileInfo f in infos)
                {
                    toolStripStatusLabel1.Text = "trabalhando em" + f.Name;
                    File.Move(f.FullName, f.FullName.Replace(txtRemover.Text, ""));
                    toolStripProgressBar1.Increment(1);

                }
                toolStripStatusLabel1.Text = "Pronto";
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Selecione uma pasta!", "Erro");
                abrir();
            }
        }

        //Função para manter apenas os números do nome do arquivo
        void manter_numeros()
        {
            string num;
            DirectoryInfo d = new DirectoryInfo(@pasta);
            FileInfo[] infos = d.GetFiles();
            int max = 0;
            foreach (FileInfo f in infos)
            {
                max++;
                toolStripProgressBar1.Maximum = max;
            }
            foreach (FileInfo f in infos)
            {
                toolStripStatusLabel1.Text = "trabalhando em" + f.Name;
                num = f.FullName.Substring(f.FullName.Length - 7);
                File.Move(f.FullName, f.FullName.Replace(f.Name, num));
                toolStripProgressBar1.Increment(1);

            }
            toolStripStatusLabel1.Text = "Pronto";
        }

        //menu abrir pasta
        private void abrirPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
            this.Text = this.Text + " Trabalhando em: " + pasta;
        }

        //botão renomear
        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(chk_mtn_numeros.Checked)
            {
                manter_numeros();
            }
            else
            {
                renomear();
            }
        }
        
        //checkbox de manter os números
        private void chk_mtn_numeros_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_mtn_numeros.Checked)
            {
                txtRemover.Enabled = false;
            }
            else
            {
                txtRemover.Enabled = true;
            }
        }
    }
}
