
Random r = new Random();
int liczba = r.Next(1, 10);
int liczba2;
bool win = false;
Console.WriteLine("Konsola wygenerowała liczbę od 1 do 10,zgadnij jaka to liczba)");
liczba2 = Convert.ToInt32(Console.ReadLine());
 while (liczba2 != liczba)
{
    if (liczba2 < liczba)
    {
        Console.WriteLine("Twoja liczba jest zbyt mała,spróbuj ponownie");
        liczba2 = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        if (liczba2 > liczba)
        {
            Console.WriteLine("Twoja liczba jest zbyt wysoka,spróbuj ponownie");
            liczba2 = Convert.ToInt32(Console.ReadLine());
        }
        if (liczba2 == liczba)


        {
            win = true;
            Console.WriteLine("Gratulacje! Udało ci się zgadnąć poprawną liczbę!");
            Console.WriteLine("Twoja liczba to" + liczba);
            break;
        }
    }
}



