using BancApp;
using System;
using System.Threading;

var balance = new Random();

var id = Guid.NewGuid();
var id1 = Guid.NewGuid();
var id2 = Guid.NewGuid();
var bancCard = new BancCard("Kapital", "Kapital Bank", "5103_2232_3233_5483", "2003", "454", new DateTime(2024, 7, 4), balance.Next(100, 200));

var bancCard1 = new BancCard("Kapital", "Kapital Bank", "4205_7462_3953_4823", "1243", "353", new DateTime(2025, 4, 3), balance.Next(300, 500));

var bancCard2 = new BancCard("Kapital", "Kapital Bank", "5205_4262_1462_7685", "1021", "421", new DateTime(2025, 2, 12), balance.Next(200, 300));

var client = new Client(id, "Rufet", "Isganderov", 18, 500, bancCard);
var client1 = new Client(id1, "Adil", "Resulov", 19, 900, bancCard1);
var client2 = new Client(id2, "Nuray", "Yunuszade", 20, 1200, bancCard2);

var clients = new Client[] { client, client1, client2 };

var Kapitalbank = new Banc(clients);


void EnterPin()
{
    Console.Write("PIN: ");
    var pin = Console.ReadLine();
    CheckPin(pin);
}

void CheckPin(string pin)
{
    int index;
    bool b = false;
    for (int i = 0; i < clients.Length; i++)
    {
        if (pin == clients[i].bancAccount.Pin)
        {
            index = i;
            b = true;
            Console.WriteLine($"{Kapitalbank.Clients[i].Name} {Kapitalbank.Clients[i].Surname} xos gelmisiz");
            Menu(i);
            break;
        }
        else
        {
            continue;
        }
    }
    if (b == false)
    {
        throw new ArgumentException("Daxil etdiyiniz PIN yanlisdir!");
    }
}

try
{
    EnterPin();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Zehmet olmasa yeniden daxil edin");
    Thread.Sleep(1500);
    Console.Clear();
    try
    {
        EnterPin();
    }
    catch (Exception ex1)
    {
        Console.WriteLine(ex1.Message);
    }
}

void Menu(int index)
{
label:
    Console.WriteLine("\n1. Balans" +
        "\n2. Nagd pul" +
        "\n3. Kartdan karta kocurme" +
        "\n4. Geri");
    Console.Write("Secim: ");
label4: var ch = Console.ReadLine();
    if (ch == "1")
    {
        Console.WriteLine($"Cari Balans: { clients[index].bancAccount.Balance}");
        Console.Write("<-Geri: ");
    label3: var a = Console.ReadKey();
        if (a.Key == ConsoleKey.LeftArrow)
        {
            Console.Clear();
            goto label;
        }
        else
        {
            goto label3;
        }

    }
    else if (ch == "2")
    {
    label1:
        int[] pul = new int[] { 10, 20, 50, 100 };
        Console.WriteLine($"\n1. {pul[0]} AZN" +
                          $"\n2. {pul[1]} AZN" +
                          $"\n3. {pul[2]} AZN" +
                          $"\n4. {pul[3]} AZN" +
                          $"\n5. Diger (Istediyiniz mebleg)");
        Console.Write("Secim: ");
        var s = Console.ReadLine();
        if (s == "1")
        {
            if (clients[index].bancAccount.Balance >= pul[0])
            {
                clients[index].bancAccount.Balance -= pul[0];
                Console.WriteLine("$--Lutfen pulunuzu goturun--$"); Thread.Sleep(1200);
                Console.Clear();
                goto label;
            }
            else
                try
                {
                    throw new ArgumentOutOfRangeException(null, "Balansda yeterli qeder mebleg yoxdur!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Zehmet olmasa yeniden daxil edin: ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto label1;
                }

        }
        else if (s == "2")
        {
            if (clients[index].bancAccount.Balance >= pul[1])
            {
                clients[index].bancAccount.Balance -= pul[1];
                Console.WriteLine("$--Lutfen pulunuzu goturun--$"); Thread.Sleep(1200);
                Console.Clear();
                goto label;
            }
            else
                try
                {
                    throw new ArgumentOutOfRangeException(null, "Balansda yeterli qeder mebleg yoxdur!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Zehmet olmasa yeniden daxil edin: ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto label1;
                }
        }
        else if (s == "3")
        {
            if (clients[index].bancAccount.Balance >= pul[2])
            {
                clients[index].bancAccount.Balance -= pul[2];
                Console.WriteLine("$--Lutfen pulunuzu goturun--$"); Thread.Sleep(1200);
                Console.Clear();
                goto label;
            }
            else
                try
                {
                    throw new ArgumentOutOfRangeException(null, "Balansda yeterli qeder mebleg yoxdur!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Zehmet olmasa yeniden daxil edin: ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto label1;
                }
        }
        else if (s == "4")
        {
            if (clients[index].bancAccount.Balance >= pul[3])
            {
                clients[index].bancAccount.Balance -= pul[3];
                Console.WriteLine("$--Lutfen pulunuzu goturun--$");
                Thread.Sleep(1200);
                Console.Clear();
                goto label;
            }
            else
                try
                {
                    throw new ArgumentOutOfRangeException(null, "Balansda yeterli qeder mebleg yoxdur!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Zehmet olmasa yeniden daxil edin: ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto label1;
                }
        }
        else if (s == "5")
        {
            Console.Write("Sechim: ");
            int other = int.Parse(Console.ReadLine());

            if (clients[index].bancAccount.Balance >= other)
            {
                clients[index].bancAccount.Balance -= other;
                Console.WriteLine("$--Lutfen pulunuzu goturun--$");
                Thread.Sleep(1400);
                Console.Clear();
                goto label;
            }
            else
                try
                {
                    throw new ArgumentOutOfRangeException(null, "Balansda yeterli qeder mebleg yoxdur!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Zehmet olmasa yeniden daxil edin");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto label1;
                }
        }
    }
    else if (ch == "3")
    {
        Console.Write("Kocurmek istediyiniz kartin PAN-ni yazin: ");
        var pan = Console.ReadLine();
        bool b = false;
        for (int i = 0; i < clients.Length; i++)
        {
            if (clients[i].bancAccount.Pan == pan)
            {
                b = true;
            label5:
                Console.Write($"Kocureceyiniz meblegi daxil edin: Max({clients[index].bancAccount.Balance} AZN)");
                int moveMoney = int.Parse(Console.ReadLine());
                if (moveMoney > clients[index].bancAccount.Balance)
                {
                    try
                    {
                        throw new Exception("Balansda yeterli qeder mebleg yoxdur!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Zehmet olmasa yeniden daxil edin");
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto label5;
                    }
                }
                else
                {
                    Console.WriteLine("Emeliyyat gedir");
                    for (int j = 0; j < 40; j++)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(" ");
                        Thread.Sleep(100);
                        Console.ResetColor();
                    }
                    clients[index].bancAccount.Balance -= moveMoney;
                    clients[i].bancAccount.Balance += moveMoney;
                    Console.WriteLine("\nEmeliyyat ugurla basa catdi");
                    Thread.Sleep(2500);
                    Console.Clear();
                    EnterPin();
                }

            }
        }
        if (!b)
        {
            Console.WriteLine("Bu PAN koda aid kart tapilmadi !");
            Thread.Sleep(1300);
            Console.Clear();
            goto label;
        }
        goto label;
    }
    else if (ch=="4")
    {
        Console.Clear();
        EnterPin();
    }
    else
    {
        goto label4;
    }
}

