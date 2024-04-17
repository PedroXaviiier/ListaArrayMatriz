namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listaNumeros = new int[5];


            for (int i = 0; i < listaNumeros.Length; i++)
            {

                Console.WriteLine("Digite um novo numero para lista: ");

                if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                {
                    listaNumeros[i] = valorInteiro;
                }

                else
                {
                    Console.WriteLine("Valor invalido, tente novamente");
                    i--;
                }


            }

            int menorNumero = listaNumeros[1];

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                if (listaNumeros[i] < menorNumero)
                {
                    menorNumero = listaNumeros[i];
                }
            }

            Console.WriteLine(menorNumero);
        }
    }
}
