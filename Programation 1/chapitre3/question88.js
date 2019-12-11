var prixBase=100;
var longueur;
var bois;
var grosseur;
var prixtotal;
var prixLivraison;
bois=prompt("entrez un type de bois entre de l'érable,le merisier,et bouleau jaune svp");
grosseur=prompt("entrer la grosseur du manche entre gros manche et petit manche svp");
longueur=Number(prompt("entrer la longueur du manche svp"));

if (longueur>33){
    longueur=25;
}
if (bois === "érable"){
    bois=50;

}
if (bois === "bouleau jaune"){
    bois=55;


}
else{

}
if(grosseur==="gros manche"){
    grosseur=10;
}
else{

    }

prixtotal=prixBase+longueur+bois+grosseur;
 prixLivraison=prixtotal*0.15;

alert(" Le prix total du baton est de: " +prixtotal+ " $ ");
alert( " Le prix de la Livraison est de: "+prixLivraison+ " $ ");