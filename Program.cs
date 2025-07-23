using DIO.models;

//OPERADORES CONDICIONAIS

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada de estoque.");
}


























    //OPERADORES DE ATRIBUIÇÃO

    //Colocar os operadores em parenteses para que possa dar ordem de execução primeiro no cálculo.
    double w = 4 / (2 + 2);

Console.WriteLine(w);


//Casting implicito
int l = 5;
double a = l;

Console.WriteLine(a);


int inteiro = 5;
string s = inteiro.ToString();

Console.WriteLine(s);


//Cast - Casting (Converter a string para inteiro, ou seja, converter um tipo para outro tipo. Todos os tipos podem ser convertidos!)
//int a = Convert.ToInt32("5");
//int a = int.Parse("5c");
//Convert - Classe
//ToInt = é uma método
//Console.WriteLine(a);


//int a = 10;
//int b = 20;

//int c = a + b;

//c = c + 5; // 30 + 5
//c -= 5; // c = c - 5;
// c *= 5;
//c += 5;

//Console.WriteLine(c);


DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));


Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Larissa";
pessoa1.Idade = 23;
pessoa1.Apresentar();


string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;

double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao);