var nombre1;
var nombre2;
var produit;
var somme;
nombre1=Number(prompt("entrer le premier nombre svp"));
nombre2=Number(prompt("entrer le deuxième nombre svp"));



if (nombre1>=10&&nombre2>=10){
    somme=nombre1+nombre2;
    alert(somme+" votre nombre est supérieur ou égale a 10");
}

else{
    produit=nombre1*nombre2;
    alert(produit+ " votre nombre est inférieur a 10")
}