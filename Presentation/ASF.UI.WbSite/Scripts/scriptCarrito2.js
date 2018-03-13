
var listaProductos = $("#listaProd").attr("name");

$(document).ready(function () {

    $(".btnSumar").click(function () {
        var idObtenido = $(this).attr("name");
        var valor = 0;

        valor = document.getElementById("quantity2").innerHTML;
        valor = parseInt(valor) + 1;

        $(".nombreCorrecto").html(valor);

        //if (idObtenido == lista.ProducId)
        //{
        //        $(".nombreCorrecto").html(valor);   
        //}
        
        var texto = document.getElementById("quantity");
        texto.value = valor;
    });


    $(".btnRestar").click(function () {
        var idObtenido = $(this).attr("name");
        var valor = 0;

        valor = document.getElementById("quantity2").innerHTML;
        valor = parseInt(valor) - 1;

        $("#quantity2").html(valor);

        var texto = document.getElementById("quantity");
        texto.value = valor;
    });









});




