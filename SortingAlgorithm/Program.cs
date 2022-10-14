namespace SortingAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(11); list.Add(25); list.Add(3); list.Add(14); list.Add(5); list.Add(26); list.Add(57); list.Add(9); list.Add(15); list.Add(49);
            InsertionSort(list);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }

        public static void InsertionSort(List<int> input)
        {

            for (int i = 0; i < input.Count(); i++)
            {
                int item = input[i];
                int currentIndex = i;

                while (currentIndex > 0 && input[currentIndex - 1] > item)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }

                input[currentIndex] = item;
            }
        }
    }

}