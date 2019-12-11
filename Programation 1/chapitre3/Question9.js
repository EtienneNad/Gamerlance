var nombrePositif=0;
var nombreNegatif=0;
var chiffreUsager=1;

while (chiffreUsager != 0){

     chiffreUsager=Number(prompt("entrer un nombre svp"));

    if (chiffreUsager>0){

       nombrePositif ++;
    }


    else if(chiffreUsager<0){
        nombreNegatif++;
    }
}
document.write("nombre de chiffre positif "+nombrePositif);
document.write("<br>");
document.write("nombre de chiffre negatif "+nombreNegatif);
