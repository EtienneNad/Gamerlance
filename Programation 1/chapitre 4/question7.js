var nombre;
var nbligne=0;

for( nombre=1;nombre<=49;nombre+=2){
    if(nbligne>=5){
        document.write("<br>");

nbligne=0
    }
    document.write( nombre);
    nbligne++;
}