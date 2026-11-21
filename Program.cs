using System.Threading.Channels;

List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
int add = int.Parse(Console.ReadLine());
int remove = int.Parse(Console.ReadLine());
int index= int.Parse(Console.ReadLine());
Console.WriteLine("начален списък; " +string.Join(" ",numbers));
numbers.Add(add);
Console.WriteLine("след add " + string.Join(" ", numbers));
numbers.Insert(0, add);
Console.WriteLine("след Insers "+ string.Join(" ", numbers));
if (numbers.Remove(remove))
{
    Console.WriteLine("след remove " + string.Join(" ", numbers));
}
else
{
    Console.WriteLine("числото липсва");
}
if (index >= 0 && index < numbers.Count)
{
    numbers.RemoveAt(index);
    Console.WriteLine("след removeAt " + string.Join(" ", numbers));


}
else
{
    Console.WriteLine("невалиден индекс");
}
Console.WriteLine("крен брой елементи" + numbers.Count);
for(int i = 0; i < numbers.Count; i++)
{


    Console.WriteLine(i + "." + numbers[i]);
}


