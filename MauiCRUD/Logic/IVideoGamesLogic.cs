using MauiCRUD.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCRUD.Logic
{
    public interface IVideoGamesLogic
    {
        #region Read
        public GameModel GetVideoGameByID(int id);
        public List<GameModel> GetVideoGames();
        #endregion
        public GameModel AddVideoGame(GameModel gameModel);
        public GameModel UpdateVideoGame(GameModel game);
        public void RemoveVideoGameByID(int id);
    }
}
