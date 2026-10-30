using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.Models
{
    internal class Player
    {
        public string name;
        public int highScore;
        public string Name { get => name; set => name = value; }
        public int HighScore { get => highScore; set => highScore = value; }

        public Player(string name)
        {
            Name = name;
            HighScore = 0;
        }
    }
}
