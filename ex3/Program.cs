namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] listaNumeros = new int[3,3];

            for (int i = 0; i < listaNumeros.GetLength(0); i++)
            {
                for (int j = 0; j < listaNumeros.GetLength(0); j++)
                {
                    Console.WriteLine("Digite um novo numero para lista: ");

                    if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                    {
                        listaNumeros[i,j] = valorInteiro;
                    }

                    else
                    {
                        Console.WriteLine("Valor invalido, tente novamente");
                        i--;
                    }
                }
            }

            foreach (int numero in listaNumeros)
            {
                Console.Write(numero + " ");
            }
        }
    }
}
