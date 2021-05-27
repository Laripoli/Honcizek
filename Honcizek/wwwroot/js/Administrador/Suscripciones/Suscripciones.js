var Suscripciones = function () {

    var handler = function () {
        _ocultar_campos();
        _periodicidad();
    };

    var _ocultar_campos = function () {

        var proyecto = $('.proyecto select').val();//Guardo el proyecto seleccionado por si se selecciona hardware por error
        var fecha_hasta = $('periodicidad input').val();//Lo mismo pero para la fecha

        if ($('#Tipo').val() == "Hardware") {
            $('.proyecto').addClass('d-none');
            $('.proyecto select').val(null);
        } else {
            $('.proyecto').removeClass('d-none');
            $('.proyecto select').val(proyecto);
        }

        if ($('#Periodicidad').val() == "Abierta") {
            $('.periodicidad').addClass("d-none");
            $('.periodicidad input').val(null);
        } else {
            $('.periodicidad').removeClass("d-none");
            $('.periodicidad input').val(fecha_hasta);
        }




        $('#Tipo').on('change', function () {
            if ($('#Tipo').val() == "Hardware") {
                $('.proyecto').addClass('d-none');
                proyecto = $('.proyecto select').val();
                $('.proyecto select').val(null);
            } else {
                $('.proyecto').removeClass('d-none');
                $('.proyecto select').val(proyecto);
            }
        });

        $('#Periodicidad').on('change', function () {
            if ($('#Periodicidad').val() == "Abierta") {
                $('.periodicidad').addClass("d-none");
                fecha_hasta = $('.periodicidad input').val();
                $('.periodicidad input').val(null);
            } else {
                $('.periodicidad').removeClass("d-none");
                $('.periodicidad input').val(fecha_hasta);
            }
        });



    }

    var _periodicidad = function () {
        _set_fechas();
        $('#Periodicidad').on('change', function () {
            _set_fechas();
        });
        $('#FechaDesde').on('change', function () {
            _set_fechas();
        });
    }

    var _set_fechas = function () {
        /*var fecha = new Date($('#FechaDesde').val());
        var periodicidad = $('#Periodicidad').val();
        switch (periodicidad) {
            case "Anual":
                fecha.setMonth(fecha.getMonth() + 12);
                break;
            case "Mensual":
                fecha.setMonth(fecha.getMonth() + 1);
                break;
            case "Trimestral":
                fecha.setMonth(fecha.getMonth() + 3);
                break;
            case "Semestral":
                fecha.setMonth(fecha.getMonth() + 6);
                break;
            default: 
                break;
        }
        $('#FechaHasta').val(formatDate(fecha));

        $('#Periodicidad').on('change', function () {
            fecha = new Date($('#FechaDesde').val());
            periodicidad = $('#Periodicidad').val();
            console.log(formatDate(fecha));
            if (periodicidad != "Abierta") {
            switch (periodicidad) {
                case "Anual":
                    fecha.setMonth(fecha.getMonth() + 12);
                    break;
                case "Mensual":
                    fecha.setMonth(fecha.getMonth() + 1);
                    break;
                case "Trimestral":
                    fecha.setMonth(fecha.getMonth() + 3);
                    break;
                case "Semestral":
                    fecha.setMonth(fecha.getMonth() + 6);
                    break;
                default:
                    break;
            }
            $('#FechaHasta').val(formatDate(fecha));
            }
        });*/
       
            var fecha = new Date($('#FechaDesde').val());
            var periodicidad = $('#Periodicidad').val();
            console.log(formatDate(fecha));
            if (periodicidad != "Abierta") {
                switch (periodicidad) {
                    case "Anual":
                        fecha.setMonth(fecha.getMonth() + 12);
                        break;
                    case "Mensual":
                        fecha.setMonth(fecha.getMonth() + 1);
                        break;
                    case "Trimestral":
                        fecha.setMonth(fecha.getMonth() + 3);
                        break;
                    case "Semestral":
                        fecha.setMonth(fecha.getMonth() + 6);
                        break;
                    default:
                        break;
                }
                $('#FechaHasta').val(formatDate(fecha));
            }
    }

    function formatDate(date) {
        var d = new Date(date),
            month = '' + (d.getMonth() + 1),
            day = '' + d.getDate(),
            year = d.getFullYear();

        if (month.length < 2)
            month = '0' + month;
        if (day.length < 2)
            day = '0' + day;

        return [year, month, day].join('-');
    }


    return {
        // public functions
        init: function () {
            handler();
        },
    };
}();