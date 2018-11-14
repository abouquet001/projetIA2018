namespace Questionnaire_IA
{
    partial class FormQuestionnaire
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.tbx_prenom = new System.Windows.Forms.TextBox();
            this.tbx_date = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_intro = new System.Windows.Forms.Label();
            this.txt_indication = new System.Windows.Forms.Label();
            this.lbl_n_etud = new System.Windows.Forms.Label();
            this.tbx_n_etud = new System.Windows.Forms.TextBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(145, 355);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nom :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(125, 425);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(65, 17);
            this.lbl_prenom.TabIndex = 1;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(144, 583);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(46, 17);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "Date :";
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(229, 355);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(100, 22);
            this.tbx_name.TabIndex = 3;
            // 
            // tbx_prenom
            // 
            this.tbx_prenom.Location = new System.Drawing.Point(229, 425);
            this.tbx_prenom.Name = "tbx_prenom";
            this.tbx_prenom.Size = new System.Drawing.Size(100, 22);
            this.tbx_prenom.TabIndex = 4;
            // 
            // tbx_date
            // 
            this.tbx_date.Location = new System.Drawing.Point(229, 578);
            this.tbx_date.Name = "tbx_date";
            this.tbx_date.Size = new System.Drawing.Size(100, 22);
            this.tbx_date.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(435, 631);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 38);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Enregistrer";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_intro
            // 
            this.txt_intro.AutoSize = true;
            this.txt_intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_intro.Location = new System.Drawing.Point(96, 41);
            this.txt_intro.Name = "txt_intro";
            this.txt_intro.Size = new System.Drawing.Size(419, 52);
            this.txt_intro.TabIndex = 7;
            this.txt_intro.Text = "Bienvenue sur le programme d\'évaluation \r\nde vos connaissances en IA. \r\n";
            // 
            // txt_indication
            // 
            this.txt_indication.AutoSize = true;
            this.txt_indication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_indication.Location = new System.Drawing.Point(51, 298);
            this.txt_indication.Name = "txt_indication";
            this.txt_indication.Size = new System.Drawing.Size(498, 20);
            this.txt_indication.TabIndex = 8;
            this.txt_indication.Text = "Pour commencer, veuillez indiquer vos informations personnelles.";
            // 
            // lbl_n_etud
            // 
            this.lbl_n_etud.AutoSize = true;
            this.lbl_n_etud.Location = new System.Drawing.Point(102, 499);
            this.lbl_n_etud.Name = "lbl_n_etud";
            this.lbl_n_etud.Size = new System.Drawing.Size(88, 17);
            this.lbl_n_etud.TabIndex = 9;
            this.lbl_n_etud.Text = "N° Etudiant :";
            // 
            // tbx_n_etud
            // 
            this.tbx_n_etud.Location = new System.Drawing.Point(229, 499);
            this.tbx_n_etud.Name = "tbx_n_etud";
            this.tbx_n_etud.Size = new System.Drawing.Size(100, 22);
            this.tbx_n_etud.TabIndex = 10;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(52, 140);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(211, 17);
            this.lbl_info.TabIndex = 11;
            this.lbl_info.Text = "Texte de presentation à rajouter";
            // 
            // FormQuestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 708);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.tbx_n_etud);
            this.Controls.Add(this.lbl_n_etud);
            this.Controls.Add(this.txt_indication);
            this.Controls.Add(this.txt_intro);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tbx_date);
            this.Controls.Add(this.tbx_prenom);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_name);
            this.Name = "FormQuestionnaire";
            this.Text = "Evaluation IA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.TextBox tbx_prenom;
        private System.Windows.Forms.TextBox tbx_date;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label txt_intro;
        private System.Windows.Forms.Label txt_indication;
        private System.Windows.Forms.Label lbl_n_etud;
        private System.Windows.Forms.TextBox tbx_n_etud;
        private System.Windows.Forms.Label lbl_info;
    }
}