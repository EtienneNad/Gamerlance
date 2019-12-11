var tauxHoraire;
var heureTravaille;
var salaire;
var heureSupl;
var salaireSupl;
var salaireTot;
tauxHoraire=Number(prompt("entrer votre taux hotaire"));
heureTravaille=Number(prompt("entrer le nombre d'heure travailler"));

if(heureTravaille>40 ){
  heureSupl=heureTravaille-40;

    salaireSupl=tauxHoraire*2*heureSupl;

    salaire=tauxHoraire* 40;
    salaireTot= salaire+salaireSupl;

    alert(salaireTot + " voici votre salaire totale");
}
else if(heureTravaille<40){
salaire=tauxHoraire*heureTravaille;
alert(salaire + " voici votre salaire totale");
}