namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var IAnimal = new List<IAnimal> { new Dog("mikis", 3), new Cat("tomas", 8), new Bass("Eserys", 29), new Carp("karpelis", 22) };
            IAnimal.ForEach(x => x.Eat());

            var IMammal = new List<IMammal> { new Dog("maksas", 1), new Cat("feliksas", 6)};
            IMammal.ForEach(x => x.GiveBirth());

            var IFish = new List<IFish> {new Bass("Aukselis", 2), new Carp("himarsas", 69) };
            IFish.ForEach(x => x.Swim());

            var comparer = new Animalcomparer();
            IAnimal.Sort(comparer);
            IAnimal.ForEach(x => Console.WriteLine(x.Name));
        }
    }
}