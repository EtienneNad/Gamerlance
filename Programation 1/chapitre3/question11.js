var sexe=prompt("entrer une lettre svp");
var nbM=0;
var nbF=0;

 while(sexe==="m"||sexe==="M"||sexe==="f"||sexe==="F"){
sexe=prompt("entrer une lettre svp");


    if(sexe==="m"||sexe==="M"){
nbM++;

   }


   else if(sexe==="f"||sexe==="F"){
       nbF++;
   }
}

document.write("<br>");
document.write(nbM+" Masculin");
document.write("<br>");
document.write(nbF+" Féminin");
