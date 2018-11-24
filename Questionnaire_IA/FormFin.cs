﻿using System;
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
    public partial class FormFin : Form
    {
        public FormFin(List<Question> lsQuestionsPosees, List<Reponse> lsReponsesJustes, List<bool> lsReponsesDonnees, int note)
        {
            InitializeComponent();
            Correction(lsQuestionsPosees, lsReponsesJustes);
            AffichageNote(note);            
        }


        //Méthodes

        public void Correction(List<Question> lsQuestions, List<Reponse> lsReponses)
        {
            //Affichage des questions/reponses dans le DataGridView
            for (int i = 0; i < lsQuestions.Count; i++)
            {
                tabCorrection.Rows.Add(lsQuestions[i].Enonce, lsReponses[i].Intitule);
            }
        }

        public void AffichageNote(int note)
        {
            lblNote2.Text = "" + note + " /20";
        }



        //Evènements


        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //fermer les form
            Form.ActiveForm.Close();
            
        }


    }
}
