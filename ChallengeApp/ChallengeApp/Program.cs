// Dzien 4

string name = "Ewa";
bool woman  = true;
var age = 18;

if (name == "Ewa" && age < 33)
{
    Console.WriteLine("Kobieta ponizej 33lat");
}
else if (name =="Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (woman == false && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
