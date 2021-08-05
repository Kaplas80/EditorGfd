using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorGfd
{
    public partial class TelaEditorDeGfd : Form
    {
        private Gfd _gfd;
        private bool _foiCarregado = false;
        public TelaEditorDeGfd()
        {
            InitializeComponent();
        }


        private void AbrirgfdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos .gfd (*.gfd)|*.gfd";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                   
                     _gfd = new Gfd(openFileDialog.FileName);
                    string caminho = SelecionarPastaComTexturas();
                    if (!caminho.Contains("Operação cancelada."))
                    {
                       var texturasQueFaltam = _gfd.VerificarSeDiretorioContemPngs(caminho);
                        if (texturasQueFaltam.Count > 0)
                        {
                            MessageBox.Show(this, $"Não foram encontrado os seguintes arquivos png:\r\n{string.Join("\r\n", texturasQueFaltam)}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _gfd = null;
                            _foiCarregado = false;
                        }
                        else
                        {
                            PrepapararDataGrid();
                            _foiCarregado = true;
                            _gfd.CarregarImagens();
                            PrepararFormulario();
                        }
                    }
                   
                    
                }
            }
        }

        private string SelecionarPastaComTexturas() 
        {

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                MessageBox.Show(this,$"Selecione a pasta contenha os seguintes arquivos png:\r\n{string.Join("\r\n",_gfd.TexturasNecessarias)}","Operação necessária:", MessageBoxButtons.OK,MessageBoxIcon.Information);
                folderBrowserDialog.SelectedPath = Properties.Settings.Default.UltimaPastaSelecionada;
                SendKeys.Send("{TAB}{TAB}{RIGHT}");
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.UltimaPastaSelecionada = folderBrowserDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                    return folderBrowserDialog.SelectedPath;
                }
            }

            return "Operação cancelada.";

        }

        private void PrepapararDataGrid()
        {
            dgFontes.DataSource = _gfd.InformacoesDeCaracteres;
            this.dgFontes.Columns["PosicaoDoGlifo"].Visible = false;
            this.dgFontes.Columns["Padding"].Visible = false;
            this.dgFontes.Columns["Finalizador"].Visible = false;
            this.dgFontes.Columns["PosicaoGlifoConvertidaX"].Visible = false;
            this.dgFontes.Columns["PosicaoGlifoConvertidaY"].Visible = false;

            dgFontes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgFontes.Columns[0].HeaderText = "Código";
            dgFontes.Columns[1].HeaderText = "Caractere";
            dgFontes.Columns[2].HeaderText = "Largura do caractere";
            dgFontes.Columns[3].HeaderText = "Altura do caractere";
            dgFontes.Columns[4].HeaderText = "Correção X";
            dgFontes.Columns[5].HeaderText = "Correção Y";
            dgFontes.Columns[6].HeaderText = "Largura do glifo";
            dgFontes.Columns[7].HeaderText = "Largura máxima do glifo";
            dgFontes.Columns[8].HeaderText = "Id textura";

            //dgFontes.Columns[0].ReadOnly = true;
            //dgFontes.Columns[1].ReadOnly = true;
            //dgFontes.Columns[2].ReadOnly = true;
            //dgFontes.Columns[3].ReadOnly = true;
            //dgFontes.Columns[4].ReadOnly = true;
            //dgFontes.Columns[5].ReadOnly = true;
            //dgFontes.Columns[6].ReadOnly = true;
            //dgFontes.Columns[7].ReadOnly = true;
            dgFontes.Columns[8].ReadOnly = true;

        }

        private void PrepararFormulario() 
        {
            NLarguraCaractere.Minimum = 1;
            NAlturaCaractere.Minimum = 1;
            NCorecaoEixoX.Minimum = -54;
            NCorecaoEixoY.Minimum = -54;
            NLarguraGlifo.Minimum = 1;

            NLarguraCaractere.Maximum = (decimal)_gfd.CabecalhoGfd.AlturaMaximaCaractere;
            NAlturaCaractere.Maximum = (decimal)_gfd.CabecalhoGfd.AlturaMaximaCaractere;
            NCorecaoEixoX.Maximum = (decimal)_gfd.CabecalhoGfd.AlturaMaximaCaractere;
            NCorecaoEixoY.Maximum = (decimal)_gfd.CabecalhoGfd.AlturaMaximaCaractere;
            NLarguraGlifo.Maximum = (decimal)_gfd.CabecalhoGfd.AlturaMaximaCaractere;

        }

        private void dgFontes_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dgFontes_SelectionChanged(object sender, EventArgs e)
        {
            if (_foiCarregado)
            {
                if (dgFontes.CurrentCell.RowIndex > -1)
                {
                    InformacoesDeCaracteres info = _gfd.InformacoesDeCaracteres[dgFontes.CurrentCell.RowIndex];
                    CarregarCamposFormulario(info);
                }
            }
            
        }

        private void CarregarCamposFormulario(InformacoesDeCaracteres info) 
        {
            TxtCaractere.Text = $"{info.Caractere}";
            NLarguraCaractere.Value = (decimal)info.LarguraDoCaractere;
            NAlturaCaractere.Value = (decimal)info.AlturaDoCaractere;
            NCorecaoEixoX.Value = (decimal)info.CorrecaoX;
            NCorecaoEixoY.Value = (decimal)info.CorrecaoY;
            NLarguraGlifo.Value = (decimal)info.LarguraDoGlifo;
            PBCaractere.Image = GerarImagemComTratamento(_gfd.ObtenhaImagemDeCaracte(info), info);
        }

        private void btnExportarImagemFonte_Click(object sender, EventArgs e)
        {
            _gfd.ObtenhaImagemDeCaracte(_gfd.InformacoesDeCaracteres[dgFontes.CurrentCell.RowIndex]).Save($"{TxtCaractere.Text}.png");
        }

        private void btnImportarImagemFonte_Click(object sender, EventArgs e)
        {

        }

        private Bitmap GerarImagemComTratamento(Bitmap fonte, InformacoesDeCaracteres info) 
        {
            using (Graphics g = Graphics.FromImage(fonte))
            {
                Pen penLargCarac = new Pen(Color.Red);
                Pen penLargGlifo = new Pen(Color.Blue);
                g.DrawLine(penLargCarac, new Point(0, (int)info.AlturaDoCaractere - 1), new Point((int)info.LarguraDoCaractere - 1, (int)info.AlturaDoCaractere - 1));
                g.DrawLine(penLargCarac, new Point((int)info.LarguraDoCaractere - 1, 0), new Point((int)info.LarguraDoCaractere - 1, (int)info.AlturaDoCaractere - 1));
                g.DrawLine(penLargGlifo, new Point((int)info.LarguraDoGlifo - 1, 0), new Point((int)info.LarguraDoGlifo - 1, (int)info.AlturaDoCaractere - 1));
            }
            return fonte;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
