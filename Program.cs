using System.Globalization;
using Task_10_Car_parking;
bool More;
TimeOnly startTime, endTime;

Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine("Welcome to Huy Corporations, we are here to take money from your parking");
Console.WriteLine("               -Our services available from 7:00 to 22:00-                   ");
Console.WriteLine("            <2hr: 2€/hr | >2hr <=5hr: 1.75€/hr | >5hr: 1.5€/hr               ");
Console.WriteLine("-----------------------------------------------------------------------------\n");
do
{
    Console.Write("Arrival time (HH:mm): ");
    string received = Console.ReadLine();
    while (!TimeOnly.TryParse(received, out startTime) || (startTime.Hour < 7 ) || (startTime.Hour > 22 ) || (startTime.Hour >= 22 && startTime.Minute > 00))
    {
        Console.Write("Invalid time, available after 7:00: ");
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
    Console.WriteLine("Your car parking charges is: {0:F2} € \n", fees.calculateCharges());




    Console.Write("Calculate another (Y/N): ");
    string decision = Console.ReadLine().ToUpper();
    if (decision.StartsWith("Y"))
        More = true;
    else
        More = false;
} while (More);