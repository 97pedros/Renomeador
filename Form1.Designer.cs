
namespace Renomeador
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_remover = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.linguagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portugueseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemover = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chk_mtn_numeros = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numManter = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numManter)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_remover
            // 
            resources.ApplyResources(this.btn_remover, "btn_remover");
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // arquivoToolStripMenuItem
            // 
            resources.ApplyResources(this.arquivoToolStripMenuItem, "arquivoToolStripMenuItem");
            this.arquivoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirPastaToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            // 
            // abrirPastaToolStripMenuItem
            // 
            resources.ApplyResources(this.abrirPastaToolStripMenuItem, "abrirPastaToolStripMenuItem");
            this.abrirPastaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.abrirPastaToolStripMenuItem.Name = "abrirPastaToolStripMenuItem";
            this.abrirPastaToolStripMenuItem.Click += new System.EventHandler(this.abrirPastaToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            resources.ApplyResources(this.fecharToolStripMenuItem, "fecharToolStripMenuItem");
            this.fecharToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            resources.ApplyResources(this.sobreToolStripMenuItem, "sobreToolStripMenuItem");
            this.sobreToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1,
            this.linguagemToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            // 
            // sobreToolStripMenuItem1
            // 
            resources.ApplyResources(this.sobreToolStripMenuItem1, "sobreToolStripMenuItem1");
            this.sobreToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // linguagemToolStripMenuItem
            // 
            resources.ApplyResources(this.linguagemToolStripMenuItem, "linguagemToolStripMenuItem");
            this.linguagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portugueseToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.linguagemToolStripMenuItem.Name = "linguagemToolStripMenuItem";
            // 
            // portugueseToolStripMenuItem
            // 
            resources.ApplyResources(this.portugueseToolStripMenuItem, "portugueseToolStripMenuItem");
            this.portugueseToolStripMenuItem.Checked = true;
            this.portugueseToolStripMenuItem.CheckOnClick = true;
            this.portugueseToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.portugueseToolStripMenuItem.Name = "portugueseToolStripMenuItem";
            this.portugueseToolStripMenuItem.Click += new System.EventHandler(this.portugueseToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.CheckOnClick = true;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtRemover
            // 
            resources.ApplyResources(this.txtRemover, "txtRemover");
            this.txtRemover.Name = "txtRemover";
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            // 
            // toolStripProgressBar1
            // 
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // chk_mtn_numeros
            // 
            resources.ApplyResources(this.chk_mtn_numeros, "chk_mtn_numeros");
            this.chk_mtn_numeros.Name = "chk_mtn_numeros";
            this.chk_mtn_numeros.UseVisualStyleBackColor = true;
            this.chk_mtn_numeros.CheckedChanged += new System.EventHandler(this.chk_mtn_numeros_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // numManter
            // 
            resources.ApplyResources(this.numManter, "numManter");
            this.numManter.Name = "numManter";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_remover;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numManter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chk_mtn_numeros);
            this.Controls.Add(this.txtRemover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numManter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemover;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem abrirPastaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox chk_mtn_numeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numManter;
        private System.Windows.Forms.ToolStripMenuItem linguagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portugueseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

