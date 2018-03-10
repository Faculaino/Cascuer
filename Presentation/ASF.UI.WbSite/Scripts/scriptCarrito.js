document.getElementById("sumar").addEventListener("click", functionSuma);
document.getElementById("restar").addEventListener("click", functionResta);

function functionSuma() {
    var valor = 0;
    var precioUn = parseFloat(document.getElementById("precioUn2").innerHTML);

    valor = document.getElementById("cantidad2").innerHTML;
    valor = parseInt(valor) + 1;
    $("#cantidad2").html(valor);
    $("#subtotal2").html(precioUn * valor);

}

function functionResta() {
    var valor = 0;
    var precioUn = parseFloat(document.getElementById("precioUn2").innerHTML);

    valor = document.getElementById("cantidad2").innerHTML;
    valor = parseInt(valor) - 1;
    $("#cantidad2").html(valor);
    $("#subtotal2").html(precioUn * valor);
}
