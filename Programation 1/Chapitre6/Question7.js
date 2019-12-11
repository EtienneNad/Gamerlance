var tabPiece=[];
var piece;
var maxVrai = 0;
var nbVraiConsecutif=0;
var nbFauxConsecutif=0;
var maxFaux = 0;
var indiceF;
var indiceV;
var maxIndiceV;
var maxIndiceF;

for (var i=0;i<10;i++){
    piece=Math.round(Math.random());

    if(piece === 0){
       tabPiece.push(false);
   }
   else {
       tabPiece.push(true);
   }
    document.write(tabPiece+" ");

   if (piece === 1){
       if(nbFauxConsecutif != 0){
           indiceV=i;
       }
        nbVraiConsecutif++;
        nbFauxConsecutif = 0;
        indiceF=0;
        if (nbVraiConsecutif > maxVrai) {
            maxVrai = nbVraiConsecutif;
            maxIndiceV=indiceV;
        }
   }
   else   {
       if(nbVraiConsecutif != 0){
       indiceF=i;
   }
       nbFauxConsecutif++;
       nbVraiConsecutif=0;
       indiceV=0;
       if (nbFauxConsecutif > maxFaux){
           maxFaux = nbFauxConsecutif;
           maxIndiceF=indiceF;
       }
   }
}
document.write("<br>"+maxVrai+"<br>");
document.write(maxFaux+"<br>");

document.write(maxIndiceV+"<br>");
document.write(maxIndiceF+"<br>");
