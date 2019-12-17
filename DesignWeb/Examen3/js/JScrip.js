$('#cache').hide();
$('#star').click(function () {
    $('#cache').show();
    $('#cache2').hide();$
    ('#cache3').hide();
});
$('#cache2').hide();
$('#marv').click(function () {
    $('#cache2').show();
    $('#cache').hide();
    $('#cache3').hide();
});
$('#cache3').hide();
$('#dc').click(function () {
    $('#cache3').show();
    $('#cache').hide();
    $('#cache2').hide();
});
$(document).ready(function () {
    $('#uname').keyup(function () {
        var nom = $('#uname').val();
        if (nom === 'SLAY' || nom === 'Test'){
            $('#errerUser').css('visibility', 'visible');
            $('#errerUser').css('color', 'red');
            $('#errerUser').html("Nom d'utilisateur non disponible");

        }
        else {
            $('#errerUser').css('visibility', 'visible');
            $('#errerUser').css('color', 'green');
            $('#errerUser').html("Nom d'utilisateur disponible");

        }
    });
});

$(document).ready(function () {
    $('#email').keyup(function () {
        var email = $('#email').val();
        if (email.includes ('@') && email.includes('.')){
            $('#errerEmail').css('visibility', 'visible');
            $('#errerEmail').css('color', 'green');
            $('#errerEmail').html("Email disponible");

        }
        else {
            $('#errerEmail').css('visibility', 'visible');
            $('#errerEmail').css('color', 'red');
            $('#errerEmail').html("email non disponible");

        }
    });
});
$(document).ready(function () {
    $('#password1').keyup(function () {
        var password = $('#password1').val();
        if (password.length < 6){
            $('#errerPwd').css('visibility', 'visible');
            $('#errerPwd').css('color', 'red');
            $('#errerPwd').html('Faible');
        } else if (password.length >= 9){
            $('#errerPwd').css('visibility', 'visible');
            $('#errerPwd').css('color', 'green');
            $('#errerPwd').html('Fort');
        }
        else if (password.length >= 6 || password.length < 9){
            $('#errerPwd').css('visibility', 'visible');
            $('#errerPwd').css('color', 'yellow');
            $('#errerPwd').html('Moyen');
        }

    });
});
$(document).ready(function () {
    $('#password2').keyup(function () {
        var password2 = $('#password2').val();
        var password3= $('#password1').val();
        if (password3 === password2){
            $('#errerPwd2').css('visibility', 'visible');
            $('#errerPwd2').css('color', 'green');
            $('#errerPwd2').html('compatible');

        }
        else if (password3 != password2){
            $('#errerPwd2').css('visibility', 'visible');
            $('#errerPwd2').css('color', 'red');
            $('#errerPwd2').html('mots de passe incompatible');
        }

    });
});