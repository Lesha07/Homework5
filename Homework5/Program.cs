Console.WriteLine("input your number");
try
{
    byte number = byte.Parse(Console.ReadLine());
    
    if(number >= 0 && number <= 255)
    {
        Console.WriteLine("Correct number");
    }
}
catch (Exception ex)
{
    Console.WriteLine("incorrect number format");
}
finally
{
    Console.WriteLine("Goodbye!");
}       