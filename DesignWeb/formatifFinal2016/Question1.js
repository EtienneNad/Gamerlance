let tab=[];
let mots=prompt("entrer un mots S.V.P");
tab=0;
tab=mots;
if (tab!="Noël" && tab!="noël" && tab!="Noel" && tab!="noel"){
    for (let i=0;i<tab.length;i++){
        document.write("*"+[]);
    }
}
    else if (tab==="Noël" || tab==="noël" || tab==="Noel" || tab==="noel"){

let tab2D=[][];
            let tab1 = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];
            let tab2 = [1, 2, 3, 4, 5];
            for (var j = 0; j < tab1.length; j++) {
                // get the size of the inner array
                // loop the inner array
                for (var k = 0; k < tab2.length; k++) {


                    if (j === 0 && k === 0){
                        tab2D[0][0]= true;
                        tab2D[1][0]= true;
                        tab2D[2][0]= true;
                        tab2D[3][0]= true;
                        tab2D[4][0]= true;
                        tab2D[1][1]= true;
                        tab2D[j][k]= true;
                        tab2D[j][k]= true;
                        tab2D[j][k]= true;
                        tab2D[j][k]= true;
                        tab2D[j][k]= true;
                        tab2D[j][k]= true;
                        tab2D[j][k]= true;
                        tab2D[j][k]= true;
                        tab2D[j][k]= true;
                        tab2D[j][k]= true;
                        tab2D[j][k]= true;
                        document.write(" * ");

                    }

                }

            }
            document.write(  tab1+"<br>"+tab2);



}

