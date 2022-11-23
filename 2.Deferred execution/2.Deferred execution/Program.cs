public class clase1
{
    public static void Main()
    {
        Console.WriteLine("fibo1");
        fibo1();

        Console.WriteLine("fibo2");
        fibo2();
    }

    public static void fibo1()
    { 
        int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
        // Construct the query
        IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x =>x > 2);
        // At this point the query has been created but not executed
        // Change the first element of the input sequence
        fibonacci[0] = 99;

        // Cause the query to be executed (enumerated)
        foreach(var number in numbersGreaterThanTwoQuery)
        {
        Console.WriteLine(number);
        }
    }
    
    public static void fibo2()
    {
        int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
        // Construct the query
        IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where(x => x > 2).ToArray();
        // At this point the query has been executedbecause of the .ToArray()
        // Change the first element of the input sequence
        fibonacci[0] = 99;           
        // Enumerate the results
        foreach(var number in numbersGreaterThanTwoQuery)
        {
            Console.WriteLine(number);
        }
    }
}

