namespace Start
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hej og Velkommen til starter opgaverne!");

            Opgave1();
            Opgave2();
            Opgave3();
            Opgave4();
        }

        static void header(int opgavernummer) {
            Console.WriteLine("------------------------");

            Console.WriteLine($"Her starter opgave {opgavernummer}");
        }

        static void Opgave1()
        {
            header(1);
        }


        static void Opgave2()
        {
            header(2);
        }
        static void Opgave3()
        {
            header(3);
        }
        static void Opgave4()
        {
            header(4);
        }
    }
}
