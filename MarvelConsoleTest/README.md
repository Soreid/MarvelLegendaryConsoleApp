Welcome! This Marvel Legendary Console app is aimed to help with setup of the Marvel Legendary Deck Building Game.

The program currently runs in the console and requires a local MongoDB instance to write and read data of the included game sets.

For reference, full rules for the game can be found at http://www.upperdeck.com/op/rulebooks/legendary_rules-core_set.pdf.

Providing a number of players from 1 to 5 will provide the set of cards to use during the game appropriate for the number of players.
The program will get a scheme and mastermind to use for the game.
The Villain deck contents will be generated based on the scheme and player count parameters, accounting for the Mastermind's 'Always Leads' ability.
The Heroes to use in the Hero deck will also be generated for the game.
There should be no duplicate listings in any given session.

The heroes chosen will always match requirements of the selections for the Villain deck.
For example, Loki requires a Strength class card to be revealed and Sabretooth requires an X-Men hero to be revealed.
Any sessions including this combination will always have at least one X-Men and at least one Strength card.
These cards can be through the same hero (such as Rogue) or different heroes (such as Hulk and Gambit) until all requirements are filled.

The program currently includes information for the core game plus the following expansions:
+ Dark City
+ Fantastic Four

Updates to be included at a future date:
+ Ability to include or exclude specific expansion sets
+ Full list of expansions

Reference for the card details was taken from https://marveldbg.wordpress.com/.