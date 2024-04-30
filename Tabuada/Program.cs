int numTabuada;

Console.Write("Digite o número da tabuada desejada:");
numTabuada = Convert.ToInt32(Console.ReadLine());

//repetição 10x

for (int i = 1; i <=10; i++)
{
    //interpolação de string $
    Console.WriteLine($"{numTabuada}x{i} = {numTabuada * i}");
}