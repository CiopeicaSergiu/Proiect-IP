using Poker.Interfaces;
using System.Windows.Forms;

namespace Poker
{
    public class GameStatesFactory : IGameStatesFactory
    {
        public Form GetGameState(string type)
        {
            Form gameState = null;
            switch (type)
            {
                case "StartMenu":
                    gameState = new StartMenu();
                    break;
                case "NewGame":
                    gameState = new NewGame();
                    break;
                case "Options":
                    gameState = new Options();
                    break;
                default:
                    gameState = new StartMenu();
                    break;

            }
            return gameState;
        }
    }
}
