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

namespace MyBuild.MesProgrammes
{
    public partial class VoirProgramme_Form : Form
    {
        public VoirProgramme_Form()
        {
            InitializeComponent();
            RecupeEntrainement();
        }

        private void VoirProgramme_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(@"C:\Users\m_boyer\Desktop\ImageEntrainement\jumping-jacks-133x75.jpg");
            pictureBox1.Image = image;
        }

        private void RecupeEntrainement()
        {
            lbx_Entrainement.SelectedIndex = -1;
            List<Entrainement> lesEntrainements = DAL.Instance.RecupEntrainementDB();
            
            lbx_Entrainement.DataSource = lesEntrainements.ToArray() ;
            lbx_Entrainement.ValueMember = "Id";
            lbx_Entrainement.DisplayMember = "Nom";
            
        }

        private void lbx_Entrainement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_Entrainement.SelectedIndex != -1)
            {
                List<Entrainement> lesEntrainements = DAL.Instance.RecupEntrainementDB();
                Entrainement entrain = lesEntrainements.Find(c => c.Id == lbx_Entrainement.SelectedValue.ToString());

                AfficherTour(entrain);
            }
        }

        private void AfficherTour(Entrainement p_entrainement)
        {
              List<Tour> lesTours =   DAL.Instance.RecupExerciceParTour(p_entrainement.Id,p_entrainement.NbTour);
              foreach (Tour leTour in lesTours)
              {
                  foreach (Exercice lExercice in leTour.lesExercices)
                  {
                      

                  }
              }
            

               
        }


    }
}
