using EditorGfd.GFD;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EditorGfd
{
    public partial class TelaEditorDeGfd : Form
    {
        private Gfd _gfd;
        private bool _foiCarregado = false;
        private Bitmap _imagemFonte;
        private bool _ehCarregamento = true;
        private bool _foiModificado = false;

        public TelaEditorDeGfd()
        {
            InitializeComponent();
            MudarEstadoFormulatio(false);
        }


        private void AbrirgfdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos .gfd (*.gfd)|*.gfd";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CarregueGfd(openFileDialog.FileName);


                }
            }
        }

        private string SelecionarPastaComTexturas()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                MessageBox.Show(this, $"Selecione a pasta contenha os seguintes arquivos png:\r\n{string.Join("\r\n", _gfd.ImagensDeGlifos)}", "Operação necessária:", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void CarregueGfd(string diretorioGfd)
        {
            _gfd = new Gfd(diretorioGfd);
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
                    this.Text = $"Editor de GFD - {Path.GetFileName(diretorioGfd)}";
                    PrepapararDataGrid();
                    _gfd.CarregarImagens();
                    PrepararFormulario();
                    _foiCarregado = true;
                    MudarEstadoFormulatio(true);
                    abrirgfdToolStripMenuItem1.Enabled = false;
                }
            }

        }

        private void EditorDeGFDPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/matheuscardoso96/EditorGfd");
        }

        private void ValorDoCampoFoiAlterado(object sender, EventArgs e)
        {
            AtualizarPreviaDeFonte();
            TxtPreviaInGame.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            PropriedadesDeGlifo propriedades = _gfd.PropriedadesDeGlifos[dgFontes.CurrentCell.RowIndex];
            int larguraCaractere = Convert.ToInt32(NLarguraCaractere.Value);
            int alturaCaractere = Convert.ToInt32(NAlturaCaractere.Value);
            int larguraDoGlifo = Convert.ToInt32(NLarguraGlifo.Value);
            int correcaoX = Convert.ToInt32(NCorecaoEixoX.Value);
            int correcaoY = Convert.ToInt32(NCorecaoEixoY.Value);
            string caractere = TxtCaractere.Text;

            string resultado = _gfd.MofidifiquePropriedadesDeGlifo(caractere, larguraCaractere, alturaCaractere, larguraDoGlifo, correcaoX, correcaoY, propriedades);
            

            if (resultado.Length > 0)
            {
                MessageBox.Show(this, resultado, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!this.Text.Contains("*"))
            {
                _foiModificado = true;
                this.Text += "*";
            }

            dgFontes.Refresh();
            TxtPreviaInGame.Enabled = true;

        }



        private void BtnSalvarGfd_Click(object sender, EventArgs e)
        {
            if (_foiCarregado)
            {
                string nomeSalvo = _gfd.SalvarGfd();
                this.Text = this.Text.Replace("*", "");
                if (!File.Exists(nomeSalvo))
                {
                    MessageBox.Show($"Não foi possível salvar o arquivo no seguinte diretório:\r\n{nomeSalvo}");
                }
                else
                {
                    MessageBox.Show($"Arquivo salvo em:\r\n{nomeSalvo}");
                }
                
            }

        }

        private void TelaEditorDeGfd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_foiModificado)
            {
                if (MessageBox.Show("Deseja sair sem salvar as modificações?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    this.Activate();

                }

            }


        }

        private void FecharGfdCarregado_Click(object sender, EventArgs e)
        {
            if (_foiModificado)
            {
                if (MessageBox.Show("Fechar gfd sem salvar as modificações?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FecharGfd();

                }

            }
            else
            {
                FecharGfd();
            }

        }



        private void MudarEstadoFormulatio(bool estado)
        {
            TxtCaractere.Enabled = estado;
            NAlturaCaractere.Enabled = estado;
            NLarguraCaractere.Enabled = estado;
            NCorecaoEixoX.Enabled = estado;
            NCorecaoEixoY.Enabled = estado;
            NLarguraGlifo.Enabled = estado;
            BtnSalvar.Enabled = estado;
            btnSalvarGfd.Enabled = estado;
            lbSalvarGfd.Enabled = estado;
            MsFecharGf.Enabled = estado;
            BtnPesquisar.Enabled = estado;
            txtPesquisa.Enabled = estado;
            txtLinhaBase.Enabled = estado;
            TxtPreviaInGame.Enabled = estado;
            TxtDescendente.Enabled = estado;
        }



        private void PrepapararDataGrid()
        {
            dgFontes.DataSource = _gfd.PropriedadesDeGlifos;
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
            dgFontes.ReadOnly = true;

        }

        private void PrepararFormulario()
        {
            NLarguraGlifo.Minimum = 1;
            NAlturaCaractere.Minimum = 1;
            NLarguraCaractere.Minimum = 1;
            NCorecaoEixoX.Minimum = -54;
            NCorecaoEixoY.Minimum = -54;
            NCorecaoEixoX.Maximum = (decimal)_gfd.CabecalhoGfd.AlturaMaximaCaractere;
            NCorecaoEixoY.Maximum = (decimal)_gfd.CabecalhoGfd.AlturaMaximaCaractere;
            txtLinhaBase.Text = _gfd.CabecalhoGfd.LinhaBase.ToString();
            TxtDescendente.Text = _gfd.CabecalhoGfd.LinhaDescendente.ToString();
            picPreviaInGame.Image = _gfd.BaseGerarPreviaInGame;
        }



        private void CarregarCamposFormulario(PropriedadesDeGlifo info)
        {
            NLarguraCaractere.Maximum = (int)info.LarguraDoCaractere;
            NAlturaCaractere.Maximum = (int)info.AlturaDoCaractere;
            NLarguraGlifo.Maximum = (int)info.LarguraDoGlifo;
            TxtCaractere.Text = $"{info.Caractere}";
            NLarguraCaractere.Value = (int)info.LarguraDoCaractere;
            NAlturaCaractere.Value = (int)info.AlturaDoCaractere;
            NCorecaoEixoX.Value = (int)info.CorrecaoX;
            NCorecaoEixoY.Value = (int)info.CorrecaoY;
            NLarguraGlifo.Value = (int)info.LarguraDoGlifo;
            _imagemFonte = _gfd.ObtenhaImagemDeGlifo(_gfd.PropriedadesDeGlifos[dgFontes.CurrentCell.RowIndex]);
            PBCaractere.Image = _gfd.GerarImagemComTratamento(info);
            PreviaComLinhaBase();
        }



        private void ModificarFonteCarregada(string dir)
        {
            Bitmap novo = new Bitmap(dir);
            if (novo.Width > _imagemFonte.Width || novo.Height > _imagemFonte.Height)
            {
                MessageBox.Show(this, "As dimenessões da imagem excedem as dimessões originais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Bitmap bitmap = new Bitmap(_imagemFonte.Width, _imagemFonte.Height);

                using (Graphics g = Graphics.FromImage(bitmap))
                {

                    g.DrawImage(novo, 0, 0);
                }

                _imagemFonte = bitmap;
                AtualizarPreviaDeFonte();
            }

        }




        public void AtualizarPreviaDeFonte()
        {
            if (!_ehCarregamento)
            {
                int larguraCaractere = Convert.ToInt32(NLarguraCaractere.Value);
                int alturaCaractere = Convert.ToInt32(NAlturaCaractere.Value);
                int larguraDoGlifo = Convert.ToInt32(NLarguraGlifo.Value);
                PBCaractere.Image = _gfd.GerarImagemComTratamentoComArguementos(larguraCaractere - 1, alturaCaractere, larguraDoGlifo, _imagemFonte);
            }
        }

       

        private void FecharGfd() 
        {
            _gfd = null;
            _foiCarregado = false;
            _imagemFonte = null;
            _ehCarregamento = true;
            _foiModificado = false;
            dgFontes.DataSource = null;
            PBCaractere.Image = null;
            NLarguraCaractere.Value = 1;
            NAlturaCaractere.Value = 1;
            NLarguraGlifo.Value = 1;
            TxtCaractere.Text = "";
            dgFontes.Refresh();
            this.Text = "Editor de GFD";
            MudarEstadoFormulatio(false);

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesquisa.Text))
            {
                char charPesquisa = Convert.ToChar(txtPesquisa.Text);
                int index = _gfd.PropriedadesDeGlifos.FindIndex(p => p.Caractere == charPesquisa);
                if (index > -1 || index ==  0 && charPesquisa == ' ')
                    dgFontes.CurrentCell = dgFontes.Rows[index].Cells[0];
                else
                {
                    MessageBox.Show($"Caractere \"{charPesquisa}\" não encontrado.");
                }
            }           
        }

        private void dgFontes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (_foiCarregado)
            {
                if (dgFontes.CurrentCell.RowIndex > -1)
                {
                    _ehCarregamento = true;
                    PropriedadesDeGlifo info = _gfd.PropriedadesDeGlifos[dgFontes.CurrentCell.RowIndex];
                    CarregarCamposFormulario(info);
                    _ehCarregamento = false;
                    TxtPreviaInGame.Enabled = true;
                }
            }
        }

        private void TxtPreviaInGame_TextChanged(object sender, EventArgs e)
        {
            GerarPreviaInGame(TxtPreviaInGame.Text);
        }

        private void GerarPreviaInGame(string texto) 
        {
          picPreviaInGame.Image =  _gfd.GerarPreviaInGame(texto, _gfd.BaseGerarPreviaInGame);
        }

        private void CorecaoEixo_ValueChanged(object sender, EventArgs e)
        {
            PreviaComLinhaBase();
            TxtPreviaInGame.Enabled = false;
        }

        private void PreviaComLinhaBase() 
        {
            PropriedadesDeGlifo info = _gfd.PropriedadesDeGlifos[dgFontes.CurrentCell.RowIndex];
            picCorecao.Image = _gfd.GerarPreviaComLinhaBaseIndividual(TxtCaractere.Text, Convert.ToInt32(NCorecaoEixoY.Value), Convert.ToInt32(NCorecaoEixoX.Value), info);
        }
    }
}
