class Program
{
    static void Main()
    {
        List<string> gala = new List<string>();
        gala.Add("Bülent Ersoy");
        gala.Add("Ajda Pekkan");
        gala.Add("Ebru Gündeş");
        gala.Add("Hadise");
        gala.Add("Hande Yener");
        gala.Add("Tarkan");
        gala.Add("Funda Arar");
        gala.Add("Demet Akalın");

        Console.WriteLine("Patika Plus Galasına Hoşgeldiniz!");
        Console.WriteLine("**Davetliler**");
        int i = 1;
        foreach (var kisiler in gala)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{i} - {kisiler}");
            i++;
        }

    }
}
