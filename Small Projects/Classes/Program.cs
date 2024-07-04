namespace Classes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            araba honda = new araba();
            araba mercedes = new araba();

            honda.model = "Civic";
            honda.vites = "Manuel";
            honda.yakit = "Dizel";
            honda.yil = 2020;

            mercedes.model = "Vito";
            mercedes.vites = "Manuel";
            mercedes.yakit = "Dizel";
            mercedes.yil = 2007;
            

            araba.arabaOzellikler("Honda",honda.model,honda.yil,honda.vites);
            araba.printfln("");
            araba.arabaOzellikler("Mercedes",mercedes.model,mercedes.yil,mercedes.vites);
            araba.printfln("");
        }
    }
}