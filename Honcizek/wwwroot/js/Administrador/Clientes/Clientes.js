var Clientes = function () {

    var handler = function (clave) {
        _ocultar_campos();
        _limpiar_filtros();
        if (clave != "") {
            _esconde_contraseña(clave);
        }
    };

    var _ocultar_campos = function () {
        if ($('#Tipo').val() == "Empresa") {
            $('.tipo-persona').addClass('d-none');
            $('.tipo-empresa').removeClass('d-none');
        } else {
            $('.tipo-empresa').addClass('d-none');
            $('.tipo-persona').removeClass('d-none');
        }



        $('#Tipo').on('change', function () {
            if ($(this).val() == "Empresa") {
                $('.tipo-persona').addClass('d-none').children().val('');
                $('.tipo-empresa').removeClass('d-none');
            } else {
                $('.tipo-empresa').addClass('d-none').children().val('');
                $('.tipo-persona').removeClass('d-none');
            }
        });
    }

    var _limpiar_filtros = function () {
        $('#limpia-filtros').on('click', function (e) {
            $('#filtro').val('');
        });
    }

    var _esconde_contraseña = function (clave) {
        $('#Clave').val('');
        $('form').submit(function () {
            if ($('#Clave').val() == "") {
                $('#Clave').val(clave);
            }
            return true;
        });
    }

    return {
        // public functions
        init: function (clave) {
            handler(clave);
        },
    };
}();