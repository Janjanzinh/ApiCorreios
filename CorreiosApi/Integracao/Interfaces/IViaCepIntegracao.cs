using CorreiosApi.Integracao.Response;

namespace CorreiosApi.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(String cep);
    }
}
