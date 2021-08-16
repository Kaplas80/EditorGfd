using EditorGfd.GFD;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Threading;
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
        private ResourceManager GerenciadorLocalizacao;

        public TelaEditorDeGfd()
        {
            InitializeComponent();
            MudarEstadoFormulatio(false);
            ObtenhaLocalizacao();
        }


        private void AbrirgfdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = GerenciadorLocalizacao.GetString("FiltroOpf");
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
                MessageBox.Show(this, $"{GerenciadorLocalizacao.GetString("MensagemAvisoDeTexturas")}\r\n{string.Join("\r\n", _gfd.ImagensDeGlifos)}", GerenciadorLocalizacao.GetString("MensagemOp"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                folderBrowserDialog.SelectedPath = Properties.Settings.Default.UltimaPastaSelecionada;
                SendKeys.Send("{TAB}{TAB}{RIGHT}");
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.UltimaPastaSelecionada = folderBrowserDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                    return folderBrowserDialog.SelectedPath;
                }
            }

            return GerenciadorLocalizacao.GetString("MensagemCancelaOp");

        }


        private void CarregueGfd(string diretorioGfd)
        {
            _gfd = new Gfd(diretorioGfd);
            string caminho = SelecionarPastaComTexturas();
            if (!caminho.Contains(GerenciadorLocalizacao.GetString("MensagemCancelaOp")))
            {
                var texturasQueFaltam = _gfd.VerificarSeDiretorioContemPngs(caminho);
                if (texturasQueFaltam.Count > 0)
                {
                    MessageBox.Show(this, $"{GerenciadorLocalizacao.GetString("MensagemTexturasNãoEncont")}:\r\n{string.Join("\r\n", texturasQueFaltam)}", GerenciadorLocalizacao.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _gfd = null;
                    _foiCarregado = false;
                }
                else
                {
                    this.Text = $"{GerenciadorLocalizacao.GetString("TituloDoForm")} - {Path.GetFileName(diretorioGfd)}";
                    PrepapararDataGrid();
                    _gfd.CarregarImagens();
                    PrepararFormulario();
                    _foiCarregado = true;
                    MudarEstadoFormulatio(true);
                    TsAbrirGfd.Enabled = false;
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
            PropriedadesDeGlifo propriedades = _gfd.PropriedadesDeGlifos[DgFontes.CurrentCell.RowIndex];
            int larguraCaractere = Convert.ToInt32(NLarguraCaractere.Value);
            int alturaCaractere = Convert.ToInt32(NAlturaCaractere.Value);
            int larguraDoGlifo = Convert.ToInt32(NLarguraGlifo.Value);
            int correcaoX = Convert.ToInt32(NCorecaoEixoX.Value);
            int correcaoY = Convert.ToInt32(NCorecaoEixoY.Value);
            string caractere = TxtCaractere.Text;

            string resultado = _gfd.MofidifiquePropriedadesDeGlifo(caractere, larguraCaractere, alturaCaractere, larguraDoGlifo, correcaoX, correcaoY, propriedades);
            

            if (resultado.Length > 0)
            {
                MessageBox.Show(this, resultado, GerenciadorLocalizacao.GetString("TituloErro"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!this.Text.Contains("*"))
            {
                _foiModificado = true;
                this.Text += "*";
            }

            DgFontes.Refresh();
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
                    MessageBox.Show($"{GerenciadorLocalizacao.GetString("MensagemErroSalvar")}\r\n{nomeSalvo}");
                }
                else
                {
                    MessageBox.Show($"{GerenciadorLocalizacao.GetString("MensagemArquivoSalvo")}\r\n{nomeSalvo}");
                }
                
            }

        }

        private void TelaEditorDeGfd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_foiModificado)
            {
                if (MessageBox.Show(GerenciadorLocalizacao.GetString("MensagemAvisoSair"), GerenciadorLocalizacao.GetString("TituloAviso"), MessageBoxButtons.YesNo) == DialogResult.No)
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
                if (MessageBox.Show(GerenciadorLocalizacao.GetString("MensagemAvisoFechar"), GerenciadorLocalizacao.GetString("TituloAviso"), MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            BtnSalvarGfd.Enabled = estado;
            LbSalvarGfd.Enabled = estado;
            TSFecharGfd.Enabled = estado;
            BtnPesquisar.Enabled = estado;
            txtPesquisa.Enabled = estado;
            txtLinhaBase.Enabled = estado;
            TxtPreviaInGame.Enabled = estado;
            TxtDescendente.Enabled = estado;
        }



        private void PrepapararDataGrid()
        {
            DgFontes.DataSource = _gfd.PropriedadesDeGlifos;
            this.DgFontes.Columns["PosicaoDoGlifo"].Visible = false;
            this.DgFontes.Columns["Padding"].Visible = false;
            this.DgFontes.Columns["Finalizador"].Visible = false;
            this.DgFontes.Columns["PosicaoGlifoConvertidaX"].Visible = false;
            this.DgFontes.Columns["PosicaoGlifoConvertidaY"].Visible = false;
            this.DgFontes.Columns["LarguraMaximaGlifo"].Visible = false;
            DgFontes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DgFontes.Columns[0].HeaderText =GerenciadorLocalizacao.GetString("DatagridColCodigo");
            DgFontes.Columns[1].HeaderText = GerenciadorLocalizacao.GetString("DatagridColCaractere");
            DgFontes.Columns[2].HeaderText = GerenciadorLocalizacao.GetString("DatagridColLargura");
            DgFontes.Columns[3].HeaderText = GerenciadorLocalizacao.GetString("DatagridColAltura");
            DgFontes.Columns[4].HeaderText = GerenciadorLocalizacao.GetString("DatagridColCorrecaoX");
            DgFontes.Columns[5].HeaderText = GerenciadorLocalizacao.GetString("DatagridColCorrecaoY");
            DgFontes.Columns[6].HeaderText = GerenciadorLocalizacao.GetString("DatagridColLgGlifo");
           // DgFontes.Columns[7].HeaderText = GerenciadorLocalizacao.GetString("DatagridColMaxLgGlifo");
            DgFontes.Columns[7].HeaderText = GerenciadorLocalizacao.GetString("DatagridColIdTextura");
            DgFontes.ReadOnly = true;

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
            NLarguraGlifo.Maximum = 99;
            TxtCaractere.Text = $"{info.Caractere}";
            NLarguraCaractere.Value = (int)info.LarguraDoCaractere;
            NAlturaCaractere.Value = (int)info.AlturaDoCaractere;
            NCorecaoEixoX.Value = (int)info.CorrecaoX;
            NCorecaoEixoY.Value = (int)info.CorrecaoY;
            NLarguraGlifo.Value = (int)info.LarguraDoGlifo;
            _imagemFonte = _gfd.ObtenhaImagemDeGlifo(_gfd.PropriedadesDeGlifos[DgFontes.CurrentCell.RowIndex]);
            PBCaractere.Image = _gfd.GerarImagemComTratamento(info);
            PreviaComLinhaBase();
        }


        public void AtualizarPreviaDeFonte()
        {
            if (!_ehCarregamento)
            {
                int larguraCaractere = Convert.ToInt32(NLarguraCaractere.Value);
                int alturaCaractere = Convert.ToInt32(NAlturaCaractere.Value);
                int larguraDoGlifo = Convert.ToInt32(NLarguraGlifo.Value);
                PBCaractere.Image = _gfd.GerarImagemComTratamentoComArguementos(larguraCaractere, alturaCaractere, larguraDoGlifo, _imagemFonte);
            }
        }

       

        private void FecharGfd() 
        {
            _gfd = null;
            _foiCarregado = false;
            _imagemFonte = null;
            _ehCarregamento = true;
            _foiModificado = false;
            DgFontes.DataSource = null;
            PBCaractere.Image = null;
            NLarguraCaractere.Value = 1;
            NAlturaCaractere.Value = 1;
            NLarguraGlifo.Value = 1;
            TxtCaractere.Text = "";
            DgFontes.Refresh();
            this.Text = GerenciadorLocalizacao.GetString("TituloDoForm");
            MudarEstadoFormulatio(false);

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPesquisa.Text))
            {
                char charPesquisa = Convert.ToChar(txtPesquisa.Text);
                int index = _gfd.PropriedadesDeGlifos.FindIndex(p => p.Caractere == charPesquisa);
                if (index > -1 || index ==  0 && charPesquisa == ' ')
                    DgFontes.CurrentCell = DgFontes.Rows[index].Cells[0];
                else
                {
                    MessageBox.Show($"{GerenciadorLocalizacao.GetString("MensagemCaracNaoEncoPt1")} \"{charPesquisa}\" {GerenciadorLocalizacao.GetString("MensagemNaoEcontrado")}");
                }
            }           
        }

        private void DgFontes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (_foiCarregado)
            {
                if (DgFontes.CurrentCell.RowIndex > -1)
                {
                    _ehCarregamento = true;
                    PropriedadesDeGlifo info = _gfd.PropriedadesDeGlifos[DgFontes.CurrentCell.RowIndex];
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
            PropriedadesDeGlifo info = _gfd.PropriedadesDeGlifos[DgFontes.CurrentCell.RowIndex];
            picCorecao.Image = _gfd.GerarPreviaComLinhaBaseIndividual(TxtCaractere.Text, Convert.ToInt32(NCorecaoEixoY.Value), Convert.ToInt32(NCorecaoEixoX.Value), info);
        }

        private void ObtenhaLocalizacao()
        {
            if (CultureInfo.CurrentCulture.Name.Contains("pt-BR"))
                GerenciadorLocalizacao = new ResourceManager("EditorGfd.Properties.Localizacao_PT_BR",typeof(TelaEditorDeGfd).Assembly);                            
            else
                GerenciadorLocalizacao = new ResourceManager("EditorGfd.Properties.Localizacao_EN",typeof(TelaEditorDeGfd).Assembly);          
            
            AplicarLocaolizaoNosComponentes();

        }

        private void AplicarLocaolizaoNosComponentes() 
        {
            Gfd.MensagemDeValidacaoDeVersao = GerenciadorLocalizacao.GetString("MensagemGfdNaoSuportado");
            Gfd.MensagemDeValidacaoVazio = GerenciadorLocalizacao.GetString("MensagemCampoVazio");
            Gfd.MensagemDeValidacaoNaLista = GerenciadorLocalizacao.GetString("MensagemCaracJaExiste");
            this.Text = GerenciadorLocalizacao.GetString("TituloDoForm");
            TSGfd.Text = GerenciadorLocalizacao.GetString("TsGfd");
            TsAbrirGfd.Text = GerenciadorLocalizacao.GetString("TsAbrirGfd");
            TSFecharGfd.Text = GerenciadorLocalizacao.GetString("TSFecharGfd");
            TSSobre.Text = GerenciadorLocalizacao.GetString("TSSobre");
            TsEdtGFDSobre.Text = GerenciadorLocalizacao.GetString("TsEdtGFDSobre");
            LbSalvarGfd.Text = GerenciadorLocalizacao.GetString("LbSalvarGfd");
            LbTitulo.Text = GerenciadorLocalizacao.GetString("LbTitulo");
            BtnPesquisar.Text = GerenciadorLocalizacao.GetString("BtnPesquisar");
            LbTituloEditorProp.Text = GerenciadorLocalizacao.GetString("LbTituloEditorProp");
            LbCaractere.Text = GerenciadorLocalizacao.GetString("LbCaractere");
            LbAltura.Text = GerenciadorLocalizacao.GetString("LbAltura");
            LBLargura.Text = GerenciadorLocalizacao.GetString("LbLargura");
            LbCorecaoX.Text = GerenciadorLocalizacao.GetString("LbCorecaoX");
            LbCorecaoY.Text = GerenciadorLocalizacao.GetString("LbCorecaoY");
            LbLarguraGlifo.Text = GerenciadorLocalizacao.GetString("LbLarguraGlifo");
            LbLeLargura.Text = GerenciadorLocalizacao.GetString("LbLeLargura");
            LbLeAltura.Text = GerenciadorLocalizacao.GetString("LbLeAltura");
            LbLeLarguraGlifo.Text = GerenciadorLocalizacao.GetString("LbLeLarguraGlifo");
            LbLeLinhaBase.Text = GerenciadorLocalizacao.GetString("LbLeLinhaBase");
            LbLeLinhaDesc.Text = GerenciadorLocalizacao.GetString("LbLeLinhaDesc");
            LbPrevia.Text = GerenciadorLocalizacao.GetString("LbPrevia");
            LbBase.Text = GerenciadorLocalizacao.GetString("LbBase");
            LbDescendente.Text = GerenciadorLocalizacao.GetString("LbDescendente");
            BtnSalvar.Text = GerenciadorLocalizacao.GetString("BtnSalvar");           
        }
   
    }
}
