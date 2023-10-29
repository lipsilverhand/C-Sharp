using System;

namespace challenge_4 {
    class Program {
        static int highscore = 144;
        static string highscorePlayer = "Phuoc";
        public static void Main(string[] args) {
            
            Check(180, "Lip");
            Check(15, "Tom");
        }

        public static void Check(int score, string playerName) {
            if (score > highscore) {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine($"New highscore is {score}");
                Console.WriteLine($"New highscore holder is {playerName}");
            } else {
                Console.WriteLine($"The old highscore of {highscore} could not be broken and still held by {highscorePlayer}.");
            }
        }
    }
}