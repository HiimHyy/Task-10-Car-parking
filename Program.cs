using System.Globalization;
using Task_10_Car_parking;
bool stillMore;
TimeOnly startTime, endTime;


do
{
    Console.Write("When do you want to begin: ");
    string received = Console.ReadLine();
    while (!TimeOnly.TryParse(received, out startTime) || (startTime.Hour < 7 ) || (startTime.Hour > 22 ) || (startTime.Hour >= 22 && startTime.Minute > 00))
    {
        Console.Write("Invalid time, type begin: ");
        received = Console.ReadLine();
    }

    Console.Write("When do you want to end: ");
    received = Console.ReadLine();
    while (!TimeOnly.TryParse(received, out endTime) || (endTime.Hour < 7) || (endTime.Hour > 22) || (endTime.Hour >= 22 && endTime.Minute > 00) || startTime > endTime)
    {
        Console.Write("Invalid time, type end: ");
        received = Console.ReadLine();
    }

    Time_counting fees = new Time_counting(startTime, endTime);
    Console.Write("Your car parking charges is: {0:F0} euros", fees.calculateCharges());
    Console.ReadLine();











    Console.Write("Calculate another (Y/N): ");
    string decision = Console.ReadLine().ToUpper();
    if (decision.StartsWith("Y"))
        stillMore = true;
    else
        stillMore = false;
} while (stillMore);