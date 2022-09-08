using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelConsoleTest.DataInits
{
    public class DarkCityData
    {
        public BaseCardModel[] heroes = new BaseCardModel[]
        {
            new() { Name="Angel", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert, Atts.Tech, Atts.Ranged } },
            new() { Name="Bishop", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Covert, Atts.Tech, Atts.Ranged } },
            new() { Name="Blade", Classification=Atts.Hero, Teams=new string[] { Atts.MarvelKnights }, Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert, Atts.Tech } },
            new() { Name="Cable", Classification=Atts.Hero, Teams=new string[] { Atts.XForce }, Classes=new string[] { Atts.Covert, Atts.Tech, Atts.Ranged } },
            new() { Name="Colossus", Classification=Atts.Hero, Teams=new string[] { Atts.XForce }, Classes=new string[] { Atts.Strength, Atts.Covert } },
            new() { Name="Daredevil", Classification=Atts.Hero, Teams=new string[] { Atts.MarvelKnights }, Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert } },
            new() { Name="Domino", Classification=Atts.Hero, Teams=new string[] { Atts.XForce }, Classes=new string[] { Atts.Instinct, Atts.Covert, Atts.Tech } },
            new() { Name="Elektra", Classification=Atts.Hero, Teams=new string[] { Atts.MarvelKnights }, Classes=new string[] { Atts.Instinct, Atts.Covert } },
            new() { Name="Forge", Classification=Atts.Hero, Teams=new string[] { Atts.XForce }, Classes=new string[] { Atts.Tech } },
            new() { Name="Ghost Rider", Classification=Atts.Hero, Teams=new string[] { Atts.MarvelKnights }, Classes=new string[] { Atts.Strength, Atts.Tech, Atts.Ranged } },
            new() { Name="Iceman", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Strength, Atts.Ranged } },
            new() { Name="Iron Fist", Classification=Atts.Hero, Teams=new string[] { Atts.MarvelKnights }, Classes=new string[] { Atts.Strength, Atts.Instinct } },
            new() { Name="Jean Grey", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Covert, Atts.Ranged } },
            new() { Name="Nightcrawler", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Instinct, Atts.Covert } },
            new() { Name="Professor X", Classification=Atts.Hero, Teams=new string[] { Atts.XMen }, Classes=new string[] { Atts.Instinct, Atts.Covert, Atts.Ranged } },
            new() { Name="Punisher", Classification=Atts.Hero, Teams=new string[] { Atts.MarvelKnights }, Classes=new string[] { Atts.Strength, Atts.Tech } },
            new() { Name="X-Force Wolverine", Classification=Atts.Hero, Teams=new string[] { Atts.XForce }, Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert } }
        };

        public BaseCardModel[] villains = new BaseCardModel[] {
            new() { Name="Emissaries of Evil", Classification=Atts.Villain },
            new() { Name="Four Horsemen", Classification=Atts.Villain, Classes=new string[] { Atts.Instinct } },
            new() { Name="Marauders", Classification=Atts.Villain },
            new() { Name="MLF", Classification=Atts.Villain },
            new() { Name="Streets of New York", Classification=Atts.Villain, Classes=new string[] { Atts.Strength } },
            new() { Name="Underworld", Classification=Atts.Villain, Teams=new string[] { Atts.MarvelKnights } }
        };

        public BaseCardModel[] henchmen = new BaseCardModel[]
        {
            new() { Name="Maggia Goons", Classification=Atts.Henchman },
            new() { Name="Phalanx", Classification=Atts.Henchman, Classes=new string[] { Atts.Tech } }
        };

        public MastermindModel[] masterminds = new MastermindModel[]
        {
            new() { CardInfo=new BaseCardModel() { Name="Apocalypse", Classification=Atts.Mastermind }, UnderlingName="Four Horsemen" },
            new() { CardInfo=new BaseCardModel() { Name="Kingpin", Classification=Atts.Mastermind, Teams=new string[] { Atts.MarvelKnights } }, UnderlingName="Streets of New York" },
            new() { CardInfo=new BaseCardModel() { Name="Mephisto", Classification=Atts.Mastermind, Teams=new string[] { Atts.MarvelKnights } }, UnderlingName="Underworld" },
            new() { CardInfo=new BaseCardModel() { Name="Mr. Sinister", Classification=Atts.Mastermind, Classes=new string[] { Atts.Covert } }, UnderlingName="Marauders" },
            new() { CardInfo=new BaseCardModel() { Name="Stryfe", Classification=Atts.Mastermind, Teams=new string[] { Atts.XForce } }, UnderlingName="MLF" }
        };

        public SchemeModel[] schemes = new SchemeModel[]
        {
            new() { CardInfo=new BaseCardModel() { Name="Capture Baby Hope", Classification=Atts.Scheme },
                    GameInfo=new GameInfoModel() { TwistCount=8 } },

            new() { CardInfo=new BaseCardModel() { Name="X-Cutioner's Song", Classification=Atts.Scheme }, HeroesAsVillains=1,
                    PlayerOverride=new PlayerOverrideModel{
                        OnePlayer=new GameInfoModel { TwistCount=8, VillainCount=2, BystanderCount=0 },
                        TwoPlayer=new GameInfoModel { TwistCount=8, VillainCount=3, BystanderCount=0 },
                        ThreePlayer=new GameInfoModel { TwistCount=8, VillainCount=4, BystanderCount=0 },
                        FourPlayer=new GameInfoModel { TwistCount=8, VillainCount=4, BystanderCount=0 },
                        FivePlayer=new GameInfoModel { TwistCount=8, VillainCount=5, BystanderCount=0 } } },

            new() { CardInfo=new BaseCardModel() { Name="Transform Citizens into Demons", Classification=Atts.Scheme }, RequiredCards=new string[] {"Jean Grey"},
                    PlayerOverride=new PlayerOverrideModel{
                        OnePlayer=new GameInfoModel { TwistCount=8, VillainCount=2, BystanderCount=0 },
                        TwoPlayer=new GameInfoModel { TwistCount=8, VillainCount=3, BystanderCount=0 },
                        ThreePlayer=new GameInfoModel { TwistCount=8, VillainCount=4, BystanderCount=0 },
                        FourPlayer=new GameInfoModel { TwistCount=8, VillainCount=4, BystanderCount=0 },
                        FivePlayer=new GameInfoModel { TwistCount=8, VillainCount=5, BystanderCount=0 } } },

            new() { CardInfo=new BaseCardModel() { Name="Steal the Weaponized Plutonium", Classification=Atts.Scheme },
                    PlayerOverride=new PlayerOverrideModel{
                        OnePlayer=new GameInfoModel { TwistCount=8, VillainCount=2 },
                        TwoPlayer=new GameInfoModel { TwistCount=8, VillainCount=3 },
                        ThreePlayer=new GameInfoModel{ TwistCount=8, VillainCount=4 },
                        FourPlayer=new GameInfoModel { TwistCount=8, VillainCount=4 },
                        FivePlayer=new GameInfoModel { TwistCount=8, VillainCount=5 } } },

            new() { CardInfo=new BaseCardModel() { Name="Detonate the Helicarrier", Classification=Atts.Scheme },
                    GameInfo=new GameInfoModel() { TwistCount=8, HeroCount=6 } },

            new() { CardInfo=new BaseCardModel() { Name="Save Humanity", Classification=Atts.Scheme, Classes=new string[] { Atts.Instinct } },
                    PlayerOverride=new PlayerOverrideModel{
                        OnePlayer=new GameInfoModel() { TwistCount=8, BystanderCount=12 },
                        TwoPlayer=new GameInfoModel() { TwistCount=8, BystanderCount=24 },
                        ThreePlayer=new GameInfoModel() { TwistCount=8, BystanderCount=24 },
                        FourPlayer=new GameInfoModel() { TwistCount=8, BystanderCount=24 },
                        FivePlayer=new GameInfoModel() { TwistCount=8, BystanderCount=24 } } },

            new() { CardInfo=new BaseCardModel() { Name="Massive Earthquake Generator", Classification=Atts.Scheme, Classes=new string[] { Atts.Strength } },
                    GameInfo=new GameInfoModel() { TwistCount=8 } },

            new() { CardInfo=new BaseCardModel() { Name="Organized Crime Wave", Classification=Atts.Scheme }, RequiredCards=new string[] { "Maggia Goons" },
                    GameInfo=new GameInfoModel() { TwistCount=8 }}
        };

        public void EnterSetDataToDb(DataAccess db)
        {
            foreach (BaseCardModel hero in heroes)
            {
                db.WriteNew<BaseCardModel>(hero, Atts.DarkCity);
            }

            foreach (BaseCardModel villain in villains)
            {
                db.WriteNew<BaseCardModel>(villain, Atts.DarkCity);
            }

            foreach (BaseCardModel henchman in henchmen)
            {
                db.WriteNew<BaseCardModel>(henchman, Atts.DarkCity);
            }

            foreach (MastermindModel mastermind in masterminds)
            {
                db.WriteNew<MastermindModel>(mastermind, Atts.DarkCity);
            }

            foreach (SchemeModel scheme in schemes)
            {
                db.WriteNew<SchemeModel>(scheme, Atts.DarkCity);
            }
        }
    }
}
