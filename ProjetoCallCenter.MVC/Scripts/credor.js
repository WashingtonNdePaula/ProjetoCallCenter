$(document).ready(function () {
    $("#CEP").blur(function () {
        var cepw = $("#CEP").val();
        var url = "/Credor/ConsultaCEP";
        $("#Logradouro").val("Carregando...");
        $("#Bairro").val("Carregando...");
        $("#Cidade").val("Carregando...");
        $("#UF").val("Carregando...");

        $.get(url, { cep: cepw }, function (data) {
            $("#Logradouro").val(data.Logradouro);
            $("#Bairro").val(data.Bairro);
            $("#Cidade").val(data.Cidade);
            $("#UF").val(data.UF);
        });
    });
});
