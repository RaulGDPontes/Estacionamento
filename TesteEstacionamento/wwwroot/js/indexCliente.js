$(document).ready(function () {
    iniciar();
});

function iniciar() {
    let modalSaida = null;
    var recarregarValor = false;
    const tabelaAtivos = $(".estacionamentoAtivo");
    const tabelaHistorico = $(".tabelaHistorico");

    $("#filtro").on("keyup", function (event) {
        FiltrarTabela(tabelaAtivos, $(event.target).val());
    });

    $("#filtroHistorico").on("keyup", function (event) {
        console.log("1")
        FiltrarTabela(tabelaHistorico, $(event.target).val());
    });

    function FiltrarTabela(tabela, valor) {
        tabela.find("tbody").find("#placa").each(function () {

            if (!$(this)[0].innerText.toLowerCase().includes(valor.toLowerCase())) {
                $(this).closest("tr").hide();
            } else {
                $(this).closest("tr").show();
            }
        });
    }

    $("#novaEntrada").on("click", async function (event) {
        event.preventDefault();
        NovaEntradaDeVeiculo()
        $("#entradaVeiculo").modal("toggle");

    });

    function NovaEntradaDeVeiculo() {
        $("#btnConfirmarEntrada").on("click", async function (event) {

            let placa = $("#placaEntrada").val();
            if (/^[a-z]{3}-[0-9]{3}$/.test(placa.toLowerCase())) {

                $.ajax({
                    type: "POST",
                    url: "Cliente/Create",
                    data: {
                        pPlaca: placa
                    },
                    dataType: 'json',
                    success: result => {
                        if (result) {
                            window.location.reload();
                        }
                    }
                });
            } else {
                alert("placa invalida")
            }
        })
    }

    $("#btnMarcarSaida").on("click", async function (event) {
        AbrirModalDeSaidaDeVeiculo(event);
    });

    async function AbrirModalDeSaidaDeVeiculo(event) {
        console.log("chamado");
        if (!modalSaida) {
            modalSaida =
                {
                    PlacaField: $("#placaInputSaida"),
                    EntradaField: $("#entrada"),
                    SaidaField: $("#saida"),
                    TotalField: $("#total")

                }
        }
        $("#modalSaidaVeiculo").modal("show");

        const id = $(event.target).closest("tr").attr("Id");
        var cliente = await buscarCliente(id);
        console.log(cliente);
        modalSaida.PlacaField.val(cliente.placa);
        modalSaida.EntradaField.val(cliente.dataEntrada.split('.')[0]);
        modalSaida.SaidaField.val(cliente.dataSaida.split('.')[0]);
        modalSaida.TotalField.val(cliente.valor);
        if (recarregarValor) {
            clearInterval(recarregarValor);
        } else {
            $("#btnConfirmarSaida").on("click", async function () {
                ConfirmarSaida(cliente.placa);
            });
            btnConfirmarSaida
        }
        recarregarValor = setInterval(function () {
            AbrirModalDeSaidaDeVeiculo(event)
        }, 60000)
    }

    function ConfirmarSaida(placa) {

        $.ajax({
            type: "POST",
            url: "Cliente/MarcarSaida",
            data: {
                pPlaca: placa
            },
            dataType: 'json',
            success: result => {
                if (result) {
                    window.location.reload();
                }
            }
        });
    }

    function buscarCliente(id) {
        return new Promise((resolve, reject) => {
            fetch(`Cliente/Details/${id}`)
                .then(
                    function (response) {
                        if (response.status !== 200) {
                            console.log('Erro na requisição Ajax: ' +
                                response.status);
                            return;
                        }

                        // Examine the text in the response
                        response.json().then(function (data) {
                            resolve(data);
                        });
                    }
                )
                .catch(function (err) {
                    reject(err);
                });
        })
    }

    $("#modalSaidaVeiculo").on('hidden.bs.modal', function () {
        clearInterval(recarregarValor);
    });
}