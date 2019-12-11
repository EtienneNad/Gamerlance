var base;
var hauteur;
var perimetre;
base=Number(prompt("entrer la mesure de la base svp"));
hauteur=Number(prompt("entrer la mesure de la hauteur svp"));

    perimetre=base*hauteur;
    if(perimetre>=100){
        alert(perimetre+"voici votre peérimètre qui est est superieur a 100")
}
    else{
        alert("erreur")
    }