using Antlr4.Runtime;
using DotNet.CompiladoresProjetoFinal.App;

class Program
{
    static void Main(string[] args)
    {
        string[] testFiles = new string[] {
            Path.Combine("ANTLR", "ValidTestCases.txt"),
            Path.Combine("ANTLR", "InvalidTestCases.txt")
        };

        foreach (var filePath in testFiles)
        {
            if (!File.Exists(filePath))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Arquivo não encontrado: {filePath}\n");
                continue;
            }

            string[] lines = File.ReadAllLines(filePath);
            var codeLines = lines
                .Where(l => !string.IsNullOrWhiteSpace(l) && !l.TrimStart().StartsWith("#"))
                .ToList();

            string input = string.Join("\n", codeLines);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n===== Analisando: {Path.GetFileName(filePath)} =====\n");
            Console.WriteLine(input);

            AntlrInputStream inputStream = new AntlrInputStream(input);
            VariableDeclarationLexer lexer = new VariableDeclarationLexer(inputStream);
            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            VariableDeclarationParser parser = new VariableDeclarationParser(tokenStream);

            parser.RemoveErrorListeners();
            parser.AddErrorListener(ThrowingErrorListener.Instance);

            try
            {
                var tree = parser.program();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nArquivo válido!");
                Console.WriteLine(tree.ToStringTree(parser));
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nArquivo inválido: " + e.Message);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n==============================================\n");
        }
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
