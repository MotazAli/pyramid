using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidConsoleApp
{

    internal class Pyramid
    {
        private double _numberOfLayers;
        private char _sign;
        private double _space, _number = 0;
        public Pyramid(double numberOfLayers, char sign)
        {
            _numberOfLayers = numberOfLayers; 
            _sign = sign;
        }

        public void Draw() {

            if(_numberOfLayers <= 0 ) return;

            for (int i = 1; i <= _numberOfLayers; i++)
            {
                for (_space = 1; _space <= (_numberOfLayers - i); _space++)
                    Console.Write(" ");
                for (_number = 1; _number <= i; _number++)
                    Console.Write(_sign);
                for (_number = (i - 1); _number >= 1; _number--)
                    Console.Write(_sign);
                Console.WriteLine();
            }
        }
    }
}
