﻿using ControlePedido.Domain.Adapters.DTOs;
using ControlePedido.Domain.Adapters.Providers;
using ControlePedido.Domain.Entities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ControlePedido.Payment.Services
{
    public class PagamentoMercadoPagoProvider : IPagamentoProvider
    {
        private readonly MercadoPagoApi _mercadoPagoApi;
        private readonly MercadoPagoIntegration _integration;
        private readonly ILogger<PagamentoMercadoPagoProvider> _logger;

        public PagamentoMercadoPagoProvider(ILogger<PagamentoMercadoPagoProvider> logger,
                                            MercadoPagoApi mercadoPagoApi,
                                            IOptions<MercadoPagoIntegration> integration)
        {
            _mercadoPagoApi = mercadoPagoApi;
            _integration = integration.Value;
            _logger = logger;
        }

        public async Task<string> GerarQRCodePagamento(Pedido pedido)
        {
            try
            {
                _logger.LogInformation("recuperando token...");

                var token = _integration.Token;

                _logger.LogInformation(token);

                var urlWebhook = _integration.UrlWebhook;

                long userId = _integration.UserId;

                var pedidoDto = new PedidoMercadoPagoDto(pedido, urlWebhook);

                var result = await _mercadoPagoApi.GerarQrCode(token, pedidoDto, userId, _integration.ExternalPosId);

                return result.QrData;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<PagamentoRealizadoDTO> ValidarTransacao(string idTransacao)
        {
            try
            {
                var pagamento = await _mercadoPagoApi.ConsultarPagamento(_integration.Token, idTransacao);
                return new PagamentoRealizadoDTO
                {
                    PedidoId = Guid.Parse(pagamento.PedidoId),
                    DataPagamento = pagamento.DataHoraPagamento,
                    CodigoTransacao = pagamento.TransacaoId.ToString()
                };
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
