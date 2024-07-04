namespace Classes;

public class araba
{
    public string? model;
    public int yil;
    public string? vites;
    public string? yakit;
    public int maxHiz;
    
    public static void printf(string str)
    {
        Console.Write(str);
    }

    public static void printfln(string str)
    {
        Console.WriteLine(str);
    }
    public static void arabaOzellikler(string marka, string model, int yil, string vites)
    {
        printf("Araba " + yil + " model " + vites + " " + marka + " " + model);
    }
    
}