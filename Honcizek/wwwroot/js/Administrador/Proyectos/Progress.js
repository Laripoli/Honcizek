var Progress = function () {

    var handler = function (id_proyecto) {
        _style();
        _faseradio(id_proyecto);
    }

    var _style = function () {
        const $pb = $('#fases');

        function eliminarClase() {
            let classRemove = $pb.attr('class').split(' ')[1];
            $pb.removeClass(classRemove);
        };

        //Reaccion al click
        $('#Analisis').on('click', function () {
            $pb.css('width', '11.2%');
            eliminarClase();
            $pb.addClass('bc-analisis');
        });

        $('#Diseño').on('click', function () {
            $pb.css('width', '21.5%');
            eliminarClase();
            $pb.addClass('bc-diseño');
        });

        $('#Maquetacion').on('click', function () {
            $pb.css('width', '33%');
            eliminarClase();
            $pb.addClass('bc-maquetacion');
        });

        $('#Desarrollo').on('click', function () {
            $pb.css('width', '46.5%');
            eliminarClase();
            $pb.addClass('bc-desarrollo');
        });

        $('#Pruebas\\ internas').on('click', function () {
            $pb.css('width', '60%');
            eliminarClase();
            $pb.addClass('bc-pruebas-internas');
        });

        $('#Pruebas\\ cliente').on('click', function () {
            $pb.css('width', '75%');
            eliminarClase();
            $pb.addClass('bc-pruebas-cliente');
        });

        $('#Implantacion').on('click', function () {
            $pb.css('width', '100%');
            eliminarClase();
            $pb.addClass('bc-implantacion');
        });
    };


    var _faseradio = function (id_proyecto) { //Sin esto al editar la barra no muestra el valor de la fase del proyecto seleccionado   
        $.ajax('/administrador/proyectos/ajax_fases', {
            type: 'post',
            data: { 'proyecto_id': id_proyecto },
            dataType: 'JSON',
            success: function (response) {
                switch (response.fase) {
                    case "Pruebas internas":
                        $("#Pruebas\\ internas").trigger('click');
                        break;

                    case "Pruebas cliente":
                        $("#Pruebas\\ cliente").trigger('click');
                        break;

                    default:
                        $("#" + response.fase).trigger('click');
                }
            }
        });
    }

    return {
        init: function (id_proyecto) {
            handler(id_proyecto);
        },
    }
}();
