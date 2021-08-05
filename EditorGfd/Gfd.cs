using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorGfd
{
    public class Gfd
    {
        public CabecalhoGfd CabecalhoGfd { get; set; }
        public List<InformacoesDeCaracteres> InformacoesDeCaracteres { get; set; }
        public List<Png> TexturasNecessarias { get; set; }
        public List<string> DiretoriosDeTexturas { get; set; }

        public Gfd(string diretorioGfd)
        {
            BinaryReader br = new BinaryReader(File.OpenRead(diretorioGfd));
            CabecalhoGfd = new CabecalhoGfd(br);

            if (CabecalhoGfd.Versao != 0x11107)
            {
                throw new ArgumentException("Versão de gfd não suportada.");
            }

            TexturasNecessarias = new List<Png>();
            for (int i = 0; i < CabecalhoGfd.QuantidadeDeTexturas; i++)
            {
                TexturasNecessarias.Add(new Png() { Nome = $"{Path.GetFileName(CabecalhoGfd.NomeDaTextura)}_{i:00}_ID_HQ.png" });
            }

            InformacoesDeCaracteres = new List<InformacoesDeCaracteres>();
            for (int i = 0; i < CabecalhoGfd.QuantidadeDeInformacoesCaracteres; i++)
            {
                InformacoesDeCaracteres.Add(new InformacoesDeCaracteres(br));
            }


            br.Close();
        }

        public void SalvarGfd()
        {
            MemoryStream novoGfd = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(novoGfd);
            CabecalhoGfd.EscreverPropriedades(bw);
            foreach (var info in InformacoesDeCaracteres)
            {
                info.EscreverPropriedades(bw);
            }

            bw.Close();
            File.WriteAllBytes("novo.gfd", novoGfd.ToArray());

        }

        public List<string> VerificarSeDiretorioContemPngs(string diretorio)
        {
            string[] pngPaths = Directory.GetFiles(diretorio, "*.png");
            foreach (var png in TexturasNecessarias)
            {
               string pathImg = pngPaths.FirstOrDefault(path => path.Contains(png.Nome));
                if (pathImg != null)
                {
                    png.Diretorio = pathImg;
                }

            }

            return TexturasNecessarias.Where( t => t.Diretorio == null).Select(t => t.Nome).ToList();
        }

        public void CarregarImagens() 
        {
            foreach (var tex in TexturasNecessarias)
            {
                tex.FontePng = new Bitmap(tex.Diretorio);
            }
        
        }

        public Bitmap ObtenhaImagemDeCaracte(InformacoesDeCaracteres info) 
        {
          
            Rectangle cloneRect = new Rectangle(info.PosicaoGlifoConvertidaX,info.PosicaoGlifoConvertidaY,(int)info.LarguraDoCaractere, (int)info.AlturaDoCaractere);
            PixelFormat format = TexturasNecessarias[info.IdTextura].FontePng.PixelFormat;
      
            var bitmap = new Bitmap(52, 52, format);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(TexturasNecessarias[info.IdTextura].FontePng, 0,0, cloneRect, GraphicsUnit.Pixel);
                return bitmap;
            }

            

        }

        public void MoficarCaractere(InformacoesDeCaracteres info, Bitmap bitmap)
        {

            Rectangle cloneRect = new Rectangle(info.PosicaoGlifoConvertidaX, info.PosicaoGlifoConvertidaY, (int)info.LarguraDoCaractere, (int)info.AlturaDoCaractere);
            PixelFormat format = TexturasNecessarias[info.IdTextura].FontePng.PixelFormat;

            using (var g = Graphics.FromImage(TexturasNecessarias[info.IdTextura].FontePng))
            {
                g.DrawImage(bitmap, info.PosicaoGlifoConvertidaX, info.PosicaoGlifoConvertidaY, cloneRect, GraphicsUnit.Pixel);
                
            }



        }
    }

    public class Png
    {
        public string Nome { get; set; }
        public string Diretorio { get; set; }
        public Bitmap FontePng { get; set; }

        public override string ToString()
        {
            return Nome; 
        }

    }

    public class CabecalhoGfd
    {
        //https://github.com/onepiecefreak3/GFDRenderer/blob/master/GFDv1v2.txt
        public string Assinatura { get; set; }
        public int Versao { get; set; }
        public int Desconhecido0 { get; set; }
        public int Desconhecido1 { get; set; }
        public int Desconhecido2 { get; set; }
        public int Desconhecido3 { get; set; }
        public int QuantidadeDeTexturas { get; set; }
        public long QuantidadeDeInformacoesCaracteres { get; set; }
        public int Desconhecido4 { get; set; }
        public float LarguraMaximaCaractere { get; set; }
        public float AlturaMaximaCaractere { get; set; }
        public float LinhaBase { get; set; }
        public float LinhaDescendente { get; set; }
        public float Desconhecido5 { get; set; }
        public int TamanhoNomeDaTextura { get; set; }
        public string NomeDaTextura { get; set; }
        public byte FinalizadorDeString { get; set; }


        public CabecalhoGfd(BinaryReader br)
        {
            Assinatura = Encoding.ASCII.GetString(br.ReadBytes(4));
            if (Assinatura == "GFD\0")
            {
                Versao = br.ReadInt32();
                Desconhecido0 = br.ReadInt32();
                Desconhecido1 = br.ReadInt32();
                Desconhecido2 = br.ReadInt32();
                Desconhecido3 = br.ReadInt32();
                QuantidadeDeTexturas = br.ReadInt32();
                QuantidadeDeInformacoesCaracteres = br.ReadInt64();
                Desconhecido4 = br.ReadInt32();
                LarguraMaximaCaractere = br.ReadSingle();
                AlturaMaximaCaractere = br.ReadSingle();
                LinhaBase = br.ReadSingle();
                LinhaDescendente = br.ReadSingle();
                Desconhecido5 = br.ReadSingle();
                TamanhoNomeDaTextura = br.ReadInt32();
                NomeDaTextura = Encoding.ASCII.GetString(br.ReadBytes(TamanhoNomeDaTextura));
                FinalizadorDeString = br.ReadByte();
            }
            
        }

        public void EscreverPropriedades(BinaryWriter bw) 
        {
            bw.Write(Encoding.ASCII.GetBytes(Assinatura));
            bw.Write(Versao);
            bw.Write(Desconhecido0);
            bw.Write(Desconhecido1);
            bw.Write(Desconhecido2);
            bw.Write(Desconhecido3);
            bw.Write(QuantidadeDeTexturas);
            bw.Write(QuantidadeDeInformacoesCaracteres);
            bw.Write(Desconhecido4);
            bw.Write(LarguraMaximaCaractere);
            bw.Write(AlturaMaximaCaractere);
            bw.Write(LinhaBase);
            bw.Write(LinhaDescendente);
            bw.Write(Desconhecido5);
            bw.Write(TamanhoNomeDaTextura);
            bw.Write(Encoding.ASCII.GetBytes(NomeDaTextura));
            bw.Write(FinalizadorDeString);
        }


    }

    public class InformacoesDeCaracteres 
    {
        public int Codigo { get; set; }
        public char Caractere { get; set; }
        public float LarguraDoCaractere { get; set; }
        public float AlturaDoCaractere { get; set; }
        public float CorrecaoX { get; set; }
        public float CorrecaoY { get; set; }
        public float LarguraDoGlifo { get; set; }
        public float LarguraMaximaGlifo { get; set; }
        public byte IdTextura { get; set; }
        public byte[] PosicaoDoGlifo { get; set; }
        public byte Padding { get; set; }
        public byte[] Finalizador{ get; set; }
        public int PosicaoGlifoConvertidaX { get; set; }
        public int PosicaoGlifoConvertidaY { get; set; }

        public InformacoesDeCaracteres(BinaryReader br)
        {
            Codigo = br.ReadInt32();
            Caractere = Convert.ToChar(Codigo);
            LarguraDoCaractere = br.ReadSingle();
            AlturaDoCaractere = br.ReadSingle();
            CorrecaoX = br.ReadSingle();
            CorrecaoY = br.ReadSingle();
            LarguraDoGlifo = br.ReadSingle();
            LarguraMaximaGlifo = br.ReadSingle();
            IdTextura = br.ReadByte();
            PosicaoDoGlifo = br.ReadBytes(3);
            Padding = br.ReadByte();
            Finalizador = br.ReadBytes(3);
            int posicoes = PosicaoDoGlifo[2] << 16 | PosicaoDoGlifo[1]<< 8 | PosicaoDoGlifo[0];
            PosicaoGlifoConvertidaX = posicoes & 0xFFF;
            PosicaoGlifoConvertidaY = posicoes >> 12;
        }

        public void EscreverPropriedades(BinaryWriter bw)
        {
            bw.Write(Codigo);
            bw.Write(LarguraDoCaractere);
            bw.Write(AlturaDoCaractere);
            bw.Write(CorrecaoX);
            bw.Write(CorrecaoY);
            bw.Write(LarguraDoGlifo);
            bw.Write(LarguraMaximaGlifo);
            bw.Write(IdTextura);
            bw.Write(PosicaoDoGlifo);
            bw.Write(Padding);
            bw.Write(Finalizador);

        }

    }
}
