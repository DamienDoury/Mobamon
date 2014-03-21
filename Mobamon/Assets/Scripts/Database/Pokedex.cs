using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mobamon.Database.Classes;
using Mobamon.Database.Enums;

namespace Mobamon.Database
{
	public static class Pokedex
	{
        public static Dictionary<int, PokemonInfo> pokemons = new Dictionary<int, PokemonInfo>()
        {
            {
                1,
                new PokemonInfo()
                {
                    ResourceName = "001 - Bulbasaur",
                    NameKey = "Pokemons_Bulbasaur"
                }
            },
            {
                2,
                new PokemonInfo()
                {
                    ResourceName = "002 - Ivysaur",
                    NameKey = "Pokemons_Ivysaur"
                }
            },
            {
                3,
                new PokemonInfo()
                {
                    ResourceName = "003 - Venusaur",
                    NameKey = "Pokemons_Venusaur"
                }
            },
            {
                4,
                new PokemonInfo()
                {
                    ResourceName = "004 - Charmander",
                    NameKey = "Pokemons_Charmander"
                }
            },
            {
                5,
                new PokemonInfo()
                {
                    ResourceName = "005 - Charmeleon",
                    NameKey = "Pokemons_Charmeleon"
                }
            },
            {
                6,
                new PokemonInfo()
                {
                    ResourceName = "006 - Charizard",
                    NameKey = "Pokemons_Charizard"
                }
            },
            {
                7,
                new PokemonInfo()
                {
                    ResourceName = "007 - Squirtle",
                    NameKey = "Pokemons_Squirtle"
                }
            },
            {
                8,
                new PokemonInfo()
                {
                    ResourceName = "008 - Wartortle",
                    NameKey = "Pokemons_Wartortle"
                }
            },
            {
                9,
                new PokemonInfo()
                {
                    ResourceName = "009 - Blastoise",
                    NameKey = "Pokemons_Blastoise"
                }
            },
            {
                10,
                new PokemonInfo()
                {
                    ResourceName = "010 - Caterpie",
                    NameKey = "Pokemons_Caterpie"
                }
            },
            {
                11,
                new PokemonInfo()
                {
                    ResourceName = "011 - Metapod",
                    NameKey = "Pokemons_Metapod"
                }
            },
            {
                12,
                new PokemonInfo()
                {
                    ResourceName = "012 - Butterfree",
                    NameKey = "Pokemons_Butterfree"
                }
            },
            {
                13,
                new PokemonInfo()
                {
                    ResourceName = "013 - Weedle",
                    NameKey = "Pokemons_Weedle"
                }
            },
            {
                14,
                new PokemonInfo()
                {
                    ResourceName = "014 - Kakuna",
                    NameKey = "Pokemons_Kakuna"
                }
            },
            {
                15,
                new PokemonInfo()
                {
                    ResourceName = "015 - Beedrill",
                    NameKey = "Pokemons_Beedrill"
                }
            },
            {
                16,
                new PokemonInfo()
                {
                    ResourceName = "016 - Pidgey",
                    NameKey = "Pokemons_Pidgey"
                }
            },
            {
                17,
                new PokemonInfo()
                {
                    ResourceName = "017 - Pidgeotto",
                    NameKey = "Pokemons_Pidgeotto"
                }
            },
            {
                18,
                new PokemonInfo()
                {
                    ResourceName = "018 - Pidgeot",
                    NameKey = "Pokemons_Pidgeot"
                }
            },
            {
                19,
                new PokemonInfo()
                {
                    ResourceName = "019 - Rattata",
                    NameKey = "Pokemons_Rattata"
                }
            },
            {
                20,
                new PokemonInfo()
                {
                    ResourceName = "020 - Raticate",
                    NameKey = "Pokemons_Raticate"
                }
            },
            {
                21,
                new PokemonInfo()
                {
                    ResourceName = "021 - Spearow",
                    NameKey = "Pokemons_Spearow"
                }
            },
            {
                22,
                new PokemonInfo()
                {
                    ResourceName = "022 - Fearow",
                    NameKey = "Pokemons_Fearow"
                }
            },
            {
                23,
                new PokemonInfo()
                {
                    ResourceName = "023 - Ekans",
                    NameKey = "Pokemons_Ekans"
                }
            },
            {
                24,
                new PokemonInfo()
                {
                    ResourceName = "024 - Arbok",
                    NameKey = "Pokemons_Arbok"
                }
            },
            {
                25,
                new PokemonInfo()
                {
                    ResourceName = "025 - Pikachu",
                    NameKey = "Pokemons_Pikachu"
                }
            },
            {
                26,
                new PokemonInfo()
                {
                    ResourceName = "026 - Raichu",
                    NameKey = "Pokemons_Raichu"
                }
            },
            {
                27,
                new PokemonInfo()
                {
                    ResourceName = "027 - Sandshrew",
                    NameKey = "Pokemons_Sandshrew"
                }
            },
            {
                28,
                new PokemonInfo()
                {
                    ResourceName = "028 - Sandslash",
                    NameKey = "Pokemons_Sandslash"
                }
            },
            {
                29,
                new PokemonInfo()
                {
                    ResourceName = "029 - Nidoran♀",
                    NameKey = "Pokemons_Nidoran♀"
                }
            },
            {
                30,
                new PokemonInfo()
                {
                    ResourceName = "030 - Nidorina",
                    NameKey = "Pokemons_Nidorina"
                }
            },
            {
                31,
                new PokemonInfo()
                {
                    ResourceName = "031 - Nidoqueen",
                    NameKey = "Pokemons_Nidoqueen"
                }
            },
            {
                32,
                new PokemonInfo()
                {
                    ResourceName = "032 - Nidoran♂",
                    NameKey = "Pokemons_Nidoran♂"
                }
            },
            {
                33,
                new PokemonInfo()
                {
                    ResourceName = "033 - Nidorino",
                    NameKey = "Pokemons_Nidorino"
                }
            },
            {
                34,
                new PokemonInfo()
                {
                    ResourceName = "034 - Nidoking",
                    NameKey = "Pokemons_Nidoking"
                }
            },
            {
                35,
                new PokemonInfo()
                {
                    ResourceName = "035 - Clefairy",
                    NameKey = "Pokemons_Clefairy"
                }
            },
            {
                36,
                new PokemonInfo()
                {
                    ResourceName = "036 - Clefable",
                    NameKey = "Pokemons_Clefable"
                }
            },
            {
                37,
                new PokemonInfo()
                {
                    ResourceName = "037 - Vulpix",
                    NameKey = "Pokemons_Vulpix"
                }
            },
            {
                38,
                new PokemonInfo()
                {
                    ResourceName = "038 - Ninetales",
                    NameKey = "Pokemons_Ninetales"
                }
            },
            {
                39,
                new PokemonInfo()
                {
                    ResourceName = "039 - Jigglypuff",
                    NameKey = "Pokemons_Jigglypuff"
                }
            },
            {
                40,
                new PokemonInfo()
                {
                    ResourceName = "040 - Wigglytuff",
                    NameKey = "Pokemons_Wigglytuff"
                }
            },
            {
                41,
                new PokemonInfo()
                {
                    ResourceName = "041 - Zubat",
                    NameKey = "Pokemons_Zubat"
                }
            },
            {
                42,
                new PokemonInfo()
                {
                    ResourceName = "042 - Golbat",
                    NameKey = "Pokemons_Golbat"
                }
            },
            {
                43,
                new PokemonInfo()
                {
                    ResourceName = "043 - Oddish",
                    NameKey = "Pokemons_Oddish"
                }
            },
            {
                44,
                new PokemonInfo()
                {
                    ResourceName = "044 - Gloom",
                    NameKey = "Pokemons_Gloom"
                }
            },
            {
                45,
                new PokemonInfo()
                {
                    ResourceName = "045 - Vileplume",
                    NameKey = "Pokemons_Vileplume"
                }
            },
            {
                46,
                new PokemonInfo()
                {
                    ResourceName = "046 - Paras",
                    NameKey = "Pokemons_Paras"
                }
            },
            {
                47,
                new PokemonInfo()
                {
                    ResourceName = "047 - Parasect",
                    NameKey = "Pokemons_Parasect"
                }
            },
            {
                48,
                new PokemonInfo()
                {
                    ResourceName = "048 - Venonat",
                    NameKey = "Pokemons_Venonat"
                }
            },
            {
                49,
                new PokemonInfo()
                {
                    ResourceName = "049 - Venomoth",
                    NameKey = "Pokemons_Venomoth"
                }
            },
            {
                50,
                new PokemonInfo()
                {
                    ResourceName = "050 - Diglett",
                    NameKey = "Pokemons_Diglett"
                }
            },
            {
                51,
                new PokemonInfo()
                {
                    ResourceName = "051 - Dugtrio",
                    NameKey = "Pokemons_Dugtrio"
                }
            },
            {
                52,
                new PokemonInfo()
                {
                    ResourceName = "052 - Meowth",
                    NameKey = "Pokemons_Meowth"
                }
            },
            {
                53,
                new PokemonInfo()
                {
                    ResourceName = "053 - Persian",
                    NameKey = "Pokemons_Persian"
                }
            },
            {
                54,
                new PokemonInfo()
                {
                    ResourceName = "054 - Psyduck",
                    NameKey = "Pokemons_Psyduck"
                }
            },
            {
                55,
                new PokemonInfo()
                {
                    ResourceName = "055 - Golduck",
                    NameKey = "Pokemons_Golduck"
                }
            },
            {
                56,
                new PokemonInfo()
                {
                    ResourceName = "056 - Mankey",
                    NameKey = "Pokemons_Mankey"
                }
            },
            {
                57,
                new PokemonInfo()
                {
                    ResourceName = "057 - Primeape",
                    NameKey = "Pokemons_Primeape"
                }
            },
            {
                58,
                new PokemonInfo()
                {
                    ResourceName = "058 - Growlithe",
                    NameKey = "Pokemons_Growlithe"
                }
            },
            {
                59,
                new PokemonInfo()
                {
                    ResourceName = "059 - Arcanine",
                    NameKey = "Pokemons_Arcanine"
                }
            },
            {
                60,
                new PokemonInfo()
                {
                    ResourceName = "060 - Poliwag",
                    NameKey = "Pokemons_Poliwag"
                }
            },
            {
                61,
                new PokemonInfo()
                {
                    ResourceName = "061 - Poliwhirl",
                    NameKey = "Pokemons_Poliwhirl"
                }
            },
            {
                62,
                new PokemonInfo()
                {
                    ResourceName = "062 - Poliwrath",
                    NameKey = "Pokemons_Poliwrath"
                }
            },
            {
                63,
                new PokemonInfo()
                {
                    ResourceName = "063 - Abra",
                    NameKey = "Pokemons_Abra"
                }
            },
            {
                64,
                new PokemonInfo()
                {
                    ResourceName = "064 - Kadabra",
                    NameKey = "Pokemons_Kadabra"
                }
            },
            {
                65,
                new PokemonInfo()
                {
                    ResourceName = "065 - Alakazam",
                    NameKey = "Pokemons_Alakazam"
                }
            },
            {
                66,
                new PokemonInfo()
                {
                    ResourceName = "066 - Machop",
                    NameKey = "Pokemons_Machop"
                }
            },
            {
                67,
                new PokemonInfo()
                {
                    ResourceName = "067 - Machoke",
                    NameKey = "Pokemons_Machoke"
                }
            },
            {
                68,
                new PokemonInfo()
                {
                    ResourceName = "068 - Machamp",
                    NameKey = "Pokemons_Machamp"
                }
            },
            {
                69,
                new PokemonInfo()
                {
                    ResourceName = "069 - Bellsprout",
                    NameKey = "Pokemons_Bellsprout"
                }
            },
            {
                70,
                new PokemonInfo()
                {
                    ResourceName = "070 - Weepinbell",
                    NameKey = "Pokemons_Weepinbell"
                }
            },
            {
                71,
                new PokemonInfo()
                {
                    ResourceName = "071 - Victreebel",
                    NameKey = "Pokemons_Victreebel"
                }
            },
            {
                72,
                new PokemonInfo()
                {
                    ResourceName = "072 - Tentacool",
                    NameKey = "Pokemons_Tentacool"
                }
            },
            {
                73,
                new PokemonInfo()
                {
                    ResourceName = "073 - Tentacruel",
                    NameKey = "Pokemons_Tentacruel"
                }
            },
            {
                74,
                new PokemonInfo()
                {
                    ResourceName = "074 - Geodude",
                    NameKey = "Pokemons_Geodude"
                }
            },
            {
                75,
                new PokemonInfo()
                {
                    ResourceName = "075 - Graveler",
                    NameKey = "Pokemons_Graveler"
                }
            },
            {
                76,
                new PokemonInfo()
                {
                    ResourceName = "076 - Golem",
                    NameKey = "Pokemons_Golem"
                }
            },
            {
                77,
                new PokemonInfo()
                {
                    ResourceName = "077 - Ponyta",
                    NameKey = "Pokemons_Ponyta"
                }
            },
            {
                78,
                new PokemonInfo()
                {
                    ResourceName = "078 - Rapidash",
                    NameKey = "Pokemons_Rapidash"
                }
            },
            {
                79,
                new PokemonInfo()
                {
                    ResourceName = "079 - Slowpoke",
                    NameKey = "Pokemons_Slowpoke"
                }
            },
            {
                80,
                new PokemonInfo()
                {
                    ResourceName = "080 - Slowbro",
                    NameKey = "Pokemons_Slowbro"
                }
            },
            {
                81,
                new PokemonInfo()
                {
                    ResourceName = "081 - Magnemite",
                    NameKey = "Pokemons_Magnemite"
                }
            },
            {
                82,
                new PokemonInfo()
                {
                    ResourceName = "082 - Magneton",
                    NameKey = "Pokemons_Magneton"
                }
            },
            {
                83,
                new PokemonInfo()
                {
                    ResourceName = "083 - Farfetch'd",
                    NameKey = "Pokemons_Farfetch'd"
                }
            },
            {
                84,
                new PokemonInfo()
                {
                    ResourceName = "084 - Doduo",
                    NameKey = "Pokemons_Doduo"
                }
            },
            {
                85,
                new PokemonInfo()
                {
                    ResourceName = "085 - Dodrio",
                    NameKey = "Pokemons_Dodrio"
                }
            },
            {
                86,
                new PokemonInfo()
                {
                    ResourceName = "086 - Seel",
                    NameKey = "Pokemons_Seel"
                }
            },
            {
                87,
                new PokemonInfo()
                {
                    ResourceName = "087 - Dewgong",
                    NameKey = "Pokemons_Dewgong"
                }
            },
            {
                88,
                new PokemonInfo()
                {
                    ResourceName = "088 - Grimer",
                    NameKey = "Pokemons_Grimer"
                }
            },
            {
                89,
                new PokemonInfo()
                {
                    ResourceName = "089 - Muk",
                    NameKey = "Pokemons_Muk"
                }
            },
            {
                90,
                new PokemonInfo()
                {
                    ResourceName = "090 - Shellder",
                    NameKey = "Pokemons_Shellder"
                }
            },
            {
                91,
                new PokemonInfo()
                {
                    ResourceName = "091 - Cloyster",
                    NameKey = "Pokemons_Cloyster"
                }
            },
            {
                92,
                new PokemonInfo()
                {
                    ResourceName = "092 - Gastly",
                    NameKey = "Pokemons_Gastly"
                }
            },
            {
                93,
                new PokemonInfo()
                {
                    ResourceName = "093 - Haunter",
                    NameKey = "Pokemons_Haunter"
                }
            },
            {
                94,
                new PokemonInfo()
                {
                    ResourceName = "094 - Gengar",
                    NameKey = "Pokemons_Gengar"
                }
            },
            {
                95,
                new PokemonInfo()
                {
                    ResourceName = "095 - Onix",
                    NameKey = "Pokemons_Onix"
                }
            },
            {
                96,
                new PokemonInfo()
                {
                    ResourceName = "096 - Drowzee",
                    NameKey = "Pokemons_Drowzee"
                }
            },
            {
                97,
                new PokemonInfo()
                {
                    ResourceName = "097 - Hypno",
                    NameKey = "Pokemons_Hypno"
                }
            },
            {
                98,
                new PokemonInfo()
                {
                    ResourceName = "098 - Krabby",
                    NameKey = "Pokemons_Krabby"
                }
            },
            {
                99,
                new PokemonInfo()
                {
                    ResourceName = "099 - Kingler",
                    NameKey = "Pokemons_Kingler"
                }
            },
            {
                100,
                new PokemonInfo()
                {
                    ResourceName = "100 - Voltorb",
                    NameKey = "Pokemons_Voltorb"
                }
            },
            {
                101,
                new PokemonInfo()
                {
                    ResourceName = "101 - Electrode",
                    NameKey = "Pokemons_Electrode"
                }
            },
            {
                102,
                new PokemonInfo()
                {
                    ResourceName = "102 - Exeggcute",
                    NameKey = "Pokemons_Exeggcute"
                }
            },
            {
                103,
                new PokemonInfo()
                {
                    ResourceName = "103 - Exeggutor",
                    NameKey = "Pokemons_Exeggutor"
                }
            },
            {
                104,
                new PokemonInfo()
                {
                    ResourceName = "104 - Cubone",
                    NameKey = "Pokemons_Cubone"
                }
            },
            {
                105,
                new PokemonInfo()
                {
                    ResourceName = "105 - Marowak",
                    NameKey = "Pokemons_Marowak"
                }
            },
            {
                106,
                new PokemonInfo()
                {
                    ResourceName = "106 - Hitmonlee",
                    NameKey = "Pokemons_Hitmonlee"
                }
            },
            {
                107,
                new PokemonInfo()
                {
                    ResourceName = "107 - Hitmonchan",
                    NameKey = "Pokemons_Hitmonchan"
                }
            },
            {
                108,
                new PokemonInfo()
                {
                    ResourceName = "108 - Lickitung",
                    NameKey = "Pokemons_Lickitung"
                }
            },
            {
                109,
                new PokemonInfo()
                {
                    ResourceName = "109 - Koffing",
                    NameKey = "Pokemons_Koffing"
                }
            },
            {
                110,
                new PokemonInfo()
                {
                    ResourceName = "110 - Weezing",
                    NameKey = "Pokemons_Weezing"
                }
            },
            {
                111,
                new PokemonInfo()
                {
                    ResourceName = "111 - Rhyhorn",
                    NameKey = "Pokemons_Rhyhorn"
                }
            },
            {
                112,
                new PokemonInfo()
                {
                    ResourceName = "112 - Rhydon",
                    NameKey = "Pokemons_Rhydon"
                }
            },
            {
                113,
                new PokemonInfo()
                {
                    ResourceName = "113 - Chansey",
                    NameKey = "Pokemons_Chansey"
                }
            },
            {
                114,
                new PokemonInfo()
                {
                    ResourceName = "114 - Tangela",
                    NameKey = "Pokemons_Tangela"
                }
            },
            {
                115,
                new PokemonInfo()
                {
                    ResourceName = "115 - Kangaskhan",
                    NameKey = "Pokemons_Kangaskhan"
                }
            },
            {
                116,
                new PokemonInfo()
                {
                    ResourceName = "116 - Horsea",
                    NameKey = "Pokemons_Horsea"
                }
            },
            {
                117,
                new PokemonInfo()
                {
                    ResourceName = "117 - Seadra",
                    NameKey = "Pokemons_Seadra"
                }
            },
            {
                118,
                new PokemonInfo()
                {
                    ResourceName = "118 - Goldeen",
                    NameKey = "Pokemons_Goldeen"
                }
            },
            {
                119,
                new PokemonInfo()
                {
                    ResourceName = "119 - Seaking",
                    NameKey = "Pokemons_Seaking"
                }
            },
            {
                120,
                new PokemonInfo()
                {
                    ResourceName = "120 - Staryu",
                    NameKey = "Pokemons_Staryu"
                }
            },
            {
                121,
                new PokemonInfo()
                {
                    ResourceName = "121 - Starmie",
                    NameKey = "Pokemons_Starmie"
                }
            },
            {
                122,
                new PokemonInfo()
                {
                    ResourceName = "122 - Mr. Mime",
                    NameKey = "Pokemons_Mr. Mime"
                }
            },
            {
                123,
                new PokemonInfo()
                {
                    ResourceName = "123 - Scyther",
                    NameKey = "Pokemons_Scyther"
                }
            },
            {
                124,
                new PokemonInfo()
                {
                    ResourceName = "124 - Jynx",
                    NameKey = "Pokemons_Jynx"
                }
            },
            {
                125,
                new PokemonInfo()
                {
                    ResourceName = "125 - Electabuzz",
                    NameKey = "Pokemons_Electabuzz"
                }
            },
            {
                126,
                new PokemonInfo()
                {
                    ResourceName = "126 - Magmar",
                    NameKey = "Pokemons_Magmar"
                }
            },
            {
                127,
                new PokemonInfo()
                {
                    ResourceName = "127 - Pinsir",
                    NameKey = "Pokemons_Pinsir"
                }
            },
            {
                128,
                new PokemonInfo()
                {
                    ResourceName = "128 - Tauros",
                    NameKey = "Pokemons_Tauros"
                }
            },
            {
                129,
                new PokemonInfo()
                {
                    ResourceName = "129 - Magikarp",
                    NameKey = "Pokemons_Magikarp"
                }
            },
            {
                130,
                new PokemonInfo()
                {
                    ResourceName = "130 - Gyarados",
                    NameKey = "Pokemons_Gyarados"
                }
            },
            {
                131,
                new PokemonInfo()
                {
                    ResourceName = "131 - Lapras",
                    NameKey = "Pokemons_Lapras"
                }
            },
            {
                132,
                new PokemonInfo()
                {
                    ResourceName = "132 - Ditto",
                    NameKey = "Pokemons_Ditto"
                }
            },
            {
                133,
                new PokemonInfo()
                {
                    ResourceName = "133 - Eevee",
                    NameKey = "Pokemons_Eevee"
                }
            },
            {
                134,
                new PokemonInfo()
                {
                    ResourceName = "134 - Vaporeon",
                    NameKey = "Pokemons_Vaporeon"
                }
            },
            {
                135,
                new PokemonInfo()
                {
                    ResourceName = "135 - Jolteon",
                    NameKey = "Pokemons_Jolteon"
                }
            },
            {
                136,
                new PokemonInfo()
                {
                    ResourceName = "136 - Flareon",
                    NameKey = "Pokemons_Flareon"
                }
            },
            {
                137,
                new PokemonInfo()
                {
                    ResourceName = "137 - Porygon",
                    NameKey = "Pokemons_Porygon"
                }
            },
            {
                138,
                new PokemonInfo()
                {
                    ResourceName = "138 - Omanyte",
                    NameKey = "Pokemons_Omanyte"
                }
            },
            {
                139,
                new PokemonInfo()
                {
                    ResourceName = "139 - Omastar",
                    NameKey = "Pokemons_Omastar"
                }
            },
            {
                140,
                new PokemonInfo()
                {
                    ResourceName = "140 - Kabuto",
                    NameKey = "Pokemons_Kabuto"
                }
            },
            {
                141,
                new PokemonInfo()
                {
                    ResourceName = "141 - Kabutops",
                    NameKey = "Pokemons_Kabutops"
                }
            },
            {
                142,
                new PokemonInfo()
                {
                    ResourceName = "142 - Aerodactyl",
                    NameKey = "Pokemons_Aerodactyl"
                }
            },
            {
                143,
                new PokemonInfo()
                {
                    ResourceName = "143 - Snorlax",
                    NameKey = "Pokemons_Snorlax"
                }
            },
            {
                144,
                new PokemonInfo()
                {
                    ResourceName = "144 - Articuno",
                    NameKey = "Pokemons_Articuno"
                }
            },
            {
                145,
                new PokemonInfo()
                {
                    ResourceName = "145 - Zapdos",
                    NameKey = "Pokemons_Zapdos"
                }
            },
            {
                146,
                new PokemonInfo()
                {
                    ResourceName = "146 - Moltres",
                    NameKey = "Pokemons_Moltres"
                }
            },
            {
                147,
                new PokemonInfo()
                {
                    ResourceName = "147 - Dratini",
                    NameKey = "Pokemons_Dratini"
                }
            },
            {
                148,
                new PokemonInfo()
                {
                    ResourceName = "148 - Dragonair",
                    NameKey = "Pokemons_Dragonair"
                }
            },
            {
                149,
                new PokemonInfo()
                {
                    ResourceName = "149 - Dragonite",
                    NameKey = "Pokemons_Dragonite"
                }
            },
            {
                150,
                new PokemonInfo()
                {
                    ResourceName = "150 - Mewtwo",
                    NameKey = "Pokemons_Mewtwo"
                }
            },
            {
                151,
                new PokemonInfo()
                {
                    ResourceName = "151 - Mew",
                    NameKey = "Pokemons_Mew"
                }
            },
            {
                152,
                new PokemonInfo()
                {
                    ResourceName = "152 - Chikorita",
                    NameKey = "Pokemons_Chikorita"
                }
            },
            {
                153,
                new PokemonInfo()
                {
                    ResourceName = "153 - Bayleef",
                    NameKey = "Pokemons_Bayleef"
                }
            },
            {
                154,
                new PokemonInfo()
                {
                    ResourceName = "154 - Meganium",
                    NameKey = "Pokemons_Meganium"
                }
            },
            {
                155,
                new PokemonInfo()
                {
                    ResourceName = "155 - Cyndaquil",
                    NameKey = "Pokemons_Cyndaquil"
                }
            },
            {
                156,
                new PokemonInfo()
                {
                    ResourceName = "156 - Quilava",
                    NameKey = "Pokemons_Quilava"
                }
            },
            {
                157,
                new PokemonInfo()
                {
                    ResourceName = "157 - Typhlosion",
                    NameKey = "Pokemons_Typhlosion"
                }
            },
            {
                158,
                new PokemonInfo()
                {
                    ResourceName = "158 - Totodile",
                    NameKey = "Pokemons_Totodile"
                }
            },
            {
                159,
                new PokemonInfo()
                {
                    ResourceName = "159 - Croconaw",
                    NameKey = "Pokemons_Croconaw"
                }
            },
            {
                160,
                new PokemonInfo()
                {
                    ResourceName = "160 - Feraligatr",
                    NameKey = "Pokemons_Feraligatr"
                }
            },
            {
                161,
                new PokemonInfo()
                {
                    ResourceName = "161 - Sentret",
                    NameKey = "Pokemons_Sentret"
                }
            },
            {
                162,
                new PokemonInfo()
                {
                    ResourceName = "162 - Furret",
                    NameKey = "Pokemons_Furret"
                }
            },
            {
                163,
                new PokemonInfo()
                {
                    ResourceName = "163 - Hoothoot",
                    NameKey = "Pokemons_Hoothoot"
                }
            },
            {
                164,
                new PokemonInfo()
                {
                    ResourceName = "164 - Noctowl",
                    NameKey = "Pokemons_Noctowl"
                }
            },
            {
                165,
                new PokemonInfo()
                {
                    ResourceName = "165 - Ledyba",
                    NameKey = "Pokemons_Ledyba"
                }
            },
            {
                166,
                new PokemonInfo()
                {
                    ResourceName = "166 - Ledian",
                    NameKey = "Pokemons_Ledian"
                }
            },
            {
                167,
                new PokemonInfo()
                {
                    ResourceName = "167 - Spinarak",
                    NameKey = "Pokemons_Spinarak"
                }
            },
            {
                168,
                new PokemonInfo()
                {
                    ResourceName = "168 - Ariados",
                    NameKey = "Pokemons_Ariados"
                }
            },
            {
                169,
                new PokemonInfo()
                {
                    ResourceName = "169 - Crobat",
                    NameKey = "Pokemons_Crobat"
                }
            },
            {
                170,
                new PokemonInfo()
                {
                    ResourceName = "170 - Chinchou",
                    NameKey = "Pokemons_Chinchou"
                }
            },
            {
                171,
                new PokemonInfo()
                {
                    ResourceName = "171 - Lanturn",
                    NameKey = "Pokemons_Lanturn"
                }
            },
            {
                172,
                new PokemonInfo()
                {
                    ResourceName = "172 - Pichu",
                    NameKey = "Pokemons_Pichu"
                }
            },
            {
                173,
                new PokemonInfo()
                {
                    ResourceName = "173 - Cleffa",
                    NameKey = "Pokemons_Cleffa"
                }
            },
            {
                174,
                new PokemonInfo()
                {
                    ResourceName = "174 - Igglybuff",
                    NameKey = "Pokemons_Igglybuff"
                }
            },
            {
                175,
                new PokemonInfo()
                {
                    ResourceName = "175 - Togepi",
                    NameKey = "Pokemons_Togepi"
                }
            },
            {
                176,
                new PokemonInfo()
                {
                    ResourceName = "176 - Togetic",
                    NameKey = "Pokemons_Togetic"
                }
            },
            {
                177,
                new PokemonInfo()
                {
                    ResourceName = "177 - Natu",
                    NameKey = "Pokemons_Natu"
                }
            },
            {
                178,
                new PokemonInfo()
                {
                    ResourceName = "178 - Xatu",
                    NameKey = "Pokemons_Xatu"
                }
            },
            {
                179,
                new PokemonInfo()
                {
                    ResourceName = "179 - Mareep",
                    NameKey = "Pokemons_Mareep"
                }
            },
            {
                180,
                new PokemonInfo()
                {
                    ResourceName = "180 - Flaaffy",
                    NameKey = "Pokemons_Flaaffy"
                }
            },
            {
                181,
                new PokemonInfo()
                {
                    ResourceName = "181 - Ampharos",
                    NameKey = "Pokemons_Ampharos"
                }
            },
            {
                182,
                new PokemonInfo()
                {
                    ResourceName = "182 - Bellossom",
                    NameKey = "Pokemons_Bellossom"
                }
            },
            {
                183,
                new PokemonInfo()
                {
                    ResourceName = "183 - Marill",
                    NameKey = "Pokemons_Marill"
                }
            },
            {
                184,
                new PokemonInfo()
                {
                    ResourceName = "184 - Azumarill",
                    NameKey = "Pokemons_Azumarill"
                }
            },
            {
                185,
                new PokemonInfo()
                {
                    ResourceName = "185 - Sudowoodo",
                    NameKey = "Pokemons_Sudowoodo"
                }
            },
            {
                186,
                new PokemonInfo()
                {
                    ResourceName = "186 - Politoed",
                    NameKey = "Pokemons_Politoed"
                }
            },
            {
                187,
                new PokemonInfo()
                {
                    ResourceName = "187 - Hoppip",
                    NameKey = "Pokemons_Hoppip"
                }
            },
            {
                188,
                new PokemonInfo()
                {
                    ResourceName = "188 - Skiploom",
                    NameKey = "Pokemons_Skiploom"
                }
            },
            {
                189,
                new PokemonInfo()
                {
                    ResourceName = "189 - Jumpluff",
                    NameKey = "Pokemons_Jumpluff"
                }
            },
            {
                190,
                new PokemonInfo()
                {
                    ResourceName = "190 - Aipom",
                    NameKey = "Pokemons_Aipom"
                }
            },
            {
                191,
                new PokemonInfo()
                {
                    ResourceName = "191 - Sunkern",
                    NameKey = "Pokemons_Sunkern"
                }
            },
            {
                192,
                new PokemonInfo()
                {
                    ResourceName = "192 - Sunflora",
                    NameKey = "Pokemons_Sunflora"
                }
            },
            {
                193,
                new PokemonInfo()
                {
                    ResourceName = "193 - Yanma",
                    NameKey = "Pokemons_Yanma"
                }
            },
            {
                194,
                new PokemonInfo()
                {
                    ResourceName = "194 - Wooper",
                    NameKey = "Pokemons_Wooper"
                }
            },
            {
                195,
                new PokemonInfo()
                {
                    ResourceName = "195 - Quagsire",
                    NameKey = "Pokemons_Quagsire"
                }
            },
            {
                196,
                new PokemonInfo()
                {
                    ResourceName = "196 - Espeon",
                    NameKey = "Pokemons_Espeon"
                }
            },
            {
                197,
                new PokemonInfo()
                {
                    ResourceName = "197 - Umbreon",
                    NameKey = "Pokemons_Umbreon"
                }
            },
            {
                198,
                new PokemonInfo()
                {
                    ResourceName = "198 - Murkrow",
                    NameKey = "Pokemons_Murkrow"
                }
            },
            {
                199,
                new PokemonInfo()
                {
                    ResourceName = "199 - Slowking",
                    NameKey = "Pokemons_Slowking"
                }
            },
            {
                200,
                new PokemonInfo()
                {
                    ResourceName = "200 - Misdreavus",
                    NameKey = "Pokemons_Misdreavus"
                }
            },
            {
                201,
                new PokemonInfo()
                {
                    ResourceName = "201 - Unown",
                    NameKey = "Pokemons_Unown"
                }
            },
            {
                202,
                new PokemonInfo()
                {
                    ResourceName = "202 - Wobbuffet",
                    NameKey = "Pokemons_Wobbuffet"
                }
            },
            {
                203,
                new PokemonInfo()
                {
                    ResourceName = "203 - Girafarig",
                    NameKey = "Pokemons_Girafarig"
                }
            },
            {
                204,
                new PokemonInfo()
                {
                    ResourceName = "204 - Pineco",
                    NameKey = "Pokemons_Pineco"
                }
            },
            {
                205,
                new PokemonInfo()
                {
                    ResourceName = "205 - Forretress",
                    NameKey = "Pokemons_Forretress"
                }
            },
            {
                206,
                new PokemonInfo()
                {
                    ResourceName = "206 - Dunsparce",
                    NameKey = "Pokemons_Dunsparce"
                }
            },
            {
                207,
                new PokemonInfo()
                {
                    ResourceName = "207 - Gligar",
                    NameKey = "Pokemons_Gligar"
                }
            },
            {
                208,
                new PokemonInfo()
                {
                    ResourceName = "208 - Steelix",
                    NameKey = "Pokemons_Steelix"
                }
            },
            {
                209,
                new PokemonInfo()
                {
                    ResourceName = "209 - Snubbull",
                    NameKey = "Pokemons_Snubbull"
                }
            },
            {
                210,
                new PokemonInfo()
                {
                    ResourceName = "210 - Granbull",
                    NameKey = "Pokemons_Granbull"
                }
            },
            {
                211,
                new PokemonInfo()
                {
                    ResourceName = "211 - Qwilfish",
                    NameKey = "Pokemons_Qwilfish"
                }
            },
            {
                212,
                new PokemonInfo()
                {
                    ResourceName = "212 - Scizor",
                    NameKey = "Pokemons_Scizor"
                }
            },
            {
                213,
                new PokemonInfo()
                {
                    ResourceName = "213 - Shuckle",
                    NameKey = "Pokemons_Shuckle"
                }
            },
            {
                214,
                new PokemonInfo()
                {
                    ResourceName = "214 - Heracross",
                    NameKey = "Pokemons_Heracross"
                }
            },
            {
                215,
                new PokemonInfo()
                {
                    ResourceName = "215 - Sneasel",
                    NameKey = "Pokemons_Sneasel"
                }
            },
            {
                216,
                new PokemonInfo()
                {
                    ResourceName = "216 - Teddiursa",
                    NameKey = "Pokemons_Teddiursa"
                }
            },
            {
                217,
                new PokemonInfo()
                {
                    ResourceName = "217 - Ursaring",
                    NameKey = "Pokemons_Ursaring"
                }
            },
            {
                218,
                new PokemonInfo()
                {
                    ResourceName = "218 - Slugma",
                    NameKey = "Pokemons_Slugma"
                }
            },
            {
                219,
                new PokemonInfo()
                {
                    ResourceName = "219 - Magcargo",
                    NameKey = "Pokemons_Magcargo"
                }
            },
            {
                220,
                new PokemonInfo()
                {
                    ResourceName = "220 - Swinub",
                    NameKey = "Pokemons_Swinub"
                }
            },
            {
                221,
                new PokemonInfo()
                {
                    ResourceName = "221 - Piloswine",
                    NameKey = "Pokemons_Piloswine"
                }
            },
            {
                222,
                new PokemonInfo()
                {
                    ResourceName = "222 - Corsola",
                    NameKey = "Pokemons_Corsola"
                }
            },
            {
                223,
                new PokemonInfo()
                {
                    ResourceName = "223 - Remoraid",
                    NameKey = "Pokemons_Remoraid"
                }
            },
            {
                224,
                new PokemonInfo()
                {
                    ResourceName = "224 - Octillery",
                    NameKey = "Pokemons_Octillery"
                }
            },
            {
                225,
                new PokemonInfo()
                {
                    ResourceName = "225 - Delibird",
                    NameKey = "Pokemons_Delibird"
                }
            },
            {
                226,
                new PokemonInfo()
                {
                    ResourceName = "226 - Mantine",
                    NameKey = "Pokemons_Mantine"
                }
            },
            {
                227,
                new PokemonInfo()
                {
                    ResourceName = "227 - Skarmory",
                    NameKey = "Pokemons_Skarmory"
                }
            },
            {
                228,
                new PokemonInfo()
                {
                    ResourceName = "228 - Houndour",
                    NameKey = "Pokemons_Houndour"
                }
            },
            {
                229,
                new PokemonInfo()
                {
                    ResourceName = "229 - Houndoom",
                    NameKey = "Pokemons_Houndoom"
                }
            },
            {
                230,
                new PokemonInfo()
                {
                    ResourceName = "230 - Kingdra",
                    NameKey = "Pokemons_Kingdra"
                }
            },
            {
                231,
                new PokemonInfo()
                {
                    ResourceName = "231 - Phanpy",
                    NameKey = "Pokemons_Phanpy"
                }
            },
            {
                232,
                new PokemonInfo()
                {
                    ResourceName = "232 - Donphan",
                    NameKey = "Pokemons_Donphan"
                }
            },
            {
                233,
                new PokemonInfo()
                {
                    ResourceName = "233 - Porygon2",
                    NameKey = "Pokemons_Porygon2"
                }
            },
            {
                234,
                new PokemonInfo()
                {
                    ResourceName = "234 - Stantler",
                    NameKey = "Pokemons_Stantler"
                }
            },
            {
                235,
                new PokemonInfo()
                {
                    ResourceName = "235 - Smeargle",
                    NameKey = "Pokemons_Smeargle"
                }
            },
            {
                236,
                new PokemonInfo()
                {
                    ResourceName = "236 - Tyrogue",
                    NameKey = "Pokemons_Tyrogue"
                }
            },
            {
                237,
                new PokemonInfo()
                {
                    ResourceName = "237 - Hitmontop",
                    NameKey = "Pokemons_Hitmontop"
                }
            },
            {
                238,
                new PokemonInfo()
                {
                    ResourceName = "238 - Smoochum",
                    NameKey = "Pokemons_Smoochum"
                }
            },
            {
                239,
                new PokemonInfo()
                {
                    ResourceName = "239 - Elekid",
                    NameKey = "Pokemons_Elekid"
                }
            },
            {
                240,
                new PokemonInfo()
                {
                    ResourceName = "240 - Magby",
                    NameKey = "Pokemons_Magby"
                }
            },
            {
                241,
                new PokemonInfo()
                {
                    ResourceName = "241 - Miltank",
                    NameKey = "Pokemons_Miltank"
                }
            },
            {
                242,
                new PokemonInfo()
                {
                    ResourceName = "242 - Blissey",
                    NameKey = "Pokemons_Blissey"
                }
            },
            {
                243,
                new PokemonInfo()
                {
                    ResourceName = "243 - Raikou",
                    NameKey = "Pokemons_Raikou"
                }
            },
            {
                244,
                new PokemonInfo()
                {
                    ResourceName = "244 - Entei",
                    NameKey = "Pokemons_Entei"
                }
            },
            {
                245,
                new PokemonInfo()
                {
                    ResourceName = "245 - Suicune",
                    NameKey = "Pokemons_Suicune"
                }
            },
            {
                246,
                new PokemonInfo()
                {
                    ResourceName = "246 - Larvitar",
                    NameKey = "Pokemons_Larvitar"
                }
            },
            {
                247,
                new PokemonInfo()
                {
                    ResourceName = "247 - Pupitar",
                    NameKey = "Pokemons_Pupitar"
                }
            },
            {
                248,
                new PokemonInfo()
                {
                    ResourceName = "248 - Tyranitar",
                    NameKey = "Pokemons_Tyranitar"
                }
            },
            {
                249,
                new PokemonInfo()
                {
                    ResourceName = "249 - Lugia",
                    NameKey = "Pokemons_Lugia"
                }
            },
            {
                250,
                new PokemonInfo()
                {
                    ResourceName = "250 - Ho-oh",
                    NameKey = "Pokemons_Ho-oh"
                }
            },
            {
                251,
                new PokemonInfo()
                {
                    ResourceName = "251 - Celebi",
                    NameKey = "Pokemons_Celebi"
                }
            },
            {
                252,
                new PokemonInfo()
                {
                    ResourceName = "252 - Treecko",
                    NameKey = "Pokemons_Treecko"
                }
            },
            {
                253,
                new PokemonInfo()
                {
                    ResourceName = "253 - Grovyle",
                    NameKey = "Pokemons_Grovyle"
                }
            },
            {
                254,
                new PokemonInfo()
                {
                    ResourceName = "254 - Sceptile",
                    NameKey = "Pokemons_Sceptile"
                }
            },
            {
                255,
                new PokemonInfo()
                {
                    ResourceName = "255 - Torchic",
                    NameKey = "Pokemons_Torchic"
                }
            },
            {
                256,
                new PokemonInfo()
                {
                    ResourceName = "256 - Combusken",
                    NameKey = "Pokemons_Combusken"
                }
            },
            {
                257,
                new PokemonInfo()
                {
                    ResourceName = "257 - Blaziken",
                    NameKey = "Pokemons_Blaziken"
                }
            },
            {
                258,
                new PokemonInfo()
                {
                    ResourceName = "258 - Mudkip",
                    NameKey = "Pokemons_Mudkip"
                }
            },
            {
                259,
                new PokemonInfo()
                {
                    ResourceName = "259 - Marshtomp",
                    NameKey = "Pokemons_Marshtomp"
                }
            },
            {
                260,
                new PokemonInfo()
                {
                    ResourceName = "260 - Swampert",
                    NameKey = "Pokemons_Swampert"
                }
            },
            {
                261,
                new PokemonInfo()
                {
                    ResourceName = "261 - Poochyena",
                    NameKey = "Pokemons_Poochyena"
                }
            },
            {
                262,
                new PokemonInfo()
                {
                    ResourceName = "262 - Mightyena",
                    NameKey = "Pokemons_Mightyena"
                }
            },
            {
                263,
                new PokemonInfo()
                {
                    ResourceName = "263 - Zigzagoon",
                    NameKey = "Pokemons_Zigzagoon"
                }
            },
            {
                264,
                new PokemonInfo()
                {
                    ResourceName = "264 - Linoone",
                    NameKey = "Pokemons_Linoone"
                }
            },
            {
                265,
                new PokemonInfo()
                {
                    ResourceName = "265 - Wurmple",
                    NameKey = "Pokemons_Wurmple"
                }
            },
            {
                266,
                new PokemonInfo()
                {
                    ResourceName = "266 - Silcoon",
                    NameKey = "Pokemons_Silcoon"
                }
            },
            {
                267,
                new PokemonInfo()
                {
                    ResourceName = "267 - Beautifly",
                    NameKey = "Pokemons_Beautifly"
                }
            },
            {
                268,
                new PokemonInfo()
                {
                    ResourceName = "268 - Cascoon",
                    NameKey = "Pokemons_Cascoon"
                }
            },
            {
                269,
                new PokemonInfo()
                {
                    ResourceName = "269 - Dustox",
                    NameKey = "Pokemons_Dustox"
                }
            },
            {
                270,
                new PokemonInfo()
                {
                    ResourceName = "270 - Lotad",
                    NameKey = "Pokemons_Lotad"
                }
            },
            {
                271,
                new PokemonInfo()
                {
                    ResourceName = "271 - Lombre",
                    NameKey = "Pokemons_Lombre"
                }
            },
            {
                272,
                new PokemonInfo()
                {
                    ResourceName = "272 - Ludicolo",
                    NameKey = "Pokemons_Ludicolo"
                }
            },
            {
                273,
                new PokemonInfo()
                {
                    ResourceName = "273 - Seedot",
                    NameKey = "Pokemons_Seedot"
                }
            },
            {
                274,
                new PokemonInfo()
                {
                    ResourceName = "274 - Nuzleaf",
                    NameKey = "Pokemons_Nuzleaf"
                }
            },
            {
                275,
                new PokemonInfo()
                {
                    ResourceName = "275 - Shiftry",
                    NameKey = "Pokemons_Shiftry"
                }
            },
            {
                276,
                new PokemonInfo()
                {
                    ResourceName = "276 - Taillow",
                    NameKey = "Pokemons_Taillow"
                }
            },
            {
                277,
                new PokemonInfo()
                {
                    ResourceName = "277 - Swellow",
                    NameKey = "Pokemons_Swellow"
                }
            },
            {
                278,
                new PokemonInfo()
                {
                    ResourceName = "278 - Wingull",
                    NameKey = "Pokemons_Wingull"
                }
            },
            {
                279,
                new PokemonInfo()
                {
                    ResourceName = "279 - Pelipper",
                    NameKey = "Pokemons_Pelipper"
                }
            },
            {
                280,
                new PokemonInfo()
                {
                    ResourceName = "280 - Ralts",
                    NameKey = "Pokemons_Ralts"
                }
            },
            {
                281,
                new PokemonInfo()
                {
                    ResourceName = "281 - Kirlia",
                    NameKey = "Pokemons_Kirlia"
                }
            },
            {
                282,
                new PokemonInfo()
                {
                    ResourceName = "282 - Gardevoir",
                    NameKey = "Pokemons_Gardevoir"
                }
            },
            {
                283,
                new PokemonInfo()
                {
                    ResourceName = "283 - Surskit",
                    NameKey = "Pokemons_Surskit"
                }
            },
            {
                284,
                new PokemonInfo()
                {
                    ResourceName = "284 - Masquerain",
                    NameKey = "Pokemons_Masquerain"
                }
            },
            {
                285,
                new PokemonInfo()
                {
                    ResourceName = "285 - Shroomish",
                    NameKey = "Pokemons_Shroomish"
                }
            },
            {
                286,
                new PokemonInfo()
                {
                    ResourceName = "286 - Breloom",
                    NameKey = "Pokemons_Breloom"
                }
            },
            {
                287,
                new PokemonInfo()
                {
                    ResourceName = "287 - Slakoth",
                    NameKey = "Pokemons_Slakoth"
                }
            },
            {
                288,
                new PokemonInfo()
                {
                    ResourceName = "288 - Vigoroth",
                    NameKey = "Pokemons_Vigoroth"
                }
            },
            {
                289,
                new PokemonInfo()
                {
                    ResourceName = "289 - Slaking",
                    NameKey = "Pokemons_Slaking"
                }
            },
            {
                290,
                new PokemonInfo()
                {
                    ResourceName = "290 - Nincada",
                    NameKey = "Pokemons_Nincada"
                }
            },
            {
                291,
                new PokemonInfo()
                {
                    ResourceName = "291 - Ninjask",
                    NameKey = "Pokemons_Ninjask"
                }
            },
            {
                292,
                new PokemonInfo()
                {
                    ResourceName = "292 - Shedinja",
                    NameKey = "Pokemons_Shedinja"
                }
            },
            {
                293,
                new PokemonInfo()
                {
                    ResourceName = "293 - Whismur",
                    NameKey = "Pokemons_Whismur"
                }
            },
            {
                294,
                new PokemonInfo()
                {
                    ResourceName = "294 - Loudred",
                    NameKey = "Pokemons_Loudred"
                }
            },
            {
                295,
                new PokemonInfo()
                {
                    ResourceName = "295 - Exploud",
                    NameKey = "Pokemons_Exploud"
                }
            },
            {
                296,
                new PokemonInfo()
                {
                    ResourceName = "296 - Makuhita",
                    NameKey = "Pokemons_Makuhita"
                }
            },
            {
                297,
                new PokemonInfo()
                {
                    ResourceName = "297 - Hariyama",
                    NameKey = "Pokemons_Hariyama"
                }
            },
            {
                298,
                new PokemonInfo()
                {
                    ResourceName = "298 - Azurill",
                    NameKey = "Pokemons_Azurill"
                }
            },
            {
                299,
                new PokemonInfo()
                {
                    ResourceName = "299 - Nosepass",
                    NameKey = "Pokemons_Nosepass"
                }
            },
            {
                300,
                new PokemonInfo()
                {
                    ResourceName = "300 - Skitty",
                    NameKey = "Pokemons_Skitty"
                }
            },
            {
                301,
                new PokemonInfo()
                {
                    ResourceName = "301 - Delcatty",
                    NameKey = "Pokemons_Delcatty"
                }
            },
            {
                302,
                new PokemonInfo()
                {
                    ResourceName = "302 - Sableye",
                    NameKey = "Pokemons_Sableye"
                }
            },
            {
                303,
                new PokemonInfo()
                {
                    ResourceName = "303 - Mawile",
                    NameKey = "Pokemons_Mawile"
                }
            },
            {
                304,
                new PokemonInfo()
                {
                    ResourceName = "304 - Aron",
                    NameKey = "Pokemons_Aron"
                }
            },
            {
                305,
                new PokemonInfo()
                {
                    ResourceName = "305 - Lairon",
                    NameKey = "Pokemons_Lairon"
                }
            },
            {
                306,
                new PokemonInfo()
                {
                    ResourceName = "306 - Aggron",
                    NameKey = "Pokemons_Aggron"
                }
            },
            {
                307,
                new PokemonInfo()
                {
                    ResourceName = "307 - Meditite",
                    NameKey = "Pokemons_Meditite"
                }
            },
            {
                308,
                new PokemonInfo()
                {
                    ResourceName = "308 - Medicham",
                    NameKey = "Pokemons_Medicham"
                }
            },
            {
                309,
                new PokemonInfo()
                {
                    ResourceName = "309 - Electrike",
                    NameKey = "Pokemons_Electrike"
                }
            },
            {
                310,
                new PokemonInfo()
                {
                    ResourceName = "310 - Manectric",
                    NameKey = "Pokemons_Manectric"
                }
            },
            {
                311,
                new PokemonInfo()
                {
                    ResourceName = "311 - Plusle",
                    NameKey = "Pokemons_Plusle"
                }
            },
            {
                312,
                new PokemonInfo()
                {
                    ResourceName = "312 - Minun",
                    NameKey = "Pokemons_Minun"
                }
            },
            {
                313,
                new PokemonInfo()
                {
                    ResourceName = "313 - Volbeat",
                    NameKey = "Pokemons_Volbeat"
                }
            },
            {
                314,
                new PokemonInfo()
                {
                    ResourceName = "314 - Illumise",
                    NameKey = "Pokemons_Illumise"
                }
            },
            {
                315,
                new PokemonInfo()
                {
                    ResourceName = "315 - Roselia",
                    NameKey = "Pokemons_Roselia"
                }
            },
            {
                316,
                new PokemonInfo()
                {
                    ResourceName = "316 - Gulpin",
                    NameKey = "Pokemons_Gulpin"
                }
            },
            {
                317,
                new PokemonInfo()
                {
                    ResourceName = "317 - Swalot",
                    NameKey = "Pokemons_Swalot"
                }
            },
            {
                318,
                new PokemonInfo()
                {
                    ResourceName = "318 - Carvanha",
                    NameKey = "Pokemons_Carvanha"
                }
            },
            {
                319,
                new PokemonInfo()
                {
                    ResourceName = "319 - Sharpedo",
                    NameKey = "Pokemons_Sharpedo"
                }
            },
            {
                320,
                new PokemonInfo()
                {
                    ResourceName = "320 - Wailmer",
                    NameKey = "Pokemons_Wailmer"
                }
            },
            {
                321,
                new PokemonInfo()
                {
                    ResourceName = "321 - Wailord",
                    NameKey = "Pokemons_Wailord"
                }
            },
            {
                322,
                new PokemonInfo()
                {
                    ResourceName = "322 - Numel",
                    NameKey = "Pokemons_Numel"
                }
            },
            {
                323,
                new PokemonInfo()
                {
                    ResourceName = "323 - Camerupt",
                    NameKey = "Pokemons_Camerupt"
                }
            },
            {
                324,
                new PokemonInfo()
                {
                    ResourceName = "324 - Torkoal",
                    NameKey = "Pokemons_Torkoal"
                }
            },
            {
                325,
                new PokemonInfo()
                {
                    ResourceName = "325 - Spoink",
                    NameKey = "Pokemons_Spoink"
                }
            },
            {
                326,
                new PokemonInfo()
                {
                    ResourceName = "326 - Grumpig",
                    NameKey = "Pokemons_Grumpig"
                }
            },
            {
                327,
                new PokemonInfo()
                {
                    ResourceName = "327 - Spinda",
                    NameKey = "Pokemons_Spinda"
                }
            },
            {
                328,
                new PokemonInfo()
                {
                    ResourceName = "328 - Trapinch",
                    NameKey = "Pokemons_Trapinch"
                }
            },
            {
                329,
                new PokemonInfo()
                {
                    ResourceName = "329 - Vibrava",
                    NameKey = "Pokemons_Vibrava"
                }
            },
            {
                330,
                new PokemonInfo()
                {
                    ResourceName = "330 - Flygon",
                    NameKey = "Pokemons_Flygon"
                }
            },
            {
                331,
                new PokemonInfo()
                {
                    ResourceName = "331 - Cacnea",
                    NameKey = "Pokemons_Cacnea"
                }
            },
            {
                332,
                new PokemonInfo()
                {
                    ResourceName = "332 - Cacturne",
                    NameKey = "Pokemons_Cacturne"
                }
            },
            {
                333,
                new PokemonInfo()
                {
                    ResourceName = "333 - Swablu",
                    NameKey = "Pokemons_Swablu"
                }
            },
            {
                334,
                new PokemonInfo()
                {
                    ResourceName = "334 - Altaria",
                    NameKey = "Pokemons_Altaria"
                }
            },
            {
                335,
                new PokemonInfo()
                {
                    ResourceName = "335 - Zangoose",
                    NameKey = "Pokemons_Zangoose"
                }
            },
            {
                336,
                new PokemonInfo()
                {
                    ResourceName = "336 - Seviper",
                    NameKey = "Pokemons_Seviper"
                }
            },
            {
                337,
                new PokemonInfo()
                {
                    ResourceName = "337 - Lunatone",
                    NameKey = "Pokemons_Lunatone"
                }
            },
            {
                338,
                new PokemonInfo()
                {
                    ResourceName = "338 - Solrock",
                    NameKey = "Pokemons_Solrock"
                }
            },
            {
                339,
                new PokemonInfo()
                {
                    ResourceName = "339 - Barboach",
                    NameKey = "Pokemons_Barboach"
                }
            },
            {
                340,
                new PokemonInfo()
                {
                    ResourceName = "340 - Whiscash",
                    NameKey = "Pokemons_Whiscash"
                }
            },
            {
                341,
                new PokemonInfo()
                {
                    ResourceName = "341 - Corphish",
                    NameKey = "Pokemons_Corphish"
                }
            },
            {
                342,
                new PokemonInfo()
                {
                    ResourceName = "342 - Crawdaunt",
                    NameKey = "Pokemons_Crawdaunt"
                }
            },
            {
                343,
                new PokemonInfo()
                {
                    ResourceName = "343 - Baltoy",
                    NameKey = "Pokemons_Baltoy"
                }
            },
            {
                344,
                new PokemonInfo()
                {
                    ResourceName = "344 - Claydol",
                    NameKey = "Pokemons_Claydol"
                }
            },
            {
                345,
                new PokemonInfo()
                {
                    ResourceName = "345 - Lileep",
                    NameKey = "Pokemons_Lileep"
                }
            },
            {
                346,
                new PokemonInfo()
                {
                    ResourceName = "346 - Cradily",
                    NameKey = "Pokemons_Cradily"
                }
            },
            {
                347,
                new PokemonInfo()
                {
                    ResourceName = "347 - Anorith",
                    NameKey = "Pokemons_Anorith"
                }
            },
            {
                348,
                new PokemonInfo()
                {
                    ResourceName = "348 - Armaldo",
                    NameKey = "Pokemons_Armaldo"
                }
            },
            {
                349,
                new PokemonInfo()
                {
                    ResourceName = "349 - Feebas",
                    NameKey = "Pokemons_Feebas"
                }
            },
            {
                350,
                new PokemonInfo()
                {
                    ResourceName = "350 - Milotic",
                    NameKey = "Pokemons_Milotic"
                }
            },
            {
                351,
                new PokemonInfo()
                {
                    ResourceName = "351 - Castform",
                    NameKey = "Pokemons_Castform"
                }
            },
            {
                352,
                new PokemonInfo()
                {
                    ResourceName = "352 - Kecleon",
                    NameKey = "Pokemons_Kecleon"
                }
            },
            {
                353,
                new PokemonInfo()
                {
                    ResourceName = "353 - Shuppet",
                    NameKey = "Pokemons_Shuppet"
                }
            },
            {
                354,
                new PokemonInfo()
                {
                    ResourceName = "354 - Banette",
                    NameKey = "Pokemons_Banette"
                }
            },
            {
                355,
                new PokemonInfo()
                {
                    ResourceName = "355 - Duskull",
                    NameKey = "Pokemons_Duskull"
                }
            },
            {
                356,
                new PokemonInfo()
                {
                    ResourceName = "356 - Dusclops",
                    NameKey = "Pokemons_Dusclops"
                }
            },
            {
                357,
                new PokemonInfo()
                {
                    ResourceName = "357 - Tropius",
                    NameKey = "Pokemons_Tropius"
                }
            },
            {
                358,
                new PokemonInfo()
                {
                    ResourceName = "358 - Chimecho",
                    NameKey = "Pokemons_Chimecho"
                }
            },
            {
                359,
                new PokemonInfo()
                {
                    ResourceName = "359 - Absol",
                    NameKey = "Pokemons_Absol"
                }
            },
            {
                360,
                new PokemonInfo()
                {
                    ResourceName = "360 - Wynaut",
                    NameKey = "Pokemons_Wynaut"
                }
            },
            {
                361,
                new PokemonInfo()
                {
                    ResourceName = "361 - Snorunt",
                    NameKey = "Pokemons_Snorunt"
                }
            },
            {
                362,
                new PokemonInfo()
                {
                    ResourceName = "362 - Glalie",
                    NameKey = "Pokemons_Glalie"
                }
            },
            {
                363,
                new PokemonInfo()
                {
                    ResourceName = "363 - Spheal",
                    NameKey = "Pokemons_Spheal"
                }
            },
            {
                364,
                new PokemonInfo()
                {
                    ResourceName = "364 - Sealeo",
                    NameKey = "Pokemons_Sealeo"
                }
            },
            {
                365,
                new PokemonInfo()
                {
                    ResourceName = "365 - Walrein",
                    NameKey = "Pokemons_Walrein"
                }
            },
            {
                366,
                new PokemonInfo()
                {
                    ResourceName = "366 - Clamperl",
                    NameKey = "Pokemons_Clamperl"
                }
            },
            {
                367,
                new PokemonInfo()
                {
                    ResourceName = "367 - Huntail",
                    NameKey = "Pokemons_Huntail"
                }
            },
            {
                368,
                new PokemonInfo()
                {
                    ResourceName = "368 - Gorebyss",
                    NameKey = "Pokemons_Gorebyss"
                }
            },
            {
                369,
                new PokemonInfo()
                {
                    ResourceName = "369 - Relicanth",
                    NameKey = "Pokemons_Relicanth"
                }
            },
            {
                370,
                new PokemonInfo()
                {
                    ResourceName = "370 - Luvdisc",
                    NameKey = "Pokemons_Luvdisc"
                }
            },
            {
                371,
                new PokemonInfo()
                {
                    ResourceName = "371 - Bagon",
                    NameKey = "Pokemons_Bagon"
                }
            },
            {
                372,
                new PokemonInfo()
                {
                    ResourceName = "372 - Shelgon",
                    NameKey = "Pokemons_Shelgon"
                }
            },
            {
                373,
                new PokemonInfo()
                {
                    ResourceName = "373 - Salamence",
                    NameKey = "Pokemons_Salamence"
                }
            },
            {
                374,
                new PokemonInfo()
                {
                    ResourceName = "374 - Beldum",
                    NameKey = "Pokemons_Beldum"
                }
            },
            {
                375,
                new PokemonInfo()
                {
                    ResourceName = "375 - Metang",
                    NameKey = "Pokemons_Metang"
                }
            },
            {
                376,
                new PokemonInfo()
                {
                    ResourceName = "376 - Metagross",
                    NameKey = "Pokemons_Metagross"
                }
            },
            {
                377,
                new PokemonInfo()
                {
                    ResourceName = "377 - Regirock",
                    NameKey = "Pokemons_Regirock"
                }
            },
            {
                378,
                new PokemonInfo()
                {
                    ResourceName = "378 - Regice",
                    NameKey = "Pokemons_Regice"
                }
            },
            {
                379,
                new PokemonInfo()
                {
                    ResourceName = "379 - Registeel",
                    NameKey = "Pokemons_Registeel"
                }
            },
            {
                380,
                new PokemonInfo()
                {
                    ResourceName = "380 - Latias",
                    NameKey = "Pokemons_Latias"
                }
            },
            {
                381,
                new PokemonInfo()
                {
                    ResourceName = "381 - Latios",
                    NameKey = "Pokemons_Latios"
                }
            },
            {
                382,
                new PokemonInfo()
                {
                    ResourceName = "382 - Kyogre",
                    NameKey = "Pokemons_Kyogre"
                }
            },
            {
                383,
                new PokemonInfo()
                {
                    ResourceName = "383 - Groudon",
                    NameKey = "Pokemons_Groudon"
                }
            },
            {
                384,
                new PokemonInfo()
                {
                    ResourceName = "384 - Rayquaza",
                    NameKey = "Pokemons_Rayquaza"
                }
            },
            {
                385,
                new PokemonInfo()
                {
                    ResourceName = "385 - Jirachi",
                    NameKey = "Pokemons_Jirachi"
                }
            },
            {
                386,
                new PokemonInfo()
                {
                    ResourceName = "386 - Deoxys",
                    NameKey = "Pokemons_Deoxys"
                }
            },
            {
                387,
                new PokemonInfo()
                {
                    ResourceName = "387 - Turtwig",
                    NameKey = "Pokemons_Turtwig"
                }
            },
            {
                388,
                new PokemonInfo()
                {
                    ResourceName = "388 - Grotle",
                    NameKey = "Pokemons_Grotle"
                }
            },
            {
                389,
                new PokemonInfo()
                {
                    ResourceName = "389 - Torterra",
                    NameKey = "Pokemons_Torterra"
                }
            },
            {
                390,
                new PokemonInfo()
                {
                    ResourceName = "390 - Chimchar",
                    NameKey = "Pokemons_Chimchar"
                }
            },
            {
                391,
                new PokemonInfo()
                {
                    ResourceName = "391 - Monferno",
                    NameKey = "Pokemons_Monferno"
                }
            },
            {
                392,
                new PokemonInfo()
                {
                    ResourceName = "392 - Infernape",
                    NameKey = "Pokemons_Infernape"
                }
            },
            {
                393,
                new PokemonInfo()
                {
                    ResourceName = "393 - Piplup",
                    NameKey = "Pokemons_Piplup"
                }
            },
            {
                394,
                new PokemonInfo()
                {
                    ResourceName = "394 - Prinplup",
                    NameKey = "Pokemons_Prinplup"
                }
            },
            {
                395,
                new PokemonInfo()
                {
                    ResourceName = "395 - Empoleon",
                    NameKey = "Pokemons_Empoleon"
                }
            },
            {
                396,
                new PokemonInfo()
                {
                    ResourceName = "396 - Starly",
                    NameKey = "Pokemons_Starly"
                }
            },
            {
                397,
                new PokemonInfo()
                {
                    ResourceName = "397 - Staravia",
                    NameKey = "Pokemons_Staravia"
                }
            },
            {
                398,
                new PokemonInfo()
                {
                    ResourceName = "398 - Staraptor",
                    NameKey = "Pokemons_Staraptor"
                }
            },
            {
                399,
                new PokemonInfo()
                {
                    ResourceName = "399 - Bidoof",
                    NameKey = "Pokemons_Bidoof"
                }
            },
            {
                400,
                new PokemonInfo()
                {
                    ResourceName = "400 - Bibarel",
                    NameKey = "Pokemons_Bibarel"
                }
            },
            {
                401,
                new PokemonInfo()
                {
                    ResourceName = "401 - Kricketot",
                    NameKey = "Pokemons_Kricketot"
                }
            },
            {
                402,
                new PokemonInfo()
                {
                    ResourceName = "402 - Kricketune",
                    NameKey = "Pokemons_Kricketune"
                }
            },
            {
                403,
                new PokemonInfo()
                {
                    ResourceName = "403 - Shinx",
                    NameKey = "Pokemons_Shinx"
                }
            },
            {
                404,
                new PokemonInfo()
                {
                    ResourceName = "404 - Luxio",
                    NameKey = "Pokemons_Luxio"
                }
            },
            {
                405,
                new PokemonInfo()
                {
                    ResourceName = "405 - Luxray",
                    NameKey = "Pokemons_Luxray"
                }
            },
            {
                406,
                new PokemonInfo()
                {
                    ResourceName = "406 - Budew",
                    NameKey = "Pokemons_Budew"
                }
            },
            {
                407,
                new PokemonInfo()
                {
                    ResourceName = "407 - Roserade",
                    NameKey = "Pokemons_Roserade"
                }
            },
            {
                408,
                new PokemonInfo()
                {
                    ResourceName = "408 - Cranidos",
                    NameKey = "Pokemons_Cranidos"
                }
            },
            {
                409,
                new PokemonInfo()
                {
                    ResourceName = "409 - Rampardos",
                    NameKey = "Pokemons_Rampardos"
                }
            },
            {
                410,
                new PokemonInfo()
                {
                    ResourceName = "410 - Shieldon",
                    NameKey = "Pokemons_Shieldon"
                }
            },
            {
                411,
                new PokemonInfo()
                {
                    ResourceName = "411 - Bastiodon",
                    NameKey = "Pokemons_Bastiodon"
                }
            },
            {
                412,
                new PokemonInfo()
                {
                    ResourceName = "412 - Burmy",
                    NameKey = "Pokemons_Burmy"
                }
            },
            {
                413,
                new PokemonInfo()
                {
                    ResourceName = "413 - Wormadam",
                    NameKey = "Pokemons_Wormadam"
                }
            },
            {
                414,
                new PokemonInfo()
                {
                    ResourceName = "414 - Mothim",
                    NameKey = "Pokemons_Mothim"
                }
            },
            {
                415,
                new PokemonInfo()
                {
                    ResourceName = "415 - Combee",
                    NameKey = "Pokemons_Combee"
                }
            },
            {
                416,
                new PokemonInfo()
                {
                    ResourceName = "416 - Vespiquen",
                    NameKey = "Pokemons_Vespiquen"
                }
            },
            {
                417,
                new PokemonInfo()
                {
                    ResourceName = "417 - Pachirisu",
                    NameKey = "Pokemons_Pachirisu"
                }
            },
            {
                418,
                new PokemonInfo()
                {
                    ResourceName = "418 - Buizel",
                    NameKey = "Pokemons_Buizel"
                }
            },
            {
                419,
                new PokemonInfo()
                {
                    ResourceName = "419 - Floatzel",
                    NameKey = "Pokemons_Floatzel"
                }
            },
            {
                420,
                new PokemonInfo()
                {
                    ResourceName = "420 - Cherubi",
                    NameKey = "Pokemons_Cherubi"
                }
            },
            {
                421,
                new PokemonInfo()
                {
                    ResourceName = "421 - Cherrim",
                    NameKey = "Pokemons_Cherrim"
                }
            },
            {
                422,
                new PokemonInfo()
                {
                    ResourceName = "422 - Shellos",
                    NameKey = "Pokemons_Shellos"
                }
            },
            {
                423,
                new PokemonInfo()
                {
                    ResourceName = "423 - Gastrodon",
                    NameKey = "Pokemons_Gastrodon"
                }
            },
            {
                424,
                new PokemonInfo()
                {
                    ResourceName = "424 - Ambipom",
                    NameKey = "Pokemons_Ambipom"
                }
            },
            {
                425,
                new PokemonInfo()
                {
                    ResourceName = "425 - Drifloon",
                    NameKey = "Pokemons_Drifloon"
                }
            },
            {
                426,
                new PokemonInfo()
                {
                    ResourceName = "426 - Drifblim",
                    NameKey = "Pokemons_Drifblim"
                }
            },
            {
                427,
                new PokemonInfo()
                {
                    ResourceName = "427 - Buneary",
                    NameKey = "Pokemons_Buneary"
                }
            },
            {
                428,
                new PokemonInfo()
                {
                    ResourceName = "428 - Lopunny",
                    NameKey = "Pokemons_Lopunny"
                }
            },
            {
                429,
                new PokemonInfo()
                {
                    ResourceName = "429 - Mismagius",
                    NameKey = "Pokemons_Mismagius"
                }
            },
            {
                430,
                new PokemonInfo()
                {
                    ResourceName = "430 - Honchkrow",
                    NameKey = "Pokemons_Honchkrow"
                }
            },
            {
                431,
                new PokemonInfo()
                {
                    ResourceName = "431 - Glameow",
                    NameKey = "Pokemons_Glameow"
                }
            },
            {
                432,
                new PokemonInfo()
                {
                    ResourceName = "432 - Purugly",
                    NameKey = "Pokemons_Purugly"
                }
            },
            {
                433,
                new PokemonInfo()
                {
                    ResourceName = "433 - Chingling",
                    NameKey = "Pokemons_Chingling"
                }
            },
            {
                434,
                new PokemonInfo()
                {
                    ResourceName = "434 - Stunky",
                    NameKey = "Pokemons_Stunky"
                }
            },
            {
                435,
                new PokemonInfo()
                {
                    ResourceName = "435 - Skuntank",
                    NameKey = "Pokemons_Skuntank"
                }
            },
            {
                436,
                new PokemonInfo()
                {
                    ResourceName = "436 - Bronzor",
                    NameKey = "Pokemons_Bronzor"
                }
            },
            {
                437,
                new PokemonInfo()
                {
                    ResourceName = "437 - Bronzong",
                    NameKey = "Pokemons_Bronzong"
                }
            },
            {
                438,
                new PokemonInfo()
                {
                    ResourceName = "438 - Bonsly",
                    NameKey = "Pokemons_Bonsly"
                }
            },
            {
                439,
                new PokemonInfo()
                {
                    ResourceName = "439 - Mime Jr.",
                    NameKey = "Pokemons_Mime Jr."
                }
            },
            {
                440,
                new PokemonInfo()
                {
                    ResourceName = "440 - Happiny",
                    NameKey = "Pokemons_Happiny"
                }
            },
            {
                441,
                new PokemonInfo()
                {
                    ResourceName = "441 - Chatot",
                    NameKey = "Pokemons_Chatot"
                }
            },
            {
                442,
                new PokemonInfo()
                {
                    ResourceName = "442 - Spiritomb",
                    NameKey = "Pokemons_Spiritomb"
                }
            },
            {
                443,
                new PokemonInfo()
                {
                    ResourceName = "443 - Gible",
                    NameKey = "Pokemons_Gible"
                }
            },
            {
                444,
                new PokemonInfo()
                {
                    ResourceName = "444 - Gabite",
                    NameKey = "Pokemons_Gabite"
                }
            },
            {
                445,
                new PokemonInfo()
                {
                    ResourceName = "445 - Garchomp",
                    NameKey = "Pokemons_Garchomp"
                }
            },
            {
                446,
                new PokemonInfo()
                {
                    ResourceName = "446 - Munchlax",
                    NameKey = "Pokemons_Munchlax"
                }
            },
            {
                447,
                new PokemonInfo()
                {
                    ResourceName = "447 - Riolu",
                    NameKey = "Pokemons_Riolu"
                }
            },
            {
                448,
                new PokemonInfo()
                {
                    ResourceName = "448 - Lucario",
                    NameKey = "Pokemons_Lucario"
                }
            },
            {
                449,
                new PokemonInfo()
                {
                    ResourceName = "449 - Hippopotas",
                    NameKey = "Pokemons_Hippopotas"
                }
            },
            {
                450,
                new PokemonInfo()
                {
                    ResourceName = "450 - Hippowdon",
                    NameKey = "Pokemons_Hippowdon"
                }
            },
            {
                451,
                new PokemonInfo()
                {
                    ResourceName = "451 - Skorupi",
                    NameKey = "Pokemons_Skorupi"
                }
            },
            {
                452,
                new PokemonInfo()
                {
                    ResourceName = "452 - Drapion",
                    NameKey = "Pokemons_Drapion"
                }
            },
            {
                453,
                new PokemonInfo()
                {
                    ResourceName = "453 - Croagunk",
                    NameKey = "Pokemons_Croagunk"
                }
            },
            {
                454,
                new PokemonInfo()
                {
                    ResourceName = "454 - Toxicroak",
                    NameKey = "Pokemons_Toxicroak"
                }
            },
            {
                455,
                new PokemonInfo()
                {
                    ResourceName = "455 - Carnivine",
                    NameKey = "Pokemons_Carnivine"
                }
            },
            {
                456,
                new PokemonInfo()
                {
                    ResourceName = "456 - Finneon",
                    NameKey = "Pokemons_Finneon"
                }
            },
            {
                457,
                new PokemonInfo()
                {
                    ResourceName = "457 - Lumineon",
                    NameKey = "Pokemons_Lumineon"
                }
            },
            {
                458,
                new PokemonInfo()
                {
                    ResourceName = "458 - Mantyke",
                    NameKey = "Pokemons_Mantyke"
                }
            },
            {
                459,
                new PokemonInfo()
                {
                    ResourceName = "459 - Snover",
                    NameKey = "Pokemons_Snover"
                }
            },
            {
                460,
                new PokemonInfo()
                {
                    ResourceName = "460 - Abomasnow",
                    NameKey = "Pokemons_Abomasnow"
                }
            },
            {
                461,
                new PokemonInfo()
                {
                    ResourceName = "461 - Weavile",
                    NameKey = "Pokemons_Weavile"
                }
            },
            {
                462,
                new PokemonInfo()
                {
                    ResourceName = "462 - Magnezone",
                    NameKey = "Pokemons_Magnezone"
                }
            },
            {
                463,
                new PokemonInfo()
                {
                    ResourceName = "463 - Lickilicky",
                    NameKey = "Pokemons_Lickilicky"
                }
            },
            {
                464,
                new PokemonInfo()
                {
                    ResourceName = "464 - Rhyperior",
                    NameKey = "Pokemons_Rhyperior"
                }
            },
            {
                465,
                new PokemonInfo()
                {
                    ResourceName = "465 - Tangrowth",
                    NameKey = "Pokemons_Tangrowth"
                }
            },
            {
                466,
                new PokemonInfo()
                {
                    ResourceName = "466 - Electivire",
                    NameKey = "Pokemons_Electivire"
                }
            },
            {
                467,
                new PokemonInfo()
                {
                    ResourceName = "467 - Magmortar",
                    NameKey = "Pokemons_Magmortar"
                }
            },
            {
                468,
                new PokemonInfo()
                {
                    ResourceName = "468 - Togekiss",
                    NameKey = "Pokemons_Togekiss"
                }
            },
            {
                469,
                new PokemonInfo()
                {
                    ResourceName = "469 - Yanmega",
                    NameKey = "Pokemons_Yanmega"
                }
            },
            {
                470,
                new PokemonInfo()
                {
                    ResourceName = "470 - Leafeon",
                    NameKey = "Pokemons_Leafeon"
                }
            },
            {
                471,
                new PokemonInfo()
                {
                    ResourceName = "471 - Glaceon",
                    NameKey = "Pokemons_Glaceon"
                }
            },
            {
                472,
                new PokemonInfo()
                {
                    ResourceName = "472 - Gliscor",
                    NameKey = "Pokemons_Gliscor"
                }
            },
            {
                473,
                new PokemonInfo()
                {
                    ResourceName = "473 - Mamoswine",
                    NameKey = "Pokemons_Mamoswine"
                }
            },
            {
                474,
                new PokemonInfo()
                {
                    ResourceName = "474 - Porygon-Z",
                    NameKey = "Pokemons_Porygon-Z"
                }
            },
            {
                475,
                new PokemonInfo()
                {
                    ResourceName = "475 - Gallade",
                    NameKey = "Pokemons_Gallade"
                }
            },
            {
                476,
                new PokemonInfo()
                {
                    ResourceName = "476 - Probopass",
                    NameKey = "Pokemons_Probopass"
                }
            },
            {
                477,
                new PokemonInfo()
                {
                    ResourceName = "477 - Dusknoir",
                    NameKey = "Pokemons_Dusknoir"
                }
            },
            {
                478,
                new PokemonInfo()
                {
                    ResourceName = "478 - Froslass",
                    NameKey = "Pokemons_Froslass"
                }
            },
            {
                479,
                new PokemonInfo()
                {
                    ResourceName = "479 - Rotom",
                    NameKey = "Pokemons_Rotom"
                }
            },
            {
                480,
                new PokemonInfo()
                {
                    ResourceName = "480 - Uxie",
                    NameKey = "Pokemons_Uxie"
                }
            },
            {
                481,
                new PokemonInfo()
                {
                    ResourceName = "481 - Mesprit",
                    NameKey = "Pokemons_Mesprit"
                }
            },
            {
                482,
                new PokemonInfo()
                {
                    ResourceName = "482 - Azelf",
                    NameKey = "Pokemons_Azelf"
                }
            },
            {
                483,
                new PokemonInfo()
                {
                    ResourceName = "483 - Dialga",
                    NameKey = "Pokemons_Dialga"
                }
            },
            {
                484,
                new PokemonInfo()
                {
                    ResourceName = "484 - Palkia",
                    NameKey = "Pokemons_Palkia"
                }
            },
            {
                485,
                new PokemonInfo()
                {
                    ResourceName = "485 - Heatran",
                    NameKey = "Pokemons_Heatran"
                }
            },
            {
                486,
                new PokemonInfo()
                {
                    ResourceName = "486 - Regigigas",
                    NameKey = "Pokemons_Regigigas"
                }
            },
            {
                487,
                new PokemonInfo()
                {
                    ResourceName = "487 - Giratina",
                    NameKey = "Pokemons_Giratina"
                }
            },
            {
                488,
                new PokemonInfo()
                {
                    ResourceName = "488 - Cresselia",
                    NameKey = "Pokemons_Cresselia"
                }
            },
            {
                489,
                new PokemonInfo()
                {
                    ResourceName = "489 - Phione",
                    NameKey = "Pokemons_Phione"
                }
            },
            {
                490,
                new PokemonInfo()
                {
                    ResourceName = "490 - Manaphy",
                    NameKey = "Pokemons_Manaphy"
                }
            },
            {
                491,
                new PokemonInfo()
                {
                    ResourceName = "491 - Darkrai",
                    NameKey = "Pokemons_Darkrai"
                }
            },
            {
                492,
                new PokemonInfo()
                {
                    ResourceName = "492 - Shaymin",
                    NameKey = "Pokemons_Shaymin"
                }
            },
            {
                493,
                new PokemonInfo()
                {
                    ResourceName = "493 - Arceus",
                    NameKey = "Pokemons_Arceus"
                }
            },
            {
                494,
                new PokemonInfo()
                {
                    ResourceName = "494 - Victini",
                    NameKey = "Pokemons_Victini"
                }
            },
            {
                495,
                new PokemonInfo()
                {
                    ResourceName = "495 - Snivy",
                    NameKey = "Pokemons_Snivy"
                }
            },
            {
                496,
                new PokemonInfo()
                {
                    ResourceName = "496 - Servine",
                    NameKey = "Pokemons_Servine"
                }
            },
            {
                497,
                new PokemonInfo()
                {
                    ResourceName = "497 - Serperior",
                    NameKey = "Pokemons_Serperior"
                }
            },
            {
                498,
                new PokemonInfo()
                {
                    ResourceName = "498 - Tepig",
                    NameKey = "Pokemons_Tepig"
                }
            },
            {
                499,
                new PokemonInfo()
                {
                    ResourceName = "499 - Pignite",
                    NameKey = "Pokemons_Pignite"
                }
            },
            {
                500,
                new PokemonInfo()
                {
                    ResourceName = "500 - Emboar",
                    NameKey = "Pokemons_Emboar"
                }
            },
            {
                501,
                new PokemonInfo()
                {
                    ResourceName = "501 - Oshawott",
                    NameKey = "Pokemons_Oshawott"
                }
            },
            {
                502,
                new PokemonInfo()
                {
                    ResourceName = "502 - Dewott",
                    NameKey = "Pokemons_Dewott"
                }
            },
            {
                503,
                new PokemonInfo()
                {
                    ResourceName = "503 - Samurott",
                    NameKey = "Pokemons_Samurott"
                }
            },
            {
                504,
                new PokemonInfo()
                {
                    ResourceName = "504 - Patrat",
                    NameKey = "Pokemons_Patrat"
                }
            },
            {
                505,
                new PokemonInfo()
                {
                    ResourceName = "505 - Watchog",
                    NameKey = "Pokemons_Watchog"
                }
            },
            {
                506,
                new PokemonInfo()
                {
                    ResourceName = "506 - Lillipup",
                    NameKey = "Pokemons_Lillipup"
                }
            },
            {
                507,
                new PokemonInfo()
                {
                    ResourceName = "507 - Herdier",
                    NameKey = "Pokemons_Herdier"
                }
            },
            {
                508,
                new PokemonInfo()
                {
                    ResourceName = "508 - Stoutland",
                    NameKey = "Pokemons_Stoutland"
                }
            },
            {
                509,
                new PokemonInfo()
                {
                    ResourceName = "509 - Purrloin",
                    NameKey = "Pokemons_Purrloin"
                }
            },
            {
                510,
                new PokemonInfo()
                {
                    ResourceName = "510 - Liepard",
                    NameKey = "Pokemons_Liepard"
                }
            },
            {
                511,
                new PokemonInfo()
                {
                    ResourceName = "511 - Pansage",
                    NameKey = "Pokemons_Pansage"
                }
            },
            {
                512,
                new PokemonInfo()
                {
                    ResourceName = "512 - Simisage",
                    NameKey = "Pokemons_Simisage"
                }
            },
            {
                513,
                new PokemonInfo()
                {
                    ResourceName = "513 - Pansear",
                    NameKey = "Pokemons_Pansear"
                }
            },
            {
                514,
                new PokemonInfo()
                {
                    ResourceName = "514 - Simisear",
                    NameKey = "Pokemons_Simisear"
                }
            },
            {
                515,
                new PokemonInfo()
                {
                    ResourceName = "515 - Panpour",
                    NameKey = "Pokemons_Panpour"
                }
            },
            {
                516,
                new PokemonInfo()
                {
                    ResourceName = "516 - Simipour",
                    NameKey = "Pokemons_Simipour"
                }
            },
            {
                517,
                new PokemonInfo()
                {
                    ResourceName = "517 - Munna",
                    NameKey = "Pokemons_Munna"
                }
            },
            {
                518,
                new PokemonInfo()
                {
                    ResourceName = "518 - Musharna",
                    NameKey = "Pokemons_Musharna"
                }
            },
            {
                519,
                new PokemonInfo()
                {
                    ResourceName = "519 - Pidove",
                    NameKey = "Pokemons_Pidove"
                }
            },
            {
                520,
                new PokemonInfo()
                {
                    ResourceName = "520 - Tranquill",
                    NameKey = "Pokemons_Tranquill"
                }
            },
            {
                521,
                new PokemonInfo()
                {
                    ResourceName = "521 - Unfezant",
                    NameKey = "Pokemons_Unfezant"
                }
            },
            {
                522,
                new PokemonInfo()
                {
                    ResourceName = "522 - Blitzle",
                    NameKey = "Pokemons_Blitzle"
                }
            },
            {
                523,
                new PokemonInfo()
                {
                    ResourceName = "523 - Zebstrika",
                    NameKey = "Pokemons_Zebstrika"
                }
            },
            {
                524,
                new PokemonInfo()
                {
                    ResourceName = "524 - Roggenrola",
                    NameKey = "Pokemons_Roggenrola"
                }
            },
            {
                525,
                new PokemonInfo()
                {
                    ResourceName = "525 - Boldore",
                    NameKey = "Pokemons_Boldore"
                }
            },
            {
                526,
                new PokemonInfo()
                {
                    ResourceName = "526 - Gigalith",
                    NameKey = "Pokemons_Gigalith"
                }
            },
            {
                527,
                new PokemonInfo()
                {
                    ResourceName = "527 - Woobat",
                    NameKey = "Pokemons_Woobat"
                }
            },
            {
                528,
                new PokemonInfo()
                {
                    ResourceName = "528 - Swoobat",
                    NameKey = "Pokemons_Swoobat"
                }
            },
            {
                529,
                new PokemonInfo()
                {
                    ResourceName = "529 - Drilbur",
                    NameKey = "Pokemons_Drilbur"
                }
            },
            {
                530,
                new PokemonInfo()
                {
                    ResourceName = "530 - Excadrill",
                    NameKey = "Pokemons_Excadrill"
                }
            },
            {
                531,
                new PokemonInfo()
                {
                    ResourceName = "531 - Audino",
                    NameKey = "Pokemons_Audino"
                }
            },
            {
                532,
                new PokemonInfo()
                {
                    ResourceName = "532 - Timburr",
                    NameKey = "Pokemons_Timburr"
                }
            },
            {
                533,
                new PokemonInfo()
                {
                    ResourceName = "533 - Gurdurr",
                    NameKey = "Pokemons_Gurdurr"
                }
            },
            {
                534,
                new PokemonInfo()
                {
                    ResourceName = "534 - Conkeldurr",
                    NameKey = "Pokemons_Conkeldurr"
                }
            },
            {
                535,
                new PokemonInfo()
                {
                    ResourceName = "535 - Tympole",
                    NameKey = "Pokemons_Tympole"
                }
            },
            {
                536,
                new PokemonInfo()
                {
                    ResourceName = "536 - Palpitoad",
                    NameKey = "Pokemons_Palpitoad"
                }
            },
            {
                537,
                new PokemonInfo()
                {
                    ResourceName = "537 - Seismitoad",
                    NameKey = "Pokemons_Seismitoad"
                }
            },
            {
                538,
                new PokemonInfo()
                {
                    ResourceName = "538 - Throh",
                    NameKey = "Pokemons_Throh"
                }
            },
            {
                539,
                new PokemonInfo()
                {
                    ResourceName = "539 - Sawk",
                    NameKey = "Pokemons_Sawk"
                }
            },
            {
                540,
                new PokemonInfo()
                {
                    ResourceName = "540 - Sewaddle",
                    NameKey = "Pokemons_Sewaddle"
                }
            },
            {
                541,
                new PokemonInfo()
                {
                    ResourceName = "541 - Swadloon",
                    NameKey = "Pokemons_Swadloon"
                }
            },
            {
                542,
                new PokemonInfo()
                {
                    ResourceName = "542 - Leavanny",
                    NameKey = "Pokemons_Leavanny"
                }
            },
            {
                543,
                new PokemonInfo()
                {
                    ResourceName = "543 - Venipede",
                    NameKey = "Pokemons_Venipede"
                }
            },
            {
                544,
                new PokemonInfo()
                {
                    ResourceName = "544 - Whirlipede",
                    NameKey = "Pokemons_Whirlipede"
                }
            },
            {
                545,
                new PokemonInfo()
                {
                    ResourceName = "545 - Scolipede",
                    NameKey = "Pokemons_Scolipede"
                }
            },
            {
                546,
                new PokemonInfo()
                {
                    ResourceName = "546 - Cottonee",
                    NameKey = "Pokemons_Cottonee"
                }
            },
            {
                547,
                new PokemonInfo()
                {
                    ResourceName = "547 - Whimsicott",
                    NameKey = "Pokemons_Whimsicott"
                }
            },
            {
                548,
                new PokemonInfo()
                {
                    ResourceName = "548 - Petilil",
                    NameKey = "Pokemons_Petilil"
                }
            },
            {
                549,
                new PokemonInfo()
                {
                    ResourceName = "549 - Lilligant",
                    NameKey = "Pokemons_Lilligant"
                }
            },
            {
                550,
                new PokemonInfo()
                {
                    ResourceName = "550 - Basculin",
                    NameKey = "Pokemons_Basculin"
                }
            },
            {
                551,
                new PokemonInfo()
                {
                    ResourceName = "551 - Sandile",
                    NameKey = "Pokemons_Sandile"
                }
            },
            {
                552,
                new PokemonInfo()
                {
                    ResourceName = "552 - Krokorok",
                    NameKey = "Pokemons_Krokorok"
                }
            },
            {
                553,
                new PokemonInfo()
                {
                    ResourceName = "553 - Krookodile",
                    NameKey = "Pokemons_Krookodile"
                }
            },
            {
                554,
                new PokemonInfo()
                {
                    ResourceName = "554 - Darumaka",
                    NameKey = "Pokemons_Darumaka"
                }
            },
            {
                555,
                new PokemonInfo()
                {
                    ResourceName = "555 - Darmanitan",
                    NameKey = "Pokemons_Darmanitan"
                }
            },
            {
                556,
                new PokemonInfo()
                {
                    ResourceName = "556 - Maractus",
                    NameKey = "Pokemons_Maractus"
                }
            },
            {
                557,
                new PokemonInfo()
                {
                    ResourceName = "557 - Dwebble",
                    NameKey = "Pokemons_Dwebble"
                }
            },
            {
                558,
                new PokemonInfo()
                {
                    ResourceName = "558 - Crustle",
                    NameKey = "Pokemons_Crustle"
                }
            },
            {
                559,
                new PokemonInfo()
                {
                    ResourceName = "559 - Scraggy",
                    NameKey = "Pokemons_Scraggy"
                }
            },
            {
                560,
                new PokemonInfo()
                {
                    ResourceName = "560 - Scrafty",
                    NameKey = "Pokemons_Scrafty"
                }
            },
            {
                561,
                new PokemonInfo()
                {
                    ResourceName = "561 - Sigilyph",
                    NameKey = "Pokemons_Sigilyph"
                }
            },
            {
                562,
                new PokemonInfo()
                {
                    ResourceName = "562 - Yamask",
                    NameKey = "Pokemons_Yamask"
                }
            },
            {
                563,
                new PokemonInfo()
                {
                    ResourceName = "563 - Cofagrigus",
                    NameKey = "Pokemons_Cofagrigus"
                }
            },
            {
                564,
                new PokemonInfo()
                {
                    ResourceName = "564 - Tirtouga",
                    NameKey = "Pokemons_Tirtouga"
                }
            },
            {
                565,
                new PokemonInfo()
                {
                    ResourceName = "565 - Carracosta",
                    NameKey = "Pokemons_Carracosta"
                }
            },
            {
                566,
                new PokemonInfo()
                {
                    ResourceName = "566 - Archen",
                    NameKey = "Pokemons_Archen"
                }
            },
            {
                567,
                new PokemonInfo()
                {
                    ResourceName = "567 - Archeops",
                    NameKey = "Pokemons_Archeops"
                }
            },
            {
                568,
                new PokemonInfo()
                {
                    ResourceName = "568 - Trubbish",
                    NameKey = "Pokemons_Trubbish"
                }
            },
            {
                569,
                new PokemonInfo()
                {
                    ResourceName = "569 - Garbodor",
                    NameKey = "Pokemons_Garbodor"
                }
            },
            {
                570,
                new PokemonInfo()
                {
                    ResourceName = "570 - Zorua",
                    NameKey = "Pokemons_Zorua"
                }
            },
            {
                571,
                new PokemonInfo()
                {
                    ResourceName = "571 - Zoroark",
                    NameKey = "Pokemons_Zoroark"
                }
            },
            {
                572,
                new PokemonInfo()
                {
                    ResourceName = "572 - Minccino",
                    NameKey = "Pokemons_Minccino"
                }
            },
            {
                573,
                new PokemonInfo()
                {
                    ResourceName = "573 - Cinccino",
                    NameKey = "Pokemons_Cinccino"
                }
            },
            {
                574,
                new PokemonInfo()
                {
                    ResourceName = "574 - Gothita",
                    NameKey = "Pokemons_Gothita"
                }
            },
            {
                575,
                new PokemonInfo()
                {
                    ResourceName = "575 - Gothorita",
                    NameKey = "Pokemons_Gothorita"
                }
            },
            {
                576,
                new PokemonInfo()
                {
                    ResourceName = "576 - Gothitelle",
                    NameKey = "Pokemons_Gothitelle"
                }
            },
            {
                577,
                new PokemonInfo()
                {
                    ResourceName = "577 - Solosis",
                    NameKey = "Pokemons_Solosis"
                }
            },
            {
                578,
                new PokemonInfo()
                {
                    ResourceName = "578 - Duosion",
                    NameKey = "Pokemons_Duosion"
                }
            },
            {
                579,
                new PokemonInfo()
                {
                    ResourceName = "579 - Reuniclus",
                    NameKey = "Pokemons_Reuniclus"
                }
            },
            {
                580,
                new PokemonInfo()
                {
                    ResourceName = "580 - Ducklett",
                    NameKey = "Pokemons_Ducklett"
                }
            },
            {
                581,
                new PokemonInfo()
                {
                    ResourceName = "581 - Swanna",
                    NameKey = "Pokemons_Swanna"
                }
            },
            {
                582,
                new PokemonInfo()
                {
                    ResourceName = "582 - Vanillite",
                    NameKey = "Pokemons_Vanillite"
                }
            },
            {
                583,
                new PokemonInfo()
                {
                    ResourceName = "583 - Vanillish",
                    NameKey = "Pokemons_Vanillish"
                }
            },
            {
                584,
                new PokemonInfo()
                {
                    ResourceName = "584 - Vanilluxe",
                    NameKey = "Pokemons_Vanilluxe"
                }
            },
            {
                585,
                new PokemonInfo()
                {
                    ResourceName = "585 - Deerling",
                    NameKey = "Pokemons_Deerling"
                }
            },
            {
                586,
                new PokemonInfo()
                {
                    ResourceName = "586 - Sawsbuck",
                    NameKey = "Pokemons_Sawsbuck"
                }
            },
            {
                587,
                new PokemonInfo()
                {
                    ResourceName = "587 - Emolga",
                    NameKey = "Pokemons_Emolga"
                }
            },
            {
                588,
                new PokemonInfo()
                {
                    ResourceName = "588 - Karrablast",
                    NameKey = "Pokemons_Karrablast"
                }
            },
            {
                589,
                new PokemonInfo()
                {
                    ResourceName = "589 - Escavalier",
                    NameKey = "Pokemons_Escavalier"
                }
            },
            {
                590,
                new PokemonInfo()
                {
                    ResourceName = "590 - Foongus",
                    NameKey = "Pokemons_Foongus"
                }
            },
            {
                591,
                new PokemonInfo()
                {
                    ResourceName = "591 - Amoonguss",
                    NameKey = "Pokemons_Amoonguss"
                }
            },
            {
                592,
                new PokemonInfo()
                {
                    ResourceName = "592 - Frillish",
                    NameKey = "Pokemons_Frillish"
                }
            },
            {
                593,
                new PokemonInfo()
                {
                    ResourceName = "593 - Jellicent",
                    NameKey = "Pokemons_Jellicent"
                }
            },
            {
                594,
                new PokemonInfo()
                {
                    ResourceName = "594 - Alomomola",
                    NameKey = "Pokemons_Alomomola"
                }
            },
            {
                595,
                new PokemonInfo()
                {
                    ResourceName = "595 - Joltik",
                    NameKey = "Pokemons_Joltik"
                }
            },
            {
                596,
                new PokemonInfo()
                {
                    ResourceName = "596 - Galvantula",
                    NameKey = "Pokemons_Galvantula"
                }
            },
            {
                597,
                new PokemonInfo()
                {
                    ResourceName = "597 - Ferroseed",
                    NameKey = "Pokemons_Ferroseed"
                }
            },
            {
                598,
                new PokemonInfo()
                {
                    ResourceName = "598 - Ferrothorn",
                    NameKey = "Pokemons_Ferrothorn"
                }
            },
            {
                599,
                new PokemonInfo()
                {
                    ResourceName = "599 - Klink",
                    NameKey = "Pokemons_Klink"
                }
            },
            {
                600,
                new PokemonInfo()
                {
                    ResourceName = "600 - Klang",
                    NameKey = "Pokemons_Klang"
                }
            },
            {
                601,
                new PokemonInfo()
                {
                    ResourceName = "601 - Klinklang",
                    NameKey = "Pokemons_Klinklang"
                }
            },
            {
                602,
                new PokemonInfo()
                {
                    ResourceName = "602 - Tynamo",
                    NameKey = "Pokemons_Tynamo"
                }
            },
            {
                603,
                new PokemonInfo()
                {
                    ResourceName = "603 - Eelektrik",
                    NameKey = "Pokemons_Eelektrik"
                }
            },
            {
                604,
                new PokemonInfo()
                {
                    ResourceName = "604 - Eelektross",
                    NameKey = "Pokemons_Eelektross"
                }
            },
            {
                605,
                new PokemonInfo()
                {
                    ResourceName = "605 - Elgyem",
                    NameKey = "Pokemons_Elgyem"
                }
            },
            {
                606,
                new PokemonInfo()
                {
                    ResourceName = "606 - Beheeyem",
                    NameKey = "Pokemons_Beheeyem"
                }
            },
            {
                607,
                new PokemonInfo()
                {
                    ResourceName = "607 - Litwick",
                    NameKey = "Pokemons_Litwick"
                }
            },
            {
                608,
                new PokemonInfo()
                {
                    ResourceName = "608 - Lampent",
                    NameKey = "Pokemons_Lampent"
                }
            },
            {
                609,
                new PokemonInfo()
                {
                    ResourceName = "609 - Chandelure",
                    NameKey = "Pokemons_Chandelure"
                }
            },
            {
                610,
                new PokemonInfo()
                {
                    ResourceName = "610 - Axew",
                    NameKey = "Pokemons_Axew"
                }
            },
            {
                611,
                new PokemonInfo()
                {
                    ResourceName = "611 - Fraxure",
                    NameKey = "Pokemons_Fraxure"
                }
            },
            {
                612,
                new PokemonInfo()
                {
                    ResourceName = "612 - Haxorus",
                    NameKey = "Pokemons_Haxorus"
                }
            },
            {
                613,
                new PokemonInfo()
                {
                    ResourceName = "613 - Cubchoo",
                    NameKey = "Pokemons_Cubchoo"
                }
            },
            {
                614,
                new PokemonInfo()
                {
                    ResourceName = "614 - Beartic",
                    NameKey = "Pokemons_Beartic"
                }
            },
            {
                615,
                new PokemonInfo()
                {
                    ResourceName = "615 - Cryogonal",
                    NameKey = "Pokemons_Cryogonal"
                }
            },
            {
                616,
                new PokemonInfo()
                {
                    ResourceName = "616 - Shelmet",
                    NameKey = "Pokemons_Shelmet"
                }
            },
            {
                617,
                new PokemonInfo()
                {
                    ResourceName = "617 - Accelgor",
                    NameKey = "Pokemons_Accelgor"
                }
            },
            {
                618,
                new PokemonInfo()
                {
                    ResourceName = "618 - Stunfisk",
                    NameKey = "Pokemons_Stunfisk"
                }
            },
            {
                619,
                new PokemonInfo()
                {
                    ResourceName = "619 - Mienfoo",
                    NameKey = "Pokemons_Mienfoo"
                }
            },
            {
                620,
                new PokemonInfo()
                {
                    ResourceName = "620 - Mienshao",
                    NameKey = "Pokemons_Mienshao"
                }
            },
            {
                621,
                new PokemonInfo()
                {
                    ResourceName = "621 - Druddigon",
                    NameKey = "Pokemons_Druddigon"
                }
            },
            {
                622,
                new PokemonInfo()
                {
                    ResourceName = "622 - Golett",
                    NameKey = "Pokemons_Golett"
                }
            },
            {
                623,
                new PokemonInfo()
                {
                    ResourceName = "623 - Golurk",
                    NameKey = "Pokemons_Golurk"
                }
            },
            {
                624,
                new PokemonInfo()
                {
                    ResourceName = "624 - Pawniard",
                    NameKey = "Pokemons_Pawniard"
                }
            },
            {
                625,
                new PokemonInfo()
                {
                    ResourceName = "625 - Bisharp",
                    NameKey = "Pokemons_Bisharp"
                }
            },
            {
                626,
                new PokemonInfo()
                {
                    ResourceName = "626 - Bouffalant",
                    NameKey = "Pokemons_Bouffalant"
                }
            },
            {
                627,
                new PokemonInfo()
                {
                    ResourceName = "627 - Rufflet",
                    NameKey = "Pokemons_Rufflet"
                }
            },
            {
                628,
                new PokemonInfo()
                {
                    ResourceName = "628 - Braviary",
                    NameKey = "Pokemons_Braviary"
                }
            },
            {
                629,
                new PokemonInfo()
                {
                    ResourceName = "629 - Vullaby",
                    NameKey = "Pokemons_Vullaby"
                }
            },
            {
                630,
                new PokemonInfo()
                {
                    ResourceName = "630 - Mandibuzz",
                    NameKey = "Pokemons_Mandibuzz"
                }
            },
            {
                631,
                new PokemonInfo()
                {
                    ResourceName = "631 - Heatmor",
                    NameKey = "Pokemons_Heatmor"
                }
            },
            {
                632,
                new PokemonInfo()
                {
                    ResourceName = "632 - Durant",
                    NameKey = "Pokemons_Durant"
                }
            },
            {
                633,
                new PokemonInfo()
                {
                    ResourceName = "633 - Deino",
                    NameKey = "Pokemons_Deino"
                }
            },
            {
                634,
                new PokemonInfo()
                {
                    ResourceName = "634 - Zweilous",
                    NameKey = "Pokemons_Zweilous"
                }
            },
            {
                635,
                new PokemonInfo()
                {
                    ResourceName = "635 - Hydreigon",
                    NameKey = "Pokemons_Hydreigon"
                }
            },
            {
                636,
                new PokemonInfo()
                {
                    ResourceName = "636 - Larvesta",
                    NameKey = "Pokemons_Larvesta"
                }
            },
            {
                637,
                new PokemonInfo()
                {
                    ResourceName = "637 - Volcarona",
                    NameKey = "Pokemons_Volcarona"
                }
            },
            {
                638,
                new PokemonInfo()
                {
                    ResourceName = "638 - Cobalion",
                    NameKey = "Pokemons_Cobalion"
                }
            },
            {
                639,
                new PokemonInfo()
                {
                    ResourceName = "639 - Terrakion",
                    NameKey = "Pokemons_Terrakion"
                }
            },
            {
                640,
                new PokemonInfo()
                {
                    ResourceName = "640 - Virizion",
                    NameKey = "Pokemons_Virizion"
                }
            },
            {
                641,
                new PokemonInfo()
                {
                    ResourceName = "641 - Tornadus",
                    NameKey = "Pokemons_Tornadus"
                }
            },
            {
                642,
                new PokemonInfo()
                {
                    ResourceName = "642 - Thundurus",
                    NameKey = "Pokemons_Thundurus"
                }
            },
            {
                643,
                new PokemonInfo()
                {
                    ResourceName = "643 - Reshiram",
                    NameKey = "Pokemons_Reshiram"
                }
            },
            {
                644,
                new PokemonInfo()
                {
                    ResourceName = "644 - Zekrom",
                    NameKey = "Pokemons_Zekrom"
                }
            },
            {
                645,
                new PokemonInfo()
                {
                    ResourceName = "645 - Landorus",
                    NameKey = "Pokemons_Landorus"
                }
            },
            {
                646,
                new PokemonInfo()
                {
                    ResourceName = "646 - Kyurem",
                    NameKey = "Pokemons_Kyurem"
                }
            },
            {
                647,
                new PokemonInfo()
                {
                    ResourceName = "647 - Keldeo",
                    NameKey = "Pokemons_Keldeo"
                }
            },
            {
                648,
                new PokemonInfo()
                {
                    ResourceName = "648 - Meloetta",
                    NameKey = "Pokemons_Meloetta"
                }
            },
            {
                649,
                new PokemonInfo()
                {
                    ResourceName = "649 - Genesect",
                    NameKey = "Pokemons_Genesect"
                }
            }
        };
	}
}