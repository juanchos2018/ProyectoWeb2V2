﻿listar();

function listar() {
    $.get("Conductor/listaConductor", function (data) {
        crearListado(["ID", "DNI", "NOMBRES", "APELLIDOS"], data);
    });
}


function borrarDatos() {
    var controles = document.getElementsByClassName("borrar");
    var ncontroles = controles.length;
    for (var i = 0; i < ncontroles; i++) {
        controles[i].value = "";
    }
}

function abrirModal(id) {
    if (id == 0) {
        borrarDatos();
    } else {
        $.get("Conductor/recuperarDatos/?id=" + id, function (data) {
            document.getElementById("txtidconductor").value = data[0].IDCONDUCTOR;
            document.getElementById("txtidempresa").value = data[0].IDEMPRESA;
            document.getElementById("txtdni").value = data[0].DNI;
            document.getElementById("txtnombres").value = data[0].NOMBRES;
            document.getElementById("txtapellidos").value = data[0].APELLIDOS;
            document.getElementById("txtcorreo").value = data[0].CORREO;
            document.getElementById("txtclave").value = data[0].CLAVE;
            document.getElementById("imgFoto").src = "data:image/png;base64," + data[0].FOTOMOSTRAR;
        });
    }
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

$("#btnconsultar").click(function () {
    var dni = $("#txtdni").val();

    $.ajax({
        url: '/Conductor/Get_Consulta_Dni/?dni=' + dni,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            
            $("#txtnombres").val(data.primerNombre + " " + data.segundoNombre);
            $("#txtapellidos").val(data.apellidoPaterno + " " + data.apellidoMaterno);

        },
        error: function (err) {
            alert("Error: " + err.responseText);
        }
    });
});


function Agregar() {

    var frm = new FormData();
    var idconductor = document.getElementById("txtidconductor").value;
    var dni = document.getElementById("txtdni").value;
    var nombres = document.getElementById("txtnombres").value;
    var apellidos = document.getElementById("txtapellidos").value;
    var correo = document.getElementById("txtcorreo").value;
    var clave = document.getElementById("txtclave").value;
    var imgFoto = document.getElementById("imgFoto").src.replace("data:image/png;base64,", "");

    frm.append("IDCONDUCTOR", idconductor);
    frm.append("IDEMPRESA", 1);
    frm.append("DNI", dni);
    frm.append("NOMBRES", nombres);
    frm.append("APELLIDOS", apellidos);
    frm.append("CORREO", correo);
    frm.append("CLAVE", clave);
    frm.append("CADENAFOTO", imgFoto);

    if (confirm("¿Desea realmente guardar?") == 1) {
        $.ajax({
            type: "POST",
            url: "Conductor/guardarDatos",
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


    if (window.FormData == undefined)
        alert("Error: FormData is undefined");

    else {
        var fileUpload = $("#fileToUpload").get(0); 
        var dni = $("#txtdni").val();
        var nombres_conductor = $("#txtnombres").val();
        var apellido_conductor = $("#txtapellidos").val();
        var correo_conductor = $("#txtcorreo").val();
        var clave_conductor = $("#txtclave").val();
        var files = fileUpload.files;
        var fileData = new FormData();

        fileData.append(files[0].name, files[0]);
        fileData.append("dni_conductor", dni);
        fileData.append("nombres_conductor", nombres_conductor);
        fileData.append("apellido_conductor", apellido_conductor);
        fileData.append("correo_conductor", correo_conductor);
        fileData.append("clave_conductor", clave_conductor);
      
        // ShowProgress();
        $.ajax({
            url: '/Conductor/CreateConductor',
            type: 'post',
            datatype: 'json',
            contentType: false,
            processData: false,
            async: false,
            data: fileData,
            success: function (response) {
                console.log("respuesta es:" + response);
                //alert("Registrado Conductor  ---");
               // listavehiculos();
            },
            error: function (xhr, status) {
                alert('Disculpe, existió un problema');
            },
        });
    }
    
}

var btnFoto = document.getElementById("fileToUpload");
btnFoto.onchange = function (e) {
    var file = document.getElementById("fileToUpload").files[0];
    var reader = new FileReader();
    if (reader != null) {
        reader.onloadend = function () {
            var img = document.getElementById("imgFoto");
            img.src = reader.result;
        }
        reader.readAsDataURL(file);
    }
}
