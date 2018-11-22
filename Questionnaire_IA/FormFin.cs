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
    public partial class FormFin : Form
    {
        public FormFin(List<Question> lsQuestionsPosees, List<Reponse> lsReponsesJustes)
        {
         
            InitializeComponent();

            //Affichage des questions/reponses dans le DataGridView
            for (int i=0;i<lsQuestionsPosees.Count;i++)
            {
                tabCorrection.Rows.Add(lsQuestionsPosees[i].Enonce, lsReponsesJustes[i].Intitule);
            }
            
        }


        //Méthodes




        //Evènements


        private void tab_correction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //fermer les form
        }


    }
}
