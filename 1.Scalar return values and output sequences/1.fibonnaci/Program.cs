int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
// Scalar return value
int numberOfElements = fibonacci.Count();
Console.WriteLine("Count: {0}", numberOfElements);

var x = fibonacci.Distinct();
foreach (var item in x)
{
    Console.WriteLine(item);
}
Console.WriteLine("///////");
foreach (int element in fibonacci)
{
    Console.WriteLine(element);
}

// Output sequence return value
IEnumerable<int> distinctNumbers = fibonacci.Distinct();
Console.WriteLine("Elements in output sequence:");
foreach(var number in distinctNumbers)
{
    Console.WriteLine(number);
}