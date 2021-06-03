var Partes = function () {

    var handler = function () {
        _check_horas();
    };

    var _check_horas = function () {


        $('form').submit(function () {
        var fallo = false;
            if ($('#Horas').val() % 1 != 0) {
                $("#formatoHoras").removeClass("d-none");
                fallo = true;
            } else {
                $("#formatoHoras").addClass("d-none");
            }
            if (!($('#Horas').val() > 0) && !($('#Minutos').val() > 0)) {
                $('#ErrorHoras').removeClass('d-none');
                fallo = true;
            } else {
                $('#ErrorHoras').addClass('d-none');
            }
            if (fallo) {
                return false;
            } else {
                return true;
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