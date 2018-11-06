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

        int Numero { get; set; }
        string Enonce { get; set; }
        List<Reponse> Reponses { get; set; }

        // Constructeurs

        public Question (int _numero,string _libelle,List<Reponse> _list_reponse )
        {
            Numero = _numero;
            Enonce = _libelle;
            Reponses = _list_reponse;
        }

        public Question() { }

        // Méthodes



    }
}
