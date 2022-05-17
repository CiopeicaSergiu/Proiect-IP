
using System.Collections.Generic;
using System.Windows.Forms;

namespace Poker
{
    public class GameManager
    {
        private Dictionary<string, Form> _gameStates;
        private static GameManager _currentGameManager;
        private GameStatesFactory _gameStatesFactory;

        private GameManager()
        { 
            _gameStates = new Dictionary<string, Form>();
            _currentGameManager = new GameManager();
            _gameStatesFactory = new GameStatesFactory();

            _gameStates.Add("StartMenu", _gameStatesFactory.GetGameState("StartMenu"));
            _gameStates.Add("NewGame", _gameStatesFactory.GetGameState("NewGame"));
            _gameStates.Add("Options", _gameStatesFactory.GetGameState("Options"));
        }

        static public GameManager GetGameManager()
        { 
            if(_currentGameManager == null)
                _currentGameManager = new GameManager();
            return _currentGameManager;
        }

        public void GetGameState(string type, out Form gameState)
        {
            if (type == "StartMenu" || type == "NewGame" || type == "Options")
                gameState = _gameStates[type];
            else
                gameState = _gameStates["StartMenu"];
        }


    }
}
