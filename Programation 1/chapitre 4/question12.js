var nombre=1;
var ligne=1;
var i;
for(i=1;ligne<=13;i+=2){
    document.write(nombre+"<br>");
    if(nombre===11){
        nombre=-1;

    }
    ligne++;
    nombre+=2;
}