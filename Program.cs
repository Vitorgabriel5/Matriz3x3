using ConsoleApp1;
namespace consoleApp1;
internal class Program {
    static void Main(string[] args) {
        Matriz M = new Matriz();
        int soma = 0;
        Console.WriteLine("Informe o valor da matriz");

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.WriteLine($"Digite o valor da posição [{i}, {j}]:");
                M.matriz[i, j] = int.Parse(Console.ReadLine());
                soma += M.matriz[i, j];
            }

        }

        Console.WriteLine("\nA Matriz 3x3 preenchida e : ");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                Console.Write($"{M.matriz[i, j]} ");

            }
            Console.WriteLine();

        }
        Console.WriteLine(soma);
    }
}



