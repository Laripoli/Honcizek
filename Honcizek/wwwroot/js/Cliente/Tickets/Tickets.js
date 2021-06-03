var Tickets = function () {

    var handler = function () {
        _cargar_hidden();
        /*_validar_descripciones();*/
    };

    var _cargar_hidden = function () {
        var suscripcion_id = $('#SuscripcionId').val();
        $.ajax('/administrador/tickets/cargar_hidden', {
            type: 'post',
            data: { 'suscripcion_id': suscripcion_id },
            dataType: 'JSON',
            success: function (response) {
                $('#ClienteId').val(response[0]);
                $('#AgenteId').val(response[1]);
            }
        });

        $('#SuscripcionId').on('change', function () {
            suscripcion_id = $(this).val();
            $.ajax('/administrador/tickets/cargar_hidden', {
                type: 'post',
                data: { 'suscripcion_id': suscripcion_id },
                dataType: 'JSON',
                success: function (response) {
                    $('#ClienteId').val(response[0]);
                    $('#AgenteId').val(response[1]);
                }
            });
        });
        
    }

    var _validar_descripciones = function () {
        $('form').submit(function () {
            if ($('#Descripcion').val() == "") {
                $('#Descripcion').val("Sin descripción");
            }
            return true;
        })

    }

    return {
        // public functions
        init: function () {
            handler();
        },
    };
}();