using System;
using System.IO;

namespace EditorGfd.GFD
{
    public class PropriedadesDeGlifo : ICloneable
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
        public byte[] Finalizador { get; set; }
        public int PosicaoGlifoConvertidaX { get; set; }
        public int PosicaoGlifoConvertidaY { get; set; }

        public PropriedadesDeGlifo(BinaryReader br)
        {
            Codigo = br.ReadInt32();
            Caractere = Convert.ToChar(Codigo);
            LarguraDoCaractere = (float)Math.Floor(br.ReadSingle());
            AlturaDoCaractere = (float)Math.Floor(br.ReadSingle());
            CorrecaoX = (float)Math.Floor(br.ReadSingle());
            CorrecaoY = (float)Math.Floor(br.ReadSingle());
            LarguraDoGlifo = (float)Math.Floor(br.ReadSingle());
            LarguraMaximaGlifo = (float)Math.Floor(br.ReadSingle());
            IdTextura = br.ReadByte();
            PosicaoDoGlifo = br.ReadBytes(3);
            Padding = br.ReadByte();
            Finalizador = br.ReadBytes(3);
            int posicoes = PosicaoDoGlifo[2] << 16 | PosicaoDoGlifo[1] << 8 | PosicaoDoGlifo[0];
            PosicaoGlifoConvertidaX = posicoes & 0xFFF;
            PosicaoGlifoConvertidaY = posicoes >> 12;

        }

        public PropriedadesDeGlifo(PropriedadesDeGlifo propriedadesDeGlifo)
        {
            Codigo = propriedadesDeGlifo.Codigo;
            Caractere = propriedadesDeGlifo.Caractere;
            LarguraDoCaractere = propriedadesDeGlifo.LarguraDoCaractere;
            AlturaDoCaractere = propriedadesDeGlifo.AlturaDoCaractere;
            CorrecaoX = propriedadesDeGlifo.CorrecaoX;
            CorrecaoY = propriedadesDeGlifo.CorrecaoY;
            LarguraDoGlifo = propriedadesDeGlifo.LarguraDoGlifo;
            LarguraMaximaGlifo = propriedadesDeGlifo.LarguraMaximaGlifo;
            IdTextura = propriedadesDeGlifo.IdTextura;
            PosicaoDoGlifo = propriedadesDeGlifo.PosicaoDoGlifo;
            Padding = propriedadesDeGlifo.Padding;
            Finalizador = propriedadesDeGlifo.Finalizador;
            PosicaoGlifoConvertidaX = propriedadesDeGlifo.PosicaoGlifoConvertidaX;
            PosicaoGlifoConvertidaY = propriedadesDeGlifo.PosicaoGlifoConvertidaY;
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

        public object Clone()
        {
            return new PropriedadesDeGlifo(this);
        }
    }
}
