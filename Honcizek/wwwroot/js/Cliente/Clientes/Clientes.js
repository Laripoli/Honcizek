var Clientes = function () {

    var handler = function () {
        _ocultar_campos();
        _limpiar_filtros();
        _cargar_localidades();
        _validacion();
    };

    var _ocultar_campos = function () {
        if ($('#Tipo').val() == "Empresa") {
            $('.tipo-persona').addClass('d-none');
            $('.tipo-empresa').removeClass('d-none');
        } else {
            $('.tipo-empresa').addClass('d-none');
            $('.tipo-persona').removeClass('d-none');
        }



        $('#Tipo').on('change', function () {
            if ($(this).val() == "Empresa") {
                $('.tipo-persona').addClass('d-none').children().val('');
                $('.tipo-empresa').removeClass('d-none');
            } else {
                $('.tipo-empresa').addClass('d-none').children().val('');
                $('.tipo-persona').removeClass('d-none');
            }
        });
    }

    var _limpiar_filtros = function () {
        $('#limpia-filtros').on('click', function (e) {
            $('#filtro').val('');
        });
    }

    var _cargar_localidades = function () {
        var provincia_id = $('#ProvinciaId').val();
        const localidades = $('#LocalidadId');
        const provincias = $('#ProvinciaId');
        const error = $("#LocalidadError");
        localidades.empty();
        $.ajax('/administrador/clientes/cargar_localidades', {
            type: 'post',
            data: { 'provincia_id': provincia_id },
            dataType: 'JSON',
            success: function (response) {
                error.addClass("d-none");
                localidades.empty();
                if (response.length > 0) {
                    error.addClass("d-none");
                    response.forEach(localidad => localidades.append(new Option(localidad.Nombre, localidad.Id)));
                    localidades.removeAttr("disabled");
                } else {
                    error.removeClass("d-none");
                }
            }
        }).fail(function () {
            error.removeClass("d-none");
        });

        provincias.on('change', function () {
            provincia_id = $('#ProvinciaId').val();
            localidades.attr("disabled", true);
            
            $.ajax('/administrador/clientes/cargar_localidades', {
                type: 'post',
                data: { 'provincia_id': provincia_id },
                dataType: 'JSON',
                success: function (response) {
                    error.addClass("d-none");
                    localidades.empty();
                    if (response.length > 0) {
                        error.addClass("d-none");
                        response.forEach(localidad => localidades.append(new Option(localidad.Nombre, localidad.Id)));
                        localidades.removeAttr("disabled");
                    } else {
                        error.removeClass("d-none");
                    }
                }
            }).fail(function () {
                error.removeClass("d-none");
            });
        });

    }

    var _validacion = function () {
        const tipo = $("#Tipo");
        const razon = $("#RazonSocial");
        const nombre = $("#Nombre");
        const apellidos = $("#Apellidos");
        const error_empresa = $("#ErrorEmpresa");
        const error_nombre = $("#ErrorNombre");
        const error_apellidos = $("#ErrorApellidos");
        var stop = false;
        $('form').submit(function () {
            if (tipo.val() == "Empresa") {
                if (razon.val() == "") {
                    error_empresa.removeClass("d-none");
                    stop = true;
                } else {
                    error_empresa.addClass("d-none");
                    stop = false;
                }
            } else {
                if (nombre.val() == "") {
                    error_nombre.removeClass("d-none");
                    stop = true;
                } else {
                    error_nombre.addClass("d-none");
                }
                if (apellidos.val() == "") {
                    error_apellidos.removeClass("d-none");
                    stop = true;
                } else {
                    error_apellidos.addClass("d-none");
                }

                if (nombre.val() != "" && apellidos.val() != "") {
                    stop = false;
                }
            }

            if (stop) return false;
            else
            return true;

        });
    }

    return {
        // public functions
        init: function (clave) {
            handler(clave);
        },
    };
}();