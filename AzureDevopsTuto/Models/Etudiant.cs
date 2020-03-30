using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevopsTuto.Models
{
    public class Etudiant : IEtudiant
    {
        public int ID { set; get; }
        public string Nom { set; get; }
        public string Matricule { set; get; }

    }

}
