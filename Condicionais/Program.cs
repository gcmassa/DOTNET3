// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();


switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal!");
        break;
    default:
        Console.WriteLine("Não é uma Vogal!");
        break;
}


/*
if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine("Vogal!");
}
else
{
    Console.WriteLine("Não é uma Vogal!");
}
*/


/*
if (letra == "a")
{
    Console.WriteLine("Vogal!");
}
else if (letra == "e")
{
    Console.WriteLine("Vogal!");
}
else if (letra == "i")
{
    Console.WriteLine("Vogal!");
}
else if (letra == "o")
{
    Console.WriteLine("Vogal!");
}
else if (letra == "u")
{
    Console.WriteLine("Vogal!");
}
else
{
    Console.WriteLine("Não é uma Vogal!");
}
*/




/*
//int quantidadeEmEstoque = 10;

//int quantidadeCompra = 0;

//bool possivelVenda = quantidadeCompra >0 && quantidadeEmEstoque >= quantidadeCompra;

//Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
//Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
//Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

//if (quantidadeCompra == 0)
//{
//    Console.WriteLine("Venda inválida!");
//}
//else if (possivelVenda)
//{
 //   Console.WriteLine("Venda Realizada");
//}
//else
//{
//    Console.WriteLine("Desculpe não temos a quantidade desejada em Estoque!");
//}*/
///*
//if (quantidadeEmEstoque >= quantidadeCompra)
//{
//    Console.WriteLine("Venda Realizada");
//}
//else
//{
//    Console.WriteLine("Desculpe não temos a quantidade desejada em Estoque!");
//}*/
