

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

//Console.WriteLine(weekDay);

if(weekDay == 0)
{
    Console.WriteLine("Its sunday!");
}
else if(weekDay == 1)
{
    Console.WriteLine("Its monday!");
}
else if(weekDay == 2)
{
    Console.WriteLine("Its tuesday!");
}
else if(weekDay == 3)
{
    Console.WriteLine("Its wednesday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("Its Thursday!");
}
else if (weekDay == 5)
{
    Console.WriteLine("Its Friday!");
}
else
{
    Console.WriteLine("Its Saturday!");
}