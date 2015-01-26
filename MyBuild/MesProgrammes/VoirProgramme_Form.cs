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
        int x = 600, y = 110;
        List<PictureBox> lesPicturesBox = new List<PictureBox>();
        public VoirProgramme_Form()
        {
            InitializeComponent();
            
            RecupeEntrainement();
        }

        private void VoirProgramme_Load(object sender, EventArgs e)
        {
            
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
                SuppPictureBox();
                Entrainement lentrainement = (Entrainement)lbx_Entrainement.SelectedItem;
                List<Entrainement> lesEntrainements = DAL.Instance.RecupEntrainementDB();
                Entrainement entrain = lesEntrainements.Find(c => c.Id == lentrainement.Id);

                AfficherTour(entrain);
            }
        }

        private void SuppPictureBox()
        {
            foreach (var lapicture in lesPicturesBox)
            {
                this.Controls.Remove(lapicture);
            }
            x = 600; y = 110;
        }

        private void AfficherTour(Entrainement p_entrainement)
        {
              List<Tour> lesTours =   DAL.Instance.RecupExerciceParTour(p_entrainement.Id,p_entrainement.NbTour);
              foreach (Tour leTour in lesTours)
              {
                  foreach (Exercice lExercice in leTour.lesExercices)
                  {
                      
                      PictureBox laPicturebox = new PictureBox();
                      laPicturebox.Width =100;
                      laPicturebox.Height =75 ;

                      
                      laPicturebox.Location = new Point(x,y);
                      Image image = Image.FromFile(lExercice.imagePath.Replace(@"\\", @"\"));
                      laPicturebox.Image = image;
                      this.Controls.Add(laPicturebox);
                      lesPicturesBox.Add(laPicturebox);

                      y += 100;
                      


                     
                      
                  }
                  y = 110;
                  x += 100;
              }
            

               
        }


    }
}
