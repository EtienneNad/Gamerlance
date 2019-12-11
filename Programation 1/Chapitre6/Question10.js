var tabOption=[ "informatique","administration","Histoire","Génie","Geographie","Bureautique"];
var option=prompt("entrer une option de cours svp");
var trouver = false;
document.write(tabOption);
for (var i=0;i<=6;i++) {


    if(option===tabOption[i]){
        document.write("<br>"+"nous possèedons cette option");
        trouver=true;
    }
}
if(!trouver){
    document.write("<br>"+" désolé nous ne possèdons pas cette option " )
}