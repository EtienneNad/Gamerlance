var boucle=0;
var compteur=0;
var nbDefaite=0;
var nbVictoire=0;
var nombreUtilisateur;
var nbOrdi;

while (boucle<=10){
    boucle++;
    nbOrdi=Math.floor(Math.random()*2);
    nombreUtilisateur=Number(prompt("entrer un nombre svp"));


document.write(nbOrdi);

    if ( nbOrdi===nombreUtilisateur){

     nbVictoire++;
     alert(nbVictoire+"vous avez gagner")

    }
    else if (nbOrdi!= nombreUtilisateur){
       nbDefaite++;
alert(nbDefaite+"vous avez perdu");
    }
}
document.write("<br>");
document.write("vous gagnez "+nbVictoire);
document.write("<br>");
document.write("vous perdez "+nbDefaite);