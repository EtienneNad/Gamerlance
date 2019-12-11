var prix;
var montantTotal;
var montantReduction;
prix= Number(prompt("entrer le prix svp"));
if (prix<=100.00){
    montantReduction=prix*0.10;
    montantTotal=prix-montantReduction;
}
else if (prix<200.00){
    montantReduction=prix*0.15;
    montantTotal=prix-montantReduction;
}
else if (prix<400.00){
    montantReduction=prix*0.20;
    montantTotal=prix-montantReduction;
}
else if (prix>400.00){
    montantReduction=prix*0.25;
    montantTotal=prix-montantReduction;

}
alert(montantReduction+" voici votre montant de reduction");
alert(montantTotal+" voici votre montant total");



