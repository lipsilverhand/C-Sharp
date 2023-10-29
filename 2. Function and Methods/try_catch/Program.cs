using System;

namespace try_catch {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Please enter a number");
            string user_input = Console.ReadLine();

            try
            {
                int x = int.Parse(user_input);
            }
            catch (FormatException)
            {
                
                Console.WriteLine("Format exception, please enter the correct type.");
            } 
            catch (ArgumentNullException) {
                Console.WriteLine("ArgumentNullException, the value was empty.");
            }
        }
    }
}