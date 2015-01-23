using MyBuild.MesProgrammes;
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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btn_Gestion_Click(object sender, EventArgs e)
        {
            btn_Entrainements.Visible = true;
            btn_Exercices.Visible = true;
            btn_Equipements.Visible = true;
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void btn_Entrainements_Click(object sender, EventArgs e)
        {
            Entrainement_Form ef = new Entrainement_Form();
            ef.Show();
        }

        private void btn_Exercices_Click(object sender, EventArgs e)
        {
            Exercice_Form ef = new Exercice_Form();
            ef.Show();
        }

        private void btn_Equipements_Click(object sender, EventArgs e)
        {
            Equipement_Form ef = new Equipement_Form();
            ef.Show();
        }

        private void btn_programme_Click(object sender, EventArgs e)
        {
            VoirProgramme_Form vp = new VoirProgramme_Form();
            vp.Show();

        }
    }
}
