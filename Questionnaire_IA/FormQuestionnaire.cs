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
    public partial class FormQuestionnaire : Form
    {
          
        public FormQuestionnaire()
        {
            InitializeComponent();
        }


        // Evènements

        private void btn_start_Click(object sender, EventArgs e)
        {
            //Affichage du formulaire des questions
            FormQuestion form2 = new FormQuestion();
            form2.Show();
            btn_start.Enabled = false;
            btn_stop.Show();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            //Fermeture du formulaire
            Form.ActiveForm.Close();
        }

       
    }
}
