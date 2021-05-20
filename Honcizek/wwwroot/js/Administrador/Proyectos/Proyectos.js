﻿var Proyectos = function () {

    var handler = function (nuevo) {
        _ocultar_campos();
    /* _limpiar_filtros();*/
         _validar_descripciones();
    };

    var _ocultar_campos = function () {
        if ($('#Tipo').val() == "Interno") {
            $('.cliente-hide').addClass('d-none');
            $('#ClienteId').val("10");
        } else {
            $('.cliente-hide').removeClass('d-none');
            $('#ClienteId').val($('#ClienteId option:first').val());
        }



        $('#Tipo').on('change', function () {
            if ($(this).val() == "Interno") {
                $('.cliente-hide').addClass('d-none');
                $('#ClienteId').val("10");
            } else {
                $('.cliente-hide').removeClass('d-none');
                $('#ClienteId').val($('#ClienteId option:first').val());
            }
        });
    }

    var _validar_descripciones = function () {
        $('input[type="submit"]').on('click', function () {
            if ($('#Descripcion').val() == "") {
                $('#Descripcion').val("Sin descripción");
            }
            if ($('#DescripcionDesarrollo').val() == "") {
                $('#DescripcionDesarrollo').val("Sin descripción del desarrollo");
            }
        })
        
    }

    var _limpiar_filtros = function () {
        $('#limpia-filtros').on('click', function (e) {
            $('#filtro').val('');
        });
    }

    return {
        // public functions
        init: function (nuevo) {
            handler(nuevo);
        },
    };
}();