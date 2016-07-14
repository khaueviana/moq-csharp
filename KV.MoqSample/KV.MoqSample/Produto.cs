namespace KV.MoqSample
{
    public class Produto
    {
        public long IdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public Categoria Categoria { get; set; }
    }
}