namespace ConsoleTestApp.Linq
{
    /*



    public class ProcessLinq
    {
       



       



        



        private void HandleIDsV2(List<Data> myDataList)
        {
            IDs = (from x in myDataList where x.Name.Contains("different") select x.Id).ToList();



            foreach (int id in IDs)
            {
                Console.WriteLine(id);
            }
        }
    }*/
    internal class Data
    {
        public Data(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
    /*internal class Data
    {
        public Data(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }*/

    public class ProcessLinq
    {
        private List<int> IDs
        {
            get;
            set;
        } = new List<int>();
        /*
          private List<int> IDs
        {
            get;
            set;
        } = new List<int>();*/

        public ProcessLinq()
        {
            var data = new List<Data>
            {
                new Data(1, "test1"),
                new Data(2, "test2"),
                new Data(3, "test3"),
                new Data(4, "test4"),
                new Data(5, "different1")
            };

            HandleIDsV1(data);
            Console.WriteLine("");
            HandleIDsV2(data);
        }
        /*
          public ProcessLinq()
        {
            var data = new List<Data>
            {
                new Data(1, "test1"),
                new Data(2, "test2"),
                new Data(3, "test3"),
                new Data(4, "test4"),
                new Data(5, "different1")
            };



            HandleIDsV1(data);
            Console.WriteLine("");
            HandleIDsV2(data);
        }*/

        private void HandleIDsV1(List<Data> myDataList)
        {
            IDs = myDataList.Where(d => d.Name.Contains("test")).Select(d => d.Id).ToList();

            IDs.ForEach(id => Console.WriteLine(id));
        }
        /*private void HandleIDsV1(List<Data> myDataList)
        {
            IDs = myDataList.Where(d => d.Name.Contains("test")).Select(d => d.Id).ToList();



            IDs.ForEach(id => Console.WriteLine(id));
        }*/

        private void HandleIDsV2(List<Data> myDataList)
        {
            IDs = (from x in myDataList where x.Name.Contains("different") select x.Id).ToList();

            foreach (int id in IDs)
            {
                Console.WriteLine(id);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var process = new ProcessLinq();
        }
    }
    
}