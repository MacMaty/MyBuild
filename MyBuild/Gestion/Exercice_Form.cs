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
    public partial class Exercice_Form : Form
    {
        public Exercice_Form()
        {
            InitializeComponent();
            LoadCbxType();
            LoadCbxEquipement();
        }

        private void btn_AjouterExercice_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_NomExercice.Text) || !String.IsNullOrWhiteSpace(txt_Recompense.Text))
            {
                Exercice lexercice = new Exercice();
                lexercice.Id = Guid.NewGuid().ToString();
                lexercice.Nom = txt_NomExercice.Text;
                lexercice.Recompense = Convert.ToInt32(txt_Recompense.Text);
                lexercice.lEquipement = new Equipement { Id = cbx_IdEquipement.SelectedValue.ToString() };
                lexercice.LeType = new TypeEntrainement { Id = cbx_IdTypeEntrainement.SelectedValue.ToString() };

                DAL.Instance.AjouterExercice(lexercice);

                txt_IdExercice.Clear();
                txt_NomExercice.Clear();
                txt_Recompense.Clear();
            }
            else
            {
                MessageBox.Show("Les valeurs du formulaire doivent être rempli ! ");
            }
        }

        private void LoadCbxType()
        {
            List<TypeEntrainement> lesType = null;
            lesType = DAL.Instance.RecupTypeEntrainement();
            cbx_IdTypeEntrainement.DataSource = lesType.ToArray();
            cbx_IdTypeEntrainement.DisplayMember = "Nom";
            cbx_IdTypeEntrainement.ValueMember = "Id";


        }
        private void LoadCbxEquipement()
        {
            List<Equipement> lesExercices = null;
            lesExercices = DAL.Instance.RecupEquipement();
            cbx_IdEquipement.DataSource = lesExercices.ToArray();
            cbx_IdEquipement.DisplayMember = "Nom";
            cbx_IdEquipement.ValueMember = "Id";
        }

        private void Exercice_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
