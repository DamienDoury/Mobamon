using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mobamon.Database.Classes;
using Mobamon.Database.Enums;
using Mobamon.Inventory;

namespace Mobamon.Database
{
    public static class ItemPool
    {
        public static Dictionary<int, Item> item = new Dictionary<int, Item>
        {
            {
                1,
                new Item
                    (
                        name: "Ability Urge",
                        identifier: "Battle items",
                        description: "When used, it activates the Ability of an ally Pokémon.",
                        id: 319
                        )
            },
            {
                2,
                new Item
                    (
                        name: "Absorb Bulb",
                        identifier: "Hold items",
                        description: "A consumable bulb. If the holder is hit by a Water-type move, its Sp. Atk will rise.",
                        id: 40
                        )
            },
            {
                3,
                new Item
                    (
                        name: "Adamant Orb",
                        identifier: "Hold items",
                        description: "A brightly gleaming orb to be held by DIALGA. It boosts the power of Dragon-, and Steel-type moves.",
                        id: 123
                        )
            },
            {
                4,
                new Item
                    (
                        name: "Aguav Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it restores the user's HP in a pinch, but will cause confusion if it hates the taste.",
                        id: 241
                        )
            },
            {
                5,
                new Item
                    (
                        name: "Air Balloon",
                        identifier: "Hold items",
                        description: "When held by a Pokémon, the Pokémon will float into the air. When the holder is attacked, this item will burst.",
                        id: 36
                        )
            },
            {
                6,
                new Item
                    (
                        name: "Amulet Coin",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It doubles a battle's prize money if the holding Pokémon joins in.",
                        id: 111
                        )
            },
            {
                7,
                new Item
                    (
                        name: "Antidote",
                        identifier: "Medicine",
                        description: "A spray-type medicine. It lifts the effect of poison from one Pokémon.",
                        id: 178
                        )
            },
            {
                8,
                new Item
                    (
                        name: "Apicot Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it raises its Sp. Def stat in a pinch.",
                        id: 284
                        )
            },
            {
                9,
                new Item
                    (
                        name: "Armor Fossil",
                        identifier: "General items",
                        description: "A fossil from a prehistoric Pokémon that lived on the land. It appears to be part of a collar.",
                        id: 348
                        )
            },
            {
                10,
                new Item
                    (
                        name: "Aspear Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it defrosts it.",
                        id: 232
                        )
            },
            {
                11,
                new Item
                    (
                        name: "Awakening",
                        identifier: "Medicine",
                        description: "A spray-type medicine. It awakens a Pokémon from the clutches of sleep.",
                        id: 181
                        )
            },
            {
                12,
                new Item
                    (
                        name: "Babiri Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Steel-type attack against the holding Pokémon.",
                        id: 278
                        )
            },
            {
                13,
                new Item
                    (
                        name: "BalmMushroom",
                        identifier: "General items",
                        description: "A rare mushroom which gives off a nice fragrance. A maniac will buy it for a high price.",
                        id: 371
                        )
            },
            {
                14,
                new Item
                    (
                        name: "Belue Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 262
                        )
            },
            {
                15,
                new Item
                    (
                        name: "Berry Juice",
                        identifier: "Medicine",
                        description: "A 100% pure juice made of Berries. It restores the HP of one Pokémon by just 20 points.",
                        id: 176
                        )
            },
            {
                16,
                new Item
                    (
                        name: "Big Mushroom",
                        identifier: "General items",
                        description: "A large and rare mushroom. It is sought after by collectors.",
                        id: 363
                        )
            },
            {
                17,
                new Item
                    (
                        name: "Big Nugget",
                        identifier: "General items",
                        description: "A big nugget of pure gold that gives off a lustrous gleam. A maniac will buy it for a high price.",
                        id: 372
                        )
            },
            {
                18,
                new Item
                    (
                        name: "Big Pearl",
                        identifier: "General items",
                        description: "A quite-large pearl that sparkles in a pretty silver color. It can be sold at a high price to shops.",
                        id: 365
                        )
            },
            {
                19,
                new Item
                    (
                        name: "Big Root",
                        identifier: "Hold items",
                        description: "A Pokémon held item that boosts the power of HP-stealing moves to let the holder recover more HP.",
                        id: 30
                        )
            },
            {
                20,
                new Item
                    (
                        name: "Binding Band",
                        identifier: "Hold items",
                        description: "A band that increases the power of binding moves when held.",
                        id: 39
                        )
            },
            {
                21,
                new Item
                    (
                        name: "Black Belt",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a belt that boosts determination and Fighting-type moves.",
                        id: 50
                        )
            },
            {
                22,
                new Item
                    (
                        name: "Black Flute",
                        identifier: "General items",
                        description: "A toy flute made from black glass. A maniac will buy it for a high price.",
                        id: 355
                        )
            },
            {
                23,
                new Item
                    (
                        name: "Black Sludge",
                        identifier: "Hold items",
                        description: "A held item that gradually restores the HP of Poison-type Pokémon. It inflicts damage on all other types.",
                        id: 23
                        )
            },
            {
                24,
                new Item
                    (
                        name: "BlackGlasses",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a shady-looking pair of glasses that boosts Dark-type moves.",
                        id: 49
                        )
            },
            {
                25,
                new Item
                    (
                        name: "Blk Apricorn",
                        identifier: "General items",
                        description: "A black Apricorn It has an indescribable scent.",
                        id: 395
                        )
            },
            {
                26,
                new Item
                    (
                        name: "Blu Apricorn",
                        identifier: "General items",
                        description: "A blue Apricorn. It smells a bit like grass.",
                        id: 390
                        )
            },
            {
                27,
                new Item
                    (
                        name: "Blue Flute",
                        identifier: "General items",
                        description: "A toy flute made from blue glass. A maniac will buy it for a high price.",
                        id: 405
                        )
            },
            {
                28,
                new Item
                    (
                        name: "Blue Scarf",
                        identifier: "General items",
                        description: "An item to be held by a Pokémon. It boosts the Beauty aspect of the holder in a Contest.",
                        id: 401
                        )
            },
            {
                29,
                new Item
                    (
                        name: "Blue Shard",
                        identifier: "General items",
                        description: "A small blue shard. It appears to be from some sort of implement made long ago.",
                        id: 385
                        )
            },
            {
                30,
                new Item
                    (
                        name: "Bluk Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 250
                        )
            },
            {
                31,
                new Item
                    (
                        name: "BrightPowder",
                        identifier: "Hold items",
                        description: "An item to be held by a POKÉMON. It casts a tricky glare that lowers the opponent's accuracy.",
                        id: 1
                        )
            },
            {
                32,
                new Item
                    (
                        name: "Bug Gem",
                        identifier: "Hold items",
                        description: "A gem with an insect-like essence. When held, it strengthens the power of a Bug-type move only once.",
                        id: 92
                        )
            },
            {
                33,
                new Item
                    (
                        name: "Burn Drive",
                        identifier: "Hold items",
                        description: "A cassette to be held by Genesect. It changes Techno Blast to a Fire-type move.",
                        id: 137
                        )
            },
            {
                34,
                new Item
                    (
                        name: "Burn Heal",
                        identifier: "Medicine",
                        description: "A spray-type medicine. It heals a single Pokémon that is suffering from a burn.",
                        id: 179
                        )
            },
            {
                35,
                new Item
                    (
                        name: "Calcium",
                        identifier: "Medicine",
                        description: "A nutritious drink for Pokémon. It raises the base Sp. Atk (Special Attack) stat of a single Pokémon.",
                        id: 200
                        )
            },
            {
                36,
                new Item
                    (
                        name: "Carbos",
                        identifier: "Medicine",
                        description: "A nutritious drink for Pokémon. It raises the base Speed stat of a single Pokémon.",
                        id: 199
                        )
            },
            {
                37,
                new Item
                    (
                        name: "Casteliacone",
                        identifier: "Medicine",
                        description: "Castelia City's specialty, soft-serve ice cream. It heals all the status problems of a single Pokémon.",
                        id: 187
                        )
            },
            {
                38,
                new Item
                    (
                        name: "Cell Battery",
                        identifier: "Hold items",
                        description: "A consumable battery. If the holder is hit by an Electric-type move, its Attack will rise.",
                        id: 41
                        )
            },
            {
                39,
                new Item
                    (
                        name: "Charcoal",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a combustible fuel that boosts the power of Fire-type moves.",
                        id: 58
                        )
            },
            {
                40,
                new Item
                    (
                        name: "Charti Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Rock-type attack against the holding Pokémon.",
                        id: 274
                        )
            },
            {
                41,
                new Item
                    (
                        name: "Cheri Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it recovers from paralysis.",
                        id: 228
                        )
            },
            {
                42,
                new Item
                    (
                        name: "Cherish Ball",
                        identifier: "Pokeballs",
                        description: "A quite rare Poké Ball that has been specially crafted to commemorate an occasion of some sort.",
                        id: 156
                        )
            },
            {
                43,
                new Item
                    (
                        name: "Chesto Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it recovers from sleep.",
                        id: 229
                        )
            },
            {
                44,
                new Item
                    (
                        name: "Chilan Berry",
                        identifier: "Berries",
                        description: "Weakens a Normal-type attack against the Pokémon holding this berry.",
                        id: 279
                        )
            },
            {
                45,
                new Item
                    (
                        name: "Chill Drive",
                        identifier: "Hold items",
                        description: "A cassette to be held by Genesect. It changes Techno Blast to an Ice-type move.",
                        id: 138
                        )
            },
            {
                46,
                new Item
                    (
                        name: "Choice Band",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. This headband ups Attack, but allows the use of only one of its moves.",
                        id: 99
                        )
            },
            {
                47,
                new Item
                    (
                        name: "Choice Scarf",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. This scarf boosts Speed, but allows the use of only one of its moves.",
                        id: 100
                        )
            },
            {
                48,
                new Item
                    (
                        name: "Choice Specs",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. These distinctive glasses boost Sp. Atk but allow the use of only one of its moves.",
                        id: 101
                        )
            },
            {
                49,
                new Item
                    (
                        name: "Chople Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Fighting-type attack against the holding Pokémon.",
                        id: 268
                        )
            },
            {
                50,
                new Item
                    (
                        name: "Claw Fossil",
                        identifier: "General items",
                        description: "A fossil of an ancient Pokémon that lived in the sea. It appears to be part of a claw.",
                        id: 344
                        )
            },
            {
                51,
                new Item
                    (
                        name: "Cleanse Tag",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It helps keep wild Pokémon away if the holder is the first one in the party.",
                        id: 112
                        )
            },
            {
                52,
                new Item
                    (
                        name: "Clever Wing",
                        identifier: "Medicine",
                        description: "An item for use on a Pokémon. It slightly increases the base Sp. Def stat of a single Pokémon.",
                        id: 209
                        )
            },
            {
                53,
                new Item
                    (
                        name: "Coba Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Flying-type attack against the holding Pokémon.",
                        id: 271
                        )
            },
            {
                54,
                new Item
                    (
                        name: "Colbur Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Dark-type attack against the holding Pokémon.",
                        id: 277
                        )
            },
            {
                55,
                new Item
                    (
                        name: "Comet Shard",
                        identifier: "General items",
                        description: "A shard which fell to the ground when a comet approached. A maniac will buy it for a high price.",
                        id: 374
                        )
            },
            {
                56,
                new Item
                    (
                        name: "Cornn Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 254
                        )
            },
            {
                57,
                new Item
                    (
                        name: "Cover Fossil",
                        identifier: "General items",
                        description: "A fossil of an ancient Pokémon that lived in the sea in ancient times. It appears to be part of its back.",
                        id: 351
                        )
            },
            {
                58,
                new Item
                    (
                        name: "Custap Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it gets to move first just once in a pinch.",
                        id: 288
                        )
            },
            {
                59,
                new Item
                    (
                        name: "Damp Mulch",
                        identifier: "General items",
                        description: "A fertilizer to be spread on soft soil in regions where Berries are grown. A maniac will buy it for a high price.",
                        id: 397
                        )
            },
            {
                60,
                new Item
                    (
                        name: "Damp Rock",
                        identifier: "Hold items",
                        description: "A Pokémon held item that extends the duration of the move Rain Dance used by the holder.",
                        id: 27
                        )
            },
            {
                61,
                new Item
                    (
                        name: "Dark Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of darkness. When held, it strengthens the power of a Dark-type move only once.",
                        id: 95
                        )
            },
            {
                62,
                new Item
                    (
                        name: "Dawn Stone",
                        identifier: "General items",
                        description: "A peculiar stone that makes certain species of Pokémon evolve. It sparkles like eyes.",
                        id: 332
                        )
            },
            {
                63,
                new Item
                    (
                        name: "DeepSeaScale",
                        identifier: "Hold items",
                        description: "An item to be held by CLAMPERL. A scale that shines a faint pink, it raises the Sp. Def stat.",
                        id: 127
                        )
            },
            {
                64,
                new Item
                    (
                        name: "DeepSeaTooth",
                        identifier: "Hold items",
                        description: "An item to be held by CLAMPERL. A fang that gleams a sharp silver, it raises the Sp. Atk stat.",
                        id: 126
                        )
            },
            {
                65,
                new Item
                    (
                        name: "Destiny Knot",
                        identifier: "Hold items",
                        description: "A long, thin, bright-red string to be held by a Pokémon. If the holder becomes infatuated, the foe does too.",
                        id: 22
                        )
            },
            {
                66,
                new Item
                    (
                        name: "Dire Hit",
                        identifier: "Battle items",
                        description: "It raises the critical-hit ratio greatly. It can be used only once and wears off if the Pokémon is withdrawn.",
                        id: 293
                        )
            },
            {
                67,
                new Item
                    (
                        name: "Dire Hit 2",
                        identifier: "Battle items",
                        description: "It can be used many times to raise the critical-hit ratio of one Pokémon. It wears off if the Pokémon is withdrawn.",
                        id: 300
                        )
            },
            {
                68,
                new Item
                    (
                        name: "Dire Hit 3",
                        identifier: "Battle items",
                        description: "It can be used many times to greatly raise a Pokémon's critical-hit ratio. It wears off if the Pokémon is withdrawn.",
                        id: 323
                        )
            },
            {
                69,
                new Item
                    (
                        name: "Dive Ball",
                        identifier: "Pokeballs",
                        description: "A somewhat different Poké Ball that works especially well on Pokémon that live underwater.",
                        id: 147
                        )
            },
            {
                70,
                new Item
                    (
                        name: "Dome Fossil",
                        identifier: "General items",
                        description: "A fossil of an ancient Pokémon that lived in the sea. It appears to be part of a shell.",
                        id: 346
                        )
            },
            {
                71,
                new Item
                    (
                        name: "Douse Drive",
                        identifier: "Hold items",
                        description: "A cassette to be held by Genesect. It changes Techno Blast to a Water-type move.",
                        id: 135
                        )
            },
            {
                72,
                new Item
                    (
                        name: "Draco Plate",
                        identifier: "Hold items",
                        description: "Increases power of Dragon-type moves. Changes Arceus' type to Dragon.",
                        id: 79
                        )
            },
            {
                73,
                new Item
                    (
                        name: "Dragon Fang",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a hard and sharp fang that ups the power of Dragon-type moves.",
                        id: 59
                        )
            },
            {
                74,
                new Item
                    (
                        name: "Dragon Gem",
                        identifier: "Hold items",
                        description: "A gem with a draconic essence. When held, it strengthens the power of a Dragon-type move only once.",
                        id: 97
                        )
            },
            {
                75,
                new Item
                    (
                        name: "Dragon Scale",
                        identifier: "General items",
                        description: "A thick and tough scale. Dragon-type Pokémon may be holding this item when caught.",
                        id: 334
                        )
            },
            {
                76,
                new Item
                    (
                        name: "Dread Plate",
                        identifier: "Hold items",
                        description: "Increases power of Dark-type moves. Changes Arceus' type to Dark.",
                        id: 80
                        )
            },
            {
                77,
                new Item
                    (
                        name: "Dream Ball",
                        identifier: "Pokeballs",
                        description: "A special Poké Ball that appears out of nowhere in a bag at the Entree Forest. It can catch any Pokémon.",
                        id: 157
                        )
            },
            {
                78,
                new Item
                    (
                        name: "Dubious Disc",
                        identifier: "General items",
                        description: "A transparent device overflowing with dubious data. Its producer is unknown.",
                        id: 339
                        )
            },
            {
                79,
                new Item
                    (
                        name: "Durin Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 261
                        )
            },
            {
                80,
                new Item
                    (
                        name: "Dusk Ball",
                        identifier: "Pokeballs",
                        description: "A somewhat different Poké Ball that makes it easier to catch wild Pokémon at night or in dark places like caves.",
                        id: 153
                        )
            },
            {
                81,
                new Item
                    (
                        name: "Dusk Stone",
                        identifier: "General items",
                        description: "A peculiar stone that makes certain species of Pokémon evolve. It is as dark as dark can be.",
                        id: 331
                        )
            },
            {
                82,
                new Item
                    (
                        name: "Earth Plate",
                        identifier: "Hold items",
                        description: "Increases power of Ground-type moves. Changes Arceus' type to Ground.",
                        id: 73
                        )
            },
            {
                83,
                new Item
                    (
                        name: "Eject Button",
                        identifier: "Hold items",
                        description: "If the holder is hit by an attack, it will switch with another Pokémon in your party.",
                        id: 42
                        )
            },
            {
                84,
                new Item
                    (
                        name: "Electirizer",
                        identifier: "General items",
                        description: "A box packed with a tremendous amount of electric energy. It is loved by a certain Pokémon.",
                        id: 337
                        )
            },
            {
                85,
                new Item
                    (
                        name: "Electric Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of electricity. When held, it strengthens the power of an Electric-type move only once.",
                        id: 84
                        )
            },
            {
                86,
                new Item
                    (
                        name: "Elixir",
                        identifier: "Medicine",
                        description: "It restores the PP of all the moves learned by the targeted Pokémon by 10 points each.",
                        id: 194
                        )
            },
            {
                87,
                new Item
                    (
                        name: "Energy Root",
                        identifier: "Medicine",
                        description: "A very bitter root. It restores the HP of one POKÉMON by 200 points.",
                        id: 175
                        )
            },
            {
                88,
                new Item
                    (
                        name: "EnergyPowder",
                        identifier: "Medicine",
                        description: "A very bitter medicine powder. It restores the HP of one POKÉMON by 50 points.",
                        id: 174
                        )
            },
            {
                89,
                new Item
                    (
                        name: "Enigma Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it restores its HP if it is hit by any supereffective attack.",
                        id: 289
                        )
            },
            {
                90,
                new Item
                    (
                        name: "Escape Rope",
                        identifier: "General items",
                        description: "A long, durable rope. Use it to escape instantly from a cave or a dungeon.",
                        id: 359
                        )
            },
            {
                91,
                new Item
                    (
                        name: "Ether",
                        identifier: "Medicine",
                        description: "It restores the PP of a Pokémon's selected move by a maximum of 10 points.",
                        id: 192
                        )
            },
            {
                92,
                new Item
                    (
                        name: "Everstone",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. The Pokémon holding this peculiar stone is prevented from evolving.",
                        id: 113
                        )
            },
            {
                93,
                new Item
                    (
                        name: "Eviolite",
                        identifier: "Hold items",
                        description: "A mysterious evolutionary lump. When held, it raises the Defense and Sp. Def of a Pokémon that can still evolve.",
                        id: 33
                        )
            },
            {
                94,
                new Item
                    (
                        name: "Exp. Share",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. The holder gets a share of a battle's Exp. Points without battling.",
                        id: 109
                        )
            },
            {
                95,
                new Item
                    (
                        name: "Expert Belt",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a well-worn belt that slightly boosts the power of supereffective moves.",
                        id: 15
                        )
            },
            {
                96,
                new Item
                    (
                        name: "Fast Ball",
                        identifier: "Pokeballs",
                        description: "A Poké Ball that makes it easier to catch Pokémon which are quick to run away.",
                        id: 162
                        )
            },
            {
                97,
                new Item
                    (
                        name: "Fighting Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of combat. When held, it strengthens the power of a Fighting-type move only once.",
                        id: 87
                        )
            },
            {
                98,
                new Item
                    (
                        name: "Figy Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it restores the user's HP in a pinch, but will cause confusion if it hates the taste.",
                        id: 238
                        )
            },
            {
                99,
                new Item
                    (
                        name: "Fire Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of fire. When held, it strengthens the power of a Fire-type move only once.",
                        id: 82
                        )
            },
            {
                100,
                new Item
                    (
                        name: "Fire Stone",
                        identifier: "General items",
                        description: "A peculiar stone that makes certain species of POKÉMON evolve. It is colored orange.",
                        id: 326
                        )
            },
            {
                101,
                new Item
                    (
                        name: "Fist Plate",
                        identifier: "Hold items",
                        description: "Increases power of Fighting-type moves. Changes Arceus' type to Fighting.",
                        id: 71
                        )
            },
            {
                102,
                new Item
                    (
                        name: "Flame Orb",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a bizarre orb that inflicts a burn on the holder in battle.",
                        id: 118
                        )
            },
            {
                103,
                new Item
                    (
                        name: "Flame Plate",
                        identifier: "Hold items",
                        description: "Increases power of Fire-type moves. Changes Arceus' type to Fire.",
                        id: 66
                        )
            },
            {
                104,
                new Item
                    (
                        name: "Float Stone",
                        identifier: "Hold items",
                        description: "A very light stone. It reduces the weight of a Pokémon when held.",
                        id: 34
                        )
            },
            {
                105,
                new Item
                    (
                        name: "Fluffy Tail",
                        identifier: "General items",
                        description: "An item that attracts Pokémon. Use it to flee from any battle with a wild Pokémon.",
                        id: 354
                        )
            },
            {
                106,
                new Item
                    (
                        name: "Flying Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of air. When held, it strengthens the power of a Flying-type move only once.",
                        id: 90
                        )
            },
            {
                107,
                new Item
                    (
                        name: "Focus Band",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. The holder may endure a potential KO attack, leaving it with just 1 HP.",
                        id: 7
                        )
            },
            {
                108,
                new Item
                    (
                        name: "Focus Sash",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. If it has full HP, the holder will endure one potential KO attack, leaving 1 HP.",
                        id: 19
                        )
            },
            {
                109,
                new Item
                    (
                        name: "Fresh Water",
                        identifier: "Medicine",
                        description: "Water with a high mineral content. It restores the HP of one POKÉMON by 50 points.",
                        id: 170
                        )
            },
            {
                110,
                new Item
                    (
                        name: "Friend Ball",
                        identifier: "Pokeballs",
                        description: "A Poké Ball that makes caught Pokémon more friendly.",
                        id: 163
                        )
            },
            {
                111,
                new Item
                    (
                        name: "Full Heal",
                        identifier: "Medicine",
                        description: "A spray-type medicine. It heals all the status problems of a single Pokémon.",
                        id: 183
                        )
            },
            {
                112,
                new Item
                    (
                        name: "Full Incense",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is an exotic-smelling incense that makes the holder bloated and slow moving.",
                        id: 122
                        )
            },
            {
                113,
                new Item
                    (
                        name: "Full Restore",
                        identifier: "Medicine",
                        description: "A medicine that fully restores the HP and heals any status problems of a single Pokémon.",
                        id: 166
                        )
            },
            {
                114,
                new Item
                    (
                        name: "Ganlon Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it raises its Defense stat in a pinch.",
                        id: 281
                        )
            },
            {
                115,
                new Item
                    (
                        name: "Genius Wing",
                        identifier: "Medicine",
                        description: "An item for use on a Pokémon. It slightly increases the base Sp. Atk stat of a single Pokémon.",
                        id: 208
                        )
            },
            {
                116,
                new Item
                    (
                        name: "Ghost Gem",
                        identifier: "Hold items",
                        description: "A gem with a spectral essence. When held, it strengthens the power of a Ghost-type move only once.",
                        id: 94
                        )
            },
            {
                117,
                new Item
                    (
                        name: "Gooey Mulch",
                        identifier: "General items",
                        description: "A fertilizer to be spread on soft soil in regions where Berries are grown. A maniac will buy it for a high price.",
                        id: 399
                        )
            },
            {
                118,
                new Item
                    (
                        name: "Grass Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of nature. When held, it strengthens the power of a Grass-type move only once.",
                        id: 85
                        )
            },
            {
                119,
                new Item
                    (
                        name: "Great Ball",
                        identifier: "Pokeballs",
                        description: "A good, high-performance Ball that provides a higher Pokémon catch rate than a standard Poké Ball.",
                        id: 141
                        )
            },
            {
                120,
                new Item
                    (
                        name: "Green Scarf",
                        identifier: "General items",
                        description: "An item to be held by a Pokémon. It boosts the Smart aspect of the holder in a Contest.",
                        id: 403
                        )
            },
            {
                121,
                new Item
                    (
                        name: "Green Shard",
                        identifier: "General items",
                        description: "A small green shard. It appears to be from some sort of implement made long ago.",
                        id: 387
                        )
            },
            {
                122,
                new Item
                    (
                        name: "Grepa Berry",
                        identifier: "Berries",
                        description: "Using it on a Pokémon makes it more friendly, but it also lowers its base Sp. Def stat.",
                        id: 247
                        )
            },
            {
                123,
                new Item
                    (
                        name: "Grip Claw",
                        identifier: "Hold items",
                        description: "A Pokémon held item that extends the duration of multiturn attacks like Bind and Wrap.",
                        id: 28
                        )
            },
            {
                124,
                new Item
                    (
                        name: "Griseous Orb",
                        identifier: "Hold items",
                        description: "A glowing orb to be held by GIRATINA. It boosts the power of Dragon- and Ghost-type moves.",
                        id: 134
                        )
            },
            {
                125,
                new Item
                    (
                        name: "Grn Apricorn",
                        identifier: "General items",
                        description: "A green Apricorn. It has a mysterious, aromatic scent.",
                        id: 392
                        )
            },
            {
                126,
                new Item
                    (
                        name: "Ground Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of land. When held, it strengthens the power of a Ground-type move only once.",
                        id: 89
                        )
            },
            {
                127,
                new Item
                    (
                        name: "Growth Mulch",
                        identifier: "General items",
                        description: "A fertilizer to be spread on soft soil in regions where Berries are grown. A maniac will buy it for a high price.",
                        id: 396
                        )
            },
            {
                128,
                new Item
                    (
                        name: "Guard Spec.",
                        identifier: "Battle items",
                        description: "An item that prevents stat reduction among the Trainer's party Pokémon for five turns after use.",
                        id: 292
                        )
            },
            {
                129,
                new Item
                    (
                        name: "HM01",
                        identifier: "Machines",
                        description: "Teaches the move Cut.",
                        id: 211
                        )
            },
            {
                130,
                new Item
                    (
                        name: "HM02",
                        identifier: "Machines",
                        description: "Teaches the move Fly.",
                        id: 220
                        )
            },
            {
                131,
                new Item
                    (
                        name: "HM03",
                        identifier: "Machines",
                        description: "Teaches the move Surf.",
                        id: 213
                        )
            },
            {
                132,
                new Item
                    (
                        name: "HM04",
                        identifier: "Machines",
                        description: "Teaches the move Strength.",
                        id: 211
                        )
            },
            {
                133,
                new Item
                    (
                        name: "HM05",
                        identifier: "Machines",
                        description: "Teaches the move Flash/Defog/Whirlpool/Waterfall.",
                        id: 213
                        )
            },
            {
                134,
                new Item
                    (
                        name: "HM06",
                        identifier: "Machines",
                        description: "Teaches the move Whirlpool/Rock Smash/Dive.",
                        id: 213
                        )
            },
            {
                135,
                new Item
                    (
                        name: "HM07",
                        identifier: "Machines",
                        description: "Teaches the move Waterfall.",
                        id: 213
                        )
            },
            {
                136,
                new Item
                    (
                        name: "HM08",
                        identifier: "Machines",
                        description: "Teaches the move Dive/Rock Climb.",
                        id: 211
                        )
            },
            {
                137,
                new Item
                    (
                        name: "HP Up",
                        identifier: "Medicine",
                        description: "A nutritious drink for Pokémon. It raises the base HP of a single Pokémon.",
                        id: 196
                        )
            },
            {
                138,
                new Item
                    (
                        name: "Haban Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Dragon-type attack against the holding Pokémon.",
                        id: 276
                        )
            },
            {
                139,
                new Item
                    (
                        name: "Hard Stone",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is an unbreakable stone that ups the power of Rock-type moves.",
                        id: 47
                        )
            },
            {
                140,
                new Item
                    (
                        name: "Heal Ball",
                        identifier: "Pokeballs",
                        description: "A remedial Poké Ball that restores the caught Pokémon's HP and eliminates any status problem.",
                        id: 154
                        )
            },
            {
                141,
                new Item
                    (
                        name: "Heal Powder",
                        identifier: "Medicine",
                        description: "A very bitter medicine powder. It heals all the status problems of a single Pokémon.",
                        id: 184
                        )
            },
            {
                142,
                new Item
                    (
                        name: "Health Wing",
                        identifier: "Medicine",
                        description: "An item for use on a Pokémon. It slightly increases the base HP of a single Pokémon.",
                        id: 205
                        )
            },
            {
                143,
                new Item
                    (
                        name: "Heart Scale",
                        identifier: "General items",
                        description: "A pretty, heart-shaped scale that is extremely rare. It glows faintly in the colors of the rainbow.",
                        id: 388
                        )
            },
            {
                144,
                new Item
                    (
                        name: "Heat Rock",
                        identifier: "Hold items",
                        description: "A Pokémon held item that extends the duration of the move Sunny Day used by the holder.",
                        id: 26
                        )
            },
            {
                145,
                new Item
                    (
                        name: "Heavy Ball",
                        identifier: "Pokeballs",
                        description: "A Poké Ball for catching very heavy Pokémon.",
                        id: 161
                        )
            },
            {
                146,
                new Item
                    (
                        name: "Helix Fossil",
                        identifier: "General items",
                        description: "A fossil of an ancient Pokémon that lived in the sea. It appears to be part of a seashell.",
                        id: 345
                        )
            },
            {
                147,
                new Item
                    (
                        name: "Hondew Berry",
                        identifier: "Berries",
                        description: "Using it on a Pokémon makes it more friendly, but it also lowers its base Sp. Atk stat.",
                        id: 246
                        )
            },
            {
                148,
                new Item
                    (
                        name: "Honey",
                        identifier: "General items",
                        description: "A sweet honey with a lush aroma that attracts wild Pokémon when it is used in grass, caves, or on special trees.",
                        id: 342
                        )
            },
            {
                149,
                new Item
                    (
                        name: "Hyper Potion",
                        identifier: "Medicine",
                        description: "A spray-type medicine for wounds. It restores the HP of one Pokémon by 200 points.",
                        id: 168
                        )
            },
            {
                150,
                new Item
                    (
                        name: "Iapapa Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it restores the user's HP in a pinch, but will cause confusion if it hates the taste.",
                        id: 242
                        )
            },
            {
                151,
                new Item
                    (
                        name: "Ice Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of ice. When held, it strengthens the power of an Ice-type move only once.",
                        id: 86
                        )
            },
            {
                152,
                new Item
                    (
                        name: "Ice Heal",
                        identifier: "Medicine",
                        description: "A spray-type medicine. It defrosts a Pokémon that has been frozen solid.",
                        id: 180
                        )
            },
            {
                153,
                new Item
                    (
                        name: "Icicle Plate",
                        identifier: "Hold items",
                        description: "Increases power of Ice-type moves. Changes Arceus' type to Ice.",
                        id: 70
                        )
            },
            {
                154,
                new Item
                    (
                        name: "Icy Rock",
                        identifier: "Hold items",
                        description: "A Pokémon held item that extends the duration of the move Hail used by the holder.",
                        id: 24
                        )
            },
            {
                155,
                new Item
                    (
                        name: "Insect Plate",
                        identifier: "Hold items",
                        description: "Increases power of Bug-type moves. Changes Arceus' type to Bug.",
                        id: 76
                        )
            },
            {
                156,
                new Item
                    (
                        name: "Iron",
                        identifier: "Medicine",
                        description: "A nutritious drink for Pokémon. It raises the base Defense stat of a single Pokémon.",
                        id: 198
                        )
            },
            {
                157,
                new Item
                    (
                        name: "Iron Ball",
                        identifier: "Hold items",
                        description: "A Pokémon held item that cuts Speed. It makes Flying-type and levitating holders susceptible to Ground moves.",
                        id: 119
                        )
            },
            {
                158,
                new Item
                    (
                        name: "Iron Plate",
                        identifier: "Hold items",
                        description: "Increases power of Steel-type moves. Changes Arceus' type to Steel.",
                        id: 81
                        )
            },
            {
                159,
                new Item
                    (
                        name: "Item Drop",
                        identifier: "Battle items",
                        description: "When used, it causes an ally Pokémon to drop a held item.",
                        id: 320
                        )
            },
            {
                160,
                new Item
                    (
                        name: "Item Urge",
                        identifier: "Battle items",
                        description: "When used, it causes an ally Pokémon to use its held item.",
                        id: 321
                        )
            },
            {
                161,
                new Item
                    (
                        name: "Jaboca Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon and a physical attack lands, the attacker also takes damage.",
                        id: 290
                        )
            },
            {
                162,
                new Item
                    (
                        name: "Kasib Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Ghost-type attack against the holding Pokémon.",
                        id: 275
                        )
            },
            {
                163,
                new Item
                    (
                        name: "Kebia Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Poison-type attack against the holding Pokémon.",
                        id: 269
                        )
            },
            {
                164,
                new Item
                    (
                        name: "Kelpsy Berry",
                        identifier: "Berries",
                        description: "Using it on a Pokémon makes it more friendly, but it also lowers its base Attack stat.",
                        id: 244
                        )
            },
            {
                165,
                new Item
                    (
                        name: "King's Rock",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. When the holder inflicts damage, the target may flinch.",
                        id: 5
                        )
            },
            {
                166,
                new Item
                    (
                        name: "Lagging Tail",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is tremendously heavy and makes the holder move slower than usual.",
                        id: 120
                        )
            },
            {
                167,
                new Item
                    (
                        name: "Lansat Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it raises its critical-hit ratio in a pinch.",
                        id: 285
                        )
            },
            {
                168,
                new Item
                    (
                        name: "Lava Cookie",
                        identifier: "Medicine",
                        description: "LAVARIDGE TOWN's local specialty. It heals all the status problems of one POKÉMON.",
                        id: 185
                        )
            },
            {
                169,
                new Item
                    (
                        name: "Lax Incense",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. The tricky aroma of this incense may make attacks miss the holder.",
                        id: 11
                        )
            },
            {
                170,
                new Item
                    (
                        name: "Leaf Stone",
                        identifier: "General items",
                        description: "A peculiar stone that makes certain species of POKÉMON evolve. It has a leaf pattern.",
                        id: 329
                        )
            },
            {
                171,
                new Item
                    (
                        name: "Leftovers",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. The holder's HP is gradually restored during battle.",
                        id: 9
                        )
            },
            {
                172,
                new Item
                    (
                        name: "Lemonade",
                        identifier: "Medicine",
                        description: "A very sweet drink. It restores the HP of one POKÉMON by 80 points.",
                        id: 172
                        )
            },
            {
                173,
                new Item
                    (
                        name: "Leppa Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it restores a move's PP by 10.",
                        id: 233
                        )
            },
            {
                174,
                new Item
                    (
                        name: "Level Ball",
                        identifier: "Pokeballs",
                        description: "A Poké Ball for catching Pokémon that are a lower level than your own.",
                        id: 159
                        )
            },
            {
                175,
                new Item
                    (
                        name: "Liechi Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it raises its Attack stat in a pinch.",
                        id: 280
                        )
            },
            {
                176,
                new Item
                    (
                        name: "Life Orb",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It boosts the power of moves, but at the cost of some HP on each hit.",
                        id: 17
                        )
            },
            {
                177,
                new Item
                    (
                        name: "Light Ball",
                        identifier: "Hold items",
                        description: "An item to be held by PIKACHU. It is a puzzling orb that raises the Attack and Sp. Atk stat.",
                        id: 128
                        )
            },
            {
                178,
                new Item
                    (
                        name: "Light Clay",
                        identifier: "Hold items",
                        description: "A Pokémon held item that extends the duration of barrier moves like Light Screen and Reflect used by the holder.",
                        id: 16
                        )
            },
            {
                179,
                new Item
                    (
                        name: "Love Ball",
                        identifier: "Pokeballs",
                        description: "Poké Ball for catching Pokémon that are the opposite gender of your Pokémon.",
                        id: 164
                        )
            },
            {
                180,
                new Item
                    (
                        name: "Luck Incense",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It doubles a battle's prize money if the holding Pokémon joins in.",
                        id: 115
                        )
            },
            {
                181,
                new Item
                    (
                        name: "Lucky Egg",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is an egg filled with happiness that earns extra Exp. Points in battle.",
                        id: 114
                        )
            },
            {
                182,
                new Item
                    (
                        name: "Lucky Punch",
                        identifier: "Hold items",
                        description: "An item to be held by CHANSEY. It is a pair of gloves that boosts CHANSEY's critical-hit ratio.",
                        id: 129
                        )
            },
            {
                183,
                new Item
                    (
                        name: "Lum Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it recovers from any status problem.",
                        id: 236
                        )
            },
            {
                184,
                new Item
                    (
                        name: "Lure Ball",
                        identifier: "Pokeballs",
                        description: "A Poké Ball for catching Pokémon hooked by a Rod when fishing.",
                        id: 158
                        )
            },
            {
                185,
                new Item
                    (
                        name: "Lustrous Orb",
                        identifier: "Hold items",
                        description: "A beautifully glowing orb to be held by PALKIA. It boosts the power of Dragon-, and Water-type moves.",
                        id: 124
                        )
            },
            {
                186,
                new Item
                    (
                        name: "Luxury Ball",
                        identifier: "Pokeballs",
                        description: "A comfortable Poké Ball that makes a caught wild Pokémon quickly grow friendly.",
                        id: 151
                        )
            },
            {
                187,
                new Item
                    (
                        name: "Macho Brace",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a stiff and heavy brace that promotes strong growth but lowers Speed.",
                        id: 102
                        )
            },
            {
                188,
                new Item
                    (
                        name: "Magmarizer",
                        identifier: "General items",
                        description: "A box packed with a tremendous amount of magma energy. It is loved by a certain Pokémon.",
                        id: 338
                        )
            },
            {
                189,
                new Item
                    (
                        name: "Magnet",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a powerful magnet that boosts the power of Electric-type moves.",
                        id: 51
                        )
            },
            {
                190,
                new Item
                    (
                        name: "Mago Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it restores the user's HP in a pinch, but will cause confusion if it hates the taste.",
                        id: 240
                        )
            },
            {
                191,
                new Item
                    (
                        name: "Magost Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 255
                        )
            },
            {
                192,
                new Item
                    (
                        name: "Master Ball",
                        identifier: "Pokeballs",
                        description: "The best Ball with the ultimate level of performance. It will catch any wild Pokémon without fail.",
                        id: 139
                        )
            },
            {
                193,
                new Item
                    (
                        name: "Max Elixir",
                        identifier: "Medicine",
                        description: "It fully restores the PP of all the moves learned by the targeted Pokémon.",
                        id: 195
                        )
            },
            {
                194,
                new Item
                    (
                        name: "Max Ether",
                        identifier: "Medicine",
                        description: "It fully restores the PP of a single selected move that has been learned by the target Pokémon.",
                        id: 193
                        )
            },
            {
                195,
                new Item
                    (
                        name: "Max Potion",
                        identifier: "Medicine",
                        description: "A spray-type medicine for wounds. It completely restores the HP of a single Pokémon.",
                        id: 167
                        )
            },
            {
                196,
                new Item
                    (
                        name: "Max Repel",
                        identifier: "General items",
                        description: "An item that prevents weak wild Pokémon from appearing for 250 steps after its use.",
                        id: 358
                        )
            },
            {
                197,
                new Item
                    (
                        name: "Max Revive",
                        identifier: "Medicine",
                        description: "A medicine that revives a fainted Pokémon. It fully restores the Pokémon's HP.",
                        id: 189
                        )
            },
            {
                198,
                new Item
                    (
                        name: "Meadow Plate",
                        identifier: "Hold items",
                        description: "Increases power of Grass-type moves. Changes Arceus' type to Grass.",
                        id: 69
                        )
            },
            {
                199,
                new Item
                    (
                        name: "Mental Herb",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It snaps the holder out of infatuation. It can be used only once.",
                        id: 4
                        )
            },
            {
                200,
                new Item
                    (
                        name: "Metal Coat",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a special metallic film that ups the power of Steel-type moves.",
                        id: 45
                        )
            },
            {
                201,
                new Item
                    (
                        name: "Metal Powder",
                        identifier: "Hold items",
                        description: "An item to be held by DITTO. Extremely fine yet hard, this odd powder boosts the Defense stat.",
                        id: 130
                        )
            },
            {
                202,
                new Item
                    (
                        name: "Metronome",
                        identifier: "Hold items",
                        description: "A Pokémon held item that boosts a move used consecutively. Its effect is reset if another move is used.",
                        id: 21
                        )
            },
            {
                203,
                new Item
                    (
                        name: "Micle Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it raises the accuracy of a move just once in a pinch.",
                        id: 287
                        )
            },
            {
                204,
                new Item
                    (
                        name: "Mind Plate",
                        identifier: "Hold items",
                        description: "Increases power of Psychic-type moves. Changes Arceus' type to Psychic.",
                        id: 75
                        )
            },
            {
                205,
                new Item
                    (
                        name: "Miracle Seed",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a seed imbued with life that ups the power of Grass-type moves.",
                        id: 48
                        )
            },
            {
                206,
                new Item
                    (
                        name: "Moomoo Milk",
                        identifier: "Medicine",
                        description: "Milk with a very high nutrition content. It restores the HP of one Pokémon by 100 points.",
                        id: 173
                        )
            },
            {
                207,
                new Item
                    (
                        name: "Moon Ball",
                        identifier: "Pokeballs",
                        description: "A Poké Ball for catching Pokémon that evolve using the Moon Stone.",
                        id: 160
                        )
            },
            {
                208,
                new Item
                    (
                        name: "Moon Stone",
                        identifier: "General items",
                        description: "A peculiar stone that makes certain species of POKÉMON evolve. It is as black as the night sky.",
                        id: 325
                        )
            },
            {
                209,
                new Item
                    (
                        name: "Muscle Band",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a headband that slightly boosts the power of physical moves.",
                        id: 13
                        )
            },
            {
                210,
                new Item
                    (
                        name: "Muscle Wing",
                        identifier: "Medicine",
                        description: "An item for use on a Pokémon. It slightly increases the base Attack stat of a single Pokémon.",
                        id: 206
                        )
            },
            {
                211,
                new Item
                    (
                        name: "Mystic Water",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a teardrop-shaped gem that ups the power of Water-type moves.",
                        id: 52
                        )
            },
            {
                212,
                new Item
                    (
                        name: "Nanab Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 251
                        )
            },
            {
                213,
                new Item
                    (
                        name: "Nest Ball",
                        identifier: "Pokeballs",
                        description: "A somewhat different Poké Ball that works especially well on weaker Pokémon in the wild.",
                        id: 148
                        )
            },
            {
                214,
                new Item
                    (
                        name: "Net Ball",
                        identifier: "Pokeballs",
                        description: "A somewhat different Poké Ball that works especially well on Water- and Bug-type Pokémon.",
                        id: 146
                        )
            },
            {
                215,
                new Item
                    (
                        name: "NeverMeltIce",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a piece of ice that repels heat and boosts Ice-type moves.",
                        id: 55
                        )
            },
            {
                216,
                new Item
                    (
                        name: "Nomel Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 257
                        )
            },
            {
                217,
                new Item
                    (
                        name: "Normal Gem",
                        identifier: "Hold items",
                        description: "A gem with an ordinary essence. When held, it strengthens the power of a Normal-type move only once.",
                        id: 98
                        )
            },
            {
                218,
                new Item
                    (
                        name: "Nugget",
                        identifier: "General items",
                        description: "A nugget of pure gold that gives off a lustrous gleam. It can be sold at a high price to shops.",
                        id: 368
                        )
            },
            {
                219,
                new Item
                    (
                        name: "Occa Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Fire-type attack against the holding Pokémon.",
                        id: 263
                        )
            },
            {
                220,
                new Item
                    (
                        name: "Odd Incense",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is an exotic-smelling incense that boosts the power of Psychic-type moves.",
                        id: 62
                        )
            },
            {
                221,
                new Item
                    (
                        name: "Odd Keystone",
                        identifier: "General items",
                        description: "A vital item that is needed to keep a stone tower from collapsing. Voices can be heard from it occasionally.",
                        id: 350
                        )
            },
            {
                222,
                new Item
                    (
                        name: "Old Amber",
                        identifier: "General items",
                        description: "A piece of amber that contains the genetic material of an ancient Pokémon. It is clear with a reddish tint.",
                        id: 347
                        )
            },
            {
                223,
                new Item
                    (
                        name: "Old Gateau",
                        identifier: "Medicine",
                        description: "Old Chateau's hidden specialty. It heals all the status problems of a single Pokémon.",
                        id: 186
                        )
            },
            {
                224,
                new Item
                    (
                        name: "Oran Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it heals the user by just 10 HP.",
                        id: 234
                        )
            },
            {
                225,
                new Item
                    (
                        name: "Oval Stone",
                        identifier: "General items",
                        description: "A peculiar stone that makes certain species of Pokémon evolve. It is shaped like an egg.",
                        id: 333
                        )
            },
            {
                226,
                new Item
                    (
                        name: "PP Max",
                        identifier: "Medicine",
                        description: "It maximally raises the top PP of a selected move that has been learned by the target Pokémon.",
                        id: 204
                        )
            },
            {
                227,
                new Item
                    (
                        name: "PP Up",
                        identifier: "Medicine",
                        description: "It slightly raises the maximum PP of a selected move that has been learned by the target Pokémon.",
                        id: 202
                        )
            },
            {
                228,
                new Item
                    (
                        name: "Pamtre Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 259
                        )
            },
            {
                229,
                new Item
                    (
                        name: "Park Ball",
                        identifier: "Pokeballs",
                        description: "A special Poké Ball for the Pal Park.",
                        id: 144
                        )
            },
            {
                230,
                new Item
                    (
                        name: "Parlyz Heal",
                        identifier: "Medicine",
                        description: "A spray-type medicine. It eliminates paralysis from a single Pokémon.",
                        id: 182
                        )
            },
            {
                231,
                new Item
                    (
                        name: "Pass Orb",
                        identifier: "Hold items",
                        description: "A mysterious orb containing the power of the Unova region, to be used when generating Pass Power.",
                        id: 43
                        )
            },
            {
                232,
                new Item
                    (
                        name: "Passho Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Water-type attack against the holding Pokémon.",
                        id: 264
                        )
            },
            {
                233,
                new Item
                    (
                        name: "Payapa Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Psychic-type attack against the holding Pokémon.",
                        id: 272
                        )
            },
            {
                234,
                new Item
                    (
                        name: "Pearl",
                        identifier: "General items",
                        description: "A somewhat-small pearl that sparkles in a pretty silver color. It can be sold cheaply to shops.",
                        id: 364
                        )
            },
            {
                235,
                new Item
                    (
                        name: "Pearl String",
                        identifier: "General items",
                        description: "Very large pearls that sparkle in a pretty silver color. A maniac will buy them for a high price.",
                        id: 373
                        )
            },
            {
                236,
                new Item
                    (
                        name: "Pecha Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it recovers from poison.",
                        id: 230
                        )
            },
            {
                237,
                new Item
                    (
                        name: "Persim Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it recovers from confusion.",
                        id: 235
                        )
            },
            {
                238,
                new Item
                    (
                        name: "Petaya Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it raises its Sp. Atk stat in a pinch.",
                        id: 283
                        )
            },
            {
                239,
                new Item
                    (
                        name: "Pinap Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 253
                        )
            },
            {
                240,
                new Item
                    (
                        name: "Pink Scarf",
                        identifier: "General items",
                        description: "An item to be held by a Pokémon. It boosts the Cute aspect of the holder in a Contest.",
                        id: 402
                        )
            },
            {
                241,
                new Item
                    (
                        name: "Plume Fossil",
                        identifier: "General items",
                        description: "A fossil of an ancient Pokémon that flew in the sky in ancient times. It appears to be part of its wing.",
                        id: 352
                        )
            },
            {
                242,
                new Item
                    (
                        name: "Pnk Apricorn",
                        identifier: "General items",
                        description: "A pink Apricorn. It has a nice, sweet scent.",
                        id: 393
                        )
            },
            {
                243,
                new Item
                    (
                        name: "Poison Barb",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a small, poisonous barb that ups the power of Poison-type moves.",
                        id: 54
                        )
            },
            {
                244,
                new Item
                    (
                        name: "Poison Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of poison. When held, it strengthens the power of a Poison-type move only once.",
                        id: 88
                        )
            },
            {
                245,
                new Item
                    (
                        name: "Poké Ball",
                        identifier: "Pokeballs",
                        description: "A device for catching wild Pokémon. It is thrown like a ball at the target. It is designed as a capsule system.",
                        id: 142
                        )
            },
            {
                246,
                new Item
                    (
                        name: "Poké Doll",
                        identifier: "General items",
                        description: "A doll that attracts Pokémon. Use it to flee from any battle with a wild Pokémon.",
                        id: 353
                        )
            },
            {
                247,
                new Item
                    (
                        name: "Poké Toy",
                        identifier: "General items",
                        description: "An item that attracts Pokémon. Use it to flee from any battle with a wild Pokémon.",
                        id: 361
                        )
            },
            {
                248,
                new Item
                    (
                        name: "Pomeg Berry",
                        identifier: "Berries",
                        description: "Using it on a Pokémon makes it more friendly, but it also lowers its base HP.",
                        id: 243
                        )
            },
            {
                249,
                new Item
                    (
                        name: "Potion",
                        identifier: "Medicine",
                        description: "A spray-type medicine for wounds. It restores the HP of one Pokémon by just 20 points.",
                        id: 165
                        )
            },
            {
                250,
                new Item
                    (
                        name: "Power Anklet",
                        identifier: "Hold items",
                        description: "A Pokémon held item that promotes Speed gain on leveling, but reduces the Speed stat.",
                        id: 107
                        )
            },
            {
                251,
                new Item
                    (
                        name: "Power Band",
                        identifier: "Hold items",
                        description: "A Pokémon held item that promotes Sp. Def gain on leveling, but reduces the Speed stat.",
                        id: 106
                        )
            },
            {
                252,
                new Item
                    (
                        name: "Power Belt",
                        identifier: "Hold items",
                        description: "A Pokémon held item that promotes Defense gain on leveling, but reduces the Speed stat.",
                        id: 104
                        )
            },
            {
                253,
                new Item
                    (
                        name: "Power Bracer",
                        identifier: "Hold items",
                        description: "A Pokémon held item that promotes Attack gain on leveling, but reduces the Speed stat.",
                        id: 103
                        )
            },
            {
                254,
                new Item
                    (
                        name: "Power Herb",
                        identifier: "Hold items",
                        description: "A single-use item to be held by a Pokémon. It allows the immediate use of a move that charges on the first turn.",
                        id: 18
                        )
            },
            {
                255,
                new Item
                    (
                        name: "Power Lens",
                        identifier: "Hold items",
                        description: "A Pokémon held item that promotes Sp. Atk gain on leveling, but reduces the Speed stat.",
                        id: 105
                        )
            },
            {
                256,
                new Item
                    (
                        name: "Power Weight",
                        identifier: "Hold items",
                        description: "A Pokémon held item that promotes HP gain on leveling, but reduces the Speed stat.",
                        id: 108
                        )
            },
            {
                257,
                new Item
                    (
                        name: "Premier Ball",
                        identifier: "Pokeballs",
                        description: "A somewhat rare Poké Ball that has been specially made to commemorate an event of some sort.",
                        id: 152
                        )
            },
            {
                258,
                new Item
                    (
                        name: "Pretty Wing",
                        identifier: "General items",
                        description: "Though this feather is beautiful, it's just a regular feather and has no effect on Pokémon.",
                        id: 370
                        )
            },
            {
                259,
                new Item
                    (
                        name: "Prism Scale",
                        identifier: "General items",
                        description: "A mysterious scale that evolves certain Pokémon. It shines in rainbow colors.",
                        id: 341
                        )
            },
            {
                260,
                new Item
                    (
                        name: "Protector",
                        identifier: "General items",
                        description: "A protective item of some sort. It is extremely stiff and heavy. It is loved by a certain Pokémon.",
                        id: 336
                        )
            },
            {
                261,
                new Item
                    (
                        name: "Protein",
                        identifier: "Medicine",
                        description: "A nutritious drink for Pokémon. It raises the base Attack stat of a single Pokémon.",
                        id: 197
                        )
            },
            {
                262,
                new Item
                    (
                        name: "Psychic Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of the mind. When held, it strengthens the power of a Psychic-type move only once.",
                        id: 91
                        )
            },
            {
                263,
                new Item
                    (
                        name: "Pure Incense",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It helps keep wild Pokémon away if the holder is the first one in the party.",
                        id: 116
                        )
            },
            {
                264,
                new Item
                    (
                        name: "Qualot Berry",
                        identifier: "Berries",
                        description: "Using it on a Pokémon makes it more friendly, but it also lowers its base Defense stat.",
                        id: 245
                        )
            },
            {
                265,
                new Item
                    (
                        name: "Quick Ball",
                        identifier: "Pokeballs",
                        description: "A somewhat different Poké Ball that provides a better catch rate if it is used at the start of a wild encounter.",
                        id: 155
                        )
            },
            {
                266,
                new Item
                    (
                        name: "Quick Claw",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. A light, sharp claw that lets the bearer move first occasionally.",
                        id: 3
                        )
            },
            {
                267,
                new Item
                    (
                        name: "Quick Powder",
                        identifier: "Hold items",
                        description: "An item to be held by DITTO. Extremely fine yet hard, this odd powder boosts the Speed stat.",
                        id: 133
                        )
            },
            {
                268,
                new Item
                    (
                        name: "Rabuta Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 256
                        )
            },
            {
                269,
                new Item
                    (
                        name: "Rare Bone",
                        identifier: "General items",
                        description: "A bone that is extremely valuable for Pokémon archeology. It can be sold for a high price to shops.",
                        id: 369
                        )
            },
            {
                270,
                new Item
                    (
                        name: "Rare Candy",
                        identifier: "Medicine",
                        description: "A candy that is packed with energy. It raises the level of a single Pokémon by one.",
                        id: 201
                        )
            },
            {
                271,
                new Item
                    (
                        name: "Rawst Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it recovers from a burn.",
                        id: 231
                        )
            },
            {
                272,
                new Item
                    (
                        name: "Razor Claw",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a sharply hooked claw that ups the holder's critical-hit ratio.",
                        id: 31
                        )
            },
            {
                273,
                new Item
                    (
                        name: "Razor Fang",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It may make foes and allies flinch when the holder inflicts damage.",
                        id: 32
                        )
            },
            {
                274,
                new Item
                    (
                        name: "Razz Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 249
                        )
            },
            {
                275,
                new Item
                    (
                        name: "Reaper Cloth",
                        identifier: "General items",
                        description: "A cloth imbued with horrifyingly strong spiritual energy. It is loved by a certain Pokémon.",
                        id: 340
                        )
            },
            {
                276,
                new Item
                    (
                        name: "Red Apricorn",
                        identifier: "General items",
                        description: "A red Apricorn. It assails your nostrils.",
                        id: 389
                        )
            },
            {
                277,
                new Item
                    (
                        name: "Red Card",
                        identifier: "Hold items",
                        description: "A card with a mysterious power. When the holder is struck by a foe, the attacker is removed from battle.",
                        id: 37
                        )
            },
            {
                278,
                new Item
                    (
                        name: "Red Flute",
                        identifier: "General items",
                        description: "A toy flute made from red glass. A maniac will buy it for a high price.",
                        id: 407
                        )
            },
            {
                279,
                new Item
                    (
                        name: "Red Scarf",
                        identifier: "General items",
                        description: "An item to be held by a Pokémon. It boosts the Cool aspect of the holder in a Contest.",
                        id: 400
                        )
            },
            {
                280,
                new Item
                    (
                        name: "Red Shard",
                        identifier: "General items",
                        description: "A small red shard. It appears to be from some sort of implement made long ago.",
                        id: 384
                        )
            },
            {
                281,
                new Item
                    (
                        name: "Relic Band",
                        identifier: "General items",
                        description: "A bracelet made in a civilization about 3,000 years ago. A maniac will buy it for a high price.",
                        id: 379
                        )
            },
            {
                282,
                new Item
                    (
                        name: "Relic Copper",
                        identifier: "General items",
                        description: "A copper coin used in a civilization about 3,000 years ago. A maniac will buy it for a high price.",
                        id: 375
                        )
            },
            {
                283,
                new Item
                    (
                        name: "Relic Crown",
                        identifier: "General items",
                        description: "A crown made in a civilization about 3,000 years ago. A maniac will buy it for a high price.",
                        id: 381
                        )
            },
            {
                284,
                new Item
                    (
                        name: "Relic Gold",
                        identifier: "General items",
                        description: "A gold coin used in a civilization about 3,000 years ago. A maniac will buy it for a high price.",
                        id: 377
                        )
            },
            {
                285,
                new Item
                    (
                        name: "Relic Silver",
                        identifier: "General items",
                        description: "A silver coin used in a civilization about 3,000 years ago. A maniac will buy it for a high price.",
                        id: 376
                        )
            },
            {
                286,
                new Item
                    (
                        name: "Relic Statue",
                        identifier: "General items",
                        description: "A stone figure made in a civilization about 3,000 years ago. A maniac will buy it for a high price.",
                        id: 380
                        )
            },
            {
                287,
                new Item
                    (
                        name: "Relic Vase",
                        identifier: "General items",
                        description: "A vase made in a civilization about 3,000 years ago. A maniac will buy it for a high price.",
                        id: 378
                        )
            },
            {
                288,
                new Item
                    (
                        name: "Repeat Ball",
                        identifier: "Pokeballs",
                        description: "A somewhat different Poké Ball that works especially well on Pokémon species that were previously caught.",
                        id: 149
                        )
            },
            {
                289,
                new Item
                    (
                        name: "Repel",
                        identifier: "General items",
                        description: "An item that prevents weak wild Pokémon from appearing for 100 steps after its use.",
                        id: 360
                        )
            },
            {
                290,
                new Item
                    (
                        name: "Reset Urge",
                        identifier: "Battle items",
                        description: "When used, it restores any stat changes of an ally Pokémon.",
                        id: 322
                        )
            },
            {
                291,
                new Item
                    (
                        name: "Resist Wing",
                        identifier: "Medicine",
                        description: "An item for use on a Pokémon. It slightly increases the base Defense stat of a single Pokémon.",
                        id: 207
                        )
            },
            {
                292,
                new Item
                    (
                        name: "Revival Herb",
                        identifier: "Medicine",
                        description: "A very bitter medicinal herb. It revives a fainted Pokémon, fully restoring its HP.",
                        id: 190
                        )
            },
            {
                293,
                new Item
                    (
                        name: "Revive",
                        identifier: "Medicine",
                        description: "A medicine that revives a fainted Pokémon. It restores half the Pokémon's maximum HP.",
                        id: 188
                        )
            },
            {
                294,
                new Item
                    (
                        name: "Rindo Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Grass-type attack against the holding Pokémon.",
                        id: 266
                        )
            },
            {
                295,
                new Item
                    (
                        name: "Ring Target",
                        identifier: "Hold items",
                        description: "Moves that would otherwise have no effect will land on the Pokémon that holds it.",
                        id: 38
                        )
            },
            {
                296,
                new Item
                    (
                        name: "Rock Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of rock. When held, it strengthens the power of a Rock-type move only once.",
                        id: 93
                        )
            },
            {
                297,
                new Item
                    (
                        name: "Rock Incense",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is an exotic-smelling incense that boosts the power of Rock-type moves.",
                        id: 63
                        )
            },
            {
                298,
                new Item
                    (
                        name: "Rocky Helmet",
                        identifier: "Hold items",
                        description: "If the holder of this item takes damage, the attacker will also be damaged upon contact.",
                        id: 35
                        )
            },
            {
                299,
                new Item
                    (
                        name: "Root Fossil",
                        identifier: "General items",
                        description: "A fossil of an ancient Pokémon that lived in the sea. It appears to be part of a plant root.",
                        id: 343
                        )
            },
            {
                300,
                new Item
                    (
                        name: "Rose Incense",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is an exotic-smelling incense that boosts the power of Grass-type moves.",
                        id: 65
                        )
            },
            {
                301,
                new Item
                    (
                        name: "Rowap Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon and a special attack lands, the attacker also takes damage.",
                        id: 291
                        )
            },
            {
                302,
                new Item
                    (
                        name: "Sacred Ash",
                        identifier: "Medicine",
                        description: "It revives all fainted Pokémon. In doing so, it also fully restores their HP.",
                        id: 191
                        )
            },
            {
                303,
                new Item
                    (
                        name: "Safari Ball",
                        identifier: "Pokeballs",
                        description: "A special Poké Ball that is used only in the Great Marsh. It is decorated in a camouflage pattern.",
                        id: 143
                        )
            },
            {
                304,
                new Item
                    (
                        name: "Salac Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it raises its Speed stat in a pinch.",
                        id: 282
                        )
            },
            {
                305,
                new Item
                    (
                        name: "Scope Lens",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a lens that boosts the holder's critical-hit ratio.",
                        id: 8
                        )
            },
            {
                306,
                new Item
                    (
                        name: "Sea Incense",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is incense with a curious aroma that boosts the power of Water-type moves.",
                        id: 61
                        )
            },
            {
                307,
                new Item
                    (
                        name: "Sharp Beak",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a long, sharp beak that boosts the power of Flying-type moves.",
                        id: 53
                        )
            },
            {
                308,
                new Item
                    (
                        name: "Shed Shell",
                        identifier: "Hold items",
                        description: "A tough, discarded carapace to be held by a Pokémon. It enables the holder to switch with a waiting Pokémon in battle.",
                        id: 29
                        )
            },
            {
                309,
                new Item
                    (
                        name: "Shell Bell",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. The holder's HP is restored a little every time it inflicts damage.",
                        id: 10
                        )
            },
            {
                310,
                new Item
                    (
                        name: "Shiny Stone",
                        identifier: "General items",
                        description: "A peculiar stone that makes certain species of Pokémon evolve. It shines with a dazzling light.",
                        id: 330
                        )
            },
            {
                311,
                new Item
                    (
                        name: "Shoal Salt",
                        identifier: "General items",
                        description: "Pure salt that can be discovered deep inside the Shoal Cave. A maniac will buy it for a high price.",
                        id: 382
                        )
            },
            {
                312,
                new Item
                    (
                        name: "Shoal Shell",
                        identifier: "General items",
                        description: "A pretty seashell that can be found deep inside the Shoal Cave. A maniac will buy it for a high price.",
                        id: 383
                        )
            },
            {
                313,
                new Item
                    (
                        name: "Shock Drive",
                        identifier: "Hold items",
                        description: "A cassette to be held by Genesect. It changes Techno Blast to an Electric-type move.",
                        id: 136
                        )
            },
            {
                314,
                new Item
                    (
                        name: "Shuca Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Ground-type attack against the holding Pokémon.",
                        id: 270
                        )
            },
            {
                315,
                new Item
                    (
                        name: "Silk Scarf",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a sumptuous scarf that boosts the power of Normal-type moves.",
                        id: 60
                        )
            },
            {
                316,
                new Item
                    (
                        name: "SilverPowder",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a shiny, silver powder that ups the power of Bug-type moves.",
                        id: 44
                        )
            },
            {
                317,
                new Item
                    (
                        name: "Sitrus Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it heals the user's HP a little.",
                        id: 237
                        )
            },
            {
                318,
                new Item
                    (
                        name: "Skull Fossil",
                        identifier: "General items",
                        description: "A fossil from a prehistoric Pokémon that lived on the land. It appears to be part of a head.",
                        id: 349
                        )
            },
            {
                319,
                new Item
                    (
                        name: "Sky Plate",
                        identifier: "Hold items",
                        description: "Increases power of Flying-type moves. Changes Arceus' type to Flying.",
                        id: 74
                        )
            },
            {
                320,
                new Item
                    (
                        name: "Smoke Ball",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It enables the holder to flee from any wild Pokémon without fail.",
                        id: 6
                        )
            },
            {
                321,
                new Item
                    (
                        name: "Smooth Rock",
                        identifier: "Hold items",
                        description: "A Pokémon held item that extends the duration of the move Sandstorm used by the holder.",
                        id: 25
                        )
            },
            {
                322,
                new Item
                    (
                        name: "Soda Pop",
                        identifier: "Medicine",
                        description: "A fizzy soda drink. It restores the HP of one POKÉMON by 60 points.",
                        id: 171
                        )
            },
            {
                323,
                new Item
                    (
                        name: "Soft Sand",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a loose, silky sand that boosts the power of Ground-type moves.",
                        id: 46
                        )
            },
            {
                324,
                new Item
                    (
                        name: "Soothe Bell",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a bell with a comforting chime that calms the holder and makes it friendly.",
                        id: 110
                        )
            },
            {
                325,
                new Item
                    (
                        name: "Soul Dew",
                        identifier: "Hold items",
                        description: "A wondrous orb to be held by LATIOS or LATIAS. It raises both the Sp. Atk and Sp. Def stats.",
                        id: 125
                        )
            },
            {
                326,
                new Item
                    (
                        name: "Spell Tag",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a sinister, eerie tag that boosts the power of Ghost-type moves.",
                        id: 56
                        )
            },
            {
                327,
                new Item
                    (
                        name: "Spelon Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 258
                        )
            },
            {
                328,
                new Item
                    (
                        name: "Splash Plate",
                        identifier: "Hold items",
                        description: "Increases power of Water-type moves. Changes Arceus' type to Water.",
                        id: 67
                        )
            },
            {
                329,
                new Item
                    (
                        name: "Spooky Plate",
                        identifier: "Hold items",
                        description: "Increases power of Ghost-type moves. Changes Arceus' type to Ghost.",
                        id: 78
                        )
            },
            {
                330,
                new Item
                    (
                        name: "Sport Ball",
                        identifier: "Pokeballs",
                        description: "A special Poké Ball for the Bug-Catching Contest.",
                        id: 145
                        )
            },
            {
                331,
                new Item
                    (
                        name: "Stable Mulch",
                        identifier: "General items",
                        description: "A fertilizer to be spread on soft soil in regions where Berries are grown. A maniac will buy it for a high price.",
                        id: 398
                        )
            },
            {
                332,
                new Item
                    (
                        name: "Star Piece",
                        identifier: "General items",
                        description: "A shard of a pretty gem that sparkles in a red color. It can be sold at a high price to shops.",
                        id: 367
                        )
            },
            {
                333,
                new Item
                    (
                        name: "Stardust",
                        identifier: "General items",
                        description: "Lovely, red-colored sand with a loose, silky feel. It can be sold at a high price to shops.",
                        id: 366
                        )
            },
            {
                334,
                new Item
                    (
                        name: "Starf Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it sharply raises one of its stats in a pinch.",
                        id: 286
                        )
            },
            {
                335,
                new Item
                    (
                        name: "Steel Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of steel. When held, it strengthens the power of a Steel-type move only once.",
                        id: 96
                        )
            },
            {
                336,
                new Item
                    (
                        name: "Stick",
                        identifier: "Hold items",
                        description: "An item to be held by FARFETCH'D. It is a very long and stiff stalk of leek that boosts the critical-hit ratio.",
                        id: 132
                        )
            },
            {
                337,
                new Item
                    (
                        name: "Sticky Barb",
                        identifier: "Hold items",
                        description: "A held item that damages the holder on every turn. It may latch on to foes and allies that touch the holder.",
                        id: 121
                        )
            },
            {
                338,
                new Item
                    (
                        name: "Stone Plate",
                        identifier: "Hold items",
                        description: "Increases power of Rock-type moves. Changes Arceus' type to Rock.",
                        id: 77
                        )
            },
            {
                339,
                new Item
                    (
                        name: "Sun Stone",
                        identifier: "General items",
                        description: "A peculiar stone that makes certain species of POKÉMON evolve. It is as red as the sun.",
                        id: 324
                        )
            },
            {
                340,
                new Item
                    (
                        name: "Super Potion",
                        identifier: "Medicine",
                        description: "A spray-type medicine for wounds. It restores the HP of one Pokémon by 50 points.",
                        id: 169
                        )
            },
            {
                341,
                new Item
                    (
                        name: "Super Repel",
                        identifier: "General items",
                        description: "An item that prevents weak wild Pokémon from appearing for 200 steps after its use.",
                        id: 357
                        )
            },
            {
                342,
                new Item
                    (
                        name: "Sweet Heart",
                        identifier: "Medicine",
                        description: "Very sweet chocolate. It restores the HP of one Pokémon by only 20 points.",
                        id: 177
                        )
            },
            {
                343,
                new Item
                    (
                        name: "Swift Wing",
                        identifier: "Medicine",
                        description: "An item for use on a Pokémon. It slightly increases the base Speed stat of a single Pokémon.",
                        id: 210
                        )
            },
            {
                344,
                new Item
                    (
                        name: "TM01",
                        identifier: "Machines",
                        description: "Teaches the move Mega Punch/DynamicPunch/Focus Punch/Hone Claws.",
                        id: 226
                        )
            },
            {
                345,
                new Item
                    (
                        name: "TM02",
                        identifier: "Machines",
                        description: "Teaches the move Razor Wind/Headbutt/Dragon Claw.",
                        id: 225
                        )
            },
            {
                346,
                new Item
                    (
                        name: "TM03",
                        identifier: "Machines",
                        description: "Teaches the move Swords Dance/Curse/Water Pulse/Psyshock.",
                        id: 221
                        )
            },
            {
                347,
                new Item
                    (
                        name: "TM04",
                        identifier: "Machines",
                        description: "Teaches the move Whirlwind/Rollout/Calm Mind.",
                        id: 221
                        )
            },
            {
                348,
                new Item
                    (
                        name: "TM05",
                        identifier: "Machines",
                        description: "Teaches the move Mega Kick/Roar.",
                        id: 211
                        )
            },
            {
                349,
                new Item
                    (
                        name: "TM06",
                        identifier: "Machines",
                        description: "Teaches the move Toxic.",
                        id: 218
                        )
            },
            {
                350,
                new Item
                    (
                        name: "TM07",
                        identifier: "Machines",
                        description: "Teaches the move Horn Drill/Zap Cannon/Hail.",
                        id: 216
                        )
            },
            {
                351,
                new Item
                    (
                        name: "TM08",
                        identifier: "Machines",
                        description: "Teaches the move Body Slam/Rock Smash/Bulk Up.",
                        id: 217
                        )
            },
            {
                352,
                new Item
                    (
                        name: "TM09",
                        identifier: "Machines",
                        description: "Teaches the move Take Down/Psych Up/Bullet Seed/Venoshock.",
                        id: 218
                        )
            },
            {
                353,
                new Item
                    (
                        name: "TM10",
                        identifier: "Machines",
                        description: "Teaches the move Double-Edge/Hidden Power.",
                        id: 211
                        )
            },
            {
                354,
                new Item
                    (
                        name: "TM11",
                        identifier: "Machines",
                        description: "Teaches the move BubbleBeam/Sunny Day.",
                        id: 212
                        )
            },
            {
                355,
                new Item
                    (
                        name: "TM12",
                        identifier: "Machines",
                        description: "Teaches the move Water Gun/Sweet Scent/Taunt.",
                        id: 226
                        )
            },
            {
                356,
                new Item
                    (
                        name: "TM13",
                        identifier: "Machines",
                        description: "Teaches the move Snore/Ice Beam.",
                        id: 216
                        )
            },
            {
                357,
                new Item
                    (
                        name: "TM14",
                        identifier: "Machines",
                        description: "Teaches the move Blizzard.",
                        id: 216
                        )
            },
            {
                358,
                new Item
                    (
                        name: "TM15",
                        identifier: "Machines",
                        description: "Teaches the move Hyper Beam.",
                        id: 211
                        )
            },
            {
                359,
                new Item
                    (
                        name: "TM16",
                        identifier: "Machines",
                        description: "Teaches the move Pay Day/Icy Wind/Light Screen.",
                        id: 221
                        )
            },
            {
                360,
                new Item
                    (
                        name: "TM17",
                        identifier: "Machines",
                        description: "Teaches the move Submission/Protect.",
                        id: 211
                        )
            },
            {
                361,
                new Item
                    (
                        name: "TM18",
                        identifier: "Machines",
                        description: "Teaches the move Counter/Rain Dance.",
                        id: 213
                        )
            },
            {
                362,
                new Item
                    (
                        name: "TM19",
                        identifier: "Machines",
                        description: "Teaches the move Seismic Toss/Giga Drain/Telekinesis/Roost.",
                        id: 221
                        )
            },
            {
                363,
                new Item
                    (
                        name: "TM20",
                        identifier: "Machines",
                        description: "Teaches the move Rage/Endure/Safeguard.",
                        id: 211
                        )
            },
            {
                364,
                new Item
                    (
                        name: "TM21",
                        identifier: "Machines",
                        description: "Teaches the move Mega Drain/Frustration.",
                        id: 211
                        )
            },
            {
                365,
                new Item
                    (
                        name: "TM22",
                        identifier: "Machines",
                        description: "Teaches the move SolarBeam.",
                        id: 215
                        )
            },
            {
                366,
                new Item
                    (
                        name: "TM23",
                        identifier: "Machines",
                        description: "Teaches the move Dragon Rage/Iron Tail/Smack Down.",
                        id: 223
                        )
            },
            {
                367,
                new Item
                    (
                        name: "TM24",
                        identifier: "Machines",
                        description: "Teaches the move Thunderbolt/DragonBreath.",
                        id: 214
                        )
            },
            {
                368,
                new Item
                    (
                        name: "TM25",
                        identifier: "Machines",
                        description: "Teaches the move Thunder.",
                        id: 214
                        )
            },
            {
                369,
                new Item
                    (
                        name: "TM26",
                        identifier: "Machines",
                        description: "Teaches the move Earthquake.",
                        id: 219
                        )
            },
            {
                370,
                new Item
                    (
                        name: "TM27",
                        identifier: "Machines",
                        description: "Teaches the move Fissure/Return.",
                        id: 211
                        )
            },
            {
                371,
                new Item
                    (
                        name: "TM28",
                        identifier: "Machines",
                        description: "Teaches the move Dig.",
                        id: 219
                        )
            },
            {
                372,
                new Item
                    (
                        name: "TM29",
                        identifier: "Machines",
                        description: "Teaches the move Psychic.",
                        id: 221
                        )
            },
            {
                373,
                new Item
                    (
                        name: "TM30",
                        identifier: "Machines",
                        description: "Teaches the move Teleport/Shadow Ball.",
                        id: 224
                        )
            },
            {
                374,
                new Item
                    (
                        name: "TM31",
                        identifier: "Machines",
                        description: "Teaches the move Mimic/Mud-Slap/Brick Break.",
                        id: 217
                        )
            },
            {
                375,
                new Item
                    (
                        name: "TM32",
                        identifier: "Machines",
                        description: "Teaches the move Double Team.",
                        id: 211
                        )
            },
            {
                376,
                new Item
                    (
                        name: "TM33",
                        identifier: "Machines",
                        description: "Teaches the move Ice Punch/Reflect.",
                        id: 221
                        )
            },
            {
                377,
                new Item
                    (
                        name: "TM34",
                        identifier: "Machines",
                        description: "Teaches the move Bide/Swagger/Shock Wave/Sludge Wave.",
                        id: 218
                        )
            },
            {
                378,
                new Item
                    (
                        name: "TM35",
                        identifier: "Machines",
                        description: "Teaches the move Metronome/Sleep Talk/Flamethrower.",
                        id: 212
                        )
            },
            {
                379,
                new Item
                    (
                        name: "TM36",
                        identifier: "Machines",
                        description: "Teaches the move Selfdestruct/Sludge Bomb.",
                        id: 218
                        )
            },
            {
                380,
                new Item
                    (
                        name: "TM37",
                        identifier: "Machines",
                        description: "Teaches the move Egg Bomb/Sandstorm.",
                        id: 223
                        )
            },
            {
                381,
                new Item
                    (
                        name: "TM38",
                        identifier: "Machines",
                        description: "Teaches the move Fire Blast.",
                        id: 212
                        )
            },
            {
                382,
                new Item
                    (
                        name: "TM39",
                        identifier: "Machines",
                        description: "Teaches the move Swift/Rock Tomb.",
                        id: 223
                        )
            },
            {
                383,
                new Item
                    (
                        name: "TM40",
                        identifier: "Machines",
                        description: "Teaches the move Skull Bash/Defense Curl/Aerial Ace.",
                        id: 220
                        )
            },
            {
                384,
                new Item
                    (
                        name: "TM41",
                        identifier: "Machines",
                        description: "Teaches the move Softboiled/ThunderPunch/Torment.",
                        id: 226
                        )
            },
            {
                385,
                new Item
                    (
                        name: "TM42",
                        identifier: "Machines",
                        description: "Teaches the move Dream Eater/Facade.",
                        id: 211
                        )
            },
            {
                386,
                new Item
                    (
                        name: "TM43",
                        identifier: "Machines",
                        description: "Teaches the move Sky Attack/Detect/Secret Power/Flame Charge.",
                        id: 212
                        )
            },
            {
                387,
                new Item
                    (
                        name: "TM44",
                        identifier: "Machines",
                        description: "Teaches the move Rest.",
                        id: 221
                        )
            },
            {
                388,
                new Item
                    (
                        name: "TM45",
                        identifier: "Machines",
                        description: "Teaches the move Thunder Wave/Attract.",
                        id: 211
                        )
            },
            {
                389,
                new Item
                    (
                        name: "TM46",
                        identifier: "Machines",
                        description: "Teaches the move Psywave/Thief.",
                        id: 226
                        )
            },
            {
                390,
                new Item
                    (
                        name: "TM47",
                        identifier: "Machines",
                        description: "Teaches the move Explosion/Steel Wing/Low Sweep.",
                        id: 217
                        )
            },
            {
                391,
                new Item
                    (
                        name: "TM48",
                        identifier: "Machines",
                        description: "Teaches the move Rock Slide/Fire Punch/Skill Swap/Round.",
                        id: 211
                        )
            },
            {
                392,
                new Item
                    (
                        name: "TM49",
                        identifier: "Machines",
                        description: "Teaches the move Tri Attack/Fury Cutter/Snatch/Echoed Voice.",
                        id: 211
                        )
            },
            {
                393,
                new Item
                    (
                        name: "TM50",
                        identifier: "Machines",
                        description: "Teaches the move Substitute/Nightmare/Overheat.",
                        id: 212
                        )
            },
            {
                394,
                new Item
                    (
                        name: "TM51",
                        identifier: "Machines",
                        description: "Teaches the move Roost/Ally Switch/Steel Wing.",
                        id: 221
                        )
            },
            {
                395,
                new Item
                    (
                        name: "TM52",
                        identifier: "Machines",
                        description: "Teaches the move Focus Blast.",
                        id: 217
                        )
            },
            {
                396,
                new Item
                    (
                        name: "TM53",
                        identifier: "Machines",
                        description: "Teaches the move Energy Ball.",
                        id: 215
                        )
            },
            {
                397,
                new Item
                    (
                        name: "TM54",
                        identifier: "Machines",
                        description: "Teaches the move False Swipe.",
                        id: 211
                        )
            },
            {
                398,
                new Item
                    (
                        name: "TM55",
                        identifier: "Machines",
                        description: "Teaches the move Brine/Scald.",
                        id: 213
                        )
            },
            {
                399,
                new Item
                    (
                        name: "TM56",
                        identifier: "Machines",
                        description: "Teaches the move Fling.",
                        id: 226
                        )
            },
            {
                400,
                new Item
                    (
                        name: "TM57",
                        identifier: "Machines",
                        description: "Teaches the move Charge Beam.",
                        id: 214
                        )
            },
            {
                401,
                new Item
                    (
                        name: "TM58",
                        identifier: "Machines",
                        description: "Teaches the move Endure/Sky Drop.",
                        id: 220
                        )
            },
            {
                402,
                new Item
                    (
                        name: "TM59",
                        identifier: "Machines",
                        description: "Teaches the move Dragon Pulse/Incinerate.",
                        id: 212
                        )
            },
            {
                403,
                new Item
                    (
                        name: "TM60",
                        identifier: "Machines",
                        description: "Teaches the move Drain Punch/Quash.",
                        id: 226
                        )
            },
            {
                404,
                new Item
                    (
                        name: "TM61",
                        identifier: "Machines",
                        description: "Teaches the move Will-O-Wisp.",
                        id: 212
                        )
            },
            {
                405,
                new Item
                    (
                        name: "TM62",
                        identifier: "Machines",
                        description: "Teaches the move Silver Wind/Acrobatics.",
                        id: 220
                        )
            },
            {
                406,
                new Item
                    (
                        name: "TM63",
                        identifier: "Machines",
                        description: "Teaches the move Embargo.",
                        id: 226
                        )
            },
            {
                407,
                new Item
                    (
                        name: "TM64",
                        identifier: "Machines",
                        description: "Teaches the move Explosion.",
                        id: 211
                        )
            },
            {
                408,
                new Item
                    (
                        name: "TM65",
                        identifier: "Machines",
                        description: "Teaches the move Shadow Claw.",
                        id: 224
                        )
            },
            {
                409,
                new Item
                    (
                        name: "TM66",
                        identifier: "Machines",
                        description: "Teaches the move Payback.",
                        id: 226
                        )
            },
            {
                410,
                new Item
                    (
                        name: "TM67",
                        identifier: "Machines",
                        description: "Teaches the move Recycle/Retaliate.",
                        id: 211
                        )
            },
            {
                411,
                new Item
                    (
                        name: "TM68",
                        identifier: "Machines",
                        description: "Teaches the move Giga Impact.",
                        id: 211
                        )
            },
            {
                412,
                new Item
                    (
                        name: "TM69",
                        identifier: "Machines",
                        description: "Teaches the move Rock Polish.",
                        id: 223
                        )
            },
            {
                413,
                new Item
                    (
                        name: "TM70",
                        identifier: "Machines",
                        description: "Teaches the move Flash.",
                        id: 211
                        )
            },
            {
                414,
                new Item
                    (
                        name: "TM71",
                        identifier: "Machines",
                        description: "Teaches the move Stone Edge.",
                        id: 223
                        )
            },
            {
                415,
                new Item
                    (
                        name: "TM72",
                        identifier: "Machines",
                        description: "Teaches the move Avalanche/Volt Switch.",
                        id: 214
                        )
            },
            {
                416,
                new Item
                    (
                        name: "TM73",
                        identifier: "Machines",
                        description: "Teaches the move Thunder Wave.",
                        id: 214
                        )
            },
            {
                417,
                new Item
                    (
                        name: "TM74",
                        identifier: "Machines",
                        description: "Teaches the move Gyro Ball.",
                        id: 227
                        )
            },
            {
                418,
                new Item
                    (
                        name: "TM75",
                        identifier: "Machines",
                        description: "Teaches the move Swords Dance.",
                        id: 211
                        )
            },
            {
                419,
                new Item
                    (
                        name: "TM76",
                        identifier: "Machines",
                        description: "Teaches the move Stealth Rock/Struggle Bug.",
                        id: 222
                        )
            },
            {
                420,
                new Item
                    (
                        name: "TM77",
                        identifier: "Machines",
                        description: "Teaches the move Psych Up.",
                        id: 211
                        )
            },
            {
                421,
                new Item
                    (
                        name: "TM78",
                        identifier: "Machines",
                        description: "Teaches the move Captivate/Bulldoze.",
                        id: 219
                        )
            },
            {
                422,
                new Item
                    (
                        name: "TM79",
                        identifier: "Machines",
                        description: "Teaches the move Dark Pulse/Frost Breath.",
                        id: 216
                        )
            },
            {
                423,
                new Item
                    (
                        name: "TM80",
                        identifier: "Machines",
                        description: "Teaches the move Rock Slide.",
                        id: 223
                        )
            },
            {
                424,
                new Item
                    (
                        name: "TM81",
                        identifier: "Machines",
                        description: "Teaches the move X-Scissor.",
                        id: 222
                        )
            },
            {
                425,
                new Item
                    (
                        name: "TM82",
                        identifier: "Machines",
                        description: "Teaches the move Sleep Talk/Dragon Tail.",
                        id: 225
                        )
            },
            {
                426,
                new Item
                    (
                        name: "TM83",
                        identifier: "Machines",
                        description: "Teaches the move Natural Gift/Work Up/Infestation.",
                        id: 211
                        )
            },
            {
                427,
                new Item
                    (
                        name: "TM84",
                        identifier: "Machines",
                        description: "Teaches the move Poison Jab.",
                        id: 218
                        )
            },
            {
                428,
                new Item
                    (
                        name: "TM85",
                        identifier: "Machines",
                        description: "Teaches the move Dream Eater.",
                        id: 221
                        )
            },
            {
                429,
                new Item
                    (
                        name: "TM86",
                        identifier: "Machines",
                        description: "Teaches the move Grass Knot.",
                        id: 215
                        )
            },
            {
                430,
                new Item
                    (
                        name: "TM87",
                        identifier: "Machines",
                        description: "Teaches the move Swagger.",
                        id: 211
                        )
            },
            {
                431,
                new Item
                    (
                        name: "TM88",
                        identifier: "Machines",
                        description: "Teaches the move Pluck/Sleep Talk.",
                        id: 220
                        )
            },
            {
                432,
                new Item
                    (
                        name: "TM89",
                        identifier: "Machines",
                        description: "Teaches the move U-turn.",
                        id: 222
                        )
            },
            {
                433,
                new Item
                    (
                        name: "TM90",
                        identifier: "Machines",
                        description: "Teaches the move Substitute.",
                        id: 211
                        )
            },
            {
                434,
                new Item
                    (
                        name: "TM91",
                        identifier: "Machines",
                        description: "Teaches the move Flash Cannon.",
                        id: 227
                        )
            },
            {
                435,
                new Item
                    (
                        name: "TM92",
                        identifier: "Machines",
                        description: "Teaches the move Trick Room.",
                        id: 221
                        )
            },
            {
                436,
                new Item
                    (
                        name: "TM93",
                        identifier: "Machines",
                        description: "Teaches the move Wild Charge.",
                        id: 214
                        )
            },
            {
                437,
                new Item
                    (
                        name: "TM94",
                        identifier: "Machines",
                        description: "Teaches the move Rock Smash.",
                        id: 217
                        )
            },
            {
                438,
                new Item
                    (
                        name: "TM95",
                        identifier: "Machines",
                        description: "Teaches the move Snarl.",
                        id: 226
                        )
            },
            {
                439,
                new Item
                    (
                        name: "Tamato Berry",
                        identifier: "Berries",
                        description: "Using it on a Pokémon makes it more friendly, but it also lowers its base Speed stat.",
                        id: 248
                        )
            },
            {
                440,
                new Item
                    (
                        name: "Tanga Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Bug-type attack against the holding Pokémon.",
                        id: 273
                        )
            },
            {
                441,
                new Item
                    (
                        name: "Thick Club",
                        identifier: "Hold items",
                        description: "An item to be held by CUBONE or MAROWAK. It is a hard bone of some sort that boosts the Attack stat.",
                        id: 131
                        )
            },
            {
                442,
                new Item
                    (
                        name: "Thunderstone",
                        identifier: "General items",
                        description: "A peculiar stone that makes certain species of POKÉMON evolve. It has a thunderbolt pattern.",
                        id: 327
                        )
            },
            {
                443,
                new Item
                    (
                        name: "Timer Ball",
                        identifier: "Pokeballs",
                        description: "A somewhat different BALL that becomes progressively better the more turns there are in a battle.",
                        id: 150
                        )
            },
            {
                444,
                new Item
                    (
                        name: "TinyMushroom",
                        identifier: "General items",
                        description: "A small and rare mushroom. It is sought after by collectors.",
                        id: 362
                        )
            },
            {
                445,
                new Item
                    (
                        name: "Toxic Orb",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a bizarre orb that badly poisons the holder in battle.",
                        id: 117
                        )
            },
            {
                446,
                new Item
                    (
                        name: "Toxic Plate",
                        identifier: "Hold items",
                        description: "Increases power of Poison-type moves. Changes Arceus' type to Poison.",
                        id: 72
                        )
            },
            {
                447,
                new Item
                    (
                        name: "TwistedSpoon",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a spoon imbued with telekinetic power that boosts Psychic-type moves.",
                        id: 57
                        )
            },
            {
                448,
                new Item
                    (
                        name: "Ultra Ball",
                        identifier: "Pokeballs",
                        description: "An ultra-performance Ball that provides a higher Pokémon catch rate than a Great Ball.",
                        id: 140
                        )
            },
            {
                449,
                new Item
                    (
                        name: "Up-Grade",
                        identifier: "General items",
                        description: "A transparent device filled with all sorts of data. It was produced by Silph Co.",
                        id: 335
                        )
            },
            {
                450,
                new Item
                    (
                        name: "Wacan Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Electric-type attack against the holding Pokémon.",
                        id: 265
                        )
            },
            {
                451,
                new Item
                    (
                        name: "Water Gem",
                        identifier: "Hold items",
                        description: "A gem with an essence of water. When held, it strengthens the power of a Water-type move only once.",
                        id: 83
                        )
            },
            {
                452,
                new Item
                    (
                        name: "Water Stone",
                        identifier: "General items",
                        description: "A peculiar stone that makes certain species of Pokémon evolve. It is a clear, light blue.",
                        id: 328
                        )
            },
            {
                453,
                new Item
                    (
                        name: "Watmel Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 260
                        )
            },
            {
                454,
                new Item
                    (
                        name: "Wave Incense",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is incense with a curious aroma that boosts the power of Water-type moves.",
                        id: 64
                        )
            },
            {
                455,
                new Item
                    (
                        name: "Wepear Berry",
                        identifier: "Berries",
                        description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price.",
                        id: 252
                        )
            },
            {
                456,
                new Item
                    (
                        name: "White Flute",
                        identifier: "General items",
                        description: "A toy flute made from white glass. A maniac will buy it for a high price.",
                        id: 356
                        )
            },
            {
                457,
                new Item
                    (
                        name: "White Herb",
                        identifier: "Hold items",
                        description: "An item to be held by a POKÉMON. It restores any lowered stat in battle. It can be used only once.",
                        id: 2
                        )
            },
            {
                458,
                new Item
                    (
                        name: "Wht Apricorn",
                        identifier: "General items",
                        description: "A white Apricorn. It doesn't smell like anything.",
                        id: 394
                        )
            },
            {
                459,
                new Item
                    (
                        name: "Wide Lens",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a magnifying lens that slightly boosts the accuracy of moves.",
                        id: 12
                        )
            },
            {
                460,
                new Item
                    (
                        name: "Wiki Berry",
                        identifier: "Berries",
                        description: "If held by a Pokémon, it restores the user's HP in a pinch, but will cause confusion if it hates the taste.",
                        id: 239
                        )
            },
            {
                461,
                new Item
                    (
                        name: "Wise Glasses",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. It is a thick pair of glasses that slightly boosts the power of special moves.",
                        id: 14
                        )
            },
            {
                462,
                new Item
                    (
                        name: "X Accuracy",
                        identifier: "Battle items",
                        description: "An item that raises the accuracy of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 297
                        )
            },
            {
                463,
                new Item
                    (
                        name: "X Accuracy 2",
                        identifier: "Battle items",
                        description: "It sharply raises the accuracy of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 306
                        )
            },
            {
                464,
                new Item
                    (
                        name: "X Accuracy 3",
                        identifier: "Battle items",
                        description: "It drastically raises the accuracy of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 312
                        )
            },
            {
                465,
                new Item
                    (
                        name: "X Accuracy 6",
                        identifier: "Battle items",
                        description: "It raises the accuracy of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn.",
                        id: 318
                        )
            },
            {
                466,
                new Item
                    (
                        name: "X Attack",
                        identifier: "Battle items",
                        description: "An item that raises the Attack stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 294
                        )
            },
            {
                467,
                new Item
                    (
                        name: "X Attack 2",
                        identifier: "Battle items",
                        description: "It sharply raises the Attack stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 305
                        )
            },
            {
                468,
                new Item
                    (
                        name: "X Attack 3",
                        identifier: "Battle items",
                        description: "It drastically raises the Attack stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 311
                        )
            },
            {
                469,
                new Item
                    (
                        name: "X Attack 6",
                        identifier: "Battle items",
                        description: "It raises the Attack stat of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn.",
                        id: 317
                        )
            },
            {
                470,
                new Item
                    (
                        name: "X Defend",
                        identifier: "Battle items",
                        description: "An item that raises the Defense stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 295
                        )
            },
            {
                471,
                new Item
                    (
                        name: "X Defend 2",
                        identifier: "Battle items",
                        description: "It sharply raises the Defense stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 304
                        )
            },
            {
                472,
                new Item
                    (
                        name: "X Defend 3",
                        identifier: "Battle items",
                        description: "It drastically raises the Defense stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 310
                        )
            },
            {
                473,
                new Item
                    (
                        name: "X Defend 6",
                        identifier: "Battle items",
                        description: "It raises the Defense stat of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn.",
                        id: 316
                        )
            },
            {
                474,
                new Item
                    (
                        name: "X Sp. Def",
                        identifier: "Battle items",
                        description: "An item that raises the Sp. Def stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 299
                        )
            },
            {
                475,
                new Item
                    (
                        name: "X Sp. Def 2",
                        identifier: "Battle items",
                        description: "It sharply raises the Sp. Def stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 303
                        )
            },
            {
                476,
                new Item
                    (
                        name: "X Sp. Def 3",
                        identifier: "Battle items",
                        description: "It drastically raises the Sp. Def stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 309
                        )
            },
            {
                477,
                new Item
                    (
                        name: "X Sp. Def 6",
                        identifier: "Battle items",
                        description: "It raises the Sp. Def stat of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn.",
                        id: 315
                        )
            },
            {
                478,
                new Item
                    (
                        name: "X Special",
                        identifier: "Battle items",
                        description: "An item that raises the Sp. Atk stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 298
                        )
            },
            {
                479,
                new Item
                    (
                        name: "X Special 2",
                        identifier: "Battle items",
                        description: "It sharply raises the Sp. Atk stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 302
                        )
            },
            {
                480,
                new Item
                    (
                        name: "X Special 3",
                        identifier: "Battle items",
                        description: "It drastically raises the Sp. Atk stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 308
                        )
            },
            {
                481,
                new Item
                    (
                        name: "X Special 6",
                        identifier: "Battle items",
                        description: "It raises the Sp. Atk stat of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn.",
                        id: 314
                        )
            },
            {
                482,
                new Item
                    (
                        name: "X Speed",
                        identifier: "Battle items",
                        description: "An item that raises the Speed stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 296
                        )
            },
            {
                483,
                new Item
                    (
                        name: "X Speed 2",
                        identifier: "Battle items",
                        description: "It sharply raises the Speed stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 301
                        )
            },
            {
                484,
                new Item
                    (
                        name: "X Speed 3",
                        identifier: "Battle items",
                        description: "It drastically raises the Speed stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn.",
                        id: 307
                        )
            },
            {
                485,
                new Item
                    (
                        name: "X Speed 6",
                        identifier: "Battle items",
                        description: "It raises the Speed stat of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn.",
                        id: 313
                        )
            },
            {
                486,
                new Item
                    (
                        name: "Yache Berry",
                        identifier: "Berries",
                        description: "Weakens a supereffective Ice-type attack against the holding Pokémon.",
                        id: 267
                        )
            },
            {
                487,
                new Item
                    (
                        name: "Yellow Flute",
                        identifier: "General items",
                        description: "A toy flute made from yellow glass. A maniac will buy it for a high price.",
                        id: 406
                        )
            },
            {
                488,
                new Item
                    (
                        name: "Yellow Scarf",
                        identifier: "General items",
                        description: "An item to be held by a Pokémon. It boosts the Tough aspect of the holder in a Contest.",
                        id: 404
                        )
            },
            {
                489,
                new Item
                    (
                        name: "Yellow Shard",
                        identifier: "General items",
                        description: "A small yellow shard. It appears to be from some sort of implement made long ago.",
                        id: 386
                        )
            },
            {
                490,
                new Item
                    (
                        name: "Ylw Apricorn",
                        identifier: "General items",
                        description: "A yellow Apricorn. It has an invigorating scent.",
                        id: 391
                        )
            },
            {
                491,
                new Item
                    (
                        name: "Zap Plate",
                        identifier: "Hold items",
                        description: "Increases power of Electric-type moves. Changes Arceus' type to Electric.",
                        id: 68
                        )
            },
            {
                492,
                new Item
                    (
                        name: "Zinc",
                        identifier: "Medicine",
                        description: "A nutritious drink for Pokémon. It raises the base Sp. Def (Special Defense) stat of a single Pokémon.",
                        id: 203
                        )
            },
            {
                493,
                new Item
                    (
                        name: "Zoom Lens",
                        identifier: "Hold items",
                        description: "An item to be held by a Pokémon. If the holder moves after its target, its accuracy will be boosted.",
                        id: 20
                        )
            }

        };
    }
}