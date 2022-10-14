namespace SortingAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list
            List<int> list = new List<int>();
            //more list
            list.Add(11); list.Add(25); list.Add(3); list.Add(14); list.Add(5); list.Add(26); list.Add(57); list.Add(9); list.Add(15); list.Add(49);
            //method
            SortStuff(list);
            //write list to console
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }

        public static void SortStuff(List<int> input)
        {
            //takes every item in list
            for (int i = 0; i < input.Count(); i++)
            {
                int item = input[i];
                int currentIndex = i;

                //checks each item if it has a lower value than the one above and if it is, it moves it up until it's the same value or higher
                while (currentIndex > 0 && input[currentIndex - 1] > item)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }

                //inserts the item to the correct position
                input[currentIndex] = item;
            }
        }
    }

}