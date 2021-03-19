function teste() {
    var funcao = $("#FuncaoId").val();

    url = "/FuncaoFun";

    $.ajax({
        type: "GET",
        url: url,
        data: { id: funcao },
        dataType: "html",
        success: successFunc,
        error: errorFunc
    });

    function successFunc(data) {
        var lista = $("#ListarEpi");
        lista.empty();
        lista.show();
        lista.html(data);
    }

    function errorFunc() {
        alert('error');
    }

}

function funcao1() {
    alert("Eu sou um alert!");
}
