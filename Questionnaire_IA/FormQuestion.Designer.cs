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
            this.lbl_intitule_question = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.rbtn_reponse1 = new System.Windows.Forms.RadioButton();
            this.rbtn_reponse2 = new System.Windows.Forms.RadioButton();
            this.rbtn_reponse3 = new System.Windows.Forms.RadioButton();
            this.rbtn_reponse4 = new System.Windows.Forms.RadioButton();
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
            // lbl_intitule_question
            // 
            this.lbl_intitule_question.AutoSize = true;
            this.lbl_intitule_question.Location = new System.Drawing.Point(48, 82);
            this.lbl_intitule_question.Name = "lbl_intitule_question";
            this.lbl_intitule_question.Size = new System.Drawing.Size(142, 17);
            this.lbl_intitule_question.TabIndex = 7;
            this.lbl_intitule_question.Text = "Intitulé de la question";
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
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(384, 550);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(115, 37);
            this.btn_quit.TabIndex = 12;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Visible = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // rbtn_reponse1
            // 
            this.rbtn_reponse1.AutoSize = true;
            this.rbtn_reponse1.Location = new System.Drawing.Point(86, 215);
            this.rbtn_reponse1.Name = "rbtn_reponse1";
            this.rbtn_reponse1.Size = new System.Drawing.Size(89, 21);
            this.rbtn_reponse1.TabIndex = 13;
            this.rbtn_reponse1.TabStop = true;
            this.rbtn_reponse1.Text = "reponse1";
            this.rbtn_reponse1.UseVisualStyleBackColor = true;
            // 
            // rbtn_reponse2
            // 
            this.rbtn_reponse2.AutoSize = true;
            this.rbtn_reponse2.Location = new System.Drawing.Point(86, 279);
            this.rbtn_reponse2.Name = "rbtn_reponse2";
            this.rbtn_reponse2.Size = new System.Drawing.Size(89, 21);
            this.rbtn_reponse2.TabIndex = 14;
            this.rbtn_reponse2.TabStop = true;
            this.rbtn_reponse2.Text = "reponse2";
            this.rbtn_reponse2.UseVisualStyleBackColor = true;
            // 
            // rbtn_reponse3
            // 
            this.rbtn_reponse3.AutoSize = true;
            this.rbtn_reponse3.Location = new System.Drawing.Point(86, 350);
            this.rbtn_reponse3.Name = "rbtn_reponse3";
            this.rbtn_reponse3.Size = new System.Drawing.Size(89, 21);
            this.rbtn_reponse3.TabIndex = 15;
            this.rbtn_reponse3.TabStop = true;
            this.rbtn_reponse3.Text = "reponse3";
            this.rbtn_reponse3.UseVisualStyleBackColor = true;
            // 
            // rbtn_reponse4
            // 
            this.rbtn_reponse4.AutoSize = true;
            this.rbtn_reponse4.Location = new System.Drawing.Point(86, 420);
            this.rbtn_reponse4.Name = "rbtn_reponse4";
            this.rbtn_reponse4.Size = new System.Drawing.Size(89, 21);
            this.rbtn_reponse4.TabIndex = 16;
            this.rbtn_reponse4.TabStop = true;
            this.rbtn_reponse4.Text = "reponse4";
            this.rbtn_reponse4.UseVisualStyleBackColor = true;
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(598, 599);
            this.Controls.Add(this.rbtn_reponse4);
            this.Controls.Add(this.rbtn_reponse3);
            this.Controls.Add(this.rbtn_reponse2);
            this.Controls.Add(this.rbtn_reponse1);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.lbl_intitule_question);
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
        private System.Windows.Forms.Label lbl_intitule_question;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.RadioButton rbtn_reponse1;
        private System.Windows.Forms.RadioButton rbtn_reponse2;
        private System.Windows.Forms.RadioButton rbtn_reponse3;
        private System.Windows.Forms.RadioButton rbtn_reponse4;
    }
}