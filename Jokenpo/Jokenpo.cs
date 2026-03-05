using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Jokenpo;

public class Jokenpo
{
    string resposta;
    public string Play()
    {
        var escolhas = new string[] { "🤚","🤛", "🤞" };
        Random rand = new Random();
        var es = rand.Next(0, 3);
        resposta = escolhas[es];

        return resposta;
    }

    public Boolean verific(string chosen)
    {
        if (resposta.Equals("🤚") && chosen.Equals("🤞"))
        {
            return true;
        }

        if (resposta.Equals("🤛") && chosen.Equals("🤚"))
        {
            return true;
        }
        if (resposta.Equals("🤞") && chosen.Equals("🤛"))
        {
            return true;
        }
        return false;
    }
}
