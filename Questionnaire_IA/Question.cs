using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire_IA
{
    class Question
    {
        int numero;
        string enonce;
        List<Reponse> reponses;
        public Question (int num,string lbl,List<Reponse> reps )
        {
            numero = num;
            enonce = lbl;
            reponses = reps;
        }
    }
}
