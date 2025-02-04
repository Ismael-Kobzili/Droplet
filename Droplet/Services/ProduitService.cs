using System;
using System.Collections.Generic;

namespace Droplet.Models
{
    internal class ProduitService
    {
        public List<ProduitEntity> products = new List<ProduitEntity>
        {
            new ProduitEntity
            {
                Id = 1,
                Nom = "Château de la Rivière",
                Annee = 2015,
                Famille = "Bordeaux",
                Contenance = 75,
                Appellation = "AOC",
                Image = "chateau_riviere.jpg",
                Description = "Un vin rouge de Bordeaux",
                PrixUnitaire = 15,
                Bio = false,
                DegreAlcool = 12,
                Id_Fournisseur = 1 
            },
            new ProduitEntity
            {
                Id = 2,
                Nom = "Ta mere",
                Annee = 2015,
                Famille = "Bordeaux",
                Contenance = 75,
                Appellation = "AOC",
                Image = "chateau_riviere.jpg",
                Description = "Un vin rouge de Bordeaux",
                PrixUnitaire = 15,
                Bio = false,
                DegreAlcool = 12,
                Id_Fournisseur = 1 
            }
        };

        
        public ProduitService()
        {
        }

        public List<ProduitEntity> GetProducts()
        {
            return products;
        }

        public ProduitEntity GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public void AddProduct(ProduitEntity product)
        {
            products.Add(product);
            MessageBox.Show("Produit ajouté avec succès");
        }
        
        public void UpdateProduct(ProduitEntity product)
        {
            var index = products.FindIndex(p => p.Id == product.Id);
            products[index] = product;
        }

        public void DeleteProduct(int id)
        {
            var product = products.Find(p => p.Id == id);
            products.Remove(product);
        }
    }

    
}
