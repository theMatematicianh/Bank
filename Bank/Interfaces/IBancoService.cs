using Bank.DTOs;
using Bank.Models;

namespace Bank.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<BancoModel>> BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>> BuscarBanco(string CodigoBanco);
    }
}
