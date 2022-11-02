Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("--- Ano Bissexto ---\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Digite um ano: ");
int ano = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

bool divisivelPor400 = ano % 400 == 0;
bool divisivelPor100 = ano % 100 == 0;
bool divisivelPor4 = ano % 4 == 0;

if (divisivelPor400 || (divisivelPor4 && !divisivelPor100))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n{ano} é bissexto.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"\n{ano} não é bissexto.");
    Console.ResetColor();
}
