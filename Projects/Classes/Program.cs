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
            honda.yakıt = "Dizel";
            honda.yıl = 2020;

            mercedes.model = "Vito";
            mercedes.vites = "Manuel";
            mercedes.yakıt = "Dizel";
            mercedes.yıl = 2007;
            

            araba.arabaOzellikler("Honda",honda.model,honda.yıl,honda.vites);
            araba.printfln("");
            araba.arabaOzellikler("Mercedes",mercedes.model,mercedes.yıl,mercedes.vites);
            araba.printfln("");
        }
    }
}