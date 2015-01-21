using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuild.BO
{
    public class Exercice
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public int leNbdeFois { get; set; }
        public int Recompense { get; set; }
        public string imagePath { get; set; }
        public Image image { get; set; }
        public TypeEntrainement LeType { get; set; }
        public Equipement lEquipement=null;

        public Exercice()
        {
            lEquipement = new Equipement();
        }

        
        
    }
}
