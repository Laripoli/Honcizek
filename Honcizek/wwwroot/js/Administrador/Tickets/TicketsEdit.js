var Tickets = function () {

    var handler = function (fecha, hora) {
        _finalizar_ticket(fecha, hora);
        _cargar_hidden()
    };

    var _finalizar_ticket = function (fecha, hora) {
        const estado = $("#Estado");
        const fechaInput = $("#FechaFinalizacion");
        const horaInput = $("#HoraFinalizacion");
        estado.on('change', function () {
            switch (estado.val()) {
                case "Finalizado":
                case "Cancelado":
                    fechaInput.val(fecha);
                    horaInput.val(hora);
                    break;
                default:
                    fechaInput.val(null);
                    horaInput.val(null);
                    break;
            }
        });

    }

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

    return {
        // public functions
        init: function (fecha, hora) {
            handler(fecha, hora);
        },
    };
}();