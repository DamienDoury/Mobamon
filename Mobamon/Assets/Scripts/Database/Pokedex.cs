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
					NameKey = "Pokemons_Bulbasaur",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 49,
						defense = 49,
						specialAttack = 65,
						specialDefense = 65,
						speed = 45
					}
				}
			},
			{
				2,
				new PokemonInfo()
				{
					ResourceName = "002 - Ivysaur",
					NameKey = "Pokemons_Ivysaur",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 62,
						defense = 63,
						specialAttack = 80,
						specialDefense = 80,
						speed = 60
					}
				}
			},
			{
				3,
				new PokemonInfo()
				{
					ResourceName = "003 - Venusaur",
					NameKey = "Pokemons_Venusaur",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 82,
						defense = 83,
						specialAttack = 100,
						specialDefense = 100,
						speed = 80
					}
				}
			},
			{
				4,
				new PokemonInfo()
				{
					ResourceName = "004 - Charmander",
					NameKey = "Pokemons_Charmander",
					Statistics = new Stats()
					{
						hp = 39,
						attack = 52,
						defense = 43,
						specialAttack = 60,
						specialDefense = 50,
						speed = 65
					}
				}
			},
			{
				5,
				new PokemonInfo()
				{
					ResourceName = "005 - Charmeleon",
					NameKey = "Pokemons_Charmeleon",
					Statistics = new Stats()
					{
						hp = 58,
						attack = 64,
						defense = 58,
						specialAttack = 80,
						specialDefense = 65,
						speed = 80
					}
				}
			},
			{
				6,
				new PokemonInfo()
				{
					ResourceName = "006 - Charizard",
					NameKey = "Pokemons_Charizard",
					Statistics = new Stats()
					{
						hp = 78,
						attack = 84,
						defense = 78,
						specialAttack = 109,
						specialDefense = 85,
						speed = 100
					}
				}
			},
			{
				7,
				new PokemonInfo()
				{
					ResourceName = "007 - Squirtle",
					NameKey = "Pokemons_Squirtle",
					Statistics = new Stats()
					{
						hp = 44,
						attack = 48,
						defense = 65,
						specialAttack = 50,
						specialDefense = 64,
						speed = 43
					}
				}
			},
			{
				8,
				new PokemonInfo()
				{
					ResourceName = "008 - Wartortle",
					NameKey = "Pokemons_Wartortle",
					Statistics = new Stats()
					{
						hp = 59,
						attack = 63,
						defense = 80,
						specialAttack = 65,
						specialDefense = 80,
						speed = 58
					}
				}
			},
			{
				9,
				new PokemonInfo()
				{
					ResourceName = "009 - Blastoise",
					NameKey = "Pokemons_Blastoise",
					Statistics = new Stats()
					{
						hp = 79,
						attack = 83,
						defense = 100,
						specialAttack = 85,
						specialDefense = 105,
						speed = 78
					}
				}
			},
			{
				10,
				new PokemonInfo()
				{
					ResourceName = "010 - Caterpie",
					NameKey = "Pokemons_Caterpie",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 30,
						defense = 35,
						specialAttack = 20,
						specialDefense = 20,
						speed = 45
					}
				}
			},
			{
				11,
				new PokemonInfo()
				{
					ResourceName = "011 - Metapod",
					NameKey = "Pokemons_Metapod",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 20,
						defense = 55,
						specialAttack = 25,
						specialDefense = 25,
						speed = 30
					}
				}
			},
			{
				12,
				new PokemonInfo()
				{
					ResourceName = "012 - Butterfree",
					NameKey = "Pokemons_Butterfree",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 45,
						defense = 50,
						specialAttack = 80,
						specialDefense = 80,
						speed = 70
					}
				}
			},
			{
				13,
				new PokemonInfo()
				{
					ResourceName = "013 - Weedle",
					NameKey = "Pokemons_Weedle",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 35,
						defense = 30,
						specialAttack = 20,
						specialDefense = 20,
						speed = 50
					}
				}
			},
			{
				14,
				new PokemonInfo()
				{
					ResourceName = "014 - Kakuna",
					NameKey = "Pokemons_Kakuna",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 25,
						defense = 50,
						specialAttack = 25,
						specialDefense = 25,
						speed = 35
					}
				}
			},
			{
				15,
				new PokemonInfo()
				{
					ResourceName = "015 - Beedrill",
					NameKey = "Pokemons_Beedrill",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 80,
						defense = 40,
						specialAttack = 45,
						specialDefense = 80,
						speed = 75
					}
				}
			},
			{
				16,
				new PokemonInfo()
				{
					ResourceName = "016 - Pidgey",
					NameKey = "Pokemons_Pidgey",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 45,
						defense = 40,
						specialAttack = 35,
						specialDefense = 35,
						speed = 56
					}
				}
			},
			{
				17,
				new PokemonInfo()
				{
					ResourceName = "017 - Pidgeotto",
					NameKey = "Pokemons_Pidgeotto",
					Statistics = new Stats()
					{
						hp = 63,
						attack = 60,
						defense = 55,
						specialAttack = 50,
						specialDefense = 50,
						speed = 71
					}
				}
			},
			{
				18,
				new PokemonInfo()
				{
					ResourceName = "018 - Pidgeot",
					NameKey = "Pokemons_Pidgeot",
					Statistics = new Stats()
					{
						hp = 83,
						attack = 80,
						defense = 75,
						specialAttack = 70,
						specialDefense = 70,
						speed = 91
					}
				}
			},
			{
				19,
				new PokemonInfo()
				{
					ResourceName = "019 - Rattata",
					NameKey = "Pokemons_Rattata",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 56,
						defense = 35,
						specialAttack = 25,
						specialDefense = 35,
						speed = 72
					}
				}
			},
			{
				20,
				new PokemonInfo()
				{
					ResourceName = "020 - Raticate",
					NameKey = "Pokemons_Raticate",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 81,
						defense = 60,
						specialAttack = 50,
						specialDefense = 70,
						speed = 97
					}
				}
			},
			{
				21,
				new PokemonInfo()
				{
					ResourceName = "021 - Spearow",
					NameKey = "Pokemons_Spearow",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 60,
						defense = 30,
						specialAttack = 31,
						specialDefense = 31,
						speed = 70
					}
				}
			},
			{
				22,
				new PokemonInfo()
				{
					ResourceName = "022 - Fearow",
					NameKey = "Pokemons_Fearow",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 90,
						defense = 65,
						specialAttack = 61,
						specialDefense = 61,
						speed = 100
					}
				}
			},
			{
				23,
				new PokemonInfo()
				{
					ResourceName = "023 - Ekans",
					NameKey = "Pokemons_Ekans",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 60,
						defense = 44,
						specialAttack = 40,
						specialDefense = 54,
						speed = 55
					}
				}
			},
			{
				24,
				new PokemonInfo()
				{
					ResourceName = "024 - Arbok",
					NameKey = "Pokemons_Arbok",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 85,
						defense = 69,
						specialAttack = 65,
						specialDefense = 79,
						speed = 80
					}
				}
			},
			{
				25,
				new PokemonInfo()
				{
					ResourceName = "025 - Pikachu",
					NameKey = "Pokemons_Pikachu",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 55,
						defense = 30,
						specialAttack = 50,
						specialDefense = 40,
						speed = 90
					}
				}
			},
			{
				26,
				new PokemonInfo()
				{
					ResourceName = "026 - Raichu",
					NameKey = "Pokemons_Raichu",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 90,
						defense = 55,
						specialAttack = 90,
						specialDefense = 80,
						speed = 100
					}
				}
			},
			{
				27,
				new PokemonInfo()
				{
					ResourceName = "027 - Sandshrew",
					NameKey = "Pokemons_Sandshrew",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 75,
						defense = 85,
						specialAttack = 20,
						specialDefense = 30,
						speed = 40
					}
				}
			},
			{
				28,
				new PokemonInfo()
				{
					ResourceName = "028 - Sandslash",
					NameKey = "Pokemons_Sandslash",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 100,
						defense = 110,
						specialAttack = 45,
						specialDefense = 55,
						speed = 65
					}
				}
			},
			{
				29,
				new PokemonInfo()
				{
					ResourceName = "029 - Nidoran♀",
					NameKey = "Pokemons_Nidoran♀",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 47,
						defense = 52,
						specialAttack = 40,
						specialDefense = 40,
						speed = 41
					}
				}
			},
			{
				30,
				new PokemonInfo()
				{
					ResourceName = "030 - Nidorina",
					NameKey = "Pokemons_Nidorina",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 62,
						defense = 67,
						specialAttack = 55,
						specialDefense = 55,
						speed = 56
					}
				}
			},
			{
				31,
				new PokemonInfo()
				{
					ResourceName = "031 - Nidoqueen",
					NameKey = "Pokemons_Nidoqueen",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 82,
						defense = 87,
						specialAttack = 75,
						specialDefense = 85,
						speed = 76
					}
				}
			},
			{
				32,
				new PokemonInfo()
				{
					ResourceName = "032 - Nidoran♂",
					NameKey = "Pokemons_Nidoran♂",
					Statistics = new Stats()
					{
						hp = 46,
						attack = 57,
						defense = 40,
						specialAttack = 40,
						specialDefense = 40,
						speed = 50
					}
				}
			},
			{
				33,
				new PokemonInfo()
				{
					ResourceName = "033 - Nidorino",
					NameKey = "Pokemons_Nidorino",
					Statistics = new Stats()
					{
						hp = 61,
						attack = 72,
						defense = 57,
						specialAttack = 55,
						specialDefense = 55,
						speed = 65
					}
				}
			},
			{
				34,
				new PokemonInfo()
				{
					ResourceName = "034 - Nidoking",
					NameKey = "Pokemons_Nidoking",
					Statistics = new Stats()
					{
						hp = 81,
						attack = 92,
						defense = 77,
						specialAttack = 85,
						specialDefense = 75,
						speed = 85
					}
				}
			},
			{
				35,
				new PokemonInfo()
				{
					ResourceName = "035 - Clefairy",
					NameKey = "Pokemons_Clefairy",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 45,
						defense = 48,
						specialAttack = 60,
						specialDefense = 65,
						speed = 35
					}
				}
			},
			{
				36,
				new PokemonInfo()
				{
					ResourceName = "036 - Clefable",
					NameKey = "Pokemons_Clefable",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 70,
						defense = 73,
						specialAttack = 85,
						specialDefense = 90,
						speed = 60
					}
				}
			},
			{
				37,
				new PokemonInfo()
				{
					ResourceName = "037 - Vulpix",
					NameKey = "Pokemons_Vulpix",
					Statistics = new Stats()
					{
						hp = 38,
						attack = 41,
						defense = 40,
						specialAttack = 50,
						specialDefense = 65,
						speed = 65
					}
				}
			},
			{
				38,
				new PokemonInfo()
				{
					ResourceName = "038 - Ninetales",
					NameKey = "Pokemons_Ninetales",
					Statistics = new Stats()
					{
						hp = 73,
						attack = 76,
						defense = 75,
						specialAttack = 81,
						specialDefense = 100,
						speed = 100
					}
				}
			},
			{
				39,
				new PokemonInfo()
				{
					ResourceName = "039 - Jigglypuff",
					NameKey = "Pokemons_Jigglypuff",
					Statistics = new Stats()
					{
						hp = 115,
						attack = 45,
						defense = 20,
						specialAttack = 45,
						specialDefense = 25,
						speed = 20
					}
				}
			},
			{
				40,
				new PokemonInfo()
				{
					ResourceName = "040 - Wigglytuff",
					NameKey = "Pokemons_Wigglytuff",
					Statistics = new Stats()
					{
						hp = 140,
						attack = 70,
						defense = 45,
						specialAttack = 75,
						specialDefense = 50,
						speed = 45
					}
				}
			},
			{
				41,
				new PokemonInfo()
				{
					ResourceName = "041 - Zubat",
					NameKey = "Pokemons_Zubat",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 45,
						defense = 35,
						specialAttack = 30,
						specialDefense = 40,
						speed = 55
					}
				}
			},
			{
				42,
				new PokemonInfo()
				{
					ResourceName = "042 - Golbat",
					NameKey = "Pokemons_Golbat",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 80,
						defense = 70,
						specialAttack = 65,
						specialDefense = 75,
						speed = 90
					}
				}
			},
			{
				43,
				new PokemonInfo()
				{
					ResourceName = "043 - Oddish",
					NameKey = "Pokemons_Oddish",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 50,
						defense = 55,
						specialAttack = 75,
						specialDefense = 65,
						speed = 30
					}
				}
			},
			{
				44,
				new PokemonInfo()
				{
					ResourceName = "044 - Gloom",
					NameKey = "Pokemons_Gloom",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 65,
						defense = 70,
						specialAttack = 85,
						specialDefense = 75,
						speed = 40
					}
				}
			},
			{
				45,
				new PokemonInfo()
				{
					ResourceName = "045 - Vileplume",
					NameKey = "Pokemons_Vileplume",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 80,
						defense = 85,
						specialAttack = 100,
						specialDefense = 90,
						speed = 50
					}
				}
			},
			{
				46,
				new PokemonInfo()
				{
					ResourceName = "046 - Paras",
					NameKey = "Pokemons_Paras",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 70,
						defense = 55,
						specialAttack = 45,
						specialDefense = 55,
						speed = 25
					}
				}
			},
			{
				47,
				new PokemonInfo()
				{
					ResourceName = "047 - Parasect",
					NameKey = "Pokemons_Parasect",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 95,
						defense = 80,
						specialAttack = 60,
						specialDefense = 80,
						speed = 30
					}
				}
			},
			{
				48,
				new PokemonInfo()
				{
					ResourceName = "048 - Venonat",
					NameKey = "Pokemons_Venonat",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 55,
						defense = 50,
						specialAttack = 40,
						specialDefense = 55,
						speed = 45
					}
				}
			},
			{
				49,
				new PokemonInfo()
				{
					ResourceName = "049 - Venomoth",
					NameKey = "Pokemons_Venomoth",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 65,
						defense = 60,
						specialAttack = 90,
						specialDefense = 75,
						speed = 90
					}
				}
			},
			{
				50,
				new PokemonInfo()
				{
					ResourceName = "050 - Diglett",
					NameKey = "Pokemons_Diglett",
					Statistics = new Stats()
					{
						hp = 10,
						attack = 55,
						defense = 25,
						specialAttack = 35,
						specialDefense = 45,
						speed = 95
					}
				}
			},
			{
				51,
				new PokemonInfo()
				{
					ResourceName = "051 - Dugtrio",
					NameKey = "Pokemons_Dugtrio",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 80,
						defense = 50,
						specialAttack = 50,
						specialDefense = 70,
						speed = 120
					}
				}
			},
			{
				52,
				new PokemonInfo()
				{
					ResourceName = "052 - Meowth",
					NameKey = "Pokemons_Meowth",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 45,
						defense = 35,
						specialAttack = 40,
						specialDefense = 40,
						speed = 90
					}
				}
			},
			{
				53,
				new PokemonInfo()
				{
					ResourceName = "053 - Persian",
					NameKey = "Pokemons_Persian",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 70,
						defense = 60,
						specialAttack = 65,
						specialDefense = 65,
						speed = 115
					}
				}
			},
			{
				54,
				new PokemonInfo()
				{
					ResourceName = "054 - Psyduck",
					NameKey = "Pokemons_Psyduck",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 52,
						defense = 48,
						specialAttack = 65,
						specialDefense = 50,
						speed = 55
					}
				}
			},
			{
				55,
				new PokemonInfo()
				{
					ResourceName = "055 - Golduck",
					NameKey = "Pokemons_Golduck",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 82,
						defense = 78,
						specialAttack = 95,
						specialDefense = 80,
						speed = 85
					}
				}
			},
			{
				56,
				new PokemonInfo()
				{
					ResourceName = "056 - Mankey",
					NameKey = "Pokemons_Mankey",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 80,
						defense = 35,
						specialAttack = 35,
						specialDefense = 45,
						speed = 70
					}
				}
			},
			{
				57,
				new PokemonInfo()
				{
					ResourceName = "057 - Primeape",
					NameKey = "Pokemons_Primeape",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 105,
						defense = 60,
						specialAttack = 60,
						specialDefense = 70,
						speed = 95
					}
				}
			},
			{
				58,
				new PokemonInfo()
				{
					ResourceName = "058 - Growlithe",
					NameKey = "Pokemons_Growlithe",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 70,
						defense = 45,
						specialAttack = 70,
						specialDefense = 50,
						speed = 60
					}
				}
			},
			{
				59,
				new PokemonInfo()
				{
					ResourceName = "059 - Arcanine",
					NameKey = "Pokemons_Arcanine",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 110,
						defense = 80,
						specialAttack = 100,
						specialDefense = 80,
						speed = 95
					}
				}
			},
			{
				60,
				new PokemonInfo()
				{
					ResourceName = "060 - Poliwag",
					NameKey = "Pokemons_Poliwag",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 50,
						defense = 40,
						specialAttack = 40,
						specialDefense = 40,
						speed = 90
					}
				}
			},
			{
				61,
				new PokemonInfo()
				{
					ResourceName = "061 - Poliwhirl",
					NameKey = "Pokemons_Poliwhirl",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 65,
						defense = 65,
						specialAttack = 50,
						specialDefense = 50,
						speed = 90
					}
				}
			},
			{
				62,
				new PokemonInfo()
				{
					ResourceName = "062 - Poliwrath",
					NameKey = "Pokemons_Poliwrath",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 85,
						defense = 95,
						specialAttack = 70,
						specialDefense = 90,
						speed = 70
					}
				}
			},
			{
				63,
				new PokemonInfo()
				{
					ResourceName = "063 - Abra",
					NameKey = "Pokemons_Abra",
					Statistics = new Stats()
					{
						hp = 25,
						attack = 20,
						defense = 15,
						specialAttack = 105,
						specialDefense = 55,
						speed = 90
					}
				}
			},
			{
				64,
				new PokemonInfo()
				{
					ResourceName = "064 - Kadabra",
					NameKey = "Pokemons_Kadabra",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 35,
						defense = 30,
						specialAttack = 120,
						specialDefense = 70,
						speed = 105
					}
				}
			},
			{
				65,
				new PokemonInfo()
				{
					ResourceName = "065 - Alakazam",
					NameKey = "Pokemons_Alakazam",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 50,
						defense = 45,
						specialAttack = 135,
						specialDefense = 85,
						speed = 120
					}
				}
			},
			{
				66,
				new PokemonInfo()
				{
					ResourceName = "066 - Machop",
					NameKey = "Pokemons_Machop",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 80,
						defense = 50,
						specialAttack = 35,
						specialDefense = 35,
						speed = 35
					}
				}
			},
			{
				67,
				new PokemonInfo()
				{
					ResourceName = "067 - Machoke",
					NameKey = "Pokemons_Machoke",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 100,
						defense = 70,
						specialAttack = 50,
						specialDefense = 60,
						speed = 45
					}
				}
			},
			{
				68,
				new PokemonInfo()
				{
					ResourceName = "068 - Machamp",
					NameKey = "Pokemons_Machamp",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 130,
						defense = 80,
						specialAttack = 65,
						specialDefense = 85,
						speed = 55
					}
				}
			},
			{
				69,
				new PokemonInfo()
				{
					ResourceName = "069 - Bellsprout",
					NameKey = "Pokemons_Bellsprout",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 75,
						defense = 35,
						specialAttack = 70,
						specialDefense = 30,
						speed = 40
					}
				}
			},
			{
				70,
				new PokemonInfo()
				{
					ResourceName = "070 - Weepinbell",
					NameKey = "Pokemons_Weepinbell",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 90,
						defense = 50,
						specialAttack = 85,
						specialDefense = 45,
						speed = 55
					}
				}
			},
			{
				71,
				new PokemonInfo()
				{
					ResourceName = "071 - Victreebel",
					NameKey = "Pokemons_Victreebel",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 105,
						defense = 65,
						specialAttack = 100,
						specialDefense = 60,
						speed = 70
					}
				}
			},
			{
				72,
				new PokemonInfo()
				{
					ResourceName = "072 - Tentacool",
					NameKey = "Pokemons_Tentacool",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 40,
						defense = 35,
						specialAttack = 50,
						specialDefense = 100,
						speed = 70
					}
				}
			},
			{
				73,
				new PokemonInfo()
				{
					ResourceName = "073 - Tentacruel",
					NameKey = "Pokemons_Tentacruel",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 70,
						defense = 65,
						specialAttack = 80,
						specialDefense = 120,
						speed = 100
					}
				}
			},
			{
				74,
				new PokemonInfo()
				{
					ResourceName = "074 - Geodude",
					NameKey = "Pokemons_Geodude",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 80,
						defense = 100,
						specialAttack = 30,
						specialDefense = 30,
						speed = 20
					}
				}
			},
			{
				75,
				new PokemonInfo()
				{
					ResourceName = "075 - Graveler",
					NameKey = "Pokemons_Graveler",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 95,
						defense = 115,
						specialAttack = 45,
						specialDefense = 45,
						speed = 35
					}
				}
			},
			{
				76,
				new PokemonInfo()
				{
					ResourceName = "076 - Golem",
					NameKey = "Pokemons_Golem",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 110,
						defense = 130,
						specialAttack = 55,
						specialDefense = 65,
						speed = 45
					}
				}
			},
			{
				77,
				new PokemonInfo()
				{
					ResourceName = "077 - Ponyta",
					NameKey = "Pokemons_Ponyta",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 85,
						defense = 55,
						specialAttack = 65,
						specialDefense = 65,
						speed = 90
					}
				}
			},
			{
				78,
				new PokemonInfo()
				{
					ResourceName = "078 - Rapidash",
					NameKey = "Pokemons_Rapidash",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 100,
						defense = 70,
						specialAttack = 80,
						specialDefense = 80,
						speed = 105
					}
				}
			},
			{
				79,
				new PokemonInfo()
				{
					ResourceName = "079 - Slowpoke",
					NameKey = "Pokemons_Slowpoke",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 65,
						defense = 65,
						specialAttack = 40,
						specialDefense = 40,
						speed = 15
					}
				}
			},
			{
				80,
				new PokemonInfo()
				{
					ResourceName = "080 - Slowbro",
					NameKey = "Pokemons_Slowbro",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 75,
						defense = 110,
						specialAttack = 100,
						specialDefense = 80,
						speed = 30
					}
				}
			},
			{
				81,
				new PokemonInfo()
				{
					ResourceName = "081 - Magnemite",
					NameKey = "Pokemons_Magnemite",
					Statistics = new Stats()
					{
						hp = 25,
						attack = 35,
						defense = 70,
						specialAttack = 95,
						specialDefense = 55,
						speed = 45
					}
				}
			},
			{
				82,
				new PokemonInfo()
				{
					ResourceName = "082 - Magneton",
					NameKey = "Pokemons_Magneton",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 60,
						defense = 95,
						specialAttack = 120,
						specialDefense = 70,
						speed = 70
					}
				}
			},
			{
				83,
				new PokemonInfo()
				{
					ResourceName = "083 - Farfetch'd",
					NameKey = "Pokemons_Farfetch'd",
					Statistics = new Stats()
					{
						hp = 52,
						attack = 65,
						defense = 55,
						specialAttack = 58,
						specialDefense = 62,
						speed = 60
					}
				}
			},
			{
				84,
				new PokemonInfo()
				{
					ResourceName = "084 - Doduo",
					NameKey = "Pokemons_Doduo",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 85,
						defense = 45,
						specialAttack = 35,
						specialDefense = 35,
						speed = 75
					}
				}
			},
			{
				85,
				new PokemonInfo()
				{
					ResourceName = "085 - Dodrio",
					NameKey = "Pokemons_Dodrio",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 110,
						defense = 70,
						specialAttack = 60,
						specialDefense = 60,
						speed = 100
					}
				}
			},
			{
				86,
				new PokemonInfo()
				{
					ResourceName = "086 - Seel",
					NameKey = "Pokemons_Seel",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 45,
						defense = 55,
						specialAttack = 45,
						specialDefense = 70,
						speed = 45
					}
				}
			},
			{
				87,
				new PokemonInfo()
				{
					ResourceName = "087 - Dewgong",
					NameKey = "Pokemons_Dewgong",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 70,
						defense = 80,
						specialAttack = 70,
						specialDefense = 95,
						speed = 70
					}
				}
			},
			{
				88,
				new PokemonInfo()
				{
					ResourceName = "088 - Grimer",
					NameKey = "Pokemons_Grimer",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 80,
						defense = 50,
						specialAttack = 40,
						specialDefense = 50,
						speed = 25
					}
				}
			},
			{
				89,
				new PokemonInfo()
				{
					ResourceName = "089 - Muk",
					NameKey = "Pokemons_Muk",
					Statistics = new Stats()
					{
						hp = 105,
						attack = 105,
						defense = 75,
						specialAttack = 65,
						specialDefense = 100,
						speed = 50
					}
				}
			},
			{
				90,
				new PokemonInfo()
				{
					ResourceName = "090 - Shellder",
					NameKey = "Pokemons_Shellder",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 65,
						defense = 100,
						specialAttack = 45,
						specialDefense = 25,
						speed = 40
					}
				}
			},
			{
				91,
				new PokemonInfo()
				{
					ResourceName = "091 - Cloyster",
					NameKey = "Pokemons_Cloyster",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 95,
						defense = 180,
						specialAttack = 85,
						specialDefense = 45,
						speed = 70
					}
				}
			},
			{
				92,
				new PokemonInfo()
				{
					ResourceName = "092 - Gastly",
					NameKey = "Pokemons_Gastly",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 35,
						defense = 30,
						specialAttack = 100,
						specialDefense = 35,
						speed = 80
					}
				}
			},
			{
				93,
				new PokemonInfo()
				{
					ResourceName = "093 - Haunter",
					NameKey = "Pokemons_Haunter",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 50,
						defense = 45,
						specialAttack = 115,
						specialDefense = 55,
						speed = 95
					}
				}
			},
			{
				94,
				new PokemonInfo()
				{
					ResourceName = "094 - Gengar",
					NameKey = "Pokemons_Gengar",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 65,
						defense = 60,
						specialAttack = 130,
						specialDefense = 75,
						speed = 110
					}
				}
			},
			{
				95,
				new PokemonInfo()
				{
					ResourceName = "095 - Onix",
					NameKey = "Pokemons_Onix",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 45,
						defense = 160,
						specialAttack = 30,
						specialDefense = 45,
						speed = 70
					}
				}
			},
			{
				96,
				new PokemonInfo()
				{
					ResourceName = "096 - Drowzee",
					NameKey = "Pokemons_Drowzee",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 48,
						defense = 45,
						specialAttack = 43,
						specialDefense = 90,
						speed = 42
					}
				}
			},
			{
				97,
				new PokemonInfo()
				{
					ResourceName = "097 - Hypno",
					NameKey = "Pokemons_Hypno",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 73,
						defense = 70,
						specialAttack = 73,
						specialDefense = 115,
						speed = 67
					}
				}
			},
			{
				98,
				new PokemonInfo()
				{
					ResourceName = "098 - Krabby",
					NameKey = "Pokemons_Krabby",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 105,
						defense = 90,
						specialAttack = 25,
						specialDefense = 25,
						speed = 50
					}
				}
			},
			{
				99,
				new PokemonInfo()
				{
					ResourceName = "099 - Kingler",
					NameKey = "Pokemons_Kingler",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 130,
						defense = 115,
						specialAttack = 50,
						specialDefense = 50,
						speed = 75
					}
				}
			},
			{
				100,
				new PokemonInfo()
				{
					ResourceName = "100 - Voltorb",
					NameKey = "Pokemons_Voltorb",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 30,
						defense = 50,
						specialAttack = 55,
						specialDefense = 55,
						speed = 100
					}
				}
			},
			{
				101,
				new PokemonInfo()
				{
					ResourceName = "101 - Electrode",
					NameKey = "Pokemons_Electrode",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 50,
						defense = 70,
						specialAttack = 80,
						specialDefense = 80,
						speed = 140
					}
				}
			},
			{
				102,
				new PokemonInfo()
				{
					ResourceName = "102 - Exeggcute",
					NameKey = "Pokemons_Exeggcute",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 40,
						defense = 80,
						specialAttack = 60,
						specialDefense = 45,
						speed = 40
					}
				}
			},
			{
				103,
				new PokemonInfo()
				{
					ResourceName = "103 - Exeggutor",
					NameKey = "Pokemons_Exeggutor",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 95,
						defense = 85,
						specialAttack = 125,
						specialDefense = 65,
						speed = 55
					}
				}
			},
			{
				104,
				new PokemonInfo()
				{
					ResourceName = "104 - Cubone",
					NameKey = "Pokemons_Cubone",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 50,
						defense = 95,
						specialAttack = 40,
						specialDefense = 50,
						speed = 35
					}
				}
			},
			{
				105,
				new PokemonInfo()
				{
					ResourceName = "105 - Marowak",
					NameKey = "Pokemons_Marowak",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 80,
						defense = 110,
						specialAttack = 50,
						specialDefense = 80,
						speed = 45
					}
				}
			},
			{
				106,
				new PokemonInfo()
				{
					ResourceName = "106 - Hitmonlee",
					NameKey = "Pokemons_Hitmonlee",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 120,
						defense = 53,
						specialAttack = 35,
						specialDefense = 110,
						speed = 87
					}
				}
			},
			{
				107,
				new PokemonInfo()
				{
					ResourceName = "107 - Hitmonchan",
					NameKey = "Pokemons_Hitmonchan",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 105,
						defense = 79,
						specialAttack = 35,
						specialDefense = 110,
						speed = 76
					}
				}
			},
			{
				108,
				new PokemonInfo()
				{
					ResourceName = "108 - Lickitung",
					NameKey = "Pokemons_Lickitung",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 55,
						defense = 75,
						specialAttack = 60,
						specialDefense = 75,
						speed = 30
					}
				}
			},
			{
				109,
				new PokemonInfo()
				{
					ResourceName = "109 - Koffing",
					NameKey = "Pokemons_Koffing",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 65,
						defense = 95,
						specialAttack = 60,
						specialDefense = 45,
						speed = 35
					}
				}
			},
			{
				110,
				new PokemonInfo()
				{
					ResourceName = "110 - Weezing",
					NameKey = "Pokemons_Weezing",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 90,
						defense = 120,
						specialAttack = 85,
						specialDefense = 70,
						speed = 60
					}
				}
			},
			{
				111,
				new PokemonInfo()
				{
					ResourceName = "111 - Rhyhorn",
					NameKey = "Pokemons_Rhyhorn",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 85,
						defense = 95,
						specialAttack = 30,
						specialDefense = 30,
						speed = 25
					}
				}
			},
			{
				112,
				new PokemonInfo()
				{
					ResourceName = "112 - Rhydon",
					NameKey = "Pokemons_Rhydon",
					Statistics = new Stats()
					{
						hp = 105,
						attack = 130,
						defense = 120,
						specialAttack = 45,
						specialDefense = 45,
						speed = 40
					}
				}
			},
			{
				113,
				new PokemonInfo()
				{
					ResourceName = "113 - Chansey",
					NameKey = "Pokemons_Chansey",
					Statistics = new Stats()
					{
						hp = 250,
						attack = 5,
						defense = 5,
						specialAttack = 35,
						specialDefense = 105,
						speed = 50
					}
				}
			},
			{
				114,
				new PokemonInfo()
				{
					ResourceName = "114 - Tangela",
					NameKey = "Pokemons_Tangela",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 55,
						defense = 115,
						specialAttack = 100,
						specialDefense = 40,
						speed = 60
					}
				}
			},
			{
				115,
				new PokemonInfo()
				{
					ResourceName = "115 - Kangaskhan",
					NameKey = "Pokemons_Kangaskhan",
					Statistics = new Stats()
					{
						hp = 105,
						attack = 95,
						defense = 80,
						specialAttack = 40,
						specialDefense = 80,
						speed = 90
					}
				}
			},
			{
				116,
				new PokemonInfo()
				{
					ResourceName = "116 - Horsea",
					NameKey = "Pokemons_Horsea",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 40,
						defense = 70,
						specialAttack = 70,
						specialDefense = 25,
						speed = 60
					}
				}
			},
			{
				117,
				new PokemonInfo()
				{
					ResourceName = "117 - Seadra",
					NameKey = "Pokemons_Seadra",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 65,
						defense = 95,
						specialAttack = 95,
						specialDefense = 45,
						speed = 85
					}
				}
			},
			{
				118,
				new PokemonInfo()
				{
					ResourceName = "118 - Goldeen",
					NameKey = "Pokemons_Goldeen",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 67,
						defense = 60,
						specialAttack = 35,
						specialDefense = 50,
						speed = 63
					}
				}
			},
			{
				119,
				new PokemonInfo()
				{
					ResourceName = "119 - Seaking",
					NameKey = "Pokemons_Seaking",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 92,
						defense = 65,
						specialAttack = 65,
						specialDefense = 80,
						speed = 68
					}
				}
			},
			{
				120,
				new PokemonInfo()
				{
					ResourceName = "120 - Staryu",
					NameKey = "Pokemons_Staryu",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 45,
						defense = 55,
						specialAttack = 70,
						specialDefense = 55,
						speed = 85
					}
				}
			},
			{
				121,
				new PokemonInfo()
				{
					ResourceName = "121 - Starmie",
					NameKey = "Pokemons_Starmie",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 75,
						defense = 85,
						specialAttack = 100,
						specialDefense = 85,
						speed = 115
					}
				}
			},
			{
				122,
				new PokemonInfo()
				{
					ResourceName = "122 - Mr. Mime",
					NameKey = "Pokemons_Mr. Mime",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 45,
						defense = 65,
						specialAttack = 100,
						specialDefense = 120,
						speed = 90
					}
				}
			},
			{
				123,
				new PokemonInfo()
				{
					ResourceName = "123 - Scyther",
					NameKey = "Pokemons_Scyther",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 110,
						defense = 80,
						specialAttack = 55,
						specialDefense = 80,
						speed = 105
					}
				}
			},
			{
				124,
				new PokemonInfo()
				{
					ResourceName = "124 - Jynx",
					NameKey = "Pokemons_Jynx",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 50,
						defense = 35,
						specialAttack = 115,
						specialDefense = 95,
						speed = 95
					}
				}
			},
			{
				125,
				new PokemonInfo()
				{
					ResourceName = "125 - Electabuzz",
					NameKey = "Pokemons_Electabuzz",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 83,
						defense = 57,
						specialAttack = 95,
						specialDefense = 85,
						speed = 105
					}
				}
			},
			{
				126,
				new PokemonInfo()
				{
					ResourceName = "126 - Magmar",
					NameKey = "Pokemons_Magmar",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 95,
						defense = 57,
						specialAttack = 100,
						specialDefense = 85,
						speed = 93
					}
				}
			},
			{
				127,
				new PokemonInfo()
				{
					ResourceName = "127 - Pinsir",
					NameKey = "Pokemons_Pinsir",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 125,
						defense = 100,
						specialAttack = 55,
						specialDefense = 70,
						speed = 85
					}
				}
			},
			{
				128,
				new PokemonInfo()
				{
					ResourceName = "128 - Tauros",
					NameKey = "Pokemons_Tauros",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 100,
						defense = 95,
						specialAttack = 40,
						specialDefense = 70,
						speed = 110
					}
				}
			},
			{
				129,
				new PokemonInfo()
				{
					ResourceName = "129 - Magikarp",
					NameKey = "Pokemons_Magikarp",
					Statistics = new Stats()
					{
						hp = 20,
						attack = 10,
						defense = 55,
						specialAttack = 15,
						specialDefense = 20,
						speed = 80
					}
				}
			},
			{
				130,
				new PokemonInfo()
				{
					ResourceName = "130 - Gyarados",
					NameKey = "Pokemons_Gyarados",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 125,
						defense = 79,
						specialAttack = 60,
						specialDefense = 100,
						speed = 81
					}
				}
			},
			{
				131,
				new PokemonInfo()
				{
					ResourceName = "131 - Lapras",
					NameKey = "Pokemons_Lapras",
					Statistics = new Stats()
					{
						hp = 130,
						attack = 85,
						defense = 80,
						specialAttack = 85,
						specialDefense = 95,
						speed = 60
					}
				}
			},
			{
				132,
				new PokemonInfo()
				{
					ResourceName = "132 - Ditto",
					NameKey = "Pokemons_Ditto",
					Statistics = new Stats()
					{
						hp = 48,
						attack = 48,
						defense = 48,
						specialAttack = 48,
						specialDefense = 48,
						speed = 48
					}
				}
			},
			{
				133,
				new PokemonInfo()
				{
					ResourceName = "133 - Eevee",
					NameKey = "Pokemons_Eevee",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 55,
						defense = 50,
						specialAttack = 45,
						specialDefense = 65,
						speed = 55
					}
				}
			},
			{
				134,
				new PokemonInfo()
				{
					ResourceName = "134 - Vaporeon",
					NameKey = "Pokemons_Vaporeon",
					Statistics = new Stats()
					{
						hp = 130,
						attack = 65,
						defense = 60,
						specialAttack = 110,
						specialDefense = 95,
						speed = 65
					}
				}
			},
			{
				135,
				new PokemonInfo()
				{
					ResourceName = "135 - Jolteon",
					NameKey = "Pokemons_Jolteon",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 65,
						defense = 60,
						specialAttack = 110,
						specialDefense = 95,
						speed = 130
					}
				}
			},
			{
				136,
				new PokemonInfo()
				{
					ResourceName = "136 - Flareon",
					NameKey = "Pokemons_Flareon",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 130,
						defense = 60,
						specialAttack = 95,
						specialDefense = 110,
						speed = 65
					}
				}
			},
			{
				137,
				new PokemonInfo()
				{
					ResourceName = "137 - Porygon",
					NameKey = "Pokemons_Porygon",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 60,
						defense = 70,
						specialAttack = 85,
						specialDefense = 75,
						speed = 40
					}
				}
			},
			{
				138,
				new PokemonInfo()
				{
					ResourceName = "138 - Omanyte",
					NameKey = "Pokemons_Omanyte",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 40,
						defense = 100,
						specialAttack = 90,
						specialDefense = 55,
						speed = 35
					}
				}
			},
			{
				139,
				new PokemonInfo()
				{
					ResourceName = "139 - Omastar",
					NameKey = "Pokemons_Omastar",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 60,
						defense = 125,
						specialAttack = 115,
						specialDefense = 70,
						speed = 55
					}
				}
			},
			{
				140,
				new PokemonInfo()
				{
					ResourceName = "140 - Kabuto",
					NameKey = "Pokemons_Kabuto",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 80,
						defense = 90,
						specialAttack = 55,
						specialDefense = 45,
						speed = 55
					}
				}
			},
			{
				141,
				new PokemonInfo()
				{
					ResourceName = "141 - Kabutops",
					NameKey = "Pokemons_Kabutops",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 115,
						defense = 105,
						specialAttack = 65,
						specialDefense = 70,
						speed = 80
					}
				}
			},
			{
				142,
				new PokemonInfo()
				{
					ResourceName = "142 - Aerodactyl",
					NameKey = "Pokemons_Aerodactyl",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 105,
						defense = 65,
						specialAttack = 60,
						specialDefense = 75,
						speed = 130
					}
				}
			},
			{
				143,
				new PokemonInfo()
				{
					ResourceName = "143 - Snorlax",
					NameKey = "Pokemons_Snorlax",
					Statistics = new Stats()
					{
						hp = 160,
						attack = 110,
						defense = 65,
						specialAttack = 65,
						specialDefense = 110,
						speed = 30
					}
				}
			},
			{
				144,
				new PokemonInfo()
				{
					ResourceName = "144 - Articuno",
					NameKey = "Pokemons_Articuno",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 85,
						defense = 100,
						specialAttack = 95,
						specialDefense = 125,
						speed = 85
					}
				}
			},
			{
				145,
				new PokemonInfo()
				{
					ResourceName = "145 - Zapdos",
					NameKey = "Pokemons_Zapdos",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 90,
						defense = 85,
						specialAttack = 125,
						specialDefense = 90,
						speed = 100
					}
				}
			},
			{
				146,
				new PokemonInfo()
				{
					ResourceName = "146 - Moltres",
					NameKey = "Pokemons_Moltres",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 100,
						defense = 90,
						specialAttack = 125,
						specialDefense = 85,
						speed = 90
					}
				}
			},
			{
				147,
				new PokemonInfo()
				{
					ResourceName = "147 - Dratini",
					NameKey = "Pokemons_Dratini",
					Statistics = new Stats()
					{
						hp = 41,
						attack = 64,
						defense = 45,
						specialAttack = 50,
						specialDefense = 50,
						speed = 50
					}
				}
			},
			{
				148,
				new PokemonInfo()
				{
					ResourceName = "148 - Dragonair",
					NameKey = "Pokemons_Dragonair",
					Statistics = new Stats()
					{
						hp = 61,
						attack = 84,
						defense = 65,
						specialAttack = 70,
						specialDefense = 70,
						speed = 70
					}
				}
			},
			{
				149,
				new PokemonInfo()
				{
					ResourceName = "149 - Dragonite",
					NameKey = "Pokemons_Dragonite",
					Statistics = new Stats()
					{
						hp = 91,
						attack = 134,
						defense = 95,
						specialAttack = 100,
						specialDefense = 100,
						speed = 80
					}
				}
			},
			{
				150,
				new PokemonInfo()
				{
					ResourceName = "150 - Mewtwo",
					NameKey = "Pokemons_Mewtwo",
					Statistics = new Stats()
					{
						hp = 106,
						attack = 110,
						defense = 90,
						specialAttack = 154,
						specialDefense = 90,
						speed = 130
					}
				}
			},
			{
				151,
				new PokemonInfo()
				{
					ResourceName = "151 - Mew",
					NameKey = "Pokemons_Mew",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 100,
						defense = 100,
						specialAttack = 100,
						specialDefense = 100,
						speed = 100
					}
				}
			},
			{
				152,
				new PokemonInfo()
				{
					ResourceName = "152 - Chikorita",
					NameKey = "Pokemons_Chikorita",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 49,
						defense = 65,
						specialAttack = 49,
						specialDefense = 65,
						speed = 45
					}
				}
			},
			{
				153,
				new PokemonInfo()
				{
					ResourceName = "153 - Bayleef",
					NameKey = "Pokemons_Bayleef",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 62,
						defense = 80,
						specialAttack = 63,
						specialDefense = 80,
						speed = 60
					}
				}
			},
			{
				154,
				new PokemonInfo()
				{
					ResourceName = "154 - Meganium",
					NameKey = "Pokemons_Meganium",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 82,
						defense = 100,
						specialAttack = 83,
						specialDefense = 100,
						speed = 80
					}
				}
			},
			{
				155,
				new PokemonInfo()
				{
					ResourceName = "155 - Cyndaquil",
					NameKey = "Pokemons_Cyndaquil",
					Statistics = new Stats()
					{
						hp = 39,
						attack = 52,
						defense = 43,
						specialAttack = 60,
						specialDefense = 50,
						speed = 65
					}
				}
			},
			{
				156,
				new PokemonInfo()
				{
					ResourceName = "156 - Quilava",
					NameKey = "Pokemons_Quilava",
					Statistics = new Stats()
					{
						hp = 58,
						attack = 64,
						defense = 58,
						specialAttack = 80,
						specialDefense = 65,
						speed = 80
					}
				}
			},
			{
				157,
				new PokemonInfo()
				{
					ResourceName = "157 - Typhlosion",
					NameKey = "Pokemons_Typhlosion",
					Statistics = new Stats()
					{
						hp = 78,
						attack = 84,
						defense = 78,
						specialAttack = 109,
						specialDefense = 85,
						speed = 100
					}
				}
			},
			{
				158,
				new PokemonInfo()
				{
					ResourceName = "158 - Totodile",
					NameKey = "Pokemons_Totodile",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 65,
						defense = 64,
						specialAttack = 44,
						specialDefense = 48,
						speed = 43
					}
				}
			},
			{
				159,
				new PokemonInfo()
				{
					ResourceName = "159 - Croconaw",
					NameKey = "Pokemons_Croconaw",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 80,
						defense = 80,
						specialAttack = 59,
						specialDefense = 63,
						speed = 58
					}
				}
			},
			{
				160,
				new PokemonInfo()
				{
					ResourceName = "160 - Feraligatr",
					NameKey = "Pokemons_Feraligatr",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 105,
						defense = 100,
						specialAttack = 79,
						specialDefense = 83,
						speed = 78
					}
				}
			},
			{
				161,
				new PokemonInfo()
				{
					ResourceName = "161 - Sentret",
					NameKey = "Pokemons_Sentret",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 46,
						defense = 34,
						specialAttack = 35,
						specialDefense = 45,
						speed = 20
					}
				}
			},
			{
				162,
				new PokemonInfo()
				{
					ResourceName = "162 - Furret",
					NameKey = "Pokemons_Furret",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 76,
						defense = 64,
						specialAttack = 45,
						specialDefense = 55,
						speed = 90
					}
				}
			},
			{
				163,
				new PokemonInfo()
				{
					ResourceName = "163 - Hoothoot",
					NameKey = "Pokemons_Hoothoot",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 30,
						defense = 30,
						specialAttack = 36,
						specialDefense = 56,
						speed = 50
					}
				}
			},
			{
				164,
				new PokemonInfo()
				{
					ResourceName = "164 - Noctowl",
					NameKey = "Pokemons_Noctowl",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 50,
						defense = 50,
						specialAttack = 76,
						specialDefense = 96,
						speed = 70
					}
				}
			},
			{
				165,
				new PokemonInfo()
				{
					ResourceName = "165 - Ledyba",
					NameKey = "Pokemons_Ledyba",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 20,
						defense = 30,
						specialAttack = 40,
						specialDefense = 80,
						speed = 55
					}
				}
			},
			{
				166,
				new PokemonInfo()
				{
					ResourceName = "166 - Ledian",
					NameKey = "Pokemons_Ledian",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 35,
						defense = 50,
						specialAttack = 55,
						specialDefense = 110,
						speed = 85
					}
				}
			},
			{
				167,
				new PokemonInfo()
				{
					ResourceName = "167 - Spinarak",
					NameKey = "Pokemons_Spinarak",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 60,
						defense = 40,
						specialAttack = 40,
						specialDefense = 40,
						speed = 30
					}
				}
			},
			{
				168,
				new PokemonInfo()
				{
					ResourceName = "168 - Ariados",
					NameKey = "Pokemons_Ariados",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 90,
						defense = 70,
						specialAttack = 60,
						specialDefense = 60,
						speed = 40
					}
				}
			},
			{
				169,
				new PokemonInfo()
				{
					ResourceName = "169 - Crobat",
					NameKey = "Pokemons_Crobat",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 90,
						defense = 80,
						specialAttack = 70,
						specialDefense = 80,
						speed = 130
					}
				}
			},
			{
				170,
				new PokemonInfo()
				{
					ResourceName = "170 - Chinchou",
					NameKey = "Pokemons_Chinchou",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 38,
						defense = 38,
						specialAttack = 56,
						specialDefense = 56,
						speed = 67
					}
				}
			},
			{
				171,
				new PokemonInfo()
				{
					ResourceName = "171 - Lanturn",
					NameKey = "Pokemons_Lanturn",
					Statistics = new Stats()
					{
						hp = 125,
						attack = 58,
						defense = 58,
						specialAttack = 76,
						specialDefense = 76,
						speed = 67
					}
				}
			},
			{
				172,
				new PokemonInfo()
				{
					ResourceName = "172 - Pichu",
					NameKey = "Pokemons_Pichu",
					Statistics = new Stats()
					{
						hp = 20,
						attack = 40,
						defense = 15,
						specialAttack = 35,
						specialDefense = 35,
						speed = 60
					}
				}
			},
			{
				173,
				new PokemonInfo()
				{
					ResourceName = "173 - Cleffa",
					NameKey = "Pokemons_Cleffa",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 25,
						defense = 28,
						specialAttack = 45,
						specialDefense = 55,
						speed = 15
					}
				}
			},
			{
				174,
				new PokemonInfo()
				{
					ResourceName = "174 - Igglybuff",
					NameKey = "Pokemons_Igglybuff",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 30,
						defense = 15,
						specialAttack = 40,
						specialDefense = 20,
						speed = 15
					}
				}
			},
			{
				175,
				new PokemonInfo()
				{
					ResourceName = "175 - Togepi",
					NameKey = "Pokemons_Togepi",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 20,
						defense = 65,
						specialAttack = 40,
						specialDefense = 65,
						speed = 20
					}
				}
			},
			{
				176,
				new PokemonInfo()
				{
					ResourceName = "176 - Togetic",
					NameKey = "Pokemons_Togetic",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 40,
						defense = 85,
						specialAttack = 80,
						specialDefense = 105,
						speed = 40
					}
				}
			},
			{
				177,
				new PokemonInfo()
				{
					ResourceName = "177 - Natu",
					NameKey = "Pokemons_Natu",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 50,
						defense = 45,
						specialAttack = 70,
						specialDefense = 45,
						speed = 70
					}
				}
			},
			{
				178,
				new PokemonInfo()
				{
					ResourceName = "178 - Xatu",
					NameKey = "Pokemons_Xatu",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 75,
						defense = 70,
						specialAttack = 95,
						specialDefense = 70,
						speed = 95
					}
				}
			},
			{
				179,
				new PokemonInfo()
				{
					ResourceName = "179 - Mareep",
					NameKey = "Pokemons_Mareep",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 40,
						defense = 40,
						specialAttack = 65,
						specialDefense = 45,
						speed = 35
					}
				}
			},
			{
				180,
				new PokemonInfo()
				{
					ResourceName = "180 - Flaaffy",
					NameKey = "Pokemons_Flaaffy",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 55,
						defense = 55,
						specialAttack = 80,
						specialDefense = 60,
						speed = 45
					}
				}
			},
			{
				181,
				new PokemonInfo()
				{
					ResourceName = "181 - Ampharos",
					NameKey = "Pokemons_Ampharos",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 75,
						defense = 75,
						specialAttack = 115,
						specialDefense = 90,
						speed = 55
					}
				}
			},
			{
				182,
				new PokemonInfo()
				{
					ResourceName = "182 - Bellossom",
					NameKey = "Pokemons_Bellossom",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 80,
						defense = 85,
						specialAttack = 90,
						specialDefense = 100,
						speed = 50
					}
				}
			},
			{
				183,
				new PokemonInfo()
				{
					ResourceName = "183 - Marill",
					NameKey = "Pokemons_Marill",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 20,
						defense = 50,
						specialAttack = 20,
						specialDefense = 50,
						speed = 40
					}
				}
			},
			{
				184,
				new PokemonInfo()
				{
					ResourceName = "184 - Azumarill",
					NameKey = "Pokemons_Azumarill",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 50,
						defense = 80,
						specialAttack = 50,
						specialDefense = 80,
						speed = 50
					}
				}
			},
			{
				185,
				new PokemonInfo()
				{
					ResourceName = "185 - Sudowoodo",
					NameKey = "Pokemons_Sudowoodo",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 100,
						defense = 115,
						specialAttack = 30,
						specialDefense = 65,
						speed = 30
					}
				}
			},
			{
				186,
				new PokemonInfo()
				{
					ResourceName = "186 - Politoed",
					NameKey = "Pokemons_Politoed",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 75,
						defense = 75,
						specialAttack = 90,
						specialDefense = 100,
						speed = 70
					}
				}
			},
			{
				187,
				new PokemonInfo()
				{
					ResourceName = "187 - Hoppip",
					NameKey = "Pokemons_Hoppip",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 35,
						defense = 40,
						specialAttack = 35,
						specialDefense = 55,
						speed = 50
					}
				}
			},
			{
				188,
				new PokemonInfo()
				{
					ResourceName = "188 - Skiploom",
					NameKey = "Pokemons_Skiploom",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 45,
						defense = 50,
						specialAttack = 45,
						specialDefense = 65,
						speed = 80
					}
				}
			},
			{
				189,
				new PokemonInfo()
				{
					ResourceName = "189 - Jumpluff",
					NameKey = "Pokemons_Jumpluff",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 55,
						defense = 70,
						specialAttack = 55,
						specialDefense = 85,
						speed = 110
					}
				}
			},
			{
				190,
				new PokemonInfo()
				{
					ResourceName = "190 - Aipom",
					NameKey = "Pokemons_Aipom",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 70,
						defense = 55,
						specialAttack = 40,
						specialDefense = 55,
						speed = 85
					}
				}
			},
			{
				191,
				new PokemonInfo()
				{
					ResourceName = "191 - Sunkern",
					NameKey = "Pokemons_Sunkern",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 30,
						defense = 30,
						specialAttack = 30,
						specialDefense = 30,
						speed = 30
					}
				}
			},
			{
				192,
				new PokemonInfo()
				{
					ResourceName = "192 - Sunflora",
					NameKey = "Pokemons_Sunflora",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 75,
						defense = 55,
						specialAttack = 105,
						specialDefense = 85,
						speed = 30
					}
				}
			},
			{
				193,
				new PokemonInfo()
				{
					ResourceName = "193 - Yanma",
					NameKey = "Pokemons_Yanma",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 65,
						defense = 45,
						specialAttack = 75,
						specialDefense = 45,
						speed = 95
					}
				}
			},
			{
				194,
				new PokemonInfo()
				{
					ResourceName = "194 - Wooper",
					NameKey = "Pokemons_Wooper",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 45,
						defense = 45,
						specialAttack = 25,
						specialDefense = 25,
						speed = 15
					}
				}
			},
			{
				195,
				new PokemonInfo()
				{
					ResourceName = "195 - Quagsire",
					NameKey = "Pokemons_Quagsire",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 85,
						defense = 85,
						specialAttack = 65,
						specialDefense = 65,
						speed = 35
					}
				}
			},
			{
				196,
				new PokemonInfo()
				{
					ResourceName = "196 - Espeon",
					NameKey = "Pokemons_Espeon",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 65,
						defense = 60,
						specialAttack = 130,
						specialDefense = 95,
						speed = 110
					}
				}
			},
			{
				197,
				new PokemonInfo()
				{
					ResourceName = "197 - Umbreon",
					NameKey = "Pokemons_Umbreon",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 65,
						defense = 110,
						specialAttack = 60,
						specialDefense = 130,
						speed = 65
					}
				}
			},
			{
				198,
				new PokemonInfo()
				{
					ResourceName = "198 - Murkrow",
					NameKey = "Pokemons_Murkrow",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 85,
						defense = 42,
						specialAttack = 85,
						specialDefense = 42,
						speed = 91
					}
				}
			},
			{
				199,
				new PokemonInfo()
				{
					ResourceName = "199 - Slowking",
					NameKey = "Pokemons_Slowking",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 75,
						defense = 80,
						specialAttack = 100,
						specialDefense = 110,
						speed = 30
					}
				}
			},
			{
				200,
				new PokemonInfo()
				{
					ResourceName = "200 - Misdreavus",
					NameKey = "Pokemons_Misdreavus",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 60,
						defense = 60,
						specialAttack = 85,
						specialDefense = 85,
						speed = 85
					}
				}
			},
			{
				201,
				new PokemonInfo()
				{
					ResourceName = "201 - Unown",
					NameKey = "Pokemons_Unown",
					Statistics = new Stats()
					{
						hp = 48,
						attack = 72,
						defense = 48,
						specialAttack = 72,
						specialDefense = 48,
						speed = 48
					}
				}
			},
			{
				202,
				new PokemonInfo()
				{
					ResourceName = "202 - Wobbuffet",
					NameKey = "Pokemons_Wobbuffet",
					Statistics = new Stats()
					{
						hp = 190,
						attack = 33,
						defense = 58,
						specialAttack = 33,
						specialDefense = 58,
						speed = 33
					}
				}
			},
			{
				203,
				new PokemonInfo()
				{
					ResourceName = "203 - Girafarig",
					NameKey = "Pokemons_Girafarig",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 80,
						defense = 65,
						specialAttack = 90,
						specialDefense = 65,
						speed = 85
					}
				}
			},
			{
				204,
				new PokemonInfo()
				{
					ResourceName = "204 - Pineco",
					NameKey = "Pokemons_Pineco",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 65,
						defense = 90,
						specialAttack = 35,
						specialDefense = 35,
						speed = 15
					}
				}
			},
			{
				205,
				new PokemonInfo()
				{
					ResourceName = "205 - Forretress",
					NameKey = "Pokemons_Forretress",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 90,
						defense = 140,
						specialAttack = 60,
						specialDefense = 60,
						speed = 40
					}
				}
			},
			{
				206,
				new PokemonInfo()
				{
					ResourceName = "206 - Dunsparce",
					NameKey = "Pokemons_Dunsparce",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 70,
						defense = 70,
						specialAttack = 65,
						specialDefense = 65,
						speed = 45
					}
				}
			},
			{
				207,
				new PokemonInfo()
				{
					ResourceName = "207 - Gligar",
					NameKey = "Pokemons_Gligar",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 75,
						defense = 105,
						specialAttack = 35,
						specialDefense = 65,
						speed = 85
					}
				}
			},
			{
				208,
				new PokemonInfo()
				{
					ResourceName = "208 - Steelix",
					NameKey = "Pokemons_Steelix",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 85,
						defense = 200,
						specialAttack = 55,
						specialDefense = 65,
						speed = 30
					}
				}
			},
			{
				209,
				new PokemonInfo()
				{
					ResourceName = "209 - Snubbull",
					NameKey = "Pokemons_Snubbull",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 80,
						defense = 50,
						specialAttack = 40,
						specialDefense = 40,
						speed = 30
					}
				}
			},
			{
				210,
				new PokemonInfo()
				{
					ResourceName = "210 - Granbull",
					NameKey = "Pokemons_Granbull",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 120,
						defense = 75,
						specialAttack = 60,
						specialDefense = 60,
						speed = 45
					}
				}
			},
			{
				211,
				new PokemonInfo()
				{
					ResourceName = "211 - Qwilfish",
					NameKey = "Pokemons_Qwilfish",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 95,
						defense = 75,
						specialAttack = 55,
						specialDefense = 55,
						speed = 85
					}
				}
			},
			{
				212,
				new PokemonInfo()
				{
					ResourceName = "212 - Scizor",
					NameKey = "Pokemons_Scizor",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 130,
						defense = 100,
						specialAttack = 55,
						specialDefense = 80,
						speed = 65
					}
				}
			},
			{
				213,
				new PokemonInfo()
				{
					ResourceName = "213 - Shuckle",
					NameKey = "Pokemons_Shuckle",
					Statistics = new Stats()
					{
						hp = 20,
						attack = 10,
						defense = 230,
						specialAttack = 10,
						specialDefense = 230,
						speed = 5
					}
				}
			},
			{
				214,
				new PokemonInfo()
				{
					ResourceName = "214 - Heracross",
					NameKey = "Pokemons_Heracross",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 125,
						defense = 75,
						specialAttack = 40,
						specialDefense = 95,
						speed = 85
					}
				}
			},
			{
				215,
				new PokemonInfo()
				{
					ResourceName = "215 - Sneasel",
					NameKey = "Pokemons_Sneasel",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 95,
						defense = 55,
						specialAttack = 35,
						specialDefense = 75,
						speed = 115
					}
				}
			},
			{
				216,
				new PokemonInfo()
				{
					ResourceName = "216 - Teddiursa",
					NameKey = "Pokemons_Teddiursa",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 80,
						defense = 50,
						specialAttack = 50,
						specialDefense = 50,
						speed = 40
					}
				}
			},
			{
				217,
				new PokemonInfo()
				{
					ResourceName = "217 - Ursaring",
					NameKey = "Pokemons_Ursaring",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 130,
						defense = 75,
						specialAttack = 75,
						specialDefense = 75,
						speed = 55
					}
				}
			},
			{
				218,
				new PokemonInfo()
				{
					ResourceName = "218 - Slugma",
					NameKey = "Pokemons_Slugma",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 40,
						defense = 40,
						specialAttack = 70,
						specialDefense = 40,
						speed = 20
					}
				}
			},
			{
				219,
				new PokemonInfo()
				{
					ResourceName = "219 - Magcargo",
					NameKey = "Pokemons_Magcargo",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 50,
						defense = 120,
						specialAttack = 80,
						specialDefense = 80,
						speed = 30
					}
				}
			},
			{
				220,
				new PokemonInfo()
				{
					ResourceName = "220 - Swinub",
					NameKey = "Pokemons_Swinub",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 50,
						defense = 40,
						specialAttack = 30,
						specialDefense = 30,
						speed = 50
					}
				}
			},
			{
				221,
				new PokemonInfo()
				{
					ResourceName = "221 - Piloswine",
					NameKey = "Pokemons_Piloswine",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 100,
						defense = 80,
						specialAttack = 60,
						specialDefense = 60,
						speed = 50
					}
				}
			},
			{
				222,
				new PokemonInfo()
				{
					ResourceName = "222 - Corsola",
					NameKey = "Pokemons_Corsola",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 55,
						defense = 85,
						specialAttack = 65,
						specialDefense = 85,
						speed = 35
					}
				}
			},
			{
				223,
				new PokemonInfo()
				{
					ResourceName = "223 - Remoraid",
					NameKey = "Pokemons_Remoraid",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 65,
						defense = 35,
						specialAttack = 65,
						specialDefense = 35,
						speed = 65
					}
				}
			},
			{
				224,
				new PokemonInfo()
				{
					ResourceName = "224 - Octillery",
					NameKey = "Pokemons_Octillery",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 105,
						defense = 75,
						specialAttack = 105,
						specialDefense = 75,
						speed = 45
					}
				}
			},
			{
				225,
				new PokemonInfo()
				{
					ResourceName = "225 - Delibird",
					NameKey = "Pokemons_Delibird",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 55,
						defense = 45,
						specialAttack = 65,
						specialDefense = 45,
						speed = 75
					}
				}
			},
			{
				226,
				new PokemonInfo()
				{
					ResourceName = "226 - Mantine",
					NameKey = "Pokemons_Mantine",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 40,
						defense = 70,
						specialAttack = 80,
						specialDefense = 140,
						speed = 70
					}
				}
			},
			{
				227,
				new PokemonInfo()
				{
					ResourceName = "227 - Skarmory",
					NameKey = "Pokemons_Skarmory",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 80,
						defense = 140,
						specialAttack = 40,
						specialDefense = 70,
						speed = 70
					}
				}
			},
			{
				228,
				new PokemonInfo()
				{
					ResourceName = "228 - Houndour",
					NameKey = "Pokemons_Houndour",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 60,
						defense = 30,
						specialAttack = 80,
						specialDefense = 50,
						speed = 65
					}
				}
			},
			{
				229,
				new PokemonInfo()
				{
					ResourceName = "229 - Houndoom",
					NameKey = "Pokemons_Houndoom",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 90,
						defense = 50,
						specialAttack = 110,
						specialDefense = 80,
						speed = 95
					}
				}
			},
			{
				230,
				new PokemonInfo()
				{
					ResourceName = "230 - Kingdra",
					NameKey = "Pokemons_Kingdra",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 95,
						defense = 95,
						specialAttack = 95,
						specialDefense = 95,
						speed = 85
					}
				}
			},
			{
				231,
				new PokemonInfo()
				{
					ResourceName = "231 - Phanpy",
					NameKey = "Pokemons_Phanpy",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 60,
						defense = 60,
						specialAttack = 40,
						specialDefense = 40,
						speed = 40
					}
				}
			},
			{
				232,
				new PokemonInfo()
				{
					ResourceName = "232 - Donphan",
					NameKey = "Pokemons_Donphan",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 120,
						defense = 120,
						specialAttack = 60,
						specialDefense = 60,
						speed = 50
					}
				}
			},
			{
				233,
				new PokemonInfo()
				{
					ResourceName = "233 - Porygon2",
					NameKey = "Pokemons_Porygon2",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 80,
						defense = 90,
						specialAttack = 105,
						specialDefense = 95,
						speed = 60
					}
				}
			},
			{
				234,
				new PokemonInfo()
				{
					ResourceName = "234 - Stantler",
					NameKey = "Pokemons_Stantler",
					Statistics = new Stats()
					{
						hp = 73,
						attack = 95,
						defense = 62,
						specialAttack = 85,
						specialDefense = 65,
						speed = 85
					}
				}
			},
			{
				235,
				new PokemonInfo()
				{
					ResourceName = "235 - Smeargle",
					NameKey = "Pokemons_Smeargle",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 20,
						defense = 35,
						specialAttack = 20,
						specialDefense = 45,
						speed = 75
					}
				}
			},
			{
				236,
				new PokemonInfo()
				{
					ResourceName = "236 - Tyrogue",
					NameKey = "Pokemons_Tyrogue",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 35,
						defense = 35,
						specialAttack = 35,
						specialDefense = 35,
						speed = 35
					}
				}
			},
			{
				237,
				new PokemonInfo()
				{
					ResourceName = "237 - Hitmontop",
					NameKey = "Pokemons_Hitmontop",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 95,
						defense = 95,
						specialAttack = 35,
						specialDefense = 110,
						speed = 70
					}
				}
			},
			{
				238,
				new PokemonInfo()
				{
					ResourceName = "238 - Smoochum",
					NameKey = "Pokemons_Smoochum",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 30,
						defense = 15,
						specialAttack = 85,
						specialDefense = 65,
						speed = 65
					}
				}
			},
			{
				239,
				new PokemonInfo()
				{
					ResourceName = "239 - Elekid",
					NameKey = "Pokemons_Elekid",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 63,
						defense = 37,
						specialAttack = 65,
						specialDefense = 55,
						speed = 95
					}
				}
			},
			{
				240,
				new PokemonInfo()
				{
					ResourceName = "240 - Magby",
					NameKey = "Pokemons_Magby",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 75,
						defense = 37,
						specialAttack = 70,
						specialDefense = 55,
						speed = 83
					}
				}
			},
			{
				241,
				new PokemonInfo()
				{
					ResourceName = "241 - Miltank",
					NameKey = "Pokemons_Miltank",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 80,
						defense = 105,
						specialAttack = 40,
						specialDefense = 70,
						speed = 100
					}
				}
			},
			{
				242,
				new PokemonInfo()
				{
					ResourceName = "242 - Blissey",
					NameKey = "Pokemons_Blissey",
					Statistics = new Stats()
					{
						hp = 255,
						attack = 10,
						defense = 10,
						specialAttack = 75,
						specialDefense = 135,
						speed = 55
					}
				}
			},
			{
				243,
				new PokemonInfo()
				{
					ResourceName = "243 - Raikou",
					NameKey = "Pokemons_Raikou",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 85,
						defense = 75,
						specialAttack = 115,
						specialDefense = 100,
						speed = 115
					}
				}
			},
			{
				244,
				new PokemonInfo()
				{
					ResourceName = "244 - Entei",
					NameKey = "Pokemons_Entei",
					Statistics = new Stats()
					{
						hp = 115,
						attack = 115,
						defense = 85,
						specialAttack = 90,
						specialDefense = 75,
						speed = 100
					}
				}
			},
			{
				245,
				new PokemonInfo()
				{
					ResourceName = "245 - Suicune",
					NameKey = "Pokemons_Suicune",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 75,
						defense = 115,
						specialAttack = 90,
						specialDefense = 115,
						speed = 85
					}
				}
			},
			{
				246,
				new PokemonInfo()
				{
					ResourceName = "246 - Larvitar",
					NameKey = "Pokemons_Larvitar",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 64,
						defense = 50,
						specialAttack = 45,
						specialDefense = 50,
						speed = 41
					}
				}
			},
			{
				247,
				new PokemonInfo()
				{
					ResourceName = "247 - Pupitar",
					NameKey = "Pokemons_Pupitar",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 84,
						defense = 70,
						specialAttack = 65,
						specialDefense = 70,
						speed = 51
					}
				}
			},
			{
				248,
				new PokemonInfo()
				{
					ResourceName = "248 - Tyranitar",
					NameKey = "Pokemons_Tyranitar",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 134,
						defense = 110,
						specialAttack = 95,
						specialDefense = 100,
						speed = 61
					}
				}
			},
			{
				249,
				new PokemonInfo()
				{
					ResourceName = "249 - Lugia",
					NameKey = "Pokemons_Lugia",
					Statistics = new Stats()
					{
						hp = 106,
						attack = 90,
						defense = 130,
						specialAttack = 90,
						specialDefense = 154,
						speed = 110
					}
				}
			},
			{
				250,
				new PokemonInfo()
				{
					ResourceName = "250 - Ho-oh",
					NameKey = "Pokemons_Ho-oh",
					Statistics = new Stats()
					{
						hp = 106,
						attack = 130,
						defense = 90,
						specialAttack = 110,
						specialDefense = 154,
						speed = 90
					}
				}
			},
			{
				251,
				new PokemonInfo()
				{
					ResourceName = "251 - Celebi",
					NameKey = "Pokemons_Celebi",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 100,
						defense = 100,
						specialAttack = 100,
						specialDefense = 100,
						speed = 100
					}
				}
			},
			{
				252,
				new PokemonInfo()
				{
					ResourceName = "252 - Treecko",
					NameKey = "Pokemons_Treecko",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 45,
						defense = 35,
						specialAttack = 65,
						specialDefense = 55,
						speed = 70
					}
				}
			},
			{
				253,
				new PokemonInfo()
				{
					ResourceName = "253 - Grovyle",
					NameKey = "Pokemons_Grovyle",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 65,
						defense = 45,
						specialAttack = 85,
						specialDefense = 65,
						speed = 95
					}
				}
			},
			{
				254,
				new PokemonInfo()
				{
					ResourceName = "254 - Sceptile",
					NameKey = "Pokemons_Sceptile",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 85,
						defense = 65,
						specialAttack = 105,
						specialDefense = 85,
						speed = 120
					}
				}
			},
			{
				255,
				new PokemonInfo()
				{
					ResourceName = "255 - Torchic",
					NameKey = "Pokemons_Torchic",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 60,
						defense = 40,
						specialAttack = 70,
						specialDefense = 50,
						speed = 45
					}
				}
			},
			{
				256,
				new PokemonInfo()
				{
					ResourceName = "256 - Combusken",
					NameKey = "Pokemons_Combusken",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 85,
						defense = 60,
						specialAttack = 85,
						specialDefense = 60,
						speed = 55
					}
				}
			},
			{
				257,
				new PokemonInfo()
				{
					ResourceName = "257 - Blaziken",
					NameKey = "Pokemons_Blaziken",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 120,
						defense = 70,
						specialAttack = 110,
						specialDefense = 70,
						speed = 80
					}
				}
			},
			{
				258,
				new PokemonInfo()
				{
					ResourceName = "258 - Mudkip",
					NameKey = "Pokemons_Mudkip",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 70,
						defense = 50,
						specialAttack = 50,
						specialDefense = 50,
						speed = 40
					}
				}
			},
			{
				259,
				new PokemonInfo()
				{
					ResourceName = "259 - Marshtomp",
					NameKey = "Pokemons_Marshtomp",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 85,
						defense = 70,
						specialAttack = 60,
						specialDefense = 70,
						speed = 50
					}
				}
			},
			{
				260,
				new PokemonInfo()
				{
					ResourceName = "260 - Swampert",
					NameKey = "Pokemons_Swampert",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 110,
						defense = 90,
						specialAttack = 85,
						specialDefense = 90,
						speed = 60
					}
				}
			},
			{
				261,
				new PokemonInfo()
				{
					ResourceName = "261 - Poochyena",
					NameKey = "Pokemons_Poochyena",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 55,
						defense = 35,
						specialAttack = 30,
						specialDefense = 30,
						speed = 35
					}
				}
			},
			{
				262,
				new PokemonInfo()
				{
					ResourceName = "262 - Mightyena",
					NameKey = "Pokemons_Mightyena",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 90,
						defense = 70,
						specialAttack = 60,
						specialDefense = 60,
						speed = 70
					}
				}
			},
			{
				263,
				new PokemonInfo()
				{
					ResourceName = "263 - Zigzagoon",
					NameKey = "Pokemons_Zigzagoon",
					Statistics = new Stats()
					{
						hp = 38,
						attack = 30,
						defense = 41,
						specialAttack = 30,
						specialDefense = 41,
						speed = 60
					}
				}
			},
			{
				264,
				new PokemonInfo()
				{
					ResourceName = "264 - Linoone",
					NameKey = "Pokemons_Linoone",
					Statistics = new Stats()
					{
						hp = 78,
						attack = 70,
						defense = 61,
						specialAttack = 50,
						specialDefense = 61,
						speed = 100
					}
				}
			},
			{
				265,
				new PokemonInfo()
				{
					ResourceName = "265 - Wurmple",
					NameKey = "Pokemons_Wurmple",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 45,
						defense = 35,
						specialAttack = 20,
						specialDefense = 30,
						speed = 20
					}
				}
			},
			{
				266,
				new PokemonInfo()
				{
					ResourceName = "266 - Silcoon",
					NameKey = "Pokemons_Silcoon",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 35,
						defense = 55,
						specialAttack = 25,
						specialDefense = 25,
						speed = 15
					}
				}
			},
			{
				267,
				new PokemonInfo()
				{
					ResourceName = "267 - Beautifly",
					NameKey = "Pokemons_Beautifly",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 70,
						defense = 50,
						specialAttack = 90,
						specialDefense = 50,
						speed = 65
					}
				}
			},
			{
				268,
				new PokemonInfo()
				{
					ResourceName = "268 - Cascoon",
					NameKey = "Pokemons_Cascoon",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 35,
						defense = 55,
						specialAttack = 25,
						specialDefense = 25,
						speed = 15
					}
				}
			},
			{
				269,
				new PokemonInfo()
				{
					ResourceName = "269 - Dustox",
					NameKey = "Pokemons_Dustox",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 50,
						defense = 70,
						specialAttack = 50,
						specialDefense = 90,
						speed = 65
					}
				}
			},
			{
				270,
				new PokemonInfo()
				{
					ResourceName = "270 - Lotad",
					NameKey = "Pokemons_Lotad",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 30,
						defense = 30,
						specialAttack = 40,
						specialDefense = 50,
						speed = 30
					}
				}
			},
			{
				271,
				new PokemonInfo()
				{
					ResourceName = "271 - Lombre",
					NameKey = "Pokemons_Lombre",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 50,
						defense = 50,
						specialAttack = 60,
						specialDefense = 70,
						speed = 50
					}
				}
			},
			{
				272,
				new PokemonInfo()
				{
					ResourceName = "272 - Ludicolo",
					NameKey = "Pokemons_Ludicolo",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 70,
						defense = 70,
						specialAttack = 90,
						specialDefense = 100,
						speed = 70
					}
				}
			},
			{
				273,
				new PokemonInfo()
				{
					ResourceName = "273 - Seedot",
					NameKey = "Pokemons_Seedot",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 40,
						defense = 50,
						specialAttack = 30,
						specialDefense = 30,
						speed = 30
					}
				}
			},
			{
				274,
				new PokemonInfo()
				{
					ResourceName = "274 - Nuzleaf",
					NameKey = "Pokemons_Nuzleaf",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 70,
						defense = 40,
						specialAttack = 60,
						specialDefense = 40,
						speed = 60
					}
				}
			},
			{
				275,
				new PokemonInfo()
				{
					ResourceName = "275 - Shiftry",
					NameKey = "Pokemons_Shiftry",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 100,
						defense = 60,
						specialAttack = 90,
						specialDefense = 60,
						speed = 80
					}
				}
			},
			{
				276,
				new PokemonInfo()
				{
					ResourceName = "276 - Taillow",
					NameKey = "Pokemons_Taillow",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 55,
						defense = 30,
						specialAttack = 30,
						specialDefense = 30,
						speed = 85
					}
				}
			},
			{
				277,
				new PokemonInfo()
				{
					ResourceName = "277 - Swellow",
					NameKey = "Pokemons_Swellow",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 85,
						defense = 60,
						specialAttack = 50,
						specialDefense = 50,
						speed = 125
					}
				}
			},
			{
				278,
				new PokemonInfo()
				{
					ResourceName = "278 - Wingull",
					NameKey = "Pokemons_Wingull",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 30,
						defense = 30,
						specialAttack = 55,
						specialDefense = 30,
						speed = 85
					}
				}
			},
			{
				279,
				new PokemonInfo()
				{
					ResourceName = "279 - Pelipper",
					NameKey = "Pokemons_Pelipper",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 50,
						defense = 100,
						specialAttack = 85,
						specialDefense = 70,
						speed = 65
					}
				}
			},
			{
				280,
				new PokemonInfo()
				{
					ResourceName = "280 - Ralts",
					NameKey = "Pokemons_Ralts",
					Statistics = new Stats()
					{
						hp = 28,
						attack = 25,
						defense = 25,
						specialAttack = 45,
						specialDefense = 35,
						speed = 40
					}
				}
			},
			{
				281,
				new PokemonInfo()
				{
					ResourceName = "281 - Kirlia",
					NameKey = "Pokemons_Kirlia",
					Statistics = new Stats()
					{
						hp = 38,
						attack = 35,
						defense = 35,
						specialAttack = 65,
						specialDefense = 55,
						speed = 50
					}
				}
			},
			{
				282,
				new PokemonInfo()
				{
					ResourceName = "282 - Gardevoir",
					NameKey = "Pokemons_Gardevoir",
					Statistics = new Stats()
					{
						hp = 68,
						attack = 65,
						defense = 65,
						specialAttack = 125,
						specialDefense = 115,
						speed = 80
					}
				}
			},
			{
				283,
				new PokemonInfo()
				{
					ResourceName = "283 - Surskit",
					NameKey = "Pokemons_Surskit",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 30,
						defense = 32,
						specialAttack = 50,
						specialDefense = 52,
						speed = 65
					}
				}
			},
			{
				284,
				new PokemonInfo()
				{
					ResourceName = "284 - Masquerain",
					NameKey = "Pokemons_Masquerain",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 60,
						defense = 62,
						specialAttack = 80,
						specialDefense = 82,
						speed = 60
					}
				}
			},
			{
				285,
				new PokemonInfo()
				{
					ResourceName = "285 - Shroomish",
					NameKey = "Pokemons_Shroomish",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 40,
						defense = 60,
						specialAttack = 40,
						specialDefense = 60,
						speed = 35
					}
				}
			},
			{
				286,
				new PokemonInfo()
				{
					ResourceName = "286 - Breloom",
					NameKey = "Pokemons_Breloom",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 130,
						defense = 80,
						specialAttack = 60,
						specialDefense = 60,
						speed = 70
					}
				}
			},
			{
				287,
				new PokemonInfo()
				{
					ResourceName = "287 - Slakoth",
					NameKey = "Pokemons_Slakoth",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 60,
						defense = 60,
						specialAttack = 35,
						specialDefense = 35,
						speed = 30
					}
				}
			},
			{
				288,
				new PokemonInfo()
				{
					ResourceName = "288 - Vigoroth",
					NameKey = "Pokemons_Vigoroth",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 80,
						defense = 80,
						specialAttack = 55,
						specialDefense = 55,
						speed = 90
					}
				}
			},
			{
				289,
				new PokemonInfo()
				{
					ResourceName = "289 - Slaking",
					NameKey = "Pokemons_Slaking",
					Statistics = new Stats()
					{
						hp = 150,
						attack = 160,
						defense = 100,
						specialAttack = 95,
						specialDefense = 65,
						speed = 100
					}
				}
			},
			{
				290,
				new PokemonInfo()
				{
					ResourceName = "290 - Nincada",
					NameKey = "Pokemons_Nincada",
					Statistics = new Stats()
					{
						hp = 31,
						attack = 45,
						defense = 90,
						specialAttack = 30,
						specialDefense = 30,
						speed = 40
					}
				}
			},
			{
				291,
				new PokemonInfo()
				{
					ResourceName = "291 - Ninjask",
					NameKey = "Pokemons_Ninjask",
					Statistics = new Stats()
					{
						hp = 61,
						attack = 90,
						defense = 45,
						specialAttack = 50,
						specialDefense = 50,
						speed = 160
					}
				}
			},
			{
				292,
				new PokemonInfo()
				{
					ResourceName = "292 - Shedinja",
					NameKey = "Pokemons_Shedinja",
					Statistics = new Stats()
					{
						hp = 1,
						attack = 90,
						defense = 45,
						specialAttack = 30,
						specialDefense = 30,
						speed = 40
					}
				}
			},
			{
				293,
				new PokemonInfo()
				{
					ResourceName = "293 - Whismur",
					NameKey = "Pokemons_Whismur",
					Statistics = new Stats()
					{
						hp = 64,
						attack = 51,
						defense = 23,
						specialAttack = 51,
						specialDefense = 23,
						speed = 28
					}
				}
			},
			{
				294,
				new PokemonInfo()
				{
					ResourceName = "294 - Loudred",
					NameKey = "Pokemons_Loudred",
					Statistics = new Stats()
					{
						hp = 84,
						attack = 71,
						defense = 43,
						specialAttack = 71,
						specialDefense = 43,
						speed = 48
					}
				}
			},
			{
				295,
				new PokemonInfo()
				{
					ResourceName = "295 - Exploud",
					NameKey = "Pokemons_Exploud",
					Statistics = new Stats()
					{
						hp = 104,
						attack = 91,
						defense = 63,
						specialAttack = 91,
						specialDefense = 63,
						speed = 68
					}
				}
			},
			{
				296,
				new PokemonInfo()
				{
					ResourceName = "296 - Makuhita",
					NameKey = "Pokemons_Makuhita",
					Statistics = new Stats()
					{
						hp = 72,
						attack = 60,
						defense = 30,
						specialAttack = 20,
						specialDefense = 30,
						speed = 25
					}
				}
			},
			{
				297,
				new PokemonInfo()
				{
					ResourceName = "297 - Hariyama",
					NameKey = "Pokemons_Hariyama",
					Statistics = new Stats()
					{
						hp = 144,
						attack = 120,
						defense = 60,
						specialAttack = 40,
						specialDefense = 60,
						speed = 50
					}
				}
			},
			{
				298,
				new PokemonInfo()
				{
					ResourceName = "298 - Azurill",
					NameKey = "Pokemons_Azurill",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 20,
						defense = 40,
						specialAttack = 20,
						specialDefense = 40,
						speed = 20
					}
				}
			},
			{
				299,
				new PokemonInfo()
				{
					ResourceName = "299 - Nosepass",
					NameKey = "Pokemons_Nosepass",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 45,
						defense = 135,
						specialAttack = 45,
						specialDefense = 90,
						speed = 30
					}
				}
			},
			{
				300,
				new PokemonInfo()
				{
					ResourceName = "300 - Skitty",
					NameKey = "Pokemons_Skitty",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 45,
						defense = 45,
						specialAttack = 35,
						specialDefense = 35,
						speed = 50
					}
				}
			},
			{
				301,
				new PokemonInfo()
				{
					ResourceName = "301 - Delcatty",
					NameKey = "Pokemons_Delcatty",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 65,
						defense = 65,
						specialAttack = 55,
						specialDefense = 55,
						speed = 70
					}
				}
			},
			{
				302,
				new PokemonInfo()
				{
					ResourceName = "302 - Sableye",
					NameKey = "Pokemons_Sableye",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 75,
						defense = 75,
						specialAttack = 65,
						specialDefense = 65,
						speed = 50
					}
				}
			},
			{
				303,
				new PokemonInfo()
				{
					ResourceName = "303 - Mawile",
					NameKey = "Pokemons_Mawile",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 85,
						defense = 85,
						specialAttack = 55,
						specialDefense = 55,
						speed = 50
					}
				}
			},
			{
				304,
				new PokemonInfo()
				{
					ResourceName = "304 - Aron",
					NameKey = "Pokemons_Aron",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 70,
						defense = 100,
						specialAttack = 40,
						specialDefense = 40,
						speed = 30
					}
				}
			},
			{
				305,
				new PokemonInfo()
				{
					ResourceName = "305 - Lairon",
					NameKey = "Pokemons_Lairon",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 90,
						defense = 140,
						specialAttack = 50,
						specialDefense = 50,
						speed = 40
					}
				}
			},
			{
				306,
				new PokemonInfo()
				{
					ResourceName = "306 - Aggron",
					NameKey = "Pokemons_Aggron",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 110,
						defense = 180,
						specialAttack = 60,
						specialDefense = 60,
						speed = 50
					}
				}
			},
			{
				307,
				new PokemonInfo()
				{
					ResourceName = "307 - Meditite",
					NameKey = "Pokemons_Meditite",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 40,
						defense = 55,
						specialAttack = 40,
						specialDefense = 55,
						speed = 60
					}
				}
			},
			{
				308,
				new PokemonInfo()
				{
					ResourceName = "308 - Medicham",
					NameKey = "Pokemons_Medicham",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 60,
						defense = 75,
						specialAttack = 60,
						specialDefense = 75,
						speed = 80
					}
				}
			},
			{
				309,
				new PokemonInfo()
				{
					ResourceName = "309 - Electrike",
					NameKey = "Pokemons_Electrike",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 45,
						defense = 40,
						specialAttack = 65,
						specialDefense = 40,
						speed = 65
					}
				}
			},
			{
				310,
				new PokemonInfo()
				{
					ResourceName = "310 - Manectric",
					NameKey = "Pokemons_Manectric",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 75,
						defense = 60,
						specialAttack = 105,
						specialDefense = 60,
						speed = 105
					}
				}
			},
			{
				311,
				new PokemonInfo()
				{
					ResourceName = "311 - Plusle",
					NameKey = "Pokemons_Plusle",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 50,
						defense = 40,
						specialAttack = 85,
						specialDefense = 75,
						speed = 95
					}
				}
			},
			{
				312,
				new PokemonInfo()
				{
					ResourceName = "312 - Minun",
					NameKey = "Pokemons_Minun",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 40,
						defense = 50,
						specialAttack = 75,
						specialDefense = 85,
						speed = 95
					}
				}
			},
			{
				313,
				new PokemonInfo()
				{
					ResourceName = "313 - Volbeat",
					NameKey = "Pokemons_Volbeat",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 73,
						defense = 55,
						specialAttack = 47,
						specialDefense = 75,
						speed = 85
					}
				}
			},
			{
				314,
				new PokemonInfo()
				{
					ResourceName = "314 - Illumise",
					NameKey = "Pokemons_Illumise",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 47,
						defense = 55,
						specialAttack = 73,
						specialDefense = 75,
						speed = 85
					}
				}
			},
			{
				315,
				new PokemonInfo()
				{
					ResourceName = "315 - Roselia",
					NameKey = "Pokemons_Roselia",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 60,
						defense = 45,
						specialAttack = 100,
						specialDefense = 80,
						speed = 65
					}
				}
			},
			{
				316,
				new PokemonInfo()
				{
					ResourceName = "316 - Gulpin",
					NameKey = "Pokemons_Gulpin",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 43,
						defense = 53,
						specialAttack = 43,
						specialDefense = 53,
						speed = 40
					}
				}
			},
			{
				317,
				new PokemonInfo()
				{
					ResourceName = "317 - Swalot",
					NameKey = "Pokemons_Swalot",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 73,
						defense = 83,
						specialAttack = 73,
						specialDefense = 83,
						speed = 55
					}
				}
			},
			{
				318,
				new PokemonInfo()
				{
					ResourceName = "318 - Carvanha",
					NameKey = "Pokemons_Carvanha",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 90,
						defense = 20,
						specialAttack = 65,
						specialDefense = 20,
						speed = 65
					}
				}
			},
			{
				319,
				new PokemonInfo()
				{
					ResourceName = "319 - Sharpedo",
					NameKey = "Pokemons_Sharpedo",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 120,
						defense = 40,
						specialAttack = 95,
						specialDefense = 40,
						speed = 95
					}
				}
			},
			{
				320,
				new PokemonInfo()
				{
					ResourceName = "320 - Wailmer",
					NameKey = "Pokemons_Wailmer",
					Statistics = new Stats()
					{
						hp = 130,
						attack = 70,
						defense = 35,
						specialAttack = 70,
						specialDefense = 35,
						speed = 60
					}
				}
			},
			{
				321,
				new PokemonInfo()
				{
					ResourceName = "321 - Wailord",
					NameKey = "Pokemons_Wailord",
					Statistics = new Stats()
					{
						hp = 170,
						attack = 90,
						defense = 45,
						specialAttack = 90,
						specialDefense = 45,
						speed = 60
					}
				}
			},
			{
				322,
				new PokemonInfo()
				{
					ResourceName = "322 - Numel",
					NameKey = "Pokemons_Numel",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 60,
						defense = 40,
						specialAttack = 65,
						specialDefense = 45,
						speed = 35
					}
				}
			},
			{
				323,
				new PokemonInfo()
				{
					ResourceName = "323 - Camerupt",
					NameKey = "Pokemons_Camerupt",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 100,
						defense = 70,
						specialAttack = 105,
						specialDefense = 75,
						speed = 40
					}
				}
			},
			{
				324,
				new PokemonInfo()
				{
					ResourceName = "324 - Torkoal",
					NameKey = "Pokemons_Torkoal",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 85,
						defense = 140,
						specialAttack = 85,
						specialDefense = 70,
						speed = 20
					}
				}
			},
			{
				325,
				new PokemonInfo()
				{
					ResourceName = "325 - Spoink",
					NameKey = "Pokemons_Spoink",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 25,
						defense = 35,
						specialAttack = 70,
						specialDefense = 80,
						speed = 60
					}
				}
			},
			{
				326,
				new PokemonInfo()
				{
					ResourceName = "326 - Grumpig",
					NameKey = "Pokemons_Grumpig",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 45,
						defense = 65,
						specialAttack = 90,
						specialDefense = 110,
						speed = 80
					}
				}
			},
			{
				327,
				new PokemonInfo()
				{
					ResourceName = "327 - Spinda",
					NameKey = "Pokemons_Spinda",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 60,
						defense = 60,
						specialAttack = 60,
						specialDefense = 60,
						speed = 60
					}
				}
			},
			{
				328,
				new PokemonInfo()
				{
					ResourceName = "328 - Trapinch",
					NameKey = "Pokemons_Trapinch",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 100,
						defense = 45,
						specialAttack = 45,
						specialDefense = 45,
						speed = 10
					}
				}
			},
			{
				329,
				new PokemonInfo()
				{
					ResourceName = "329 - Vibrava",
					NameKey = "Pokemons_Vibrava",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 70,
						defense = 50,
						specialAttack = 50,
						specialDefense = 50,
						speed = 70
					}
				}
			},
			{
				330,
				new PokemonInfo()
				{
					ResourceName = "330 - Flygon",
					NameKey = "Pokemons_Flygon",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 100,
						defense = 80,
						specialAttack = 80,
						specialDefense = 80,
						speed = 100
					}
				}
			},
			{
				331,
				new PokemonInfo()
				{
					ResourceName = "331 - Cacnea",
					NameKey = "Pokemons_Cacnea",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 85,
						defense = 40,
						specialAttack = 85,
						specialDefense = 40,
						speed = 35
					}
				}
			},
			{
				332,
				new PokemonInfo()
				{
					ResourceName = "332 - Cacturne",
					NameKey = "Pokemons_Cacturne",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 115,
						defense = 60,
						specialAttack = 115,
						specialDefense = 60,
						speed = 55
					}
				}
			},
			{
				333,
				new PokemonInfo()
				{
					ResourceName = "333 - Swablu",
					NameKey = "Pokemons_Swablu",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 40,
						defense = 60,
						specialAttack = 40,
						specialDefense = 75,
						speed = 50
					}
				}
			},
			{
				334,
				new PokemonInfo()
				{
					ResourceName = "334 - Altaria",
					NameKey = "Pokemons_Altaria",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 70,
						defense = 90,
						specialAttack = 70,
						specialDefense = 105,
						speed = 80
					}
				}
			},
			{
				335,
				new PokemonInfo()
				{
					ResourceName = "335 - Zangoose",
					NameKey = "Pokemons_Zangoose",
					Statistics = new Stats()
					{
						hp = 73,
						attack = 115,
						defense = 60,
						specialAttack = 60,
						specialDefense = 60,
						speed = 90
					}
				}
			},
			{
				336,
				new PokemonInfo()
				{
					ResourceName = "336 - Seviper",
					NameKey = "Pokemons_Seviper",
					Statistics = new Stats()
					{
						hp = 73,
						attack = 100,
						defense = 60,
						specialAttack = 100,
						specialDefense = 60,
						speed = 65
					}
				}
			},
			{
				337,
				new PokemonInfo()
				{
					ResourceName = "337 - Lunatone",
					NameKey = "Pokemons_Lunatone",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 55,
						defense = 65,
						specialAttack = 95,
						specialDefense = 85,
						speed = 70
					}
				}
			},
			{
				338,
				new PokemonInfo()
				{
					ResourceName = "338 - Solrock",
					NameKey = "Pokemons_Solrock",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 95,
						defense = 85,
						specialAttack = 55,
						specialDefense = 65,
						speed = 70
					}
				}
			},
			{
				339,
				new PokemonInfo()
				{
					ResourceName = "339 - Barboach",
					NameKey = "Pokemons_Barboach",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 48,
						defense = 43,
						specialAttack = 46,
						specialDefense = 41,
						speed = 60
					}
				}
			},
			{
				340,
				new PokemonInfo()
				{
					ResourceName = "340 - Whiscash",
					NameKey = "Pokemons_Whiscash",
					Statistics = new Stats()
					{
						hp = 110,
						attack = 78,
						defense = 73,
						specialAttack = 76,
						specialDefense = 71,
						speed = 60
					}
				}
			},
			{
				341,
				new PokemonInfo()
				{
					ResourceName = "341 - Corphish",
					NameKey = "Pokemons_Corphish",
					Statistics = new Stats()
					{
						hp = 43,
						attack = 80,
						defense = 65,
						specialAttack = 50,
						specialDefense = 35,
						speed = 35
					}
				}
			},
			{
				342,
				new PokemonInfo()
				{
					ResourceName = "342 - Crawdaunt",
					NameKey = "Pokemons_Crawdaunt",
					Statistics = new Stats()
					{
						hp = 63,
						attack = 120,
						defense = 85,
						specialAttack = 90,
						specialDefense = 55,
						speed = 55
					}
				}
			},
			{
				343,
				new PokemonInfo()
				{
					ResourceName = "343 - Baltoy",
					NameKey = "Pokemons_Baltoy",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 40,
						defense = 55,
						specialAttack = 40,
						specialDefense = 70,
						speed = 55
					}
				}
			},
			{
				344,
				new PokemonInfo()
				{
					ResourceName = "344 - Claydol",
					NameKey = "Pokemons_Claydol",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 70,
						defense = 105,
						specialAttack = 70,
						specialDefense = 120,
						speed = 75
					}
				}
			},
			{
				345,
				new PokemonInfo()
				{
					ResourceName = "345 - Lileep",
					NameKey = "Pokemons_Lileep",
					Statistics = new Stats()
					{
						hp = 66,
						attack = 41,
						defense = 77,
						specialAttack = 61,
						specialDefense = 87,
						speed = 23
					}
				}
			},
			{
				346,
				new PokemonInfo()
				{
					ResourceName = "346 - Cradily",
					NameKey = "Pokemons_Cradily",
					Statistics = new Stats()
					{
						hp = 86,
						attack = 81,
						defense = 97,
						specialAttack = 81,
						specialDefense = 107,
						speed = 43
					}
				}
			},
			{
				347,
				new PokemonInfo()
				{
					ResourceName = "347 - Anorith",
					NameKey = "Pokemons_Anorith",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 95,
						defense = 50,
						specialAttack = 40,
						specialDefense = 50,
						speed = 75
					}
				}
			},
			{
				348,
				new PokemonInfo()
				{
					ResourceName = "348 - Armaldo",
					NameKey = "Pokemons_Armaldo",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 125,
						defense = 100,
						specialAttack = 70,
						specialDefense = 80,
						speed = 45
					}
				}
			},
			{
				349,
				new PokemonInfo()
				{
					ResourceName = "349 - Feebas",
					NameKey = "Pokemons_Feebas",
					Statistics = new Stats()
					{
						hp = 20,
						attack = 15,
						defense = 20,
						specialAttack = 10,
						specialDefense = 55,
						speed = 80
					}
				}
			},
			{
				350,
				new PokemonInfo()
				{
					ResourceName = "350 - Milotic",
					NameKey = "Pokemons_Milotic",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 60,
						defense = 79,
						specialAttack = 100,
						specialDefense = 125,
						speed = 81
					}
				}
			},
			{
				351,
				new PokemonInfo()
				{
					ResourceName = "351 - Castform",
					NameKey = "Pokemons_Castform",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 70,
						defense = 70,
						specialAttack = 70,
						specialDefense = 70,
						speed = 70
					}
				}
			},
			{
				352,
				new PokemonInfo()
				{
					ResourceName = "352 - Kecleon",
					NameKey = "Pokemons_Kecleon",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 90,
						defense = 70,
						specialAttack = 60,
						specialDefense = 120,
						speed = 40
					}
				}
			},
			{
				353,
				new PokemonInfo()
				{
					ResourceName = "353 - Shuppet",
					NameKey = "Pokemons_Shuppet",
					Statistics = new Stats()
					{
						hp = 44,
						attack = 75,
						defense = 35,
						specialAttack = 63,
						specialDefense = 33,
						speed = 45
					}
				}
			},
			{
				354,
				new PokemonInfo()
				{
					ResourceName = "354 - Banette",
					NameKey = "Pokemons_Banette",
					Statistics = new Stats()
					{
						hp = 64,
						attack = 115,
						defense = 65,
						specialAttack = 83,
						specialDefense = 63,
						speed = 65
					}
				}
			},
			{
				355,
				new PokemonInfo()
				{
					ResourceName = "355 - Duskull",
					NameKey = "Pokemons_Duskull",
					Statistics = new Stats()
					{
						hp = 20,
						attack = 40,
						defense = 90,
						specialAttack = 30,
						specialDefense = 90,
						speed = 25
					}
				}
			},
			{
				356,
				new PokemonInfo()
				{
					ResourceName = "356 - Dusclops",
					NameKey = "Pokemons_Dusclops",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 70,
						defense = 130,
						specialAttack = 60,
						specialDefense = 130,
						speed = 25
					}
				}
			},
			{
				357,
				new PokemonInfo()
				{
					ResourceName = "357 - Tropius",
					NameKey = "Pokemons_Tropius",
					Statistics = new Stats()
					{
						hp = 99,
						attack = 68,
						defense = 83,
						specialAttack = 72,
						specialDefense = 87,
						speed = 51
					}
				}
			},
			{
				358,
				new PokemonInfo()
				{
					ResourceName = "358 - Chimecho",
					NameKey = "Pokemons_Chimecho",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 50,
						defense = 70,
						specialAttack = 95,
						specialDefense = 80,
						speed = 65
					}
				}
			},
			{
				359,
				new PokemonInfo()
				{
					ResourceName = "359 - Absol",
					NameKey = "Pokemons_Absol",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 130,
						defense = 60,
						specialAttack = 75,
						specialDefense = 60,
						speed = 75
					}
				}
			},
			{
				360,
				new PokemonInfo()
				{
					ResourceName = "360 - Wynaut",
					NameKey = "Pokemons_Wynaut",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 23,
						defense = 48,
						specialAttack = 23,
						specialDefense = 48,
						speed = 23
					}
				}
			},
			{
				361,
				new PokemonInfo()
				{
					ResourceName = "361 - Snorunt",
					NameKey = "Pokemons_Snorunt",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 50,
						defense = 50,
						specialAttack = 50,
						specialDefense = 50,
						speed = 50
					}
				}
			},
			{
				362,
				new PokemonInfo()
				{
					ResourceName = "362 - Glalie",
					NameKey = "Pokemons_Glalie",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 80,
						defense = 80,
						specialAttack = 80,
						specialDefense = 80,
						speed = 80
					}
				}
			},
			{
				363,
				new PokemonInfo()
				{
					ResourceName = "363 - Spheal",
					NameKey = "Pokemons_Spheal",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 40,
						defense = 50,
						specialAttack = 55,
						specialDefense = 50,
						speed = 25
					}
				}
			},
			{
				364,
				new PokemonInfo()
				{
					ResourceName = "364 - Sealeo",
					NameKey = "Pokemons_Sealeo",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 60,
						defense = 70,
						specialAttack = 75,
						specialDefense = 70,
						speed = 45
					}
				}
			},
			{
				365,
				new PokemonInfo()
				{
					ResourceName = "365 - Walrein",
					NameKey = "Pokemons_Walrein",
					Statistics = new Stats()
					{
						hp = 110,
						attack = 80,
						defense = 90,
						specialAttack = 95,
						specialDefense = 90,
						speed = 65
					}
				}
			},
			{
				366,
				new PokemonInfo()
				{
					ResourceName = "366 - Clamperl",
					NameKey = "Pokemons_Clamperl",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 64,
						defense = 85,
						specialAttack = 74,
						specialDefense = 55,
						speed = 32
					}
				}
			},
			{
				367,
				new PokemonInfo()
				{
					ResourceName = "367 - Huntail",
					NameKey = "Pokemons_Huntail",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 104,
						defense = 105,
						specialAttack = 94,
						specialDefense = 75,
						speed = 52
					}
				}
			},
			{
				368,
				new PokemonInfo()
				{
					ResourceName = "368 - Gorebyss",
					NameKey = "Pokemons_Gorebyss",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 84,
						defense = 105,
						specialAttack = 114,
						specialDefense = 75,
						speed = 52
					}
				}
			},
			{
				369,
				new PokemonInfo()
				{
					ResourceName = "369 - Relicanth",
					NameKey = "Pokemons_Relicanth",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 90,
						defense = 130,
						specialAttack = 45,
						specialDefense = 65,
						speed = 55
					}
				}
			},
			{
				370,
				new PokemonInfo()
				{
					ResourceName = "370 - Luvdisc",
					NameKey = "Pokemons_Luvdisc",
					Statistics = new Stats()
					{
						hp = 43,
						attack = 30,
						defense = 55,
						specialAttack = 40,
						specialDefense = 65,
						speed = 97
					}
				}
			},
			{
				371,
				new PokemonInfo()
				{
					ResourceName = "371 - Bagon",
					NameKey = "Pokemons_Bagon",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 75,
						defense = 60,
						specialAttack = 40,
						specialDefense = 30,
						speed = 50
					}
				}
			},
			{
				372,
				new PokemonInfo()
				{
					ResourceName = "372 - Shelgon",
					NameKey = "Pokemons_Shelgon",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 95,
						defense = 100,
						specialAttack = 60,
						specialDefense = 50,
						speed = 50
					}
				}
			},
			{
				373,
				new PokemonInfo()
				{
					ResourceName = "373 - Salamence",
					NameKey = "Pokemons_Salamence",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 135,
						defense = 80,
						specialAttack = 110,
						specialDefense = 80,
						speed = 100
					}
				}
			},
			{
				374,
				new PokemonInfo()
				{
					ResourceName = "374 - Beldum",
					NameKey = "Pokemons_Beldum",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 55,
						defense = 80,
						specialAttack = 35,
						specialDefense = 60,
						speed = 30
					}
				}
			},
			{
				375,
				new PokemonInfo()
				{
					ResourceName = "375 - Metang",
					NameKey = "Pokemons_Metang",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 75,
						defense = 100,
						specialAttack = 55,
						specialDefense = 80,
						speed = 50
					}
				}
			},
			{
				376,
				new PokemonInfo()
				{
					ResourceName = "376 - Metagross",
					NameKey = "Pokemons_Metagross",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 135,
						defense = 130,
						specialAttack = 95,
						specialDefense = 90,
						speed = 70
					}
				}
			},
			{
				377,
				new PokemonInfo()
				{
					ResourceName = "377 - Regirock",
					NameKey = "Pokemons_Regirock",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 100,
						defense = 200,
						specialAttack = 50,
						specialDefense = 100,
						speed = 50
					}
				}
			},
			{
				378,
				new PokemonInfo()
				{
					ResourceName = "378 - Regice",
					NameKey = "Pokemons_Regice",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 50,
						defense = 100,
						specialAttack = 100,
						specialDefense = 200,
						speed = 50
					}
				}
			},
			{
				379,
				new PokemonInfo()
				{
					ResourceName = "379 - Registeel",
					NameKey = "Pokemons_Registeel",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 75,
						defense = 150,
						specialAttack = 75,
						specialDefense = 150,
						speed = 50
					}
				}
			},
			{
				380,
				new PokemonInfo()
				{
					ResourceName = "380 - Latias",
					NameKey = "Pokemons_Latias",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 80,
						defense = 90,
						specialAttack = 110,
						specialDefense = 130,
						speed = 110
					}
				}
			},
			{
				381,
				new PokemonInfo()
				{
					ResourceName = "381 - Latios",
					NameKey = "Pokemons_Latios",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 90,
						defense = 80,
						specialAttack = 130,
						specialDefense = 110,
						speed = 110
					}
				}
			},
			{
				382,
				new PokemonInfo()
				{
					ResourceName = "382 - Kyogre",
					NameKey = "Pokemons_Kyogre",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 100,
						defense = 90,
						specialAttack = 150,
						specialDefense = 140,
						speed = 90
					}
				}
			},
			{
				383,
				new PokemonInfo()
				{
					ResourceName = "383 - Groudon",
					NameKey = "Pokemons_Groudon",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 150,
						defense = 140,
						specialAttack = 100,
						specialDefense = 90,
						speed = 90
					}
				}
			},
			{
				384,
				new PokemonInfo()
				{
					ResourceName = "384 - Rayquaza",
					NameKey = "Pokemons_Rayquaza",
					Statistics = new Stats()
					{
						hp = 105,
						attack = 150,
						defense = 90,
						specialAttack = 150,
						specialDefense = 90,
						speed = 95
					}
				}
			},
			{
				385,
				new PokemonInfo()
				{
					ResourceName = "385 - Jirachi",
					NameKey = "Pokemons_Jirachi",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 100,
						defense = 100,
						specialAttack = 100,
						specialDefense = 100,
						speed = 100
					}
				}
			},
			{
				386,
				new PokemonInfo()
				{
					ResourceName = "386 - Deoxys",
					NameKey = "Pokemons_Deoxys",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 150,
						defense = 50,
						specialAttack = 150,
						specialDefense = 50,
						speed = 150
					}
				}
			},
			{
				387,
				new PokemonInfo()
				{
					ResourceName = "387 - Turtwig",
					NameKey = "Pokemons_Turtwig",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 68,
						defense = 64,
						specialAttack = 45,
						specialDefense = 55,
						speed = 31
					}
				}
			},
			{
				388,
				new PokemonInfo()
				{
					ResourceName = "388 - Grotle",
					NameKey = "Pokemons_Grotle",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 89,
						defense = 85,
						specialAttack = 55,
						specialDefense = 65,
						speed = 36
					}
				}
			},
			{
				389,
				new PokemonInfo()
				{
					ResourceName = "389 - Torterra",
					NameKey = "Pokemons_Torterra",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 109,
						defense = 105,
						specialAttack = 75,
						specialDefense = 85,
						speed = 56
					}
				}
			},
			{
				390,
				new PokemonInfo()
				{
					ResourceName = "390 - Chimchar",
					NameKey = "Pokemons_Chimchar",
					Statistics = new Stats()
					{
						hp = 44,
						attack = 58,
						defense = 44,
						specialAttack = 58,
						specialDefense = 44,
						speed = 61
					}
				}
			},
			{
				391,
				new PokemonInfo()
				{
					ResourceName = "391 - Monferno",
					NameKey = "Pokemons_Monferno",
					Statistics = new Stats()
					{
						hp = 64,
						attack = 78,
						defense = 52,
						specialAttack = 78,
						specialDefense = 52,
						speed = 81
					}
				}
			},
			{
				392,
				new PokemonInfo()
				{
					ResourceName = "392 - Infernape",
					NameKey = "Pokemons_Infernape",
					Statistics = new Stats()
					{
						hp = 76,
						attack = 104,
						defense = 71,
						specialAttack = 104,
						specialDefense = 71,
						speed = 108
					}
				}
			},
			{
				393,
				new PokemonInfo()
				{
					ResourceName = "393 - Piplup",
					NameKey = "Pokemons_Piplup",
					Statistics = new Stats()
					{
						hp = 53,
						attack = 51,
						defense = 53,
						specialAttack = 61,
						specialDefense = 56,
						speed = 40
					}
				}
			},
			{
				394,
				new PokemonInfo()
				{
					ResourceName = "394 - Prinplup",
					NameKey = "Pokemons_Prinplup",
					Statistics = new Stats()
					{
						hp = 64,
						attack = 66,
						defense = 68,
						specialAttack = 81,
						specialDefense = 76,
						speed = 50
					}
				}
			},
			{
				395,
				new PokemonInfo()
				{
					ResourceName = "395 - Empoleon",
					NameKey = "Pokemons_Empoleon",
					Statistics = new Stats()
					{
						hp = 84,
						attack = 86,
						defense = 88,
						specialAttack = 111,
						specialDefense = 101,
						speed = 60
					}
				}
			},
			{
				396,
				new PokemonInfo()
				{
					ResourceName = "396 - Starly",
					NameKey = "Pokemons_Starly",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 55,
						defense = 30,
						specialAttack = 30,
						specialDefense = 30,
						speed = 60
					}
				}
			},
			{
				397,
				new PokemonInfo()
				{
					ResourceName = "397 - Staravia",
					NameKey = "Pokemons_Staravia",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 75,
						defense = 50,
						specialAttack = 40,
						specialDefense = 40,
						speed = 80
					}
				}
			},
			{
				398,
				new PokemonInfo()
				{
					ResourceName = "398 - Staraptor",
					NameKey = "Pokemons_Staraptor",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 120,
						defense = 70,
						specialAttack = 50,
						specialDefense = 50,
						speed = 100
					}
				}
			},
			{
				399,
				new PokemonInfo()
				{
					ResourceName = "399 - Bidoof",
					NameKey = "Pokemons_Bidoof",
					Statistics = new Stats()
					{
						hp = 59,
						attack = 45,
						defense = 40,
						specialAttack = 35,
						specialDefense = 40,
						speed = 31
					}
				}
			},
			{
				400,
				new PokemonInfo()
				{
					ResourceName = "400 - Bibarel",
					NameKey = "Pokemons_Bibarel",
					Statistics = new Stats()
					{
						hp = 79,
						attack = 85,
						defense = 60,
						specialAttack = 55,
						specialDefense = 60,
						speed = 71
					}
				}
			},
			{
				401,
				new PokemonInfo()
				{
					ResourceName = "401 - Kricketot",
					NameKey = "Pokemons_Kricketot",
					Statistics = new Stats()
					{
						hp = 37,
						attack = 25,
						defense = 41,
						specialAttack = 25,
						specialDefense = 41,
						speed = 25
					}
				}
			},
			{
				402,
				new PokemonInfo()
				{
					ResourceName = "402 - Kricketune",
					NameKey = "Pokemons_Kricketune",
					Statistics = new Stats()
					{
						hp = 77,
						attack = 85,
						defense = 51,
						specialAttack = 55,
						specialDefense = 51,
						speed = 65
					}
				}
			},
			{
				403,
				new PokemonInfo()
				{
					ResourceName = "403 - Shinx",
					NameKey = "Pokemons_Shinx",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 65,
						defense = 34,
						specialAttack = 40,
						specialDefense = 34,
						speed = 45
					}
				}
			},
			{
				404,
				new PokemonInfo()
				{
					ResourceName = "404 - Luxio",
					NameKey = "Pokemons_Luxio",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 85,
						defense = 49,
						specialAttack = 60,
						specialDefense = 49,
						speed = 60
					}
				}
			},
			{
				405,
				new PokemonInfo()
				{
					ResourceName = "405 - Luxray",
					NameKey = "Pokemons_Luxray",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 120,
						defense = 79,
						specialAttack = 95,
						specialDefense = 79,
						speed = 70
					}
				}
			},
			{
				406,
				new PokemonInfo()
				{
					ResourceName = "406 - Budew",
					NameKey = "Pokemons_Budew",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 30,
						defense = 35,
						specialAttack = 50,
						specialDefense = 70,
						speed = 55
					}
				}
			},
			{
				407,
				new PokemonInfo()
				{
					ResourceName = "407 - Roserade",
					NameKey = "Pokemons_Roserade",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 70,
						defense = 55,
						specialAttack = 125,
						specialDefense = 105,
						speed = 90
					}
				}
			},
			{
				408,
				new PokemonInfo()
				{
					ResourceName = "408 - Cranidos",
					NameKey = "Pokemons_Cranidos",
					Statistics = new Stats()
					{
						hp = 67,
						attack = 125,
						defense = 40,
						specialAttack = 30,
						specialDefense = 30,
						speed = 58
					}
				}
			},
			{
				409,
				new PokemonInfo()
				{
					ResourceName = "409 - Rampardos",
					NameKey = "Pokemons_Rampardos",
					Statistics = new Stats()
					{
						hp = 97,
						attack = 165,
						defense = 60,
						specialAttack = 65,
						specialDefense = 50,
						speed = 58
					}
				}
			},
			{
				410,
				new PokemonInfo()
				{
					ResourceName = "410 - Shieldon",
					NameKey = "Pokemons_Shieldon",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 42,
						defense = 118,
						specialAttack = 42,
						specialDefense = 88,
						speed = 30
					}
				}
			},
			{
				411,
				new PokemonInfo()
				{
					ResourceName = "411 - Bastiodon",
					NameKey = "Pokemons_Bastiodon",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 52,
						defense = 168,
						specialAttack = 47,
						specialDefense = 138,
						speed = 30
					}
				}
			},
			{
				412,
				new PokemonInfo()
				{
					ResourceName = "412 - Burmy",
					NameKey = "Pokemons_Burmy",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 29,
						defense = 45,
						specialAttack = 29,
						specialDefense = 45,
						speed = 36
					}
				}
			},
			{
				413,
				new PokemonInfo()
				{
					ResourceName = "413 - Wormadam",
					NameKey = "Pokemons_Wormadam",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 59,
						defense = 85,
						specialAttack = 79,
						specialDefense = 105,
						speed = 36
					}
				}
			},
			{
				414,
				new PokemonInfo()
				{
					ResourceName = "414 - Mothim",
					NameKey = "Pokemons_Mothim",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 94,
						defense = 50,
						specialAttack = 94,
						specialDefense = 50,
						speed = 66
					}
				}
			},
			{
				415,
				new PokemonInfo()
				{
					ResourceName = "415 - Combee",
					NameKey = "Pokemons_Combee",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 30,
						defense = 42,
						specialAttack = 30,
						specialDefense = 42,
						speed = 70
					}
				}
			},
			{
				416,
				new PokemonInfo()
				{
					ResourceName = "416 - Vespiquen",
					NameKey = "Pokemons_Vespiquen",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 80,
						defense = 102,
						specialAttack = 80,
						specialDefense = 102,
						speed = 40
					}
				}
			},
			{
				417,
				new PokemonInfo()
				{
					ResourceName = "417 - Pachirisu",
					NameKey = "Pokemons_Pachirisu",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 45,
						defense = 70,
						specialAttack = 45,
						specialDefense = 90,
						speed = 95
					}
				}
			},
			{
				418,
				new PokemonInfo()
				{
					ResourceName = "418 - Buizel",
					NameKey = "Pokemons_Buizel",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 65,
						defense = 35,
						specialAttack = 60,
						specialDefense = 30,
						speed = 85
					}
				}
			},
			{
				419,
				new PokemonInfo()
				{
					ResourceName = "419 - Floatzel",
					NameKey = "Pokemons_Floatzel",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 105,
						defense = 55,
						specialAttack = 85,
						specialDefense = 50,
						speed = 115
					}
				}
			},
			{
				420,
				new PokemonInfo()
				{
					ResourceName = "420 - Cherubi",
					NameKey = "Pokemons_Cherubi",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 35,
						defense = 45,
						specialAttack = 62,
						specialDefense = 53,
						speed = 35
					}
				}
			},
			{
				421,
				new PokemonInfo()
				{
					ResourceName = "421 - Cherrim",
					NameKey = "Pokemons_Cherrim",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 60,
						defense = 70,
						specialAttack = 87,
						specialDefense = 78,
						speed = 85
					}
				}
			},
			{
				422,
				new PokemonInfo()
				{
					ResourceName = "422 - Shellos",
					NameKey = "Pokemons_Shellos",
					Statistics = new Stats()
					{
						hp = 76,
						attack = 48,
						defense = 48,
						specialAttack = 57,
						specialDefense = 62,
						speed = 34
					}
				}
			},
			{
				423,
				new PokemonInfo()
				{
					ResourceName = "423 - Gastrodon",
					NameKey = "Pokemons_Gastrodon",
					Statistics = new Stats()
					{
						hp = 111,
						attack = 83,
						defense = 68,
						specialAttack = 92,
						specialDefense = 82,
						speed = 39
					}
				}
			},
			{
				424,
				new PokemonInfo()
				{
					ResourceName = "424 - Ambipom",
					NameKey = "Pokemons_Ambipom",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 100,
						defense = 66,
						specialAttack = 60,
						specialDefense = 66,
						speed = 115
					}
				}
			},
			{
				425,
				new PokemonInfo()
				{
					ResourceName = "425 - Drifloon",
					NameKey = "Pokemons_Drifloon",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 50,
						defense = 34,
						specialAttack = 60,
						specialDefense = 44,
						speed = 70
					}
				}
			},
			{
				426,
				new PokemonInfo()
				{
					ResourceName = "426 - Drifblim",
					NameKey = "Pokemons_Drifblim",
					Statistics = new Stats()
					{
						hp = 150,
						attack = 80,
						defense = 44,
						specialAttack = 90,
						specialDefense = 54,
						speed = 80
					}
				}
			},
			{
				427,
				new PokemonInfo()
				{
					ResourceName = "427 - Buneary",
					NameKey = "Pokemons_Buneary",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 66,
						defense = 44,
						specialAttack = 44,
						specialDefense = 56,
						speed = 85
					}
				}
			},
			{
				428,
				new PokemonInfo()
				{
					ResourceName = "428 - Lopunny",
					NameKey = "Pokemons_Lopunny",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 76,
						defense = 84,
						specialAttack = 54,
						specialDefense = 96,
						speed = 105
					}
				}
			},
			{
				429,
				new PokemonInfo()
				{
					ResourceName = "429 - Mismagius",
					NameKey = "Pokemons_Mismagius",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 60,
						defense = 60,
						specialAttack = 105,
						specialDefense = 105,
						speed = 105
					}
				}
			},
			{
				430,
				new PokemonInfo()
				{
					ResourceName = "430 - Honchkrow",
					NameKey = "Pokemons_Honchkrow",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 125,
						defense = 52,
						specialAttack = 105,
						specialDefense = 52,
						speed = 71
					}
				}
			},
			{
				431,
				new PokemonInfo()
				{
					ResourceName = "431 - Glameow",
					NameKey = "Pokemons_Glameow",
					Statistics = new Stats()
					{
						hp = 49,
						attack = 55,
						defense = 42,
						specialAttack = 42,
						specialDefense = 37,
						speed = 85
					}
				}
			},
			{
				432,
				new PokemonInfo()
				{
					ResourceName = "432 - Purugly",
					NameKey = "Pokemons_Purugly",
					Statistics = new Stats()
					{
						hp = 71,
						attack = 82,
						defense = 64,
						specialAttack = 64,
						specialDefense = 59,
						speed = 112
					}
				}
			},
			{
				433,
				new PokemonInfo()
				{
					ResourceName = "433 - Chingling",
					NameKey = "Pokemons_Chingling",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 30,
						defense = 50,
						specialAttack = 65,
						specialDefense = 50,
						speed = 45
					}
				}
			},
			{
				434,
				new PokemonInfo()
				{
					ResourceName = "434 - Stunky",
					NameKey = "Pokemons_Stunky",
					Statistics = new Stats()
					{
						hp = 63,
						attack = 63,
						defense = 47,
						specialAttack = 41,
						specialDefense = 41,
						speed = 74
					}
				}
			},
			{
				435,
				new PokemonInfo()
				{
					ResourceName = "435 - Skuntank",
					NameKey = "Pokemons_Skuntank",
					Statistics = new Stats()
					{
						hp = 103,
						attack = 93,
						defense = 67,
						specialAttack = 71,
						specialDefense = 61,
						speed = 84
					}
				}
			},
			{
				436,
				new PokemonInfo()
				{
					ResourceName = "436 - Bronzor",
					NameKey = "Pokemons_Bronzor",
					Statistics = new Stats()
					{
						hp = 57,
						attack = 24,
						defense = 86,
						specialAttack = 24,
						specialDefense = 86,
						speed = 23
					}
				}
			},
			{
				437,
				new PokemonInfo()
				{
					ResourceName = "437 - Bronzong",
					NameKey = "Pokemons_Bronzong",
					Statistics = new Stats()
					{
						hp = 67,
						attack = 89,
						defense = 116,
						specialAttack = 79,
						specialDefense = 116,
						speed = 33
					}
				}
			},
			{
				438,
				new PokemonInfo()
				{
					ResourceName = "438 - Bonsly",
					NameKey = "Pokemons_Bonsly",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 80,
						defense = 95,
						specialAttack = 10,
						specialDefense = 45,
						speed = 10
					}
				}
			},
			{
				439,
				new PokemonInfo()
				{
					ResourceName = "439 - Mime Jr.",
					NameKey = "Pokemons_Mime Jr.",
					Statistics = new Stats()
					{
						hp = 20,
						attack = 25,
						defense = 45,
						specialAttack = 70,
						specialDefense = 90,
						speed = 60
					}
				}
			},
			{
				440,
				new PokemonInfo()
				{
					ResourceName = "440 - Happiny",
					NameKey = "Pokemons_Happiny",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 5,
						defense = 5,
						specialAttack = 15,
						specialDefense = 65,
						speed = 30
					}
				}
			},
			{
				441,
				new PokemonInfo()
				{
					ResourceName = "441 - Chatot",
					NameKey = "Pokemons_Chatot",
					Statistics = new Stats()
					{
						hp = 76,
						attack = 65,
						defense = 45,
						specialAttack = 92,
						specialDefense = 42,
						speed = 91
					}
				}
			},
			{
				442,
				new PokemonInfo()
				{
					ResourceName = "442 - Spiritomb",
					NameKey = "Pokemons_Spiritomb",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 92,
						defense = 108,
						specialAttack = 92,
						specialDefense = 108,
						speed = 35
					}
				}
			},
			{
				443,
				new PokemonInfo()
				{
					ResourceName = "443 - Gible",
					NameKey = "Pokemons_Gible",
					Statistics = new Stats()
					{
						hp = 58,
						attack = 70,
						defense = 45,
						specialAttack = 40,
						specialDefense = 45,
						speed = 42
					}
				}
			},
			{
				444,
				new PokemonInfo()
				{
					ResourceName = "444 - Gabite",
					NameKey = "Pokemons_Gabite",
					Statistics = new Stats()
					{
						hp = 68,
						attack = 90,
						defense = 65,
						specialAttack = 50,
						specialDefense = 55,
						speed = 82
					}
				}
			},
			{
				445,
				new PokemonInfo()
				{
					ResourceName = "445 - Garchomp",
					NameKey = "Pokemons_Garchomp",
					Statistics = new Stats()
					{
						hp = 108,
						attack = 130,
						defense = 95,
						specialAttack = 80,
						specialDefense = 85,
						speed = 102
					}
				}
			},
			{
				446,
				new PokemonInfo()
				{
					ResourceName = "446 - Munchlax",
					NameKey = "Pokemons_Munchlax",
					Statistics = new Stats()
					{
						hp = 135,
						attack = 85,
						defense = 40,
						specialAttack = 40,
						specialDefense = 85,
						speed = 5
					}
				}
			},
			{
				447,
				new PokemonInfo()
				{
					ResourceName = "447 - Riolu",
					NameKey = "Pokemons_Riolu",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 70,
						defense = 40,
						specialAttack = 35,
						specialDefense = 40,
						speed = 60
					}
				}
			},
			{
				448,
				new PokemonInfo()
				{
					ResourceName = "448 - Lucario",
					NameKey = "Pokemons_Lucario",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 110,
						defense = 70,
						specialAttack = 115,
						specialDefense = 70,
						speed = 90
					}
				}
			},
			{
				449,
				new PokemonInfo()
				{
					ResourceName = "449 - Hippopotas",
					NameKey = "Pokemons_Hippopotas",
					Statistics = new Stats()
					{
						hp = 68,
						attack = 72,
						defense = 78,
						specialAttack = 38,
						specialDefense = 42,
						speed = 32
					}
				}
			},
			{
				450,
				new PokemonInfo()
				{
					ResourceName = "450 - Hippowdon",
					NameKey = "Pokemons_Hippowdon",
					Statistics = new Stats()
					{
						hp = 108,
						attack = 112,
						defense = 118,
						specialAttack = 68,
						specialDefense = 72,
						speed = 47
					}
				}
			},
			{
				451,
				new PokemonInfo()
				{
					ResourceName = "451 - Skorupi",
					NameKey = "Pokemons_Skorupi",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 50,
						defense = 90,
						specialAttack = 30,
						specialDefense = 55,
						speed = 65
					}
				}
			},
			{
				452,
				new PokemonInfo()
				{
					ResourceName = "452 - Drapion",
					NameKey = "Pokemons_Drapion",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 90,
						defense = 110,
						specialAttack = 60,
						specialDefense = 75,
						speed = 95
					}
				}
			},
			{
				453,
				new PokemonInfo()
				{
					ResourceName = "453 - Croagunk",
					NameKey = "Pokemons_Croagunk",
					Statistics = new Stats()
					{
						hp = 48,
						attack = 61,
						defense = 40,
						specialAttack = 61,
						specialDefense = 40,
						speed = 50
					}
				}
			},
			{
				454,
				new PokemonInfo()
				{
					ResourceName = "454 - Toxicroak",
					NameKey = "Pokemons_Toxicroak",
					Statistics = new Stats()
					{
						hp = 83,
						attack = 106,
						defense = 65,
						specialAttack = 86,
						specialDefense = 65,
						speed = 85
					}
				}
			},
			{
				455,
				new PokemonInfo()
				{
					ResourceName = "455 - Carnivine",
					NameKey = "Pokemons_Carnivine",
					Statistics = new Stats()
					{
						hp = 74,
						attack = 100,
						defense = 72,
						specialAttack = 90,
						specialDefense = 72,
						speed = 46
					}
				}
			},
			{
				456,
				new PokemonInfo()
				{
					ResourceName = "456 - Finneon",
					NameKey = "Pokemons_Finneon",
					Statistics = new Stats()
					{
						hp = 49,
						attack = 49,
						defense = 56,
						specialAttack = 49,
						specialDefense = 61,
						speed = 66
					}
				}
			},
			{
				457,
				new PokemonInfo()
				{
					ResourceName = "457 - Lumineon",
					NameKey = "Pokemons_Lumineon",
					Statistics = new Stats()
					{
						hp = 69,
						attack = 69,
						defense = 76,
						specialAttack = 69,
						specialDefense = 86,
						speed = 91
					}
				}
			},
			{
				458,
				new PokemonInfo()
				{
					ResourceName = "458 - Mantyke",
					NameKey = "Pokemons_Mantyke",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 20,
						defense = 50,
						specialAttack = 60,
						specialDefense = 120,
						speed = 50
					}
				}
			},
			{
				459,
				new PokemonInfo()
				{
					ResourceName = "459 - Snover",
					NameKey = "Pokemons_Snover",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 62,
						defense = 50,
						specialAttack = 62,
						specialDefense = 60,
						speed = 40
					}
				}
			},
			{
				460,
				new PokemonInfo()
				{
					ResourceName = "460 - Abomasnow",
					NameKey = "Pokemons_Abomasnow",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 92,
						defense = 75,
						specialAttack = 92,
						specialDefense = 85,
						speed = 60
					}
				}
			},
			{
				461,
				new PokemonInfo()
				{
					ResourceName = "461 - Weavile",
					NameKey = "Pokemons_Weavile",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 120,
						defense = 65,
						specialAttack = 45,
						specialDefense = 85,
						speed = 125
					}
				}
			},
			{
				462,
				new PokemonInfo()
				{
					ResourceName = "462 - Magnezone",
					NameKey = "Pokemons_Magnezone",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 70,
						defense = 115,
						specialAttack = 130,
						specialDefense = 90,
						speed = 60
					}
				}
			},
			{
				463,
				new PokemonInfo()
				{
					ResourceName = "463 - Lickilicky",
					NameKey = "Pokemons_Lickilicky",
					Statistics = new Stats()
					{
						hp = 110,
						attack = 85,
						defense = 95,
						specialAttack = 80,
						specialDefense = 95,
						speed = 50
					}
				}
			},
			{
				464,
				new PokemonInfo()
				{
					ResourceName = "464 - Rhyperior",
					NameKey = "Pokemons_Rhyperior",
					Statistics = new Stats()
					{
						hp = 115,
						attack = 140,
						defense = 130,
						specialAttack = 55,
						specialDefense = 55,
						speed = 40
					}
				}
			},
			{
				465,
				new PokemonInfo()
				{
					ResourceName = "465 - Tangrowth",
					NameKey = "Pokemons_Tangrowth",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 100,
						defense = 125,
						specialAttack = 110,
						specialDefense = 50,
						speed = 50
					}
				}
			},
			{
				466,
				new PokemonInfo()
				{
					ResourceName = "466 - Electivire",
					NameKey = "Pokemons_Electivire",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 123,
						defense = 67,
						specialAttack = 95,
						specialDefense = 85,
						speed = 95
					}
				}
			},
			{
				467,
				new PokemonInfo()
				{
					ResourceName = "467 - Magmortar",
					NameKey = "Pokemons_Magmortar",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 95,
						defense = 67,
						specialAttack = 125,
						specialDefense = 95,
						speed = 83
					}
				}
			},
			{
				468,
				new PokemonInfo()
				{
					ResourceName = "468 - Togekiss",
					NameKey = "Pokemons_Togekiss",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 50,
						defense = 95,
						specialAttack = 120,
						specialDefense = 115,
						speed = 80
					}
				}
			},
			{
				469,
				new PokemonInfo()
				{
					ResourceName = "469 - Yanmega",
					NameKey = "Pokemons_Yanmega",
					Statistics = new Stats()
					{
						hp = 86,
						attack = 76,
						defense = 86,
						specialAttack = 116,
						specialDefense = 56,
						speed = 95
					}
				}
			},
			{
				470,
				new PokemonInfo()
				{
					ResourceName = "470 - Leafeon",
					NameKey = "Pokemons_Leafeon",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 110,
						defense = 130,
						specialAttack = 60,
						specialDefense = 65,
						speed = 95
					}
				}
			},
			{
				471,
				new PokemonInfo()
				{
					ResourceName = "471 - Glaceon",
					NameKey = "Pokemons_Glaceon",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 60,
						defense = 110,
						specialAttack = 130,
						specialDefense = 95,
						speed = 65
					}
				}
			},
			{
				472,
				new PokemonInfo()
				{
					ResourceName = "472 - Gliscor",
					NameKey = "Pokemons_Gliscor",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 95,
						defense = 125,
						specialAttack = 45,
						specialDefense = 75,
						speed = 95
					}
				}
			},
			{
				473,
				new PokemonInfo()
				{
					ResourceName = "473 - Mamoswine",
					NameKey = "Pokemons_Mamoswine",
					Statistics = new Stats()
					{
						hp = 110,
						attack = 130,
						defense = 80,
						specialAttack = 70,
						specialDefense = 60,
						speed = 80
					}
				}
			},
			{
				474,
				new PokemonInfo()
				{
					ResourceName = "474 - Porygon-Z",
					NameKey = "Pokemons_Porygon-Z",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 80,
						defense = 70,
						specialAttack = 135,
						specialDefense = 75,
						speed = 90
					}
				}
			},
			{
				475,
				new PokemonInfo()
				{
					ResourceName = "475 - Gallade",
					NameKey = "Pokemons_Gallade",
					Statistics = new Stats()
					{
						hp = 68,
						attack = 125,
						defense = 65,
						specialAttack = 65,
						specialDefense = 115,
						speed = 80
					}
				}
			},
			{
				476,
				new PokemonInfo()
				{
					ResourceName = "476 - Probopass",
					NameKey = "Pokemons_Probopass",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 55,
						defense = 145,
						specialAttack = 75,
						specialDefense = 150,
						speed = 40
					}
				}
			},
			{
				477,
				new PokemonInfo()
				{
					ResourceName = "477 - Dusknoir",
					NameKey = "Pokemons_Dusknoir",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 100,
						defense = 135,
						specialAttack = 65,
						specialDefense = 135,
						speed = 45
					}
				}
			},
			{
				478,
				new PokemonInfo()
				{
					ResourceName = "478 - Froslass",
					NameKey = "Pokemons_Froslass",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 80,
						defense = 70,
						specialAttack = 80,
						specialDefense = 70,
						speed = 110
					}
				}
			},
			{
				479,
				new PokemonInfo()
				{
					ResourceName = "479 - Rotom",
					NameKey = "Pokemons_Rotom",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 50,
						defense = 77,
						specialAttack = 95,
						specialDefense = 77,
						speed = 91
					}
				}
			},
			{
				480,
				new PokemonInfo()
				{
					ResourceName = "480 - Uxie",
					NameKey = "Pokemons_Uxie",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 75,
						defense = 130,
						specialAttack = 75,
						specialDefense = 130,
						speed = 95
					}
				}
			},
			{
				481,
				new PokemonInfo()
				{
					ResourceName = "481 - Mesprit",
					NameKey = "Pokemons_Mesprit",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 105,
						defense = 105,
						specialAttack = 105,
						specialDefense = 105,
						speed = 80
					}
				}
			},
			{
				482,
				new PokemonInfo()
				{
					ResourceName = "482 - Azelf",
					NameKey = "Pokemons_Azelf",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 125,
						defense = 70,
						specialAttack = 125,
						specialDefense = 70,
						speed = 115
					}
				}
			},
			{
				483,
				new PokemonInfo()
				{
					ResourceName = "483 - Dialga",
					NameKey = "Pokemons_Dialga",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 120,
						defense = 120,
						specialAttack = 150,
						specialDefense = 100,
						speed = 90
					}
				}
			},
			{
				484,
				new PokemonInfo()
				{
					ResourceName = "484 - Palkia",
					NameKey = "Pokemons_Palkia",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 120,
						defense = 100,
						specialAttack = 150,
						specialDefense = 120,
						speed = 100
					}
				}
			},
			{
				485,
				new PokemonInfo()
				{
					ResourceName = "485 - Heatran",
					NameKey = "Pokemons_Heatran",
					Statistics = new Stats()
					{
						hp = 91,
						attack = 90,
						defense = 106,
						specialAttack = 130,
						specialDefense = 106,
						speed = 77
					}
				}
			},
			{
				486,
				new PokemonInfo()
				{
					ResourceName = "486 - Regigigas",
					NameKey = "Pokemons_Regigigas",
					Statistics = new Stats()
					{
						hp = 110,
						attack = 160,
						defense = 110,
						specialAttack = 80,
						specialDefense = 110,
						speed = 100
					}
				}
			},
			{
				487,
				new PokemonInfo()
				{
					ResourceName = "487 - Giratina",
					NameKey = "Pokemons_Giratina",
					Statistics = new Stats()
					{
						hp = 150,
						attack = 100,
						defense = 120,
						specialAttack = 100,
						specialDefense = 120,
						speed = 90
					}
				}
			},
			{
				488,
				new PokemonInfo()
				{
					ResourceName = "488 - Cresselia",
					NameKey = "Pokemons_Cresselia",
					Statistics = new Stats()
					{
						hp = 120,
						attack = 70,
						defense = 120,
						specialAttack = 75,
						specialDefense = 130,
						speed = 85
					}
				}
			},
			{
				489,
				new PokemonInfo()
				{
					ResourceName = "489 - Phione",
					NameKey = "Pokemons_Phione",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 80,
						defense = 80,
						specialAttack = 80,
						specialDefense = 80,
						speed = 80
					}
				}
			},
			{
				490,
				new PokemonInfo()
				{
					ResourceName = "490 - Manaphy",
					NameKey = "Pokemons_Manaphy",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 100,
						defense = 100,
						specialAttack = 100,
						specialDefense = 100,
						speed = 100
					}
				}
			},
			{
				491,
				new PokemonInfo()
				{
					ResourceName = "491 - Darkrai",
					NameKey = "Pokemons_Darkrai",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 90,
						defense = 90,
						specialAttack = 135,
						specialDefense = 90,
						speed = 125
					}
				}
			},
			{
				492,
				new PokemonInfo()
				{
					ResourceName = "492 - Shaymin",
					NameKey = "Pokemons_Shaymin",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 100,
						defense = 100,
						specialAttack = 100,
						specialDefense = 100,
						speed = 100
					}
				}
			},
			{
				493,
				new PokemonInfo()
				{
					ResourceName = "493 - Arceus",
					NameKey = "Pokemons_Arceus",
					Statistics = new Stats()
					{
						hp = 120,
						attack = 120,
						defense = 120,
						specialAttack = 120,
						specialDefense = 120,
						speed = 120
					}
				}
			},
			{
				494,
				new PokemonInfo()
				{
					ResourceName = "494 - Victini",
					NameKey = "Pokemons_Victini",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 100,
						defense = 100,
						specialAttack = 100,
						specialDefense = 100,
						speed = 100
					}
				}
			},
			{
				495,
				new PokemonInfo()
				{
					ResourceName = "495 - Snivy",
					NameKey = "Pokemons_Snivy",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 45,
						defense = 55,
						specialAttack = 45,
						specialDefense = 55,
						speed = 63
					}
				}
			},
			{
				496,
				new PokemonInfo()
				{
					ResourceName = "496 - Servine",
					NameKey = "Pokemons_Servine",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 60,
						defense = 75,
						specialAttack = 60,
						specialDefense = 75,
						speed = 83
					}
				}
			},
			{
				497,
				new PokemonInfo()
				{
					ResourceName = "497 - Serperior",
					NameKey = "Pokemons_Serperior",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 75,
						defense = 95,
						specialAttack = 75,
						specialDefense = 95,
						speed = 113
					}
				}
			},
			{
				498,
				new PokemonInfo()
				{
					ResourceName = "498 - Tepig",
					NameKey = "Pokemons_Tepig",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 63,
						defense = 45,
						specialAttack = 45,
						specialDefense = 45,
						speed = 45
					}
				}
			},
			{
				499,
				new PokemonInfo()
				{
					ResourceName = "499 - Pignite",
					NameKey = "Pokemons_Pignite",
					Statistics = new Stats()
					{
						hp = 90,
						attack = 93,
						defense = 55,
						specialAttack = 70,
						specialDefense = 55,
						speed = 55
					}
				}
			},
			{
				500,
				new PokemonInfo()
				{
					ResourceName = "500 - Emboar",
					NameKey = "Pokemons_Emboar",
					Statistics = new Stats()
					{
						hp = 110,
						attack = 123,
						defense = 65,
						specialAttack = 100,
						specialDefense = 65,
						speed = 65
					}
				}
			},
			{
				501,
				new PokemonInfo()
				{
					ResourceName = "501 - Oshawott",
					NameKey = "Pokemons_Oshawott",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 55,
						defense = 45,
						specialAttack = 63,
						specialDefense = 45,
						speed = 45
					}
				}
			},
			{
				502,
				new PokemonInfo()
				{
					ResourceName = "502 - Dewott",
					NameKey = "Pokemons_Dewott",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 75,
						defense = 60,
						specialAttack = 83,
						specialDefense = 60,
						speed = 60
					}
				}
			},
			{
				503,
				new PokemonInfo()
				{
					ResourceName = "503 - Samurott",
					NameKey = "Pokemons_Samurott",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 100,
						defense = 85,
						specialAttack = 108,
						specialDefense = 70,
						speed = 70
					}
				}
			},
			{
				504,
				new PokemonInfo()
				{
					ResourceName = "504 - Patrat",
					NameKey = "Pokemons_Patrat",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 55,
						defense = 39,
						specialAttack = 35,
						specialDefense = 39,
						speed = 42
					}
				}
			},
			{
				505,
				new PokemonInfo()
				{
					ResourceName = "505 - Watchog",
					NameKey = "Pokemons_Watchog",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 85,
						defense = 69,
						specialAttack = 60,
						specialDefense = 69,
						speed = 77
					}
				}
			},
			{
				506,
				new PokemonInfo()
				{
					ResourceName = "506 - Lillipup",
					NameKey = "Pokemons_Lillipup",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 60,
						defense = 45,
						specialAttack = 25,
						specialDefense = 45,
						speed = 55
					}
				}
			},
			{
				507,
				new PokemonInfo()
				{
					ResourceName = "507 - Herdier",
					NameKey = "Pokemons_Herdier",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 80,
						defense = 65,
						specialAttack = 35,
						specialDefense = 65,
						speed = 60
					}
				}
			},
			{
				508,
				new PokemonInfo()
				{
					ResourceName = "508 - Stoutland",
					NameKey = "Pokemons_Stoutland",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 100,
						defense = 90,
						specialAttack = 45,
						specialDefense = 90,
						speed = 80
					}
				}
			},
			{
				509,
				new PokemonInfo()
				{
					ResourceName = "509 - Purrloin",
					NameKey = "Pokemons_Purrloin",
					Statistics = new Stats()
					{
						hp = 41,
						attack = 50,
						defense = 37,
						specialAttack = 50,
						specialDefense = 37,
						speed = 66
					}
				}
			},
			{
				510,
				new PokemonInfo()
				{
					ResourceName = "510 - Liepard",
					NameKey = "Pokemons_Liepard",
					Statistics = new Stats()
					{
						hp = 64,
						attack = 88,
						defense = 50,
						specialAttack = 88,
						specialDefense = 50,
						speed = 106
					}
				}
			},
			{
				511,
				new PokemonInfo()
				{
					ResourceName = "511 - Pansage",
					NameKey = "Pokemons_Pansage",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 53,
						defense = 48,
						specialAttack = 53,
						specialDefense = 48,
						speed = 64
					}
				}
			},
			{
				512,
				new PokemonInfo()
				{
					ResourceName = "512 - Simisage",
					NameKey = "Pokemons_Simisage",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 98,
						defense = 63,
						specialAttack = 98,
						specialDefense = 63,
						speed = 101
					}
				}
			},
			{
				513,
				new PokemonInfo()
				{
					ResourceName = "513 - Pansear",
					NameKey = "Pokemons_Pansear",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 53,
						defense = 48,
						specialAttack = 53,
						specialDefense = 48,
						speed = 64
					}
				}
			},
			{
				514,
				new PokemonInfo()
				{
					ResourceName = "514 - Simisear",
					NameKey = "Pokemons_Simisear",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 98,
						defense = 63,
						specialAttack = 98,
						specialDefense = 63,
						speed = 101
					}
				}
			},
			{
				515,
				new PokemonInfo()
				{
					ResourceName = "515 - Panpour",
					NameKey = "Pokemons_Panpour",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 53,
						defense = 48,
						specialAttack = 53,
						specialDefense = 48,
						speed = 64
					}
				}
			},
			{
				516,
				new PokemonInfo()
				{
					ResourceName = "516 - Simipour",
					NameKey = "Pokemons_Simipour",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 98,
						defense = 63,
						specialAttack = 98,
						specialDefense = 63,
						speed = 101
					}
				}
			},
			{
				517,
				new PokemonInfo()
				{
					ResourceName = "517 - Munna",
					NameKey = "Pokemons_Munna",
					Statistics = new Stats()
					{
						hp = 76,
						attack = 25,
						defense = 45,
						specialAttack = 67,
						specialDefense = 55,
						speed = 24
					}
				}
			},
			{
				518,
				new PokemonInfo()
				{
					ResourceName = "518 - Musharna",
					NameKey = "Pokemons_Musharna",
					Statistics = new Stats()
					{
						hp = 116,
						attack = 55,
						defense = 85,
						specialAttack = 107,
						specialDefense = 95,
						speed = 29
					}
				}
			},
			{
				519,
				new PokemonInfo()
				{
					ResourceName = "519 - Pidove",
					NameKey = "Pokemons_Pidove",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 55,
						defense = 50,
						specialAttack = 36,
						specialDefense = 30,
						speed = 43
					}
				}
			},
			{
				520,
				new PokemonInfo()
				{
					ResourceName = "520 - Tranquill",
					NameKey = "Pokemons_Tranquill",
					Statistics = new Stats()
					{
						hp = 62,
						attack = 77,
						defense = 62,
						specialAttack = 50,
						specialDefense = 42,
						speed = 65
					}
				}
			},
			{
				521,
				new PokemonInfo()
				{
					ResourceName = "521 - Unfezant",
					NameKey = "Pokemons_Unfezant",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 105,
						defense = 80,
						specialAttack = 65,
						specialDefense = 55,
						speed = 93
					}
				}
			},
			{
				522,
				new PokemonInfo()
				{
					ResourceName = "522 - Blitzle",
					NameKey = "Pokemons_Blitzle",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 60,
						defense = 32,
						specialAttack = 50,
						specialDefense = 32,
						speed = 76
					}
				}
			},
			{
				523,
				new PokemonInfo()
				{
					ResourceName = "523 - Zebstrika",
					NameKey = "Pokemons_Zebstrika",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 100,
						defense = 63,
						specialAttack = 80,
						specialDefense = 63,
						speed = 116
					}
				}
			},
			{
				524,
				new PokemonInfo()
				{
					ResourceName = "524 - Roggenrola",
					NameKey = "Pokemons_Roggenrola",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 75,
						defense = 85,
						specialAttack = 25,
						specialDefense = 25,
						speed = 15
					}
				}
			},
			{
				525,
				new PokemonInfo()
				{
					ResourceName = "525 - Boldore",
					NameKey = "Pokemons_Boldore",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 105,
						defense = 105,
						specialAttack = 50,
						specialDefense = 40,
						speed = 20
					}
				}
			},
			{
				526,
				new PokemonInfo()
				{
					ResourceName = "526 - Gigalith",
					NameKey = "Pokemons_Gigalith",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 135,
						defense = 130,
						specialAttack = 60,
						specialDefense = 70,
						speed = 25
					}
				}
			},
			{
				527,
				new PokemonInfo()
				{
					ResourceName = "527 - Woobat",
					NameKey = "Pokemons_Woobat",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 45,
						defense = 43,
						specialAttack = 55,
						specialDefense = 43,
						speed = 72
					}
				}
			},
			{
				528,
				new PokemonInfo()
				{
					ResourceName = "528 - Swoobat",
					NameKey = "Pokemons_Swoobat",
					Statistics = new Stats()
					{
						hp = 67,
						attack = 57,
						defense = 55,
						specialAttack = 77,
						specialDefense = 55,
						speed = 114
					}
				}
			},
			{
				529,
				new PokemonInfo()
				{
					ResourceName = "529 - Drilbur",
					NameKey = "Pokemons_Drilbur",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 85,
						defense = 40,
						specialAttack = 30,
						specialDefense = 45,
						speed = 68
					}
				}
			},
			{
				530,
				new PokemonInfo()
				{
					ResourceName = "530 - Excadrill",
					NameKey = "Pokemons_Excadrill",
					Statistics = new Stats()
					{
						hp = 110,
						attack = 135,
						defense = 60,
						specialAttack = 50,
						specialDefense = 65,
						speed = 88
					}
				}
			},
			{
				531,
				new PokemonInfo()
				{
					ResourceName = "531 - Audino",
					NameKey = "Pokemons_Audino",
					Statistics = new Stats()
					{
						hp = 103,
						attack = 60,
						defense = 86,
						specialAttack = 60,
						specialDefense = 86,
						speed = 50
					}
				}
			},
			{
				532,
				new PokemonInfo()
				{
					ResourceName = "532 - Timburr",
					NameKey = "Pokemons_Timburr",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 80,
						defense = 55,
						specialAttack = 25,
						specialDefense = 35,
						speed = 35
					}
				}
			},
			{
				533,
				new PokemonInfo()
				{
					ResourceName = "533 - Gurdurr",
					NameKey = "Pokemons_Gurdurr",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 105,
						defense = 85,
						specialAttack = 40,
						specialDefense = 50,
						speed = 40
					}
				}
			},
			{
				534,
				new PokemonInfo()
				{
					ResourceName = "534 - Conkeldurr",
					NameKey = "Pokemons_Conkeldurr",
					Statistics = new Stats()
					{
						hp = 105,
						attack = 140,
						defense = 95,
						specialAttack = 55,
						specialDefense = 65,
						speed = 45
					}
				}
			},
			{
				535,
				new PokemonInfo()
				{
					ResourceName = "535 - Tympole",
					NameKey = "Pokemons_Tympole",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 50,
						defense = 40,
						specialAttack = 50,
						specialDefense = 40,
						speed = 64
					}
				}
			},
			{
				536,
				new PokemonInfo()
				{
					ResourceName = "536 - Palpitoad",
					NameKey = "Pokemons_Palpitoad",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 65,
						defense = 55,
						specialAttack = 65,
						specialDefense = 55,
						speed = 69
					}
				}
			},
			{
				537,
				new PokemonInfo()
				{
					ResourceName = "537 - Seismitoad",
					NameKey = "Pokemons_Seismitoad",
					Statistics = new Stats()
					{
						hp = 105,
						attack = 85,
						defense = 75,
						specialAttack = 85,
						specialDefense = 75,
						speed = 74
					}
				}
			},
			{
				538,
				new PokemonInfo()
				{
					ResourceName = "538 - Throh",
					NameKey = "Pokemons_Throh",
					Statistics = new Stats()
					{
						hp = 120,
						attack = 100,
						defense = 85,
						specialAttack = 30,
						specialDefense = 85,
						speed = 45
					}
				}
			},
			{
				539,
				new PokemonInfo()
				{
					ResourceName = "539 - Sawk",
					NameKey = "Pokemons_Sawk",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 125,
						defense = 75,
						specialAttack = 30,
						specialDefense = 75,
						speed = 85
					}
				}
			},
			{
				540,
				new PokemonInfo()
				{
					ResourceName = "540 - Sewaddle",
					NameKey = "Pokemons_Sewaddle",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 53,
						defense = 70,
						specialAttack = 40,
						specialDefense = 60,
						speed = 42
					}
				}
			},
			{
				541,
				new PokemonInfo()
				{
					ResourceName = "541 - Swadloon",
					NameKey = "Pokemons_Swadloon",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 63,
						defense = 90,
						specialAttack = 50,
						specialDefense = 80,
						speed = 42
					}
				}
			},
			{
				542,
				new PokemonInfo()
				{
					ResourceName = "542 - Leavanny",
					NameKey = "Pokemons_Leavanny",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 103,
						defense = 80,
						specialAttack = 70,
						specialDefense = 70,
						speed = 92
					}
				}
			},
			{
				543,
				new PokemonInfo()
				{
					ResourceName = "543 - Venipede",
					NameKey = "Pokemons_Venipede",
					Statistics = new Stats()
					{
						hp = 30,
						attack = 45,
						defense = 59,
						specialAttack = 30,
						specialDefense = 39,
						speed = 57
					}
				}
			},
			{
				544,
				new PokemonInfo()
				{
					ResourceName = "544 - Whirlipede",
					NameKey = "Pokemons_Whirlipede",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 55,
						defense = 99,
						specialAttack = 40,
						specialDefense = 79,
						speed = 47
					}
				}
			},
			{
				545,
				new PokemonInfo()
				{
					ResourceName = "545 - Scolipede",
					NameKey = "Pokemons_Scolipede",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 90,
						defense = 89,
						specialAttack = 55,
						specialDefense = 69,
						speed = 112
					}
				}
			},
			{
				546,
				new PokemonInfo()
				{
					ResourceName = "546 - Cottonee",
					NameKey = "Pokemons_Cottonee",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 27,
						defense = 60,
						specialAttack = 37,
						specialDefense = 50,
						speed = 66
					}
				}
			},
			{
				547,
				new PokemonInfo()
				{
					ResourceName = "547 - Whimsicott",
					NameKey = "Pokemons_Whimsicott",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 67,
						defense = 85,
						specialAttack = 77,
						specialDefense = 75,
						speed = 116
					}
				}
			},
			{
				548,
				new PokemonInfo()
				{
					ResourceName = "548 - Petilil",
					NameKey = "Pokemons_Petilil",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 35,
						defense = 50,
						specialAttack = 70,
						specialDefense = 50,
						speed = 30
					}
				}
			},
			{
				549,
				new PokemonInfo()
				{
					ResourceName = "549 - Lilligant",
					NameKey = "Pokemons_Lilligant",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 60,
						defense = 75,
						specialAttack = 110,
						specialDefense = 75,
						speed = 90
					}
				}
			},
			{
				550,
				new PokemonInfo()
				{
					ResourceName = "550 - Basculin",
					NameKey = "Pokemons_Basculin",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 92,
						defense = 65,
						specialAttack = 80,
						specialDefense = 55,
						speed = 98
					}
				}
			},
			{
				551,
				new PokemonInfo()
				{
					ResourceName = "551 - Sandile",
					NameKey = "Pokemons_Sandile",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 72,
						defense = 35,
						specialAttack = 35,
						specialDefense = 35,
						speed = 65
					}
				}
			},
			{
				552,
				new PokemonInfo()
				{
					ResourceName = "552 - Krokorok",
					NameKey = "Pokemons_Krokorok",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 82,
						defense = 45,
						specialAttack = 45,
						specialDefense = 45,
						speed = 74
					}
				}
			},
			{
				553,
				new PokemonInfo()
				{
					ResourceName = "553 - Krookodile",
					NameKey = "Pokemons_Krookodile",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 117,
						defense = 70,
						specialAttack = 65,
						specialDefense = 70,
						speed = 92
					}
				}
			},
			{
				554,
				new PokemonInfo()
				{
					ResourceName = "554 - Darumaka",
					NameKey = "Pokemons_Darumaka",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 90,
						defense = 45,
						specialAttack = 15,
						specialDefense = 45,
						speed = 50
					}
				}
			},
			{
				555,
				new PokemonInfo()
				{
					ResourceName = "555 - Darmanitan",
					NameKey = "Pokemons_Darmanitan",
					Statistics = new Stats()
					{
						hp = 105,
						attack = 140,
						defense = 55,
						specialAttack = 30,
						specialDefense = 55,
						speed = 95
					}
				}
			},
			{
				556,
				new PokemonInfo()
				{
					ResourceName = "556 - Maractus",
					NameKey = "Pokemons_Maractus",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 86,
						defense = 67,
						specialAttack = 106,
						specialDefense = 67,
						speed = 60
					}
				}
			},
			{
				557,
				new PokemonInfo()
				{
					ResourceName = "557 - Dwebble",
					NameKey = "Pokemons_Dwebble",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 65,
						defense = 85,
						specialAttack = 35,
						specialDefense = 35,
						speed = 55
					}
				}
			},
			{
				558,
				new PokemonInfo()
				{
					ResourceName = "558 - Crustle",
					NameKey = "Pokemons_Crustle",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 95,
						defense = 125,
						specialAttack = 65,
						specialDefense = 75,
						speed = 45
					}
				}
			},
			{
				559,
				new PokemonInfo()
				{
					ResourceName = "559 - Scraggy",
					NameKey = "Pokemons_Scraggy",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 75,
						defense = 70,
						specialAttack = 35,
						specialDefense = 70,
						speed = 48
					}
				}
			},
			{
				560,
				new PokemonInfo()
				{
					ResourceName = "560 - Scrafty",
					NameKey = "Pokemons_Scrafty",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 90,
						defense = 115,
						specialAttack = 45,
						specialDefense = 115,
						speed = 58
					}
				}
			},
			{
				561,
				new PokemonInfo()
				{
					ResourceName = "561 - Sigilyph",
					NameKey = "Pokemons_Sigilyph",
					Statistics = new Stats()
					{
						hp = 72,
						attack = 58,
						defense = 80,
						specialAttack = 103,
						specialDefense = 80,
						speed = 97
					}
				}
			},
			{
				562,
				new PokemonInfo()
				{
					ResourceName = "562 - Yamask",
					NameKey = "Pokemons_Yamask",
					Statistics = new Stats()
					{
						hp = 38,
						attack = 30,
						defense = 85,
						specialAttack = 55,
						specialDefense = 65,
						speed = 30
					}
				}
			},
			{
				563,
				new PokemonInfo()
				{
					ResourceName = "563 - Cofagrigus",
					NameKey = "Pokemons_Cofagrigus",
					Statistics = new Stats()
					{
						hp = 58,
						attack = 50,
						defense = 145,
						specialAttack = 95,
						specialDefense = 105,
						speed = 30
					}
				}
			},
			{
				564,
				new PokemonInfo()
				{
					ResourceName = "564 - Tirtouga",
					NameKey = "Pokemons_Tirtouga",
					Statistics = new Stats()
					{
						hp = 54,
						attack = 78,
						defense = 103,
						specialAttack = 53,
						specialDefense = 45,
						speed = 22
					}
				}
			},
			{
				565,
				new PokemonInfo()
				{
					ResourceName = "565 - Carracosta",
					NameKey = "Pokemons_Carracosta",
					Statistics = new Stats()
					{
						hp = 74,
						attack = 108,
						defense = 133,
						specialAttack = 83,
						specialDefense = 65,
						speed = 32
					}
				}
			},
			{
				566,
				new PokemonInfo()
				{
					ResourceName = "566 - Archen",
					NameKey = "Pokemons_Archen",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 112,
						defense = 45,
						specialAttack = 74,
						specialDefense = 45,
						speed = 70
					}
				}
			},
			{
				567,
				new PokemonInfo()
				{
					ResourceName = "567 - Archeops",
					NameKey = "Pokemons_Archeops",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 140,
						defense = 65,
						specialAttack = 112,
						specialDefense = 65,
						speed = 110
					}
				}
			},
			{
				568,
				new PokemonInfo()
				{
					ResourceName = "568 - Trubbish",
					NameKey = "Pokemons_Trubbish",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 50,
						defense = 62,
						specialAttack = 40,
						specialDefense = 62,
						speed = 65
					}
				}
			},
			{
				569,
				new PokemonInfo()
				{
					ResourceName = "569 - Garbodor",
					NameKey = "Pokemons_Garbodor",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 95,
						defense = 82,
						specialAttack = 60,
						specialDefense = 82,
						speed = 75
					}
				}
			},
			{
				570,
				new PokemonInfo()
				{
					ResourceName = "570 - Zorua",
					NameKey = "Pokemons_Zorua",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 65,
						defense = 40,
						specialAttack = 80,
						specialDefense = 40,
						speed = 65
					}
				}
			},
			{
				571,
				new PokemonInfo()
				{
					ResourceName = "571 - Zoroark",
					NameKey = "Pokemons_Zoroark",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 105,
						defense = 60,
						specialAttack = 120,
						specialDefense = 60,
						speed = 105
					}
				}
			},
			{
				572,
				new PokemonInfo()
				{
					ResourceName = "572 - Minccino",
					NameKey = "Pokemons_Minccino",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 50,
						defense = 40,
						specialAttack = 40,
						specialDefense = 40,
						speed = 75
					}
				}
			},
			{
				573,
				new PokemonInfo()
				{
					ResourceName = "573 - Cinccino",
					NameKey = "Pokemons_Cinccino",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 95,
						defense = 60,
						specialAttack = 65,
						specialDefense = 60,
						speed = 115
					}
				}
			},
			{
				574,
				new PokemonInfo()
				{
					ResourceName = "574 - Gothita",
					NameKey = "Pokemons_Gothita",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 30,
						defense = 50,
						specialAttack = 55,
						specialDefense = 65,
						speed = 45
					}
				}
			},
			{
				575,
				new PokemonInfo()
				{
					ResourceName = "575 - Gothorita",
					NameKey = "Pokemons_Gothorita",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 45,
						defense = 70,
						specialAttack = 75,
						specialDefense = 85,
						speed = 55
					}
				}
			},
			{
				576,
				new PokemonInfo()
				{
					ResourceName = "576 - Gothitelle",
					NameKey = "Pokemons_Gothitelle",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 55,
						defense = 95,
						specialAttack = 95,
						specialDefense = 110,
						speed = 65
					}
				}
			},
			{
				577,
				new PokemonInfo()
				{
					ResourceName = "577 - Solosis",
					NameKey = "Pokemons_Solosis",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 30,
						defense = 40,
						specialAttack = 105,
						specialDefense = 50,
						speed = 20
					}
				}
			},
			{
				578,
				new PokemonInfo()
				{
					ResourceName = "578 - Duosion",
					NameKey = "Pokemons_Duosion",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 40,
						defense = 50,
						specialAttack = 125,
						specialDefense = 60,
						speed = 30
					}
				}
			},
			{
				579,
				new PokemonInfo()
				{
					ResourceName = "579 - Reuniclus",
					NameKey = "Pokemons_Reuniclus",
					Statistics = new Stats()
					{
						hp = 110,
						attack = 65,
						defense = 75,
						specialAttack = 125,
						specialDefense = 85,
						speed = 30
					}
				}
			},
			{
				580,
				new PokemonInfo()
				{
					ResourceName = "580 - Ducklett",
					NameKey = "Pokemons_Ducklett",
					Statistics = new Stats()
					{
						hp = 62,
						attack = 44,
						defense = 50,
						specialAttack = 44,
						specialDefense = 50,
						speed = 55
					}
				}
			},
			{
				581,
				new PokemonInfo()
				{
					ResourceName = "581 - Swanna",
					NameKey = "Pokemons_Swanna",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 87,
						defense = 63,
						specialAttack = 87,
						specialDefense = 63,
						speed = 98
					}
				}
			},
			{
				582,
				new PokemonInfo()
				{
					ResourceName = "582 - Vanillite",
					NameKey = "Pokemons_Vanillite",
					Statistics = new Stats()
					{
						hp = 36,
						attack = 50,
						defense = 50,
						specialAttack = 65,
						specialDefense = 60,
						speed = 44
					}
				}
			},
			{
				583,
				new PokemonInfo()
				{
					ResourceName = "583 - Vanillish",
					NameKey = "Pokemons_Vanillish",
					Statistics = new Stats()
					{
						hp = 51,
						attack = 65,
						defense = 65,
						specialAttack = 80,
						specialDefense = 75,
						speed = 59
					}
				}
			},
			{
				584,
				new PokemonInfo()
				{
					ResourceName = "584 - Vanilluxe",
					NameKey = "Pokemons_Vanilluxe",
					Statistics = new Stats()
					{
						hp = 71,
						attack = 95,
						defense = 85,
						specialAttack = 110,
						specialDefense = 95,
						speed = 79
					}
				}
			},
			{
				585,
				new PokemonInfo()
				{
					ResourceName = "585 - Deerling",
					NameKey = "Pokemons_Deerling",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 60,
						defense = 50,
						specialAttack = 40,
						specialDefense = 50,
						speed = 75
					}
				}
			},
			{
				586,
				new PokemonInfo()
				{
					ResourceName = "586 - Sawsbuck",
					NameKey = "Pokemons_Sawsbuck",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 100,
						defense = 70,
						specialAttack = 60,
						specialDefense = 70,
						speed = 95
					}
				}
			},
			{
				587,
				new PokemonInfo()
				{
					ResourceName = "587 - Emolga",
					NameKey = "Pokemons_Emolga",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 75,
						defense = 60,
						specialAttack = 75,
						specialDefense = 60,
						speed = 103
					}
				}
			},
			{
				588,
				new PokemonInfo()
				{
					ResourceName = "588 - Karrablast",
					NameKey = "Pokemons_Karrablast",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 75,
						defense = 45,
						specialAttack = 40,
						specialDefense = 45,
						speed = 60
					}
				}
			},
			{
				589,
				new PokemonInfo()
				{
					ResourceName = "589 - Escavalier",
					NameKey = "Pokemons_Escavalier",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 135,
						defense = 105,
						specialAttack = 60,
						specialDefense = 105,
						speed = 20
					}
				}
			},
			{
				590,
				new PokemonInfo()
				{
					ResourceName = "590 - Foongus",
					NameKey = "Pokemons_Foongus",
					Statistics = new Stats()
					{
						hp = 69,
						attack = 55,
						defense = 45,
						specialAttack = 55,
						specialDefense = 55,
						speed = 15
					}
				}
			},
			{
				591,
				new PokemonInfo()
				{
					ResourceName = "591 - Amoonguss",
					NameKey = "Pokemons_Amoonguss",
					Statistics = new Stats()
					{
						hp = 114,
						attack = 85,
						defense = 70,
						specialAttack = 85,
						specialDefense = 80,
						speed = 30
					}
				}
			},
			{
				592,
				new PokemonInfo()
				{
					ResourceName = "592 - Frillish",
					NameKey = "Pokemons_Frillish",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 40,
						defense = 50,
						specialAttack = 65,
						specialDefense = 85,
						speed = 40
					}
				}
			},
			{
				593,
				new PokemonInfo()
				{
					ResourceName = "593 - Jellicent",
					NameKey = "Pokemons_Jellicent",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 60,
						defense = 70,
						specialAttack = 85,
						specialDefense = 105,
						speed = 60
					}
				}
			},
			{
				594,
				new PokemonInfo()
				{
					ResourceName = "594 - Alomomola",
					NameKey = "Pokemons_Alomomola",
					Statistics = new Stats()
					{
						hp = 165,
						attack = 75,
						defense = 80,
						specialAttack = 40,
						specialDefense = 45,
						speed = 65
					}
				}
			},
			{
				595,
				new PokemonInfo()
				{
					ResourceName = "595 - Joltik",
					NameKey = "Pokemons_Joltik",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 47,
						defense = 50,
						specialAttack = 57,
						specialDefense = 50,
						speed = 65
					}
				}
			},
			{
				596,
				new PokemonInfo()
				{
					ResourceName = "596 - Galvantula",
					NameKey = "Pokemons_Galvantula",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 77,
						defense = 60,
						specialAttack = 97,
						specialDefense = 60,
						speed = 108
					}
				}
			},
			{
				597,
				new PokemonInfo()
				{
					ResourceName = "597 - Ferroseed",
					NameKey = "Pokemons_Ferroseed",
					Statistics = new Stats()
					{
						hp = 44,
						attack = 50,
						defense = 91,
						specialAttack = 24,
						specialDefense = 86,
						speed = 10
					}
				}
			},
			{
				598,
				new PokemonInfo()
				{
					ResourceName = "598 - Ferrothorn",
					NameKey = "Pokemons_Ferrothorn",
					Statistics = new Stats()
					{
						hp = 74,
						attack = 94,
						defense = 131,
						specialAttack = 54,
						specialDefense = 116,
						speed = 20
					}
				}
			},
			{
				599,
				new PokemonInfo()
				{
					ResourceName = "599 - Klink",
					NameKey = "Pokemons_Klink",
					Statistics = new Stats()
					{
						hp = 40,
						attack = 55,
						defense = 70,
						specialAttack = 45,
						specialDefense = 60,
						speed = 30
					}
				}
			},
			{
				600,
				new PokemonInfo()
				{
					ResourceName = "600 - Klang",
					NameKey = "Pokemons_Klang",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 80,
						defense = 95,
						specialAttack = 70,
						specialDefense = 85,
						speed = 50
					}
				}
			},
			{
				601,
				new PokemonInfo()
				{
					ResourceName = "601 - Klinklang",
					NameKey = "Pokemons_Klinklang",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 100,
						defense = 115,
						specialAttack = 70,
						specialDefense = 85,
						speed = 90
					}
				}
			},
			{
				602,
				new PokemonInfo()
				{
					ResourceName = "602 - Tynamo",
					NameKey = "Pokemons_Tynamo",
					Statistics = new Stats()
					{
						hp = 35,
						attack = 55,
						defense = 40,
						specialAttack = 45,
						specialDefense = 40,
						speed = 60
					}
				}
			},
			{
				603,
				new PokemonInfo()
				{
					ResourceName = "603 - Eelektrik",
					NameKey = "Pokemons_Eelektrik",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 85,
						defense = 70,
						specialAttack = 75,
						specialDefense = 70,
						speed = 40
					}
				}
			},
			{
				604,
				new PokemonInfo()
				{
					ResourceName = "604 - Eelektross",
					NameKey = "Pokemons_Eelektross",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 115,
						defense = 80,
						specialAttack = 105,
						specialDefense = 80,
						speed = 50
					}
				}
			},
			{
				605,
				new PokemonInfo()
				{
					ResourceName = "605 - Elgyem",
					NameKey = "Pokemons_Elgyem",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 55,
						defense = 55,
						specialAttack = 85,
						specialDefense = 55,
						speed = 30
					}
				}
			},
			{
				606,
				new PokemonInfo()
				{
					ResourceName = "606 - Beheeyem",
					NameKey = "Pokemons_Beheeyem",
					Statistics = new Stats()
					{
						hp = 75,
						attack = 75,
						defense = 75,
						specialAttack = 125,
						specialDefense = 95,
						speed = 40
					}
				}
			},
			{
				607,
				new PokemonInfo()
				{
					ResourceName = "607 - Litwick",
					NameKey = "Pokemons_Litwick",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 30,
						defense = 55,
						specialAttack = 65,
						specialDefense = 55,
						speed = 20
					}
				}
			},
			{
				608,
				new PokemonInfo()
				{
					ResourceName = "608 - Lampent",
					NameKey = "Pokemons_Lampent",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 40,
						defense = 60,
						specialAttack = 95,
						specialDefense = 60,
						speed = 55
					}
				}
			},
			{
				609,
				new PokemonInfo()
				{
					ResourceName = "609 - Chandelure",
					NameKey = "Pokemons_Chandelure",
					Statistics = new Stats()
					{
						hp = 60,
						attack = 55,
						defense = 90,
						specialAttack = 145,
						specialDefense = 90,
						speed = 80
					}
				}
			},
			{
				610,
				new PokemonInfo()
				{
					ResourceName = "610 - Axew",
					NameKey = "Pokemons_Axew",
					Statistics = new Stats()
					{
						hp = 46,
						attack = 87,
						defense = 60,
						specialAttack = 30,
						specialDefense = 40,
						speed = 57
					}
				}
			},
			{
				611,
				new PokemonInfo()
				{
					ResourceName = "611 - Fraxure",
					NameKey = "Pokemons_Fraxure",
					Statistics = new Stats()
					{
						hp = 66,
						attack = 117,
						defense = 70,
						specialAttack = 40,
						specialDefense = 50,
						speed = 67
					}
				}
			},
			{
				612,
				new PokemonInfo()
				{
					ResourceName = "612 - Haxorus",
					NameKey = "Pokemons_Haxorus",
					Statistics = new Stats()
					{
						hp = 76,
						attack = 147,
						defense = 90,
						specialAttack = 60,
						specialDefense = 70,
						speed = 97
					}
				}
			},
			{
				613,
				new PokemonInfo()
				{
					ResourceName = "613 - Cubchoo",
					NameKey = "Pokemons_Cubchoo",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 70,
						defense = 40,
						specialAttack = 60,
						specialDefense = 40,
						speed = 40
					}
				}
			},
			{
				614,
				new PokemonInfo()
				{
					ResourceName = "614 - Beartic",
					NameKey = "Pokemons_Beartic",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 110,
						defense = 80,
						specialAttack = 70,
						specialDefense = 80,
						speed = 50
					}
				}
			},
			{
				615,
				new PokemonInfo()
				{
					ResourceName = "615 - Cryogonal",
					NameKey = "Pokemons_Cryogonal",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 50,
						defense = 30,
						specialAttack = 95,
						specialDefense = 135,
						speed = 105
					}
				}
			},
			{
				616,
				new PokemonInfo()
				{
					ResourceName = "616 - Shelmet",
					NameKey = "Pokemons_Shelmet",
					Statistics = new Stats()
					{
						hp = 50,
						attack = 40,
						defense = 85,
						specialAttack = 40,
						specialDefense = 65,
						speed = 25
					}
				}
			},
			{
				617,
				new PokemonInfo()
				{
					ResourceName = "617 - Accelgor",
					NameKey = "Pokemons_Accelgor",
					Statistics = new Stats()
					{
						hp = 80,
						attack = 70,
						defense = 40,
						specialAttack = 100,
						specialDefense = 60,
						speed = 145
					}
				}
			},
			{
				618,
				new PokemonInfo()
				{
					ResourceName = "618 - Stunfisk",
					NameKey = "Pokemons_Stunfisk",
					Statistics = new Stats()
					{
						hp = 109,
						attack = 66,
						defense = 84,
						specialAttack = 81,
						specialDefense = 99,
						speed = 32
					}
				}
			},
			{
				619,
				new PokemonInfo()
				{
					ResourceName = "619 - Mienfoo",
					NameKey = "Pokemons_Mienfoo",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 85,
						defense = 50,
						specialAttack = 55,
						specialDefense = 50,
						speed = 65
					}
				}
			},
			{
				620,
				new PokemonInfo()
				{
					ResourceName = "620 - Mienshao",
					NameKey = "Pokemons_Mienshao",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 125,
						defense = 60,
						specialAttack = 95,
						specialDefense = 60,
						speed = 105
					}
				}
			},
			{
				621,
				new PokemonInfo()
				{
					ResourceName = "621 - Druddigon",
					NameKey = "Pokemons_Druddigon",
					Statistics = new Stats()
					{
						hp = 77,
						attack = 120,
						defense = 90,
						specialAttack = 60,
						specialDefense = 90,
						speed = 48
					}
				}
			},
			{
				622,
				new PokemonInfo()
				{
					ResourceName = "622 - Golett",
					NameKey = "Pokemons_Golett",
					Statistics = new Stats()
					{
						hp = 59,
						attack = 74,
						defense = 50,
						specialAttack = 35,
						specialDefense = 50,
						speed = 35
					}
				}
			},
			{
				623,
				new PokemonInfo()
				{
					ResourceName = "623 - Golurk",
					NameKey = "Pokemons_Golurk",
					Statistics = new Stats()
					{
						hp = 89,
						attack = 124,
						defense = 80,
						specialAttack = 55,
						specialDefense = 80,
						speed = 55
					}
				}
			},
			{
				624,
				new PokemonInfo()
				{
					ResourceName = "624 - Pawniard",
					NameKey = "Pokemons_Pawniard",
					Statistics = new Stats()
					{
						hp = 45,
						attack = 85,
						defense = 70,
						specialAttack = 40,
						specialDefense = 40,
						speed = 60
					}
				}
			},
			{
				625,
				new PokemonInfo()
				{
					ResourceName = "625 - Bisharp",
					NameKey = "Pokemons_Bisharp",
					Statistics = new Stats()
					{
						hp = 65,
						attack = 125,
						defense = 100,
						specialAttack = 60,
						specialDefense = 70,
						speed = 70
					}
				}
			},
			{
				626,
				new PokemonInfo()
				{
					ResourceName = "626 - Bouffalant",
					NameKey = "Pokemons_Bouffalant",
					Statistics = new Stats()
					{
						hp = 95,
						attack = 110,
						defense = 95,
						specialAttack = 40,
						specialDefense = 95,
						speed = 55
					}
				}
			},
			{
				627,
				new PokemonInfo()
				{
					ResourceName = "627 - Rufflet",
					NameKey = "Pokemons_Rufflet",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 83,
						defense = 50,
						specialAttack = 37,
						specialDefense = 50,
						speed = 60
					}
				}
			},
			{
				628,
				new PokemonInfo()
				{
					ResourceName = "628 - Braviary",
					NameKey = "Pokemons_Braviary",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 123,
						defense = 75,
						specialAttack = 57,
						specialDefense = 75,
						speed = 80
					}
				}
			},
			{
				629,
				new PokemonInfo()
				{
					ResourceName = "629 - Vullaby",
					NameKey = "Pokemons_Vullaby",
					Statistics = new Stats()
					{
						hp = 70,
						attack = 55,
						defense = 75,
						specialAttack = 45,
						specialDefense = 65,
						speed = 60
					}
				}
			},
			{
				630,
				new PokemonInfo()
				{
					ResourceName = "630 - Mandibuzz",
					NameKey = "Pokemons_Mandibuzz",
					Statistics = new Stats()
					{
						hp = 110,
						attack = 65,
						defense = 105,
						specialAttack = 55,
						specialDefense = 95,
						speed = 80
					}
				}
			},
			{
				631,
				new PokemonInfo()
				{
					ResourceName = "631 - Heatmor",
					NameKey = "Pokemons_Heatmor",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 97,
						defense = 66,
						specialAttack = 105,
						specialDefense = 66,
						speed = 65
					}
				}
			},
			{
				632,
				new PokemonInfo()
				{
					ResourceName = "632 - Durant",
					NameKey = "Pokemons_Durant",
					Statistics = new Stats()
					{
						hp = 58,
						attack = 109,
						defense = 112,
						specialAttack = 48,
						specialDefense = 48,
						speed = 109
					}
				}
			},
			{
				633,
				new PokemonInfo()
				{
					ResourceName = "633 - Deino",
					NameKey = "Pokemons_Deino",
					Statistics = new Stats()
					{
						hp = 52,
						attack = 65,
						defense = 50,
						specialAttack = 45,
						specialDefense = 50,
						speed = 38
					}
				}
			},
			{
				634,
				new PokemonInfo()
				{
					ResourceName = "634 - Zweilous",
					NameKey = "Pokemons_Zweilous",
					Statistics = new Stats()
					{
						hp = 72,
						attack = 85,
						defense = 70,
						specialAttack = 65,
						specialDefense = 70,
						speed = 58
					}
				}
			},
			{
				635,
				new PokemonInfo()
				{
					ResourceName = "635 - Hydreigon",
					NameKey = "Pokemons_Hydreigon",
					Statistics = new Stats()
					{
						hp = 92,
						attack = 105,
						defense = 90,
						specialAttack = 125,
						specialDefense = 90,
						speed = 98
					}
				}
			},
			{
				636,
				new PokemonInfo()
				{
					ResourceName = "636 - Larvesta",
					NameKey = "Pokemons_Larvesta",
					Statistics = new Stats()
					{
						hp = 55,
						attack = 85,
						defense = 55,
						specialAttack = 50,
						specialDefense = 55,
						speed = 60
					}
				}
			},
			{
				637,
				new PokemonInfo()
				{
					ResourceName = "637 - Volcarona",
					NameKey = "Pokemons_Volcarona",
					Statistics = new Stats()
					{
						hp = 85,
						attack = 60,
						defense = 65,
						specialAttack = 135,
						specialDefense = 105,
						speed = 100
					}
				}
			},
			{
				638,
				new PokemonInfo()
				{
					ResourceName = "638 - Cobalion",
					NameKey = "Pokemons_Cobalion",
					Statistics = new Stats()
					{
						hp = 91,
						attack = 90,
						defense = 129,
						specialAttack = 90,
						specialDefense = 72,
						speed = 108
					}
				}
			},
			{
				639,
				new PokemonInfo()
				{
					ResourceName = "639 - Terrakion",
					NameKey = "Pokemons_Terrakion",
					Statistics = new Stats()
					{
						hp = 91,
						attack = 129,
						defense = 90,
						specialAttack = 72,
						specialDefense = 90,
						speed = 108
					}
				}
			},
			{
				640,
				new PokemonInfo()
				{
					ResourceName = "640 - Virizion",
					NameKey = "Pokemons_Virizion",
					Statistics = new Stats()
					{
						hp = 91,
						attack = 90,
						defense = 72,
						specialAttack = 90,
						specialDefense = 129,
						speed = 108
					}
				}
			},
			{
				641,
				new PokemonInfo()
				{
					ResourceName = "641 - Tornadus",
					NameKey = "Pokemons_Tornadus",
					Statistics = new Stats()
					{
						hp = 79,
						attack = 115,
						defense = 70,
						specialAttack = 125,
						specialDefense = 80,
						speed = 111
					}
				}
			},
			{
				642,
				new PokemonInfo()
				{
					ResourceName = "642 - Thundurus",
					NameKey = "Pokemons_Thundurus",
					Statistics = new Stats()
					{
						hp = 79,
						attack = 115,
						defense = 70,
						specialAttack = 125,
						specialDefense = 80,
						speed = 111
					}
				}
			},
			{
				643,
				new PokemonInfo()
				{
					ResourceName = "643 - Reshiram",
					NameKey = "Pokemons_Reshiram",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 120,
						defense = 100,
						specialAttack = 150,
						specialDefense = 120,
						speed = 90
					}
				}
			},
			{
				644,
				new PokemonInfo()
				{
					ResourceName = "644 - Zekrom",
					NameKey = "Pokemons_Zekrom",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 150,
						defense = 120,
						specialAttack = 120,
						specialDefense = 100,
						speed = 90
					}
				}
			},
			{
				645,
				new PokemonInfo()
				{
					ResourceName = "645 - Landorus",
					NameKey = "Pokemons_Landorus",
					Statistics = new Stats()
					{
						hp = 89,
						attack = 125,
						defense = 90,
						specialAttack = 115,
						specialDefense = 80,
						speed = 101
					}
				}
			},
			{
				646,
				new PokemonInfo()
				{
					ResourceName = "646 - Kyurem",
					NameKey = "Pokemons_Kyurem",
					Statistics = new Stats()
					{
						hp = 125,
						attack = 130,
						defense = 90,
						specialAttack = 130,
						specialDefense = 90,
						speed = 95
					}
				}
			},
			{
				647,
				new PokemonInfo()
				{
					ResourceName = "647 - Keldeo",
					NameKey = "Pokemons_Keldeo",
					Statistics = new Stats()
					{
						hp = 91,
						attack = 72,
						defense = 90,
						specialAttack = 129,
						specialDefense = 90,
						speed = 108
					}
				}
			},
			{
				648,
				new PokemonInfo()
				{
					ResourceName = "648 - Meloetta",
					NameKey = "Pokemons_Meloetta",
					Statistics = new Stats()
					{
						hp = 100,
						attack = 77,
						defense = 77,
						specialAttack = 128,
						specialDefense = 128,
						speed = 90
					}
				}
			},
			{
				649,
				new PokemonInfo()
				{
					ResourceName = "649 - Genesect",
					NameKey = "Pokemons_Genesect",
					Statistics = new Stats()
					{
						hp = 71,
						attack = 120,
						defense = 95,
						specialAttack = 120,
						specialDefense = 95,
						speed = 99
					}
				}
			}

        };
	}
}