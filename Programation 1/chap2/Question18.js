var montantVente;
var montantEscopte;
var prix;

prix=Number(prompt("entrer le prix svp"));
montantEscopte=0.12;
if (prix>=500){

    montantVente=prix*montantEscopte;
    alert(montantVente+ " voici votre montant d'escompte");
}
else{
    alert(prix+ " votre prix n'a pas de montant d'escompte");
} 