

Dictionary<string,string> carros = new Dictionary<string, string>();

carros.Add("K34K6","Fiat");
carros.Add("K34K5","Golf");
carros.Add("K34K4","Uno");
carros.Add("K3434","Corola");
//carros.Remove("K3434");


foreach (var x in carros)
{
    Console.WriteLine($"Numero da placa: {x.Key} - Modelo do carro: {x.Value}");
}

Console.WriteLine("-------containsKey------");

carros["K3434"] = "Ferrari";
foreach (var x in carros)
{
    Console.WriteLine($"Numero da placa: {x.Key} - Modelo do carro: {x.Value}");
}