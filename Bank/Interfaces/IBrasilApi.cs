using Bank.DTOs;
using Bank.Models;

namespace Bank.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep);
        Task<ResponseGenerico<BancoModel>>BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string CodigoBanco);


    }
}
