using System;
using Cosmos;

namespace CosmosNeofetch
{
    /// <summary>
    /// A COSMOS implementation of Neofetch.
    /// </summary>
    public class CosmosNeofetch
    {
        // Change these variables to match your OS.
        public static string LoggedUser = "myUser";
        public static string PC_Name = "myPcName";
        public static string OS_Name = "myOs";
        public static string OS_Ver = "v1.0";
        public static string OS_Rev = "20250514";

        public static string Kernel_Name = "myKernel";
        public static string Kernel_Ver = "v1.0";
        public static string Shell_Name = "myShell";
        public static string Shell_Ver = "v1.0";
        
        public static string cpuBrand;
        public static string ramAmount;

        // Put your ASCII art here in seperate lines
        public static string[] asciiArt = new[]
        {
            "            ......",
            "       .:::::::::::::.",
            "    .:::-###########+:::",
            "   .::#################::::::::.....",
            "  .::###################:*#####::::::",
            "  ::%######:::::::+##=:#############::",
            " ::######:::::::::::::############:::",
            ".::******:::::::::::::************::",
            ".::++++++::::::::::::=++++++++++++::",
            " ::++++++:::::::::::+++++++++++++::",
            " .::+++++++:::::::=+++:::++++++:::.",
            "  .::+++++++++++++++++++::::::::",
            "   .::+++++++++++++++++::.",
            "     ::::+++++++++++-:::",
            "      ..:::::::::::::.",
            "          .........."
        };

        public static string[] info = new[]
        {
                $"{LoggedUser}@{PC_Name}",
                $"OS: {OS_Name} {OS_Ver}",
                $"OS revision: {OS_Rev}",
                $"Kernel: {Kernel_Name} {Kernel_Ver}",
                $"Shell: {Shell_Name} {Shell_Ver}",
                "Resolution: 80x25 chars",
                $"CPU: {cpuBrand}",
                $"RAM: {ramAmount}"
        };

        /// <summary>
        /// Runs the main part of CosmosNeofetch.
        /// </summary>
        public static void Main()
        {
            var originalColor = Console.ForegroundColor;
            var asciiColor = ConsoleColor.Gray; // Replace this with whatever color you want

            Console.WriteLine();

            for (int i = 0; i < asciiArt.Length; i++)
            {
                Console.ForegroundColor = asciiColor;
                Console.Write(asciiArt[i]);

                if (i < info.Length)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(info[i] + "\n");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = originalColor;
        } 
    }
}
