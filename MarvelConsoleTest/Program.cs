using MarvelConsoleTest.DataInits;
using MarvelConsoleTest.Processes;
using System.Reflection.Metadata;

DataAccess db = new("MarvelLegendary");
Random rand = new();
GameInfo gameInfo = new();
List<string> includedSets = new() { Atts.Core, Atts.DarkCity, Atts.FantFour };

//  Enter new set info to Database

List<string> CollectionList = db.ListCollections();

if (!CollectionList.Contains(Atts.Core))
{
    CoreSetData coreSet = new CoreSetData();
    coreSet.EnterSetDataToDb(db);
}
if (!CollectionList.Contains(Atts.DarkCity))
{
    DarkCityData darkSet = new DarkCityData();
    darkSet.EnterSetDataToDb(db);
}
if (!CollectionList.Contains(Atts.FantFour))
{
    FantasticFourData fantFourSet = new FantasticFourData();
    fantFourSet.EnterSetDataToDb(db);
}


List<BaseCardModel> heroes = new(), henchmen = new(), villains = new();
List<MastermindModel> masterminds = new();
List<SchemeModel> schemes = new();

//Get all data from local database for each used set
foreach (string set in includedSets)
{
    heroes.AddRange(db.ReadByType<BaseCardModel>(set, Atts.Hero));
    henchmen.AddRange(db.ReadByType<BaseCardModel>(set, Atts.Henchman));
    villains.AddRange(db.ReadByType<BaseCardModel>(set, Atts.Villain));
    masterminds.AddRange(db.ReadByType<MastermindModel>(set, Atts.Mastermind));
    schemes.AddRange(db.ReadByType<SchemeModel>(set, Atts.Scheme));
}

