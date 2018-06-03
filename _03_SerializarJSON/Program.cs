using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _03_SerializarJSON {
    class Program {
        static void Main(string[] args) {

            Usuario usuario = new Usuario() { Nome = "Alessandro AA", CPF = "000.026.345.54", Idade = 28 };
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string serializerString = serializer.Serialize(usuario);
            StreamWriter writer = new StreamWriter(@"E:\Temp\Writer\WriterJson.json");
            //sempre que utilizar Streamwriter tem que fechar o arquivo
            writer.WriteLine(serializerString);
            writer.Flush();
            writer.Close();
        }

    }
}
