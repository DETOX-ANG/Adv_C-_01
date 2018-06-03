using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using _00_Biblioteca;

namespace _04_DeserializarJSON {
    class Program {
        static void Main(string[] args) {

            StreamReader reader = new StreamReader(@"E:\Temp\Writer\WriterJson.json");
            string jsondata = reader.ReadToEnd();

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            

            Usuario usuario = (Usuario) serializer.Deserialize(jsondata, typeof(Usuario));

            Console.WriteLine($"{usuario.CPF}, {usuario.Nome}, {usuario.Idade}");
            Console.ReadKey();
        }
    }
}
