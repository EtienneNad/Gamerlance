
var miseInitiale2=prompt("entrer votre mise svp");
var banque2=prompt("montant d'argent,");
var condition=prompt("montant max");
var choix2=Number(prompt("chosiser 0 ou 1"));
var tab3=[];
for (var z=0;z<1000;z++){
var miseInitiale=miseInitiale2;
var banque=banque2;
var conditionSortie=condition;
var choix=choix2;
var nbdefaite=0;
var nbDefaiteCon=0;
var miseActuel=miseInitiale;
var tab=[];
var tab2=[];
for (var i=0;banque<conditionSortie;i++){
    var random=Math.floor(Math.random()*2);
    if (random===choix){
        tab.push('victoire');
        nbdefaite=0;
        banque++;
        miseActuel=miseInitiale;

    }
    else if(random!=choix){
        tab.push('defaite');
        nbdefaite++;
        miseActuel*=2;
        tab2.push(miseActuel)
    }
    if(nbdefaite>nbDefaiteCon){
        nbDefaiteCon=nbdefaite;

    }
}

document.write(tab+"<br>");
document.write("nombre de défaite consécutive: "+nbDefaiteCon+"<br>");
document.write("Maximum d'argent mise sur la table: "+Math.max(...tab2)+"<br>");
document.write("montant: "+banque>+"<br>");
tab3.push(Math.max(...tab2))
}
document.write("mise maximum:"+Math.max(...tab3));