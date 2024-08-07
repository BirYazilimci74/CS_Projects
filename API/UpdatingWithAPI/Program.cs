using System.Text;
using System.Text.Json;
using API.Models;

namespace API.UpdatingWithAPI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Car updatedCar = new Car{
                Name = "Bugatti Chiron",
                Description = "Legend",
                Image_Filename = "chiron"
            };
            
            //await UpdateCar(12,updatedCar);

            Ride updatedRide = new Ride{
                DriverName = "Hamdiye Nur Kanca",
                Target = "Bahçelievler",
                Plate = "45fgh34",
                Latitude = 40.9158695,
                Longitude = 29.2507281
            };
            
            //await UpdateRide(4,updatedRide);
        }

        private static async Task UpdateCar(int id, Car updatedCar)
        {
            string localhostPathCar = $"http://localhost:5117/api/cars/{id}";

            using HttpClient client = new HttpClient();

            try
            {
                string carJson = JsonSerializer.Serialize(updatedCar);
                StringContent content = new StringContent(carJson,Encoding.UTF8,"application/json");

                HttpResponseMessage message = await client.PutAsync(localhostPathCar,content);
                message.EnsureSuccessStatusCode();

                Console.WriteLine($"No {id} car was updated.");
            }
            catch (System.Exception)
            {
                Console.WriteLine($"No {id} car was not updated.");
                throw;
            }
        }

        private static async Task UpdateRide(int id, Ride updatedRide)
        {
            string localhostPathRide = $"http://localhost:5117/api/rides/{id}";

            using HttpClient client = new HttpClient();

            try
            {
                string rideJson = JsonSerializer.Serialize(updatedRide);
                StringContent content = new StringContent(rideJson,Encoding.UTF8,"application/json");

                HttpResponseMessage message = await client.PutAsync(localhostPathRide,content);
                message.EnsureSuccessStatusCode();

                Console.WriteLine($"No {id} ride was updated.");
            }
            catch (System.Exception)
            {
                Console.WriteLine($"No {id} ride was not updated.");
                throw;
            }
        }
    }
}