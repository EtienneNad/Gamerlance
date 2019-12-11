var tabnombre=[];
for (var i=0;i<=9;i++){
    var nombre=Number(prompt("entrer 10 nombre svp"));
    tabnombre.push(nombre)
}
document.write("plus petit nombre "+Math.min(...tabnombre) + '<br>' + "plus grand Nombre " + Math.max(...tabnombre));