int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch(weekDay)  //väärtus mida kontrollitakse
{
    case 0: // case 0: = if (weekDay==0)
        Console.WriteLine("Its Sunday");
        break;
    case 1:
        Console.WriteLine("Its monday");
        break;
    case 2:
        Console.WriteLine("Its tuesday");
        break;
    case 3:
        Console.WriteLine(("is wednesday");
        break ;
    case 4:
        Console.WriteLine("its thursday");
        break;
    case 5:
        Console.WriteLine("its friday");
        break;
    case 6:
        Console.WriteLine("its saturday");
        break;
    default:
        Console.WriteLine("oops your calendar must be broken");
        break;
}

Console.WriteLine("Have a nice day");