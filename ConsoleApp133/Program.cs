int say = 0, yas = 0;

for (int i = 0; i < 20; i++)
{
    Console.Write("{0}. yaşı giriniz:", i + 1);
    yas = Convert.ToInt16(Console.ReadLine());
    if (yas >= 18 && yas <= 25)
        say++;
}

Console.WriteLine("18 ile 25 yaş arası {0} öğrenci vardır.", say);
Console.ReadKey();