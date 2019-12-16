class MonnaieVirtuelle{
    constructor(nomMonaie,valeurEnUSD,actif,actifUSD){
        this.nomMonnaie=nomMonaie;
        this.valeurEnUSD=valeurEnUSD;
        this.actif=actif;
        this.actifUSD=actifUSD;
    }

}


class porteFeuille {
    constructor(NomProprietaire, tableauMonnaie) {
        this.NomProprietaire = NomProprietaire;
        this.tableauMonnaie= tableauMonnaie;

    }
    tableauMonnaie = [bitcoin,Ethereum,Litecoin];
     NomProprietaire=prompt("entrez le nom");


}
document.write(this.NomProprietaire+this.tableauMonnaie);