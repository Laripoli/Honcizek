var Trabajos = function () {

    var handler = function () {
        _validar_descripciones();
    };

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