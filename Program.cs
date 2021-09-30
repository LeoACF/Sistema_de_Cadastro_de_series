using System;

namespace DIO.series
{
    class Program
    {
        static void Main(string[] args)
        {
            static SerieRepositorio repositorio = new SerieRepositorio();
            string OpcaoUsuario = ObterOpcaoUsuario();
            while (OpcaoUsuario.Toupper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSerie();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "c":
                        Console.Clear();
                        break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
                OpcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços");
            Console.ReadLine();
        }
        public static void ListarSerie()
        {
            Console.WriteLine("Listar series");
            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma serie encontrada");
                return;
            }
            foreach (var serie in lista)
            {
                var Excluido = serie.retornaExcluido();

                Console.WriteLine("#ID {0}: . {1} . {2}", serie retornaId(), serie retornaTitulo(), (Excluido ?"Excluido" : ""));
            }
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Insira uma nova Serie:")
            
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} . {1}", Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o genero entre as opcoes acima");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Insira o Titulo da serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da serie:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a Descricao da serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id:repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        Titulo: entradaTitulo,
                                        ano: entradaAno,
                                        Descricao: entradaDescricao);
        }
        private statc void AtualizarSerie()
        {
            Console.WriteLine("Digite o ID da serie: ");
            int indiceSerie = int.parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} . {1} ", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o Genero da serie: ");
            int entradaGenero = int.parse(Console.ReadLine());

            Console.WriteLine("Insira o Titulo da serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da serie:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a Descricao da serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie AtualizarSerie = new Serie(id:indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        Titulo: entradaTitulo,
                                        ano: entradaAno,
                                        Descricao: entradaDescricao);
            repositorio.Atualizar(indiceSerie, AtualizarSerie);
        }
        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o Id da serie: ");
            int indiceSerie = int.parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }
        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o Id da serie: ");
            int indiceSerie = int.parse(Console.ReadLine());

            var serie = repositorio.retornaId(indiceSerie);

            Console.WriteLine(serie);
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine('Dio series à seu dispor');
            Console.WriteLine('Informe a opcao desejada');
            
            Console.WriteLine('1.Listar series');
            Console.WriteLine('2.Inserir nova serie');
            Console.WriteLine('3.Atualizar serie');
            Console.WriteLine('4.Excluir serie');
            Console.WriteLine('5.Visualizar serie');
            Console.WriteLine('c.Limpar a tela');
            Console.WriteLine('x.Sair');
            Console.WriteLine();

            string OpcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoUsuario;
        }
    }
}
