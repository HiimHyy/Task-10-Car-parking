using System.Globalization;
using Task_10_Car_parking;
bool stillMore;
TimeOnly startTime, endTime;

Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine("Welcome to Leonardo Corporations, we are here to take money from your parking");
Console.WriteLine("                Our services available from 7:00 to 22:00                    ");
Console.WriteLine("-----------------------------------------------------------------------------\n");
do
{
    Console.Write("Arrival time (HH:mm): ");
    string received = Console.ReadLine();
    while (!TimeOnly.TryParse(received, out startTime) || (startTime.Hour < 7 ) || (startTime.Hour > 22 ) || (startTime.Hour >= 22 && startTime.Minute > 00))
    {
        Console.Write("Invalid time, available after 7:00 : ");
        received = Console.ReadLine();
    }

    Console.Write("Departure time (HH:mm): ");
    received = Console.ReadLine();
    while (!TimeOnly.TryParse(received, out endTime) || (endTime.Hour < 7) || (endTime.Hour > 22) || (endTime.Hour >= 22 && endTime.Minute > 00) || startTime > endTime)
    {
        Console.Write("Invalid time, available before 22:00: ");
        received = Console.ReadLine();
    }

    Time_counting fees = new Time_counting(startTime, endTime);
    Console.WriteLine("Your car parking charges is: {0:F2} euros \n", fees.calculateCharges());
    Console.ReadLine();





    Console.Write("Calculate another (Y/N): ");
    string decision = Console.ReadLine().ToUpper();
    if (decision.StartsWith("Y"))
        stillMore = true;
    else
        stillMore = false;
} while (stillMore);