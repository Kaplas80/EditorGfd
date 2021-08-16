using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace EditorGfd.GFD
{
    public class Gfd
    {
        public CabecalhoGfd CabecalhoGfd { get; set; }
        public List<PropriedadesDeGlifo> PropriedadesDeGlifos { get; set; }
        public List<ImagemDeGlifo> ImagensDeGlifos { get; set; }
        public List<string> DiretoriosDeTexturas { get; set; }
        public string CaminhoDeGfd { get; set; }
        public string NomeDoGfd { get; set; }
        public Image BaseGerarPreviaInGame { get; set; }
        public Image PreviaComLinhaBaseIdividual { get; set; }

        public Gfd(string diretorioGfd)
        {
            NomeDoGfd = Path.GetFileName(diretorioGfd);
            CaminhoDeGfd = diretorioGfd;
            BinaryReader br = new BinaryReader(File.OpenRead(diretorioGfd));
            CabecalhoGfd = new CabecalhoGfd(br);

            if (CabecalhoGfd.Versao != 0x11107)
            {
                throw new ArgumentException("Versão de gfd não suportada.");
            }

            ImagensDeGlifos = new List<ImagemDeGlifo>();
            for (int i = 0; i < CabecalhoGfd.QuantidadeDeTexturas; i++)
            {
                ImagensDeGlifos.Add(new ImagemDeGlifo() { Nome = $"{Path.GetFileName(CabecalhoGfd.NomeDaTextura)}_{i:00}_ID_HQ.png" });
            }

            PropriedadesDeGlifos = new List<PropriedadesDeGlifo>();
            for (int i = 0; i < CabecalhoGfd.QuantidadeDeInformacoesCaracteres; i++)
            {
                PropriedadesDeGlifos.Add(new PropriedadesDeGlifo(br));
            }

            PropriedadesDeGlifos = PropriedadesDeGlifos.OrderBy(c => c.Codigo).ToList();
            br.Close();

            BaseGerarPreviaInGame = GerarImagensDePrevia(new Bitmap(370, 100));
            PreviaComLinhaBaseIdividual = GerarImagensDePrevia(new Bitmap(150, 150));

        }

        private Bitmap GerarImagensDePrevia(Bitmap bitmap) 
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                Pen penLinhaBase = new Pen(Color.Green);
                Pen penLinhaDescendente = new Pen(Color.Purple);
                g.DrawLine(penLinhaBase, new Point(0, (int)CabecalhoGfd.LinhaBase), new Point(bitmap.Width, (int)CabecalhoGfd.LinhaBase));
                g.DrawLine(penLinhaDescendente, new Point(0, (int)CabecalhoGfd.LinhaBase + (int)CabecalhoGfd.LinhaDescendente), new Point(bitmap.Width, (int)CabecalhoGfd.LinhaBase + (int)CabecalhoGfd.LinhaDescendente));

            }
            return bitmap;
        }

        public string SalvarGfd()
        {
            MemoryStream novoGfd = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(novoGfd);
            CabecalhoGfd.EscreverPropriedades(bw);
            //É preciso reordenar a lista pelo código, se não o gfd não funciona como deveria
            List<PropriedadesDeGlifo> copialista = PropriedadesDeGlifos.Select(x =>(PropriedadesDeGlifo)x.Clone()).OrderBy(x => x.Codigo).ToList();

            foreach (PropriedadesDeGlifo propiedades in copialista)
            {
                propiedades.EscreverPropriedades(bw);
            }

            bw.Close();
            string nomeDoGfdSemExt = NomeDoGfd.Replace(".gfd", "");
            if (!Directory.Exists(nomeDoGfdSemExt))
            {
                Directory.CreateDirectory(nomeDoGfdSemExt);
            }

            string nomeArquivoSalvo = $"{nomeDoGfdSemExt}\\{DateTime.Now:dd-MM-yyyy-HH-mm-ss}_{NomeDoGfd}";
            File.WriteAllBytes(nomeArquivoSalvo, novoGfd.ToArray());
            return nomeArquivoSalvo;

        }

        public List<string> VerificarSeDiretorioContemPngs(string diretorio)
        {
            string[] pngPaths = Directory.GetFiles(diretorio, "*.png");
            foreach (var png in ImagensDeGlifos)
            {
               string pathImg = pngPaths.FirstOrDefault(path => path.Contains(png.Nome));
                if (pathImg != null)
                {
                    png.Diretorio = pathImg;
                }

            }

            return ImagensDeGlifos.Where( t => t.Diretorio == null).Select(t => t.Nome).ToList();
        }

        public void CarregarImagens() 
        {
            foreach (var tex in ImagensDeGlifos)
            {
                tex.Imagem = new Bitmap(tex.Diretorio);
            }
        
        }

        public Bitmap ObtenhaImagemDeGlifo(PropriedadesDeGlifo propriedades) 
        {
          
            Rectangle cloneRect = new Rectangle(propriedades.PosicaoGlifoConvertidaX,propriedades.PosicaoGlifoConvertidaY,(int)propriedades.LarguraDoCaractere, (int)propriedades.AlturaDoCaractere);
            PixelFormat format = ImagensDeGlifos[propriedades.IdTextura].Imagem.PixelFormat;
      
            var bitmap = new Bitmap((int)propriedades.LarguraDoGlifo,(int)propriedades.AlturaDoCaractere, format);
            if (propriedades.LarguraDoCaractere > propriedades.LarguraDoGlifo)
            {
                bitmap = new Bitmap((int)propriedades.LarguraDoCaractere, (int)propriedades.AlturaDoCaractere, format);
            }
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(ImagensDeGlifos[propriedades.IdTextura].Imagem, 0,0, cloneRect, GraphicsUnit.Pixel);
                return bitmap;
            }

            

        }

        public string MofidifiquePropriedadesDeGlifo(string caractere, int larguraCaractere, int alturaCaractere, int larguraDoGlifo, int correcaoX, int correcaoY, PropriedadesDeGlifo propriedades)
        {
            List<string> erros = new List<string>();
            if (propriedades.Codigo == 0x20)
                caractere = " ";

            char caractereC = Convert.ToChar(caractere);

            if (string.IsNullOrEmpty(caractere) && propriedades.Codigo != 0x20)
            {
                erros.Add("O campo de caractere não pode estar vazio.");
            }         

            if (CaractereEstaPresenteNaLista(caractere, propriedades.Caractere.ToString()))
            {
                erros.Add("O caractere já está presente na lista.");
            }

            
            

            if (erros.Count == 0)
            {
                propriedades.LarguraDoCaractere = larguraCaractere;
                propriedades.AlturaDoCaractere = alturaCaractere;
                propriedades.LarguraDoGlifo = larguraDoGlifo;
                propriedades.CorrecaoX = correcaoX;
                propriedades.CorrecaoY = correcaoY;
                propriedades.Codigo = caractereC;
                propriedades.Caractere = caractereC;

            }            

            return string.Join("\r\n", erros);
        }

        private void AtualizarImagemDeGlifo(Bitmap imagemCaractere, PropriedadesDeGlifo prop ,int posicaoX, int posicaoY, int idTextura)
        {
            for (int y = posicaoY; y < posicaoY + prop.AlturaDoCaractere; y++)
            {
                for (int x = posicaoX; x < posicaoX + prop.LarguraDoGlifo; x++)
                {

                    if (x >= ImagensDeGlifos[idTextura].Imagem.Width)
                    {
                        continue;
                    }
                    ImagensDeGlifos[idTextura].Imagem.SetPixel(x,y,Color.Transparent);
                }
            }

            using (Graphics g = Graphics.FromImage(ImagensDeGlifos[idTextura].Imagem))
            {
               
              g.DrawImage(imagemCaractere, posicaoX, posicaoY);
            }


        }

        private bool CaractereEstaPresenteNaLista(string caractere, string caractereQueSeraSubistiuido) 
        {
            if (caractere != caractereQueSeraSubistiuido && PropriedadesDeGlifos.Any(p => p.Caractere.ToString() == caractere))
            {
                return true;
            }

            return false;
        }

        public Bitmap GerarImagemComTratamento(PropriedadesDeGlifo propriedade)
        {
           return GerarImagemComTratamentoComArguementos((int)propriedade.LarguraDoCaractere, (int)propriedade.AlturaDoCaractere, (int)propriedade.LarguraDoGlifo, ObtenhaImagemDeGlifo(propriedade));
           
        }

        public Bitmap GerarImagemComTratamentoComArguementos(int larguraCaractere, int alturaCaractere, int larguraDoGlifo, Bitmap imgCaractere)
        {
            if (imgCaractere != null)
            {
                Bitmap fonte = new Bitmap(imgCaractere);

                using (Graphics g = Graphics.FromImage(fonte))
                {
                    Pen penLargCarac = new Pen(Color.Red);
                    Pen penalturaCarac = new Pen(Color.Orange);
                    Pen penLargGlifo = new Pen(Color.Blue);
                    g.DrawLine(penLargCarac, new Point(0, alturaCaractere - 1), new Point(larguraCaractere - 1, alturaCaractere - 1));
                    g.DrawLine(penalturaCarac, new Point(larguraCaractere - 1, 0), new Point(larguraCaractere - 1, alturaCaractere - 1));
                    g.DrawLine(penLargGlifo, new Point(larguraDoGlifo - 1, 0), new Point(larguraDoGlifo - 1, alturaCaractere - 1));
                }

                return fonte;
            }

            return null;
        }


        public Bitmap GerarPreviaInGame(string texto, Image bitmap)
        {
            Bitmap previa = new Bitmap(bitmap);

            using (Graphics g = Graphics.FromImage(previa))
            {
                int valorX = 4;

                foreach (char letra in texto)
                {
                    PropriedadesDeGlifo pg = PropriedadesDeGlifos.Where(p => p.Caractere == letra).FirstOrDefault();

                    if (pg != null)
                    {
                        g.DrawImage(ObtenhaImagemDeGlifo(pg), valorX + pg.CorrecaoX,pg.CorrecaoY);
                        valorX += (int)pg.LarguraDoGlifo;
                    }
                }

            }


            return previa;
        }

        public Bitmap GerarPreviaComLinhaBaseIndividual(string texto,int valorCorecaoY, int valorCorecaoX, PropriedadesDeGlifo propiedade)
        {
            Bitmap previa = new Bitmap(PreviaComLinhaBaseIdividual);

            using (Graphics g = Graphics.FromImage(previa))
            {
                
                g.DrawImage(ObtenhaImagemDeGlifo(propiedade), valorCorecaoX, valorCorecaoY);                                  
            }


            return previa;
        }



    }

    public class ImagemDeGlifo
    {
        public string Nome { get; set; }
        public string Diretorio { get; set; }
        public Bitmap Imagem{ get; set; }

        public override string ToString()
        {
            return Nome; 
        }

    }

    
}
