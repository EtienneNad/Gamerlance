var nb=1;
var nbLigne=5;
var nbcolonne=4;


for (var i=0;i<nbLigne; i++){
    for (var j=0;j<nbcolonne; j++){

        document.write(nb+" ");
        if (j!=nbcolonne-1){
            
        nb+=1;
    }

    }
     nb=nb*2;



    document.write("<br>");
}

