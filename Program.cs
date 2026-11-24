string[] konular = { "C# Temelleri", "Git ve GitHub", "Koleksiyonlar", "OOP" };

Console.WriteLine("Ogrenilecek Konular:");

foreach (string konu in konular)
{
    Console.WriteLine("- " + konu);
}
