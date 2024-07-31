using System.Text;
using System.Text.Json;
using API.Models;

namespace API.AddingWithAPI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("*****************Add Car*****************");
            await AddCar(new Car {Id = 11, Name = "Chery Tiggo", Description = "Worthless", Image_Filename = "chery" });//id should change according to the database.
                                                                                                                        //if id is auto inc, no problem.
            Console.WriteLine("*****************Add Ride*****************");
            await AddRide(new Ride {DriverName = "Hamdiye Nur Kanca", Target = "Maltepe", Plate = "05HMD312", Latitude = 40.8889309 ,Longitude = 29.2380319});
        }

        public static async Task AddCar(Car newCar)
        {
            string localhostPathCar = "http://localhost:5117/api/cars";
            
            using HttpClient client = new HttpClient();

            try
            {
                string carJson = JsonSerializer.Serialize(newCar);
                StringContent content = new StringContent(carJson, Encoding.UTF8, "application/json");

                HttpResponseMessage message = await client.PostAsync(localhostPathCar, content);
                message.EnsureSuccessStatusCode();

                Console.WriteLine("Car added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static async Task AddRide(Ride newRide)
        {
            string localhostPathRide = "http://localhost:5117/api/rides";
            
            using HttpClient client = new HttpClient();

            try
            {
                string rideJson = JsonSerializer.Serialize(newRide);
                StringContent content = new StringContent(rideJson, Encoding.UTF8, "application/json");

                HttpResponseMessage message = await client.PostAsync(localhostPathRide, content);
                message.EnsureSuccessStatusCode();

                Console.WriteLine("Ride added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
