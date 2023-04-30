#region Task1

using Asinxron.Models;
using System.Diagnostics;
string[] urls = new string[]
{
    "https://docs.microsoft.com",
    "https://docs.microsoft.com/aspnet/core",
    "https://docs.microsoft.com/azure",
    "https://docs.microsoft.com/azure/devops",
    "https://docs.microsoft.com/dotnet",
    "https://docs.microsoft.com/dynamics365",
    "https://docs.microsoft.com/education",
    "https://docs.microsoft.com/enterprise-mobility-security",
    "https://docs.microsoft.com/gaming",
    "https://docs.microsoft.com/graph",
    "https://docs.microsoft.com/microsoft-365",
    "https://docs.microsoft.com/office",
    "https://docs.microsoft.com/powershell"
};
Asinxron
GetHttpsContent(urls);

//void GetHttpsContent(string[] urls)
//{
//    HttpClient client = new HttpClient();
//    Stopwatch sw = Stopwatch.StartNew();
//    sw.Start();
//    foreach (string url in urls)
//    {
//        var result = client.GetStringAsync(url).Result;
//        Console.WriteLine(result.Length);
//    }
//    sw.Stop();
//    Console.WriteLine($"{sw.ElapsedMilliseconds} ms");
//}


//non-asinxron

//await GetHttpsContentAsync(urls);
//async Task GetHttpsContentAsync(string[] urls)
//{

//    HttpClient client = new HttpClient();
//    List<Task<string>> tasks = new List<Task<string>>();
//    Stopwatch sw = Stopwatch.StartNew();

//    foreach (string url in urls)
//    {
//        var result = client.GetStringAsync(url);
//        tasks.Add(result);

//    }
//    sw.Start();
//    string[] arr = await Task.WhenAll(tasks);
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item.Length);
//    }
//    sw.Stop();
//    Console.WriteLine($"{sw.ElapsedMilliseconds} ms");
//}

#endregion



Weapon pistol = new Weapon(10, Standard);
pistol.Fire();  

Weapon sniperRifle = new Weapon(5, ArmorPiercing);
sniperRifle.Fire();  
Weapon shotgun = new Weapon(0, Incendiary);
shotgun.Fire(); 







