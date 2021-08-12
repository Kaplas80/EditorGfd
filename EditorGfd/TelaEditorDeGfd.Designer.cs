
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
            this.dgFontes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirgfdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirgfdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MsFecharGf = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeGFDPorMatheusAbreuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExportarImagemFonte = new System.Windows.Forms.Button();
            this.btnImportarImagemFonte = new System.Windows.Forms.Button();
            this.NCorecaoEixoY = new System.Windows.Forms.NumericUpDown();
            this.NAlturaCaractere = new System.Windows.Forms.NumericUpDown();
            this.NCorecaoEixoX = new System.Windows.Forms.NumericUpDown();
            this.NLarguraCaractere = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.NLarguraGlifo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCaractere = new System.Windows.Forms.TextBox();
            this.PBCaractere = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalvarGfd = new System.Windows.Forms.ToolStripButton();
            this.lbSalvarGfd = new System.Windows.Forms.ToolStripLabel();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFontes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // dgFontes
            // 
            this.dgFontes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFontes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFontes.Location = new System.Drawing.Point(23, 58);
            this.dgFontes.Name = "dgFontes";
            this.dgFontes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFontes.Size = new System.Drawing.Size(1175, 349);
            this.dgFontes.TabIndex = 0;
            this.dgFontes.CurrentCellChanged += new System.EventHandler(this.dgFontes_CurrentCellChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirgfdToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "MSOpcoes";
            // 
            // abrirgfdToolStripMenuItem
            // 
            this.abrirgfdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirgfdToolStripMenuItem1,
            this.MsFecharGf});
            this.abrirgfdToolStripMenuItem.Name = "abrirgfdToolStripMenuItem";
            this.abrirgfdToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.abrirgfdToolStripMenuItem.Text = "Gfd";
            // 
            // abrirgfdToolStripMenuItem1
            // 
            this.abrirgfdToolStripMenuItem1.Name = "abrirgfdToolStripMenuItem1";
            this.abrirgfdToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.abrirgfdToolStripMenuItem1.Text = "Abrir arquivo .gfd";
            this.abrirgfdToolStripMenuItem1.Click += new System.EventHandler(this.AbrirgfdToolStripMenuItem1_Click);
            // 
            // MsFecharGf
            // 
            this.MsFecharGf.Enabled = false;
            this.MsFecharGf.Name = "MsFecharGf";
            this.MsFecharGf.Size = new System.Drawing.Size(167, 22);
            this.MsFecharGf.Text = "Fechar .gfd";
            this.MsFecharGf.Visible = false;
            this.MsFecharGf.Click += new System.EventHandler(this.FecharGfdCarregado_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorDeGFDPorMatheusAbreuToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // editorDeGFDPorMatheusAbreuToolStripMenuItem
            // 
            this.editorDeGFDPorMatheusAbreuToolStripMenuItem.Name = "editorDeGFDPorMatheusAbreuToolStripMenuItem";
            this.editorDeGFDPorMatheusAbreuToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.editorDeGFDPorMatheusAbreuToolStripMenuItem.Text = "Editor de GFD v0.5 por Matheus Abreu";
            this.editorDeGFDPorMatheusAbreuToolStripMenuItem.Click += new System.EventHandler(this.EditorDeGFDPorToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.BtnPesquisar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgFontes);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 446);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 32);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(497, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propriedades de caracteres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnExportarImagemFonte);
            this.panel3.Controls.Add(this.btnImportarImagemFonte);
            this.panel3.Controls.Add(this.NCorecaoEixoY);
            this.panel3.Controls.Add(this.NAlturaCaractere);
            this.panel3.Controls.Add(this.NCorecaoEixoX);
            this.panel3.Controls.Add(this.NLarguraCaractere);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.NLarguraGlifo);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.BtnSalvar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtCaractere);
            this.panel3.Controls.Add(this.PBCaractere);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 502);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 201);
            this.panel3.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1044, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Largura do glifo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1044, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Largura do caractere";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumBlue;
            this.pictureBox2.Location = new System.Drawing.Point(1009, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(1009, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnExportarImagemFonte
            // 
            this.btnExportarImagemFonte.Enabled = false;
            this.btnExportarImagemFonte.Location = new System.Drawing.Point(740, 92);
            this.btnExportarImagemFonte.Name = "btnExportarImagemFonte";
            this.btnExportarImagemFonte.Size = new System.Drawing.Size(75, 23);
            this.btnExportarImagemFonte.TabIndex = 21;
            this.btnExportarImagemFonte.Text = "Exportar";
            this.btnExportarImagemFonte.UseVisualStyleBackColor = true;
            this.btnExportarImagemFonte.Visible = false;
            this.btnExportarImagemFonte.Click += new System.EventHandler(this.BtnExportarImagemFonte_Click);
            // 
            // btnImportarImagemFonte
            // 
            this.btnImportarImagemFonte.Enabled = false;
            this.btnImportarImagemFonte.Location = new System.Drawing.Point(740, 141);
            this.btnImportarImagemFonte.Name = "btnImportarImagemFonte";
            this.btnImportarImagemFonte.Size = new System.Drawing.Size(75, 23);
            this.btnImportarImagemFonte.TabIndex = 20;
            this.btnImportarImagemFonte.Text = "Importar";
            this.btnImportarImagemFonte.UseVisualStyleBackColor = true;
            this.btnImportarImagemFonte.Visible = false;
            this.btnImportarImagemFonte.Click += new System.EventHandler(this.BtnImportarImagemFonte_Click);
            // 
            // NCorecaoEixoY
            // 
            this.NCorecaoEixoY.Location = new System.Drawing.Point(365, 144);
            this.NCorecaoEixoY.Name = "NCorecaoEixoY";
            this.NCorecaoEixoY.Size = new System.Drawing.Size(120, 20);
            this.NCorecaoEixoY.TabIndex = 19;
            // 
            // NAlturaCaractere
            // 
            this.NAlturaCaractere.Location = new System.Drawing.Point(199, 147);
            this.NAlturaCaractere.Name = "NAlturaCaractere";
            this.NAlturaCaractere.Size = new System.Drawing.Size(120, 20);
            this.NAlturaCaractere.TabIndex = 18;
            this.NAlturaCaractere.ValueChanged += new System.EventHandler(this.ValorDoCampoFoiAlterado);
            // 
            // NCorecaoEixoX
            // 
            this.NCorecaoEixoX.Location = new System.Drawing.Point(365, 96);
            this.NCorecaoEixoX.Name = "NCorecaoEixoX";
            this.NCorecaoEixoX.Size = new System.Drawing.Size(120, 20);
            this.NCorecaoEixoX.TabIndex = 17;
            // 
            // NLarguraCaractere
            // 
            this.NLarguraCaractere.Location = new System.Drawing.Point(199, 96);
            this.NLarguraCaractere.Name = "NLarguraCaractere";
            this.NLarguraCaractere.Size = new System.Drawing.Size(120, 20);
            this.NLarguraCaractere.TabIndex = 16;
            this.NLarguraCaractere.ValueChanged += new System.EventHandler(this.ValorDoCampoFoiAlterado);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(572, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Largura do glifo";
            // 
            // NLarguraGlifo
            // 
            this.NLarguraGlifo.Location = new System.Drawing.Point(575, 95);
            this.NLarguraGlifo.Name = "NLarguraGlifo";
            this.NLarguraGlifo.Size = new System.Drawing.Size(120, 20);
            this.NLarguraGlifo.TabIndex = 14;
            this.NLarguraGlifo.ValueChanged += new System.EventHandler(this.ValorDoCampoFoiAlterado);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Correção relativa Eixo Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Correção relativa Eixo X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Altura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Largura";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(23, 144);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caractere";
            // 
            // TxtCaractere
            // 
            this.TxtCaractere.Location = new System.Drawing.Point(23, 95);
            this.TxtCaractere.MaxLength = 1;
            this.TxtCaractere.Name = "TxtCaractere";
            this.TxtCaractere.Size = new System.Drawing.Size(140, 20);
            this.TxtCaractere.TabIndex = 2;
            // 
            // PBCaractere
            // 
            this.PBCaractere.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PBCaractere.Location = new System.Drawing.Point(835, 34);
            this.PBCaractere.Name = "PBCaractere";
            this.PBCaractere.Size = new System.Drawing.Size(151, 151);
            this.PBCaractere.TabIndex = 1;
            this.PBCaractere.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(23, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1175, 24);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(492, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Editor de propriedades";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvarGfd,
            this.lbSalvarGfd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalvarGfd
            // 
            this.btnSalvarGfd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvarGfd.Image = global::EditorGfd.Properties.Resources.SaveStatusBar1_16x;
            this.btnSalvarGfd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarGfd.Name = "btnSalvarGfd";
            this.btnSalvarGfd.Size = new System.Drawing.Size(23, 22);
            this.btnSalvarGfd.Text = "toolStripButton1";
            this.btnSalvarGfd.Click += new System.EventHandler(this.BtnSalvarGfd_Click);
            // 
            // lbSalvarGfd
            // 
            this.lbSalvarGfd.Name = "lbSalvarGfd";
            this.lbSalvarGfd.Size = new System.Drawing.Size(112, 22);
            this.lbSalvarGfd.Text = "Salvar modificações";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(23, 414);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 3;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(104, 414);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(157, 20);
            this.txtPesquisa.TabIndex = 4;
            // 
            // TelaEditorDeGfd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaEditorDeGfd";
            this.Text = "Editor de GFD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaEditorDeGfd_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgFontes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgFontes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirgfdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirgfdToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCaractere;
        private System.Windows.Forms.PictureBox PBCaractere;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NLarguraGlifo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NCorecaoEixoY;
        private System.Windows.Forms.NumericUpDown NAlturaCaractere;
        private System.Windows.Forms.NumericUpDown NCorecaoEixoX;
        private System.Windows.Forms.NumericUpDown NLarguraCaractere;
        private System.Windows.Forms.Button btnExportarImagemFonte;
        private System.Windows.Forms.Button btnImportarImagemFonte;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeGFDPorMatheusAbreuToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvarGfd;
        private System.Windows.Forms.ToolStripMenuItem MsFecharGf;
        private System.Windows.Forms.ToolStripLabel lbSalvarGfd;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button BtnPesquisar;
    }
}

