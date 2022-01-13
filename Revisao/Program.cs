
namespace Revisao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;

            string opcaoUsuario = Menu();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        indiceAluno = CadastrarAluno(ref alunos, ref indiceAluno);
                        break;
                    case "2":
                        ListarAlunos(ref alunos);
                        break;
                    case "3":
                        CalcularMediaGeral(ref alunos);

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = Menu();
            }
        }

        private static void CalcularMediaGeral(ref Aluno[] alunos)
        {
            decimal notaTotal = 0;
            var nAlunos = 0;
            for (int i = 0; i < alunos.Length; i++)
            {
                if (!string.IsNullOrEmpty(alunos[i].Nome))
                {
                    notaTotal = notaTotal + alunos[i].Nota;
                    nAlunos++;
                }

            }
            var mediaGeral = notaTotal / nAlunos;
            Conceito conceitoGeral;


            if (mediaGeral < 2)
                conceitoGeral = Conceito.E;
            else if (mediaGeral < 4)
                conceitoGeral = Conceito.D;
            else if (mediaGeral < 6)
                conceitoGeral = Conceito.C;
            else if (mediaGeral < 8)
                conceitoGeral = Conceito.B;
            else
                conceitoGeral = Conceito.A;


            System.Console.WriteLine($"Média geral: {mediaGeral} de {nAlunos} alunos - Conceito: {conceitoGeral}");
        }

        private static void ListarAlunos(ref Aluno[] alunos)
        {
            foreach (var estudante in alunos)
            {
                if (!string.IsNullOrEmpty(estudante.Nome))
                    System.Console.WriteLine($"Aluno: {estudante.Nome} - Nota: {estudante.Nota}");
            }
        }

        private static int CadastrarAluno(ref Aluno[] alunos, ref int indiceAluno)
        {
            Console.WriteLine("Informe o nome do aluno:");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Informe a nota do aluno:");
            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.Nota = nota;
            }
            else
            {
                throw new ArgumentException();
            }
            alunos[indiceAluno] = aluno;
            indiceAluno++;
            return indiceAluno;
        }

        private static string Menu()
        {
            Console.WriteLine();
            Console.WriteLine("----------- Menu ----------------");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir Novo Aluno: ");
            Console.WriteLine("2 - Listar Alunos: ");
            Console.WriteLine("3 - Calcular média geral: ");
            Console.WriteLine("X - Sair: ");
            Console.WriteLine();

            string opcao = Console.ReadLine();
            Console.WriteLine();
            return opcao;
        }
    }
}