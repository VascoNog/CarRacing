using CarRacing.app;

const int trackLength = 100;

var car1 = new Car("Mercedes", ">");
var car2 = new Car("Fiat", "=");
var car3 = new Car("Mustang", "»");
var car4 = new Car("BMW", "*");

List<Car> allCars = new List<Car> { car1, car2, car3, car4 };
List<Car> results = new List<Car>();

bool ongoing = true;
while (ongoing)
{
    Console.Clear();
    foreach (var car in allCars)
    {
        if (car.GetKms() >= trackLength)
        {
            if (!results.Contains(car))
                results.Add(car);
        }
        else
        {
            car.Speed();
        }

        car.Print();
   
    }
     Thread.Sleep(500);
    //Verificar se todos os carros terminaram
    //if (results.Count == allCars.Count)
    //{
    //    ongoing = false;
    //}

    // OU:

    if ( allCars.Any(car  => !results.Contains(car)))
    {
        continue;
    }
    else
    {
        ongoing = false;
    }
}

// Mostrar os resultados:

for (int i = 0; i < results.Count; i++)
{
    Console.WriteLine($"Posição: {i+1} - {results[i].Make}  -  {results[i].Symbol}");
}

//    Console.WriteLine(results.Count);
//    if(i==0)
//        Console.WriteLine($"Vencedor: {results[i].Make}");
//    else
//        Console.WriteLine($"Posição {i}: {results[i].Make}");

//while (car1.GetKms() <= trackLength)
//{
//    Console.Clear();
//    car1.Speed();
//    car1.Print();
//    car2.Speed();
//    car2.Print();
//    car3.Speed();
//    car3.Print();
//    car4.Speed();
//    car4.Print();
//    Thread.Sleep(500);
//}
//Console.WriteLine($"kms totais percorridos: {car1.GetKms()}");