using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace SerializarXML {
    class Program {
        static void Main(string[] args) {

            //Criar um usuário declarando as 3 propriedades
            Usuario usuario = new Usuario() { Nome = "Angelo dos Santos Rocha", CPF = "142.846.377.11", Idade = 25};
            //iniciar o serializador identificando que objeto será utilizado
            XmlSerializer serializer = new XmlSerializer(typeof(Usuario));
            //iniciar a stream de escrita de arquivos
            StreamWriter writer = new StreamWriter(@"E:\Temp\Writer\writer.xml");
            //utilizar o método serialzar para gerar o arquivo xml com as propriedades.
            serializer.Serialize(writer, usuario);

        }
    }
}
