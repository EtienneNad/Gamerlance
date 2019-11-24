var ligne=6;
var colonne=3;
var nb=0;
var espace=81;

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
    nb-=10;
    nb*=2;
}