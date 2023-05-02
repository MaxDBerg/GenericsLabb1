namespace GenericsLabb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- Create an object of LådaCollection and add 5 objects to it
            LådaCollection boxCollection = new LådaCollection();
            boxCollection.Add(new Låda(1, 2, 3));
            boxCollection.Add(new Låda(2, 3, 4));
            boxCollection.Add(new Låda(3, 4, 5));
            boxCollection.Add(new Låda(4, 5, 6));
            boxCollection.Add(new Låda(5, 6, 7));

            // 2- Add an object with the same dimensions as an existing box
            Låda boxWithSameDimensions = new Låda(2, 3, 4);
            boxCollection.Add(boxWithSameDimensions);

            // 3- Test Remove method and then display the list after removing an object
            Console.WriteLine("Before removing a box:");
            DisplayBoxes(boxCollection);
            boxCollection.Remove(boxWithSameDimensions);
            Console.WriteLine("After removing a box:");
            DisplayBoxes(boxCollection);

            // 4- Check if the collection contains a specific object
            bool containsBox = boxCollection.Contains(new Låda(1, 2, 3));
            Console.WriteLine("Box collection contains box with dimensions 1, 2, 3: " + containsBox);

            // 5- Display all boxes in the collection
            Console.WriteLine("All boxes in the collection:");
            DisplayBoxes(boxCollection);

            Console.ReadKey();
        }

        // Helper method to display all boxes in the collection
        static void DisplayBoxes(LådaCollection boxCollection)
        {
            foreach (Låda box in boxCollection)
            {
                Console.WriteLine("Box with dimensions {0}, {1}, {2}", box.höjd, box.längd, box.bredd);
            }
        }

    }
}