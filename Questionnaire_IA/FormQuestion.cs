using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Questionnaire_IA
{
    public partial class FormQuestion : Form
    {

        //Déclarations
        static int numeroQuestion = 1; //numero de la question où on en est dans le questionnaire
        Random R = new Random(); //nombre aléatoire
        List<Question> lsQuestion = new List<Question> { }; //Liste des questions à poser
        List<Question> lsQuestionsPosees = new List<Question> { }; //Liste des questions réellement posées
        List<Reponse> lsRepUser = new List<Reponse> { }; //Liste des réponses données par l'opérateur
        List<Reponse> lsRepJustes = new List<Reponse> { }; //Liste des réponses justes

        

        public FormQuestion()
        {
            //Initialisations
            InitializeComponent();
            lsQuestion = RecupererQuestions();
            InitializeQuestion();
        }

       
        //Méthodes

        private List<Question> RecupererQuestions()
        {
            //Fonction qui permet de récupérer la liste des questions à poser et qui la renvoie
            
            //Désérialisation
            StreamReader reader = new StreamReader("..\\..\\questions.xml");
            List<Question> questions = (List<Question>)new XmlSerializer(typeof(List<Question>)).Deserialize(reader);
            reader.Close();
            //retour
            return questions;
        }


        private void InitializeQuestion()
        {
            //Procédure qui permet d'initialiser la question à afficher 
            lbl_num_question.Text = "Question n° " + numeroQuestion + " :";

            int k = R.Next(lsQuestion.Count); //un rang de plus que le nb total de questions
            if (k != 0) 
            {
                k = k - 1;
            }
            lbl_intitule_question.Text = lsQuestion[k].Enonce;
            rbtn_reponse1.Text = lsQuestion[k].Reponses[0].Intitule;
            rbtn_reponse2.Text = lsQuestion[k].Reponses[1].Intitule;
            rbtn_reponse3.Text = lsQuestion[k].Reponses[2].Intitule;
            rbtn_reponse4.Text = lsQuestion[k].Reponses[3].Intitule;
            //Transfert dans listes
            lsQuestionsPosees.Add(lsQuestion[k]);
            lsQuestion.Remove(lsQuestion[k]);
            numeroQuestion++;
        }


        private void Annuler()
        {
            //Procédure qui permet de déselectionner tous les items 
            rbtn_reponse1.Checked = false;
            rbtn_reponse2.Checked = false;
            rbtn_reponse3.Checked = false;
            rbtn_reponse4.Checked = false;
        }


        private void QuestionSuivante()
        {
            //Procédure pour afficher la question suivante
            InitializeQuestion();
            Annuler();
        }


        private void InitializeRepJustes()
        { 
            // Procédure qui permet de remplir la liste des réponses justes lsRepJustes
            // avec les réponses justes associées aux questions posées
            for(int i = 0; i < lsQuestionsPosees.Count; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (lsQuestionsPosees[i].Reponses[j].Juste == true)
                    {
                        lsRepJustes.Add(lsQuestionsPosees[i].Reponses[j]);
                    }
                }
            }
        }


        private int Evaluation(Reponse ReponseUser, Reponse ReponseJuste, int note)
        {
            //Fonction d'évaluation de la réponse de l'opérateur à la question posée
            //Renvoie la note mise à jour
            if (ReponseUser == ReponseJuste)
            {
                note++;
            }
            return note;
        }
        

        private void Enregistrer(Question QuestionPosee)
        {
            //Procédure qui permet de sauvegarder la réponse de l'opérateur dans la liste lsRepUser
            if(rbtn_reponse1.Checked)
            {
                lsRepUser.Add(QuestionPosee.Reponses[0]);
            }
            if (rbtn_reponse2.Checked)
            {
                lsRepUser.Add(QuestionPosee.Reponses[1]);
            }
            if (rbtn_reponse3.Checked)
            {
                lsRepUser.Add(QuestionPosee.Reponses[2]);
            }
            if (rbtn_reponse4.Checked)
            {
                lsRepUser.Add(QuestionPosee.Reponses[3]);
            }
            //Si aucune réponse n'est sélectionnée, on attribue une réponse fausse pas défaut
            Reponse noReponse = new Reponse(1, QuestionPosee.Numero, "Vous n'avez pas répondu à cette question", false);
            if ((rbtn_reponse1.Checked == false)&& (rbtn_reponse2.Checked == false) && (rbtn_reponse3.Checked == false) && (rbtn_reponse4.Checked == false))
            {
                lsRepUser.Add(noReponse);
            }
        }
           


        //Evènements 


        private void btn_annuler_Click(object sender, EventArgs e)
        {
            //Bouton qui permet de déselectionner chaque item
            Annuler();
        }


        private void btn_valider_Click(object sender, EventArgs e)
        {
            //Bouton qui permet d'évaluer la réponse de l'opérateur,
            // d'enregistrer l'évaluation, de passer à la question suivante
            // ou d'afficher la correction si toutes les questions sont passées

            //Récupérer à quelle question on est 
            string intituleQuestion = lbl_intitule_question.Text;
            int note = 0;

            //Enregistrer la réponse à la question en cours
            Enregistrer(lsQuestionsPosees.Last<Question>());

            //Si on a atteint le nombre de questions voulu (ici 17)
            if (numeroQuestion == 18) 
            {
                InitializeRepJustes(); // Récupération des réponses justes
                for (int n = 0; n < lsQuestionsPosees.Count; n++)
                {
                    note = Evaluation(lsRepUser[n], lsRepJustes[n], note); //Notation de l'opérateur
                }
                //Affichage du formulaire de Dijkstra
                FormDijkstra form4 = new FormDijkstra(lsQuestionsPosees, lsRepJustes, lsRepUser, note);
                form4.Show();
                

                //Possibilités de quitter
                btn_quit.Show();
                btn_valider.Enabled = false;
                btn_annuler.Enabled = false;
                rbtn_reponse1.Enabled = false;
                rbtn_reponse2.Enabled = false;
                rbtn_reponse3.Enabled = false;
                rbtn_reponse4.Enabled = false;
            }
            else
            {
                QuestionSuivante();
            }
        }


        private void btn_quit_Click(object sender, EventArgs e)
        {
            //Fermeture du formulaire
            Form.ActiveForm.Close();
        }
    }
}
