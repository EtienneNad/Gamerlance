let tabChance=[];
let nombreUsager=prompt("entrer un nombre entre 1 et 200");
for (let i=0;i<=100;i++){

tabChance[i]=Math.floor(Math.random()*200);

}

document.write(tabChance+"<br>");

if (nombreUsager === tabChance){
     document.write("<br>"+"vous avez trouver un nombre");
}
else {
    document.write("vous N'avez pas réussi")
}

