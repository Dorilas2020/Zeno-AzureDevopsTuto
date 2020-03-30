namespace AzureDevopsTuto.Models
{
    public interface IEtudiant
    {
         int ID { set; get; }
         string Nom { set; get; }
         string Matricule { set; get; }
    }
}