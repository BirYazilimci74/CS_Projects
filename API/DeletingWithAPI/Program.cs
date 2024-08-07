using API.Models;

namespace API.DeletingWithAPI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await DeleteRide(8);
            await DeleteCar(13);
        }

        private static async Task DeleteRide(int id)
        {
            string localhostPathRide = $"http://localhost:5117/api/rides/{id}";

            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage message = await client.DeleteAsync(localhostPathRide);
                message.EnsureSuccessStatusCode();

                Console.WriteLine($"NO {id} ride was deleted");
            }
            catch (System.Exception)
            {
                Console.WriteLine($"NO {id} ride was not deleted");
                throw;
            }
        }

        private static async Task DeleteCar(int id)
        {
            string localhostPathCar = $"http://localhost:5117/api/cars/{id}";

            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage message = await client.DeleteAsync(localhostPathCar);
                message.EnsureSuccessStatusCode();

                Console.WriteLine($"NO {id} car was deleted");
            }
            catch (System.Exception)
            {
                Console.WriteLine($"NO {id} car was not deleted");
                throw;
            }
        }
    }
}