var Tickets = function () {

    var handler = function (fecha, hora) {
        _finalizar_ticket(fecha, hora);
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

    return {
        // public functions
        init: function (fecha, hora) {
            handler(fecha, hora);
        },
    };
}();