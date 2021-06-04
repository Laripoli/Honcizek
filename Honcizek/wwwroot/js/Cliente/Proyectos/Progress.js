var Progress = function () {

    var handler = function (fase) {
        if(fase!=null)
        _faseradio(fase);
    }
/*

        $('#Pruebas\\ internas').on('click', function () {
        
        });

        $('#Pruebas\\ cliente').on('click', function () {
            
        });
 */
    var _faseradio = function (fase) { //Sin esto al editar la barra no muestra el valor de la fase del proyecto seleccionado   
        const $pb = $('#fases');
        switch (fase) {
            case "Analisis":
                $('.fase').find('input').attr('checked', false);
                $pb.css('width', '11.2%');
                $pb.addClass('bc-analisis');
                $('#Analisis').attr('checked', true);
                break;
            case "Diseno":
                $('.fase').find('input').attr('checked', false);
                $pb.css('width', '21.5%');
                $pb.addClass('bc-diseno');
                 
                break;
            case "Maquetacion":
                $('.fase').find('input').attr('checked', false);
                $pb.css('width', '33%');
                $pb.addClass('bc-maquetacion');
                 
                break;
            case "Desarrollo":
                $('.fase').find('input').attr('checked', false);
                $pb.css('width', '46.5%');
                $pb.addClass('bc-desarrollo');
                console.log("d");
                 
                break;
            case "Pruebas internas":
                $('.fase').find('input').attr('checked', false);
                $pb.css('width', '60%');
                $pb.addClass('bc-pruebas-internas');
               
                 
                break;

            case "Pruebas cliente":
                $('.fase').find('input').attr('checked', false);
                $pb.css('width', '75%');
                $pb.addClass('bc-pruebas-cliente');
                 
                break;
            case "Implantacion":
                $('.fase').find('input').attr('checked', false);
                $pb.css('width', '100%');
                $pb.addClass('bc-implantacion');
                 
                break;
        }      
       
    }

    return {
        init: function (fase) {
            handler(fase);
        },
    }
}();
