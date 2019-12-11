var boucle=0;
var compteur=0;
var Nb0=0;
var Nb1=0;
while (boucle<=100){
    boucle++;
    compteur=Math.floor(Math.random()*2);
    document.write(compteur);
    if (compteur===0){
        Nb0++;

    }
    else if(compteur===1){
        Nb1++;
    }
}
document.write(("<br>"))

document.write(Nb1);
document.write(("<br>"))

document.write(Nb0);
document.write(("<br>"))
