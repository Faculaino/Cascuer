$(document).ready(function () {

    $(".btnSumar").click(function () {
        var idObtenido = $(this).attr("name");
        var valor = 0;

        valor = document.getElementById("quantity2").innerHTML;
        valor = parseInt(valor) + 1;

        $('.valorNumeric').each(function () {
            if ($(this).attr("name") == $("#quantity2").attr("name"))
            {
                $(".valorNumeric").text(valor);
            }
            
        });
      
        var texto = document.getElementById("quantity");
        texto.value = valor;
    });

    $(".btnRestar").click(function () {
        var idObtenido = $(this).attr("name");
        var valor = 0;

        valor = document.getElementById("quantity2").innerHTML;
        valor = parseInt(valor) - 1;

        $('.valorNumeric').each(function () {
            if ($(this).attr("name") == $("#quantity2").attr("name"))
            {
                $(".valorNumeric").text(valor);
            }

        });

        var texto = document.getElementById("quantity");
        texto.value = valor;
    });










});




