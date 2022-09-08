using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelConsoleTest.DataInits
{
    public class FantasticFourData
    {
        public BaseCardModel[] heroes = new BaseCardModel[]
        {
            new() { Name="Human Torch", Classification=Atts.Hero, Teams=new string[] { Atts.FantasticFour }, Classes=new string[] { Atts.Instinct, Atts.Ranged } },
            new() { Name="Invisible Woman", Classification=Atts.Hero, Teams=new string[] { Atts.FantasticFour }, Classes=new string[] { Atts.Covert, Atts.Ranged } },
            new() { Name="Mr. Fantastic", Classification=Atts.Hero, Teams=new string[] { Atts.FantasticFour }, Classes=new string[] { Atts.Instinct, Atts.Tech } },
            new() { Name="Silver Surfer", Classification=Atts.Hero, Classes=new string[] { Atts.Strength, Atts.Covert, Atts.Ranged } },
            new() { Name="Thing", Classification=Atts.Hero, Teams=new string[] { Atts.FantasticFour }, Classes=new string[] { Atts.Strength, Atts.Instinct } }
        };

        public BaseCardModel[] villains = new BaseCardModel[]
        {
            new() { Name="Heralds of Galactus", Classification=Atts.Villain, Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert, Atts.Ranged } },
            new() { Name="Subterranea", Classification=Atts.Villain }
        };

        public MastermindModel[] masterminds = new MastermindModel[]
        {
            new() { CardInfo=new BaseCardModel() { Name="Galactus", Classification=Atts.Mastermind, 
                    Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert, Atts.Tech, Atts.Ranged } }, UnderlingName="Heralds of Galactus" },
            new() { CardInfo=new BaseCardModel() { Name="Mole Man", Classification=Atts.Mastermind }, UnderlingName="Subterranea" }
        };

        public SchemeModel[] schemes = new SchemeModel[]
        {
            new() { CardInfo=new BaseCardModel() { Name="Bathe Earth in Cosmic Rays", Classification=Atts.Scheme },
                    GameInfo=new GameInfoModel() { TwistCount=6 } },
            new() { CardInfo=new BaseCardModel() { Name="Flood the Planet with Melted Glaciers", Classification=Atts.Scheme },
                    GameInfo=new GameInfoModel() { TwistCount=8 } },
            new() { CardInfo=new BaseCardModel() { Name="Invisible Force Field", Classification=Atts.Scheme },
                    GameInfo=new GameInfoModel() { TwistCount=7 } },
            new() { CardInfo=new BaseCardModel() { Name="Pull Reality into the Negative Zone", Classification=Atts.Scheme },
                    GameInfo=new GameInfoModel() { TwistCount=8 } }
        };

        public void EnterSetDataToDb(DataAccess db)
        {
            foreach (BaseCardModel hero in heroes)
            {
                db.WriteNew<BaseCardModel>(hero, Atts.FantFour);
            }

            foreach (BaseCardModel villain in villains)
            {
                db.WriteNew<BaseCardModel>(villain, Atts.FantFour);
            }

            foreach (MastermindModel mastermind in masterminds)
            {
                db.WriteNew<MastermindModel>(mastermind, Atts.FantFour);
            }

            foreach (SchemeModel scheme in schemes)
            {
                db.WriteNew<SchemeModel>(scheme, Atts.FantFour);
            }
        }
    }
}
