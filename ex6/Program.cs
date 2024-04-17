namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] animais = 
            { 
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" }
            };

            foreach (string item in animais)
            {
                Console.WriteLine(item);
            }


            
            MenuOpcoes(out string opcao);

            if (opcao.Equals("sair"))
            {
                return;
            }

            Console.WriteLine("o que deseja procurar? ");
            var pesquisa = Console.ReadLine();

            for (int i = 0; i < animais.GetLength(0); i++)
            {
                if (pesquisa.Equals(animais[i, int.Parse(opcao)]))
                {
                    Console.WriteLine("Encontrado: " + ImprimirAnimal(animais, i));
                }
            }
        }

        static string ImprimirAnimal(string[,] animais, int indiceAnimal)
        {
            const int indiceNome = 0;
            const int indiceEspecie = 1;
            const int indiceIdade = 2;
            const int indicePeso = 3;

            string animal = "nome: " + animais[indiceAnimal, indiceNome] + " , especie: " + animais[indiceAnimal, indiceEspecie];

            return animal;
        }

        static void MenuOpcoes(out string opcao)
        {
            Console.WriteLine("Para buscar por nome digite '0' \n"
                            + "Para buscar por especie digite '1' \n" 
                            + "Para buscar por idade digite '2' \n" 
                            + "Para buscar por peso digite '3' \n" 
                            + "Para sair, digite 'sair' ");

            opcao = Console.ReadLine().ToLower();
            opcao = opcao == null ? string.Empty : opcao.Trim();
        }

    }
}

