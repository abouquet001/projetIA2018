using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire_IA
{
    public partial class FormQuestion : Form
    {
        //Déclarations

        static int numeroQuestion = 1;
        Random R = new Random();
        List<Question> lsQuestion = new List<Question> { };


        public FormQuestion()
        {

            InitializeComponent();
            InitializeQuestion();

        }


        //Méthodes

        private void InitializeQuestion()
        {
            //Test
            Reponse rep1 = new Reponse(1, 1, "La réponse A", true);
            Reponse rep2 = new Reponse(2, 1, "La réponse B", false);
            Reponse rep3 = new Reponse(3, 1, "Raiponce", true);
            Reponse rep4 = new Reponse(4, 1, "RIP", false);
            List<Reponse> reptiles = new List<Reponse> { rep1, rep2, rep3, rep4 };
            Question q1 = new Question(1, "La question 1", reptiles);
            Question q2 = new Question(2, "La question 2", reptiles);
            Question q3 = new Question(3, "La question 3", reptiles);
            Reponse repA = new Reponse(1, 4, "A.en I.A. pour jouer à deux contre un adversaire.", false);
            Reponse repB = new Reponse(2, 4, "B.en I.A.pour trouver le plus court chemin dans un graphe.", true);
            Reponse repC = new Reponse(3, 4, "C.en reconnaissance des formes pour détecter un isomorphisme de graphe.", false);
            Reponse repD = new Reponse(4, 4, "D.pour la détection de contours en vision par ordinateur", false);
            List<Reponse> lsRep = new List<Reponse> { repA, repB, repC, repD };
            Question q4 = new Question(4, "L’algorithme MinMax est utilisé :", lsRep);
            List<Question> lsQuest = new List<Question> { q1, q2, q3, q4 };


            //CREER UNE NOUVELLE LISTE AVeC QUESTION POSEE !!
            lbl_num_question.Text = "Question n° " + numeroQuestion + " :";
            lsQuestion = lsQuest;
            int k = R.Next(5); //un rang de plus que le nb total de questions
            if (k != 0)
            {
                k = k - 1;
            }
            lbl_intitule_question.Text = lsQuestion[k].Enonce;
            box_reponse1.Text = lsQuestion[k].Reponses[0].Intitule;
            box_reponse2.Text = lsQuestion[k].Reponses[1].Intitule;
            box_reponse3.Text = lsQuestion[k].Reponses[2].Intitule;
            box_reponse4.Text = lsQuestion[k].Reponses[3].Intitule;
          
            numeroQuestion++;
        }


        private void QuestionSuivante()
        {
            InitializeQuestion();
        }


        private bool Evaluation(List<Question> lsQuestion, int indice)
        {
            bool correct = true;
            //CAS 1 : cocher une réponse fausse
            if ((box_reponse1.Checked)&&(lsQuestion[indice].Reponses[0].Juste == false))
            {
                correct = false;
            }
            if ((box_reponse2.Checked) && (lsQuestion[indice].Reponses[1].Juste == false))
            {
                correct = false;
            }
            if ((box_reponse3.Checked) && (lsQuestion[indice].Reponses[2].Juste == false))
            {
                correct = false;
            }
            if ((box_reponse4.Checked) && (lsQuestion[indice].Reponses[3].Juste == false))
            {
                correct = false;
            }
            return correct;
            //CAS 2 : ne rien cocher
            //CAS 3 : ne pas cocher toutes les bonnes réponses

            //for (int k = 0; k < lsQuestion.Count; k++)
            //{

            //}
        }


        private void Enregistrer()
        {
            //en entree elle prend le résultat d'évaluation
            // enregistre sur le fichier xml
        }



        private void Noter()
        {

        }



        private void Correction()
        {
            //à la fin du questionnaire, affiche la correction des questions posées
        }



        //Evènements 


        private void btn_annuler_Click(object sender, EventArgs e)
        {
            box_reponse1.Checked = false;
            box_reponse2.Checked = false;
            box_reponse3.Checked = false;
            box_reponse4.Checked = false;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            //quand l'user valide, il faut évaluer sa réponse, enregistrer l'évaluation, passer à la question suivante

            QuestionSuivante();
        }

        
    }
}
