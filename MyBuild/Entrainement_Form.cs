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
        private int nbExercices = 0;
        int x = 20, y = 50;
        
        public Entrainement_Form()
        {
           DAL Manager = DAL.Instance;
            InitializeComponent();
            LoadCbxType();
            LoadCbxNbTours();
            
            
        }

        private void LoadCbxExercices(int p_nbExercices)
        {
            
           string typeExo = cbx_TypeEntrainement.SelectedValue.ToString();
           // for (int i = nbExercices; i < p_nbExercices; i++)
           // {
                
                ComboBox cb1 = new ComboBox();
                //cb1.Name = "cbExo" + i+1;
                cb1.Name = "cbExo" + (nbExercices+1);
                gbxExercices.Controls.Add(cb1);
                cb1.Width = 160;
                cb1.Location = new Point(x,y);
                LoadCbxExercices(cb1, typeExo);
                y += 20;
                nbExercices++;
           // }
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
            //lesType = DAL.Instance.RecupTypeEntrainement();
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
            return DAL.Instance.RecupTypeEntrainement();
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
          
            
        }

        private void cbx_nbrExercices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void btn_AddExo_Click(object sender, EventArgs e)
        {

                LoadCbxExercices(nbExercices);

        }

        private void btn_RemoveExo_Click(object sender, EventArgs e)
        {
            
            SuppCbxExo();
        }

        private void SuppCbxExo()
        {
            gbxExercices.Controls.RemoveByKey("cbExo" + (nbExercices));
            if (y >= 50)
            {
                if (nbExercices >= 1)
                {
                    y -= 20;
                    nbExercices--;
                }
            
            }
        }
    }
}
