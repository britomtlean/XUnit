using Calculadora.Services;

int n1 = 1;
int n2 = 2;

Calculadoraimp c = new Calculadoraimp();

Console.WriteLine($"{n1} + {n2} é igual a {c.Somar(n1, n2)}");

