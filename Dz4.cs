Console.Write("Введите числo");
int a = Convert.ToInt32(Console.ReadLine()); 
int index = 1;
while(index <= a)
{
    if(index % 2 == 0)
    {
        Console.WriteLine(index);
    }
index++;
}