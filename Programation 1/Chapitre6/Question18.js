var tabnom=[];

for (var i=0;i<=9;i++){
   tabnom.push(prompt("entrer les 10 nom svp"));


}
tabnom.sort();
for (var z=0;z<tabnom.length;z++){
    document.write("Nom:"+tabnom[z]+"<br>");
}

