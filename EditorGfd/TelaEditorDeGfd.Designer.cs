
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
            this.dgFontes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirgfdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirgfdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PBCaractere = new System.Windows.Forms.PictureBox();
            this.TxtCaractere = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NLarguraGlifo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.NLarguraCaractere = new System.Windows.Forms.NumericUpDown();
            this.NCorecaoEixoX = new System.Windows.Forms.NumericUpDown();
            this.NAlturaCaractere = new System.Windows.Forms.NumericUpDown();
            this.NCorecaoEixoY = new System.Windows.Forms.NumericUpDown();
            this.btnImportarImagemFonte = new System.Windows.Forms.Button();
            this.btnExportarImagemFonte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFontes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCaractere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NLarguraGlifo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NLarguraCaractere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCorecaoEixoX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAlturaCaractere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCorecaoEixoY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.dgFontes.SelectionChanged += new System.EventHandler(this.dgFontes_SelectionChanged);
            this.dgFontes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgFontes_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirgfdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "MSOpcoes";
            // 
            // abrirgfdToolStripMenuItem
            // 
            this.abrirgfdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirgfdToolStripMenuItem1});
            this.abrirgfdToolStripMenuItem.Name = "abrirgfdToolStripMenuItem";
            this.abrirgfdToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.abrirgfdToolStripMenuItem.Text = "Gfd";
            // 
            // abrirgfdToolStripMenuItem1
            // 
            this.abrirgfdToolStripMenuItem1.Name = "abrirgfdToolStripMenuItem1";
            this.abrirgfdToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.abrirgfdToolStripMenuItem1.Text = "Abrir arquivo .gfd";
            this.abrirgfdToolStripMenuItem1.Click += new System.EventHandler(this.AbrirgfdToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgFontes);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 453);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(497, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propriedades de caracteres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 32);
            this.panel2.TabIndex = 2;
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
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.BtnSalvar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtCaractere);
            this.panel3.Controls.Add(this.PBCaractere);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(12, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1240, 181);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(23, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1175, 32);
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
            // PBCaractere
            // 
            this.PBCaractere.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PBCaractere.Location = new System.Drawing.Point(882, 71);
            this.PBCaractere.Name = "PBCaractere";
            this.PBCaractere.Size = new System.Drawing.Size(100, 96);
            this.PBCaractere.TabIndex = 1;
            this.PBCaractere.TabStop = false;
            // 
            // TxtCaractere
            // 
            this.TxtCaractere.Location = new System.Drawing.Point(23, 95);
            this.TxtCaractere.Name = "TxtCaractere";
            this.TxtCaractere.Size = new System.Drawing.Size(140, 20);
            this.TxtCaractere.TabIndex = 2;
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
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(23, 144);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(907, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Imagem";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Altura";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Correção relativa Eixo Y";
            // 
            // NLarguraGlifo
            // 
            this.NLarguraGlifo.Location = new System.Drawing.Point(575, 95);
            this.NLarguraGlifo.Name = "NLarguraGlifo";
            this.NLarguraGlifo.Size = new System.Drawing.Size(120, 20);
            this.NLarguraGlifo.TabIndex = 14;
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
            // NLarguraCaractere
            // 
            this.NLarguraCaractere.Location = new System.Drawing.Point(199, 96);
            this.NLarguraCaractere.Name = "NLarguraCaractere";
            this.NLarguraCaractere.Size = new System.Drawing.Size(120, 20);
            this.NLarguraCaractere.TabIndex = 16;
            // 
            // NCorecaoEixoX
            // 
            this.NCorecaoEixoX.Location = new System.Drawing.Point(365, 96);
            this.NCorecaoEixoX.Name = "NCorecaoEixoX";
            this.NCorecaoEixoX.Size = new System.Drawing.Size(120, 20);
            this.NCorecaoEixoX.TabIndex = 17;
            // 
            // NAlturaCaractere
            // 
            this.NAlturaCaractere.Location = new System.Drawing.Point(199, 147);
            this.NAlturaCaractere.Name = "NAlturaCaractere";
            this.NAlturaCaractere.Size = new System.Drawing.Size(120, 20);
            this.NAlturaCaractere.TabIndex = 18;
            // 
            // NCorecaoEixoY
            // 
            this.NCorecaoEixoY.Location = new System.Drawing.Point(365, 144);
            this.NCorecaoEixoY.Name = "NCorecaoEixoY";
            this.NCorecaoEixoY.Size = new System.Drawing.Size(120, 20);
            this.NCorecaoEixoY.TabIndex = 19;
            // 
            // btnImportarImagemFonte
            // 
            this.btnImportarImagemFonte.Location = new System.Drawing.Point(801, 144);
            this.btnImportarImagemFonte.Name = "btnImportarImagemFonte";
            this.btnImportarImagemFonte.Size = new System.Drawing.Size(75, 23);
            this.btnImportarImagemFonte.TabIndex = 20;
            this.btnImportarImagemFonte.Text = "Importar";
            this.btnImportarImagemFonte.UseVisualStyleBackColor = true;
            this.btnImportarImagemFonte.Click += new System.EventHandler(this.btnImportarImagemFonte_Click);
            // 
            // btnExportarImagemFonte
            // 
            this.btnExportarImagemFonte.Location = new System.Drawing.Point(801, 92);
            this.btnExportarImagemFonte.Name = "btnExportarImagemFonte";
            this.btnExportarImagemFonte.Size = new System.Drawing.Size(75, 23);
            this.btnExportarImagemFonte.TabIndex = 21;
            this.btnExportarImagemFonte.Text = "Exportar";
            this.btnExportarImagemFonte.UseVisualStyleBackColor = true;
            this.btnExportarImagemFonte.Click += new System.EventHandler(this.btnExportarImagemFonte_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumBlue;
            this.pictureBox2.Location = new System.Drawing.Point(1009, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 32);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1044, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Largura do glifo";
            // 
            // TelaEditorDeGfd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaEditorDeGfd";
            this.Text = "Editor de GFD";
            ((System.ComponentModel.ISupportInitialize)(this.dgFontes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBCaractere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NLarguraGlifo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NLarguraCaractere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCorecaoEixoX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NAlturaCaractere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NCorecaoEixoY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label4;
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
    }
}

