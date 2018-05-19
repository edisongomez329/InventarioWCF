//Para uso de DataContract y de DataMember
//using System.Runtime.Serialization

var url = $("#URL").val();
$(document).ready(function () {    
    ConsultarProductosPorNombreCommand("");
});

function cosultarProductos(nombre) {
    $.get(url + "Index/ConsultarProductosPorNombreAsync?nombre=" + nombre,
        function (data) {
            console.log(data);
        });
};

function crearProducto(id) {    
    var params = $("#formProductos").serialize();
    $.post(url + "Index/CrearProductos", params)
        .done(function (data) {            
            mostrarMensaje();
            $("#formProductos").trigger("reset");
        }).fail(function (xhr, status, error) {            
            alert("Error al crear producto");
        });
};

function mostrarMensaje() {
    $(".alert").removeClass("hidden");
    setTimeout(function () {
        $(".alert").addClass("hidden");
    }, 3000);
};

function ConsultarProductosPorNombreCommand(nombre) {
    $.get(url + "Index/ConsultarProductosPorNombreCommand?nombre=" + nombre, function (data) {
        console.log("Data consultada con command");
        console.log(data);
    });
};