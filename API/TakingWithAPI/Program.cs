using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System;
using System.IO;
using System.Text.Json;

using API.Models;

namespace API.TakingWithAPI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("*****************Cars*****************");
            await WriteCarInfo();

            Console.WriteLine("*****************Rides*****************");
            await WriteRideInfo();
        }

        public static async Task WriteRideInfo()
        {
            string localhostPathRide = "http://localhost:5117/api/rides";
            
            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage message = await client.GetAsync(localhostPathRide);
                message.EnsureSuccessStatusCode();

                string rideJson = await message.Content.ReadAsStringAsync();
                //Console.WriteLine(rideJson);
                List<Ride> rides = JsonSerializer.Deserialize<List<Ride>>(rideJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                foreach (Ride ride in rides)
                {
                    Console.WriteLine($"ID:{ride.Id} \nDriver Name:{ride.DriverName} \nTarget:{ride.Target} \n");
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static async Task WriteCarInfo()
        {
            string localhostPathCar = "http://localhost:5117/api/cars";
            
            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage message = await client.GetAsync(localhostPathCar);
                message.EnsureSuccessStatusCode();

                string carJson = await message.Content.ReadAsStringAsync();
                //Console.WriteLine(carJson);
                
                List<Car> cars = JsonSerializer.Deserialize<List<Car>>(carJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                foreach (Car car in cars)
                {
                    Console.WriteLine($"ID:{car.Id} \nName:{car.Name} \nDescription:{car.Description} \n");
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}