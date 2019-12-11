var tabNombre=[1,2,3,4,5,6,7,8,9,10,11,12];
var somme;
for (var i=0;i<=11;i++){
    for (var j=0;j<=11;j++ ){
    somme=tabNombre[i]+tabNombre[j];

    if (somme===15){
        document.write(tabNombre[i]+"+"+tabNombre[j]+"="+ somme+"<br>");

    }
}
}