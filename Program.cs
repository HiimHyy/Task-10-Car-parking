using Task_10_Car_parking;
bool stillMore;
double startTime, endTime;
do
{
    Console.Write("When do you want to begin: ");
    string received = Console.ReadLine();
    while (!Double.TryParse(received, out startTime))
    {
        Console.Write("Invalid time, try again: ");
        received = Console.ReadLine();
    }
    
    Console.Write("When do you want to end: ");
    received = Console.ReadLine();
    while (!Double.TryParse(received, out endTime))
    {
        Console.Write("Invalid time, try again: ");
        received = Console.ReadLine();
    }












    Console.Write("Calculate another (Y/N): ");
    string decision = Console.ReadLine().ToUpper();
    if (decision.StartsWith("Y"))
        stillMore = true;
    else
        stillMore = false;
} while (stillMore);