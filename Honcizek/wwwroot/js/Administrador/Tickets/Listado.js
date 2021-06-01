var Listado = function () {

    var handler = function () {
        _limpiar_filtros();
    };

    var _limpiar_filtros = function () {
        $('#limpia-filtros').on('click', function (e) {
            console.log("a");
            $(':input').val('');
        });
    }

    return {
        // public functions
        init: function () {
            handler();
        },
    };
}();