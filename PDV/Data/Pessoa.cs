namespace PDV.Data
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Categoria { get; set; }
        public string? CPF { get; set; }
        public string? Funcao { get; set; }
        public string? Endereco { get; set; }
        public string? Celular { get; set; }

        public string? Data { get; set; } = DateTime.Now.ToLocalTime().ToString();
    }
}
