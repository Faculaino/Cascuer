document.getElementById("sumar").addEventListener("click", functionSuma);
document.getElementById("restar").addEventListener("click", functionResta);

function functionSuma() {
    var valor = 0;
    valor = document.getElementById("cantidad").value;
    valor = parseInt(valor) + 1;
    $("#cantidad").val(valor);
}

function functionResta() {
    var valor = 0;
    valor = document.getElementById("cantidad").value;
    valor = parseInt(valor) - 1;
    $("#cantidad").val(valor);
}