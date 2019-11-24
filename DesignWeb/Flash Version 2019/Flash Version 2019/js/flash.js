//On positionne Flash en relative pour accéder aux déplacements X et Y
//Par défaut un élément est statique
$('#flashID').css("position","relative");
$('#boutonGauche').click(function () {
    $('#flashID').css( "left","-=10");

});
$('#boutonDroite').click(function () {
    $('#flashID').css( "left","+=10");

});
$('#boutonChangerImage').click(function () {
  var nomimage=$('#flashID').attr("src");

  if (nomimage==="img/Flash2.png"){
      $('#flashID').attr("src","img/Flash1.png");

  }
  else{
      $('#flashID').attr("src","img/Flash2.png")
  }
});
$('#boutonEnleverImage').click(function () {
    $('#flashID').remove();


});
$('#boutonAjouterImage').click(function () {
    $('#flashID').after("<img id=\"flashID\" class=\"flashClass\" src=\"img/Flash1.png\" width=\"200px\"/>");

});
$('#boutonAjouterAttribut').click(function () {
    $('#flashID').attr("alt","image de flash");
});
var timer;
$('#boutonPerso1').click(function () {
    timer=setInterval(AttaqueEclair,500);
});
var compteur=0;
var compteur2=0;
 function AttaqueEclair () {

    if(compteur>=1 && compteur<=25) {
        $('#flashID').css("left","+=50");


 }
     if(compteur>=25 && compteur<=30){

         $('#flashID').css("top","+=50");


     }
     if(compteur>=29 && compteur<=53){

         $('#flashID').css("left","-=50");


     }
compteur2++;
compteur++;
 }