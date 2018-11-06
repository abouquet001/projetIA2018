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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormQuest());

            Reponse rep1 = new Reponse();
            Reponse rep2 = new Reponse();
            List<Reponse> reps = new List<Reponse> { rep1, rep2 };
            Question q1 = new Question(1, "Qui etes vous ?", reps);
            List<Question> questions = new List<Question> { q1 };
            StreamWriter writer = new StreamWriter("questions.xml");
            new XmlSerializer(typeof(List<Question>)).Serialize(writer, questions);
            writer.Close();
        }
    }
}
