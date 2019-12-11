//#1 identifier les variable
var salaire;
var jour;
var heure;
var revenue;
//étape 2 lire les données
salaire=prompt("entrer votre salaire svp:");
jour=prompt ("entrer le nombre de jour que vous travailler svp:");
heure=prompt("entrer le nombre d'heure que vous travailler par jour svp:");

revenue=salaire * heure *jour;

alert("voici votre revenue brut:" + revenue+"$");
