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
    public partial class Equipement_Form : Form
    {
        public Equipement_Form()
        {
            InitializeComponent();
            
            DsMyBuild ds =  DAL.Instance.RecupEquipementDB();
           
            dgv_Equipement.DataSource =ds;
            dgv_Equipement.DataMember = ds.TableEquipement.TableName;
            dgv_Equipement.Columns[0].Visible = false;
        }

        private void Equipement_Form_Load(object sender, EventArgs e)
        {
            txt_IdEquipement.Text = Guid.NewGuid().ToString();
            
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if(txt_NomEquipement.Text != "" || txt_NomEquipement == null)
            {
            Equipement  lequipement = new Equipement();
            lequipement.Id = txt_IdEquipement.Text;
            lequipement.Nom = txt_NomEquipement.Text;
            DAL.Instance.AjouterEquipementDB(lequipement);

            txt_NomEquipement.Clear();
            txt_IdEquipement.Clear();
            txt_IdEquipement.Text = Guid.NewGuid().ToString();
            dgv_Equipement.DataSource = DAL.Instance.RecupEquipementDB();
            dgv_Equipement.Update();
            dgv_Equipement.Refresh();
            
            
            }
            else{
                MessageBox.Show("Le champ équipement est vide.");

            }
        }


        
    }
}
