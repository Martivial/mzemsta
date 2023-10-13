

string surname = Console.ReadLine();
var age = int.Parse(Console.ReadLine());
var age_pension = int.Parse(Console.ReadLine());
var calc = (age_pension - age);
Convert.ToInt32(calc);


Console.WriteLine($"Witaj, {surname}!");

if (age < 0 || age_pension < 0)
{
    Console.WriteLine("Wiek nie może być ujemny!");
}
else
{

    if (age < age_pension)
 
    {

        Console.WriteLine($"Do emerytury brakuje Ci {calc} lat!");
    }
    else
    {
        Console.WriteLine("Jesteś emerytem!");
    }
}



