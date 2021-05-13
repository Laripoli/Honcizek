var Clientes = function () {

    var handler = function () {
        _ocultar_campos();
        _limpiar_filtros();
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

    return {
        // public functions
        init: function () {
            handler();
        },
    };
}();