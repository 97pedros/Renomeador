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
using System.Runtime.CompilerServices;

namespace Renomeador
{
    public partial class Form1 : Form
    {
        //gerenciador de recursos para o idioma inglês
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
                //comandos que leem as informações de arquivos e pastas
                DirectoryInfo d = new DirectoryInfo(@pasta);
                FileInfo[] infos = d.GetFiles();
                int max = 0;
                //loop para definir o tamanho maximo de passos para a barra de carregamento
                foreach (FileInfo f in infos)
                {
                    max++;
                    toolStripProgressBar1.Maximum = max;
                }
                //loop para renomear arquivos com apenas o numero determinado de caracteres no final da string com o nome do arquivo
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
                //exibe mensagem de erro no idioma selecionado
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
                this.Text = Text + " Trabalhando em: " + pasta;
            }
            else
            {
                this.Text = Text + " Working on: " + pasta;
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
            lang_por();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.englishToolStripMenuItem.Checked = true;
            this.portugueseToolStripMenuItem.Checked = false;
            lang_eng();
        }

        void lang_eng()
        {
            //Traduz o programa para inglês
            eng = true;
            arquivoToolStripMenuItem.Text = res_man.GetString("arquivo");
            abrirPastaToolStripMenuItem.Text = res_man.GetString("abrir_pasta");
            fecharToolStripMenuItem.Text = res_man.GetString("fechar");
            sobreToolStripMenuItem.Text = res_man.GetString("sobre");
            linguagemToolStripMenuItem.Text = res_man.GetString("linguagem");
            label1.Text = res_man.GetString("texto_para_remover");
            btn_remover.Text = res_man.GetString("renomear");
            chk_mtn_numeros.Text = res_man.GetString("manter_apenas_os_ultimos");
            label2.Text = res_man.GetString("caracteres_do_final");
            toolStripStatusLabel1.Text = res_man.GetString("pronto");
            sobreToolStripMenuItem1.Text = res_man.GetString("sobre");
            Properties.Settings.Default.lang = "en";
            Properties.Settings.Default.Save();
        }

        void lang_por()
        {
            //traduz o programa para portugues
            eng = false;
            arquivoToolStripMenuItem.Text = "Arquivo";
            abrirPastaToolStripMenuItem.Text = "Abrir pasta";
            fecharToolStripMenuItem.Text = "Fechar";
            sobreToolStripMenuItem.Text = "Sobre";
            linguagemToolStripMenuItem.Text = "Linguagem";
            label1.Text = "Texto para remover";
            btn_remover.Text = "Renomear";
            chk_mtn_numeros.Text = "Manter apenas os ultimos";
            label2.Text = "caracteres do final";
            toolStripStatusLabel1.Text = "Pronto";
            sobreToolStripMenuItem1.Text = "Sobre";
            Properties.Settings.Default.lang = "pt";
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Abre a janela de seleção de idioma na primeira execução do programa
            switch (Properties.Settings.Default.lang) 
            {
                case "en":
                    lang_eng();
                    englishToolStripMenuItem.Checked = true;
                    portugueseToolStripMenuItem.Checked = false;
                    break;
                case "pt":
                    lang_por();
                    englishToolStripMenuItem.Checked = false;
                    portugueseToolStripMenuItem.Checked = true;
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}