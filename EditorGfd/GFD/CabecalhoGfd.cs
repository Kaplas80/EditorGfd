using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EditorGfd.GFD
{
    public class CabecalhoGfd
    {
        //https://github.com/onepiecefreak3/GFDRenderer/blob/master/GFDv1v2.txt
        public string Assinatura { get; set; }
        public int Versao { get; set; }
        public int Desconhecido0 { get; set; }
        public int Desconhecido1 { get; set; }
        public int Desconhecido2 { get; set; }
        public int TamanhoDaFonte { get; set; }
        public int QuantidadeDeTexturas { get; set; }
        public long QuantidadeDeInformacoesCaracteres { get; set; }
        public int QuatidadeDeEntradasAdicionais { get; set; }
        public float LarguraMaximaCaractere { get; set; }
        public float AlturaMaximaCaractere { get; set; }
        public float LinhaBase { get; set; }
        public float LinhaDescendente { get; set; }
        public List<float> EntradasAdicionais { get; set; }
        public int TamanhoNomeDaTextura { get; set; }
        public string NomeDaTextura { get; set; }
        public byte FinalizadorDeString { get; set; }


        public CabecalhoGfd(BinaryReader br)
        {

            Assinatura = Encoding.ASCII.GetString(br.ReadBytes(4));
            if (Assinatura == "GFD\0")
            {
                EntradasAdicionais = new List<float>();
                Versao = br.ReadInt32();
                Desconhecido0 = br.ReadInt32();
                Desconhecido1 = br.ReadInt32();
                Desconhecido2 = br.ReadInt32();
                TamanhoDaFonte = br.ReadInt32();
                QuantidadeDeTexturas = br.ReadInt32();
                QuantidadeDeInformacoesCaracteres = br.ReadInt64();
                QuatidadeDeEntradasAdicionais = br.ReadInt32();
                LarguraMaximaCaractere = br.ReadSingle();
                AlturaMaximaCaractere = br.ReadSingle();
                LinhaBase = br.ReadSingle();
                LinhaDescendente = br.ReadSingle();
                for (int i = 0; i < QuatidadeDeEntradasAdicionais; i++)
                {
                    EntradasAdicionais.Add(br.ReadSingle());
                }
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
            bw.Write(TamanhoDaFonte);
            bw.Write(QuantidadeDeTexturas);
            bw.Write(QuantidadeDeInformacoesCaracteres);
            bw.Write(QuatidadeDeEntradasAdicionais);
            bw.Write(LarguraMaximaCaractere);
            bw.Write(AlturaMaximaCaractere);
            bw.Write(LinhaBase);
            bw.Write(LinhaDescendente);
            for (int i = 0; i < EntradasAdicionais.Count; i++)
            {
                bw.Write(EntradasAdicionais[i]);
            }
            bw.Write(TamanhoNomeDaTextura);
            bw.Write(Encoding.ASCII.GetBytes(NomeDaTextura));
            bw.Write(FinalizadorDeString);
        }


    }
}
