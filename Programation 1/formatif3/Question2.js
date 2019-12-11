var ligne=7;
var colonne=6;
var nb=0;
var espace=6;

for (var i=0;i<ligne;i++){
    for (var j=0;j<colonne;j++){
        if (j===0);

        for (var k=0;k<espace;k++){
            document.write(".");
        }

        document.write(nb+" ");
        nb+=10;
    }
    document.write("<br>");
    espace-=1;

}