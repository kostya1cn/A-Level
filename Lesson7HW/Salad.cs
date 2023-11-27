namespace Lesson7HW
{
    public class Salad
    {
        private List<Vegetable> vegetables;

        public Salad()
        {
            vegetables = new List<Vegetable>();
        }

        public void AddVegetable(Vegetable vegetable)
        {
            vegetables.Add(vegetable);
        }

        public void SortByParameter(string parameter)
        {
            switch (parameter.ToLower())
            {
                case "calories":
                    vegetables = vegetables.OrderBy(v => v.GetCalories()).ToList();
                    break;
                case "weight":
                    vegetables = vegetables.OrderBy(v => v.GetWeight()).ToList();
                    break;
                default:
                    Console.WriteLine("Неверный параметр для сортировки.");
                    break;
            }
        }

        public int CalculateTotalCalories()
        {
            return vegetables.Sum(v => v.GetCalories());
        }

        public List<Vegetable> FindVegetablesByCriteria(Func<Vegetable, bool> criteria)
        {
            return vegetables.Where(criteria).ToList();
        }

        public List<Vegetable> GetVegetables()
        {
            return vegetables;
        }
    }
}