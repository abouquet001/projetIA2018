using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions = new List<Question>();
            Reponse r1 = new Reponse()
            {
                Juste = true,
                Numero = 1,
                NumQuestion = 1,
                Intitule = "Bonjour"
            };
            Reponse r2 = new Reponse()
            {
                Juste = false,
                Numero = 2,
                NumQuestion = 1,
                Intitule = "Au revoir"
            };
            Reponse r3 = new Reponse()
            {
                Juste = false,
                Numero = 3,
                NumQuestion = 1,
                Intitule = "Au revoir"
            };
            Reponse r4 = new Reponse()
            {
                Juste = false,
                Numero = 4,
                NumQuestion = 1,
                Intitule = "Au revoi"
            };
            Question q1 = new Question()
            {
                Numero = 1,
                Enonce = "Quel reponse veut dire bonjour ?",
                Reponses = new List<Reponse> { r1, r2, r3, r4 }
            };
            questions.Add(q1);
            XmlSerializer xs = new XmlSerializer(typeof(List<Question>));
            using (StreamWriter wr = new StreamWriter("E:\\Documents\\ENSC\\2A\\projetIA2018\\Questionnaire_IA\\questions.xml"))
            //"C:\\Users\\Antoine\\Documents\\ENSC\\2A\\IA\\ProjetIA2018\\Questionnaire_IA\\questions.xml"
            //E:\Documents\ENSC\2A\projetIA2018
            {
                xs.Serialize(wr, questions);
            }
        }
    }
}
