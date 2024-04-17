namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] listaNumeros = new int[4,4];
            Random aleatorio = new Random();

            for (int i = 0; i < listaNumeros.GetLength(0); i++)
            {
                for (int j = 0; j < listaNumeros.GetLength(0); j++)
                {
                    listaNumeros[i, j] = aleatorio.Next();
                    Console.WriteLine(i + ", " + j + ": " + listaNumeros[i, j]);
                }
            }

            int maiorNumero = listaNumeros[1,1];

            foreach (int numero in listaNumeros)
            {
                if(numero > maiorNumero)
                maiorNumero = numero;
            }

            Console.WriteLine("O maior valor é: " + maiorNumero);


        }
    }
}
