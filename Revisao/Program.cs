namespace Revisao
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario =  Menu();       

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO
                        break;
                    case "2":
                        //TODO 
                        break;
                    case "3":
                        //TODO
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = Menu();
            }
        }

        private static string Menu()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir Novo Aluno: ");
            Console.WriteLine("2 - Listar Alunos: ");
            Console.WriteLine("3 - Calcular média geral: ");
            Console.WriteLine("X - Sair: ");
            Console.WriteLine();
        
            string opcao = Console.ReadLine();
            return opcao;
        }
    }
}