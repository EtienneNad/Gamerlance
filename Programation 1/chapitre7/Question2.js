let personne4 = {};
personne4.nom= "Greninja";
    personne4.type= "eau";
    personne4.hp= 230;
    personne4.nomattaque1="Haze slash";
personne4.degatAttaque1=110;
personne4.nomAttaque2="Shadowy Hunter";
personne4.degatAttaque=130;

for( let cle in personne4) {
    document.write(cle+":"+"<br>"); // Affichera la clé (prenom, nom, age)
    document.write(personne4[cle]+"<br>"); // Affichera la valeur associée à la clé ("Shany", "Carle", 38)
}
