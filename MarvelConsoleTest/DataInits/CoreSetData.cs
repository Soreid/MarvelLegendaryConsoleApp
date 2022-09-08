using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelConsoleTest.DataInits
{
    public class CoreSetData
    {
        public BaseCardModel[] heroes = new BaseCardModel[]
        {
            new() { Name="Black Widow", Classification=Atts.Hero, Teams=new string[] { Atts.Avengers }, Classes=new string[] { Atts.Covert, Atts.Tech } },
            new() { Name="Captain America", Classification=Atts.Hero, Teams=new string[] { Atts.Avengers }, Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert, Atts.Tech } },
            new() { Name="Cyclops", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Strength, Atts.Ranged } },
            new() { Name="Deadpool", Classification=Atts.Hero, Classes=new string[] { Atts.Instinct, Atts.Covert, Atts.Tech } },
            new() { Name="Emma Frost", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert, Atts.Ranged } },
            new() { Name="Gambit", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Instinct, Atts.Covert, Atts.Ranged } },
            new() { Name="Hawkeye", Classification=Atts.Hero, Teams=new string[] { Atts.Avengers }, Classes=new string[] { Atts.Instinct, Atts.Tech } },
            new() { Name="Hulk", Classification=Atts.Hero, Teams=new string[] { Atts.Avengers }, Classes=new string[] { Atts.Strength, Atts.Instinct } },
            new() { Name="Iron Man", Classification=Atts.Hero, Teams=new string[] { Atts.Avengers }, Classes=new string[] { Atts.Tech, Atts.Ranged } },
            new() { Name="Nick Fury", Classification=Atts.Hero, Teams=new string[] { Atts.Shield }, Classes=new string[] { Atts.Strength, Atts.Covert, Atts.Tech } },
            new() { Name="Rogue", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Strength, Atts.Covert } },
            new() { Name="Spider-Man", Classification=Atts.Hero, Teams=new string[] { Atts.SpiderFriends }, Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert, Atts.Tech } },
            new() { Name="Storm", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Covert, Atts.Ranged } },
            new() { Name="Thor", Classification=Atts.Hero, Teams=new string[] { Atts.Avengers }, Classes=new string[] { Atts.Strength, Atts.Ranged } },
            new() { Name="Wolverine", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Instinct } }
        };

        public BaseCardModel[] villains = new BaseCardModel[]
        {
            new() { Name="Brotherhood", Classification=Atts.Villain, Teams=new string[] { Atts.XMen } },
            new() { Name="Enemies of Asgard", Classification=Atts.Villain, Classes=new string[] { Atts.Ranged } },
            new() { Name="Hydra", Classification=Atts.Villain },
            new() { Name="Masters of Evil", Classification=Atts.Villain, Teams=new string[] { Atts.Avengers }, Classes=new string[] { Atts.Tech } },
            new() { Name="Radiation", Classification=Atts.Villain, Classes=new string[] { Atts.Strength } },
            new() { Name="Skrulls", Classification=Atts.Villain },
            new() { Name="Spider-Foes", Classification=Atts.Villain, Classes=new string[] { Atts.Covert } },
        };

        public BaseCardModel[] henchmen = new BaseCardModel[]
        {
            new() { Name="Doombot Legion", Classification=Atts.Henchman },
            new() { Name="Hand Ninjas", Classification=Atts.Henchman },
            new() { Name="Savage Land Mutates", Classification=Atts.Henchman },
            new() { Name="Sentinel", Classification=Atts.Henchman }
        };

        public MastermindModel[] masterminds = new MastermindModel[]
        {
            new() { CardInfo=new BaseCardModel { Name="Dr. Doom", Classification=Atts.Mastermind, Classes=new string[] { Atts.Tech, Atts.Ranged } }, UnderlingName="Doombot Legion" },
            new() { CardInfo=new BaseCardModel { Name="Loki", Classification=Atts.Mastermind, Classes=new string[] { Atts.Strength } }, UnderlingName="Enemies of Asgard" },
            new() { CardInfo=new BaseCardModel { Name="Magneto", Classification=Atts.Mastermind, Teams=new string[] { Atts.XMen } }, UnderlingName="Brotherhood" },
            new() { CardInfo=new BaseCardModel { Name="Red Skull", Classification=Atts.Mastermind }, UnderlingName="Hydra" }
        };

        public SchemeModel[] schemes = new SchemeModel[]
        {
            new() { CardInfo=new BaseCardModel { Name="Super Hero Civil War", Classification=Atts.Scheme },
                    PlayerOverride = new PlayerOverrideModel {
                        TwoPlayer=new GameInfoModel { TwistCount=8, HeroCount=4 },
                        ThreePlayer=new GameInfoModel { TwistCount=8 },
                        FourPlayer=new GameInfoModel { TwistCount=5 },
                        FivePlayer=new GameInfoModel { TwistCount=5 } } },

            new() { CardInfo=new BaseCardModel { Name="Secret Invasion of the Skrull Shapeshifters", Classification=Atts.Scheme }, RequiredCards=new[] { "Skrulls" },
                    GameInfo=new GameInfoModel { TwistCount=8, HeroCount=6 },  MiscInfo=new[] {"12 random Hero cards put into Villain deck"} },

            new() { CardInfo=new BaseCardModel { Name="Replace Eath's Leaders with Killbots", Classification=Atts.Scheme }, 
                    GameInfo=new GameInfoModel { TwistCount=5, BystanderCount=18 } },

            new() { CardInfo=new BaseCardModel { Name="The Legacy Virus", Classification=Atts.Scheme, Classes=new[] { Atts.Tech } },
                    GameInfo=new GameInfoModel { TwistCount=8 } },

            new() { CardInfo=new BaseCardModel { Name="Midtown Bank Robbery", Classification=Atts.Scheme },
                    GameInfo=new GameInfoModel { BystanderCount=12, TwistCount = 8 } },

            new() { CardInfo=new BaseCardModel { Name="Unleash the Power of the Cosmic Cube", Classification=Atts.Scheme }, 
                    GameInfo=new GameInfoModel { TwistCount=8 } },

            new() { CardInfo=new BaseCardModel { Name="Portals to the Dark Dimension", Classification=Atts.Scheme }, 
                    GameInfo=new GameInfoModel { TwistCount=7 } },

             new() { CardInfo=new BaseCardModel { Name="Negative Zone Prison Breakout", Classification=Atts.Scheme },
                    PlayerOverride = new PlayerOverrideModel {
                        TwoPlayer=new GameInfoModel { TwistCount=8, HenchmanCount=2 },
                        ThreePlayer=new GameInfoModel { TwistCount=8, HenchmanCount=2 },
                        FourPlayer=new GameInfoModel { TwistCount=8, HenchmanCount=3 },
                        FivePlayer=new GameInfoModel { TwistCount=8, HenchmanCount=3 } } }


        };

        public void EnterSetDataToDb(DataAccess db)
        {
            foreach(BaseCardModel hero in heroes)
            {
                db.WriteNew<BaseCardModel>(hero, Atts.Core);
            }

            foreach (BaseCardModel villain in villains)
            {
                db.WriteNew<BaseCardModel>(villain, Atts.Core);
            }

            foreach (BaseCardModel henchman in henchmen)
            {
                db.WriteNew<BaseCardModel>(henchman, Atts.Core);
            }

            foreach (MastermindModel mastermind in masterminds)
            {
                db.WriteNew<MastermindModel>(mastermind, Atts.Core);
            }

            foreach (SchemeModel scheme in schemes)
            {
                db.WriteNew<SchemeModel>(scheme, Atts.Core);
            }
        }
    }
}
