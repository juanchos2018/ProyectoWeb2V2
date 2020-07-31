﻿listar();

function listar() {
    $.get("Producto/listaProducto", function (data) {
        crearListado(["ID", "NOMBRE", "PRECIO"], data);
    });
}


function crearListado(arrayColumnas, data) {
    var contenido = "";
    contenido += "<table id='dataTable' class='table table-bordered' width='100%' cellspacing='0'>";
    contenido += "<thead>";
    contenido += "<tr>";
    for (var i = 0; i < arrayColumnas.length; i++) {
        contenido += "<td>";
        contenido += arrayColumnas[i];
        contenido += "</td>";
    }
    contenido += "<th>Operaciones</th>";
    contenido += "</tr>";
    contenido += "</thead>";
    var llaves = Object.keys(data[0]);
    contenido += "<tbody>";
    var nfilas = data.length;
    //alert(nfilas);
    for (var i = 0; i < nfilas; i++) {
        contenido += "<tr>";
        for (var j = 0; j < llaves.length; j++) {
            var valorLlaves = llaves[j];
            contenido += "<td>";
            contenido += data[i][valorLlaves];
            contenido += "</td>";

        }
        var llaveId = llaves[0];
        contenido += "<td>";
        contenido += "<button class='btn btn-primary' onclick='abrirModal(" + data[i][llaveId] + ")' data-toggle='modal' data-target='#exampleModalXl'><i class='far fa-edit'></i></button> ";
        contenido += "<button class='btn btn-danger'  onclick='eliminar(" + data[i][llaveId] + ")'><i class='fas fa-trash'></i></button>";
        contenido += "</td>";
        contenido += "</tr>";
    }

    contenido += "</tbody>";
    contenido += "</table>";
    document.getElementById("tabla").innerHTML = contenido;
    $("#dataTable").dataTable(
        {
            searching: true
        });
}

function abrirModal(id) {
    if (id == 0) {
        borrarDatos();
    } else {
        $.get("Producto/recuperarDatos/?id=" + id, function (data) {
            document.getElementById("txtidproducto").value = data[0].IDPRODUCTO;
            document.getElementById("txtidempresa").value = data[0].IDEMPRESA;
            document.getElementById("txtnombre").value = data[0].NOMBRE;
            document.getElementById("txtdescripcion").value = data[0].DESCRIPCION;
            document.getElementById("txtprecio").value = data[0].PRECIO;
            document.getElementById("imgFoto").src = "data:image/png;base64," + data[0].FOTOMOSTRAR;
        });
    }
}

function borrarDatos() {
    var controles = document.getElementsByClassName("borrar");
    var ncontroles = controles.length;
    for (var i = 0; i < ncontroles; i++) {
        controles[i].value = "";
    }
}

function Agregar() {

    var frm = new FormData();
    var idproducto = document.getElementById("txtidproducto").value;
    var nombre = document.getElementById("txtnombre").value;
    var descripcion = document.getElementById("txtdescripcion").value;
    var precio = document.getElementById("txtprecio").value;
    var imgFoto = document.getElementById("imgFoto").src.replace("data:image/png;base64,", "");

    frm.append("IDPRODUCTO", idproducto);
    frm.append("IDEMPRESA", 1);
    frm.append("NOMBRE", nombre);
    frm.append("DESCRIPCION", descripcion);
    frm.append("PRECIO", precio);
    frm.append("CADENAFOTO", imgFoto);
    frm.append("ESTADO", 1);

    if (confirm("¿Desea realmente guardar?") == 1) {
        $.ajax({
            type: "POST",
            url: "Producto/guardarDatos",
            data: frm,
            contentType: false,
            processData: false,
            success: function (data) {
                if (data != 0) {
                    listar();
                    alert("Se ejecuto correctamente")
                    document.getElementById("btnCancelar").click();
                } else {
                    alert("Ocurrio un error")
                }
            }
        });
    }
    else {

    }
}

var btnFoto = document.getElementById("btnFoto");
btnFoto.onchange = function (e) {
    var file = document.getElementById("btnFoto").files[0];
    var reader = new FileReader();
    if (reader != null) {
        reader.onloadend = function () {
            var img = document.getElementById("imgFoto");
            img.src = reader.result;
        }
        reader.readAsDataURL(file);
    }
}