int n = Convert.ToInt32(Console.ReadLine());
bool contains5 = false;
while (n>0)
{
    int i = n % 10;
    if (i == 5)
    {
        contains5 = true;
        break;
    }
   
    n /= 10;
}
if (contains5) 
    Console.WriteLine("Contains 5");
 else
    Console.WriteLine("Does not contain 5");
