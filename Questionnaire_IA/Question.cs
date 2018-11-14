using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_IA
{
    public class Question
    {
        // Propriétés 

        public int Numero { get; set; }
        public string Enonce { get; set; }
        public List<Reponse> Reponses { get; set; }

        // Constructeurs

        public Question (int _numero, string _libelle, List<Reponse> _list_reponse)
        {
            Numero = _numero;
            Enonce = _libelle;
            Reponses = _list_reponse;
            //nb de points par question 
            //pour l'instant 20 questions à 1 point
        }

        public Question() { }

        // Méthodes

        /*public void InitializeQuestion()
        {
            //Test
            Reponse rep1 = new Reponse(1, 1, "La réponse A", true);
            Reponse rep2 = new Reponse(2, 1, "La réponse B", false);
            Reponse rep3 = new Reponse(3, 1, "Raiponce", true);
            Reponse rep4 = new Reponse(4, 1, "RIP", false);
            List<Reponse> reptiles = new List<Reponse> { rep1, rep2, rep3, rep4 };
            Question q1 = new Question(1, "La question 1", reptiles);
            Question q2 = new Question(2, "La question 2", reptiles);
            Question q = new Question(3, "La question 2", reptiles);
            List<Question> lsQuest = new List<Question> { q1, q2 };
            //lbl_num_question.Text = "Question n° " + numeroQuestion + " :";
            Random R = new Random();
            int k = R.Next(2);
            
        }*/

    }
}
