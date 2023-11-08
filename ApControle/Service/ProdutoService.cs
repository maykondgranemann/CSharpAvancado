using Model;

namespace Service
{
    public class ProdutoService
    {
        public List<Produto> List()
        {
            return new List<Produto>(); 
        }
        public void Create(string nome, string descricao)
        {
            Produto produto = new Produto();    
        }
    }
}