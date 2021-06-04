var Tickets = function () {

    var handler = function () {
        _cargar_hidden();
        _validar();
    };

    var _cargar_hidden = function () {
        var suscripcion_id = $('#SuscripcionId').val();
        if (suscripcion_id != null) {

            $.ajax('/administrador/tickets/cargar_hidden', {
                type: 'post',
                data: { 'suscripcion_id': suscripcion_id },
                dataType: 'JSON',
                success: function (response) {
                    $('#ClienteId').val(response[0]);
                    $('#AgenteId').val(response[1]);
                }
            });
        } else {
            $("#SuscripcionId").append(new Option("No hay suscripciones", null));
        }

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

    var _validar = function () {
        $('form').submit(function () {
            if ($("#SuscripcionId").val() == "null") {
                $("#Error-suscripcion").removeClass("d-none");
                return false;
            } else {
                return true;
            }
        });
    }

   

    return {
        // public functions
        init: function () {
            handler();
        },
    };
}();