var sommePositive=0;
var sommeNégative=0;
var chiffreUsager=Number(prompt("entrer un chiffre svp"));
while (chiffreUsager !=0){
    if (chiffreUsager>0){
        sommePositive += chiffreUsager;
    }
    else{
        sommeNégative+=chiffreUsager;
    }
     chiffreUsager=Number(prompt("entrer un chiffre svp"));
}
alert("somme des Positive");
alert("somme des Négative");
