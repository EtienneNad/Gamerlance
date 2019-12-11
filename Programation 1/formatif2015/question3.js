var album1=0;
var usager=1;
var album2=0;
var album3=0;
var album4=0;
var album5=0;
var indiponible=0;

while (usager != 0){
    usager=Number(prompt("entrer un chiffre svp"));
    if (usager===1){

        album1++;
    }
    if (usager===2){

        album2++;
    }
        if (usager===3){

            album3++;
        }

        if (usager===4){

            album4++;
        }

        if (usager===5){

            album5++;
        }
        else if (usager>5){

            indiponible++;
        }
}
    document.write(album1+" album Enfants"+"<br>");
    document.write(album2+" album Rock"+"<br>");
    document.write(album3+" album Détente"+"<br>");
    document.write(album4+" album Populaire"+"<br>");
    document.write(album5+" album Jazz"+"<br>");
    document.write(indiponible+" cette option n'est pas disponible"+"<br>");


