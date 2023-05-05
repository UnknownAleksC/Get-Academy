namespace Social_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Bent", 32,  new String[]{"Mørre", "Romsdal"}, "Elsker fisking");

            Console.WriteLine(user.Occupations[0]);
        }

}
}