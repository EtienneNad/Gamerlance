var nombre=10;
var ligne=1;
var i;
for(i=1;ligne<=12;i++){
document.write(nombre+"<br>");
    if(nombre===0){
        nombre=12;

    }
    ligne++;
    nombre-=2;
}