int contador = 0;

Console.Write("Escolha um numero: ");
int contador2 = Convert.ToInt32(Console.ReadLine());

while (contador < contador2)
{
    Console.WriteLine(contador);
    contador = contador + 2;
}