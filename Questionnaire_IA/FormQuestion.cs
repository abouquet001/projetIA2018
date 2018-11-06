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
        public FormQuestion()
        {
            InitializeComponent();
        }

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
            

        }

        private void evaluation()
        {

        }
    }
}
