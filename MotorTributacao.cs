namespace KV.MoqSample
{
    public class MotorTributacao
    {
        private readonly IProdutoService produtoService;

        public MotorTributacao(IProdutoService produtoService)
        {
            this.produtoService = produtoService;
        }

        public decimal CalcularImposto(long idProduto)
        {
            var produto = produtoService.ObterProduto(idProduto);

            var precoCalculado = produto.Preco * (1 - produto.Categoria.Desconto);

            var precoComImposto = precoCalculado + 10;

            return precoComImposto;
        }
    }
}