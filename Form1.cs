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
using System.Reflection;
using System.Resources;
using System.Configuration;
using System.Collections.Specialized;


namespace Renomeador
{
    public partial class Form1 : Form
    {
        ResourceManager res_man = new ResourceManager("Renomeador.lang_en", Assembly.GetExecutingAssembly());
        string pasta;
        bool eng = false;
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
                    if(!eng)
                    {
                        toolStripStatusLabel1.Text = "trabalhando em" + f.Name;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "working on" + f.Name;
                    }
                    File.Move(f.FullName, f.FullName.Replace(txtRemover.Text, ""));
                    toolStripProgressBar1.Increment(1);

                }
                if(eng)
                {
                    toolStripStatusLabel1.Text = "Done";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Pronto";
                }
            }
            catch (ArgumentNullException)
            {
                if (!eng)
                {
                    MessageBox.Show("Selecione uma pasta!", "Erro");
                }
                else
                {
                    MessageBox.Show("Select a folder!", "Error");
                }
                abrir();
            }
        }

        //Função para manter apenas os ultimos caracteres do nome do arquivo
        void manter_char()
        {
            string num;
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
                        int manter = f.Name.Substring(f.Name.IndexOf(".")).Length + Decimal.ToInt32(numManter.Value);
                        toolStripStatusLabel1.Text = "trabalhando em" + f.Name;
                        num = f.FullName.Substring(f.FullName.Length - manter);
                        File.Move(f.FullName, f.FullName.Replace(f.Name, num));
                        toolStripProgressBar1.Increment(1);
                }
                toolStripStatusLabel1.Text = "Pronto";
            }
            catch(ArgumentNullException)
            {
                if(!eng)
                {
                    MessageBox.Show("Selecione uma pasta!", "Erro");
                }
                else
                {
                    MessageBox.Show("Select a folder!", "Error");
                }
                abrir();
            }
        }

        //menu abrir pasta
        private void abrirPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
            if(!eng)
            {
                this.Text = this.Text + " Trabalhando em: " + pasta;
            }
            else
            {
                this.Text = this.Text + " Working on: " + pasta;
            }
        }

        //botão renomear
        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(chk_mtn_numeros.Checked)
            {
                manter_char();
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
                numManter.Enabled = true;
            }
            else
            {
                txtRemover.Enabled = true;
                numManter.Enabled = false;
            }
        }

        private void portugueseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.englishToolStripMenuItem.Checked = false;
            this.portugueseToolStripMenuItem.Checked = true;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.englishToolStripMenuItem.Checked = true;
            this.portugueseToolStripMenuItem.Checked = false;
            lang_eng();
        }

        void lang_eng()
        {
            eng = true;
            this.arquivoToolStripMenuItem.Text = res_man.GetString("arquivo");
            this.abrirPastaToolStripMenuItem.Text = res_man.GetString("abrir_pasta");
            this.fecharToolStripMenuItem.Text = res_man.GetString("fechar");
            this.sobreToolStripMenuItem.Text = res_man.GetString("sobre");
            this.linguagemToolStripMenuItem.Text = res_man.GetString("linguagem");
            this.label1.Text = res_man.GetString("texto_para_remover");
            this.btn_remover.Text = res_man.GetString("renomear");
            this.chk_mtn_numeros.Text = res_man.GetString("manter_apenas_os_ultimos");
            this.label2.Text = res_man.GetString("caracteres_do_final");
            this.toolStripStatusLabel1.Text = res_man.GetString("pronto");
            this.sobreToolStripMenuItem1.Text = res_man.GetString("sobre");
        }
    }
}
