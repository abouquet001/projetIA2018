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
            this.tabCorrection = new System.Windows.Forms.DataGridView();
            this.colQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReponses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblNote2 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabCorrection)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titre_correction
            // 
            this.lbl_titre_correction.AutoSize = true;
            this.lbl_titre_correction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre_correction.Location = new System.Drawing.Point(44, 37);
            this.lbl_titre_correction.Name = "lbl_titre_correction";
            this.lbl_titre_correction.Size = new System.Drawing.Size(102, 25);
            this.lbl_titre_correction.TabIndex = 0;
            this.lbl_titre_correction.Text = "Correction";
            // 
            // tabCorrection
            // 
            this.tabCorrection.AllowUserToAddRows = false;
            this.tabCorrection.AllowUserToDeleteRows = false;
            this.tabCorrection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabCorrection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabCorrection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabCorrection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuestions,
            this.colReponses});
            this.tabCorrection.Location = new System.Drawing.Point(49, 85);
            this.tabCorrection.Name = "tabCorrection";
            this.tabCorrection.ReadOnly = true;
            this.tabCorrection.RowTemplate.Height = 24;
            this.tabCorrection.Size = new System.Drawing.Size(1046, 430);
            this.tabCorrection.TabIndex = 3;
            // 
            // colQuestions
            // 
            this.colQuestions.HeaderText = "Questions";
            this.colQuestions.Name = "colQuestions";
            this.colQuestions.ReadOnly = true;
            this.colQuestions.Width = 101;
            // 
            // colReponses
            // 
            this.colReponses.HeaderText = "Reponses";
            this.colReponses.Name = "colReponses";
            this.colReponses.ReadOnly = true;
            this.colReponses.Width = 101;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(858, 44);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(84, 18);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "Votre note :";
            // 
            // lblNote2
            // 
            this.lblNote2.AutoSize = true;
            this.lblNote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote2.Location = new System.Drawing.Point(964, 44);
            this.lblNote2.Name = "lblNote2";
            this.lblNote2.Size = new System.Drawing.Size(38, 18);
            this.lblNote2.TabIndex = 5;
            this.lblNote2.Text = "X/20";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(548, 545);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // FormFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 616);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lblNote2);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.tabCorrection);
            this.Controls.Add(this.lbl_titre_correction);
            this.Name = "FormFin";
            this.Text = "Questions";
            ((System.ComponentModel.ISupportInitialize)(this.tabCorrection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre_correction;
        private System.Windows.Forms.DataGridView tab_correction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Réponses;
        private System.Windows.Forms.DataGridView tabCorrection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReponses;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblNote2;
        private System.Windows.Forms.Button btn_Ok;
    }
}