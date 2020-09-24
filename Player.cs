using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectWord
{
    class Player
    {

        public string name { get; private set; }

        private int score;

        public int Score
        {
            get { return score; }
            set
            {
                if (value > 0)
                {
                    score = value;
                }
                else
                {
                    score = 0;
                }

            }
        }


        public List<char> Guessedletter { get; } = new List<char>();



        public Player(string name)
        {
            this.name = name;
        }
    }


}
