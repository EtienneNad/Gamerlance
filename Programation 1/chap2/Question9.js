var nomUtilisateur;
var motDePasse;
nomUtilisateur=prompt("entrer votre nom d'utilisateur svp");
motDePasse=prompt("entrer votre mot de passe svp");
if(nomUtilisateur==="admin"&& motDePasse==="12345"){
    alert("bonjour "+ nomUtilisateur);
}
else{
    alert("votre nom d'utilisateur ou votre mots de passe est invalide")
}