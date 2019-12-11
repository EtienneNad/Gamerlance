var nombre=2;
var ligne=1;
var i;
for(i=0;ligne<=30;i++){
    document.write(nombre+"<br>");
    if(nombre===10){
        nombre=0;

    }
    ligne++;
    nombre+=2;
}
