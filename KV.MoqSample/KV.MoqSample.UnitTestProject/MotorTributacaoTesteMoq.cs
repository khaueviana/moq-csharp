using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace KV.MoqSample.UnitTestProject
{
    [TestClass]
    public class MotorTributacaoTesteMoq
    {
        private MotorTributacao target;
        private Mock<IProdutoService> mock;

        [TestMethod]
        public void CalculoImpostoTeste()
        {
            mock = new Mock<IProdutoService>();
            target = new MotorTributacao(mock.Object);

            Produto produto = new Produto()
            {
                IdProduto = 1,
                Descricao = "Produto de Teste",
                Preco = 15.00M,
                Categoria = new Categoria()
                {
                    IdCategoria = 1,
                    Desconto = 0.25M
                }
            };

            mock.Setup(x => x.ObterProduto(It.IsAny<long>())).Returns(produto);

            long idProduto = 1;
            decimal esperado = 21.25M;
            decimal obtido = target.CalcularImposto(idProduto);

            Assert.AreEqual(esperado, obtido);
        }
    }
}