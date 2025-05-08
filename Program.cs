// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;


Console.WriteLine("Hello, World 3!");
var s = JsonConvert.SerializeObject(new { Name = "John", Age = 30 });
Console.WriteLine(s);
SixLabors.ImageSharp.Image image = SixLabors.ImageSharp.Image.Load("fb.jpg");