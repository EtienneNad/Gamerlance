
class Cylindre{

    constructor(rayon,hauteur) {
        this.rayon = rayon;
            this.hauteur = hauteur;


    }

    Getvolume(){
        return("<br>"+"total: "+"<br>"+Math.PI*Math.pow(this.rayon,2) * this.hauteur);

    }

}

let cylindre1 = new Cylindre(14,38);
let cylindre2= new Cylindre(2,10);






class Boite{
    constructor(tabCylindre){
    this.tabCylindre = tabCylindre;
    }
    getVolumeBoite(){
        let somme=0;
        for(let i=0;i<this.tabCylindre.length;i++){
            somme += this.tabCylindre[i].Getvolume();
        }
        return somme;
    }

}
let tabC=[];
let cy1=new Cylindre(9,3);
let cy2=new Cylindre(10,3);
let cy3=new Cylindre(11,3);
let cy4=new Cylindre(12,3);
let cy5=new Cylindre(13,3);
tabC.push(cy1);
tabC.push(cy2);
tabC.push(cy3);
tabC.push(cy4);
tabC.push(cy5);

let boite=new Boite(tabC);
document.write("<br>");
document.write(boite.getVolumeBoite()+"<br>");
