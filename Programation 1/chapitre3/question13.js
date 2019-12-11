var nombre=999;
var nb1;
var nb2;
var nb3;
var total;
var boucle=1000;

while (boucle<1000){
boucle--;
if(nombre<10){
     total =nombre** 3
}
else if(nombre<100){
nb1=nombre[0];
nb2=nombre[1];
total=nb1**3+nb2**3;
}
else if(nombre<1000){
    nb1=nombre[0];
    nb2=nombre[1];
    nb3=nombre[2];
    total=nb1**3+nb2**3+nb3**3;
}
else{
alert(total="erreur");
}
}
document.write(total+"ceci est un nombre amstrong");