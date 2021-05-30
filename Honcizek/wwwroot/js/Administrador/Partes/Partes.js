var Partes = function () {

    var handler = function () {
        _check_horas();
    };

    var _check_horas = function () {



        $('form').submit(function () {
            if (!($('#Horas').val() > 0) && !($('#Minutos').val() > 0)) {
                $('#ErrorHoras').removeClass('d-none');
                return false;
            } else {
                $('#ErrorHoras').addClass('d-none');
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