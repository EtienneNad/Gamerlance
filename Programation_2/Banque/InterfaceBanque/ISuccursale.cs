using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banque;

namespace InterfaceBanque
{
   public interface ISuccursale 
   {
        string Adresse { get; }
        uint NumeroDeTransit { get; }

        /// <summary>
        /// Inscrit un client a la succursale
        /// </summary>
        /// <param name="adresse">Adresse du client</param>
        /// <param name="nom">Nom du client</param>
        /// <param name="nas">Numéro d'assurance social du client (9 charactères)</param>
        void InscriptionClient(string adresse, string nom, uint nas);

        /// <summary>
        /// Retire un client de la succursale
        /// </summary>
        /// <param name="nas">Numéro d'assurance social du client (9 charactères)</param>
        /// <returns>Vrai si l'action a fonctionné sinon faux</returns>
        bool RetirerClient(uint nas);

        /// <summary>
        /// Trouve un client dans la succursale a l'aide de son NAS
        /// </summary>
        /// <param name="nas">Numéro d'assurance social du client (9 charactères)</param>
        /// <returns>Le client trouvé</returns>
        IClients TrouverClient(uint nas);


    }
}
