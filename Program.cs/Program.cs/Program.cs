string name = "Marcin";
string sex = "Mężczyzna";
int age = 15;
if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && sex != "Kobieta")
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
