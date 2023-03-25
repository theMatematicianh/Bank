using System.Text.Json.Serialization;

namespace Bank.DTOs
{
    public class BancoResponse
    {
        public string? Ispb { get; set; }


        public string? NomeAbreviado { get; set; }

        public int? Codigo { get; set; }

        public string? NomeCompleto { get; set; }
    }
}
