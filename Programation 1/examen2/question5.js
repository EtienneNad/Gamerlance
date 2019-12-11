var  nbHorizontal =Number(prompt("entrer un chiffre svp" ));
var nbVertical =Number(prompt("entrer un chiffre svp"));
var nombre1 =1;
var nombre2=1;
var total;
var k = nbHorizontal;
var point= 3*nbHorizontal;
document.write("* |"+" ");
for(var z=1;z<=nbHorizontal; z++) {
    document.write(nombre2+" ");
 nombre2++
}
document.write("<br>"+" ");
for(var t=1;t<=point; t++) {
    document.write("-"+" ");

}

nombre2=1;
document.write("<br>");

for ( var j =1 ;j<=nbVertical; j++){
     document.write(nombre1+" | "+" ");
for (var i = 1; i <= nbHorizontal; i++){
    total=nombre1*nombre2;
    document.write(total+" ");
    if ( k === nombre2){
    nombre1++;
    k =+ nbHorizontal;
    document.write("<br>"+" ");
    nombre2=0;
    }
    nombre2++;
}
}