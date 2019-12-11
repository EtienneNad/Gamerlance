var nombreA;
var nombreB;
nombreA=prompt("entrer le premier nombre svp");
nombreB=prompt("entrer le deuxieme nombre svp");
if (nombreA<nombreB){
    alert(nombreA+ " plus petit");

}
else if(nombreA>nombreB){
    alert(nombreA+ " plus grand");
}
else if (nombreA===nombreB){
    alert("erreur")
}