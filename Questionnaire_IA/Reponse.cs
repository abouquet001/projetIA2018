using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_IA
{
    public class Reponse
    {
        // Propriétés

        public int Numero { get; set; }
        public int NumQuestion { get; set; }
        public string Intitule { get; set; }
        public bool Juste { get; set; }

        // Constructeurs 

        public Reponse(int _numero, int _numQuestion, string _intitule, bool _juste)
        {
            Numero = _numero;
            NumQuestion = _numQuestion;
            Intitule = _intitule;
            Juste = _juste;
        }

        public Reponse() { }

        // Méthodes

    }
}
