namespace FirstProgram
{
    public class Program
    {
        enum Color
        {
            Red,
            Green,
            Blue
        }

        static void Main(string[] args)
        {
            var favoriteColor = Color.Red;
            Console.WriteLine(favoriteColor);
        }
    }
}
