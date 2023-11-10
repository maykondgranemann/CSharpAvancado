using Service;

Console.WriteLine("Hello, World!");

ProdutoService produtoService = new ProdutoService();
foreach (var item in produtoService.List())
{
    Console.WriteLine(item.Nome);
}