var  date;
var article1;
var article2;
var article3;
var totale;
var tps;
var tvq;
date=prompt("entrer la date svp");
article1=Number(prompt("entre le prix de l'article 1 svp"));
article2=Number(prompt("entrer le prix de l'article 2 svp"));
article3=Number(prompt("entrer prix de l'article 3 svp"));
totale=(article1+article2+article3);
tps=(totale*0.05);
tvq=(totale*0.0995);
totale=(totale*1.15);
alert("date"+date);
alert("totale"+totale);
alert("tps"+tps);
alert("tvq"+tvq);




