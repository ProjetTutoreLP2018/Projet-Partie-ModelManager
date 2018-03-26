using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Partie_ModelManager.Models
{
    public class ModeleManager
    {

        /*
         * Méthode qui permet de retourner un 
         * Modele
         * */
        public Modele RechercherModele(int id)
        {
            return null;
        }


        /*
         * Méthode qui permet de renvoyer la 
         * liste des modele de la base
         * de données
         * */
        public List<Modele> ConsulterModeles()
        {
            return null;
        }


        /*
         * Méthode qui permet d'ajouter un nouveau
         * modele dans la base de données
         * */
        public void AjouterModele(Modele modele)
        {

        }


        /*
         * Méthode qui permet de modifier
         * un modele existant dant la base de données.
         * On renvoie ce modele une fois modifier.
         * */
        public Modele ModifierModel(Modele modele)
        {
            return null;
        }


        /*
         * Méthode qui permet de supprimer un
         * modele dans la base de donneés.
         * Elle renvoie un booléen pour connaître
         * la réussite de cette méthode.
         * */
        public bool SupprimerModele(Modele modele)
        {
            return false;
        }
    }
}