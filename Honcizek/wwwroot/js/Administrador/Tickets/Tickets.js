var Tickets = function () {

    var handler = function () {
        _cargar_hidden();
    };

    var _cargar_hidden = function () {
        console.log("hola");
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
        init: function () {
            handler();
        },
    };
}();