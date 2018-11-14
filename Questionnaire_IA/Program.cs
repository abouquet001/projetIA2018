using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Questionnaire_IA
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        ///[STAThread]
        static void Main()
        {

            StreamReader reader = new StreamReader("C:\\Users\\Antoine\\Documents\\ENSC\\2A\\IA\\ProjetIA2018\\Questionnaire_IA\\questions.xml");
            List<Question> questions = (List<Question>)new XmlSerializer(typeof(List<Question>)).Deserialize(reader);
            reader.Close();
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormQuestion());

           
            /* Reponse rep1 = new Reponse();
             Reponse rep2 = new Reponse();
             List<Reponse> reps = new List<Reponse> { rep1, rep2 };
             Question q1 = new Question(1, "Qui etes vous ?", reps);
             List<Question> questions = new List<Question> { q1 };
             StreamWriter writer = new StreamWriter("questions.xml");
             new XmlSerializer(typeof(List<Question>)).Serialize(writer, questions);
             writer.Close();*/

            //Test
            /*
            Reponse rep1 = new Reponse(1, 1, "La réponse A", true);
            Reponse rep2 = new Reponse(2, 1, "La réponse B", false);
            Reponse rep3 = new Reponse(3, 1, "Raiponce", true);
            Reponse rep4 = new Reponse(4, 1, "RIP", false);
            List<Reponse> reptiles = new List<Reponse> { rep1, rep2, rep3, rep4 };
            Question q1 = new Question(1, "La question 1", reptiles);
            Question q2 = new Question(2, "La question 2", reptiles);
            Question q = new Question(3, "La question 2", reptiles);
            List<Question> lsQuest = new List<Question> { q1, q2 };
            lbl_num_question.Text = "Question n° " + numeroQuestion + " :";
            Random R = new Random();
            int k = R.Next(2);*/


        }
    }
}
