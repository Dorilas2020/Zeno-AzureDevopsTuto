using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevopsTuto.Models.BD
{
    public class DBContext
    {
        public List<IEtudiant> Etudiants { set; get; }

        public DBContext()
        {
            Etudiants = new List<IEtudiant>()
            {
                new Etudiant
                {
                    ID = 1,
                    Nom = "Toto",
                    Matricule = "00001"
                },
                new Etudiant
                {
                    ID = 2,
                    Nom = "Tata",
                    Matricule = "00002"
                },
                new Etudiant
                {
                    ID = 3,
                    Nom = "Tonton",
                    Matricule = "00003"
                },
            };
        }
       

    }
}
