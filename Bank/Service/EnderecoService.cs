using AutoMapper;
using Bank.DTOs;
using Bank.Interfaces;

namespace Bank.Service
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;

        public EnderecoService(IMapper mapper,IBrasilApi barsilApi)
        {
            _mapper = mapper;
            _brasilApi = barsilApi;

        }

        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCep(cep);
            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);

        }
    }
}
