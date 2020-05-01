using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banque;

namespace InterfaceBanque
{
   public interface IClients
    {

        string Nom { get; }
        uint Nas { get; }
        string Adresse { get; }

        /// <summary>
        /// Crée un compte
        /// </summary>
        /// <param name="nom">Nom du compte</param>
        /// <param name="margeCredit">Marge de crédit du compte (0 si aucune marge)</param>
        void AjouterCompte(string nom, uint margeCredit);

        /// <summary>
        /// Retire un compte
        /// </summary>
        /// <param name="noCompte">Numéro du compte</param>
        /// <returns>Vrai si l'action a fonctionné sinon faux</returns>
        bool SupprimerCompte(uint noCompte);

        /// <summary>
        /// Trouve un compte à l'aide de son numéro de compte
        /// </summary>
        /// <param name="noCompte">Numéro du compte</param>
        /// <returns>Retourne le compte trouvé</returns>
        ICompte TrouverCompte(uint noCompte);

        /// <summary>
        /// Depose de l'argent dans un compte
        /// </summary>
        /// <param name="noCompte">Numéro du compte</param>
        /// <param name="montant">Montant d'argent à déposer</param>
        /// <returns>Vrai si l'action a fonctionné sinon faux</returns>
        bool DeposerArgent(uint noCompte, uint montant);

        /// <summary>
        /// Retire de l'argent du compte
        /// </summary>
        /// <param name="noCompte">Numéro du compte</param>
        /// <param name="montant">Montant d'argent à retirer</param>
        /// <returns>Vrai si l'action a fonctionné sinon faux</returns>
        bool RetirerArgent(uint noCompte, uint montant);
    }
}
