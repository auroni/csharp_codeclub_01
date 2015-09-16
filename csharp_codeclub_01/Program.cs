using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_codeclub_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player();
            Player playerTwo = new Player("Assassiini", 100, 80, 1000);

            playerOne.Name = "Knihti";


            string tempName = playerOne.Name;

            playerOne.getPlayerInfo();
            playerTwo.getPlayerInfo();
        }
    }
}
