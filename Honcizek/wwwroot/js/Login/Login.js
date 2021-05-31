var Login = function () {

    var handler = function () {
        _validar_descripciones();
    };

    var _validar_descripciones = function () {
        var login = false;
        var passwd = false;
        const Login = $('#login'); 
        const LoginError = $('#login-error'); 
        const Password = $('#password'); 
        const PasswordError = $('#password-error'); 

        $('form').submit(function () {
            if (Login.val() == "") {
                login = false;
                LoginError.removeClass("d-none");
            } else {
                login = true;
                LoginError.addClass("d-none");
            }
            if (Password.val() == "") {
                passwd = false;
                PasswordError.removeClass("d-none");
            } else {
                passwd = true;
                PasswordError.addClass("d-none");
            }

            if (login && passwd) {
                return true;
            } else {
                return false;
            }
        })

    }

    return {
        // public functions
        init: function () {
            handler();
        },
    };
}();