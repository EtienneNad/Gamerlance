var tab1=["V","F","F","V","F","V","F","V","V","F","V","F"];
var tab2=[];

var bonneReponce=0;
document.write(tab1+"<br>");
for (var i=0;i<tab1.length;i++){


    tab2.push(prompt("enter V ou F"));
    if (tab1[i]===tab2[i]){
bonneReponce++



    }
    document.write(tab2[i]);
}


document.write("<br>"+"vous avez "+bonneReponce+"/"+tab1.length+" bonne Réponce")