using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

/*var result = Generatenumbers(10)

.Where(n => n % 2 == 0)
.Select(n=>n*3);

foreach(var item in result)
{
    Console.WriteLine(item);    
}

IEnumerable<int> Generatenumbers(int value)
{
    
    for (var i = 0; i < value; i++)
    {
      yield return i;
        
    }
    
}
*/
var fileContent = await File.ReadAllTextAsync("DATA.json");
var cars = JsonSerializer.Deserialize<CarData[]>(fileContent);

var CarSelonlesPortes = cars.Where(car => car.NumberOfDoors >= 4);

foreach (var car in CarSelonlesPortes)
{
    Console.WriteLine($"cette marque {car.Make} qui fabrique un model dont " +
        $"" +
        $"les porte sont {car.NumberOfDoors} "); 
}  

class CarData
{
    [JsonPropertyName("id")]
    public int ID { get; set; } 

    [JsonPropertyName("car_make")]
    public string Make { get; set; }

    [JsonPropertyName("car_model")]
    public string Model { get; set; }

   
    
    [JsonPropertyName("hp")]
    public int HP { get; set; }

    [JsonPropertyName("number_doors")]
    public int NumberOfDoors { get; set; }

    [JsonPropertyName("car_year")]
    public int Year { get; set; }   
    
   
}
