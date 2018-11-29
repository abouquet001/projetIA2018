using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Questionnaire_IA 
{
    public partial class FormDijkstra : Form
    {
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public char numinitial;
        static public char numfinal;
        static List<Node2> L_Ouverts = new List<Node2>();
        static List<Node2> L_Fermes = new List<Node2>();
        static SearchTree g = new SearchTree(L_Ouverts, L_Fermes);
        static Node2 N0 = new Node2();
        static Node2 N = new Node2();
        static public int iteration = 0;
        static bool OuvertFerme = false;
        static bool Treeview=false;
        static TreeView originalTree = new TreeView();
        static List<bool> ouvertFermes = new List<bool>();
        static int note;
        List<Question> lQP = new List<Question>();
        List<Reponse> lRJ = new List<Reponse>();
        List<Reponse> lRD = new List<Reponse>();

        public FormDijkstra(List<Question> lsQuestionsPosees, List<Reponse> lsReponsesJustes, List<Reponse> lsReponsesDonnees, int _note)
        {
            InitializeComponent();
            note = _note;
            lQP = lsQuestionsPosees;
            lRJ = lsReponsesJustes;
            lRD = lsReponsesDonnees;
        }

        private bool CompareList(List<Node2> LA, List<int> LR)
        {
            bool equal = true;
            if (LA.Count != LR.Count)
            { return equal = false; }
            else
            {
                if (LA.Count == 0)
                {
                    return equal;
                }
                else
                {
                    LR.Sort();
                    for (int i = 0; i < LA.Count; i++)
                    {
                        if (LA[i].numero != LR[i])
                        {
                            equal = false;
                        }
                    }

                }

            }
            return equal;
        }
        private List<int> RecupO()
        {
            List<int> LO = new List<int>();
            string saisie = tB_ouvert.Text;
            Node2 N = new Node2();
            if (saisie != "")
            {
                for (int i = 0; i < saisie.Length; i++)
                {
                    if (saisie[i] != ',')
                    {

                        LO.Add(Convert.ToInt32(saisie[i]) - 48);
                    }
                }
            }
            return LO;
        }
        private List<int> RecupF()
        {
            List<int> LF = new List<int>();
            string saisie = tB_Ferme.Text;
            Node2 N = new Node2();
            if (saisie != "")
            {
                for (int i = 0; i < saisie.Length; i++)
                {
                    if (saisie[i] != ',')
                    {

                        LF.Add(Convert.ToInt32(saisie[i]) - 48);
                    }
                }
            }
            return LF;
        }

        
       

        private bool CompareTree(TreeView TV1, TreeView TV2)
        {

            List<TreeNode> ltn1 = new List<TreeNode>();
            getallTreeNode(TV1.Nodes, ltn1);
            List<TreeNode> ltn2 = new List<TreeNode>();
            getallTreeNode(TV2.Nodes, ltn2);

            //find the difference
            foreach (TreeNode tn2 in ltn2)
            {
                List<TreeNode> tmp = new List<TreeNode>();
                foreach (TreeNode tn1 in ltn1)
                {
                    if (tn1.Parent == null && tn2.Parent == null && tn1.Text.Equals(tn2.Text))
                    {
                        tmp.Add(tn2);
                    }
                    if (tn1.Parent != null && tn2.Parent != null)
                    {

                        if (tn1.Text.Equals(tn2.Text) && tn1.Parent.Text.Equals(tn2.Parent.Text))
                        {
                            tmp.Add(tn2);
                        }
                    }
                }
                if (tmp == null || tmp.Count == 0)
                {
                    return false;
                }

            }

            return true;
        }

        private void getallTreeNode(TreeNodeCollection nodes, List<TreeNode> ltn)
        {
            foreach (TreeNode td in nodes)
            {
                ltn.Add(td);
                if (td.Nodes.Count > 0)
                    getallTreeNode(td.Nodes, ltn);
            }
        }

        private void btn_ouvertFermeSuivant_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToChar(lbl_init.Text);
            numfinal = Convert.ToChar(lbl_fin.Text);
            if (iteration == 0)
            {
                N0.numero = numinitial - 48;
                L_Ouverts.Add(N0);
            }

            iteration++;
            lbl_iteration.Text = "Itération : " + Convert.ToString(iteration);
            N = L_Ouverts[0];

            if (L_Ouverts.Count != 0 && N.EndState() == false)
            {

                // tant que le noeud n'est pas terminal et que ouverts n'est pas vide

                // Le meilleur noeud des ouverts est supposé placé en tête de liste
                // On le place dans les fermés
                L_Ouverts.Remove(N);
                L_Fermes.Add(N);

                // Il faut trouver les noeuds successeurs de N
                g.MAJSuccesseurs(N);
                // Inutile de retrier car les insertions ont été faites en respectant l'ordre
                // On prend le meilleur, donc celui en position 0, pour continuer à explorer les états
                // A condition qu'il existe bien sûr
                if (L_Ouverts.Count > 0)
                {
                    N = L_Ouverts[0];
                }
                else
                {
                    N = null;
                }

            }
            
            List<int> LF = new List<int>();
            List<int> LO = new List<int>();
            LF = RecupF();
            LO = RecupO();
            bool boolLO = CompareList(L_Ouverts, LO);
            bool boolLF = CompareList(L_Fermes, LF);
            if (boolLO && boolLF)
            {
                ouvertFermes.Add(true);
            }
            else { ouvertFermes.Add(false); }

            if (N.EndState())
            {
                OuvertFerme = true;
                foreach (bool b in ouvertFermes)
                {
                    if (b == false)
                    {
                        OuvertFerme = false;
                    }
                }
                btn_ouvertFermeSuivant.Enabled = false;
                treeView1.Enabled = true;
                btn_insertNode.Enabled = true;
                tB_treeView.Enabled = true;
                g.GetSearchTreeVide(treeView1);
                originalTree = g.GetSearchTree();
            }
        }

        private void FormDijkstra_Load(object sender, EventArgs e)
        {
            StreamReader monStreamReader = new StreamReader("graphe1.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // Ensuite on a ls tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                lB_affichageNoeud.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
            lbl_init.Text = "0";
            lbl_fin.Text =Convert.ToString(matrice.GetLength(1)-1) ;
            numinitial = Convert.ToChar(lbl_init.Text);
            numfinal = Convert.ToChar(lbl_fin.Text);
        }

        private void btn_insertNode_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Text = tB_treeView.Text;
        }


        private void btn_resultat_Click(object sender, EventArgs e)
        {
            
            Treeview = CompareTree(treeView1, originalTree);
            if (OuvertFerme && Treeview)
            {
                MessageBox.Show("Bravo ! Vous avez réussi ces deux derniers exercices");
                note += 3;
            }
            else if(OuvertFerme && !Treeview)
            {
                MessageBox.Show(" Vous n'avez réussi que les ouverts et les fermés");
                note += 2;
            }
            else if (!OuvertFerme && Treeview)
            {
                MessageBox.Show(" Vous n'avez réussi que le remplissage de l'arbre");
                note +=1 ;
            }
            else { MessageBox.Show(" Désolé vous avez commis des erreurs dans ces deux derniers exercices"); }
            FormFin form3 = new FormFin(lQP, lRJ, lRD, note);
            form3.ShowDialog();
            Form.ActiveForm.Close();
        }

        
    }
}
