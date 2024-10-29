class Program
{
    static void Main()
    {
        List<string> gala = new List<string>();
        gala.Add("1-Bülent Ersoy");
        gala.Add("2-Ajda Pekkan");
        gala.Add("3-Ebru Gündeş");
        gala.Add("4-Hadise");
        gala.Add("5-Hande Yener");
        gala.Add("6-Tarkan");
        gala.Add("7-Funda Arar");
        gala.Add("8-Demet Akalın");

        Console.WriteLine("Patika Plus Galasına Hoşgeldiniz!");
        Console.WriteLine("**Davetliler**");
        foreach (var kisiler in gala)
        {
            Console.WriteLine(kisiler);
        }

    }
}
