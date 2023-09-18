namespace Lesson7HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetable lettuce = new LeafyVegetable("Lettuce", 5, 100, "High");
            Vegetable carrot = new RootVegetable("Carrot", 41, 80, "Taproot");
            Vegetable broccoli = new StemVegetable("Broccoli", 55, 150, 20);

            Salad mySalad = new Salad();
            mySalad.AddVegetable(lettuce);
            mySalad.AddVegetable(carrot);
            mySalad.AddVegetable(broccoli);

            int totalCalories = mySalad.CalculateTotalCalories();
            Console.WriteLine($"Total Calories in the Salad: {totalCalories} calories");

            mySalad.SortByParameter("calories");

            Console.WriteLine("Sorted Vegetables:");
            foreach (var vegetable in mySalad.GetVegetables())
            {
                Console.WriteLine($"Name: {vegetable.Name}, Calories: {vegetable.Calories}");
            }

            var matchingVegetables = mySalad.FindVegetablesByCriteria(v => v.GetCalories() < 50);

            Console.WriteLine("Matching Vegetables (Calories < 50):");
            foreach (var vegetable in matchingVegetables)
            {
                Console.WriteLine($"Name: {vegetable.Name}, Calories: {vegetable.Calories}");
            }
        }
    }
}
