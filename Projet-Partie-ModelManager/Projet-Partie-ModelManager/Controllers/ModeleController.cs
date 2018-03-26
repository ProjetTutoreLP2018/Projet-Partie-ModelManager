using Projet_Partie_ModelManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_Partie_ModelManager.Controllers
{
    public class ModeleController : Controller
    {

        private ModeleManager modeleManager = new ModeleManager();

        public Modele RechercherModele(int id)
        {
            return modeleManager.RechercherModele(id);
        }

        public List<Modele> ConsulterModeles()
        {
            return modeleManager.ConsulterModeles();
        }

        public void AjouterModele(Modele modele)
        {
            modeleManager.AjouterModele(modele);
        }

        public Modele ModifierModel(Modele modele)
        {
            return modeleManager.ModifierModel(modele);
        }

        public bool SupprimerModele(Modele modele)
        {
            return modeleManager.SupprimerModele(modele);
        }
    }
}