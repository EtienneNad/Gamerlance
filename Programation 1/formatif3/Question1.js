
var ligne=16;
var colonne1=1;
var colonne2=1;
var colonne3=1;
var prixbillet=3;
var nb=0;
var espace=15;
var revenue;
document.write(" nombre spectateur"+" prix billet_______ "+" revenue"+"<br>");

for (var i=0;i<ligne;i++){
    revenue=nb*prixbillet;
    for (var j=0;j<colonne1;j++){

        document.write(nb+" ");
        nb+=10;
    }
    for (var l=0;l<colonne2;l++){
        if (l===0);

        for (var m=0;m<espace;m++){
            document.write("_");
        }
        document.write(prixbillet+"$");
        }
        for (var k=0;k<colonne3;k++){
            if (k===0);

            for (var n=0;n<espace;n++){
                document.write("_");
            }
            document.write(revenue+"$");


        }

    document.write("<br>");


}




