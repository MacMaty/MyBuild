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

       private static DAL instance;
       const string cnxString = @"Data Source =TOSHIBA-MAT\BASEPCMATHIEU; Initial Catalog=MyBuild;Integrated Security=SSPI";
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

       public  List<TypeEntrainement> RecupTypeEntrainement()
       {
           cnx.Open();
           SqlCommand cmd = new SqlCommand("dbo.RecupType", cnx);
           cmd.CommandType = CommandType.StoredProcedure;
           SqlDataReader dr = cmd.ExecuteReader();

           List<TypeEntrainement> list_TypeEntrainement = new List<TypeEntrainement>();
           while (dr.Read())
           {
               TypeEntrainement l_Activite = new TypeEntrainement();
               l_Activite.Id = dr["id"].ToString().Trim();
               l_Activite.Nom = dr["name"].ToString().Trim();
               list_TypeEntrainement.Add(l_Activite);
 
           }

           dr.Close();
           cnx.Close();
           return list_TypeEntrainement;
       }

       public List<Exercice> RecupExercice(string p_typeExercice)
       {
           cnx.Open();
           SqlCommand cmd = new SqlCommand("dbo.RecupExercice", cnx);
           cmd.CommandType = CommandType.StoredProcedure;
           //SqlParameter sqlParam = new SqlParameter("@typeExercice", p_typeExercice);
           cmd.Parameters.Add("@typeExercice", SqlDbType.NVarChar).Value = p_typeExercice;
           SqlDataReader rdr = cmd.ExecuteReader();
           List<Exercice> list_Exercice = new List<Exercice>();
           while(rdr.Read())
           {
               Exercice l_exercice = new Exercice();
               l_exercice.Id = rdr["id"].ToString().Trim();
               l_exercice.Nom = rdr["name"].ToString().Trim();
               l_exercice.Recompense = Convert.ToInt32(rdr["recompense"].ToString().Trim());

               list_Exercice.Add(l_exercice);
           }
           rdr.Close();
           cnx.Close();

           return list_Exercice;
       }



    }
}
