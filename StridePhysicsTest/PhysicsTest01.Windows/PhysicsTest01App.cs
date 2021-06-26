using Stride.Engine;

namespace PhysicsTest01
{
    class PhysicsTest01App
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
