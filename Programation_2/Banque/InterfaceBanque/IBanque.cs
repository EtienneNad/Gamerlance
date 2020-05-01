using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banque;

namespace InterfaceBanque
{
    public interface IBanque 
    {
        /// <summary>
        /// Ajoute une succursale
        /// </summary>
        /// <param name="addresse">L'addresse de la succursale</param>
        void AjouterSuccursale(string adresse);

        /// <summary>
        /// Retire une succursale avec son numéro de transit
        /// </summary>
        /// <param name="noSuccursale">Numéro de transit de la succursale</param>
        /// <returns>Vrai si l'action a fonctionné sinon faux</returns>
        bool RetirerSuccursale(uint noSuccursale);

        /// <summary>
        /// Trouve une succursale avec son numéro de transit
        /// </summary>
        /// <param name="noSuccursale">Numéro de transit de la succursale</param>
        /// <returns>La succursale trouvée</returns>
        ISuccursale TrouverSuccursale(uint noSuccursale);

        /// <summary>
        /// Transfert de l'argent entre deux comptes
        /// </summary>
        /// <param name="montant">Montant d'argent</param>
        /// <param name="source">Compte source</param>
        /// <param name="destination">Compte destinaire</param>
        /// <returns>Vrai si l'action a fonctionné sinon faux</returns>
        bool TransfertEntreComptes(uint montant, ICompte source, ICompte destination);
    }
}
    