Console.Write("Enter the number of players (1-5): ");
int players = Convert.ToInt32(Console.ReadLine());
while(players <= 0 || players > 5)
{
    Console.Write("Enter the number of players (1-5): ");
    players = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("-----------------------------------");
Console.WriteLine();

GameInfoModel sessionData = gameInfo.GameSetup(players);

List<BaseCardModel> sessionHeroes = new();
List<BaseCardModel> sessionHenchmen = new();
List<BaseCardModel> sessionVillains = new();
List<MastermindModel> sessionMasterminds = new();
List<string> requiredTeams = new();
List<string> requiredClasses = new();

//Get and implement Scheme rules

Console.Write("Scheme: ");
SchemeModel sessionScheme = schemes[rand.Next(schemes.Count())];
while(players == 1 && sessionScheme.CardInfo.Name == "Super Hero Civil War" || players == 1 && sessionScheme.CardInfo.Name == "Negative Zone Prison Breakout")
{
    sessionScheme = schemes[rand.Next(schemes.Count())];
}
Console.WriteLine(sessionScheme.CardInfo.Name);

if (sessionScheme.GameInfo != null)
{
    gameInfo.DataOverride(sessionData, sessionScheme.GameInfo);
}

//Check for scheme data that implements different setup from regular player setup
if (sessionScheme.PlayerOverride != null)
{
    if (players == 1)
        gameInfo.DataOverride(sessionData, sessionScheme.PlayerOverride.OnePlayer);
    if (players == 2)
        gameInfo.DataOverride(sessionData, sessionScheme.PlayerOverride.TwoPlayer);
    if (players == 3)
        gameInfo.DataOverride(sessionData, sessionScheme.PlayerOverride.ThreePlayer);
    if (players == 4)
        gameInfo.DataOverride(sessionData, sessionScheme.PlayerOverride.FourPlayer);
    if (players == 5)
        gameInfo.DataOverride(sessionData, sessionScheme.PlayerOverride.FivePlayer);
}
Console.WriteLine();

if (sessionScheme.RequiredCards != null)
{
    foreach (string name in sessionScheme.RequiredCards)
    {
        BaseCardModel card = new();
        foreach (string set in includedSets)
        {
            BaseCardModel check = db.ReadByName<BaseCardModel>(set, name);
            if (check != null)
            {
                card = check;
                break;
            }
        }
        if (card.Classification != Atts.Hero)
        {
            AddUnitToSessionData(card);
        }
        else
        {
            AddUnitToSessionDataOverride(card, sessionVillains);
        }
    }
}

//Add heroes to villain deck list if the scheme requires it
while (sessionScheme.HeroesAsVillains > 0)
{
    AddUnitToSessionDataOverride(heroes[rand.Next(heroes.Count())], sessionVillains);
    sessionScheme.HeroesAsVillains--;
}

//Get and implement Mastermind data

Console.Write("Mastermind: ");
while (sessionMasterminds.Count() < sessionData.MastermindCount)
{
    MastermindModel m = masterminds[rand.Next(masterminds.Count())];
    string underling = m.UnderlingName;

    if (players != 1)
    {
        BaseCardModel uCard = null;
        int setIndex = 0;
        while (uCard == null)
        {
            uCard = db.ReadByName<BaseCardModel>(includedSets[setIndex], underling);
            setIndex++;
        }

        AddUnitToSessionData(uCard);
    }

    AddMastermindToSessionData(m);

    Console.WriteLine(m.CardInfo.Name);
}

Console.WriteLine();
Console.WriteLine("-- Villain Deck Contents --");
Console.WriteLine();

while (sessionVillains.Count() < sessionData.VillainCount)
{
    AddUnitToSessionData(villains[rand.Next(villains.Count())]);
}
foreach (var v in sessionVillains)
{
    Console.WriteLine("-" + v.Name);
}
Console.WriteLine();

Console.WriteLine("Henchmen:");
while (sessionHenchmen.Count() < sessionData.HenchmanCount)
{
    AddUnitToSessionData(henchmen[rand.Next(henchmen.Count())]);
}
foreach (var h in sessionHenchmen)
{
    Console.WriteLine("-" + h.Name);
}

Console.WriteLine();
Console.WriteLine("Bystanders: " + sessionData.BystanderCount);
Console.WriteLine("Scheme Twists: " + sessionData.TwistCount);
Console.WriteLine("Master Strikes: " + sessionData.MasterStrikeCount);

if (sessionScheme.MiscInfo != null)
{
    foreach (string line in sessionScheme.MiscInfo)
    {
        Console.WriteLine("Extra: " + line);
    }
}

Console.WriteLine();
Console.WriteLine("-- Hero Deck Contents --");
Console.WriteLine();

//Find the first heroes by requirements of the mastermind and villains groups
while (requiredTeams.Count > 0 || requiredClasses.Count() > 0)
{
    if (requiredTeams.Count > 0)
        AddUnitByAttToSessionData(requiredTeams[0]);

    if (requiredClasses.Count > 0)
        AddUnitByAttToSessionData(requiredClasses[0]);
}

while (sessionHeroes.Count() < sessionData.HeroCount)
{
    AddUnitToSessionData(heroes[rand.Next(heroes.Count())]);
}
foreach (var h in sessionHeroes)
{
    Console.WriteLine("-" + h.Name);
}


Console.ReadLine();


//End of Program


void AddUnitToSessionData(BaseCardModel c)
{
    if (c.Classification == Atts.Hero)
    {
        BaseCardModel hero = heroes.Find(x => x.Name == c.Name);
        sessionHeroes.Add(hero);

        if (hero.Teams != null)
        {
            foreach (string t in hero.Teams)
            {
                requiredTeams.RemoveAll(x => x == t);
            }
        }
        if (hero.Classes != null)
        {
            foreach (string color in hero.Classes)
            {
                requiredClasses.RemoveAll(x => x == color);
            }
        }

        heroes.Remove(hero);
    }
    if (c.Classification == Atts.Henchman)
    {
        BaseCardModel henchman = henchmen.Find(x => x.Name == c.Name);
        sessionHenchmen.Add(henchman);
        if (henchman.Teams != null)
            requiredTeams.AddRange(henchman.Teams);
        if (henchman.Classes != null)
            requiredClasses.AddRange(henchman.Classes);
        henchmen.Remove(henchman);
    }
    if (c.Classification == Atts.Villain)
    {
        BaseCardModel villain = villains.Find(x => x.Name == c.Name);
        sessionVillains.Add(villain);
        if (villain.Teams != null)
            requiredTeams.AddRange(villain.Teams);
        if (villain.Classes != null)
            requiredClasses.AddRange(villain.Classes);
        villains.Remove(villain);
    }
}

void AddUnitToSessionDataOverride(BaseCardModel c, List<BaseCardModel> destination)
{
    if (c.Classification == Atts.Hero)
    {
        BaseCardModel hero = heroes.Find(x => x.Name == c.Name);
        destination.Add(hero);
        heroes.Remove(hero);
    }
    if (c.Classification == Atts.Henchman)
    {
        BaseCardModel henchman = henchmen.Find(x => x.Name == c.Name);
        destination.Add(henchman);
        henchmen.Remove(henchman);
    }
    if (c.Classification == Atts.Villain)
    {
        BaseCardModel villain = villains.Find(x => x.Name == c.Name);
        destination.Add(villain);
        villains.Remove(villain);
    }
}

void AddMastermindToSessionData(MastermindModel c)
{
    sessionMasterminds.Add(c);
    masterminds.Remove(c);
}

void AddUnitByAttToSessionData(string att)
{
    List<BaseCardModel> heroList = new();

    foreach (string set in includedSets)
    {
        heroList.AddRange(db.ReadByAttribute<BaseCardModel>(set, att));
    }
    for (int i = heroList.Count - 1; i >= 0; i--)
    {
        if (heroList[i].Classification != Atts.Hero)
            heroList.RemoveAt(i);
    }

    AddUnitToSessionData(heroList[rand.Next(heroList.Count())]);
}