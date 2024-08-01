using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System;
using System.IO;
using System.Text.Json;

using API.Models;

namespace API.TakingSpecificDataWithAPI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("*************Ride*************");
            await GetRideByID(2);
            Console.WriteLine("*************Car*************");
            await GetCarByID(2);
        }

        public static async Task GetRideByID(int id)
        {
            string localhostPathRide = $"http://localhost:5117/api/rides/{id}";

            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage message = await client.GetAsync(localhostPathRide);
                message.EnsureSuccessStatusCode();

                string rideJson = await message.Content.ReadAsStringAsync();
                //Console.WriteLine(rideJson);
                Ride ride = JsonSerializer.Deserialize<Ride>(rideJson,new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                Console.WriteLine(  $"ID: {ride.Id}\n" + 
                                    $"DriverName: {ride.DriverName}\n" + 
                                    $"Target: {ride.Target}\n" + 
                                    $"Plate: {ride.Plate}");

            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static async Task GetCarByID(int id)
        {
            string localhostPathCar = $"http://localhost:5117/api/cars/{id}";

            using HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage message = await client.GetAsync(localhostPathCar);
                message.EnsureSuccessStatusCode();

                string carJson = await message.Content.ReadAsStringAsync();
                //Console.WriteLine(carJson);

                Car car = JsonSerializer.Deserialize<Car>(carJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                Console.WriteLine(  $"ID: {car.Id}\n" + 
                                    $"Name: {car.Name}\n" + 
                                    $"Descripton: {car.Description}\n" + 
                                    $"ImageName: {car.Image_Filename}");

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}