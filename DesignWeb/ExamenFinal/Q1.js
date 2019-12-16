let type=prompt("entre le type du pockémon adverse");
let dommage;



let dommage2=Math.round(Math.random());
if (dommage2===1){
dommage2=100;
}
else{
dommage2=0;
}
let dommage3=Math.round(Math.random());

if (dommage3===1){
    dommage3=100;
}
else{
    dommage3=0;
}
dommage=dommage2+dommage3;
if (type==="eau"){
    dommage*=2;
}
document.write(dommage);