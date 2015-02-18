using MyBuild.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBuild
{
    public partial class Entrainement_Form : Form
    {
        Entrainement lentrainement = new Entrainement();
        int numeroTour = 0;
        private int nbExercices = 0;
        int x = 20, y = 50;
        List<ComboBox> lesExercicesCbx = null;
        List<ComboBox> lesnbExericicesCbx = null;
        TreeNode root = new TreeNode("Entrainement");
       
        
        
        TreeNode[] lesTreeTours = new TreeNode[10]{
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
        };
        TreeNode[] lesTreeExercice = new TreeNode[10]{
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
            new TreeNode{Text="Non Renseigné"},
        };
        
        public Entrainement_Form()
        {
           DAL Manager = DAL.Instance;
            InitializeComponent();
            LoadCbxType();
            LoadCbxNbTours();
            lesExercicesCbx = new List<ComboBox>();
            lesnbExericicesCbx = new List<ComboBox>(); 
           
        }

        private void LoadCbxExercices(int p_nbExercices)
        {
           AddCbExo();
        }

        private void AddCbNbFoisExo()
        {
            string typeExo = cbx_TypeEntrainement.SelectedValue.ToString();
            ComboBox cb1 = new ComboBox();
            cb1.Name = "cbNbExo" + (nbExercices + 1);
            gbxExercices.Controls.Add(cb1);
            cb1.Width = 40;
            cb1.Location = new Point(x+165, y);
            LoadCbxNbFoisExercices(cb1);
            lesnbExericicesCbx.Add(cb1);
            
        }

        private void LoadCbxNbFoisExercices(ComboBox cb1)
        {
            
            for (int i = 0; i < 250; i = i + 10)
            {
                    cb1.Items.Add(i);  
            }
        }

        private void AddCbExo()
        {
            if(nbExercices<10)
            { 
                string typeExo = cbx_TypeEntrainement.SelectedValue.ToString();
                ComboBox cb1 = new ComboBox();
                cb1.Name = "cbExo" + (nbExercices + 1);
                gbxExercices.Controls.Add(cb1);
                cb1.Width = 160;
                cb1.Location = new Point(x, y);

                LoadCbxExercices(cb1, typeExo);
                lesExercicesCbx.Add(cb1);
               /* rtxt_log.Text += "\nAJOUTER : \n";
                foreach(ComboBox lecb in lesExercicesCbx)
                {
                    rtxt_log.Text += "\n"+lecb.Name.ToString();
                }*/
                AddCbNbFoisExo();
                
                nbExercices++;
                y += 20;
                if (nbExercices > 0)
                {
                    cbx_TypeEntrainement.Enabled = false;
                    btn_AjouterExercices.Visible = true;
                }
                else
                {
                    cbx_TypeEntrainement.Enabled = true;
                    btn_AjouterExercices.Visible = false;
                }
            }
            }
            
        

        private void LoadCbxExercices(ComboBox cb, string p_typeExercice)
        {
            List<Exercice> lesExercices = null;
            lesExercices = RecupExercice(p_typeExercice);
            cb.DataSource = lesExercices.ToArray();
            cb.DisplayMember = "Nom";
            cb.ValueMember = "Id";
        }

     
        private void LoadCbxNbTours()
        {
            for (int i =1;i<=10;i++)
            {
                cbx_nbTours.Items.Add(i);
            }
        }

        private void LoadCbxType()
        {
            List<TypeEntrainement> lesType = null;
            lesType = RecupTypeEntrainement();
            cbx_TypeEntrainement.DataSource = lesType.ToArray();
            cbx_TypeEntrainement.DisplayMember = "Nom";
            cbx_TypeEntrainement.ValueMember = "Id";
 
            
        }
        public List<Exercice> RecupExercice(string p_typeExercice)
        {
            return DAL.Instance.RecupExercice(p_typeExercice);
        }

        public List<TypeEntrainement> RecupTypeEntrainement()
        {
            return  DAL.Instance.RecupTypeEntrainement();
        }

        private void btn_AjouterEntrainement_Click(object sender, EventArgs e)
        {
            gbx_Entrainement.Visible = true;
            tbx_Id.Text = Guid.NewGuid().ToString();
        }

        private void btn_AjouterExercices_Click(object sender, EventArgs e)
        {
            int NumCheck = numeroTour;
            NumCheck++;
            
            //laTreeView.Width = 250;
            //laTreeView.Location = new Point( 500, 150);
            
            if (root.Nodes.Count >0)
            {
               // root.Remove();
               // root.Nodes[numeroTour-1].Remove();
               // this.Controls.Remove(laTreeView);
               
            }
            
           
           
           
                for (int p = 0; p < nbExercices; p++)
                {
                    ComboBox laComboExercice = lesExercicesCbx[p];
                    ComboBox laComboNbtour = lesnbExericicesCbx[p];
                    
                    Exercice lexercices = new Exercice();
                    lexercices.Id = laComboExercice.SelectedValue.ToString();
                    lexercices.Nom = laComboExercice.Text;
                    lexercices.LeType = new TypeEntrainement {
                        Id = cbx_TypeEntrainement.SelectedValue.ToString().Trim(),
                        Nom = cbx_TypeEntrainement.Text.Trim() 
                    };
                   
                    if (laComboNbtour.SelectedItem != null)
                    {
                        lexercices.leNbdeFois = Convert.ToInt32(laComboNbtour.SelectedItem.ToString());
                    }
                    else { lexercices.leNbdeFois = 0; }
                    lentrainement.lesTours[numeroTour - 1].lesExercices.Add(lexercices);
                    lexercices.sequence = p+1;
                    root.Nodes[numeroTour - 1].Nodes.Add(lexercices.Nom);
                    //lesTreeTours[numeroTour - 1].Nodes.Add(lexercices.Nom);
                }
                //root = new TreeNode("Entrainement");
                    
                    //root = new TreeNode("Entrainement", lesTreeTours);
                //
                //this.Controls.Add(laTreeView);


               /* rtxt_log.Text += "\n Tour numero : " + lentrainement.lesTours[numeroTour - 1].numeroTour;
                foreach (Exercice lexo in lentrainement.lesTours[numeroTour - 1].lesExercices)
                {
                    rtxt_log.Text += "\n" + lexo.leNbdeFois.ToString() + " x " + lexo.Nom.ToString();
                }*/

                if (NumCheck <= Convert.ToInt32(cbx_nbTours.SelectedItem.ToString()))
                {
                    AddTour();
                }

        }


        private void btn_AddExo_Click(object sender, EventArgs e)
        {
            if (numeroTour > 0)
            { LoadCbxExercices(nbExercices);
            /*rtxt_log.Text += "\n NOMBRE cbExo : "+lesExercicesCbx.Count.ToString();*/
            }
            else { MessageBox.Show("Il faut ajouter un Tour avant un Exercice"); }
        }

        private void btn_RemoveExo_Click(object sender, EventArgs e)
        {
            if(numeroTour>0)
            { 
            
            SuppUneCbxExo();
            if (nbExercices > 0)
            {
                cbx_TypeEntrainement.Enabled = false;
            }
            else { cbx_TypeEntrainement.Enabled = true;
            btn_AjouterExercices.Visible = false;
            }
            }
        }

        private void SuppUneCbxExo()
        {
                if (y >= 50)
                {
                    if (nbExercices >= 1)
                    {
                        if (numeroTour == root.Nodes.Count && lentrainement.lesTours[numeroTour - 1].lesExercices.Count > 0)
                        {
                      
                        ComboBox lexoSup = lesExercicesCbx.First(a => a.Name == "cbExo" + nbExercices);
                      
                        ComboBox lnbSup = lesnbExericicesCbx.First(a => a.Name == "cbNbExo" + nbExercices);
                      

                        gbxExercices.Controls.Remove(lexoSup);
                        lesExercicesCbx.Remove(lexoSup);

                        gbxExercices.Controls.Remove(lnbSup);
                        lesnbExericicesCbx.Remove(lnbSup);

                        
                            root.Nodes[numeroTour - 1].Nodes.RemoveAt(nbExercices - 1);
                            lentrainement.lesTours[numeroTour - 1].lesExercices.RemoveAt(nbExercices - 1);
                        
                       
                        //lesTreeTours[numeroTour-1].Nodes.RemoveAt(nbExercices-1);
                        //lesTreeExercice[nbExercices].Remove();

                        y -= 20;
                        nbExercices--;
                        }
                        else { MessageBox.Show("Selectionné le Tour qui contient des Exercices pour en supprimer."); }
                    }
                }
            }
        /// <summary>
        /// Supprime tous les controles dans la partie Exercice 
        /// </summary>
        private void SuppAllcbxExo()
        {
            if (y >= 50)
            {
                if (nbExercices >= 1)
                {
                    if (lentrainement.lesTours.Count == 0)
                    {
                        SuppCbxExercice(lesExercicesCbx);

                    }
                    btn_AjouterExercices.Visible = false;
                }
                    // supprime les controles de ma liste 
                    lesExercicesCbx.RemoveRange(0,lesExercicesCbx.Count);
                    lesnbExericicesCbx.RemoveRange(0, lesnbExericicesCbx.Count); ;

                    y = 50;
                
                nbExercices = 0;
            }
        }

        private void SuppCbxExercice(List<ComboBox> lesExercicesCbx)
        {
            foreach (ComboBox lexo in lesExercicesCbx)
            {
                // supprime les contrôles de l'interface
                gbxExercices.Controls.Remove(lexo);
                nbExercices--;
            }
            foreach (ComboBox lnbExo in lesnbExericicesCbx)
            {
                gbxExercices.Controls.Remove(lnbExo);
            }
        }



        private void btn_AddTour_Click(object sender, EventArgs e)
        {
           


            AddTour();
        }

        private void AddTour()
        {
            if (cbx_nbTours.SelectedItem != null)
            {
                if (numeroTour < (Convert.ToInt32(cbx_nbTours.SelectedItem.ToString())))
                {
                    numeroTour++;
                    lbl_numeroTour.Text = Convert.ToString(numeroTour);
                    cbx_TypeEntrainement.Enabled = false;
                    Tour leTour = new Tour { numeroTour = this.numeroTour };

                    root.Nodes.Add(new TreeNode { Name = leTour.numeroTour.ToString(), Text = leTour.numeroTour.ToString() });
                    // lesTreeTours[leTour.numeroTour - 1] = new TreeNode(leTour.numeroTour.ToString());
                   
                    
                    lentrainement.lesTours.Add(leTour);
                }
                else { cbx_TypeEntrainement.Enabled = true; }
            }
        }

        private void btn_RemoveTour_Click(object sender, EventArgs e)
        {
            if (numeroTour > 0)
            {
                if (lentrainement.lesTours.Count > 0)
                {
                    Tour tour = lentrainement.lesTours[lentrainement.lesTours.Count-1];

                    root.Nodes.RemoveAt(tour.numeroTour-1);
                    //lesTreeTours[tour.numeroTour] = new TreeNode { Text = "Non renseigné"};
                   
                    lentrainement.lesTours.Remove(tour);
                    cbx_TypeEntrainement.Enabled = false;
                }

                if (numeroTour == 1)
                {
                    SuppAllcbxExo();
                    numeroTour--;
                    cbx_TypeEntrainement.Enabled = true;
                   
                }
                else { numeroTour--; }
                
                lbl_numeroTour.Text = Convert.ToString(numeroTour);   
            }
            else { cbx_TypeEntrainement.Enabled = true; }
        }
     

        private void Entrainement_Form_Load(object sender, EventArgs e)
        {
            laTreeView.Nodes.Add(root);
        }

        private void btn_ValiderEntrainement_Click(object sender, EventArgs e)
        {
            try
            {
                if (lentrainement.lesTours.Count > 0 || String.IsNullOrEmpty(txt_NomEntrainement.Text) || Convert.ToInt32(cbx_nbTours.SelectedItem.ToString()) > 0)
                {
                    lentrainement.Id = tbx_Id.Text;
                    lentrainement.Nom = txt_NomEntrainement.Text;
                    lentrainement.NbTour = Convert.ToInt32(cbx_nbTours.SelectedItem.ToString());
                    DAL.Instance.AjouterEntrainementDB(lentrainement);
                    tbx_Id.Text =Guid.NewGuid().ToString() ;
                    txt_NomEntrainement.Text = "";
                    cbx_nbTours.SelectedIndex = -1;
                    cbx_TypeEntrainement.SelectedIndex = -1;
                    numeroTour = 0;
                  

                    lbl_numeroTour.Text = numeroTour.ToString();
                    SuppCbxExercice(lesExercicesCbx);
                    root.Remove();
                }
                else { MessageBox.Show("Il manque des valeurs.."); }
            }
            catch (Exception ex)
            {
 
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
