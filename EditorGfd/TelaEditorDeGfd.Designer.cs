
namespace EditorGfd
{
    partial class TelaEditorDeGfd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditorDeGfd));
            this.DgFontes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSGfd = new System.Windows.Forms.ToolStripMenuItem();
            this.TsAbrirGfd = new System.Windows.Forms.ToolStripMenuItem();
            this.TSFecharGfd = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.TsEdtGFDSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LbLeLinhaDesc = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LbLeLinhaBase = new System.Windows.Forms.Label();
            this.LbLeAltura = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.LbDescendente = new System.Windows.Forms.Label();
            this.TxtDescendente = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picCorecao = new System.Windows.Forms.PictureBox();
            this.LbBase = new System.Windows.Forms.Label();
            this.txtLinhaBase = new System.Windows.Forms.TextBox();
            this.LbPrevia = new System.Windows.Forms.Label();
            this.TxtPreviaInGame = new System.Windows.Forms.TextBox();
            this.picPreviaInGame = new System.Windows.Forms.PictureBox();
            this.LbLeLarguraGlifo = new System.Windows.Forms.Label();
            this.LbLeLargura = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NCorecaoEixoY = new System.Windows.Forms.NumericUpDown();
            this.NAlturaCaractere = new System.Windows.Forms.NumericUpDown();
            this.NCorecaoEixoX = new System.Windows.Forms.NumericUpDown();
            this.NLarguraCaractere = new System.Windows.Forms.NumericUpDown();
            this.LbLarguraGlifo = new System.Windows.Forms.Label();
            this.NLarguraGlifo = new System.Windows.Forms.NumericUpDown();
            this.LbCorecaoY = new System.Windows.Forms.Label();
            this.LbCorecaoX = new System.Windows.Forms.Label();
            this.LbAltura = new System.Windows.Forms.Label();
            this.LBLargura = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LbCaractere = new System.Windows.Forms.Label();
            this.TxtCaractere = new System.Windows.Forms.TextBox();
            this.PBCaractere = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LbTituloEditorProp = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnSalvarGfd = new System.Windows.Forms.ToolStripButton();
            this.LbSalvarGfd = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgFontes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorecao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviaInGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCorecaoEixoY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAlturaCaractere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCorecaoEixoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NLarguraCaractere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NLarguraGlifo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaractere)).BeginInit();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgFontes
            // 
            resources.ApplyResources(this.DgFontes, "DgFontes");
            this.DgFontes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgFontes.Name = "DgFontes";
            this.DgFontes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgFontes.CurrentCellChanged += new System.EventHandler(this.DgFontes_CurrentCellChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSGfd,
            this.TSSobre});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // TSGfd
            // 
            this.TSGfd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsAbrirGfd,
            this.TSFecharGfd});
            this.TSGfd.Name = "TSGfd";
            resources.ApplyResources(this.TSGfd, "TSGfd");
            // 
            // TsAbrirGfd
            // 
            this.TsAbrirGfd.Name = "TsAbrirGfd";
            resources.ApplyResources(this.TsAbrirGfd, "TsAbrirGfd");
            this.TsAbrirGfd.Click += new System.EventHandler(this.AbrirgfdToolStripMenuItem1_Click);
            // 
            // TSFecharGfd
            // 
            resources.ApplyResources(this.TSFecharGfd, "TSFecharGfd");
            this.TSFecharGfd.Name = "TSFecharGfd";
            this.TSFecharGfd.Click += new System.EventHandler(this.FecharGfdCarregado_Click);
            // 
            // TSSobre
            // 
            this.TSSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsEdtGFDSobre});
            this.TSSobre.Name = "TSSobre";
            resources.ApplyResources(this.TSSobre, "TSSobre");
            // 
            // TsEdtGFDSobre
            // 
            this.TsEdtGFDSobre.Name = "TsEdtGFDSobre";
            resources.ApplyResources(this.TsEdtGFDSobre, "TsEdtGFDSobre");
            this.TsEdtGFDSobre.Click += new System.EventHandler(this.EditorDeGFDPorToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.BtnPesquisar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DgFontes);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // txtPesquisa
            // 
            resources.ApplyResources(this.txtPesquisa, "txtPesquisa");
            this.txtPesquisa.Name = "txtPesquisa";
            // 
            // BtnPesquisar
            // 
            resources.ApplyResources(this.BtnPesquisar, "BtnPesquisar");
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LbTitulo);
            this.panel2.Name = "panel2";
            // 
            // LbTitulo
            // 
            resources.ApplyResources(this.LbTitulo, "LbTitulo");
            this.LbTitulo.Name = "LbTitulo";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.LbLeAltura);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.LbDescendente);
            this.panel3.Controls.Add(this.TxtDescendente);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.picCorecao);
            this.panel3.Controls.Add(this.LbBase);
            this.panel3.Controls.Add(this.txtLinhaBase);
            this.panel3.Controls.Add(this.LbPrevia);
            this.panel3.Controls.Add(this.TxtPreviaInGame);
            this.panel3.Controls.Add(this.picPreviaInGame);
            this.panel3.Controls.Add(this.LbLeLarguraGlifo);
            this.panel3.Controls.Add(this.LbLeLargura);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.NCorecaoEixoY);
            this.panel3.Controls.Add(this.NAlturaCaractere);
            this.panel3.Controls.Add(this.NCorecaoEixoX);
            this.panel3.Controls.Add(this.NLarguraCaractere);
            this.panel3.Controls.Add(this.LbLarguraGlifo);
            this.panel3.Controls.Add(this.NLarguraGlifo);
            this.panel3.Controls.Add(this.LbCorecaoY);
            this.panel3.Controls.Add(this.LbCorecaoX);
            this.panel3.Controls.Add(this.LbAltura);
            this.panel3.Controls.Add(this.LBLargura);
            this.panel3.Controls.Add(this.BtnSalvar);
            this.panel3.Controls.Add(this.LbCaractere);
            this.panel3.Controls.Add(this.TxtCaractere);
            this.panel3.Controls.Add(this.PBCaractere);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Name = "panel3";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LbLeLinhaDesc);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // LbLeLinhaDesc
            // 
            resources.ApplyResources(this.LbLeLinhaDesc, "LbLeLinhaDesc");
            this.LbLeLinhaDesc.Name = "LbLeLinhaDesc";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LbLeLinhaBase);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // LbLeLinhaBase
            // 
            resources.ApplyResources(this.LbLeLinhaBase, "LbLeLinhaBase");
            this.LbLeLinhaBase.Name = "LbLeLinhaBase";
            // 
            // LbLeAltura
            // 
            resources.ApplyResources(this.LbLeAltura, "LbLeAltura");
            this.LbLeAltura.Name = "LbLeAltura";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Orange;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // LbDescendente
            // 
            resources.ApplyResources(this.LbDescendente, "LbDescendente");
            this.LbDescendente.Name = "LbDescendente";
            // 
            // TxtDescendente
            // 
            resources.ApplyResources(this.TxtDescendente, "TxtDescendente");
            this.TxtDescendente.Name = "TxtDescendente";
            this.TxtDescendente.ReadOnly = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // picCorecao
            // 
            this.picCorecao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.picCorecao, "picCorecao");
            this.picCorecao.Name = "picCorecao";
            this.picCorecao.TabStop = false;
            // 
            // LbBase
            // 
            resources.ApplyResources(this.LbBase, "LbBase");
            this.LbBase.Name = "LbBase";
            // 
            // txtLinhaBase
            // 
            resources.ApplyResources(this.txtLinhaBase, "txtLinhaBase");
            this.txtLinhaBase.Name = "txtLinhaBase";
            this.txtLinhaBase.ReadOnly = true;
            // 
            // LbPrevia
            // 
            resources.ApplyResources(this.LbPrevia, "LbPrevia");
            this.LbPrevia.Name = "LbPrevia";
            // 
            // TxtPreviaInGame
            // 
            resources.ApplyResources(this.TxtPreviaInGame, "TxtPreviaInGame");
            this.TxtPreviaInGame.Name = "TxtPreviaInGame";
            this.TxtPreviaInGame.TextChanged += new System.EventHandler(this.TxtPreviaInGame_TextChanged);
            // 
            // picPreviaInGame
            // 
            this.picPreviaInGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.picPreviaInGame, "picPreviaInGame");
            this.picPreviaInGame.Name = "picPreviaInGame";
            this.picPreviaInGame.TabStop = false;
            // 
            // LbLeLarguraGlifo
            // 
            resources.ApplyResources(this.LbLeLarguraGlifo, "LbLeLarguraGlifo");
            this.LbLeLarguraGlifo.Name = "LbLeLarguraGlifo";
            // 
            // LbLeLargura
            // 
            resources.ApplyResources(this.LbLeLargura, "LbLeLargura");
            this.LbLeLargura.Name = "LbLeLargura";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumBlue;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // NCorecaoEixoY
            // 
            resources.ApplyResources(this.NCorecaoEixoY, "NCorecaoEixoY");
            this.NCorecaoEixoY.Name = "NCorecaoEixoY";
            this.NCorecaoEixoY.ValueChanged += new System.EventHandler(this.CorecaoEixo_ValueChanged);
            // 
            // NAlturaCaractere
            // 
            resources.ApplyResources(this.NAlturaCaractere, "NAlturaCaractere");
            this.NAlturaCaractere.Name = "NAlturaCaractere";
            this.NAlturaCaractere.ValueChanged += new System.EventHandler(this.ValorDoCampoFoiAlterado);
            // 
            // NCorecaoEixoX
            // 
            resources.ApplyResources(this.NCorecaoEixoX, "NCorecaoEixoX");
            this.NCorecaoEixoX.Name = "NCorecaoEixoX";
            this.NCorecaoEixoX.ValueChanged += new System.EventHandler(this.CorecaoEixo_ValueChanged);
            // 
            // NLarguraCaractere
            // 
            resources.ApplyResources(this.NLarguraCaractere, "NLarguraCaractere");
            this.NLarguraCaractere.Name = "NLarguraCaractere";
            this.NLarguraCaractere.ValueChanged += new System.EventHandler(this.ValorDoCampoFoiAlterado);
            // 
            // LbLarguraGlifo
            // 
            resources.ApplyResources(this.LbLarguraGlifo, "LbLarguraGlifo");
            this.LbLarguraGlifo.Name = "LbLarguraGlifo";
            // 
            // NLarguraGlifo
            // 
            resources.ApplyResources(this.NLarguraGlifo, "NLarguraGlifo");
            this.NLarguraGlifo.Name = "NLarguraGlifo";
            this.NLarguraGlifo.ValueChanged += new System.EventHandler(this.ValorDoCampoFoiAlterado);
            // 
            // LbCorecaoY
            // 
            resources.ApplyResources(this.LbCorecaoY, "LbCorecaoY");
            this.LbCorecaoY.Name = "LbCorecaoY";
            // 
            // LbCorecaoX
            // 
            resources.ApplyResources(this.LbCorecaoX, "LbCorecaoX");
            this.LbCorecaoX.Name = "LbCorecaoX";
            // 
            // LbAltura
            // 
            resources.ApplyResources(this.LbAltura, "LbAltura");
            this.LbAltura.Name = "LbAltura";
            // 
            // LBLargura
            // 
            resources.ApplyResources(this.LBLargura, "LBLargura");
            this.LBLargura.Name = "LBLargura";
            // 
            // BtnSalvar
            // 
            resources.ApplyResources(this.BtnSalvar, "BtnSalvar");
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // LbCaractere
            // 
            resources.ApplyResources(this.LbCaractere, "LbCaractere");
            this.LbCaractere.Name = "LbCaractere";
            // 
            // TxtCaractere
            // 
            resources.ApplyResources(this.TxtCaractere, "TxtCaractere");
            this.TxtCaractere.Name = "TxtCaractere";
            // 
            // PBCaractere
            // 
            this.PBCaractere.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.PBCaractere, "PBCaractere");
            this.PBCaractere.Name = "PBCaractere";
            this.PBCaractere.TabStop = false;
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.LbTituloEditorProp);
            this.panel4.Name = "panel4";
            // 
            // LbTituloEditorProp
            // 
            resources.ApplyResources(this.LbTituloEditorProp, "LbTituloEditorProp");
            this.LbTituloEditorProp.Name = "LbTituloEditorProp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSalvarGfd,
            this.LbSalvarGfd});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // BtnSalvarGfd
            // 
            this.BtnSalvarGfd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSalvarGfd.Image = global::EditorGfd.Properties.Resources.SaveStatusBar1_16x;
            resources.ApplyResources(this.BtnSalvarGfd, "BtnSalvarGfd");
            this.BtnSalvarGfd.Name = "BtnSalvarGfd";
            this.BtnSalvarGfd.Click += new System.EventHandler(this.BtnSalvarGfd_Click);
            // 
            // LbSalvarGfd
            // 
            this.LbSalvarGfd.Name = "LbSalvarGfd";
            resources.ApplyResources(this.LbSalvarGfd, "LbSalvarGfd");
            // 
            // TelaEditorDeGfd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaEditorDeGfd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaEditorDeGfd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgFontes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorecao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreviaInGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCorecaoEixoY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAlturaCaractere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCorecaoEixoX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NLarguraCaractere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NLarguraGlifo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaractere)).EndInit();
            this.panel4.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgFontes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSGfd;
        private System.Windows.Forms.ToolStripMenuItem TsAbrirGfd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LbTituloEditorProp;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LbCaractere;
        private System.Windows.Forms.TextBox TxtCaractere;
        private System.Windows.Forms.PictureBox PBCaractere;
        private System.Windows.Forms.Label LbAltura;
        private System.Windows.Forms.Label LBLargura;
        private System.Windows.Forms.Label LbLarguraGlifo;
        private System.Windows.Forms.NumericUpDown NLarguraGlifo;
        private System.Windows.Forms.Label LbCorecaoY;
        private System.Windows.Forms.Label LbCorecaoX;
        private System.Windows.Forms.NumericUpDown NCorecaoEixoY;
        private System.Windows.Forms.NumericUpDown NAlturaCaractere;
        private System.Windows.Forms.NumericUpDown NCorecaoEixoX;
        private System.Windows.Forms.NumericUpDown NLarguraCaractere;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbLeLarguraGlifo;
        private System.Windows.Forms.Label LbLeLargura;
        private System.Windows.Forms.ToolStripMenuItem TSSobre;
        private System.Windows.Forms.ToolStripMenuItem TsEdtGFDSobre;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSalvarGfd;
        private System.Windows.Forms.ToolStripMenuItem TSFecharGfd;
        private System.Windows.Forms.ToolStripLabel LbSalvarGfd;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label LbPrevia;
        private System.Windows.Forms.TextBox TxtPreviaInGame;
        private System.Windows.Forms.PictureBox picPreviaInGame;
        private System.Windows.Forms.Label LbBase;
        private System.Windows.Forms.TextBox txtLinhaBase;
        private System.Windows.Forms.PictureBox picCorecao;
        private System.Windows.Forms.Label LbLeLinhaBase;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label LbLeLinhaDesc;
        private System.Windows.Forms.Label LbDescendente;
        private System.Windows.Forms.TextBox TxtDescendente;
        private System.Windows.Forms.Label LbLeAltura;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

