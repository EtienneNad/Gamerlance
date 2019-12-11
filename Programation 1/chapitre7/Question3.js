class Guerrier{
    constructor(pv,force,agility,precision){
        this.pv=pv;
        this.force=force;
        this.agility=agility;
        this.precision=precision;
    }
    GetAttaque(){
        this.chance=(Math.random()*1);
        return((this.force*this.precision+this.agility)*this.chance);

}

}

let pv1=100;
let pv2=100;

let force=Math.round((Math.random()*9)+1);
let agility=Math.round((Math.random()*9)+1);
let precision=Math.round((Math.random()*9)+1);
let force1=Math.round((Math.random()*9)+1);
let agility1=Math.round((Math.random()*9)+1);
let precision1=Math.round((Math.random()*9)+1);

let guerrier = new Guerrier(pv1, force,agility,precision);
let guerrier2= new Guerrier(pv2, force1,agility1,precision1);



while (pv1>=0 && pv2>=0){

    pv1-=guerrier2.GetAttaque();
      pv2-=guerrier.GetAttaque();
      document.write("pv = "+pv1+"<br>"+" Dégats = "+Math.round(guerrier.GetAttaque())+"<br>");

    document.write("pv = "+pv2+"<br>"+" Dégats = "+guerrier.GetAttaque()+"<br>");

    document.write("<br>");

}










document.write("pv = "+pv2+"<br>"+" Dégats = "+guerrier2.GetAttaque());

