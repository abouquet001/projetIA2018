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
        // Déclarations

        //List<Eleve>

        public FormQuestionnaire()
        {
            InitializeComponent();
        }


        // Evènements

        private void btn_save_Click(object sender, EventArgs e)
        {

            FormQuestion form2 = new FormQuestion();
            form2.Show();
        }
    }
}
