namespace PDV.Data
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public string? Marca { get; set; }
        public string? Volume { get; set; }
        public string? Peso { get; set; }
        public double? Preco { get; set; }
        public int? Quantidade { get; set; } 
        public string? Data { get; set; } = DateTime.Now.ToLocalTime().ToString();

    }
}
