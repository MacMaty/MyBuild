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
        int x = 300, y = 50;
        List<PictureBox> lesPicturesBox = new List<PictureBox>();
        List<Label> listLabelTour = new List<Label>();
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
            
            foreach (var lelabel in listLabelTour)
            {
                this.Controls.Remove(lelabel);
            }
            x = 300; y = 50;
        }

        private void AfficherTour(Entrainement p_entrainement)
        {
              List<Tour> lesTours =   DAL.Instance.RecupExerciceParTour(p_entrainement.Id,p_entrainement.NbTour);
              foreach (Tour leTour in lesTours)
              {
                  Label lelabelTour = new Label();
                  lelabelTour.Text = "Tour : "+leTour.numeroTour.ToString();
                  lelabelTour.Location = new Point(x , y-25);
                  listLabelTour.Add(lelabelTour);
                  this.Controls.Add(lelabelTour);
                  foreach (Exercice lExercice in leTour.lesExercices)
                  {
                      
                      PictureBox laPicturebox = new PictureBox();
                      laPicturebox.Width =133;
                      laPicturebox.Height =75 ;

                      Label lelabnbTour = new Label();
                      lelabnbTour.Text = " x " + lExercice.leNbdeFois.ToString();
                      lelabnbTour.Location = new Point(x+135, y);
                      lelabnbTour.Width = 36;
                      this.Controls.Add(lelabnbTour);
                      listLabelTour.Add(lelabnbTour);


                      laPicturebox.Location = new Point(x,y);
                      Image image = Image.FromFile(lExercice.imagePath.Replace(@"\\", @"\"));
                      laPicturebox.Image = image;
                      this.Controls.Add(laPicturebox);
                      lesPicturesBox.Add(laPicturebox);

                      y += 82;
                     
                  }
                  y = 50;
                  x += 172;
              }
            

               
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (lbx_Entrainement.SelectedIndex >= 0)
            {
                var id = lbx_Entrainement.SelectedValue;
                DAL.Instance.SupprimerEntrainement(id);
                VoirProgramme_Form vp = new VoirProgramme_Form();
                vp.Show();
                this.Close();
            }
        }


    }
}
