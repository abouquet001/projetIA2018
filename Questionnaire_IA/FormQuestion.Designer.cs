namespace Questionnaire_IA
{
    partial class FormQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_num_question = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.box_reponse1 = new System.Windows.Forms.CheckBox();
            this.lbl_intitule_question = new System.Windows.Forms.Label();
            this.box_reponse2 = new System.Windows.Forms.CheckBox();
            this.box_reponse3 = new System.Windows.Forms.CheckBox();
            this.box_reponse4 = new System.Windows.Forms.CheckBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_num_question
            // 
            this.lbl_num_question.AutoSize = true;
            this.lbl_num_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_question.Location = new System.Drawing.Point(47, 37);
            this.lbl_num_question.Name = "lbl_num_question";
            this.lbl_num_question.Size = new System.Drawing.Size(108, 20);
            this.lbl_num_question.TabIndex = 0;
            this.lbl_num_question.Text = "Question n°X";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(384, 497);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(115, 38);
            this.btn_valider.TabIndex = 5;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // box_reponse1
            // 
            this.box_reponse1.AutoSize = true;
            this.box_reponse1.Location = new System.Drawing.Point(65, 202);
            this.box_reponse1.Name = "box_reponse1";
            this.box_reponse1.Size = new System.Drawing.Size(90, 21);
            this.box_reponse1.TabIndex = 6;
            this.box_reponse1.Text = "reponse1";
            this.box_reponse1.UseVisualStyleBackColor = true;
            // 
            // lbl_intitule_question
            // 
            this.lbl_intitule_question.AutoSize = true;
            this.lbl_intitule_question.Location = new System.Drawing.Point(48, 82);
            this.lbl_intitule_question.Name = "lbl_intitule_question";
            this.lbl_intitule_question.Size = new System.Drawing.Size(142, 17);
            this.lbl_intitule_question.TabIndex = 7;
            this.lbl_intitule_question.Text = "Intitulé de la question";
            // 
            // box_reponse2
            // 
            this.box_reponse2.AutoSize = true;
            this.box_reponse2.Location = new System.Drawing.Point(65, 275);
            this.box_reponse2.Name = "box_reponse2";
            this.box_reponse2.Size = new System.Drawing.Size(90, 21);
            this.box_reponse2.TabIndex = 8;
            this.box_reponse2.Text = "reponse2";
            this.box_reponse2.UseVisualStyleBackColor = true;
            // 
            // box_reponse3
            // 
            this.box_reponse3.AutoSize = true;
            this.box_reponse3.Location = new System.Drawing.Point(65, 346);
            this.box_reponse3.Name = "box_reponse3";
            this.box_reponse3.Size = new System.Drawing.Size(90, 21);
            this.box_reponse3.TabIndex = 9;
            this.box_reponse3.Text = "reponse3";
            this.box_reponse3.UseVisualStyleBackColor = true;
            // 
            // box_reponse4
            // 
            this.box_reponse4.AutoSize = true;
            this.box_reponse4.Location = new System.Drawing.Point(65, 416);
            this.box_reponse4.Name = "box_reponse4";
            this.box_reponse4.Size = new System.Drawing.Size(90, 21);
            this.box_reponse4.TabIndex = 10;
            this.box_reponse4.Text = "reponse4";
            this.box_reponse4.UseVisualStyleBackColor = true;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(217, 497);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(115, 38);
            this.btn_annuler.TabIndex = 11;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 599);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.box_reponse4);
            this.Controls.Add(this.box_reponse3);
            this.Controls.Add(this.box_reponse2);
            this.Controls.Add(this.lbl_intitule_question);
            this.Controls.Add(this.box_reponse1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_num_question);
            this.Name = "FormQuestion";
            this.Text = "Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num_question;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.CheckBox box_reponse1;
        private System.Windows.Forms.Label lbl_intitule_question;
        private System.Windows.Forms.CheckBox box_reponse2;
        private System.Windows.Forms.CheckBox box_reponse3;
        private System.Windows.Forms.CheckBox box_reponse4;
        private System.Windows.Forms.Button btn_annuler;
    }
}