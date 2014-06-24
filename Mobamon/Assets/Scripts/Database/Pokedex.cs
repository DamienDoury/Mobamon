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
						baseStats = new int[]{45, 49, 49, 65, 65, 45}
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
						baseStats = new int[]{60, 62, 63, 80, 80, 60}
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
						baseStats = new int[]{80, 82, 83, 100, 100, 80}
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
						baseStats = new int[]{39, 52, 43, 60, 50, 65}
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
						baseStats = new int[]{58, 64, 58, 80, 65, 80}
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
						baseStats = new int[]{78, 84, 78, 109, 85, 100}
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
						baseStats = new int[]{44, 48, 65, 50, 64, 43}
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
						baseStats = new int[]{59, 63, 80, 65, 80, 58}
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
						baseStats = new int[]{79, 83, 100, 85, 105, 78}
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
						baseStats = new int[]{45, 30, 35, 20, 20, 45}
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
						baseStats = new int[]{50, 20, 55, 25, 25, 30}
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
						baseStats = new int[]{60, 45, 50, 80, 80, 70}
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
						baseStats = new int[]{40, 35, 30, 20, 20, 50}
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
						baseStats = new int[]{45, 25, 50, 25, 25, 35}
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
						baseStats = new int[]{65, 80, 40, 45, 80, 75}
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
						baseStats = new int[]{40, 45, 40, 35, 35, 56}
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
						baseStats = new int[]{63, 60, 55, 50, 50, 71}
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
						baseStats = new int[]{83, 80, 75, 70, 70, 91}
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
						baseStats = new int[]{30, 56, 35, 25, 35, 72}
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
						baseStats = new int[]{55, 81, 60, 50, 70, 97}
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
						baseStats = new int[]{40, 60, 30, 31, 31, 70}
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
						baseStats = new int[]{65, 90, 65, 61, 61, 100}
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
						baseStats = new int[]{35, 60, 44, 40, 54, 55}
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
						baseStats = new int[]{60, 85, 69, 65, 79, 80}
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
						baseStats = new int[]{35, 55, 30, 50, 40, 90}
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
						baseStats = new int[]{60, 90, 55, 90, 80, 100}
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
						baseStats = new int[]{50, 75, 85, 20, 30, 40}
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
						baseStats = new int[]{75, 100, 110, 45, 55, 65}
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
						baseStats = new int[]{55, 47, 52, 40, 40, 41}
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
						baseStats = new int[]{70, 62, 67, 55, 55, 56}
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
						baseStats = new int[]{90, 82, 87, 75, 85, 76}
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
						baseStats = new int[]{46, 57, 40, 40, 40, 50}
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
						baseStats = new int[]{61, 72, 57, 55, 55, 65}
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
						baseStats = new int[]{81, 92, 77, 85, 75, 85}
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
						baseStats = new int[]{70, 45, 48, 60, 65, 35}
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
						baseStats = new int[]{95, 70, 73, 85, 90, 60}
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
						baseStats = new int[]{38, 41, 40, 50, 65, 65}
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
						baseStats = new int[]{73, 76, 75, 81, 100, 100}
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
						baseStats = new int[]{115, 45, 20, 45, 25, 20}
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
						baseStats = new int[]{140, 70, 45, 75, 50, 45}
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
						baseStats = new int[]{40, 45, 35, 30, 40, 55}
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
						baseStats = new int[]{75, 80, 70, 65, 75, 90}
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
						baseStats = new int[]{45, 50, 55, 75, 65, 30}
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
						baseStats = new int[]{60, 65, 70, 85, 75, 40}
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
						baseStats = new int[]{75, 80, 85, 100, 90, 50}
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
						baseStats = new int[]{35, 70, 55, 45, 55, 25}
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
						baseStats = new int[]{60, 95, 80, 60, 80, 30}
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
						baseStats = new int[]{60, 55, 50, 40, 55, 45}
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
						baseStats = new int[]{70, 65, 60, 90, 75, 90}
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
						baseStats = new int[]{10, 55, 25, 35, 45, 95}
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
						baseStats = new int[]{35, 80, 50, 50, 70, 120}
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
						baseStats = new int[]{40, 45, 35, 40, 40, 90}
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
						baseStats = new int[]{65, 70, 60, 65, 65, 115}
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
						baseStats = new int[]{50, 52, 48, 65, 50, 55}
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
						baseStats = new int[]{80, 82, 78, 95, 80, 85}
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
						baseStats = new int[]{40, 80, 35, 35, 45, 70}
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
						baseStats = new int[]{65, 105, 60, 60, 70, 95}
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
						baseStats = new int[]{55, 70, 45, 70, 50, 60}
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
						baseStats = new int[]{90, 110, 80, 100, 80, 95}
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
						baseStats = new int[]{40, 50, 40, 40, 40, 90}
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
						baseStats = new int[]{65, 65, 65, 50, 50, 90}
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
						baseStats = new int[]{90, 85, 95, 70, 90, 70}
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
						baseStats = new int[]{25, 20, 15, 105, 55, 90}
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
						baseStats = new int[]{40, 35, 30, 120, 70, 105}
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
						baseStats = new int[]{55, 50, 45, 135, 85, 120}
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
						baseStats = new int[]{70, 80, 50, 35, 35, 35}
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
						baseStats = new int[]{80, 100, 70, 50, 60, 45}
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
						baseStats = new int[]{90, 130, 80, 65, 85, 55}
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
						baseStats = new int[]{50, 75, 35, 70, 30, 40}
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
						baseStats = new int[]{65, 90, 50, 85, 45, 55}
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
						baseStats = new int[]{80, 105, 65, 100, 60, 70}
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
						baseStats = new int[]{40, 40, 35, 50, 100, 70}
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
						baseStats = new int[]{80, 70, 65, 80, 120, 100}
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
						baseStats = new int[]{40, 80, 100, 30, 30, 20}
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
						baseStats = new int[]{55, 95, 115, 45, 45, 35}
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
						baseStats = new int[]{80, 110, 130, 55, 65, 45}
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
						baseStats = new int[]{50, 85, 55, 65, 65, 90}
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
						baseStats = new int[]{65, 100, 70, 80, 80, 105}
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
						baseStats = new int[]{90, 65, 65, 40, 40, 15}
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
						baseStats = new int[]{95, 75, 110, 100, 80, 30}
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
						baseStats = new int[]{25, 35, 70, 95, 55, 45}
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
						baseStats = new int[]{50, 60, 95, 120, 70, 70}
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
						baseStats = new int[]{52, 65, 55, 58, 62, 60}
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
						baseStats = new int[]{35, 85, 45, 35, 35, 75}
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
						baseStats = new int[]{60, 110, 70, 60, 60, 100}
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
						baseStats = new int[]{65, 45, 55, 45, 70, 45}
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
						baseStats = new int[]{90, 70, 80, 70, 95, 70}
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
						baseStats = new int[]{80, 80, 50, 40, 50, 25}
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
						baseStats = new int[]{105, 105, 75, 65, 100, 50}
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
						baseStats = new int[]{30, 65, 100, 45, 25, 40}
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
						baseStats = new int[]{50, 95, 180, 85, 45, 70}
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
						baseStats = new int[]{30, 35, 30, 100, 35, 80}
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
						baseStats = new int[]{45, 50, 45, 115, 55, 95}
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
						baseStats = new int[]{60, 65, 60, 130, 75, 110}
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
						baseStats = new int[]{35, 45, 160, 30, 45, 70}
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
						baseStats = new int[]{60, 48, 45, 43, 90, 42}
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
						baseStats = new int[]{85, 73, 70, 73, 115, 67}
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
						baseStats = new int[]{30, 105, 90, 25, 25, 50}
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
						baseStats = new int[]{55, 130, 115, 50, 50, 75}
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
						baseStats = new int[]{40, 30, 50, 55, 55, 100}
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
						baseStats = new int[]{60, 50, 70, 80, 80, 140}
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
						baseStats = new int[]{60, 40, 80, 60, 45, 40}
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
						baseStats = new int[]{95, 95, 85, 125, 65, 55}
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
						baseStats = new int[]{50, 50, 95, 40, 50, 35}
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
						baseStats = new int[]{60, 80, 110, 50, 80, 45}
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
						baseStats = new int[]{50, 120, 53, 35, 110, 87}
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
						baseStats = new int[]{50, 105, 79, 35, 110, 76}
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
						baseStats = new int[]{90, 55, 75, 60, 75, 30}
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
						baseStats = new int[]{40, 65, 95, 60, 45, 35}
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
						baseStats = new int[]{65, 90, 120, 85, 70, 60}
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
						baseStats = new int[]{80, 85, 95, 30, 30, 25}
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
						baseStats = new int[]{105, 130, 120, 45, 45, 40}
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
						baseStats = new int[]{250, 5, 5, 35, 105, 50}
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
						baseStats = new int[]{65, 55, 115, 100, 40, 60}
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
						baseStats = new int[]{105, 95, 80, 40, 80, 90}
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
						baseStats = new int[]{30, 40, 70, 70, 25, 60}
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
						baseStats = new int[]{55, 65, 95, 95, 45, 85}
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
						baseStats = new int[]{45, 67, 60, 35, 50, 63}
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
						baseStats = new int[]{80, 92, 65, 65, 80, 68}
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
						baseStats = new int[]{30, 45, 55, 70, 55, 85}
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
						baseStats = new int[]{60, 75, 85, 100, 85, 115}
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
						baseStats = new int[]{40, 45, 65, 100, 120, 90}
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
						baseStats = new int[]{70, 110, 80, 55, 80, 105}
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
						baseStats = new int[]{65, 50, 35, 115, 95, 95}
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
						baseStats = new int[]{65, 83, 57, 95, 85, 105}
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
						baseStats = new int[]{65, 95, 57, 100, 85, 93}
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
						baseStats = new int[]{65, 125, 100, 55, 70, 85}
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
						baseStats = new int[]{75, 100, 95, 40, 70, 110}
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
						baseStats = new int[]{20, 10, 55, 15, 20, 80}
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
						baseStats = new int[]{95, 125, 79, 60, 100, 81}
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
						baseStats = new int[]{130, 85, 80, 85, 95, 60}
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
						baseStats = new int[]{48, 48, 48, 48, 48, 48}
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
						baseStats = new int[]{55, 55, 50, 45, 65, 55}
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
						baseStats = new int[]{130, 65, 60, 110, 95, 65}
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
						baseStats = new int[]{65, 65, 60, 110, 95, 130}
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
						baseStats = new int[]{65, 130, 60, 95, 110, 65}
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
						baseStats = new int[]{65, 60, 70, 85, 75, 40}
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
						baseStats = new int[]{35, 40, 100, 90, 55, 35}
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
						baseStats = new int[]{70, 60, 125, 115, 70, 55}
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
						baseStats = new int[]{30, 80, 90, 55, 45, 55}
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
						baseStats = new int[]{60, 115, 105, 65, 70, 80}
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
						baseStats = new int[]{80, 105, 65, 60, 75, 130}
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
						baseStats = new int[]{160, 110, 65, 65, 110, 30}
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
						baseStats = new int[]{90, 85, 100, 95, 125, 85}
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
						baseStats = new int[]{90, 90, 85, 125, 90, 100}
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
						baseStats = new int[]{90, 100, 90, 125, 85, 90}
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
						baseStats = new int[]{41, 64, 45, 50, 50, 50}
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
						baseStats = new int[]{61, 84, 65, 70, 70, 70}
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
						baseStats = new int[]{91, 134, 95, 100, 100, 80}
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
						baseStats = new int[]{106, 110, 90, 154, 90, 130}
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
						baseStats = new int[]{100, 100, 100, 100, 100, 100}
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
						baseStats = new int[]{45, 49, 65, 49, 65, 45}
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
						baseStats = new int[]{60, 62, 80, 63, 80, 60}
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
						baseStats = new int[]{80, 82, 100, 83, 100, 80}
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
						baseStats = new int[]{39, 52, 43, 60, 50, 65}
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
						baseStats = new int[]{58, 64, 58, 80, 65, 80}
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
						baseStats = new int[]{78, 84, 78, 109, 85, 100}
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
						baseStats = new int[]{50, 65, 64, 44, 48, 43}
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
						baseStats = new int[]{65, 80, 80, 59, 63, 58}
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
						baseStats = new int[]{85, 105, 100, 79, 83, 78}
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
						baseStats = new int[]{35, 46, 34, 35, 45, 20}
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
						baseStats = new int[]{85, 76, 64, 45, 55, 90}
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
						baseStats = new int[]{60, 30, 30, 36, 56, 50}
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
						baseStats = new int[]{100, 50, 50, 76, 96, 70}
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
						baseStats = new int[]{40, 20, 30, 40, 80, 55}
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
						baseStats = new int[]{55, 35, 50, 55, 110, 85}
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
						baseStats = new int[]{40, 60, 40, 40, 40, 30}
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
						baseStats = new int[]{70, 90, 70, 60, 60, 40}
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
						baseStats = new int[]{85, 90, 80, 70, 80, 130}
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
						baseStats = new int[]{75, 38, 38, 56, 56, 67}
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
						baseStats = new int[]{125, 58, 58, 76, 76, 67}
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
						baseStats = new int[]{20, 40, 15, 35, 35, 60}
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
						baseStats = new int[]{50, 25, 28, 45, 55, 15}
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
						baseStats = new int[]{90, 30, 15, 40, 20, 15}
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
						baseStats = new int[]{35, 20, 65, 40, 65, 20}
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
						baseStats = new int[]{55, 40, 85, 80, 105, 40}
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
						baseStats = new int[]{40, 50, 45, 70, 45, 70}
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
						baseStats = new int[]{65, 75, 70, 95, 70, 95}
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
						baseStats = new int[]{55, 40, 40, 65, 45, 35}
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
						baseStats = new int[]{70, 55, 55, 80, 60, 45}
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
						baseStats = new int[]{90, 75, 75, 115, 90, 55}
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
						baseStats = new int[]{75, 80, 85, 90, 100, 50}
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
						baseStats = new int[]{70, 20, 50, 20, 50, 40}
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
						baseStats = new int[]{100, 50, 80, 50, 80, 50}
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
						baseStats = new int[]{70, 100, 115, 30, 65, 30}
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
						baseStats = new int[]{90, 75, 75, 90, 100, 70}
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
						baseStats = new int[]{35, 35, 40, 35, 55, 50}
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
						baseStats = new int[]{55, 45, 50, 45, 65, 80}
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
						baseStats = new int[]{75, 55, 70, 55, 85, 110}
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
						baseStats = new int[]{55, 70, 55, 40, 55, 85}
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
						baseStats = new int[]{30, 30, 30, 30, 30, 30}
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
						baseStats = new int[]{75, 75, 55, 105, 85, 30}
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
						baseStats = new int[]{65, 65, 45, 75, 45, 95}
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
						baseStats = new int[]{55, 45, 45, 25, 25, 15}
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
						baseStats = new int[]{95, 85, 85, 65, 65, 35}
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
						baseStats = new int[]{65, 65, 60, 130, 95, 110}
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
						baseStats = new int[]{95, 65, 110, 60, 130, 65}
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
						baseStats = new int[]{60, 85, 42, 85, 42, 91}
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
						baseStats = new int[]{95, 75, 80, 100, 110, 30}
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
						baseStats = new int[]{60, 60, 60, 85, 85, 85}
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
						baseStats = new int[]{48, 72, 48, 72, 48, 48}
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
						baseStats = new int[]{190, 33, 58, 33, 58, 33}
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
						baseStats = new int[]{70, 80, 65, 90, 65, 85}
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
						baseStats = new int[]{50, 65, 90, 35, 35, 15}
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
						baseStats = new int[]{75, 90, 140, 60, 60, 40}
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
						baseStats = new int[]{100, 70, 70, 65, 65, 45}
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
						baseStats = new int[]{65, 75, 105, 35, 65, 85}
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
						baseStats = new int[]{75, 85, 200, 55, 65, 30}
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
						baseStats = new int[]{60, 80, 50, 40, 40, 30}
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
						baseStats = new int[]{90, 120, 75, 60, 60, 45}
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
						baseStats = new int[]{65, 95, 75, 55, 55, 85}
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
						baseStats = new int[]{70, 130, 100, 55, 80, 65}
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
						baseStats = new int[]{20, 10, 230, 10, 230, 5}
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
						baseStats = new int[]{80, 125, 75, 40, 95, 85}
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
						baseStats = new int[]{55, 95, 55, 35, 75, 115}
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
						baseStats = new int[]{60, 80, 50, 50, 50, 40}
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
						baseStats = new int[]{90, 130, 75, 75, 75, 55}
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
						baseStats = new int[]{40, 40, 40, 70, 40, 20}
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
						baseStats = new int[]{50, 50, 120, 80, 80, 30}
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
						baseStats = new int[]{50, 50, 40, 30, 30, 50}
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
						baseStats = new int[]{100, 100, 80, 60, 60, 50}
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
						baseStats = new int[]{55, 55, 85, 65, 85, 35}
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
						baseStats = new int[]{35, 65, 35, 65, 35, 65}
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
						baseStats = new int[]{75, 105, 75, 105, 75, 45}
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
						baseStats = new int[]{45, 55, 45, 65, 45, 75}
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
						baseStats = new int[]{65, 40, 70, 80, 140, 70}
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
						baseStats = new int[]{65, 80, 140, 40, 70, 70}
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
						baseStats = new int[]{45, 60, 30, 80, 50, 65}
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
						baseStats = new int[]{75, 90, 50, 110, 80, 95}
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
						baseStats = new int[]{75, 95, 95, 95, 95, 85}
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
						baseStats = new int[]{90, 60, 60, 40, 40, 40}
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
						baseStats = new int[]{90, 120, 120, 60, 60, 50}
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
						baseStats = new int[]{85, 80, 90, 105, 95, 60}
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
						baseStats = new int[]{73, 95, 62, 85, 65, 85}
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
						baseStats = new int[]{55, 20, 35, 20, 45, 75}
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
						baseStats = new int[]{35, 35, 35, 35, 35, 35}
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
						baseStats = new int[]{50, 95, 95, 35, 110, 70}
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
						baseStats = new int[]{45, 30, 15, 85, 65, 65}
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
						baseStats = new int[]{45, 63, 37, 65, 55, 95}
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
						baseStats = new int[]{45, 75, 37, 70, 55, 83}
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
						baseStats = new int[]{95, 80, 105, 40, 70, 100}
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
						baseStats = new int[]{255, 10, 10, 75, 135, 55}
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
						baseStats = new int[]{90, 85, 75, 115, 100, 115}
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
						baseStats = new int[]{115, 115, 85, 90, 75, 100}
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
						baseStats = new int[]{100, 75, 115, 90, 115, 85}
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
						baseStats = new int[]{50, 64, 50, 45, 50, 41}
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
						baseStats = new int[]{70, 84, 70, 65, 70, 51}
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
						baseStats = new int[]{100, 134, 110, 95, 100, 61}
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
						baseStats = new int[]{106, 90, 130, 90, 154, 110}
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
						baseStats = new int[]{106, 130, 90, 110, 154, 90}
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
						baseStats = new int[]{100, 100, 100, 100, 100, 100}
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
						baseStats = new int[]{40, 45, 35, 65, 55, 70}
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
						baseStats = new int[]{50, 65, 45, 85, 65, 95}
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
						baseStats = new int[]{70, 85, 65, 105, 85, 120}
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
						baseStats = new int[]{45, 60, 40, 70, 50, 45}
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
						baseStats = new int[]{60, 85, 60, 85, 60, 55}
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
						baseStats = new int[]{80, 120, 70, 110, 70, 80}
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
						baseStats = new int[]{50, 70, 50, 50, 50, 40}
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
						baseStats = new int[]{70, 85, 70, 60, 70, 50}
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
						baseStats = new int[]{100, 110, 90, 85, 90, 60}
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
						baseStats = new int[]{35, 55, 35, 30, 30, 35}
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
						baseStats = new int[]{70, 90, 70, 60, 60, 70}
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
						baseStats = new int[]{38, 30, 41, 30, 41, 60}
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
						baseStats = new int[]{78, 70, 61, 50, 61, 100}
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
						baseStats = new int[]{45, 45, 35, 20, 30, 20}
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
						baseStats = new int[]{50, 35, 55, 25, 25, 15}
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
						baseStats = new int[]{60, 70, 50, 90, 50, 65}
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
						baseStats = new int[]{50, 35, 55, 25, 25, 15}
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
						baseStats = new int[]{60, 50, 70, 50, 90, 65}
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
						baseStats = new int[]{40, 30, 30, 40, 50, 30}
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
						baseStats = new int[]{60, 50, 50, 60, 70, 50}
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
						baseStats = new int[]{80, 70, 70, 90, 100, 70}
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
						baseStats = new int[]{40, 40, 50, 30, 30, 30}
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
						baseStats = new int[]{70, 70, 40, 60, 40, 60}
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
						baseStats = new int[]{90, 100, 60, 90, 60, 80}
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
						baseStats = new int[]{40, 55, 30, 30, 30, 85}
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
						baseStats = new int[]{60, 85, 60, 50, 50, 125}
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
						baseStats = new int[]{40, 30, 30, 55, 30, 85}
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
						baseStats = new int[]{60, 50, 100, 85, 70, 65}
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
						baseStats = new int[]{28, 25, 25, 45, 35, 40}
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
						baseStats = new int[]{38, 35, 35, 65, 55, 50}
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
						baseStats = new int[]{68, 65, 65, 125, 115, 80}
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
						baseStats = new int[]{40, 30, 32, 50, 52, 65}
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
						baseStats = new int[]{70, 60, 62, 80, 82, 60}
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
						baseStats = new int[]{60, 40, 60, 40, 60, 35}
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
						baseStats = new int[]{60, 130, 80, 60, 60, 70}
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
						baseStats = new int[]{60, 60, 60, 35, 35, 30}
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
						baseStats = new int[]{80, 80, 80, 55, 55, 90}
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
						baseStats = new int[]{150, 160, 100, 95, 65, 100}
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
						baseStats = new int[]{31, 45, 90, 30, 30, 40}
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
						baseStats = new int[]{61, 90, 45, 50, 50, 160}
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
						baseStats = new int[]{1, 90, 45, 30, 30, 40}
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
						baseStats = new int[]{64, 51, 23, 51, 23, 28}
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
						baseStats = new int[]{84, 71, 43, 71, 43, 48}
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
						baseStats = new int[]{104, 91, 63, 91, 63, 68}
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
						baseStats = new int[]{72, 60, 30, 20, 30, 25}
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
						baseStats = new int[]{144, 120, 60, 40, 60, 50}
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
						baseStats = new int[]{50, 20, 40, 20, 40, 20}
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
						baseStats = new int[]{30, 45, 135, 45, 90, 30}
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
						baseStats = new int[]{50, 45, 45, 35, 35, 50}
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
						baseStats = new int[]{70, 65, 65, 55, 55, 70}
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
						baseStats = new int[]{50, 75, 75, 65, 65, 50}
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
						baseStats = new int[]{50, 85, 85, 55, 55, 50}
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
						baseStats = new int[]{50, 70, 100, 40, 40, 30}
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
						baseStats = new int[]{60, 90, 140, 50, 50, 40}
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
						baseStats = new int[]{70, 110, 180, 60, 60, 50}
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
						baseStats = new int[]{30, 40, 55, 40, 55, 60}
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
						baseStats = new int[]{60, 60, 75, 60, 75, 80}
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
						baseStats = new int[]{40, 45, 40, 65, 40, 65}
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
						baseStats = new int[]{70, 75, 60, 105, 60, 105}
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
						baseStats = new int[]{60, 50, 40, 85, 75, 95}
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
						baseStats = new int[]{60, 40, 50, 75, 85, 95}
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
						baseStats = new int[]{65, 73, 55, 47, 75, 85}
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
						baseStats = new int[]{65, 47, 55, 73, 75, 85}
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
						baseStats = new int[]{50, 60, 45, 100, 80, 65}
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
						baseStats = new int[]{70, 43, 53, 43, 53, 40}
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
						baseStats = new int[]{100, 73, 83, 73, 83, 55}
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
						baseStats = new int[]{45, 90, 20, 65, 20, 65}
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
						baseStats = new int[]{70, 120, 40, 95, 40, 95}
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
						baseStats = new int[]{130, 70, 35, 70, 35, 60}
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
						baseStats = new int[]{170, 90, 45, 90, 45, 60}
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
						baseStats = new int[]{60, 60, 40, 65, 45, 35}
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
						baseStats = new int[]{70, 100, 70, 105, 75, 40}
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
						baseStats = new int[]{70, 85, 140, 85, 70, 20}
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
						baseStats = new int[]{60, 25, 35, 70, 80, 60}
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
						baseStats = new int[]{80, 45, 65, 90, 110, 80}
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
						baseStats = new int[]{60, 60, 60, 60, 60, 60}
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
						baseStats = new int[]{45, 100, 45, 45, 45, 10}
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
						baseStats = new int[]{50, 70, 50, 50, 50, 70}
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
						baseStats = new int[]{80, 100, 80, 80, 80, 100}
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
						baseStats = new int[]{50, 85, 40, 85, 40, 35}
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
						baseStats = new int[]{70, 115, 60, 115, 60, 55}
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
						baseStats = new int[]{45, 40, 60, 40, 75, 50}
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
						baseStats = new int[]{75, 70, 90, 70, 105, 80}
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
						baseStats = new int[]{73, 115, 60, 60, 60, 90}
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
						baseStats = new int[]{73, 100, 60, 100, 60, 65}
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
						baseStats = new int[]{70, 55, 65, 95, 85, 70}
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
						baseStats = new int[]{70, 95, 85, 55, 65, 70}
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
						baseStats = new int[]{50, 48, 43, 46, 41, 60}
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
						baseStats = new int[]{110, 78, 73, 76, 71, 60}
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
						baseStats = new int[]{43, 80, 65, 50, 35, 35}
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
						baseStats = new int[]{63, 120, 85, 90, 55, 55}
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
						baseStats = new int[]{40, 40, 55, 40, 70, 55}
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
						baseStats = new int[]{60, 70, 105, 70, 120, 75}
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
						baseStats = new int[]{66, 41, 77, 61, 87, 23}
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
						baseStats = new int[]{86, 81, 97, 81, 107, 43}
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
						baseStats = new int[]{45, 95, 50, 40, 50, 75}
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
						baseStats = new int[]{75, 125, 100, 70, 80, 45}
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
						baseStats = new int[]{20, 15, 20, 10, 55, 80}
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
						baseStats = new int[]{95, 60, 79, 100, 125, 81}
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
						baseStats = new int[]{70, 70, 70, 70, 70, 70}
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
						baseStats = new int[]{60, 90, 70, 60, 120, 40}
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
						baseStats = new int[]{44, 75, 35, 63, 33, 45}
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
						baseStats = new int[]{64, 115, 65, 83, 63, 65}
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
						baseStats = new int[]{20, 40, 90, 30, 90, 25}
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
						baseStats = new int[]{40, 70, 130, 60, 130, 25}
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
						baseStats = new int[]{99, 68, 83, 72, 87, 51}
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
						baseStats = new int[]{65, 50, 70, 95, 80, 65}
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
						baseStats = new int[]{65, 130, 60, 75, 60, 75}
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
						baseStats = new int[]{95, 23, 48, 23, 48, 23}
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
						baseStats = new int[]{50, 50, 50, 50, 50, 50}
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
						baseStats = new int[]{80, 80, 80, 80, 80, 80}
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
						baseStats = new int[]{70, 40, 50, 55, 50, 25}
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
						baseStats = new int[]{90, 60, 70, 75, 70, 45}
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
						baseStats = new int[]{110, 80, 90, 95, 90, 65}
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
						baseStats = new int[]{35, 64, 85, 74, 55, 32}
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
						baseStats = new int[]{55, 104, 105, 94, 75, 52}
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
						baseStats = new int[]{55, 84, 105, 114, 75, 52}
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
						baseStats = new int[]{100, 90, 130, 45, 65, 55}
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
						baseStats = new int[]{43, 30, 55, 40, 65, 97}
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
						baseStats = new int[]{45, 75, 60, 40, 30, 50}
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
						baseStats = new int[]{65, 95, 100, 60, 50, 50}
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
						baseStats = new int[]{95, 135, 80, 110, 80, 100}
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
						baseStats = new int[]{40, 55, 80, 35, 60, 30}
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
						baseStats = new int[]{60, 75, 100, 55, 80, 50}
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
						baseStats = new int[]{80, 135, 130, 95, 90, 70}
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
						baseStats = new int[]{80, 100, 200, 50, 100, 50}
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
						baseStats = new int[]{80, 50, 100, 100, 200, 50}
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
						baseStats = new int[]{80, 75, 150, 75, 150, 50}
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
						baseStats = new int[]{80, 80, 90, 110, 130, 110}
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
						baseStats = new int[]{80, 90, 80, 130, 110, 110}
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
						baseStats = new int[]{100, 100, 90, 150, 140, 90}
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
						baseStats = new int[]{100, 150, 140, 100, 90, 90}
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
						baseStats = new int[]{105, 150, 90, 150, 90, 95}
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
						baseStats = new int[]{100, 100, 100, 100, 100, 100}
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
						baseStats = new int[]{50, 150, 50, 150, 50, 150}
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
						baseStats = new int[]{55, 68, 64, 45, 55, 31}
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
						baseStats = new int[]{75, 89, 85, 55, 65, 36}
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
						baseStats = new int[]{95, 109, 105, 75, 85, 56}
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
						baseStats = new int[]{44, 58, 44, 58, 44, 61}
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
						baseStats = new int[]{64, 78, 52, 78, 52, 81}
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
						baseStats = new int[]{76, 104, 71, 104, 71, 108}
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
						baseStats = new int[]{53, 51, 53, 61, 56, 40}
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
						baseStats = new int[]{64, 66, 68, 81, 76, 50}
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
						baseStats = new int[]{84, 86, 88, 111, 101, 60}
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
						baseStats = new int[]{40, 55, 30, 30, 30, 60}
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
						baseStats = new int[]{55, 75, 50, 40, 40, 80}
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
						baseStats = new int[]{85, 120, 70, 50, 50, 100}
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
						baseStats = new int[]{59, 45, 40, 35, 40, 31}
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
						baseStats = new int[]{79, 85, 60, 55, 60, 71}
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
						baseStats = new int[]{37, 25, 41, 25, 41, 25}
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
						baseStats = new int[]{77, 85, 51, 55, 51, 65}
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
						baseStats = new int[]{45, 65, 34, 40, 34, 45}
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
						baseStats = new int[]{60, 85, 49, 60, 49, 60}
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
						baseStats = new int[]{80, 120, 79, 95, 79, 70}
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
						baseStats = new int[]{40, 30, 35, 50, 70, 55}
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
						baseStats = new int[]{60, 70, 55, 125, 105, 90}
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
						baseStats = new int[]{67, 125, 40, 30, 30, 58}
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
						baseStats = new int[]{97, 165, 60, 65, 50, 58}
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
						baseStats = new int[]{30, 42, 118, 42, 88, 30}
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
						baseStats = new int[]{60, 52, 168, 47, 138, 30}
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
						baseStats = new int[]{40, 29, 45, 29, 45, 36}
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
						baseStats = new int[]{60, 59, 85, 79, 105, 36}
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
						baseStats = new int[]{70, 94, 50, 94, 50, 66}
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
						baseStats = new int[]{30, 30, 42, 30, 42, 70}
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
						baseStats = new int[]{70, 80, 102, 80, 102, 40}
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
						baseStats = new int[]{60, 45, 70, 45, 90, 95}
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
						baseStats = new int[]{55, 65, 35, 60, 30, 85}
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
						baseStats = new int[]{85, 105, 55, 85, 50, 115}
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
						baseStats = new int[]{45, 35, 45, 62, 53, 35}
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
						baseStats = new int[]{70, 60, 70, 87, 78, 85}
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
						baseStats = new int[]{76, 48, 48, 57, 62, 34}
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
						baseStats = new int[]{111, 83, 68, 92, 82, 39}
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
						baseStats = new int[]{75, 100, 66, 60, 66, 115}
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
						baseStats = new int[]{90, 50, 34, 60, 44, 70}
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
						baseStats = new int[]{150, 80, 44, 90, 54, 80}
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
						baseStats = new int[]{55, 66, 44, 44, 56, 85}
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
						baseStats = new int[]{65, 76, 84, 54, 96, 105}
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
						baseStats = new int[]{60, 60, 60, 105, 105, 105}
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
						baseStats = new int[]{100, 125, 52, 105, 52, 71}
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
						baseStats = new int[]{49, 55, 42, 42, 37, 85}
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
						baseStats = new int[]{71, 82, 64, 64, 59, 112}
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
						baseStats = new int[]{45, 30, 50, 65, 50, 45}
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
						baseStats = new int[]{63, 63, 47, 41, 41, 74}
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
						baseStats = new int[]{103, 93, 67, 71, 61, 84}
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
						baseStats = new int[]{57, 24, 86, 24, 86, 23}
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
						baseStats = new int[]{67, 89, 116, 79, 116, 33}
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
						baseStats = new int[]{50, 80, 95, 10, 45, 10}
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
						baseStats = new int[]{20, 25, 45, 70, 90, 60}
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
						baseStats = new int[]{100, 5, 5, 15, 65, 30}
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
						baseStats = new int[]{76, 65, 45, 92, 42, 91}
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
						baseStats = new int[]{50, 92, 108, 92, 108, 35}
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
						baseStats = new int[]{58, 70, 45, 40, 45, 42}
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
						baseStats = new int[]{68, 90, 65, 50, 55, 82}
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
						baseStats = new int[]{108, 130, 95, 80, 85, 102}
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
						baseStats = new int[]{135, 85, 40, 40, 85, 5}
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
						baseStats = new int[]{40, 70, 40, 35, 40, 60}
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
						baseStats = new int[]{70, 110, 70, 115, 70, 90}
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
						baseStats = new int[]{68, 72, 78, 38, 42, 32}
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
						baseStats = new int[]{108, 112, 118, 68, 72, 47}
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
						baseStats = new int[]{40, 50, 90, 30, 55, 65}
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
						baseStats = new int[]{70, 90, 110, 60, 75, 95}
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
						baseStats = new int[]{48, 61, 40, 61, 40, 50}
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
						baseStats = new int[]{83, 106, 65, 86, 65, 85}
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
						baseStats = new int[]{74, 100, 72, 90, 72, 46}
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
						baseStats = new int[]{49, 49, 56, 49, 61, 66}
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
						baseStats = new int[]{69, 69, 76, 69, 86, 91}
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
						baseStats = new int[]{45, 20, 50, 60, 120, 50}
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
						baseStats = new int[]{60, 62, 50, 62, 60, 40}
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
						baseStats = new int[]{90, 92, 75, 92, 85, 60}
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
						baseStats = new int[]{70, 120, 65, 45, 85, 125}
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
						baseStats = new int[]{70, 70, 115, 130, 90, 60}
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
						baseStats = new int[]{110, 85, 95, 80, 95, 50}
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
						baseStats = new int[]{115, 140, 130, 55, 55, 40}
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
						baseStats = new int[]{100, 100, 125, 110, 50, 50}
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
						baseStats = new int[]{75, 123, 67, 95, 85, 95}
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
						baseStats = new int[]{75, 95, 67, 125, 95, 83}
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
						baseStats = new int[]{85, 50, 95, 120, 115, 80}
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
						baseStats = new int[]{86, 76, 86, 116, 56, 95}
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
						baseStats = new int[]{65, 110, 130, 60, 65, 95}
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
						baseStats = new int[]{65, 60, 110, 130, 95, 65}
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
						baseStats = new int[]{75, 95, 125, 45, 75, 95}
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
						baseStats = new int[]{110, 130, 80, 70, 60, 80}
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
						baseStats = new int[]{85, 80, 70, 135, 75, 90}
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
						baseStats = new int[]{68, 125, 65, 65, 115, 80}
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
						baseStats = new int[]{60, 55, 145, 75, 150, 40}
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
						baseStats = new int[]{45, 100, 135, 65, 135, 45}
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
						baseStats = new int[]{70, 80, 70, 80, 70, 110}
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
						baseStats = new int[]{50, 50, 77, 95, 77, 91}
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
						baseStats = new int[]{75, 75, 130, 75, 130, 95}
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
						baseStats = new int[]{80, 105, 105, 105, 105, 80}
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
						baseStats = new int[]{75, 125, 70, 125, 70, 115}
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
						baseStats = new int[]{100, 120, 120, 150, 100, 90}
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
						baseStats = new int[]{90, 120, 100, 150, 120, 100}
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
						baseStats = new int[]{91, 90, 106, 130, 106, 77}
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
						baseStats = new int[]{110, 160, 110, 80, 110, 100}
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
						baseStats = new int[]{150, 100, 120, 100, 120, 90}
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
						baseStats = new int[]{120, 70, 120, 75, 130, 85}
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
						baseStats = new int[]{80, 80, 80, 80, 80, 80}
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
						baseStats = new int[]{100, 100, 100, 100, 100, 100}
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
						baseStats = new int[]{70, 90, 90, 135, 90, 125}
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
						baseStats = new int[]{100, 100, 100, 100, 100, 100}
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
						baseStats = new int[]{120, 120, 120, 120, 120, 120}
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
						baseStats = new int[]{100, 100, 100, 100, 100, 100}
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
						baseStats = new int[]{45, 45, 55, 45, 55, 63}
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
						baseStats = new int[]{60, 60, 75, 60, 75, 83}
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
						baseStats = new int[]{75, 75, 95, 75, 95, 113}
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
						baseStats = new int[]{65, 63, 45, 45, 45, 45}
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
						baseStats = new int[]{90, 93, 55, 70, 55, 55}
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
						baseStats = new int[]{110, 123, 65, 100, 65, 65}
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
						baseStats = new int[]{55, 55, 45, 63, 45, 45}
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
						baseStats = new int[]{75, 75, 60, 83, 60, 60}
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
						baseStats = new int[]{95, 100, 85, 108, 70, 70}
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
						baseStats = new int[]{45, 55, 39, 35, 39, 42}
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
						baseStats = new int[]{60, 85, 69, 60, 69, 77}
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
						baseStats = new int[]{45, 60, 45, 25, 45, 55}
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
						baseStats = new int[]{65, 80, 65, 35, 65, 60}
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
						baseStats = new int[]{85, 100, 90, 45, 90, 80}
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
						baseStats = new int[]{41, 50, 37, 50, 37, 66}
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
						baseStats = new int[]{64, 88, 50, 88, 50, 106}
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
						baseStats = new int[]{50, 53, 48, 53, 48, 64}
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
						baseStats = new int[]{75, 98, 63, 98, 63, 101}
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
						baseStats = new int[]{50, 53, 48, 53, 48, 64}
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
						baseStats = new int[]{75, 98, 63, 98, 63, 101}
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
						baseStats = new int[]{50, 53, 48, 53, 48, 64}
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
						baseStats = new int[]{75, 98, 63, 98, 63, 101}
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
						baseStats = new int[]{76, 25, 45, 67, 55, 24}
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
						baseStats = new int[]{116, 55, 85, 107, 95, 29}
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
						baseStats = new int[]{50, 55, 50, 36, 30, 43}
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
						baseStats = new int[]{62, 77, 62, 50, 42, 65}
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
						baseStats = new int[]{80, 105, 80, 65, 55, 93}
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
						baseStats = new int[]{45, 60, 32, 50, 32, 76}
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
						baseStats = new int[]{75, 100, 63, 80, 63, 116}
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
						baseStats = new int[]{55, 75, 85, 25, 25, 15}
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
						baseStats = new int[]{70, 105, 105, 50, 40, 20}
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
						baseStats = new int[]{85, 135, 130, 60, 70, 25}
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
						baseStats = new int[]{55, 45, 43, 55, 43, 72}
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
						baseStats = new int[]{67, 57, 55, 77, 55, 114}
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
						baseStats = new int[]{60, 85, 40, 30, 45, 68}
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
						baseStats = new int[]{110, 135, 60, 50, 65, 88}
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
						baseStats = new int[]{103, 60, 86, 60, 86, 50}
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
						baseStats = new int[]{75, 80, 55, 25, 35, 35}
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
						baseStats = new int[]{85, 105, 85, 40, 50, 40}
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
						baseStats = new int[]{105, 140, 95, 55, 65, 45}
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
						baseStats = new int[]{50, 50, 40, 50, 40, 64}
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
						baseStats = new int[]{75, 65, 55, 65, 55, 69}
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
						baseStats = new int[]{105, 85, 75, 85, 75, 74}
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
						baseStats = new int[]{120, 100, 85, 30, 85, 45}
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
						baseStats = new int[]{75, 125, 75, 30, 75, 85}
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
						baseStats = new int[]{45, 53, 70, 40, 60, 42}
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
						baseStats = new int[]{55, 63, 90, 50, 80, 42}
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
						baseStats = new int[]{75, 103, 80, 70, 70, 92}
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
						baseStats = new int[]{30, 45, 59, 30, 39, 57}
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
						baseStats = new int[]{40, 55, 99, 40, 79, 47}
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
						baseStats = new int[]{60, 90, 89, 55, 69, 112}
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
						baseStats = new int[]{40, 27, 60, 37, 50, 66}
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
						baseStats = new int[]{60, 67, 85, 77, 75, 116}
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
						baseStats = new int[]{45, 35, 50, 70, 50, 30}
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
						baseStats = new int[]{70, 60, 75, 110, 75, 90}
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
						baseStats = new int[]{70, 92, 65, 80, 55, 98}
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
						baseStats = new int[]{50, 72, 35, 35, 35, 65}
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
						baseStats = new int[]{60, 82, 45, 45, 45, 74}
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
						baseStats = new int[]{95, 117, 70, 65, 70, 92}
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
						baseStats = new int[]{70, 90, 45, 15, 45, 50}
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
						baseStats = new int[]{105, 140, 55, 30, 55, 95}
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
						baseStats = new int[]{75, 86, 67, 106, 67, 60}
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
						baseStats = new int[]{50, 65, 85, 35, 35, 55}
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
						baseStats = new int[]{70, 95, 125, 65, 75, 45}
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
						baseStats = new int[]{50, 75, 70, 35, 70, 48}
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
						baseStats = new int[]{65, 90, 115, 45, 115, 58}
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
						baseStats = new int[]{72, 58, 80, 103, 80, 97}
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
						baseStats = new int[]{38, 30, 85, 55, 65, 30}
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
						baseStats = new int[]{58, 50, 145, 95, 105, 30}
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
						baseStats = new int[]{54, 78, 103, 53, 45, 22}
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
						baseStats = new int[]{74, 108, 133, 83, 65, 32}
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
						baseStats = new int[]{55, 112, 45, 74, 45, 70}
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
						baseStats = new int[]{75, 140, 65, 112, 65, 110}
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
						baseStats = new int[]{50, 50, 62, 40, 62, 65}
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
						baseStats = new int[]{80, 95, 82, 60, 82, 75}
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
						baseStats = new int[]{40, 65, 40, 80, 40, 65}
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
						baseStats = new int[]{60, 105, 60, 120, 60, 105}
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
						baseStats = new int[]{55, 50, 40, 40, 40, 75}
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
						baseStats = new int[]{75, 95, 60, 65, 60, 115}
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
						baseStats = new int[]{45, 30, 50, 55, 65, 45}
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
						baseStats = new int[]{60, 45, 70, 75, 85, 55}
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
						baseStats = new int[]{70, 55, 95, 95, 110, 65}
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
						baseStats = new int[]{45, 30, 40, 105, 50, 20}
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
						baseStats = new int[]{65, 40, 50, 125, 60, 30}
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
						baseStats = new int[]{110, 65, 75, 125, 85, 30}
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
						baseStats = new int[]{62, 44, 50, 44, 50, 55}
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
						baseStats = new int[]{75, 87, 63, 87, 63, 98}
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
						baseStats = new int[]{36, 50, 50, 65, 60, 44}
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
						baseStats = new int[]{51, 65, 65, 80, 75, 59}
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
						baseStats = new int[]{71, 95, 85, 110, 95, 79}
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
						baseStats = new int[]{60, 60, 50, 40, 50, 75}
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
						baseStats = new int[]{80, 100, 70, 60, 70, 95}
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
						baseStats = new int[]{55, 75, 60, 75, 60, 103}
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
						baseStats = new int[]{50, 75, 45, 40, 45, 60}
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
						baseStats = new int[]{70, 135, 105, 60, 105, 20}
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
						baseStats = new int[]{69, 55, 45, 55, 55, 15}
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
						baseStats = new int[]{114, 85, 70, 85, 80, 30}
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
						baseStats = new int[]{55, 40, 50, 65, 85, 40}
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
						baseStats = new int[]{100, 60, 70, 85, 105, 60}
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
						baseStats = new int[]{165, 75, 80, 40, 45, 65}
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
						baseStats = new int[]{50, 47, 50, 57, 50, 65}
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
						baseStats = new int[]{70, 77, 60, 97, 60, 108}
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
						baseStats = new int[]{44, 50, 91, 24, 86, 10}
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
						baseStats = new int[]{74, 94, 131, 54, 116, 20}
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
						baseStats = new int[]{40, 55, 70, 45, 60, 30}
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
						baseStats = new int[]{60, 80, 95, 70, 85, 50}
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
						baseStats = new int[]{60, 100, 115, 70, 85, 90}
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
						baseStats = new int[]{35, 55, 40, 45, 40, 60}
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
						baseStats = new int[]{65, 85, 70, 75, 70, 40}
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
						baseStats = new int[]{85, 115, 80, 105, 80, 50}
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
						baseStats = new int[]{55, 55, 55, 85, 55, 30}
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
						baseStats = new int[]{75, 75, 75, 125, 95, 40}
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
						baseStats = new int[]{50, 30, 55, 65, 55, 20}
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
						baseStats = new int[]{60, 40, 60, 95, 60, 55}
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
						baseStats = new int[]{60, 55, 90, 145, 90, 80}
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
						baseStats = new int[]{46, 87, 60, 30, 40, 57}
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
						baseStats = new int[]{66, 117, 70, 40, 50, 67}
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
						baseStats = new int[]{76, 147, 90, 60, 70, 97}
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
						baseStats = new int[]{55, 70, 40, 60, 40, 40}
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
						baseStats = new int[]{95, 110, 80, 70, 80, 50}
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
						baseStats = new int[]{70, 50, 30, 95, 135, 105}
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
						baseStats = new int[]{50, 40, 85, 40, 65, 25}
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
						baseStats = new int[]{80, 70, 40, 100, 60, 145}
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
						baseStats = new int[]{109, 66, 84, 81, 99, 32}
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
						baseStats = new int[]{45, 85, 50, 55, 50, 65}
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
						baseStats = new int[]{65, 125, 60, 95, 60, 105}
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
						baseStats = new int[]{77, 120, 90, 60, 90, 48}
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
						baseStats = new int[]{59, 74, 50, 35, 50, 35}
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
						baseStats = new int[]{89, 124, 80, 55, 80, 55}
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
						baseStats = new int[]{45, 85, 70, 40, 40, 60}
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
						baseStats = new int[]{65, 125, 100, 60, 70, 70}
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
						baseStats = new int[]{95, 110, 95, 40, 95, 55}
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
						baseStats = new int[]{70, 83, 50, 37, 50, 60}
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
						baseStats = new int[]{100, 123, 75, 57, 75, 80}
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
						baseStats = new int[]{70, 55, 75, 45, 65, 60}
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
						baseStats = new int[]{110, 65, 105, 55, 95, 80}
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
						baseStats = new int[]{85, 97, 66, 105, 66, 65}
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
						baseStats = new int[]{58, 109, 112, 48, 48, 109}
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
						baseStats = new int[]{52, 65, 50, 45, 50, 38}
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
						baseStats = new int[]{72, 85, 70, 65, 70, 58}
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
						baseStats = new int[]{92, 105, 90, 125, 90, 98}
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
						baseStats = new int[]{55, 85, 55, 50, 55, 60}
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
						baseStats = new int[]{85, 60, 65, 135, 105, 100}
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
						baseStats = new int[]{91, 90, 129, 90, 72, 108}
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
						baseStats = new int[]{91, 129, 90, 72, 90, 108}
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
						baseStats = new int[]{91, 90, 72, 90, 129, 108}
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
						baseStats = new int[]{79, 115, 70, 125, 80, 111}
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
						baseStats = new int[]{79, 115, 70, 125, 80, 111}
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
						baseStats = new int[]{100, 120, 100, 150, 120, 90}
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
						baseStats = new int[]{100, 150, 120, 120, 100, 90}
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
						baseStats = new int[]{89, 125, 90, 115, 80, 101}
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
						baseStats = new int[]{125, 130, 90, 130, 90, 95}
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
						baseStats = new int[]{91, 72, 90, 129, 90, 108}
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
						baseStats = new int[]{100, 77, 77, 128, 128, 90}
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
						baseStats = new int[]{71, 120, 95, 120, 95, 99}
					}
				}
			}
			
		};
	}
}