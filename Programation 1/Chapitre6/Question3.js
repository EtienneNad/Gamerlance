var tabmois=["Janvier","Février","Mars","Avril","Mai","Juin","Juillet","Aout","Septembre","Octobre","Novembre","Décembre"];
var mois=prompt("entrer un mois svp");
var trouver = false;
for (var i=11;0<=i;i--) {
    document.write(tabmois[i]);

    if(mois===tabmois[i]){
    document.write(tabmois[i]);
trouver=true;
}
}
if(!trouver){
    document.write("ce mois n'existe pas" )
}