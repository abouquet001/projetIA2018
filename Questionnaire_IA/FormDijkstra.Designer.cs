namespace Questionnaire_IA
{
    partial class FormDijkstra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDijkstra));
            this.btn_resultat = new System.Windows.Forms.Button();
            this.btn_insertNode = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lB_affichageNoeud = new System.Windows.Forms.ListBox();
            this.lbl_Ferme = new System.Windows.Forms.Label();
            this.lbl_Ouvert = new System.Windows.Forms.Label();
            this.btn_ouvertFermeSuivant = new System.Windows.Forms.Button();
            this.tB_Ferme = new System.Windows.Forms.TextBox();
            this.tB_ouvert = new System.Windows.Forms.TextBox();
            this.lbl_consigne = new System.Windows.Forms.Label();
            this.tB_treeView = new System.Windows.Forms.TextBox();
            this.lbl_init = new System.Windows.Forms.Label();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.lbl_numFinal = new System.Windows.Forms.Label();
            this.lbl_numInit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_iteration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_resultat
            // 
            this.btn_resultat.Location = new System.Drawing.Point(521, 485);
            this.btn_resultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_resultat.Name = "btn_resultat";
            this.btn_resultat.Size = new System.Drawing.Size(100, 28);
            this.btn_resultat.TabIndex = 23;
            this.btn_resultat.Text = "Résultat";
            this.btn_resultat.UseVisualStyleBackColor = true;
            this.btn_resultat.Click += new System.EventHandler(this.btn_resultat_Click);
            // 
            // btn_insertNode
            // 
            this.btn_insertNode.Enabled = false;
            this.btn_insertNode.Location = new System.Drawing.Point(725, 431);
            this.btn_insertNode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_insertNode.Name = "btn_insertNode";
            this.btn_insertNode.Size = new System.Drawing.Size(159, 28);
            this.btn_insertNode.TabIndex = 22;
            this.btn_insertNode.Text = "Valider Noeud";
            this.btn_insertNode.UseVisualStyleBackColor = true;
            this.btn_insertNode.Click += new System.EventHandler(this.btn_insertNode_Click);
            // 
            // treeView1
            // 
            this.treeView1.Enabled = false;
            this.treeView1.Location = new System.Drawing.Point(711, 122);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(201, 221);
            this.treeView1.TabIndex = 21;
            // 
            // lB_affichageNoeud
            // 
            this.lB_affichageNoeud.FormattingEnabled = true;
            this.lB_affichageNoeud.ItemHeight = 16;
            this.lB_affichageNoeud.Location = new System.Drawing.Point(65, 112);
            this.lB_affichageNoeud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lB_affichageNoeud.Name = "lB_affichageNoeud";
            this.lB_affichageNoeud.Size = new System.Drawing.Size(132, 148);
            this.lB_affichageNoeud.TabIndex = 25;
            // 
            // lbl_Ferme
            // 
            this.lbl_Ferme.AutoSize = true;
            this.lbl_Ferme.Location = new System.Drawing.Point(313, 377);
            this.lbl_Ferme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ferme.Name = "lbl_Ferme";
            this.lbl_Ferme.Size = new System.Drawing.Size(116, 17);
            this.lbl_Ferme.TabIndex = 31;
            this.lbl_Ferme.Text = "Liste des Fermés";
            // 
            // lbl_Ouvert
            // 
            this.lbl_Ouvert.AutoSize = true;
            this.lbl_Ouvert.Location = new System.Drawing.Point(55, 377);
            this.lbl_Ouvert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ouvert.Name = "lbl_Ouvert";
            this.lbl_Ouvert.Size = new System.Drawing.Size(119, 17);
            this.lbl_Ouvert.TabIndex = 30;
            this.lbl_Ouvert.Text = "Liste des Ouverts";
            // 
            // btn_ouvertFermeSuivant
            // 
            this.btn_ouvertFermeSuivant.Location = new System.Drawing.Point(202, 431);
            this.btn_ouvertFermeSuivant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ouvertFermeSuivant.Name = "btn_ouvertFermeSuivant";
            this.btn_ouvertFermeSuivant.Size = new System.Drawing.Size(100, 28);
            this.btn_ouvertFermeSuivant.TabIndex = 29;
            this.btn_ouvertFermeSuivant.Text = "Suivant";
            this.btn_ouvertFermeSuivant.UseVisualStyleBackColor = true;
            this.btn_ouvertFermeSuivant.Click += new System.EventHandler(this.btn_ouvertFermeSuivant_Click);
            // 
            // tB_Ferme
            // 
            this.tB_Ferme.Location = new System.Drawing.Point(316, 398);
            this.tB_Ferme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_Ferme.Name = "tB_Ferme";
            this.tB_Ferme.Size = new System.Drawing.Size(132, 22);
            this.tB_Ferme.TabIndex = 28;
            // 
            // tB_ouvert
            // 
            this.tB_ouvert.Location = new System.Drawing.Point(58, 398);
            this.tB_ouvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_ouvert.Name = "tB_ouvert";
            this.tB_ouvert.Size = new System.Drawing.Size(132, 22);
            this.tB_ouvert.TabIndex = 27;
            // 
            // lbl_consigne
            // 
            this.lbl_consigne.AutoSize = true;
            this.lbl_consigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_consigne.Location = new System.Drawing.Point(16, 11);
            this.lbl_consigne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_consigne.Name = "lbl_consigne";
            this.lbl_consigne.Size = new System.Drawing.Size(218, 20);
            this.lbl_consigne.TabIndex = 32;
            this.lbl_consigne.Text = "Voici la dernière question  : ";
            // 
            // tB_treeView
            // 
            this.tB_treeView.Enabled = false;
            this.tB_treeView.Location = new System.Drawing.Point(739, 384);
            this.tB_treeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_treeView.Name = "tB_treeView";
            this.tB_treeView.Size = new System.Drawing.Size(132, 22);
            this.tB_treeView.TabIndex = 33;
            // 
            // lbl_init
            // 
            this.lbl_init.AutoSize = true;
            this.lbl_init.Location = new System.Drawing.Point(273, 144);
            this.lbl_init.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_init.Name = "lbl_init";
            this.lbl_init.Size = new System.Drawing.Size(46, 17);
            this.lbl_init.TabIndex = 34;
            this.lbl_init.Text = "label1";
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Location = new System.Drawing.Point(405, 144);
            this.lbl_fin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(46, 17);
            this.lbl_fin.TabIndex = 35;
            this.lbl_fin.Text = "label2";
            // 
            // lbl_numFinal
            // 
            this.lbl_numFinal.AutoSize = true;
            this.lbl_numFinal.Location = new System.Drawing.Point(405, 112);
            this.lbl_numFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numFinal.Name = "lbl_numFinal";
            this.lbl_numFinal.Size = new System.Drawing.Size(84, 17);
            this.lbl_numFinal.TabIndex = 36;
            this.lbl_numFinal.Text = "Noeud Final";
            // 
            // lbl_numInit
            // 
            this.lbl_numInit.AutoSize = true;
            this.lbl_numInit.Location = new System.Drawing.Point(273, 112);
            this.lbl_numInit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numInit.Name = "lbl_numInit";
            this.lbl_numInit.Size = new System.Drawing.Size(98, 17);
            this.lbl_numInit.TabIndex = 37;
            this.lbl_numInit.Text = "Noeud Initial : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "Voici, ci-dessous, un réseau de noeuds avec \r\nun noeud initial et un noeud final." +
    "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(487, 68);
            this.label3.TabIndex = 40;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 85);
            this.label4.TabIndex = 41;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // lbl_iteration
            // 
            this.lbl_iteration.AutoSize = true;
            this.lbl_iteration.Location = new System.Drawing.Point(235, 399);
            this.lbl_iteration.Name = "lbl_iteration";
            this.lbl_iteration.Size = new System.Drawing.Size(60, 13);
            this.lbl_iteration.TabIndex = 42;
            this.lbl_iteration.Text = "Itération : 0";
            // 
            // FormDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 446);
            this.Controls.Add(this.lbl_iteration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_numInit);
            this.Controls.Add(this.lbl_numFinal);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.lbl_init);
            this.Controls.Add(this.tB_treeView);
            this.Controls.Add(this.lbl_consigne);
            this.Controls.Add(this.lbl_Ferme);
            this.Controls.Add(this.lbl_Ouvert);
            this.Controls.Add(this.btn_ouvertFermeSuivant);
            this.Controls.Add(this.tB_Ferme);
            this.Controls.Add(this.tB_ouvert);
            this.Controls.Add(this.lB_affichageNoeud);
            this.Controls.Add(this.btn_resultat);
            this.Controls.Add(this.btn_insertNode);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDijkstra";
            this.Text = "FormDijkstra";
            this.Load += new System.EventHandler(this.FormDijkstra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_resultat;
        private System.Windows.Forms.Button btn_insertNode;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox lB_affichageNoeud;
        private System.Windows.Forms.Label lbl_Ferme;
        private System.Windows.Forms.Label lbl_Ouvert;
        private System.Windows.Forms.Button btn_ouvertFermeSuivant;
        private System.Windows.Forms.TextBox tB_Ferme;
        private System.Windows.Forms.TextBox tB_ouvert;
        private System.Windows.Forms.Label lbl_consigne;
        private System.Windows.Forms.TextBox tB_treeView;
        private System.Windows.Forms.Label lbl_init;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.Label lbl_numFinal;
        private System.Windows.Forms.Label lbl_numInit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_iteration;
    }
}