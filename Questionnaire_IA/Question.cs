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
        

    }
}
