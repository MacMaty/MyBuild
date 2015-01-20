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
           y += 20;
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
            string typeExo = cbx_TypeEntrainement.SelectedValue.ToString();
            ComboBox cb1 = new ComboBox();
            //cb1.Name = "cbExo" + i+1;
            cb1.Name = "cbExo" + (nbExercices + 1);
            gbxExercices.Controls.Add(cb1);
            cb1.Width = 160;
            cb1.Location = new Point(x, y);
            LoadCbxExercices(cb1, typeExo);
            lesExercicesCbx.Add(cb1);
            AddCbNbFoisExo();
            nbExercices++;
            if (nbExercices > 0)
            {

                cbx_TypeEntrainement.Enabled = false;
                btn_AjouterExercices.Visible = true;
            }
            else { cbx_TypeEntrainement.Enabled = true;
            btn_AjouterExercices.Visible = false;
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
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Entrainement_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_AjouterEntrainement_Click(object sender, EventArgs e)
        {
            gbx_Entrainement.Visible = true;
            tbx_Id.Text = Guid.NewGuid().ToString();
        }

        private void btn_AjouterExercices_Click(object sender, EventArgs e)
        {
            int nbTour = Convert.ToInt32(cbx_nbTours.SelectedItem.ToString());
            for (int i = 1; i <= nbTour; i++)
            {
                Tour leTour = new Tour();
                leTour.numeroTour = nbTour;
                for (int p = 0; i < nbExercices; i++)
                {
                    ComboBox laComboExercice = lesExercicesCbx[p];
                    ComboBox laComboNbtour = lesnbExericicesCbx[p];
                    Exercice lexercices = new Exercice();
                    List<Exercice> lesExercice = new List<Exercice>();
                    lexercices.Id = laComboExercice.SelectedValue.ToString();
                    lexercices.Nom = laComboExercice.Text;
                    lexercices.LeType = new TypeEntrainement { Id = cbx_TypeEntrainement.SelectedValue.ToString().Trim(), Nom = cbx_TypeEntrainement.Text.Trim() };
                    lexercices.leNbdeFois = Convert.ToInt32(laComboNbtour.SelectedItem.ToString());

                    leTour.lesExercices.Add(lexercices);

                }
                lentrainement.lesTours.Add(leTour);
            }
        }

        private void cbx_nbrExercices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void btn_AddExo_Click(object sender, EventArgs e)
        {
            if (numeroTour > 0)
            { LoadCbxExercices(nbExercices); }
            else { MessageBox.Show("Il faut ajouter un Tour avant un Exercice"); }
        }

        private void btn_RemoveExo_Click(object sender, EventArgs e)
        {
            
            
            SuppCbxExo();
            if (nbExercices > 0)
            {

                cbx_TypeEntrainement.Enabled = false;
            }
            else { cbx_TypeEntrainement.Enabled = true;
            btn_AjouterExercices.Visible = false;
            }
        }

        private void SuppCbxExo()
        {
           
                if (y >= 50)
                {
                    if (nbExercices >= 1)
                    {
                        if(lentrainement.lesTours.Count>0)
                        { lentrainement.lesTours.RemoveAt(nbExercices - 1); }                        
                        gbxExercices.Controls.Remove(lesExercicesCbx[nbExercices-1]);
                        gbxExercices.Controls.Remove(lesnbExericicesCbx[nbExercices-1]);
                        lesnbExericicesCbx.RemoveAt(nbExercices - 1);
                        lesExercicesCbx.RemoveAt(nbExercices - 1);
                        y -= 20;
                        nbExercices--;
                    }

                }
            }

        private void btn_AddTour_Click(object sender, EventArgs e)
        {
            if(numeroTour<(Convert.ToInt32(cbx_nbTours.SelectedItem.ToString())))
            {
            numeroTour++;
            lbl_numeroTour.Text = Convert.ToString(numeroTour);
            }            
        }

        private void btn_RemoveTour_Click(object sender, EventArgs e)
        {
            if (numeroTour > 0)
            {
                if (lentrainement.lesTours.Count > 0)
                {
                    Tour tour = lentrainement.lesTours[numeroTour + 1];
                    lentrainement.lesTours.Remove(tour);
                }
                numeroTour--;
                lbl_numeroTour.Text = Convert.ToString(numeroTour);
            }
        }

        private void gbx_Entrainement_Enter(object sender, EventArgs e)
        {

        }
            
    }
}
