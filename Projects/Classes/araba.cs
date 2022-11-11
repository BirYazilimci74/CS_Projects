namespace Classes;

public class araba
{
    public string model;
    public int yıl;
    public string vites;
    public string yakıt;
    public int maxHız;
    
    public static void printf(string str)
    {
        Console.Write(str);
    }

    public static void printfln(string str)
    {
        Console.WriteLine(str);
    }
    public static void arabaOzellikler(string marka, string model, int yıl, string vites)
    {
        printf("Araba " + yıl + " model " + vites + " " + marka + " " + model);
    }
    
}