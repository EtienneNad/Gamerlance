let octet = [];
let motPasseInvalides = [];
let motPasseUsager = "1234";
let motPasseTemp;
let motDePasseValide = "false";
let nbTentatives = 0;

function AfficherMenu(){
    document.write("1 - Lire octet <br> 2 - Afficher octet <br> 3 - Traduire octet" );
    let choix = 0;
    while(choix != 4){
        choix = Number(prompt("Choisissez la bonne option 1-2-3-4"));

        if(choix === 1){
            LireOctet();
        }
        else if(choix === 2){
            AfficherOctet();
        }
        else if(choix === 3){
            TraduireOctet();
        }
    }
}

function LireOctet(){
    for(let i =0;i<8;i++){
        octet[i] = prompt("Entrez true ou false");
    }
}

function AfficherOctet(){
    for(let i =0;i<8;i++){
        document.write(octet[i]);
    }
}

function TraduireOctet(){
    let position = 7;
    let total = 0;
    for(let i =0;i<8;i++){
        if(octet[i] === "true"){
            total += Math.pow(2,position);
        }
        position--;
    }
    document.write(total);
}

while(motDePasseValide === "false" && nbTentatives <  3) {
    motPasseTemp = prompt("Entrez le mot de passe");

    if (motPasseTemp != motPasseUsager) {
        motPasseInvalides.push(motPasseTemp);
        nbTentatives++;
    }
    else{
        motDePasseValide = true;
    }
}

if(motDePasseValide === false){
    document.write("Message d'erreur mauvais mots de passe");
    document.write(motPasseInvalides[0] + " " + motPasseInvalides[1] + " " + motPasseInvalides[2])
}
else if(motDePasseValide === true){
    AfficherMenu();
    }