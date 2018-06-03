using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using _00_Biblioteca;


namespace Deserializar {
    class Program {
        static void Main(string[] args) {

            StreamReader reader = new StreamReader(@"E:\Temp\Writer\writer.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Usuario));

            //Como o serializer é do tipo usuário, então podemos realizar o cast na hora de instanciar a classe usuário
            Usuario usuario = (Usuario)serializer.Deserialize(reader);

            Console.WriteLine($"{usuario.CPF}, {usuario.Nome}, {usuario.Idade}");
            Console.ReadKey();
        }
    }
}
