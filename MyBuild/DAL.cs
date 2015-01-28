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
       const string cnxString = @"Data Source =TOSHIBA-MAT\BASEPCMATHIEU; Initial Catalog=MyBuild;Integrated Security=SSPI";
       //const string cnxString = @"Data Source =B2V-CZC3306VZC\SQLEXPRESS; Initial Catalog=MyBuild;Integrated Security=SSPI";
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
           
           SqlCommand cmd = new SqlCommand("dbo.RecupExercice", cnx);
           cmd.CommandType = CommandType.StoredProcedure;
           //SqlParameter sqlParam = new SqlParameter("@typeExercice", p_typeExercice);
           cmd.Parameters.Add("@typeExercice", SqlDbType.NVarChar).Value = p_typeExercice;

           SqlDataAdapter adapter = new SqlDataAdapter();
           adapter.SelectCommand = cmd;

           //Remplir le DataSet
           DsMyBuild dsDataMyBuild = new DsMyBuild();
           adapter.Fill(dsDataMyBuild, dsDataMyBuild.TableExercice.TableName);
           var myData = dsDataMyBuild.Tables[2].AsEnumerable().Select(dataRow => new Exercice
           {
               Id = dataRow.Field<string>("Id").Trim(),
               Nom = dataRow.Field<string>("Nom").Trim(),
               Recompense = Convert.ToInt32(dataRow.Field<string>("Recompense")),
               lEquipement = new Equipement{
                   Id = dataRow.Field<string>("IdEquipement").Trim(),
                   Nom = dataRow.Field<string>("NomEquipement").Trim()
               }
           });
           var list = myData.ToList();
           return list;    


           /*
           SqlDataReader rdr = cmd.ExecuteReader();

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
           cnx.Close();
          
*/
        
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
            SqlCommand cmd = new SqlCommand("dbo.RecupEquipement", cnx);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Remplir le DataSet
            DsMyBuild DsDataMyBuild = new DsMyBuild();
            adapter.Fill(DsDataMyBuild, DsDataMyBuild.TableEquipement.TableName);
            var myData = DsDataMyBuild.Tables["TableEquipement"].AsEnumerable().Select(dataRow => new Equipement
            {
                Id = dataRow.Field<string>("Id").Trim(),
                Nom = dataRow.Field<string>("Nom").Trim(),

            });
            var list = myData.ToList();
            return list;    

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

        internal void AjouterExercice(Exercice lexercice)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("dbo.AjouterExercice", cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idExercice", SqlDbType.NVarChar).Value = lexercice.Id.Trim();
                cmd.Parameters.Add("@nomExercice", SqlDbType.NVarChar).Value = lexercice.Nom.Trim();
                cmd.Parameters.Add("@recompense", SqlDbType.Int).Value = lexercice.Recompense;
                cmd.Parameters.Add("@idEquipement", SqlDbType.NVarChar).Value = lexercice.lEquipement.Id.Trim();
                cmd.Parameters.Add("@idTypeEntrainement", SqlDbType.NVarChar).Value = lexercice.LeType.Id.Trim();
                cmd.Parameters.Add("@imgPath", SqlDbType.VarChar).Value = lexercice.imagePath.Trim();
                //cmd.Parameters.Add("@image", SqlDbType.Binary).Value = Convert.ToByte(lexercice.image);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                cnx.Close();
            }
        }

        internal void AjouterEntrainementDB(Entrainement lentrainement)
        {
            cnx.Open();
            SqlTransaction sqlT = cnx.BeginTransaction("SampleTransaction");
            try
            {
            
            SqlCommand cmd = new SqlCommand("dbo.AjouterEntrainement", cnx);
            cmd.Transaction = sqlT;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idEntrainement", SqlDbType.NVarChar).Value = lentrainement.Id.Trim();
            cmd.Parameters.Add("@nomEntrainement", SqlDbType.NVarChar).Value = lentrainement.Nom.Trim();
            cmd.Parameters.Add("@nbTour", SqlDbType.Int).Value = lentrainement.NbTour;
            cmd.ExecuteNonQuery();
            

            foreach (var leTour in lentrainement.lesTours)
            {
                foreach (var Lexercice in leTour.lesExercices)
                {
                    cmd = new SqlCommand("dbo.AjouterTour", cnx);
                    cmd.Transaction = sqlT;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idEntrainement", SqlDbType.NVarChar).Value = lentrainement.Id.Trim();
                    cmd.Parameters.Add("@idExercice", SqlDbType.NVarChar).Value = Lexercice.Id;
                    cmd.Parameters.Add("@numeroTour", SqlDbType.NVarChar).Value = leTour.numeroTour;
                    cmd.Parameters.Add("@nbFoisExercice", SqlDbType.Int).Value = Lexercice.leNbdeFois;
                    cmd.Parameters.Add("@sequenceExercice", SqlDbType.Int).Value = Lexercice.sequence;
                    cmd.ExecuteNonQuery();
                    
                }
            }
            sqlT.Commit();
             }
            catch (Exception ex)
            {
                sqlT.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {

                cnx.Close();
            }

        }

        internal List<Entrainement> RecupEntrainementDB()
        {
            
            Entrainement lesEntrainements = new Entrainement();
            SqlCommand cmd = new SqlCommand("dbo.RecupEntrainement", cnx);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // Remplir le DataSet
            DsMyBuild DsDataMyBuild = new DsMyBuild();
            adapter.Fill(DsDataMyBuild, DsDataMyBuild.TableEntrainement.TableName);
            var myData = DsDataMyBuild.Tables["TableEntrainement"].AsEnumerable().Select(dataRow => new Entrainement
            {
                Id = dataRow.Field<string>("Id").Trim(),
                Nom = dataRow.Field<string>("Nom").Trim(),
                NbTour =dataRow.Field<int>("NbTour")

            });
            var list = myData.ToList();
            return list;    
        }

       

        internal List<Tour> RecupExerciceParTour(string p_idEntrainement, int p_nbTour)
        {
            cnx.Open();
            List<Tour> lesTours = new List<Tour>();
            for (int i = 1; i <= p_nbTour; i++)
            {
                Tour leTour = new Tour { numeroTour = i };
                SqlCommand cmd = new SqlCommand("dbo.RecupExerciceParTour", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter sqlParam = new SqlParameter("@typeExercice", p_typeExercice);
                cmd.Parameters.Add("@idEntrainement", SqlDbType.NVarChar).Value = p_idEntrainement;
                cmd.Parameters.Add("@numeroTour", SqlDbType.Int).Value = i;

              SqlDataReader rdr = cmd.ExecuteReader();

           List<Exercice> list_Exercice = new List<Exercice>();
           while(rdr.Read())
           {
               Exercice l_exercice = new Exercice();
               l_exercice.Id = rdr["idExercice"].ToString().Trim();
               l_exercice.Nom = rdr["Nom"].ToString().Trim();
               l_exercice.Recompense = Convert.ToInt32(rdr["Recompense"].ToString().Trim());
               l_exercice.imagePath = rdr["imgPath"].ToString().Trim();
               l_exercice.leNbdeFois = Convert.ToInt32(rdr["nbFoisExercice"].ToString().Trim());
               l_exercice.sequence = Convert.ToInt32(rdr["sequenceExercice"].ToString().Trim());
               list_Exercice.Add(l_exercice);
           }
           rdr.Close();
           leTour.lesExercices = list_Exercice;

           lesTours.Add(leTour);
     
            }
            cnx.Close();
            return lesTours;  
        }
    }
}
