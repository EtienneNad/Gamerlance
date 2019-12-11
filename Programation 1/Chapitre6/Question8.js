
var somme=0;
var moyenne=0;
var nom=[];
var note=[];


for (var i=0;i<5;i++){
    nom[i]=prompt("entre le nom d'un élève");
     note[i]=Number(prompt("entrer la Note d'un élèeve"));

    somme+=note[i];

}
moyenne+=somme/5;
//Je regarde toutes les notes et je sors ceux qui sont en bas de la moyenne
for(var j=0;j<nom.length;j++){
if(note[j]>moyenne){
    document.write("Nom:"+nom[j]+"<br>");
    document.write("Note:"+note[j]+"<br>");


}




}
document.write("moyenne:"+moyenne+"<br>");