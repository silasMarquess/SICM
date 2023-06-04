using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using SICM.DAO;
using System.Drawing;
using System.IO;

namespace SICM.Servicos
{
    class ObjectService
    {
        public static string GenerateCodeObject<T>(T obj)
        {
            string codigo = null;
            Random rd = new Random();

           if(obj is Templo)
            {
                codigo = "IEA0000";
                bool test = ConexaoDAO.ValidateOperation(IgrejaDAO.TestCodeIgrejaExist, codigo);

                while (test)
                {
                    string numeros = rd.Next().ToString().Substring(0,4);
                    string codigoInterno = "IEA"+numeros;
                    test = ConexaoDAO.ValidateOperation(IgrejaDAO.TestCodeIgrejaExist, codigoInterno);
                    codigo = codigoInterno; 
                }

            }else if(obj is Membro)
            {

            }
            return codigo;
         }

        public static byte[] ImgToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
    }
}
