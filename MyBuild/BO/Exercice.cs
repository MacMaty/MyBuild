using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild.BO
{
    class Exercice
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public int Recompense { get; set; }
        public Type LeType { get; set; }
        public List<Equipement> lesEquipement=null;

        public Exercice()
        {
            lesEquipement = new List<Equipement>();
        }

        public void AddEquipement(Equipement lequipement)
        {
            lesEquipement.Add(lequipement);
        }
        
    }
}
