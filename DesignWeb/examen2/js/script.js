
$('#buttonGo').click(function () {
    var nom = $('#Word').val();
    if (nom.length<3){
        alert("ce mots est trop court")
    }
    else if (nom.length>12) {
        alert("ce mots est trop long");
    }

    for (let a=0;a<nom.length;a++){
        let lettre=5;
        for (let i=0;i<=4;i++){


            lettre[i]=Math.floor(Math.random()*2);




        $('#lettre' + (a+1)).attr("src","image/"+nom.toUpperCase()[a]+'/'+nom.toUpperCase()[a]+[i]+".jpg");


            }

    }


});

$('#red').click(function () {
    $('#bg').css("background-image","url(\"image/rouge.jpg\")")
});
$('#blue').click(function () {
    $('#bg').css("background-image","url(\"image/bleu.jpg\")")
});
$('#white').click(function () {
    $('#bg').css("background-image","url(\"image/blanc.jpg\")")
});
$('#gray').click(function () {
    $('#bg').css("background-image","url(\"image/gris.jpg\")")
});
$('#blueF').click(function () {
    $('#bg').css("background-image","url(\"image/bleuFonce.jpg\")")
});
$('#black').click(function () {
    $('#bg').css("background-image","url(\"image/noir.jpg\")")
});
$('#pink').click(function () {
    $('#bg').css("background-image","url(\"image/rose.jpg\")")
});
