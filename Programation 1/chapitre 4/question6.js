var jour;
var montantDeposer=0.01;
var montantSolde;



         for(jour=1;jour<=10;jour++){
             montantSolde=0.01* 2;
             if(jour===1){
                 montantSolde=0.01;
             }
     document.write("jour " + jour+"<br>");
     document.write("votre montant déposer est de: " + montantDeposer +"<br>");
     document.write("votre solde est de:" + montantSolde +"<br>");
     }
