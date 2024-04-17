namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoLista;

            Console.WriteLine("Digite o tamanho da lista 1: ");
            bool v = int.TryParse(Console.ReadLine(), out tamanhoLista);
 
            int[] listaNumeros = new int[tamanhoLista];
            int[] listaNumeros2 = new int[tamanhoLista];

            PopularLista(listaNumeros);

            PopularLista(listaNumeros2);

            SomarMostrarValores(listaNumeros, listaNumeros2);



        }

        static void PopularLista(int[] listaNumeros) 
        {
 
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                Console.WriteLine("Digite um novo numero para lista: ");

                if (int.TryParse(Console.ReadLine(), out int valorInteiro))
                {
                    listaNumeros[i] = valorInteiro;
                }

                else
                {
                    Console.WriteLine("Valor invalido, tente novamente \n");
                    i--;
                }

            }
        }

        static void SomarMostrarValores(int[] listaNumeros, int[] listaNumeros2)
        {
            int[] listaNumerosSoma = new int[listaNumeros.Length];

            for (int i = 0; i < listaNumeros.Length; i++)
            {
                listaNumerosSoma[i] = listaNumeros[i] + listaNumeros2[i];
            }
            Console.Write("a soma das duas listas é: ");

            foreach (int numero in listaNumerosSoma)
            Console.Write(numero + " ");


        }
    }
}
