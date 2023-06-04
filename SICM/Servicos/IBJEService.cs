using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace SICM.Servicos
{
  public class Regiao
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Sigla { get; set; }
    }

    public class UF
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public Regiao Regiao { get; set; }
    }

   public class Mesorregiao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public UF Uf { get; set; }
    }

   public  class Microrregiao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Mesorregiao Mesorregiao { get; set; }
    }

   public  class Municipio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Microrregiao Microrregiao { get; set; }

        public static List<Municipio> GetListaMunicipios()
        {
            string urlServico = "https://servicodados.ibge.gov.br/api/v1/localidades/municipios";
            string Json = new WebClient().DownloadString(urlServico);

            List<Municipio> lista = JsonConvert.DeserializeObject<List<Municipio>>(Json);
            lista.ForEach(Charcter);
            return lista;
        }

        private static void Charcter(Municipio mun)
        {
            mun.Nome = MudarFormatoCaracter(mun.Nome);
            mun.Microrregiao.Mesorregiao.Uf.Nome = MudarFormatoCaracter(mun.Microrregiao.Mesorregiao.Uf.Nome);
        }
        

        private static  string MudarFormatoCaracter(string valor)
        {
            Encoding iso = Encoding.GetEncoding("ISO-8859-1");
            Encoding utf8 = Encoding.UTF8;

            byte[] UtfByte = utf8.GetBytes(valor);
            byte[] isobyte = Encoding.Convert(utf8, iso, UtfByte);

            string textoIso = utf8.GetString(isobyte);
            return textoIso;
        }
    }


}
