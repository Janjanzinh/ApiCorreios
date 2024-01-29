using CorreiosApi.Integracao.Interfaces;
using CorreiosApi.Integracao.Refit;
using CorreiosApi.Integracao.Response;
using System.Reflection.Metadata.Ecma335;

namespace CorreiosApi.Integracao
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {
        private readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;
        public ViaCepIntegracao(IViaCepIntegracaoRefit viaCepIntegracaoRefit)
        {

            _viaCepIntegracaoRefit = viaCepIntegracaoRefit;

        }
        public async Task<ViaCepResponse> ObterDadosViaCep(String cep)

        {
            var responseData = await _viaCepIntegracaoRefit.ObterDadosViaCep(cep);
            

            if (responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }
            return null;
        }
    }
}