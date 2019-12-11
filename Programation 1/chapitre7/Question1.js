


    let personne3 = {
        nom : "pikachu",
        type: "foudre",
        hp: 50,
        nomattaque1:"Agility",
        degatAttaque1:0,
        nomAttaque2:"Thundershock",
        degatAttaque2:20
};
    for( let cle in personne3) {
        document.write(cle+":"+"<br>"); // Affichera la clé (prenom, nom, age)
        document.write(personne3[cle]+"<br>"); // Affichera la valeur associée à la clé ("Shany", "Carle", 38)
    }


