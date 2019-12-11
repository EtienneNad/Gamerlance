var tab =[0,1];

var total=0;
for (var k=0;k<=9;k++){

    document.write("<br>");
for (var i=11;i>=0;i--){
    tab[i]=Math.floor(Math.random()*2);
    document.write(tab[i]);



if (tab[i]===1){
    tab[i]=Math.pow(2,i);

}
else{
    tab[i]=0;

}

total+=tab[i];

}
document.write("<br>");
document.write(tab +"="+ total);
    tab=[];
    total=0;
}



