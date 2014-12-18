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
        public Entrainement_Form()
        {
            
            InitializeComponent();
            LoadCbxType();
            LoadCbxNbTours();
            LoadCbxNbExercices();
        }

        private void LoadCbxNbExercices()
        {
            for (int i = 0; i <= 10; i++)
            {
                cbx_nbrExercices.Items.Add(i);
            }
        }

        private void LoadCbxNbTours()
        {
            for (int i =0;i<=10;i++)
            {
                cbx_nbTours.Items.Add(i);
            }
        }

        private void LoadCbxType()
        {
            List<TypeEntrainement> lesType = new List<TypeEntrainement>();
            lesType = RecupTypeEntrainement();
 
            cbx_TypeEntrainement.DataSource = lesType.ToArray();
            cbx_TypeEntrainement.DisplayMember = "Nom";
            cbx_TypeEntrainement.ValueMember = "Id";
 
            
        }

        private List<TypeEntrainement> RecupTypeEntrainement()
        {
            List<TypeEntrainement> list_TypeEntrainement = new List<TypeEntrainement>();

            TypeEntrainement l_Activite = new TypeEntrainement();
            l_Activite.Id = "str";
            l_Activite.Nom = "Strenght";
            list_TypeEntrainement.Add(l_Activite);

            l_Activite = new TypeEntrainement();
            l_Activite.Id = "for";
            l_Activite.Nom = "Force";
            list_TypeEntrainement.Add(l_Activite);

            return list_TypeEntrainement;
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
            lbl_CompteurTours.Visible = true;
            lbl_NbExercices.Visible = true;
            cbx_nbrExercices.Visible = true;
        }
    }
}
