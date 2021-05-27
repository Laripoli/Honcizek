var Trabajadores = function () {

    var handler = function () {
        _validar_descripciones();
    };

    var _validar_descripciones = function () {
        $('form').submit(function () {
            var login = $('#Login').val();
            $.ajax('/administrador/trabajadores/login_check', {
                type: 'post',
                data: { 'login': login },
                dataType: 'JSON',
                success: function (response) {
                    console.log(response);
                    if (response == true) {
                        return true;
                    } else {
                        $('#login-error').text('Parece que ese nombre de usuario ya existe..');
                        return false;
                    }
                }, fail: function () {
                    $('#login-error').text('Parece que ese nombre de usuario ya existe..');
                    return false;
                }
            });

        })

    }

    return {
        // public functions
        init: function () {
            handler();
        },
    };
}();