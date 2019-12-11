var tab=[1,2,3,4,6,7];
var x=prompt(" entrer un chiffre svp");
 for (var i=0;i<tab.length;i++){
     if (x<tab[i]){
         document.write(x+" "+tab[i]+" ");
         x=tab[tab.length-1];
     }
     else{
         document.write(tab[i]+" ");
     }
 }