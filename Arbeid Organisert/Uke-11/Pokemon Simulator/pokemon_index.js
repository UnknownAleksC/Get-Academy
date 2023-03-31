const pokemonIndex = [
    {
        pokedexNum: 1,
        pokemonName: 'Bulbasaur',
        element: ['Grass', 'Poison'],
        weakness: ['Fire', 'Ice', 'Flying', 'Psychic']
    },
    {
        pokedexNum: 2,
        pokemonName: 'Ivysaur',
        element: ['Grass', 'Poison'],
        weakness: ['Fire', 'Ice', 'Flying', 'Psychic']
    },
    {
        pokedexNum: 3,
        pokemonName: 'Venusaur',
        element: ['Grass', 'Poison'],
        weakness: ['Fire', 'Ice', 'Flying', 'Psychic']
    },
    {
        pokedexNum: 4,
        pokemonName: 'Charmander',
        element: ['Fire'],
        weakness: ['Water', 'Ground', 'Rock']
    },
    {
        pokedexNum: 5,
        pokemonName: 'Charmeleon',
        element: ['Fire'],
        weakness: ['Water', 'Ground', 'Rock']
    },
    {
        pokedexNum: 6,
        pokemonName: 'Charizard',
        element: ['Fire', 'Flying'],
        weakness: ['Water', 'Electric', 'Rock']
    },
    {
        pokedexNum: 7,
        pokemonName: 'Squirtle',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 8,
        pokemonName: 'Wartortle',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 9,
        pokemonName: 'Blastoise',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 10,
        pokemonName: 'Caterpie',
        element: ['Bug'],
        weakness: ['Fire', 'Flying', 'Rock']
    },
    {
        pokedexNum: 11,
        pokemonName: 'Metapod',
        element: ['Bug'],
        weakness: ['Fire', 'Flying', 'Rock']
    },
    {
        pokedexNum: 12,
        pokemonName: 'Butterfree',
        element: ['Bug', 'Flying'],
        weakness: ['Fire', 'Electric', 'Ice', 'Flying', 'Rock']
    },
    {
        pokedexNum: 13,
        pokemonName: 'Weedle',
        element: ['Bug', 'Poison'],
        weakness: ['Fire', 'Flying', 'Psychic', 'Rock']
    },
    {
        pokedexNum: 14,
        pokemonName: 'Kakuna',
        element: ['Bug', 'Poison'],
        weakness: ['Fire', 'Flying', 'Psychic', 'Rock']
    },
    {
        pokedexNum: 15,
        pokemonName: 'Beedrill',
        element: ['Bug', 'Poison'],
        weakness: ['Fire', 'Flying', 'Psychic', 'Rock']
    },
    {
        pokedexNum: 16,
        pokemonName: 'Pidgey',
        element: ['Normal', 'Flying'],
        weakness: ['Electric', 'Ice', 'Rock']
    },
    {
        pokedexNum: 17,
        pokemonName: 'Pidgeotto',
        element: ['Normal', 'Flying'],
        weakness: ['Electric', 'Ice', 'Rock']
    },
    {
        pokedexNum: 18,
        pokemonName: 'Pidgeot',
        element: ['Normal', 'Flying'],
        weakness: ['Electric', 'Ice', 'Rock']
    },
    {
        pokedexNum: 19,
        pokemonName: 'Rattata',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 20,
        pokemonName: 'Raticate',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 21,
        pokemonName: 'Spearow',
        element: ['Normal', 'Flying'],
        weakness: ['Electric', 'Ice', 'Rock']
    },
    {
        pokedexNum: 22,
        pokemonName: 'Fearow',
        element: ['Normal', 'Flying'],
        weakness: ['Electric', 'Ice', 'Rock']
    },
    {
        pokedexNum: 23,
        pokemonName: 'Ekans',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 24,
        pokemonName: 'Arbok',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 25,
        pokemonName: 'Pikachu',
        element: ['Electric'],
        weakness: ['Ground']
    },
    {
        pokedexNum: 26,
        pokemonName: 'Raichu',
        element: ['Electric'],
        weakness: ['Ground']
    },
    {
        pokedexNum: 27,
        pokemonName: 'Sandshrew',
        element: ['Ground'],
        weakness: ['Water', 'Grass', 'Ice']
    },
    {
        pokedexNum: 28,
        pokemonName: 'Sandslash',
        element: ['Ground'],
        weakness: ['Water', 'Grass', 'Ice']
    },
    {
        pokedexNum: 29,
        pokemonName: 'Nidoran♀',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 30,
        pokemonName: 'Nidorina',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 31,
        pokemonName: 'Nidoqueen',
        element: ['Poison', 'Ground'],
        weakness: ['Water', 'Ice', 'Ground', 'Psychic']
    },
    {
        pokedexNum: 32,
        pokemonName: 'Nidoran♂',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 33,
        pokemonName: 'Nidorino',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 34,
        pokemonName: 'Nidoking',
        element: ['Poison', 'Ground'],
        weakness: ['Water', 'Ice', 'Ground', 'Psychic']
    },
    {
        pokedexNum: 35,
        pokemonName: 'Clefairy',
        element: ['Fairy'],
        weakness: ['Steel', 'Poison']
    },
    {
        pokedexNum: 36,
        pokemonName: 'Clefable',
        element: ['Fairy'],
        weakness: ['Steel', 'Poison']
    },
    {
        pokedexNum: 37,
        pokemonName: 'Vulpix',
        element: ['Fire'],
        weakness: ['Water', 'Ground', 'Rock']
    },
    {
        pokedexNum: 38,
        pokemonName: 'Ninetales',
        element: ['Fire'],
        weakness: ['Water', 'Ground', 'Rock']
    },
    {
        pokedexNum: 39,
        pokemonName: 'Jigglypuff',
        element: ['Normal', 'Fairy'],
        weakness: ['Steel', 'Poison']
    },
    {
        pokedexNum: 40,
        pokemonName: 'Wigglytuff',
        element: ['Normal', 'Fairy'],
        weakness: ['Steel', 'Poison']
    },
    {
        pokedexNum: 41,
        pokemonName: 'Zubat',
        element: ['Poison', 'Flying'],
        weakness: ['Electric', 'Ice', 'Psychic', 'Rock']
    },
    {
        pokedexNum: 42,
        pokemonName: 'Golbat',
        element: ['Poison', 'Flying'],
        weakness: ['Electric', 'Ice', 'Psychic', 'Rock']
    },
    {
        pokedexNum: 43,
        pokemonName: 'Oddish',
        element: ['Grass', 'Poison'],
        weakness: ['Fire', 'Ice', 'Flying', 'Psychic']
    },
    {
        pokedexNum: 44,
        pokemonName: 'Gloom',
        element: ['Grass', 'Poison'],
        weakness: ['Fire', 'Ice', 'Flying', 'Psychic']
    },
    {
        pokedexNum: 45,
        pokemonName: 'Vileplume',
        element: ['Grass', 'Poison'],
        weakness: ['Fire', 'Ice', 'Flying', 'Psychic']
    },
    {
        pokedexNum: 46,
        pokemonName: 'Paras',
        element: ['Bug', 'Grass'],
        weakness: ['Fire', 'Ice', 'Flying', 'Bug', 'Poison', 'Rock']
    },
    {
        pokedexNum: 47,
        pokemonName: 'Parasect',
        element: ['Bug', 'Grass'],
        weakness: ['Fire', 'Ice', 'Flying', 'Bug', 'Poison', 'Rock']
    },
    {
        pokedexNum: 48,
        pokemonName: 'Venonat',
        element: ['Bug', 'Poison'],
        weakness: ['Fire', 'Flying', 'Psychic', 'Rock']
    },
    {
        pokedexNum: 49,
        pokemonName: 'Venomoth',
        element: ['Bug', 'Poison'],
        weakness: ['Fire', 'Flying', 'Psychic', 'Rock']
    },
    {
        pokedexNum: 50,
        pokemonName: 'Diglett',
        element: ['Ground'],
        weakness: ['Water', 'Grass', 'Ice']
    },
    {
        pokedexNum: 51,
        pokemonName: 'Dugtrio',
        element: ['Ground'],
        weakness: ['Water', 'Grass', 'Ice']
    },
    {
        pokedexNum: 52,
        pokemonName: 'Meowth',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 53,
        pokemonName: 'Persian',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 54,
        pokemonName: 'Psyduck',
        element: ['Water'],
        weakness: ['Electric', 'Grass']
    },
    {
        pokedexNum: 55,
        pokemonName: 'Golduck',
        element: ['Water'],
        weakness: ['Electric', 'Grass']
    },
    {
        pokedexNum: 56,
        pokemonName: 'Mankey',
        element: ['Fighting'],
        weakness: ['Flying', 'Psychic']
    },
    {
        pokedexNum: 57,
        pokemonName: 'Primeape',
        element: ['Fighting'],
        weakness: ['Flying', 'Psychic']
    },
    {
        pokedexNum: 58,
        pokemonName: 'Growlithe',
        element: ['Fire'],
        weakness: ['Water', 'Ground', 'Rock']
    },
    {
        pokedexNum: 59,
        pokemonName: 'Arcanine',
        element: ['Fire'],
        weakness: ['Water', 'Ground', 'Rock']
    },
    {
        pokedexNum: 60,
        pokemonName: 'Poliwag',
        element: ['Water'],
        weakness: ['Electric', 'Grass']
    },
    {
        pokedexNum: 61,
        pokemonName: 'Poliwhirl',
        element: ['Water'],
        weakness: ['Electric', 'Grass']
    },
    {
        pokedexNum: 62,
        pokemonName: 'Poliwrath',
        element: ['Water', 'Fighting'],
        weakness: ['Electric', 'Grass', 'Flying', 'Psychic']
    },
    {
        pokedexNum: 63,
        pokemonName: 'Abra',
        element: ['Psychic'],
        weakness: ['Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 64,
        pokemonName: 'Kadabra',
        element: ['Psychic'],
        weakness: ['Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 65,
        pokemonName: 'Alakazam',
        element: ['Psychic'],
        weakness: ['Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 66,
        pokemonName: 'Machop',
        element: ['Fighting'],
        weakness: ['Flying', 'Psychic']
    },
    {
        pokedexNum: 67,
        pokemonName: 'Machoke',
        element: ['Fighting'],
        weakness: ['Flying', 'Psychic']
    },
    {
        pokedexNum: 68,
        pokemonName: 'Machamp',
        element: ['Fighting'],
        weakness: ['Flying', 'Psychic']
    },
    {
        pokedexNum: 69,
        pokemonName: 'Bellsprout',
        element: ['Grass', 'Poison'],
        weakness: ['Fire', 'Ice', 'Flying', 'Psychic']
    },
    {
        pokedexNum: 70,
        pokemonName: 'Weepinbell',
        element: ['Grass', 'Poison'],
        weakness: ['Fire', 'Ice', 'Flying', 'Psychic']
    },
    {
        pokedexNum: 71,
        pokemonName: 'Victreebel',
        element: ['Grass', 'Poison'],
        weakness: ['Fire', 'Ice', 'Flying', 'Psychic']
    },
    {
        pokedexNum: 72,
        pokemonName: 'Tentacool',
        element: ['Water', 'Poison'],
        weakness: ['Electric', 'Ground', 'Psychic']
    },
    {
        pokedexNum: 73,
        pokemonName: 'Tentacruel',
        element: ['Water', 'Poison'],
        weakness: ['Electric', 'Ground', 'Psychic']
    },
    {
        pokedexNum: 74,
        pokemonName: 'Geodude',
        element: ['Rock', 'Ground'],
        weakness: ['Water', 'Grass', 'Ice', 'Fighting', 'Ground', 'Steel']
    },
    {
        pokedexNum: 75,
        pokemonName: 'Graveler',
        element: ['Rock', 'Ground'],
        weakness: ['Water', 'Grass', 'Ice', 'Fighting', 'Ground', 'Steel']
    },
    {
        pokedexNum: 76,
        pokemonName: 'Golem',
        element: ['Rock', 'Ground'],
        weakness: ['Water', 'Grass', 'Ice', 'Fighting', 'Ground', 'Steel']
    },
    {
        pokedexNum: 77,
        pokemonName: 'Ponyta',
        element: ['Fire'],
        weakness: ['Water', 'Ground', 'Rock']
    },
    {
        pokedexNum: 78,
        pokemonName: 'Rapidash',
        element: ['Fire'],
        weakness: ['Water', 'Ground', 'Rock']
    },
    {
        pokedexNum: 79,
        pokemonName: 'Slowpoke',
        element: ['Water', 'Psychic'],
        weakness: ['Electric', 'Grass', 'Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 80,
        pokemonName: 'Slowbro',
        element: ['Water', 'Psychic'],
        weakness: ['Electric', 'Grass', 'Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 81,
        pokemonName: 'Magnemite',
        element: ['Electric', 'Steel'],
        weakness: ['Fire', 'Fighting', 'Ground']
    },
    {
        pokedexNum: 82,
        pokemonName: 'Magneton',
        element: ['Electric', 'Steel'],
        weakness: ['Fire', 'Fighting', 'Ground']
    },
    {
        pokedexNum: 83,
        pokemonName: "Farfetch'd",
        element: ['Normal', 'Flying'],
        weakness: ['Electric', 'Ice', 'Rock']
    },
    {
        pokedexNum: 84,
        pokemonName: 'Doduo',
        element: ['Normal', 'Flying'],
        weakness: ['Electric', 'Ice', 'Rock']
    },
    {
        pokedexNum: 85,
        pokemonName: 'Dodrio',
        element: ['Normal', 'Flying'],
        weakness: ['Electric', 'Ice', 'Rock']
    },
    {
        pokedexNum: 86,
        pokemonName: 'Seel',
        element: ['Water'],
        weakness: ['Electric', 'Grass']
    },
    {
        pokedexNum: 87,
        pokemonName: 'Dewgong',
        element: ['Water', 'Ice'],
        weakness: ['Electric', 'Grass', 'Fighting', 'Rock']
    },
    {
        pokedexNum: 88,
        pokemonName: 'Grimer',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 89,
        pokemonName: 'Muk',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 90,
        pokemonName: 'Shellder',
        element: ['Water'],
        weakness: ['Electric', 'Grass']
    },
    {
        pokedexNum: 91,
        pokemonName: 'Cloyster',
        element: ['Water', 'Ice'],
        weakness: ['Electric', 'Grass', 'Fighting', 'Rock']
    },
    {
        pokedexNum: 92,
        pokemonName: 'Gastly',
        element: ['Ghost', 'Poison'],
        weakness: ['Ground', 'Psychic', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 93,
        pokemonName: 'Haunter',
        element: ['Ghost', 'Poison'],
        weakness: ['Ground', 'Psychic', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 94,
        pokemonName: 'Gengar',
        element: ['Ghost', 'Poison'],
        weakness: ['Ground', 'Psychic', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 95,
        pokemonName: 'Onix',
        element: ['Rock', 'Ground'],
        weakness: ['Water', 'Grass', 'Ice', 'Fighting', 'Ground', 'Steel']
    },
    {
        pokedexNum: 96,
        pokemonName: 'Drowzee',
        element: ['Psychic'],
        weakness: ['Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 97,
        pokemonName: 'Hypno',
        element: ['Psychic'],
        weakness: ['Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 98,
        pokemonName: 'Krabby',
        element: ['Water'],
        weakness: ['Electric', 'Grass']
    },
    {
        pokedexNum: 99,
        pokemonName: 'Kingler',
        element: ['Water'],
        weakness: ['Electric', 'Grass']
    },
    {
        pokedexNum: 100,
        pokemonName: 'Voltorb',
        element: ['Electric'],
        weakness: ['Ground']
    },
    {
        pokedexNum: 101,
        pokemonName: 'Electrode',
        element: ['Electric'],
        weakness: ['Ground']
    },
    {
        pokedexNum: 102,
        pokemonName: 'Exeggcute',
        element: ['Grass', 'Psychic'],
        weakness: ['Fire', 'Ice', 'Flying', 'Poison', 'Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 104,
        pokemonName: 'Cubone',
        element: ['Ground'],
        weakness: ['Water', 'Grass', 'Ice']
    },
    {
        pokedexNum: 105,
        pokemonName: 'Marowak',
        element: ['Ground'],
        weakness: ['Water', 'Grass', 'Ice']
    },
    {
        pokedexNum: 106,
        pokemonName: 'Hitmonlee',
        element: ['Fighting'],
        weakness: ['Flying', 'Psychic', 'Fairy']
    },
    {
        pokedexNum: 107,
        pokemonName: 'Hitmonchan',
        element: ['Fighting'],
        weakness: ['Flying', 'Psychic', 'Fairy']
    },
    {
        pokedexNum: 108,
        pokemonName: 'Lickitung',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 109,
        pokemonName: 'Koffing',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 110,
        pokemonName: 'Weezing',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 111,
        pokemonName: 'Rhyhorn',
        element: ['Ground', 'Rock'],
        weakness: ['Water', 'Grass', 'Ice', 'Fighting', 'Ground', 'Steel']
    },
    {
        pokedexNum: 112,
        pokemonName: 'Rhydon',
        element: ['Ground', 'Rock'],
        weakness: ['Water', 'Grass', 'Ice', 'Fighting', 'Ground', 'Steel']
    },
    {
        pokedexNum: 113,
        pokemonName: 'Chansey',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 114,
        pokemonName: 'Tangela',
        element: ['Grass'],
        weakness: ['Fire', 'Ice', 'Poison', 'Flying', 'Bug']
    },
    {
        pokedexNum: 115,
        pokemonName: 'Kangaskhan',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 116,
        pokemonName: 'Horsea',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 117,
        pokemonName: 'Seadra',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 118,
        pokemonName: 'Goldeen',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 119,
        pokemonName: 'Seaking',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 120,
        pokemonName: 'Staryu',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 121,
        pokemonName: 'Starmie',
        element: ['Water', 'Psychic'],
        weakness: ['Grass', 'Electric', 'Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 103,
        pokemonName: 'Exeggutor',
        element: ['Grass', 'Psychic'],
        weakness: ['Flying', 'Ice', 'Dragon', 'Poison', 'Fairy', 'Bug']
    },
    {
        pokedexNum: 104,
        pokemonName: 'Cubone',
        element: ['Ground'],
        weakness: ['Water', 'Grass', 'Ice']
    },
    {
        pokedexNum: 105,
        pokemonName: 'Marowak',
        element: ['Ground'],
        weakness: ['Water', 'Grass', 'Ice']
    },
    {
        pokedexNum: 106,
        pokemonName: 'Hitmonlee',
        element: ['Fighting'],
        weakness: ['Flying', 'Psychic', 'Fairy']
    },
    {
        pokedexNum: 107,
        pokemonName: 'Hitmonchan',
        element: ['Fighting'],
        weakness: ['Flying', 'Psychic', 'Fairy']
    },
    {
        pokedexNum: 108,
        pokemonName: 'Lickitung',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 109,
        pokemonName: 'Koffing',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 110,
        pokemonName: 'Weezing',
        element: ['Poison'],
        weakness: ['Ground', 'Psychic']
    },
    {
        pokedexNum: 111,
        pokemonName: 'Rhyhorn',
        element: ['Ground', 'Rock'],
        weakness: ['Water', 'Grass', 'Ice', 'Fighting', 'Ground', 'Steel']
    },
    {
        pokedexNum: 112,
        pokemonName: 'Rhydon',
        element: ['Ground', 'Rock'],
        weakness: ['Water', 'Grass', 'Ice', 'Fighting', 'Ground', 'Steel']
    },
    {
        pokedexNum: 113,
        pokemonName: 'Chansey',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 114,
        pokemonName: 'Tangela',
        element: ['Grass'],
        weakness: ['Fire', 'Ice', 'Poison', 'Flying', 'Bug']
    },
    {
        pokedexNum: 115,
        pokemonName: 'Kangaskhan',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 116,
        pokemonName: 'Horsea',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 117,
        pokemonName: 'Seadra',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 118,
        pokemonName: 'Goldeen',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 119,
        pokemonName: 'Seaking',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 120,
        pokemonName: 'Staryu',
        element: ['Water'],
        weakness: ['Grass', 'Electric']
    },
    {
        pokedexNum: 121,
        pokemonName: 'Starmie',
        element: ['Water', 'Psychic'],
        weakness: ['Grass', 'Electric', 'Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 122,
        pokemonName: 'Mr. Mime',
        element: ['Psychic', 'Fairy'],
        weakness: ['Steel', 'Poison']
    },
    {
        pokedexNum: 123,
        pokemonName: 'Scyther',
        element: ['Bug', 'Flying'],
        weakness: ['Fire', 'Electric', 'Ice', 'Flying', 'Rock']
    },
    {
        pokedexNum: 124,
        pokemonName: 'Jynx',
        element: ['Ice', 'Psychic'],
        weakness: ['Fire', 'Bug', 'Rock', 'Ghost', 'Dark', 'Steel']
    },
    {
        pokedexNum: 125,
        pokemonName: 'Electabuzz',
        element: ['Electric'],
        weakness: ['Ground']
    },
    {
        pokedexNum: 126,
        pokemonName: 'Magmar',
        element: ['Fire'],
        weakness: ['Water', 'Ground', 'Rock']
    },
    {
        pokedexNum: 127,
        pokemonName: 'Pinsir',
        element: ['Bug'],
        weakness: ['Fire', 'Flying', 'Rock']
    },
    {
        pokedexNum: 128,
        pokemonName: 'Tauros',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 129,
        pokemonName: 'Magikarp',
        element: ['Water'],
        weakness: ['Electric', 'Grass']
    },
    {
        pokedexNum: 130,
        pokemonName: 'Gyarados',
        element: ['Water', 'Flying'],
        weakness: ['Electric', 'Rock']
    },
    {
        pokedexNum: 131,
        pokemonName: 'Lapras',
        element: ['Water', 'Ice'],
        weakness: ['Electric', 'Grass', 'Fighting', 'Rock']
    },
    {
        pokedexNum: 132,
        pokemonName: 'Ditto',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 133,
        pokemonName: 'Eevee',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 134,
        pokemonName: 'Vaporeon',
        element: ['Water'],
        weakness: ['Electric', 'Grass']
    },
    {
        pokedexNum: 135,
        pokemonName: 'Jolteon',
        element: ['Electric'],
        weakness: ['Ground']
    },
    {
        pokedexNum: 136,
        pokemonName: 'Flareon',
        element: ['Fire'],
        weakness: ['Water', 'Ground', 'Rock']
    },
    {
        pokedexNum: 137,
        pokemonName: 'Porygon',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 138,
        pokemonName: 'Omanyte',
        element: ['Rock', 'Water'],
        weakness: ['Grass', 'Electric', 'Fighting', 'Ground']
    },
    {
        pokedexNum: 139,
        pokemonName: 'Omastar',
        element: ['Rock', 'Water'],
        weakness: ['Grass', 'Electric', 'Fighting', 'Ground']
    },
    {
        pokedexNum: 140,
        pokemonName: 'Kabuto',
        element: ['Rock', 'Water'],
        weakness: ['Grass', 'Electric', 'Fighting', 'Ground']
    },
    {
        pokedexNum: 141,
        pokemonName: 'Kabutops',
        element: ['Rock', 'Water'],
        weakness: ['Grass', 'Electric', 'Fighting', 'Ground']
    },
    {
        pokedexNum: 142,
        pokemonName: 'Aerodactyl',
        element: ['Rock', 'Flying'],
        weakness: ['Water', 'Electric', 'Ice', 'Rock', 'Steel']
    },
    {
        pokedexNum: 143,
        pokemonName: 'Snorlax',
        element: ['Normal'],
        weakness: ['Fighting']
    },
    {
        pokedexNum: 144,
        pokemonName: 'Articuno',
        element: ['Ice', 'Flying'],
        weakness: ['Fire', 'Electric', 'Rock', 'Steel']
    },
    {
        pokedexNum: 145,
        pokemonName: 'Zapdos',
        element: ['Electric', 'Flying'],
        weakness: ['Ice', 'Rock']
    },
    {
        pokedexNum: 146,
        pokemonName: 'Moltres',
        element: ['Fire', 'Flying'],
        weakness: ['Water', 'Electric', 'Rock']
    },
    {
        pokedexNum: 147,
        pokemonName: 'Dratini',
        element: ['Dragon'],
        weakness: ['Ice', 'Dragon', 'Fairy']
    },
    {
        pokedexNum: 148,
        pokemonName: 'Dragonair',
        element: ['Dragon'],
        weakness: ['Ice', 'Dragon', 'Fairy']
    },
    {
        pokedexNum: 149,
        pokemonName: 'Dragonite',
        element: ['Dragon', 'Flying'],
        weakness: ['Ice', 'Rock', 'Dragon', 'Fairy']
    },
    {
        pokedexNum: 150,
        pokemonName: 'Mewtwo',
        element: ['Psychic'],
        weakness: ['Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 151,
        pokemonName: 'Mew',
        element: ['Psychic'],
        weakness: ['Bug', 'Ghost', 'Dark']
    },
    {
        pokedexNum: 152,
        pokemonName: 'Missingno',
        element: [],
        weakness: [],
    }
]

let playerBoxPokemon = [
    {
        pokemonId: 1,
        pokedexNum: 52,
        name: 'Goofer',
        exp: 1,
        stats: {},
        // hp: 50,
        // level: 1,
        // attack: 1,
        // physicalDefense: 5,
        // elementalDefense: 5,
    },
    {
        pokemonId: 2,
        pokedexNum: 52,
        name: 'Goofer',
        exp: 1,
        stats: {},
        // hp: 50,
        // level: 1,
        // attack: 1,
        // physicalDefense: 5,
        // elementalDefense: 5,
    }
];

let playerPartyPokemon = [
    {
        partyId: 1,
        playerPokemonId: 1
    },
    {
        partyId: 2,
        playerPokemonId: undefined
    },
    {
        partyId: 3,
        playerPokemonId: undefined
    },
    {
        partyId: 4,
        playerPokemonId: undefined
    },
    {
        partyId: 5,
        playerPokemonId: undefined
    },
    {
        partyId: 6,
        playerPokemonId: undefined
    },
];

calculateStats(2);

function calculateStats(pokemonId) {
    let pokemon = playerBoxPokemon.filter(box => box.pokemonId == pokemonId);
    let stats;
    let level = Math.floor(1 + pokemon.exp / 100);
    console.log(pokemon[0]);
}
