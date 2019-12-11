var base =prompt("entrer une base svp.");
var exposant =prompt("entrer un exposant svp.");
var nombre=0;
var reponse;
var i;
for (i=0;i<=exposant;i++){
    reponse=Math.floor(Math.pow(base,nombre));

  document.write(base +" exp "+nombre+" = "+reponse+"<br>");
  nombre++;
}

