
Console.WriteLine("Enter a number:");
int userNumb = Convert.ToInt32(Console.ReadLine());

// kas kasutaja arv on paaris või paaritu

int result = userNumb % 2;

Console.WriteLine(result);

if(result != 0)  // !=ei ole
 {
    Console.WriteLine("usernumber is odd");
 }
else
{
    Console.WriteLine("usernumber is even");
}