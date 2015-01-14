using MyBuild.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    public class DAL
    {
       List<Equipement> lesEquipement = new List<Equipement>();
       private static DAL instance;
       //const string cnxString = @"Data Source =TOSHIBA-MAT\BASEPCMATHIEU; Initial Catalog=MyBuild;Integrated Security=SSPI";
       const string cnxString = @"Data Source =B2V-CZC3306VZC\SQLEXPRESS; Initial Catalog=MyBuild;Integrated Security=SSPI";
       SqlConnection cnx = null;
       public DAL() {
           cnx = new SqlConnection(cnxString);
       }

       public static DAL Instance
       {
          get 
          {
             if (instance == null)
             {
                 instance = new DAL();
             }
             return instance;
          }
       }

       public List<TypeEntrainement> RecupTypeEntrainement()
       {
           SqlCommand cmd = new SqlCommand("dbo.RecupTypeEntrainement", cnx);
           SqlDataAdapter adapter = new SqlDataAdapter();
           adapter.SelectCommand = cmd;

           // Remplir le DataSet
           DsMyBuild DsDataMyBuild = new DsMyBuild();
           adapter.Fill(DsDataMyBuild, DsDataMyBuild.TableEquipement.TableName);
           var myData = DsDataMyBuild.Tables[0].AsEnumerable().Select(dataRow => new TypeEntrainement { Id = dataRow.Field<string>("Id").Trim(), Nom = dataRow.Field<string>("Nom").Trim() });
           var list = myData.ToList();
           return list;          
       }

       public List<Exercice> RecupExercice(string p_typeExercice)
       {
           /*cnx.Open();
           SqlCommand cmd = new SqlCommand("dbo.RecupExercice", cnx);
           cmd.CommandType = CommandType.StoredProcedure;
           //SqlParameter sqlParam = new SqlParameter("@typeExercice", p_typeExercice);
           cmd.Parameters.Add("@typeExercice", SqlDbType.NVarChar).Value = p_typeExercice;
           SqlDataReader rdr = cmd.ExecuteReader();*/
           List<Exercice> list_Exercice = new List<Exercice>();
           /*while(rdr.Read())
           {
               Exercice l_exercice = new Exercice();
               l_exercice.Id = rdr["id"].ToString().Trim();
               l_exercice.Nom = rdr["name"].ToString().Trim();
               l_exercice.Recompense = Convert.ToInt32(rdr["recompense"].ToString().Trim());

               list_Exercice.Add(l_exercice);
           }
           rdr.Close();
           cnx.Close();*/
           Exercice l_Activite = new Exercice();
           l_Activite.Id = "pup";
           l_Activite.Nom = "Pushups";
           list_Exercice.Add(l_Activite);
           l_Activite = new Exercice();
           l_Activite.Id = "stip";
           l_Activite.Nom = "Situps";
           list_Exercice.Add(l_Activite);
           l_Activite = new Exercice();
           l_Activite.Id = "sqt";
           l_Activite.Nom = "Squats";
           list_Exercice.Add(l_Activite);
           


           return list_Exercice;
       }

        public void AjouterExoEntrainement(string IdEntrainement,string idExercice, int nbfoisExercice)
        {
            try { 
            cnx.Open();
            SqlCommand cmd = new SqlCommand("dbo.RecupExercice", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@IdEntrainement", SqlDbType.NVarChar).Value = IdEntrainement;
            cmd.Parameters.Add("@idExercice", SqlDbType.NVarChar).Value = idExercice;
            cmd.Parameters.Add("@nbfoisExercice", SqlDbType.Int).Value = nbfoisExercice;
            cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DsMyBuild RecupEquipementDB()
        {// TODO : Faire la suite de la procédure
            SqlCommand cmd = new SqlCommand("dbo.RecupEquipement", cnx);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Remplir le DataSet
            DsMyBuild DsDataMyBuild = new DsMyBuild();
            adapter.Fill(DsDataMyBuild, DsDataMyBuild.TableEquipement.TableName);

            return DsDataMyBuild;
        }

        internal List<Equipement> RecupEquipement()
        {
            

            Equipement lequipement = new Equipement();
            lequipement.Id = "bar";
            lequipement.Nom = "Barre de traction";
            lesEquipement.Add(lequipement);
            lequipement = new Equipement();
            lequipement.Id = "100";
            lequipement.Nom = "100 Mètres";
            lesEquipement.Add(lequipement);
            DataSet ds = new DataSet();
            
            return lesEquipement;

        }



        internal void AjouterEquipementDB(Equipement lequipement)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("dbo.AjouterEquipement", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.NVarChar).Value = lequipement.Id.Trim();
                cmd.Parameters.Add("@Nom", SqlDbType.NVarChar).Value = lequipement.Nom.Trim();
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally{
                 
           cnx.Close();
            }
        }
    }
}
