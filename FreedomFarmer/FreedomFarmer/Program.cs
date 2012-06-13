using System;

namespace FreedomFarmer
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (FreedomFarmerGame game = new FreedomFarmerGame())
            {
                game.Run();
            }
        }
    }
#endif
}

