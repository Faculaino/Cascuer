document.getElementById("sumar").addEventListener("click", functionSuma);
document.getElementById("restar").addEventListener("click", functionResta);

function functionSuma() {
    var valor = 0;
    valor = document.getElementById("quantity2").innerHTML;

    valor = parseInt(valor) + 1;
    $("#quantity2").html(valor);
    // $("#quantity").val(valor);
    var texto = document.getElementById("quantity");
    texto.value = valor;

}

function functionResta() {
    var valor = 0;
    valor = document.getElementById("quantity2").innerHTML;

    if (valor <= 0)
    {
        valor = 0;
    }
    else
    {
        valor = parseInt(valor) - 1;
        //actualizaTotal(-precioUn);
    }
    $("#quantity2").html(valor);
    // $("#quantity").val(valor);
    // actualizaSubtotal(precioUn, valor);
    var texto = document.getElementById("quantity");
    texto.value = valor;
    
}

//function actualizaSubtotal(pu, cantidad) {
//    $("#subtotal2").html(pu * cantidad);
//}

//function actualizaTotal(valor) {
//    var valorTOTAL = parseFloat(document.getElementById("total2").innerHTML);
//    valorTOTAL = valorTOTAL + parseFloat(valor);
//    $("#total2").html(valorTOTAL);
//}





