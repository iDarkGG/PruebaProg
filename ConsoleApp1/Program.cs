namespace PruebaProg
{
    public class uwu : Figuras
    {
        public override void AreaFigura()
        {
            Console.WriteLine("uwu");
        }
        public static void main(string[] args)
        {
            Uwu();
            Console.WriteLine("uuuuuuh");
        }
        static int count = 0;
        public static void Uwu()
        {
            count++;
            if (count <= 5)
            {
                Console.WriteLine((count));
                Uwu();
            }

        }
    }
}
