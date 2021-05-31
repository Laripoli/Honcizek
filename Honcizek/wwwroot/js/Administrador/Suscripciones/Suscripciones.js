var Suscripciones = function () {

    var handler = function (proyecto_id) {
        _ocultar_campos();
        _periodicidad();
        _cargar_proyectos(proyecto_id);
        _check_precio();
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
       
            var fecha = new Date($('#FechaDesde').val());
            var periodicidad = $('#Periodicidad').val();
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

    var _check_precio = function () {


        $('#PrecioAlta').val(parseInt($('#PrecioAlta').val()));
        $('#PrecioPeriodo').val(parseInt($('#PrecioPeriodo').val()));
        $('form').submit(function () {
            if (!($('#PrecioAlta').val() > 0) && !($('#PrecioPeriodo').val() > 0)) {
                $('#ErrorPrecio').removeClass('d-none');
                return false;
            } else {
            $('#ErrorPrecio').addClass('d-none');
            if ($('#Observaciones').val() == "") {
                $('#Observaciones').val("Sin Observaciones");
            }
            return true;
            }
        })
    }

    var _cargar_proyectos = function (proyecto_id) {
        var ProyectoId = proyecto_id;
        var cliente_id = $('#ClienteId').val();
        const clientes = $('#ClienteId');
        const proyectos = $('#ProyectoId');
        const error = $("#ProyectoError");
        proyectos.empty();
        $.ajax('/administrador/suscripciones/cargar_proyectos', {
            type: 'post',
            data: { 'cliente_id': cliente_id },
            dataType: 'JSON',
            success: function (response) {
                error.addClass("d-none");
                proyectos.empty();
                if (response.length > 0) {
                    error.addClass("d-none");
                    response.forEach(proyecto => proyectos.append(new Option(proyecto.Nombre, proyecto.Id)));
                    proyectos.removeAttr("disabled");
                    if ($("#ProyectoId option[value='" + ProyectoId + "']").length > 0) {
                        proyectos.val(ProyectoId);
                    }
                } else {
                    proyectos.append(new Option("Sin proyectos", null));
                }
            }
        }).fail(function () {
            error.removeClass("d-none");
        });

        clientes.on('change', function () {
            cliente_id = $('#ClienteId').val();
            proyectos.attr("disabled", true);
            $.ajax('/administrador/suscripciones/cargar_proyectos', {
                type: 'post',
                data: { 'cliente_id': cliente_id },
                dataType: 'JSON',
                success: function (response) {
                    error.addClass("d-none");
                    proyectos.empty();
                    if (response.length > 0) {
                        error.addClass("d-none");
                        response.forEach(proyecto => proyectos.append(new Option(proyecto.Nombre, proyecto.Id)));
                        proyectos.removeAttr("disabled");
                    } else {
                        proyectos.append(new Option("Sin proyectos", null))
                    }
                }
            }).fail(function () {
                error.removeClass("d-none");
            });
        });

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
        init: function (proyecto_id) {
            handler(proyecto_id);
        },
    };
}();