var nombre =1;
var ligne =16;
var i;
var z;

for ( i=0; nombre<=32768 ;i++){

    document.write(nombre);
    document.write(" ");
    nombre *=2;

    for ( z=16; ligne===nombre; z*=16){
        document.write("<br>");
        ligne*=16;

    }

}


