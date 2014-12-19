using MyBuild.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild
{
    public class DAL
    {

       private static DAL instance;

       public DAL() { }

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
           List<TypeEntrainement> list_TypeEntrainement = new List<TypeEntrainement>();

           TypeEntrainement l_Activite = new TypeEntrainement();
           l_Activite.Id = "str";
           l_Activite.Nom = "Strenght";
           list_TypeEntrainement.Add(l_Activite);

           l_Activite = new TypeEntrainement();
           l_Activite.Id = "for";
           l_Activite.Nom = "Force";
           list_TypeEntrainement.Add(l_Activite);

           return list_TypeEntrainement;
       }



    }
}
