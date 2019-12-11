class Examen {
    constructor(question=[]) {
        this.question = question;
    }

    GetNotes() {
        let somme = 0;
        for (let i = 0; i < 5; i++) {
            somme += this.question[i];
        }
        return somme;
    }
}

class Etudiant {
    constructor(nom, prenom, examen) {
        this.nom = nom;
        this.prenom = prenom;
        this.examen = examen;
    }


}

let tabEtudiant = [];
for (let j = 0; j < 50; j++) {
    //mettre random()
    let tabQuestion = [];
    for (let k = 0; k < 5; k++) {
        tabQuestion[k] = Math.floor(Math.random() * 20)
    }

    let examen = new Examen(tabQuestion);
    let nom = prompt("entrez le nom");
    let prenom = prompt("Entrez le Prénom");
    tabEtudiant[j] = new Etudiant(nom, prenom, examen);


}
for (let f = 0; f < 50; f++) {
    let note = tabEtudiant[f].examen.GetNotes();
    if (note >= 60) {
        document.write(tabEtudiant[f].prenom + " "+tabEtudiant[f].nom + " notes: " + note+"<br>");


    }




}
