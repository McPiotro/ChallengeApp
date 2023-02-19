var name = "Malia";
string gender = "Kobieta";
string gender2 = "Mężczyzna";
int age = 35;
int age2 = 17;



if (age == 35 && gender == "Kobieta" && name == "Lola")
{
    Console.WriteLine("-Kobieta o imieniu Lola, lat 35");
}

else if (age == 35 && gender == "Kobieta" && name == "Malia")
{
    Console.WriteLine("-Kobieta o imieniu Malia, lat 35");
}


if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("-Kobieta przed 30 lat");
}

else if (gender == "Kobieta" && age > 30)
{
    Console.WriteLine("-Kobieta powyżej 30 lat");
}


if (gender2 == "Mężczyzna" && age2 >= 18)
{
    Console.WriteLine("-Pełnoletni Mężczyzna");
}

else if (gender2 == "Mężczyzna" && age2 < 18)
{
    Console.WriteLine("-Niepełnoletni Mężczyzna");
}
