
using System.Windows.Forms;
namespace Poker.Interfaces
{
    public interface IGameStatesFactory
    {
       Form GetGameState(string type);
    }
}
