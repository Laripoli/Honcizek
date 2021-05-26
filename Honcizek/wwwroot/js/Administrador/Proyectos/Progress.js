var Progress = function () {

    var handler = function (fase) {
        _style();
        if(fase!=null)
        _faseradio(fase);
    }

    var _style = function () {
        const $pb = $('#fases');

        function eliminarClase() {
            let classRemove = $pb.attr('class').split(' ')[1];
            $pb.removeClass(classRemove);
        };

        //Reaccion al click
        $('#Analisis').on('click', function () {
            $('.fase').find('input').attr('checked', false);
            $pb.css('width', '11.2%');
            eliminarClase();
            $pb.addClass('bc-analisis');
            $(this).attr('checked', true);
        });

        $('#Diseno').on('click', function () {
            $('.fase').find('input').attr('checked', false);
            $pb.css('width', '21.5%');
            eliminarClase();
            $pb.addClass('bc-diseno');
            $(this).attr('checked', true);
        });

        $('#Maquetacion').on('click', function () {
            $('.fase').find('input').attr('checked', false);
            $pb.css('width', '33%');
            eliminarClase();
            $pb.addClass('bc-maquetacion');
            $(this) .attr('checked', true);
        });

        $('#Desarrollo').on('click', function () {
            $('.fase').find('input').attr('checked', false);
            $pb.css('width', '46.5%');
            eliminarClase();
            $pb.addClass('bc-desarrollo');
            console.log("d");
            $(this) .attr('checked', true);
        });

        $('#Pruebas\\ internas').on('click', function () {
            $('.fase').find('input').attr('checked', false);
            $pb.css('width', '60%');
            eliminarClase();
            $pb.addClass('bc-pruebas-internas');
            $(this) .attr('checked', true);
        });

        $('#Pruebas\\ cliente').on('click', function () {
            $('.fase').find('input').attr('checked', false);
            $pb.css('width', '75%');
            eliminarClase();
            $pb.addClass('bc-pruebas-cliente');
            $(this) .attr('checked', true);
        });

        $('#Implantacion').on('click', function () {
            $('.fase').find('input').attr('checked', false);
            $pb.css('width', '100%');
            eliminarClase();
            $pb.addClass('bc-implantacion');
            $(this) .attr('checked', true);
        });
    };


    var _faseradio = function (fase) { //Sin esto al editar la barra no muestra el valor de la fase del proyecto seleccionado   
        switch (fase) {
            case "Pruebas internas":
                $("#Pruebas\\ internas").trigger('click');
                break;

            case "Pruebas cliente":
                $("#Pruebas\\ cliente").trigger('click');
                break;

            default:
                $("#" + fase).trigger('click');
                console.log(fase);
        }      
       
    }

    return {
        init: function (fase) {
            handler(fase);
        },
    }
}();
