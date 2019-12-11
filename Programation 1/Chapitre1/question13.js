var nom;
var noteLaboratoire;
var noteExamenMiSession;
var noteExamenFinSession;
var notefinale;

nom=prompt("entrer le nom de l'élève");
noteLaboratoire=Number(prompt("entrer la note d'examen de laboratoire"));
noteExamenMiSession=Number(prompt("entrer la note d'examen de mi session"));
noteExamenFinSession=Number(prompt("entrer la note d'examen de fin de session"));
notefinale=(noteLaboratoire+noteExamenMiSession+noteExamenFinSession)/3;
alert(nom+" voici la note finale que vous avez obtenu "+notefinale);
