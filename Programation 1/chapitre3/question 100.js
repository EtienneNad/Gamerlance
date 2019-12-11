var nombre1;
var nombre2;
var variableX=Math.floor(Math.random()*10);
var variableY=Math.floor(Math.random()*10);
var somme;
var produit;
produit=variableX*variableY;
somme= variableX+variableY;
alert(" vous devez deviner le résultat");

alert("la somme est X+Y="+ somme);
alert("le produit est X*Y="+ produit);


nombre1=prompt("entrer nombre1 SVP");
nombre2=prompt("entrer nombre2 SVP");

if(nombre1+nombre2===somme && nombre1*nombre2===produit){
alert("vous avez gagner");
}
else{
    alert("vous avex perdu");
}
alert(somme);
alert(produit);
