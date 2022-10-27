using MauiCRUD.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static Android.Content.ClipData;

namespace MauiCRUD.Logic
{
    public class VideoGamesLogic : IVideoGamesLogic
    {
        private static List<GameModel> _games;

        public VideoGamesLogic()
        {
            if(_games == null)
            {
                _games = new List<GameModel>()
                {
                    new GameModel(){ID = 1, Name = "Lost Planet", isAvailable = true, Price = 999},
                    new GameModel(){ID = 2, Name = "Modern Warfare", isAvailable = false, Price = 199},
                    new GameModel(){ID = 3, Name = "Ghost Recon", isAvailable = true, Price = 399},
                    new GameModel(){ID = 4, Name = "Rainbow Six", isAvailable = true, Price = 699},
                    new GameModel(){ID = 5, Name = "Destiny", isAvailable = false, Price = 499},
                };
            }
        }

        public GameModel GetVideoGameByID(int id)
        {
            return _games.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<GameModel> GetVideoGames()
        {
            return _games;
        }

        public GameModel AddVideoGame(GameModel gameModel)
        {
            if(gameModel != null)
            {
                int nextId = _games.Max(i => i.ID);
                gameModel.ID = nextId + 1;
                _games.Add(gameModel);
            }
            else
            {
                throw new ArgumentNullException();
            }
            
            return gameModel;
        }

        public GameModel UpdateVideoGame(GameModel game)
        {
            GameModel UpdateModel = new GameModel();
            ArgumentNullException.ThrowIfNull(game);
            UpdateModel = _games.Where(x => x.ID == game.ID).FirstOrDefault();
            UpdateModel.Name = game.Name;
            UpdateModel.Price = game.Price;
            UpdateModel.isAvailable = game.isAvailable;

            return UpdateModel;
        }

        public void RemoveVideoGameByID(int id)
        {
            var game = _games.Where(x => x.ID == id).FirstOrDefault();
            ArgumentNullException.ThrowIfNull(game);
            _games.Remove(game);
        }



    }
}
