﻿using System.ComponentModel;
using ControlePedido.Domain.Entities;
using ControlePedido.Domain.Enums;

namespace ControlePedido.Application.DTOs;

[DisplayName("AcompanhamentoPedido")]
public class AcompanhamentoPedidoDTO
{
    public Guid Id { get; private set; }
    public string? CpfCliente { get; private set; }
    public StatusPedido Status { get; private set; }

    public AcompanhamentoPedidoDTO(Pedido pedido)
    {
        Id = pedido.Id;

        if (pedido.Cliente is not null)
            CpfCliente = pedido.Cliente.Cpf.Numero;
        else
            CpfCliente = "Cpf não informado!";

        Status = pedido.RetornarStatusAtual();
    }
}
