using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelLegendaryConsoleApp.DataInits
{
    public class PaintRedData
    {
        public BaseCardModel[] heroes = new BaseCardModel[]
{
            new() { Name="Black Cat", Classification=Atts.Hero, Teams=new string[] { Atts.SpiderFriends }, Classes=new string[] { Atts.Instinct, Atts.Covert } },
            new() { Name="Moon Knight", Classification=Atts.Hero, Teams=new string[] { Atts.MarvelKnights }, Classes=new string[] { Atts.Instinct, Atts.Tech } },
            new() { Name="Scarlet Spider", Classification=Atts.Hero, Teams=new string[] { Atts.SpiderFriends }, Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert } },
            new() { Name="Spider-Woman", Classification=Atts.Hero, Teams=new string[] { Atts.SpiderFriends }, Classes=new string[] { Atts.Strength, Atts.Covert, Atts.Ranged } },
            new() { Name="Symbiote Spider-Man", Classification=Atts.Hero, Teams=new string[] { Atts.SpiderFriends }, Classes=new string[] { Atts.Strength, Atts.Instinct, Atts.Covert, Atts.Ranged } }
};

        public BaseCardModel[] villains = new BaseCardModel[]
        {
            new() { Name="Maximum Carnage", Classification=Atts.Villain },
            new() { Name="Sinister Six", Classification=Atts.Villain, Classes=new string[] { Atts.Instinct } }
        };

        public MastermindModel[] masterminds = new MastermindModel[]
        {
            new() { CardInfo=new BaseCardModel() { Name="Carnage", Classification=Atts.Mastermind }, UnderlingName="Maximum Carnage" },
            new() { CardInfo=new BaseCardModel() { Name="Mysterio", Classification=Atts.Mastermind }, UnderlingName="Sinister Six" }
        };

        public SchemeModel[] schemes = new SchemeModel[]
        {
            new() { CardInfo=new BaseCardModel() { Name="Invade the Daily Bugle News HQ", Classification=Atts.Scheme }, MiscInfo=new string[] { "Only six cards from the last henchman group" },
                    PlayerOverride = new PlayerOverrideModel {
                        TwoPlayer=new GameInfoModel { TwistCount=8, HenchmanCount=2 },
                        ThreePlayer=new GameInfoModel { TwistCount=8, HenchmanCount=2 },
                        FourPlayer=new GameInfoModel { TwistCount=8, HenchmanCount=3 },
                        FivePlayer=new GameInfoModel { TwistCount=8, HenchmanCount=3 } } },

            new() { CardInfo=new BaseCardModel() { Name="Weave a Web of Lies", Classification=Atts.Scheme },
                    GameInfo=new GameInfoModel() { TwistCount=7 } },

            new() { CardInfo=new BaseCardModel() { Name="The Clone Saga", Classification=Atts.Scheme },
                    GameInfo=new GameInfoModel() { TwistCount=8 } },

            new() { CardInfo=new BaseCardModel() { Name="Splice Humans with Spider DNA", Classification=Atts.Scheme }, RequiredCards=new string[] {"Sinister Six"},
                    GameInfo=new GameInfoModel() { TwistCount=8 } }
        };

        public void EnterSetDataToDb(DataAccess db)
        {
            foreach (BaseCardModel hero in heroes)
            {
                db.WriteNew<BaseCardModel>(hero, Atts.PaintRed);
            }

            foreach (BaseCardModel villain in villains)
            {
                db.WriteNew<BaseCardModel>(villain, Atts.PaintRed);
            }

            foreach (MastermindModel mastermind in masterminds)
            {
                db.WriteNew<MastermindModel>(mastermind, Atts.PaintRed);
            }

            foreach (SchemeModel scheme in schemes)
            {
                db.WriteNew<SchemeModel>(scheme, Atts.PaintRed);
            }
        }
    }
}
