using DIO.models;



int a = 10;
int b = 20;

int c = a + b;

//c = c + 5; // 30 + 5
//c -= 5; // c = c - 5;
// c *= 5;
c += 5;

Console.WriteLine(c);



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