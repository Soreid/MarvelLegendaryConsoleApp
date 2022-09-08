using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelConsoleTest.Processes
{
    public class GameInfo
    {
        public GameInfoModel GameSetup(int players)
        {

            GameInfoModel gameStats = new GameInfoModel();

            gameStats.MasterStrikeCount = 5;
            gameStats.MastermindCount = 1;
            switch (players)
            {
                case 1:
                    gameStats.HeroCount = 3;
                    gameStats.VillainCount = 1;
                    gameStats.HenchmanCount = 1;
                    gameStats.BystanderCount = 1;
                    gameStats.MasterStrikeCount = 1;
                    break;
                case 2:
                    gameStats.HeroCount = 5;
                    gameStats.VillainCount = 2;
                    gameStats.HenchmanCount = 1;
                    gameStats.BystanderCount = 2;
                    break;
                case 3:
                    gameStats.HeroCount = 5;
                    gameStats.VillainCount = 3;
                    gameStats.HenchmanCount = 1;
                    gameStats.BystanderCount = 8;
                    break;
                case 4:
                    gameStats.HeroCount = 5;
                    gameStats.VillainCount = 3;
                    gameStats.HenchmanCount = 2;
                    gameStats.BystanderCount = 8;
                    break;
                case 5:
                    gameStats.HeroCount = 6;
                    gameStats.VillainCount = 4;
                    gameStats.HenchmanCount = 2;
                    gameStats.BystanderCount = 12;
                    break;
                default:
                    Console.WriteLine("No players selected!");
                    break;
            }

            return gameStats;
        }

        public GameInfoModel DataOverride(GameInfoModel baseModel, GameInfoModel overrideModel)
        {
            if (overrideModel.BystanderCount >= 0)
                baseModel.BystanderCount = overrideModel.BystanderCount;
            if (overrideModel.HenchmanCount >= 0)
                baseModel.HenchmanCount = overrideModel.HenchmanCount;
            if (overrideModel.HeroCount >= 0)
                baseModel.HeroCount = overrideModel.HeroCount;
            if (overrideModel.MastermindCount >= 0)
                baseModel.MastermindCount = overrideModel.MastermindCount;
            if (overrideModel.MasterStrikeCount >= 0)
                baseModel.MasterStrikeCount = overrideModel.MasterStrikeCount;
            if (overrideModel.TwistCount >= 0)
                baseModel.TwistCount = overrideModel.TwistCount;
            if (overrideModel.VillainCount >= 0)
                baseModel.VillainCount = overrideModel.VillainCount;

            return baseModel;
        }
    }
}
