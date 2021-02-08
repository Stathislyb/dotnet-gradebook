using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          string name = "";
          if(args.Length > 0)
            name = args[0];
            
          Console.WriteLine($"Hello {name}!");
        }
    }
}
