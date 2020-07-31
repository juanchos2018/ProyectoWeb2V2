listar();

function listar() {
    $.get("Pedido/listaPedido", function (data) {
        crearListado(["ID", "NOMBRE USUARIO", "CELULAR", "TOTAL", "ESTADO"], data);
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