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