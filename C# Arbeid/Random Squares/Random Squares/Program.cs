namespace Random_Squares
{
    internal class Program
    {
        private static int _width = 50;
        private static int _height = 25;

        static void Main(string[] args)
        {
            while (true)
            {
                var boxes = CreateBoxes();
                Show(boxes);
                Console.WriteLine("(press enter for new. ctrl+c=exit)");
                Console.ReadLine();
            }
        }

        private static Box[] CreateBoxes()
        {
            var random = new Random();
            var boxes = new Box[3];
            for (var i = 0; i < boxes.Length; i++)
            {
                boxes[i] = new Box(random, _width - 1, _height - 1);
            }
            return boxes;
        }

        private static void Show(Box[] boxes)
        {
            var screen = new VirtualScreen(_width, _height);
            foreach (var box in boxes)
            {
                screen.Add(box);
            }
            screen.Show();
        }
    }
}