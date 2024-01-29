using CorreiosApi.Integracao.Response;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Refit;

namespace CorreiosApi.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(String cep);
    }
}
