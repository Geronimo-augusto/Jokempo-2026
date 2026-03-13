using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokempo.Core
{
    public class JokempoGame
    {
        private string botChoice;

        public string Play()
        {
            string[] escolhas = { "🤛", "🤚", "🤞" };
            Random rand = new Random();
            botChoice = escolhas[rand.Next(3)];
            return botChoice;
        }

        public bool Verificar(string jogador)
        {
            if (jogador == "🤛" && botChoice == "🤞") return true;
            if (jogador == "🤚" && botChoice == "🤛") return true;
            if (jogador == "🤞" && botChoice == "🤚") return true;

            return false;
        }
    }
}
