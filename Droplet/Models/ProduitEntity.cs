using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droplet.Models
{
    internal class ProduitEntity
    {
        private string v;

        public int Id { get; set; }
        public string Nom { get; set; }
        public int Annee { get; set; }
        public string Famille { get; set; }
        public float Contenance { get; set; }
        public string Appellation { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }

        public decimal PrixUnitaire { get; set; }

        public bool Bio { get; set; }

        public float DegreAlcool { get; set; }

        public int Id_Fournisseur { get; set; }
    }
}
