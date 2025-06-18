using Antlr4.Runtime;
using DotNet.CompiladoresProjetoFinal.App;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

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
                string unformattedTree = tree.ToStringTree(parser);
                Console.WriteLine(unformattedTree);

                string formattedTree = FormatParseTree(unformattedTree);
                string outputFileName = Path.GetFileNameWithoutExtension(filePath) + "_FormattedTree.txt";
                string outputFilePath = Path.Combine(Path.GetDirectoryName(filePath), outputFileName); 
                File.WriteAllText(outputFilePath, formattedTree);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nÁrvore de parse formatada salva em: {outputFilePath}");
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

    private static void AppendIndent(StringBuilder sb, int level, string unit)
    {
        for (int i = 0; i < level; i++)
        {
            sb.Append(unit);
        }
    }

    public static string FormatParseTree(string treeString)
    {
        var output = new StringBuilder();
        int indentLevel = 0;
        string indentUnit = "  ";
        bool startOfLine = true;

        string spacedString = treeString.Replace("(", " ( ")
                                      .Replace(")", " ) ")
                                      .Replace(";", " ; ");
        string normalizedString = Regex.Replace(spacedString, @"\s+", " ").Trim();
        
        var tokens = normalizedString.Split(' ');

        foreach (string token in tokens)
        {
            if (string.IsNullOrWhiteSpace(token)) continue;

            if (token == ")")
            {
                indentLevel--;
                output.AppendLine(); 
                AppendIndent(output, indentLevel, indentUnit);
                output.Append(token);
                startOfLine = false; 
            }
            else if (token == "(")
            {
                if (!startOfLine && output.Length > 0) 
                {
                    output.AppendLine();
                }
                AppendIndent(output, indentLevel, indentUnit);
                output.Append(token);
                indentLevel++;
                output.AppendLine();
                startOfLine = true; 
            }
            else 
            {
                if (startOfLine)
                {
                    AppendIndent(output, indentLevel, indentUnit);
                }
                else
                {
                    if (output.Length > 0 && !char.IsWhiteSpace(output[output.Length -1]))
                    {
                         output.Append(" ");
                    }
                }
                output.Append(token);
                startOfLine = false;
            }
        }
        return output.ToString();
    }
}
