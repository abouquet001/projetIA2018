namespace Questionnaire_IA
{
    partial class FormFin
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
            this.lbl_titre_correction = new System.Windows.Forms.Label();
            this.lbl_correction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titre_correction
            // 
            this.lbl_titre_correction.AutoSize = true;
            this.lbl_titre_correction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_correction.Location = new System.Drawing.Point(232, 56);
            this.lbl_titre_correction.Name = "lbl_titre_correction";
            this.lbl_titre_correction.Size = new System.Drawing.Size(102, 25);
            this.lbl_titre_correction.TabIndex = 0;
            this.lbl_titre_correction.Text = "Correction";
            // 
            // lbl_correction
            // 
            this.lbl_correction.AutoSize = true;
            this.lbl_correction.Location = new System.Drawing.Point(60, 126);
            this.lbl_correction.Name = "lbl_correction";
            this.lbl_correction.Size = new System.Drawing.Size(46, 17);
            this.lbl_correction.TabIndex = 1;
            this.lbl_correction.Text = "label2";
            // 
            // FormFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 505);
            this.Controls.Add(this.lbl_correction);
            this.Controls.Add(this.lbl_titre_correction);
            this.Name = "FormFin";
            this.Text = "Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre_correction;
        private System.Windows.Forms.Label lbl_correction;
    }
}