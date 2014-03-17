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
                     id: 334,
                     name: "Ability Urge",
                     identifier: "Battle items",
                     description: "When used, it activates the Ability of an ally Pokémon."
                     )   
            },      
            {       
                2,  
                new Item    
                    (   
                     id: 41, 
                     name: "Absorb Bulb",
                     identifier: "Hold items",
                     description: "A consumable bulb. If the holder is hit by a Water-type move, its Sp. Atk will rise."
                     )   
            },      
            {       
                3,  
                new Item    
                    (   
                     id: 129, 
                     name: "Adamant Orb",
                     identifier: "Hold items",
                     description: "A brightly gleaming orb to be held by DIALGA. It boosts the power of Dragon-, and Steel-type moves."
                     )   
            },      
            {       
                4,  
                new Item    
                    (   
                     id: 253, 
                     name: "Aguav Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it restores the user's HP in a pinch, but will cause confusion if it hates the taste."
                     )   
            },      
            {       
                5,  
                new Item    
                    (   
                     id: 37, 
                     name: "Air Balloon",
                     identifier: "Hold items",
                     description: "When held by a Pokémon, the Pokémon will float into the air. When the holder is attacked, this item will burst."
                     )   
            },      
            {       
                6,  
                new Item    
                    (   
                     id: 116, 
                     name: "Amulet Coin",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It doubles a battle's prize money if the holding Pokémon joins in."
                     )   
            },      
            {       
                7,  
                new Item    
                    (   
                     id: 186, 
                     name: "Antidote",
                     identifier: "Medicine",
                     description: "A spray-type medicine. It lifts the effect of poison from one Pokémon."
                     )   
            },      
            {       
                8,  
                new Item    
                    (   
                     id: 298, 
                     name: "Apicot Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it raises its Sp. Def stat in a pinch."
                     )   
            },      
            {       
                9,  
                new Item    
                    (   
                     id: 365, 
                     name: "Armor Fossil",
                     identifier: "General items",
                     description: "A fossil from a prehistoric Pokémon that lived on the land. It appears to be part of a collar."
                     )   
            },      
            {       
                10, 
                new Item    
                    (   
                     id: 243, 
                     name: "Aspear Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it defrosts it."
                     )   
            },      
            {       
                11, 
                new Item    
                    (   
                     id: 190, 
                     name: "Awakening",
                     identifier: "Medicine",
                     description: "A spray-type medicine. It awakens a Pokémon from the clutches of sleep."
                     )   
            },      
            {       
                12, 
                new Item    
                    (   
                     id: 291, 
                     name: "Babiri Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Steel-type attack against the holding Pokémon."
                     )   
            },      
            {       
                13, 
                new Item    
                    (   
                     id: 389, 
                     name: "BalmMushroom",
                     identifier: "General items",
                     description: "A rare mushroom which gives off a nice fragrance. A maniac will buy it for a high price."
                     )   
            },      
            {       
                14, 
                new Item    
                    (   
                     id: 275, 
                     name: "Belue Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                15, 
                new Item    
                    (   
                     id: 184, 
                     name: "Berry Juice",
                     identifier: "Medicine",
                     description: "A 100% pure juice made of Berries. It restores the HP of one Pokémon by just 20 points."
                     )   
            },      
            {       
                16, 
                new Item    
                    (   
                     id: 381, 
                     name: "Big Mushroom",
                     identifier: "General items",
                     description: "A large and rare mushroom. It is sought after by collectors."
                     )   
            },      
            {       
                17, 
                new Item    
                    (   
                     id: 390, 
                     name: "Big Nugget",
                     identifier: "General items",
                     description: "A big nugget of pure gold that gives off a lustrous gleam. A maniac will buy it for a high price."
                     )   
            },      
            {       
                18, 
                new Item    
                    (   
                     id: 383, 
                     name: "Big Pearl",
                     identifier: "General items",
                     description: "A quite-large pearl that sparkles in a pretty silver color. It can be sold at a high price to shops."
                     )   
            },      
            {       
                19, 
                new Item    
                    (   
                     id: 31, 
                     name: "Big Root",
                     identifier: "Hold items",
                     description: "A Pokémon held item that boosts the power of HP-stealing moves to let the holder recover more HP."
                     )   
            },      
            {       
                20, 
                new Item    
                    (   
                     id: 40, 
                     name: "Binding Band",
                     identifier: "Hold items",
                     description: "A band that increases the power of binding moves when held."
                     )   
            },      
            {       
                21, 
                new Item    
                    (   
                     id: 52, 
                     name: "Black Belt",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a belt that boosts determination and Fighting-type moves."
                     )   
            },      
            {       
                22, 
                new Item    
                    (   
                     id: 372, 
                     name: "Black Flute",
                     identifier: "General items",
                     description: "A toy flute made from black glass. A maniac will buy it for a high price."
                     )   
            },      
            {       
                23, 
                new Item    
                    (   
                     id: 24, 
                     name: "Black Sludge",
                     identifier: "Hold items",
                     description: "A held item that gradually restores the HP of Poison-type Pokémon. It inflicts damage on all other types."
                     )   
            },      
            {       
                24, 
                new Item    
                    (   
                     id: 51, 
                     name: "BlackGlasses",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a shady-looking pair of glasses that boosts Dark-type moves."
                     )   
            },      
            {       
                25, 
                new Item    
                    (   
                     id: 414, 
                     name: "Blk Apricorn",
                     identifier: "General items",
                     description: "A black Apricorn It has an indescribable scent."
                     )   
            },      
            {       
                26, 
                new Item    
                    (   
                     id: 409, 
                     name: "Blu Apricorn",
                     identifier: "General items",
                     description: "A blue Apricorn. It smells a bit like grass."
                     )   
            },      
            {       
                27, 
                new Item    
                    (   
                     id: 425, 
                     name: "Blue Flute",
                     identifier: "General items",
                     description: "A toy flute made from blue glass. A maniac will buy it for a high price."
                     )   
            },      
            {       
                28, 
                new Item    
                    (   
                     id: 421, 
                     name: "Blue Scarf",
                     identifier: "General items",
                     description: "An item to be held by a Pokémon. It boosts the Beauty aspect of the holder in a Contest."
                     )   
            },      
            {       
                29, 
                new Item    
                    (   
                     id: 404, 
                     name: "Blue Shard",
                     identifier: "General items",
                     description: "A small blue shard. It appears to be from some sort of implement made long ago."
                     )   
            },      
            {       
                30, 
                new Item    
                    (   
                     id: 262, 
                     name: "Bluk Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                31, 
                new Item    
                    (   
                     id: 1, 
                     name: "BrightPowder",
                     identifier: "Hold items",
                     description: "An item to be held by a POKÉMON. It casts a tricky glare that lowers the opponent's accuracy."
                     )   
            },      
            {       
                32, 
                new Item    
                    (   
                     id: 96, 
                     name: "Bug Gem",
                     identifier: "Hold items",
                     description: "A gem with an insect-like essence. When held, it strengthens the power of a Bug-type move only once."
                     )   
            },      
            {       
                33, 
                new Item    
                    (   
                     id: 143, 
                     name: "Burn Drive",
                     identifier: "Hold items",
                     description: "A cassette to be held by Genesect. It changes Techno Blast to a Fire-type move."
                     )   
            },      
            {       
                34, 
                new Item    
                    (   
                     id: 187, 
                     name: "Burn Heal",
                     identifier: "Medicine",
                     description: "A spray-type medicine. It heals a single Pokémon that is suffering from a burn."
                     )   
            },      
            {       
                35, 
                new Item    
                    (   
                     id: 209, 
                     name: "Calcium",
                     identifier: "Medicine",
                     description: "A nutritious drink for Pokémon. It raises the base Sp. Atk (Special Attack) stat of a single Pokémon."
                     )   
            },      
            {       
                36, 
                new Item    
                    (   
                     id: 208, 
                     name: "Carbos",
                     identifier: "Medicine",
                     description: "A nutritious drink for Pokémon. It raises the base Speed stat of a single Pokémon."
                     )   
            },      
            {       
                37, 
                new Item    
                    (   
                     id: 196, 
                     name: "Casteliacone",
                     identifier: "Medicine",
                     description: "Castelia City's specialty, soft-serve ice cream. It heals all the status problems of a single Pokémon."
                     )   
            },      
            {       
                38, 
                new Item    
                    (   
                     id: 43, 
                     name: "Cell Battery",
                     identifier: "Hold items",
                     description: "A consumable battery. If the holder is hit by an Electric-type move, its Attack will rise."
                     )   
            },      
            {       
                39, 
                new Item    
                    (   
                     id: 60, 
                     name: "Charcoal",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a combustible fuel that boosts the power of Fire-type moves."
                     )   
            },      
            {       
                40, 
                new Item    
                    (   
                     id: 287, 
                     name: "Charti Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Rock-type attack against the holding Pokémon."
                     )   
            },      
            {       
                41, 
                new Item    
                    (   
                     id: 239, 
                     name: "Cheri Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it recovers from paralysis."
                     )   
            },      
            {       
                42, 
                new Item    
                    (   
                     id: 163, 
                     name: "Cherish Ball",
                     identifier: "Pokeballs",
                     description: "A quite rare Poké Ball that has been specially crafted to commemorate an occasion of some sort."
                     )   
            },      
            {       
                43, 
                new Item    
                    (   
                     id: 240, 
                     name: "Chesto Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it recovers from sleep."
                     )   
            },      
            {       
                44, 
                new Item    
                    (   
                     id: 292, 
                     name: "Chilan Berry",
                     identifier: "Berries",
                     description: "Weakens a Normal-type attack against the Pokémon holding this berry."
                     )   
            },      
            {       
                45, 
                new Item    
                    (   
                     id: 144, 
                     name: "Chill Drive",
                     identifier: "Hold items",
                     description: "A cassette to be held by Genesect. It changes Techno Blast to an Ice-type move."
                     )   
            },      
            {       
                46, 
                new Item    
                    (   
                     id: 103, 
                     name: "Choice Band",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. This headband ups Attack, but allows the use of only one of its moves."
                     )   
            },      
            {       
                47, 
                new Item    
                    (   
                     id: 104, 
                     name: "Choice Scarf",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. This scarf boosts Speed, but allows the use of only one of its moves."
                     )   
            },      
            {       
                48, 
                new Item    
                    (   
                     id: 106, 
                     name: "Choice Specs",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. These distinctive glasses boost Sp. Atk but allow the use of only one of its moves."
                     )   
            },      
            {       
                49, 
                new Item    
                    (   
                     id: 281, 
                     name: "Chople Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Fighting-type attack against the holding Pokémon."
                     )   
            },      
            {       
                50, 
                new Item    
                    (   
                     id: 361, 
                     name: "Claw Fossil",
                     identifier: "General items",
                     description: "A fossil of an ancient Pokémon that lived in the sea. It appears to be part of a claw."
                     )   
            },      
            {       
                51, 
                new Item    
                    (   
                     id: 117, 
                     name: "Cleanse Tag",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It helps keep wild Pokémon away if the holder is the first one in the party."
                     )   
            },      
            {       
                52, 
                new Item    
                    (   
                     id: 219, 
                     name: "Clever Wing",
                     identifier: "Medicine",
                     description: "An item for use on a Pokémon. It slightly increases the base Sp. Def stat of a single Pokémon."
                     )   
            },      
            {       
                53, 
                new Item    
                    (   
                     id: 284, 
                     name: "Coba Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Flying-type attack against the holding Pokémon."
                     )   
            },      
            {       
                54, 
                new Item    
                    (   
                     id: 290, 
                     name: "Colbur Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Dark-type attack against the holding Pokémon."
                     )   
            },      
            {       
                55, 
                new Item    
                    (   
                     id: 392, 
                     name: "Comet Shard",
                     identifier: "General items",
                     description: "A shard which fell to the ground when a comet approached. A maniac will buy it for a high price."
                     )   
            },      
            {       
                56, 
                new Item    
                    (   
                     id: 266, 
                     name: "Cornn Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                57, 
                new Item    
                    (   
                     id: 368, 
                     name: "Cover Fossil",
                     identifier: "General items",
                     description: "A fossil of an ancient Pokémon that lived in the sea in ancient times. It appears to be part of its back."
                     )   
            },      
            {       
                58, 
                new Item    
                    (   
                     id: 302, 
                     name: "Custap Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it gets to move first just once in a pinch."
                     )   
            },      
            {       
                59, 
                new Item    
                    (   
                     id: 416, 
                     name: "Damp Mulch",
                     identifier: "General items",
                     description: "A fertilizer to be spread on soft soil in regions where Berries are grown. A maniac will buy it for a high price."
                     )   
            },      
            {       
                60, 
                new Item    
                    (   
                     id: 28, 
                     name: "Damp Rock",
                     identifier: "Hold items",
                     description: "A Pokémon held item that extends the duration of the move Rain Dance used by the holder."
                     )   
            },      
            {       
                61, 
                new Item    
                    (   
                     id: 99, 
                     name: "Dark Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of darkness. When held, it strengthens the power of a Dark-type move only once."
                     )   
            },      
            {       
                62, 
                new Item    
                    (   
                     id: 348, 
                     name: "Dawn Stone",
                     identifier: "General items",
                     description: "A peculiar stone that makes certain species of Pokémon evolve. It sparkles like eyes."
                     )   
            },      
            {       
                63, 
                new Item    
                    (   
                     id: 133, 
                     name: "DeepSeaScale",
                     identifier: "Hold items",
                     description: "An item to be held by CLAMPERL. A scale that shines a faint pink, it raises the Sp. Def stat."
                     )   
            },      
            {       
                64, 
                new Item    
                    (   
                     id: 132, 
                     name: "DeepSeaTooth",
                     identifier: "Hold items",
                     description: "An item to be held by CLAMPERL. A fang that gleams a sharp silver, it raises the Sp. Atk stat."
                     )   
            },      
            {       
                65, 
                new Item    
                    (   
                     id: 23, 
                     name: "Destiny Knot",
                     identifier: "Hold items",
                     description: "A long, thin, bright-red string to be held by a Pokémon. If the holder becomes infatuated, the foe does too."
                     )   
            },      
            {       
                66, 
                new Item    
                    (   
                     id: 307, 
                     name: "Dire Hit",
                     identifier: "Battle items",
                     description: "It raises the critical-hit ratio greatly. It can be used only once and wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                67, 
                new Item    
                    (   
                     id: 314, 
                     name: "Dire Hit 2",
                     identifier: "Battle items",
                     description: "It can be used many times to raise the critical-hit ratio of one Pokémon. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                68, 
                new Item    
                    (   
                     id: 339, 
                     name: "Dire Hit 3",
                     identifier: "Battle items",
                     description: "It can be used many times to greatly raise a Pokémon's critical-hit ratio. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                69, 
                new Item    
                    (   
                     id: 154, 
                     name: "Dive Ball",
                     identifier: "Pokeballs",
                     description: "A somewhat different Poké Ball that works especially well on Pokémon that live underwater."
                     )   
            },      
            {       
                70, 
                new Item    
                    (   
                     id: 363, 
                     name: "Dome Fossil",
                     identifier: "General items",
                     description: "A fossil of an ancient Pokémon that lived in the sea. It appears to be part of a shell."
                     )   
            },      
            {       
                71, 
                new Item    
                    (   
                     id: 141, 
                     name: "Douse Drive",
                     identifier: "Hold items",
                     description: "A cassette to be held by Genesect. It changes Techno Blast to a Water-type move."
                     )   
            },      
            {       
                72, 
                new Item    
                    (   
                     id: 82, 
                     name: "Draco Plate",
                     identifier: "Hold items",
                     description: "Increases power of Dragon-type moves. Changes Arceus' type to Dragon."
                     )   
            },      
            {       
                73, 
                new Item    
                    (   
                     id: 61, 
                     name: "Dragon Fang",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a hard and sharp fang that ups the power of Dragon-type moves."
                     )   
            },      
            {       
                74, 
                new Item    
                    (   
                     id: 101, 
                     name: "Dragon Gem",
                     identifier: "Hold items",
                     description: "A gem with a draconic essence. When held, it strengthens the power of a Dragon-type move only once."
                     )   
            },      
            {       
                75, 
                new Item    
                    (   
                     id: 350, 
                     name: "Dragon Scale",
                     identifier: "General items",
                     description: "A thick and tough scale. Dragon-type Pokémon may be holding this item when caught."
                     )   
            },      
            {       
                76, 
                new Item    
                    (   
                     id: 83, 
                     name: "Dread Plate",
                     identifier: "Hold items",
                     description: "Increases power of Dark-type moves. Changes Arceus' type to Dark."
                     )   
            },      
            {       
                77, 
                new Item    
                    (   
                     id: 164, 
                     name: "Dream Ball",
                     identifier: "Pokeballs",
                     description: "A special Poké Ball that appears out of nowhere in a bag at the Entree Forest. It can catch any Pokémon."
                     )   
            },      
            {       
                78, 
                new Item    
                    (   
                     id: 355, 
                     name: "Dubious Disc",
                     identifier: "General items",
                     description: "A transparent device overflowing with dubious data. Its producer is unknown."
                     )   
            },      
            {       
                79, 
                new Item    
                    (   
                     id: 274, 
                     name: "Durin Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                80, 
                new Item    
                    (   
                     id: 160, 
                     name: "Dusk Ball",
                     identifier: "Pokeballs",
                     description: "A somewhat different Poké Ball that makes it easier to catch wild Pokémon at night or in dark places like caves."
                     )   
            },      
            {       
                81, 
                new Item    
                    (   
                     id: 347, 
                     name: "Dusk Stone",
                     identifier: "General items",
                     description: "A peculiar stone that makes certain species of Pokémon evolve. It is as dark as dark can be."
                     )   
            },      
            {       
                82, 
                new Item    
                    (   
                     id: 76, 
                     name: "Earth Plate",
                     identifier: "Hold items",
                     description: "Increases power of Ground-type moves. Changes Arceus' type to Ground."
                     )   
            },      
            {       
                83, 
                new Item    
                    (   
                     id: 44, 
                     name: "Eject Button",
                     identifier: "Hold items",
                     description: "If the holder is hit by an attack, it will switch with another Pokémon in your party."
                     )   
            },      
            {       
                84, 
                new Item    
                    (   
                     id: 353, 
                     name: "Electirizer",
                     identifier: "General items",
                     description: "A box packed with a tremendous amount of electric energy. It is loved by a certain Pokémon."
                     )   
            },      
            {       
                85, 
                new Item    
                    (   
                     id: 88, 
                     name: "Electric Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of electricity. When held, it strengthens the power of an Electric-type move only once."
                     )   
            },      
            {       
                86, 
                new Item    
                    (   
                     id: 203, 
                     name: "Elixir",
                     identifier: "Medicine",
                     description: "It restores the PP of all the moves learned by the targeted Pokémon by 10 points each."
                     )   
            },      
            {       
                87, 
                new Item    
                    (   
                     id: 183, 
                     name: "Energy Root",
                     identifier: "Medicine",
                     description: "A very bitter root. It restores the HP of one POKÉMON by 200 points."
                     )   
            },      
            {       
                88, 
                new Item    
                    (   
                     id: 182, 
                     name: "EnergyPowder",
                     identifier: "Medicine",
                     description: "A very bitter medicine powder. It restores the HP of one POKÉMON by 50 points."
                     )   
            },      
            {       
                89, 
                new Item    
                    (   
                     id: 303, 
                     name: "Enigma Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it restores its HP if it is hit by any supereffective attack."
                     )   
            },      
            {       
                90, 
                new Item    
                    (   
                     id: 376, 
                     name: "Escape Rope",
                     identifier: "General items",
                     description: "A long, durable rope. Use it to escape instantly from a cave or a dungeon."
                     )   
            },      
            {       
                91, 
                new Item    
                    (   
                     id: 201, 
                     name: "Ether",
                     identifier: "Medicine",
                     description: "It restores the PP of a Pokémon's selected move by a maximum of 10 points."
                     )   
            },      
            {       
                92, 
                new Item    
                    (   
                     id: 118, 
                     name: "Everstone",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. The Pokémon holding this peculiar stone is prevented from evolving."
                     )   
            },      
            {       
                93, 
                new Item    
                    (   
                     id: 34, 
                     name: "Eviolite",
                     identifier: "Hold items",
                     description: "A mysterious evolutionary lump. When held, it raises the Defense and Sp. Def of a Pokémon that can still evolve."
                     )   
            },      
            {       
                94, 
                new Item    
                    (   
                     id: 114, 
                     name: "Exp. Share",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. The holder gets a share of a battle's Exp. Points without battling."
                     )   
            },      
            {       
                95, 
                new Item    
                    (   
                     id: 15, 
                     name: "Expert Belt",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a well-worn belt that slightly boosts the power of supereffective moves."
                     )   
            },      
            {       
                96, 
                new Item    
                    (   
                     id: 170, 
                     name: "Fast Ball",
                     identifier: "Pokeballs",
                     description: "A Poké Ball that makes it easier to catch Pokémon which are quick to run away."
                     )   
            },      
            {       
                97, 
                new Item    
                    (   
                     id: 91, 
                     name: "Fighting Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of combat. When held, it strengthens the power of a Fighting-type move only once."
                     )   
            },      
            {       
                98, 
                new Item    
                    (   
                     id: 249, 
                     name: "Figy Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it restores the user's HP in a pinch, but will cause confusion if it hates the taste."
                     )   
            },      
            {       
                99, 
                new Item    
                    (   
                     id: 86, 
                     name: "Fire Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of fire. When held, it strengthens the power of a Fire-type move only once."
                     )   
            },      
            {       
                100,    
                new Item    
                    (   
                     id: 342, 
                     name: "Fire Stone",
                     identifier: "General items",
                     description: "A peculiar stone that makes certain species of POKÉMON evolve. It is colored orange."
                     )   
            },      
            {       
                101,    
                new Item    
                    (   
                     id: 74, 
                     name: "Fist Plate",
                     identifier: "Hold items",
                     description: "Increases power of Fighting-type moves. Changes Arceus' type to Fighting."
                     )   
            },      
            {       
                102,    
                new Item    
                    (   
                     id: 123, 
                     name: "Flame Orb",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a bizarre orb that inflicts a burn on the holder in battle."
                     )   
            },      
            {       
                103,    
                new Item    
                    (   
                     id: 69, 
                     name: "Flame Plate",
                     identifier: "Hold items",
                     description: "Increases power of Fire-type moves. Changes Arceus' type to Fire."
                     )   
            },      
            {       
                104,    
                new Item    
                    (   
                     id: 35, 
                     name: "Float Stone",
                     identifier: "Hold items",
                     description: "A very light stone. It reduces the weight of a Pokémon when held."
                     )   
            },      
            {       
                105,    
                new Item    
                    (   
                     id: 371, 
                     name: "Fluffy Tail",
                     identifier: "General items",
                     description: "An item that attracts Pokémon. Use it to flee from any battle with a wild Pokémon."
                     )   
            },      
            {       
                106,    
                new Item    
                    (   
                     id: 94, 
                     name: "Flying Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of air. When held, it strengthens the power of a Flying-type move only once."
                     )   
            },      
            {       
                107,    
                new Item    
                    (   
                     id: 7, 
                     name: "Focus Band",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. The holder may endure a potential KO attack, leaving it with just 1 HP."
                     )   
            },      
            {       
                108,    
                new Item    
                    (   
                     id: 19, 
                     name: "Focus Sash",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. If it has full HP, the holder will endure one potential KO attack, leaving 1 HP."
                     )   
            },      
            {       
                109,    
                new Item    
                    (   
                     id: 178, 
                     name: "Fresh Water",
                     identifier: "Medicine",
                     description: "Water with a high mineral content. It restores the HP of one POKÉMON by 50 points."
                     )   
            },      
            {       
                110,    
                new Item    
                    (   
                     id: 171, 
                     name: "Friend Ball",
                     identifier: "Pokeballs",
                     description: "A Poké Ball that makes caught Pokémon more friendly."
                     )   
            },      
            {       
                111,    
                new Item    
                    (   
                     id: 192, 
                     name: "Full Heal",
                     identifier: "Medicine",
                     description: "A spray-type medicine. It heals all the status problems of a single Pokémon."
                     )   
            },      
            {       
                112,    
                new Item    
                    (   
                     id: 128, 
                     name: "Full Incense",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is an exotic-smelling incense that makes the holder bloated and slow moving."
                     )   
            },      
            {       
                113,    
                new Item    
                    (   
                     id: 174, 
                     name: "Full Restore",
                     identifier: "Medicine",
                     description: "A medicine that fully restores the HP and heals any status problems of a single Pokémon."
                     )   
            },      
            {       
                114,    
                new Item    
                    (   
                     id: 295, 
                     name: "Ganlon Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it raises its Defense stat in a pinch."
                     )   
            },      
            {       
                115,    
                new Item    
                    (   
                     id: 218, 
                     name: "Genius Wing",
                     identifier: "Medicine",
                     description: "An item for use on a Pokémon. It slightly increases the base Sp. Atk stat of a single Pokémon."
                     )   
            },      
            {       
                116,    
                new Item    
                    (   
                     id: 98, 
                     name: "Ghost Gem",
                     identifier: "Hold items",
                     description: "A gem with a spectral essence. When held, it strengthens the power of a Ghost-type move only once."
                     )   
            },      
            {       
                117,    
                new Item    
                    (   
                     id: 418, 
                     name: "Gooey Mulch",
                     identifier: "General items",
                     description: "A fertilizer to be spread on soft soil in regions where Berries are grown. A maniac will buy it for a high price."
                     )   
            },      
            {       
                118,    
                new Item    
                    (   
                     id: 89, 
                     name: "Grass Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of nature. When held, it strengthens the power of a Grass-type move only once."
                     )   
            },      
            {       
                119,    
                new Item    
                    (   
                     id: 148, 
                     name: "Great Ball",
                     identifier: "Pokeballs",
                     description: "A good, high-performance Ball that provides a higher Pokémon catch rate than a standard Poké Ball."
                     )   
            },      
            {       
                120,    
                new Item    
                    (   
                     id: 423, 
                     name: "Green Scarf",
                     identifier: "General items",
                     description: "An item to be held by a Pokémon. It boosts the Smart aspect of the holder in a Contest."
                     )   
            },      
            {       
                121,    
                new Item    
                    (   
                     id: 406, 
                     name: "Green Shard",
                     identifier: "General items",
                     description: "A small green shard. It appears to be from some sort of implement made long ago."
                     )   
            },      
            {       
                122,    
                new Item    
                    (   
                     id: 259, 
                     name: "Grepa Berry",
                     identifier: "Berries",
                     description: "Using it on a Pokémon makes it more friendly, but it also lowers its base Sp. Def stat."
                     )   
            },      
            {       
                123,    
                new Item    
                    (   
                     id: 29, 
                     name: "Grip Claw",
                     identifier: "Hold items",
                     description: "A Pokémon held item that extends the duration of multiturn attacks like Bind and Wrap."
                     )   
            },      
            {       
                124,    
                new Item    
                    (   
                     id: 140, 
                     name: "Griseous Orb",
                     identifier: "Hold items",
                     description: "A glowing orb to be held by GIRATINA. It boosts the power of Dragon- and Ghost-type moves."
                     )   
            },      
            {       
                125,    
                new Item    
                    (   
                     id: 411, 
                     name: "Grn Apricorn",
                     identifier: "General items",
                     description: "A green Apricorn. It has a mysterious, aromatic scent."
                     )   
            },      
            {       
                126,    
                new Item    
                    (   
                     id: 93, 
                     name: "Ground Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of land. When held, it strengthens the power of a Ground-type move only once."
                     )   
            },      
            {       
                127,    
                new Item    
                    (   
                     id: 415, 
                     name: "Growth Mulch",
                     identifier: "General items",
                     description: "A fertilizer to be spread on soft soil in regions where Berries are grown. A maniac will buy it for a high price."
                     )   
            },      
            {       
                128,    
                new Item    
                    (   
                     id: 306, 
                     name: "Guard Spec.",
                     identifier: "Battle items",
                     description: "An item that prevents stat reduction among the Trainer's party Pokémon for five turns after use."
                     )   
            },      
            {       
                129,    
                new Item    
                    (   
                     id: 221, 
                     name: "HM01",
                     identifier: "Machines",
                     description: "Teaches the move Cut."
                     )   
            },      
            {       
                130,    
                new Item    
                    (   
                     id: 230, 
                     name: "HM02",
                     identifier: "Machines",
                     description: "Teaches the move Fly."
                     )   
            },      
            {       
                131,    
                new Item    
                    (   
                     id: 223, 
                     name: "HM03",
                     identifier: "Machines",
                     description: "Teaches the move Surf."
                     )   
            },      
            {       
                132,    
                new Item    
                    (   
                     id: 221, 
                     name: "HM04",
                     identifier: "Machines",
                     description: "Teaches the move Strength."
                     )   
            },      
            {       
                133,    
                new Item    
                    (   
                     id: 223, 
                     name: "HM05",
                     identifier: "Machines",
                     description: "Teaches the move Flash/Defog/Whirlpool/Waterfall."
                     )   
            },      
            {       
                134,    
                new Item    
                    (   
                     id: 223, 
                     name: "HM06",
                     identifier: "Machines",
                     description: "Teaches the move Whirlpool/Rock Smash/Dive."
                     )   
            },      
            {       
                135,    
                new Item    
                    (   
                     id: 223, 
                     name: "HM07",
                     identifier: "Machines",
                     description: "Teaches the move Waterfall."
                     )   
            },      
            {       
                136,    
                new Item    
                    (   
                     id: 221, 
                     name: "HM08",
                     identifier: "Machines",
                     description: "Teaches the move Dive/Rock Climb."
                     )   
            },      
            {       
                137,    
                new Item    
                    (   
                     id: 205, 
                     name: "HP Up",
                     identifier: "Medicine",
                     description: "A nutritious drink for Pokémon. It raises the base HP of a single Pokémon."
                     )   
            },      
            {       
                138,    
                new Item    
                    (   
                     id: 289, 
                     name: "Haban Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Dragon-type attack against the holding Pokémon."
                     )   
            },      
            {       
                139,    
                new Item    
                    (   
                     id: 49, 
                     name: "Hard Stone",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is an unbreakable stone that ups the power of Rock-type moves."
                     )   
            },      
            {       
                140,    
                new Item    
                    (   
                     id: 161, 
                     name: "Heal Ball",
                     identifier: "Pokeballs",
                     description: "A remedial Poké Ball that restores the caught Pokémon's HP and eliminates any status problem."
                     )   
            },      
            {       
                141,    
                new Item    
                    (   
                     id: 193, 
                     name: "Heal Powder",
                     identifier: "Medicine",
                     description: "A very bitter medicine powder. It heals all the status problems of a single Pokémon."
                     )   
            },      
            {       
                142,    
                new Item    
                    (   
                     id: 215, 
                     name: "Health Wing",
                     identifier: "Medicine",
                     description: "An item for use on a Pokémon. It slightly increases the base HP of a single Pokémon."
                     )   
            },      
            {       
                143,    
                new Item    
                    (   
                     id: 407, 
                     name: "Heart Scale",
                     identifier: "General items",
                     description: "A pretty, heart-shaped scale that is extremely rare. It glows faintly in the colors of the rainbow."
                     )   
            },      
            {       
                144,    
                new Item    
                    (   
                     id: 27, 
                     name: "Heat Rock",
                     identifier: "Hold items",
                     description: "A Pokémon held item that extends the duration of the move Sunny Day used by the holder."
                     )   
            },      
            {       
                145,    
                new Item    
                    (   
                     id: 169, 
                     name: "Heavy Ball",
                     identifier: "Pokeballs",
                     description: "A Poké Ball for catching very heavy Pokémon."
                     )   
            },      
            {       
                146,    
                new Item    
                    (   
                     id: 362, 
                     name: "Helix Fossil",
                     identifier: "General items",
                     description: "A fossil of an ancient Pokémon that lived in the sea. It appears to be part of a seashell."
                     )   
            },      
            {       
                147,    
                new Item    
                    (   
                     id: 258, 
                     name: "Hondew Berry",
                     identifier: "Berries",
                     description: "Using it on a Pokémon makes it more friendly, but it also lowers its base Sp. Atk stat."
                     )   
            },      
            {       
                148,    
                new Item    
                    (   
                     id: 359, 
                     name: "Honey",
                     identifier: "General items",
                     description: "A sweet honey with a lush aroma that attracts wild Pokémon when it is used in grass, caves, or on special trees."
                     )   
            },      
            {       
                149,    
                new Item    
                    (   
                     id: 176, 
                     name: "Hyper Potion",
                     identifier: "Medicine",
                     description: "A spray-type medicine for wounds. It restores the HP of one Pokémon by 200 points."
                     )   
            },      
            {       
                150,    
                new Item    
                    (   
                     id: 254, 
                     name: "Iapapa Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it restores the user's HP in a pinch, but will cause confusion if it hates the taste."
                     )   
            },      
            {       
                151,    
                new Item    
                    (   
                     id: 90, 
                     name: "Ice Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of ice. When held, it strengthens the power of an Ice-type move only once."
                     )   
            },      
            {       
                152,    
                new Item    
                    (   
                     id: 188, 
                     name: "Ice Heal",
                     identifier: "Medicine",
                     description: "A spray-type medicine. It defrosts a Pokémon that has been frozen solid."
                     )   
            },      
            {       
                153,    
                new Item    
                    (   
                     id: 73, 
                     name: "Icicle Plate",
                     identifier: "Hold items",
                     description: "Increases power of Ice-type moves. Changes Arceus' type to Ice."
                     )   
            },      
            {       
                154,    
                new Item    
                    (   
                     id: 25, 
                     name: "Icy Rock",
                     identifier: "Hold items",
                     description: "A Pokémon held item that extends the duration of the move Hail used by the holder."
                     )   
            },      
            {       
                155,    
                new Item    
                    (   
                     id: 79, 
                     name: "Insect Plate",
                     identifier: "Hold items",
                     description: "Increases power of Bug-type moves. Changes Arceus' type to Bug."
                     )   
            },      
            {       
                156,    
                new Item    
                    (   
                     id: 207, 
                     name: "Iron",
                     identifier: "Medicine",
                     description: "A nutritious drink for Pokémon. It raises the base Defense stat of a single Pokémon."
                     )   
            },      
            {       
                157,    
                new Item    
                    (   
                     id: 124, 
                     name: "Iron Ball",
                     identifier: "Hold items",
                     description: "A Pokémon held item that cuts Speed. It makes Flying-type and levitating holders susceptible to Ground moves."
                     )   
            },      
            {       
                158,    
                new Item    
                    (   
                     id: 85, 
                     name: "Iron Plate",
                     identifier: "Hold items",
                     description: "Increases power of Steel-type moves. Changes Arceus' type to Steel."
                     )   
            },      
            {       
                159,    
                new Item    
                    (   
                     id: 335, 
                     name: "Item Drop",
                     identifier: "Battle items",
                     description: "When used, it causes an ally Pokémon to drop a held item."
                     )   
            },      
            {       
                160,    
                new Item    
                    (   
                     id: 337, 
                     name: "Item Urge",
                     identifier: "Battle items",
                     description: "When used, it causes an ally Pokémon to use its held item."
                     )   
            },      
            {       
                161,    
                new Item    
                    (   
                     id: 304, 
                     name: "Jaboca Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon and a physical attack lands, the attacker also takes damage."
                     )   
            },      
            {       
                162,    
                new Item    
                    (   
                     id: 288, 
                     name: "Kasib Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Ghost-type attack against the holding Pokémon."
                     )   
            },      
            {       
                163,    
                new Item    
                    (   
                     id: 282, 
                     name: "Kebia Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Poison-type attack against the holding Pokémon."
                     )   
            },      
            {       
                164,    
                new Item    
                    (   
                     id: 256, 
                     name: "Kelpsy Berry",
                     identifier: "Berries",
                     description: "Using it on a Pokémon makes it more friendly, but it also lowers its base Attack stat."
                     )   
            },      
            {       
                165,    
                new Item    
                    (   
                     id: 5, 
                     name: "King's Rock",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. When the holder inflicts damage, the target may flinch."
                     )   
            },      
            {       
                166,    
                new Item    
                    (   
                     id: 125, 
                     name: "Lagging Tail",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is tremendously heavy and makes the holder move slower than usual."
                     )   
            },      
            {       
                167,    
                new Item    
                    (   
                     id: 299, 
                     name: "Lansat Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it raises its critical-hit ratio in a pinch."
                     )   
            },      
            {       
                168,    
                new Item    
                    (   
                     id: 194, 
                     name: "Lava Cookie",
                     identifier: "Medicine",
                     description: "LAVARIDGE TOWN's local specialty. It heals all the status problems of one POKÉMON."
                     )   
            },      
            {       
                169,    
                new Item    
                    (   
                     id: 11, 
                     name: "Lax Incense",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. The tricky aroma of this incense may make attacks miss the holder."
                     )   
            },      
            {       
                170,    
                new Item    
                    (   
                     id: 345, 
                     name: "Leaf Stone",
                     identifier: "General items",
                     description: "A peculiar stone that makes certain species of POKÉMON evolve. It has a leaf pattern."
                     )   
            },      
            {       
                171,    
                new Item    
                    (   
                     id: 9, 
                     name: "Leftovers",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. The holder's HP is gradually restored during battle."
                     )   
            },      
            {       
                172,    
                new Item    
                    (   
                     id: 180, 
                     name: "Lemonade",
                     identifier: "Medicine",
                     description: "A very sweet drink. It restores the HP of one POKÉMON by 80 points."
                     )   
            },      
            {       
                173,    
                new Item    
                    (   
                     id: 244, 
                     name: "Leppa Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it restores a move's PP by 10."
                     )   
            },      
            {       
                174,    
                new Item    
                    (   
                     id: 166, 
                     name: "Level Ball",
                     identifier: "Pokeballs",
                     description: "A Poké Ball for catching Pokémon that are a lower level than your own."
                     )   
            },      
            {       
                175,    
                new Item    
                    (   
                     id: 293, 
                     name: "Liechi Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it raises its Attack stat in a pinch."
                     )   
            },      
            {       
                176,    
                new Item    
                    (   
                     id: 17, 
                     name: "Life Orb",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It boosts the power of moves, but at the cost of some HP on each hit."
                     )   
            },      
            {       
                177,    
                new Item    
                    (   
                     id: 134, 
                     name: "Light Ball",
                     identifier: "Hold items",
                     description: "An item to be held by PIKACHU. It is a puzzling orb that raises the Attack and Sp. Atk stat."
                     )   
            },      
            {       
                178,    
                new Item    
                    (   
                     id: 16, 
                     name: "Light Clay",
                     identifier: "Hold items",
                     description: "A Pokémon held item that extends the duration of barrier moves like Light Screen and Reflect used by the holder."
                     )   
            },      
            {       
                179,    
                new Item    
                    (   
                     id: 172, 
                     name: "Love Ball",
                     identifier: "Pokeballs",
                     description: "Poké Ball for catching Pokémon that are the opposite gender of your Pokémon."
                     )   
            },      
            {       
                180,    
                new Item    
                    (   
                     id: 120, 
                     name: "Luck Incense",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It doubles a battle's prize money if the holding Pokémon joins in."
                     )   
            },      
            {       
                181,    
                new Item    
                    (   
                     id: 119, 
                     name: "Lucky Egg",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is an egg filled with happiness that earns extra Exp. Points in battle."
                     )   
            },      
            {       
                182,    
                new Item    
                    (   
                     id: 135, 
                     name: "Lucky Punch",
                     identifier: "Hold items",
                     description: "An item to be held by CHANSEY. It is a pair of gloves that boosts CHANSEY's critical-hit ratio."
                     )   
            },      
            {       
                183,    
                new Item    
                    (   
                     id: 247, 
                     name: "Lum Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it recovers from any status problem."
                     )   
            },      
            {       
                184,    
                new Item    
                    (   
                     id: 165, 
                     name: "Lure Ball",
                     identifier: "Pokeballs",
                     description: "A Poké Ball for catching Pokémon hooked by a Rod when fishing."
                     )   
            },      
            {       
                185,    
                new Item    
                    (   
                     id: 130, 
                     name: "Lustrous Orb",
                     identifier: "Hold items",
                     description: "A beautifully glowing orb to be held by PALKIA. It boosts the power of Dragon-, and Water-type moves."
                     )   
            },      
            {       
                186,    
                new Item    
                    (   
                     id: 158, 
                     name: "Luxury Ball",
                     identifier: "Pokeballs",
                     description: "A comfortable Poké Ball that makes a caught wild Pokémon quickly grow friendly."
                     )   
            },      
            {       
                187,    
                new Item    
                    (   
                     id: 107, 
                     name: "Macho Brace",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a stiff and heavy brace that promotes strong growth but lowers Speed."
                     )   
            },      
            {       
                188,    
                new Item    
                    (   
                     id: 354, 
                     name: "Magmarizer",
                     identifier: "General items",
                     description: "A box packed with a tremendous amount of magma energy. It is loved by a certain Pokémon."
                     )   
            },      
            {       
                189,    
                new Item    
                    (   
                     id: 53, 
                     name: "Magnet",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a powerful magnet that boosts the power of Electric-type moves."
                     )   
            },      
            {       
                190,    
                new Item    
                    (   
                     id: 251, 
                     name: "Mago Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it restores the user's HP in a pinch, but will cause confusion if it hates the taste."
                     )   
            },      
            {       
                191,    
                new Item    
                    (   
                     id: 267, 
                     name: "Magost Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                192,    
                new Item    
                    (   
                     id: 145, 
                     name: "Master Ball",
                     identifier: "Pokeballs",
                     description: "The best Ball with the ultimate level of performance. It will catch any wild Pokémon without fail."
                     )   
            },      
            {       
                193,    
                new Item    
                    (   
                     id: 204, 
                     name: "Max Elixir",
                     identifier: "Medicine",
                     description: "It fully restores the PP of all the moves learned by the targeted Pokémon."
                     )   
            },      
            {       
                194,    
                new Item    
                    (   
                     id: 202, 
                     name: "Max Ether",
                     identifier: "Medicine",
                     description: "It fully restores the PP of a single selected move that has been learned by the target Pokémon."
                     )   
            },      
            {       
                195,    
                new Item    
                    (   
                     id: 175, 
                     name: "Max Potion",
                     identifier: "Medicine",
                     description: "A spray-type medicine for wounds. It completely restores the HP of a single Pokémon."
                     )   
            },      
            {       
                196,    
                new Item    
                    (   
                     id: 375, 
                     name: "Max Repel",
                     identifier: "General items",
                     description: "An item that prevents weak wild Pokémon from appearing for 250 steps after its use."
                     )   
            },      
            {       
                197,    
                new Item    
                    (   
                     id: 198, 
                     name: "Max Revive",
                     identifier: "Medicine",
                     description: "A medicine that revives a fainted Pokémon. It fully restores the Pokémon's HP."
                     )   
            },      
            {       
                198,    
                new Item    
                    (   
                     id: 72, 
                     name: "Meadow Plate",
                     identifier: "Hold items",
                     description: "Increases power of Grass-type moves. Changes Arceus' type to Grass."
                     )   
            },      
            {       
                199,    
                new Item    
                    (   
                     id: 4, 
                     name: "Mental Herb",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It snaps the holder out of infatuation. It can be used only once."
                     )   
            },      
            {       
                200,    
                new Item    
                    (   
                     id: 47, 
                     name: "Metal Coat",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a special metallic film that ups the power of Steel-type moves."
                     )   
            },      
            {       
                201,    
                new Item    
                    (   
                     id: 136, 
                     name: "Metal Powder",
                     identifier: "Hold items",
                     description: "An item to be held by DITTO. Extremely fine yet hard, this odd powder boosts the Defense stat."
                     )   
            },      
            {       
                202,    
                new Item    
                    (   
                     id: 22, 
                     name: "Metronome",
                     identifier: "Hold items",
                     description: "A Pokémon held item that boosts a move used consecutively. Its effect is reset if another move is used."
                     )   
            },      
            {       
                203,    
                new Item    
                    (   
                     id: 301, 
                     name: "Micle Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it raises the accuracy of a move just once in a pinch."
                     )   
            },      
            {       
                204,    
                new Item    
                    (   
                     id: 78, 
                     name: "Mind Plate",
                     identifier: "Hold items",
                     description: "Increases power of Psychic-type moves. Changes Arceus' type to Psychic."
                     )   
            },      
            {       
                205,    
                new Item    
                    (   
                     id: 50, 
                     name: "Miracle Seed",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a seed imbued with life that ups the power of Grass-type moves."
                     )   
            },      
            {       
                206,    
                new Item    
                    (   
                     id: 181, 
                     name: "Moomoo Milk",
                     identifier: "Medicine",
                     description: "Milk with a very high nutrition content. It restores the HP of one Pokémon by 100 points."
                     )   
            },      
            {       
                207,    
                new Item    
                    (   
                     id: 167, 
                     name: "Moon Ball",
                     identifier: "Pokeballs",
                     description: "A Poké Ball for catching Pokémon that evolve using the Moon Stone."
                     )   
            },      
            {       
                208,    
                new Item    
                    (   
                     id: 341, 
                     name: "Moon Stone",
                     identifier: "General items",
                     description: "A peculiar stone that makes certain species of POKÉMON evolve. It is as black as the night sky."
                     )   
            },      
            {       
                209,    
                new Item    
                    (   
                     id: 13, 
                     name: "Muscle Band",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a headband that slightly boosts the power of physical moves."
                     )   
            },      
            {       
                210,    
                new Item    
                    (   
                     id: 216, 
                     name: "Muscle Wing",
                     identifier: "Medicine",
                     description: "An item for use on a Pokémon. It slightly increases the base Attack stat of a single Pokémon."
                     )   
            },      
            {       
                211,    
                new Item    
                    (   
                     id: 54, 
                     name: "Mystic Water",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a teardrop-shaped gem that ups the power of Water-type moves."
                     )   
            },      
            {       
                212,    
                new Item    
                    (   
                     id: 263, 
                     name: "Nanab Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                213,    
                new Item    
                    (   
                     id: 155, 
                     name: "Nest Ball",
                     identifier: "Pokeballs",
                     description: "A somewhat different Poké Ball that works especially well on weaker Pokémon in the wild."
                     )   
            },      
            {       
                214,    
                new Item    
                    (   
                     id: 153, 
                     name: "Net Ball",
                     identifier: "Pokeballs",
                     description: "A somewhat different Poké Ball that works especially well on Water- and Bug-type Pokémon."
                     )   
            },      
            {       
                215,    
                new Item    
                    (   
                     id: 57, 
                     name: "NeverMeltIce",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a piece of ice that repels heat and boosts Ice-type moves."
                     )   
            },      
            {       
                216,    
                new Item    
                    (   
                     id: 269, 
                     name: "Nomel Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                217,    
                new Item    
                    (   
                     id: 102, 
                     name: "Normal Gem",
                     identifier: "Hold items",
                     description: "A gem with an ordinary essence. When held, it strengthens the power of a Normal-type move only once."
                     )   
            },      
            {       
                218,    
                new Item    
                    (   
                     id: 386, 
                     name: "Nugget",
                     identifier: "General items",
                     description: "A nugget of pure gold that gives off a lustrous gleam. It can be sold at a high price to shops."
                     )   
            },      
            {       
                219,    
                new Item    
                    (   
                     id: 276, 
                     name: "Occa Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Fire-type attack against the holding Pokémon."
                     )   
            },      
            {       
                220,    
                new Item    
                    (   
                     id: 65, 
                     name: "Odd Incense",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is an exotic-smelling incense that boosts the power of Psychic-type moves."
                     )   
            },      
            {       
                221,    
                new Item    
                    (   
                     id: 367, 
                     name: "Odd Keystone",
                     identifier: "General items",
                     description: "A vital item that is needed to keep a stone tower from collapsing. Voices can be heard from it occasionally."
                     )   
            },      
            {       
                222,    
                new Item    
                    (   
                     id: 364, 
                     name: "Old Amber",
                     identifier: "General items",
                     description: "A piece of amber that contains the genetic material of an ancient Pokémon. It is clear with a reddish tint."
                     )   
            },      
            {       
                223,    
                new Item    
                    (   
                     id: 195, 
                     name: "Old Gateau",
                     identifier: "Medicine",
                     description: "Old Chateau's hidden specialty. It heals all the status problems of a single Pokémon."
                     )   
            },      
            {       
                224,    
                new Item    
                    (   
                     id: 245, 
                     name: "Oran Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it heals the user by just 10 HP."
                     )   
            },      
            {       
                225,    
                new Item    
                    (   
                     id: 349, 
                     name: "Oval Stone",
                     identifier: "General items",
                     description: "A peculiar stone that makes certain species of Pokémon evolve. It is shaped like an egg."
                     )   
            },      
            {       
                226,    
                new Item    
                    (   
                     id: 214, 
                     name: "PP Max",
                     identifier: "Medicine",
                     description: "It maximally raises the top PP of a selected move that has been learned by the target Pokémon."
                     )   
            },      
            {       
                227,    
                new Item    
                    (   
                     id: 212, 
                     name: "PP Up",
                     identifier: "Medicine",
                     description: "It slightly raises the maximum PP of a selected move that has been learned by the target Pokémon."
                     )   
            },      
            {       
                228,    
                new Item    
                    (   
                     id: 271, 
                     name: "Pamtre Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                229,    
                new Item    
                    (   
                     id: 151, 
                     name: "Park Ball",
                     identifier: "Pokeballs",
                     description: "A special Poké Ball for the Pal Park."
                     )   
            },      
            {       
                230,    
                new Item    
                    (   
                     id: 191, 
                     name: "Parlyz Heal",
                     identifier: "Medicine",
                     description: "A spray-type medicine. It eliminates paralysis from a single Pokémon."
                     )   
            },      
            {       
                231,    
                new Item    
                    (   
                     id: 45, 
                     name: "Pass Orb",
                     identifier: "Hold items",
                     description: "A mysterious orb containing the power of the Unova region, to be used when generating Pass Power."
                     )   
            },      
            {       
                232,    
                new Item    
                    (   
                     id: 277, 
                     name: "Passho Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Water-type attack against the holding Pokémon."
                     )   
            },      
            {       
                233,    
                new Item    
                    (   
                     id: 285, 
                     name: "Payapa Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Psychic-type attack against the holding Pokémon."
                     )   
            },      
            {       
                234,    
                new Item    
                    (   
                     id: 382, 
                     name: "Pearl",
                     identifier: "General items",
                     description: "A somewhat-small pearl that sparkles in a pretty silver color. It can be sold cheaply to shops."
                     )   
            },      
            {       
                235,    
                new Item    
                    (   
                     id: 391, 
                     name: "Pearl String",
                     identifier: "General items",
                     description: "Very large pearls that sparkle in a pretty silver color. A maniac will buy them for a high price."
                     )   
            },      
            {       
                236,    
                new Item    
                    (   
                     id: 241, 
                     name: "Pecha Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it recovers from poison."
                     )   
            },      
            {       
                237,    
                new Item    
                    (   
                     id: 246, 
                     name: "Persim Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it recovers from confusion."
                     )   
            },      
            {       
                238,    
                new Item    
                    (   
                     id: 297, 
                     name: "Petaya Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it raises its Sp. Atk stat in a pinch."
                     )   
            },      
            {       
                239,    
                new Item    
                    (   
                     id: 265, 
                     name: "Pinap Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                240,    
                new Item    
                    (   
                     id: 422, 
                     name: "Pink Scarf",
                     identifier: "General items",
                     description: "An item to be held by a Pokémon. It boosts the Cute aspect of the holder in a Contest."
                     )   
            },      
            {       
                241,    
                new Item    
                    (   
                     id: 369, 
                     name: "Plume Fossil",
                     identifier: "General items",
                     description: "A fossil of an ancient Pokémon that flew in the sky in ancient times. It appears to be part of its wing."
                     )   
            },      
            {       
                242,    
                new Item    
                    (   
                     id: 412, 
                     name: "Pnk Apricorn",
                     identifier: "General items",
                     description: "A pink Apricorn. It has a nice, sweet scent."
                     )   
            },      
            {       
                243,    
                new Item    
                    (   
                     id: 56, 
                     name: "Poison Barb",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a small, poisonous barb that ups the power of Poison-type moves."
                     )   
            },      
            {       
                244,    
                new Item    
                    (   
                     id: 92, 
                     name: "Poison Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of poison. When held, it strengthens the power of a Poison-type move only once."
                     )   
            },      
            {       
                245,    
                new Item    
                    (   
                     id: 149, 
                     name: "Poké Ball",
                     identifier: "Pokeballs",
                     description: "A device for catching wild Pokémon. It is thrown like a ball at the target. It is designed as a capsule system."
                     )   
            },      
            {       
                246,    
                new Item    
                    (   
                     id: 370, 
                     name: "Poké Doll",
                     identifier: "General items",
                     description: "A doll that attracts Pokémon. Use it to flee from any battle with a wild Pokémon."
                     )   
            },      
            {       
                247,    
                new Item    
                    (   
                     id: 379, 
                     name: "Poké Toy",
                     identifier: "General items",
                     description: "An item that attracts Pokémon. Use it to flee from any battle with a wild Pokémon."
                     )   
            },      
            {       
                248,    
                new Item    
                    (   
                     id: 255, 
                     name: "Pomeg Berry",
                     identifier: "Berries",
                     description: "Using it on a Pokémon makes it more friendly, but it also lowers its base HP."
                     )   
            },      
            {       
                249,    
                new Item    
                    (   
                     id: 173, 
                     name: "Potion",
                     identifier: "Medicine",
                     description: "A spray-type medicine for wounds. It restores the HP of one Pokémon by just 20 points."
                     )   
            },      
            {       
                250,    
                new Item    
                    (   
                     id: 112, 
                     name: "Power Anklet",
                     identifier: "Hold items",
                     description: "A Pokémon held item that promotes Speed gain on leveling, but reduces the Speed stat."
                     )   
            },      
            {       
                251,    
                new Item    
                    (   
                     id: 111, 
                     name: "Power Band",
                     identifier: "Hold items",
                     description: "A Pokémon held item that promotes Sp. Def gain on leveling, but reduces the Speed stat."
                     )   
            },      
            {       
                252,    
                new Item    
                    (   
                     id: 109, 
                     name: "Power Belt",
                     identifier: "Hold items",
                     description: "A Pokémon held item that promotes Defense gain on leveling, but reduces the Speed stat."
                     )   
            },      
            {       
                253,    
                new Item    
                    (   
                     id: 108, 
                     name: "Power Bracer",
                     identifier: "Hold items",
                     description: "A Pokémon held item that promotes Attack gain on leveling, but reduces the Speed stat."
                     )   
            },      
            {       
                254,    
                new Item    
                    (   
                     id: 18, 
                     name: "Power Herb",
                     identifier: "Hold items",
                     description: "A single-use item to be held by a Pokémon. It allows the immediate use of a move that charges on the first turn."
                     )   
            },      
            {       
                255,    
                new Item    
                    (   
                     id: 110, 
                     name: "Power Lens",
                     identifier: "Hold items",
                     description: "A Pokémon held item that promotes Sp. Atk gain on leveling, but reduces the Speed stat."
                     )   
            },      
            {       
                256,    
                new Item    
                    (   
                     id: 113, 
                     name: "Power Weight",
                     identifier: "Hold items",
                     description: "A Pokémon held item that promotes HP gain on leveling, but reduces the Speed stat."
                     )   
            },      
            {       
                257,    
                new Item    
                    (   
                     id: 159, 
                     name: "Premier Ball",
                     identifier: "Pokeballs",
                     description: "A somewhat rare Poké Ball that has been specially made to commemorate an event of some sort."
                     )   
            },      
            {       
                258,    
                new Item    
                    (   
                     id: 388, 
                     name: "Pretty Wing",
                     identifier: "General items",
                     description: "Though this feather is beautiful, it's just a regular feather and has no effect on Pokémon."
                     )   
            },      
            {       
                259,    
                new Item    
                    (   
                     id: 358, 
                     name: "Prism Scale",
                     identifier: "General items",
                     description: "A mysterious scale that evolves certain Pokémon. It shines in rainbow colors."
                     )   
            },      
            {       
                260,    
                new Item    
                    (   
                     id: 352, 
                     name: "Protector",
                     identifier: "General items",
                     description: "A protective item of some sort. It is extremely stiff and heavy. It is loved by a certain Pokémon."
                     )   
            },      
            {       
                261,    
                new Item    
                    (   
                     id: 206, 
                     name: "Protein",
                     identifier: "Medicine",
                     description: "A nutritious drink for Pokémon. It raises the base Attack stat of a single Pokémon."
                     )   
            },      
            {       
                262,    
                new Item    
                    (   
                     id: 95, 
                     name: "Psychic Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of the mind. When held, it strengthens the power of a Psychic-type move only once."
                     )   
            },      
            {       
                263,    
                new Item    
                    (   
                     id: 121, 
                     name: "Pure Incense",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It helps keep wild Pokémon away if the holder is the first one in the party."
                     )   
            },      
            {       
                264,    
                new Item    
                    (   
                     id: 257, 
                     name: "Qualot Berry",
                     identifier: "Berries",
                     description: "Using it on a Pokémon makes it more friendly, but it also lowers its base Defense stat."
                     )   
            },      
            {       
                265,    
                new Item    
                    (   
                     id: 162, 
                     name: "Quick Ball",
                     identifier: "Pokeballs",
                     description: "A somewhat different Poké Ball that provides a better catch rate if it is used at the start of a wild encounter."
                     )   
            },      
            {       
                266,    
                new Item    
                    (   
                     id: 3, 
                     name: "Quick Claw",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. A light, sharp claw that lets the bearer move first occasionally."
                     )   
            },      
            {       
                267,    
                new Item    
                    (   
                     id: 139, 
                     name: "Quick Powder",
                     identifier: "Hold items",
                     description: "An item to be held by DITTO. Extremely fine yet hard, this odd powder boosts the Speed stat."
                     )   
            },      
            {       
                268,    
                new Item    
                    (   
                     id: 268, 
                     name: "Rabuta Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                269,    
                new Item    
                    (   
                     id: 387, 
                     name: "Rare Bone",
                     identifier: "General items",
                     description: "A bone that is extremely valuable for Pokémon archeology. It can be sold for a high price to shops."
                     )   
            },      
            {       
                270,    
                new Item    
                    (   
                     id: 211, 
                     name: "Rare Candy",
                     identifier: "Medicine",
                     description: "A candy that is packed with energy. It raises the level of a single Pokémon by one."
                     )   
            },      
            {       
                271,    
                new Item    
                    (   
                     id: 242, 
                     name: "Rawst Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it recovers from a burn."
                     )   
            },      
            {       
                272,    
                new Item    
                    (   
                     id: 32, 
                     name: "Razor Claw",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a sharply hooked claw that ups the holder's critical-hit ratio."
                     )   
            },      
            {       
                273,    
                new Item    
                    (   
                     id: 33, 
                     name: "Razor Fang",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It may make foes and allies flinch when the holder inflicts damage."
                     )   
            },      
            {       
                274,    
                new Item    
                    (   
                     id: 261, 
                     name: "Razz Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                275,    
                new Item    
                    (   
                     id: 356, 
                     name: "Reaper Cloth",
                     identifier: "General items",
                     description: "A cloth imbued with horrifyingly strong spiritual energy. It is loved by a certain Pokémon."
                     )   
            },      
            {       
                276,    
                new Item    
                    (   
                     id: 408, 
                     name: "Red Apricorn",
                     identifier: "General items",
                     description: "A red Apricorn. It assails your nostrils."
                     )   
            },      
            {       
                277,    
                new Item    
                    (   
                     id: 38, 
                     name: "Red Card",
                     identifier: "Hold items",
                     description: "A card with a mysterious power. When the holder is struck by a foe, the attacker is removed from battle."
                     )   
            },      
            {       
                278,    
                new Item    
                    (   
                     id: 427, 
                     name: "Red Flute",
                     identifier: "General items",
                     description: "A toy flute made from red glass. A maniac will buy it for a high price."
                     )   
            },      
            {       
                279,    
                new Item    
                    (   
                     id: 419, 
                     name: "Red Scarf",
                     identifier: "General items",
                     description: "An item to be held by a Pokémon. It boosts the Cool aspect of the holder in a Contest."
                     )   
            },      
            {       
                280,    
                new Item    
                    (   
                     id: 403, 
                     name: "Red Shard",
                     identifier: "General items",
                     description: "A small red shard. It appears to be from some sort of implement made long ago."
                     )   
            },      
            {       
                281,    
                new Item    
                    (   
                     id: 397, 
                     name: "Relic Band",
                     identifier: "General items",
                     description: "A bracelet made in a civilization about 3,000 years ago. A maniac will buy it for a high price."
                     )   
            },      
            {       
                282,    
                new Item    
                    (   
                     id: 393, 
                     name: "Relic Copper",
                     identifier: "General items",
                     description: "A copper coin used in a civilization about 3,000 years ago. A maniac will buy it for a high price."
                     )   
            },      
            {       
                283,    
                new Item    
                    (   
                     id: 400, 
                     name: "Relic Crown",
                     identifier: "General items",
                     description: "A crown made in a civilization about 3,000 years ago. A maniac will buy it for a high price."
                     )   
            },      
            {       
                284,    
                new Item    
                    (   
                     id: 395, 
                     name: "Relic Gold",
                     identifier: "General items",
                     description: "A gold coin used in a civilization about 3,000 years ago. A maniac will buy it for a high price."
                     )   
            },      
            {       
                285,    
                new Item    
                    (   
                     id: 394, 
                     name: "Relic Silver",
                     identifier: "General items",
                     description: "A silver coin used in a civilization about 3,000 years ago. A maniac will buy it for a high price."
                     )   
            },      
            {       
                286,    
                new Item    
                    (   
                     id: 398, 
                     name: "Relic Statue",
                     identifier: "General items",
                     description: "A stone figure made in a civilization about 3,000 years ago. A maniac will buy it for a high price."
                     )   
            },      
            {       
                287,    
                new Item    
                    (   
                     id: 396, 
                     name: "Relic Vase",
                     identifier: "General items",
                     description: "A vase made in a civilization about 3,000 years ago. A maniac will buy it for a high price."
                     )   
            },      
            {       
                288,    
                new Item    
                    (   
                     id: 156, 
                     name: "Repeat Ball",
                     identifier: "Pokeballs",
                     description: "A somewhat different Poké Ball that works especially well on Pokémon species that were previously caught."
                     )   
            },      
            {       
                289,    
                new Item    
                    (   
                     id: 377, 
                     name: "Repel",
                     identifier: "General items",
                     description: "An item that prevents weak wild Pokémon from appearing for 100 steps after its use."
                     )   
            },      
            {       
                290,    
                new Item    
                    (   
                     id: 338, 
                     name: "Reset Urge",
                     identifier: "Battle items",
                     description: "When used, it restores any stat changes of an ally Pokémon."
                     )   
            },      
            {       
                291,    
                new Item    
                    (   
                     id: 217, 
                     name: "Resist Wing",
                     identifier: "Medicine",
                     description: "An item for use on a Pokémon. It slightly increases the base Defense stat of a single Pokémon."
                     )   
            },      
            {       
                292,    
                new Item    
                    (   
                     id: 199, 
                     name: "Revival Herb",
                     identifier: "Medicine",
                     description: "A very bitter medicinal herb. It revives a fainted Pokémon, fully restoring its HP."
                     )   
            },      
            {       
                293,    
                new Item    
                    (   
                     id: 197, 
                     name: "Revive",
                     identifier: "Medicine",
                     description: "A medicine that revives a fainted Pokémon. It restores half the Pokémon's maximum HP."
                     )   
            },      
            {       
                294,    
                new Item    
                    (   
                     id: 279, 
                     name: "Rindo Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Grass-type attack against the holding Pokémon."
                     )   
            },      
            {       
                295,    
                new Item    
                    (   
                     id: 39, 
                     name: "Ring Target",
                     identifier: "Hold items",
                     description: "Moves that would otherwise have no effect will land on the Pokémon that holds it."
                     )   
            },      
            {       
                296,    
                new Item    
                    (   
                     id: 97, 
                     name: "Rock Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of rock. When held, it strengthens the power of a Rock-type move only once."
                     )   
            },      
            {       
                297,    
                new Item    
                    (   
                     id: 66, 
                     name: "Rock Incense",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is an exotic-smelling incense that boosts the power of Rock-type moves."
                     )   
            },      
            {       
                298,    
                new Item    
                    (   
                     id: 36, 
                     name: "Rocky Helmet",
                     identifier: "Hold items",
                     description: "If the holder of this item takes damage, the attacker will also be damaged upon contact."
                     )   
            },      
            {       
                299,    
                new Item    
                    (   
                     id: 360, 
                     name: "Root Fossil",
                     identifier: "General items",
                     description: "A fossil of an ancient Pokémon that lived in the sea. It appears to be part of a plant root."
                     )   
            },      
            {       
                300,    
                new Item    
                    (   
                     id: 68, 
                     name: "Rose Incense",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is an exotic-smelling incense that boosts the power of Grass-type moves."
                     )   
            },      
            {       
                301,    
                new Item    
                    (   
                     id: 305, 
                     name: "Rowap Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon and a special attack lands, the attacker also takes damage."
                     )   
            },      
            {       
                302,    
                new Item    
                    (   
                     id: 200, 
                     name: "Sacred Ash",
                     identifier: "Medicine",
                     description: "It revives all fainted Pokémon. In doing so, it also fully restores their HP."
                     )   
            },      
            {       
                303,    
                new Item    
                    (   
                     id: 150, 
                     name: "Safari Ball",
                     identifier: "Pokeballs",
                     description: "A special Poké Ball that is used only in the Great Marsh. It is decorated in a camouflage pattern."
                     )   
            },      
            {       
                304,    
                new Item    
                    (   
                     id: 296, 
                     name: "Salac Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it raises its Speed stat in a pinch."
                     )   
            },      
            {       
                305,    
                new Item    
                    (   
                     id: 8, 
                     name: "Scope Lens",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a lens that boosts the holder's critical-hit ratio."
                     )   
            },      
            {       
                306,    
                new Item    
                    (   
                     id: 64, 
                     name: "Sea Incense",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is incense with a curious aroma that boosts the power of Water-type moves."
                     )   
            },      
            {       
                307,    
                new Item    
                    (   
                     id: 55, 
                     name: "Sharp Beak",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a long, sharp beak that boosts the power of Flying-type moves."
                     )   
            },      
            {       
                308,    
                new Item    
                    (   
                     id: 30, 
                     name: "Shed Shell",
                     identifier: "Hold items",
                     description: "A tough, discarded carapace to be held by a Pokémon. It enables the holder to switch with a waiting Pokémon in battle."
                     )   
            },      
            {       
                309,    
                new Item    
                    (   
                     id: 10, 
                     name: "Shell Bell",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. The holder's HP is restored a little every time it inflicts damage."
                     )   
            },      
            {       
                310,    
                new Item    
                    (   
                     id: 346, 
                     name: "Shiny Stone",
                     identifier: "General items",
                     description: "A peculiar stone that makes certain species of Pokémon evolve. It shines with a dazzling light."
                     )   
            },      
            {       
                311,    
                new Item    
                    (   
                     id: 401, 
                     name: "Shoal Salt",
                     identifier: "General items",
                     description: "Pure salt that can be discovered deep inside the Shoal Cave. A maniac will buy it for a high price."
                     )   
            },      
            {       
                312,    
                new Item    
                    (   
                     id: 402, 
                     name: "Shoal Shell",
                     identifier: "General items",
                     description: "A pretty seashell that can be found deep inside the Shoal Cave. A maniac will buy it for a high price."
                     )   
            },      
            {       
                313,    
                new Item    
                    (   
                     id: 142, 
                     name: "Shock Drive",
                     identifier: "Hold items",
                     description: "A cassette to be held by Genesect. It changes Techno Blast to an Electric-type move."
                     )   
            },      
            {       
                314,    
                new Item    
                    (   
                     id: 283, 
                     name: "Shuca Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Ground-type attack against the holding Pokémon."
                     )   
            },      
            {       
                315,    
                new Item    
                    (   
                     id: 62, 
                     name: "Silk Scarf",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a sumptuous scarf that boosts the power of Normal-type moves."
                     )   
            },      
            {       
                316,    
                new Item    
                    (   
                     id: 46, 
                     name: "SilverPowder",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a shiny, silver powder that ups the power of Bug-type moves."
                     )   
            },      
            {       
                317,    
                new Item    
                    (   
                     id: 248, 
                     name: "Sitrus Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it heals the user's HP a little."
                     )   
            },      
            {       
                318,    
                new Item    
                    (   
                     id: 366, 
                     name: "Skull Fossil",
                     identifier: "General items",
                     description: "A fossil from a prehistoric Pokémon that lived on the land. It appears to be part of a head."
                     )   
            },      
            {       
                319,    
                new Item    
                    (   
                     id: 77, 
                     name: "Sky Plate",
                     identifier: "Hold items",
                     description: "Increases power of Flying-type moves. Changes Arceus' type to Flying."
                     )   
            },      
            {       
                320,    
                new Item    
                    (   
                     id: 6, 
                     name: "Smoke Ball",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It enables the holder to flee from any wild Pokémon without fail."
                     )   
            },      
            {       
                321,    
                new Item    
                    (   
                     id: 26, 
                     name: "Smooth Rock",
                     identifier: "Hold items",
                     description: "A Pokémon held item that extends the duration of the move Sandstorm used by the holder."
                     )   
            },      
            {       
                322,    
                new Item    
                    (   
                     id: 179, 
                     name: "Soda Pop",
                     identifier: "Medicine",
                     description: "A fizzy soda drink. It restores the HP of one POKÉMON by 60 points."
                     )   
            },      
            {       
                323,    
                new Item    
                    (   
                     id: 48, 
                     name: "Soft Sand",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a loose, silky sand that boosts the power of Ground-type moves."
                     )   
            },      
            {       
                324,    
                new Item    
                    (   
                     id: 115, 
                     name: "Soothe Bell",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a bell with a comforting chime that calms the holder and makes it friendly."
                     )   
            },      
            {       
                325,    
                new Item    
                    (   
                     id: 131, 
                     name: "Soul Dew",
                     identifier: "Hold items",
                     description: "A wondrous orb to be held by LATIOS or LATIAS. It raises both the Sp. Atk and Sp. Def stats."
                     )   
            },      
            {       
                326,    
                new Item    
                    (   
                     id: 58, 
                     name: "Spell Tag",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a sinister, eerie tag that boosts the power of Ghost-type moves."
                     )   
            },      
            {       
                327,    
                new Item    
                    (   
                     id: 270, 
                     name: "Spelon Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                328,    
                new Item    
                    (   
                     id: 70, 
                     name: "Splash Plate",
                     identifier: "Hold items",
                     description: "Increases power of Water-type moves. Changes Arceus' type to Water."
                     )   
            },      
            {       
                329,    
                new Item    
                    (   
                     id: 81, 
                     name: "Spooky Plate",
                     identifier: "Hold items",
                     description: "Increases power of Ghost-type moves. Changes Arceus' type to Ghost."
                     )   
            },      
            {       
                330,    
                new Item    
                    (   
                     id: 152, 
                     name: "Sport Ball",
                     identifier: "Pokeballs",
                     description: "A special Poké Ball for the Bug-Catching Contest."
                     )   
            },      
            {       
                331,    
                new Item    
                    (   
                     id: 417, 
                     name: "Stable Mulch",
                     identifier: "General items",
                     description: "A fertilizer to be spread on soft soil in regions where Berries are grown. A maniac will buy it for a high price."
                     )   
            },      
            {       
                332,    
                new Item    
                    (   
                     id: 385, 
                     name: "Star Piece",
                     identifier: "General items",
                     description: "A shard of a pretty gem that sparkles in a red color. It can be sold at a high price to shops."
                     )   
            },      
            {       
                333,    
                new Item    
                    (   
                     id: 384, 
                     name: "Stardust",
                     identifier: "General items",
                     description: "Lovely, red-colored sand with a loose, silky feel. It can be sold at a high price to shops."
                     )   
            },      
            {       
                334,    
                new Item    
                    (   
                     id: 300, 
                     name: "Starf Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it sharply raises one of its stats in a pinch."
                     )   
            },      
            {       
                335,    
                new Item    
                    (   
                     id: 100, 
                     name: "Steel Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of steel. When held, it strengthens the power of a Steel-type move only once."
                     )   
            },      
            {       
                336,    
                new Item    
                    (   
                     id: 138, 
                     name: "Stick",
                     identifier: "Hold items",
                     description: "An item to be held by FARFETCH'D. It is a very long and stiff stalk of leek that boosts the critical-hit ratio."
                     )   
            },      
            {       
                337,    
                new Item    
                    (   
                     id: 127, 
                     name: "Sticky Barb",
                     identifier: "Hold items",
                     description: "A held item that damages the holder on every turn. It may latch on to foes and allies that touch the holder."
                     )   
            },      
            {       
                338,    
                new Item    
                    (   
                     id: 80, 
                     name: "Stone Plate",
                     identifier: "Hold items",
                     description: "Increases power of Rock-type moves. Changes Arceus' type to Rock."
                     )   
            },      
            {       
                339,    
                new Item    
                    (   
                     id: 340, 
                     name: "Sun Stone",
                     identifier: "General items",
                     description: "A peculiar stone that makes certain species of POKÉMON evolve. It is as red as the sun."
                     )   
            },      
            {       
                340,    
                new Item    
                    (   
                     id: 177, 
                     name: "Super Potion",
                     identifier: "Medicine",
                     description: "A spray-type medicine for wounds. It restores the HP of one Pokémon by 50 points."
                     )   
            },      
            {       
                341,    
                new Item    
                    (   
                     id: 374, 
                     name: "Super Repel",
                     identifier: "General items",
                     description: "An item that prevents weak wild Pokémon from appearing for 200 steps after its use."
                     )   
            },      
            {       
                342,    
                new Item    
                    (   
                     id: 185, 
                     name: "Sweet Heart",
                     identifier: "Medicine",
                     description: "Very sweet chocolate. It restores the HP of one Pokémon by only 20 points."
                     )   
            },      
            {       
                343,    
                new Item    
                    (   
                     id: 220, 
                     name: "Swift Wing",
                     identifier: "Medicine",
                     description: "An item for use on a Pokémon. It slightly increases the base Speed stat of a single Pokémon."
                     )   
            },      
            {       
                344,    
                new Item    
                    (   
                     id: 237, 
                     name: "TM01",
                     identifier: "Machines",
                     description: "Teaches the move Mega Punch/DynamicPunch/Focus Punch/Hone Claws."
                     )   
            },      
            {       
                345,    
                new Item    
                    (   
                     id: 236, 
                     name: "TM02",
                     identifier: "Machines",
                     description: "Teaches the move Razor Wind/Headbutt/Dragon Claw."
                     )   
            },      
            {       
                346,    
                new Item    
                    (   
                     id: 232, 
                     name: "TM03",
                     identifier: "Machines",
                     description: "Teaches the move Swords Dance/Curse/Water Pulse/Psyshock."
                     )   
            },      
            {       
                347,    
                new Item    
                    (   
                     id: 232, 
                     name: "TM04",
                     identifier: "Machines",
                     description: "Teaches the move Whirlwind/Rollout/Calm Mind."
                     )   
            },      
            {       
                348,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM05",
                     identifier: "Machines",
                     description: "Teaches the move Mega Kick/Roar."
                     )   
            },      
            {       
                349,    
                new Item    
                    (   
                     id: 228, 
                     name: "TM06",
                     identifier: "Machines",
                     description: "Teaches the move Toxic."
                     )   
            },      
            {       
                350,    
                new Item    
                    (   
                     id: 226, 
                     name: "TM07",
                     identifier: "Machines",
                     description: "Teaches the move Horn Drill/Zap Cannon/Hail."
                     )   
            },      
            {       
                351,    
                new Item    
                    (   
                     id: 227, 
                     name: "TM08",
                     identifier: "Machines",
                     description: "Teaches the move Body Slam/Rock Smash/Bulk Up."
                     )   
            },      
            {       
                352,    
                new Item    
                    (   
                     id: 228, 
                     name: "TM09",
                     identifier: "Machines",
                     description: "Teaches the move Take Down/Psych Up/Bullet Seed/Venoshock."
                     )   
            },      
            {       
                353,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM10",
                     identifier: "Machines",
                     description: "Teaches the move Double-Edge/Hidden Power."
                     )   
            },      
            {       
                354,    
                new Item    
                    (   
                     id: 222, 
                     name: "TM11",
                     identifier: "Machines",
                     description: "Teaches the move BubbleBeam/Sunny Day."
                     )   
            },      
            {       
                355,    
                new Item    
                    (   
                     id: 237, 
                     name: "TM12",
                     identifier: "Machines",
                     description: "Teaches the move Water Gun/Sweet Scent/Taunt."
                     )   
            },      
            {       
                356,    
                new Item    
                    (   
                     id: 226, 
                     name: "TM13",
                     identifier: "Machines",
                     description: "Teaches the move Snore/Ice Beam."
                     )   
            },      
            {       
                357,    
                new Item    
                    (   
                     id: 226, 
                     name: "TM14",
                     identifier: "Machines",
                     description: "Teaches the move Blizzard."
                     )   
            },      
            {       
                358,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM15",
                     identifier: "Machines",
                     description: "Teaches the move Hyper Beam."
                     )   
            },      
            {       
                359,    
                new Item    
                    (   
                     id: 232, 
                     name: "TM16",
                     identifier: "Machines",
                     description: "Teaches the move Pay Day/Icy Wind/Light Screen."
                     )   
            },      
            {       
                360,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM17",
                     identifier: "Machines",
                     description: "Teaches the move Submission/Protect."
                     )   
            },      
            {       
                361,    
                new Item    
                    (   
                     id: 223, 
                     name: "TM18",
                     identifier: "Machines",
                     description: "Teaches the move Counter/Rain Dance."
                     )   
            },      
            {       
                362,    
                new Item    
                    (   
                     id: 232, 
                     name: "TM19",
                     identifier: "Machines",
                     description: "Teaches the move Seismic Toss/Giga Drain/Telekinesis/Roost."
                     )   
            },      
            {       
                363,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM20",
                     identifier: "Machines",
                     description: "Teaches the move Rage/Endure/Safeguard."
                     )   
            },      
            {       
                364,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM21",
                     identifier: "Machines",
                     description: "Teaches the move Mega Drain/Frustration."
                     )   
            },      
            {       
                365,    
                new Item    
                    (   
                     id: 225, 
                     name: "TM22",
                     identifier: "Machines",
                     description: "Teaches the move SolarBeam."
                     )   
            },      
            {       
                366,    
                new Item    
                    (   
                     id: 234, 
                     name: "TM23",
                     identifier: "Machines",
                     description: "Teaches the move Dragon Rage/Iron Tail/Smack Down."
                     )   
            },      
            {       
                367,    
                new Item    
                    (   
                     id: 224, 
                     name: "TM24",
                     identifier: "Machines",
                     description: "Teaches the move Thunderbolt/DragonBreath."
                     )   
            },      
            {       
                368,    
                new Item    
                    (   
                     id: 224, 
                     name: "TM25",
                     identifier: "Machines",
                     description: "Teaches the move Thunder."
                     )   
            },      
            {       
                369,    
                new Item    
                    (   
                     id: 229, 
                     name: "TM26",
                     identifier: "Machines",
                     description: "Teaches the move Earthquake."
                     )   
            },      
            {       
                370,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM27",
                     identifier: "Machines",
                     description: "Teaches the move Fissure/Return."
                     )   
            },      
            {       
                371,    
                new Item    
                    (   
                     id: 229, 
                     name: "TM28",
                     identifier: "Machines",
                     description: "Teaches the move Dig."
                     )   
            },      
            {       
                372,    
                new Item    
                    (   
                     id: 232, 
                     name: "TM29",
                     identifier: "Machines",
                     description: "Teaches the move Psychic."
                     )   
            },      
            {       
                373,    
                new Item    
                    (   
                     id: 235, 
                     name: "TM30",
                     identifier: "Machines",
                     description: "Teaches the move Teleport/Shadow Ball."
                     )   
            },      
            {       
                374,    
                new Item    
                    (   
                     id: 227, 
                     name: "TM31",
                     identifier: "Machines",
                     description: "Teaches the move Mimic/Mud-Slap/Brick Break."
                     )   
            },      
            {       
                375,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM32",
                     identifier: "Machines",
                     description: "Teaches the move Double Team."
                     )   
            },      
            {       
                376,    
                new Item    
                    (   
                     id: 232, 
                     name: "TM33",
                     identifier: "Machines",
                     description: "Teaches the move Ice Punch/Reflect."
                     )   
            },      
            {       
                377,    
                new Item    
                    (   
                     id: 228, 
                     name: "TM34",
                     identifier: "Machines",
                     description: "Teaches the move Bide/Swagger/Shock Wave/Sludge Wave."
                     )   
            },      
            {       
                378,    
                new Item    
                    (   
                     id: 222, 
                     name: "TM35",
                     identifier: "Machines",
                     description: "Teaches the move Metronome/Sleep Talk/Flamethrower."
                     )   
            },      
            {       
                379,    
                new Item    
                    (   
                     id: 228, 
                     name: "TM36",
                     identifier: "Machines",
                     description: "Teaches the move Selfdestruct/Sludge Bomb."
                     )   
            },      
            {       
                380,    
                new Item    
                    (   
                     id: 234, 
                     name: "TM37",
                     identifier: "Machines",
                     description: "Teaches the move Egg Bomb/Sandstorm."
                     )   
            },      
            {       
                381,    
                new Item    
                    (   
                     id: 222, 
                     name: "TM38",
                     identifier: "Machines",
                     description: "Teaches the move Fire Blast."
                     )   
            },      
            {       
                382,    
                new Item    
                    (   
                     id: 234, 
                     name: "TM39",
                     identifier: "Machines",
                     description: "Teaches the move Swift/Rock Tomb."
                     )   
            },      
            {       
                383,    
                new Item    
                    (   
                     id: 230, 
                     name: "TM40",
                     identifier: "Machines",
                     description: "Teaches the move Skull Bash/Defense Curl/Aerial Ace."
                     )   
            },      
            {       
                384,    
                new Item    
                    (   
                     id: 237, 
                     name: "TM41",
                     identifier: "Machines",
                     description: "Teaches the move Softboiled/ThunderPunch/Torment."
                     )   
            },      
            {       
                385,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM42",
                     identifier: "Machines",
                     description: "Teaches the move Dream Eater/Facade."
                     )   
            },      
            {       
                386,    
                new Item    
                    (   
                     id: 222, 
                     name: "TM43",
                     identifier: "Machines",
                     description: "Teaches the move Sky Attack/Detect/Secret Power/Flame Charge."
                     )   
            },      
            {       
                387,    
                new Item    
                    (   
                     id: 232, 
                     name: "TM44",
                     identifier: "Machines",
                     description: "Teaches the move Rest."
                     )   
            },      
            {       
                388,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM45",
                     identifier: "Machines",
                     description: "Teaches the move Thunder Wave/Attract."
                     )   
            },      
            {       
                389,    
                new Item    
                    (   
                     id: 237, 
                     name: "TM46",
                     identifier: "Machines",
                     description: "Teaches the move Psywave/Thief."
                     )   
            },      
            {       
                390,    
                new Item    
                    (   
                     id: 227, 
                     name: "TM47",
                     identifier: "Machines",
                     description: "Teaches the move Explosion/Steel Wing/Low Sweep."
                     )   
            },      
            {       
                391,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM48",
                     identifier: "Machines",
                     description: "Teaches the move Rock Slide/Fire Punch/Skill Swap/Round."
                     )   
            },      
            {       
                392,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM49",
                     identifier: "Machines",
                     description: "Teaches the move Tri Attack/Fury Cutter/Snatch/Echoed Voice."
                     )   
            },      
            {       
                393,    
                new Item    
                    (   
                     id: 222, 
                     name: "TM50",
                     identifier: "Machines",
                     description: "Teaches the move Substitute/Nightmare/Overheat."
                     )   
            },      
            {       
                394,    
                new Item    
                    (   
                     id: 232, 
                     name: "TM51",
                     identifier: "Machines",
                     description: "Teaches the move Roost/Ally Switch/Steel Wing."
                     )   
            },      
            {       
                395,    
                new Item    
                    (   
                     id: 227, 
                     name: "TM52",
                     identifier: "Machines",
                     description: "Teaches the move Focus Blast."
                     )   
            },      
            {       
                396,    
                new Item    
                    (   
                     id: 225, 
                     name: "TM53",
                     identifier: "Machines",
                     description: "Teaches the move Energy Ball."
                     )   
            },      
            {       
                397,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM54",
                     identifier: "Machines",
                     description: "Teaches the move False Swipe."
                     )   
            },      
            {       
                398,    
                new Item    
                    (   
                     id: 223, 
                     name: "TM55",
                     identifier: "Machines",
                     description: "Teaches the move Brine/Scald."
                     )   
            },      
            {       
                399,    
                new Item    
                    (   
                     id: 237, 
                     name: "TM56",
                     identifier: "Machines",
                     description: "Teaches the move Fling."
                     )   
            },      
            {       
                400,    
                new Item    
                    (   
                     id: 224, 
                     name: "TM57",
                     identifier: "Machines",
                     description: "Teaches the move Charge Beam."
                     )   
            },      
            {       
                401,    
                new Item    
                    (   
                     id: 230, 
                     name: "TM58",
                     identifier: "Machines",
                     description: "Teaches the move Endure/Sky Drop."
                     )   
            },      
            {       
                402,    
                new Item    
                    (   
                     id: 222, 
                     name: "TM59",
                     identifier: "Machines",
                     description: "Teaches the move Dragon Pulse/Incinerate."
                     )   
            },      
            {       
                403,    
                new Item    
                    (   
                     id: 237, 
                     name: "TM60",
                     identifier: "Machines",
                     description: "Teaches the move Drain Punch/Quash."
                     )   
            },      
            {       
                404,    
                new Item    
                    (   
                     id: 222, 
                     name: "TM61",
                     identifier: "Machines",
                     description: "Teaches the move Will-O-Wisp."
                     )   
            },      
            {       
                405,    
                new Item    
                    (   
                     id: 230, 
                     name: "TM62",
                     identifier: "Machines",
                     description: "Teaches the move Silver Wind/Acrobatics."
                     )   
            },      
            {       
                406,    
                new Item    
                    (   
                     id: 237, 
                     name: "TM63",
                     identifier: "Machines",
                     description: "Teaches the move Embargo."
                     )   
            },      
            {       
                407,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM64",
                     identifier: "Machines",
                     description: "Teaches the move Explosion."
                     )   
            },      
            {       
                408,    
                new Item    
                    (   
                     id: 235, 
                     name: "TM65",
                     identifier: "Machines",
                     description: "Teaches the move Shadow Claw."
                     )   
            },      
            {       
                409,    
                new Item    
                    (   
                     id: 237, 
                     name: "TM66",
                     identifier: "Machines",
                     description: "Teaches the move Payback."
                     )   
            },      
            {       
                410,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM67",
                     identifier: "Machines",
                     description: "Teaches the move Recycle/Retaliate."
                     )   
            },      
            {       
                411,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM68",
                     identifier: "Machines",
                     description: "Teaches the move Giga Impact."
                     )   
            },      
            {       
                412,    
                new Item    
                    (   
                     id: 234, 
                     name: "TM69",
                     identifier: "Machines",
                     description: "Teaches the move Rock Polish."
                     )   
            },      
            {       
                413,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM70",
                     identifier: "Machines",
                     description: "Teaches the move Flash."
                     )   
            },      
            {       
                414,    
                new Item    
                    (   
                     id: 234, 
                     name: "TM71",
                     identifier: "Machines",
                     description: "Teaches the move Stone Edge."
                     )   
            },      
            {       
                415,    
                new Item    
                    (   
                     id: 224, 
                     name: "TM72",
                     identifier: "Machines",
                     description: "Teaches the move Avalanche/Volt Switch."
                     )   
            },      
            {       
                416,    
                new Item    
                    (   
                     id: 224, 
                     name: "TM73",
                     identifier: "Machines",
                     description: "Teaches the move Thunder Wave."
                     )   
            },      
            {       
                417,    
                new Item    
                    (   
                     id: 238, 
                     name: "TM74",
                     identifier: "Machines",
                     description: "Teaches the move Gyro Ball."
                     )   
            },      
            {       
                418,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM75",
                     identifier: "Machines",
                     description: "Teaches the move Swords Dance."
                     )   
            },      
            {       
                419,    
                new Item    
                    (   
                     id: 233, 
                     name: "TM76",
                     identifier: "Machines",
                     description: "Teaches the move Stealth Rock/Struggle Bug."
                     )   
            },      
            {       
                420,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM77",
                     identifier: "Machines",
                     description: "Teaches the move Psych Up."
                     )   
            },      
            {       
                421,    
                new Item    
                    (   
                     id: 229, 
                     name: "TM78",
                     identifier: "Machines",
                     description: "Teaches the move Captivate/Bulldoze."
                     )   
            },      
            {       
                422,    
                new Item    
                    (   
                     id: 226, 
                     name: "TM79",
                     identifier: "Machines",
                     description: "Teaches the move Dark Pulse/Frost Breath."
                     )   
            },      
            {       
                423,    
                new Item    
                    (   
                     id: 234, 
                     name: "TM80",
                     identifier: "Machines",
                     description: "Teaches the move Rock Slide."
                     )   
            },      
            {       
                424,    
                new Item    
                    (   
                     id: 233, 
                     name: "TM81",
                     identifier: "Machines",
                     description: "Teaches the move X-Scissor."
                     )   
            },      
            {       
                425,    
                new Item    
                    (   
                     id: 236, 
                     name: "TM82",
                     identifier: "Machines",
                     description: "Teaches the move Sleep Talk/Dragon Tail."
                     )   
            },      
            {       
                426,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM83",
                     identifier: "Machines",
                     description: "Teaches the move Natural Gift/Work Up/Infestation."
                     )   
            },      
            {       
                427,    
                new Item    
                    (   
                     id: 228, 
                     name: "TM84",
                     identifier: "Machines",
                     description: "Teaches the move Poison Jab."
                     )   
            },      
            {       
                428,    
                new Item    
                    (   
                     id: 232, 
                     name: "TM85",
                     identifier: "Machines",
                     description: "Teaches the move Dream Eater."
                     )   
            },      
            {       
                429,    
                new Item    
                    (   
                     id: 225, 
                     name: "TM86",
                     identifier: "Machines",
                     description: "Teaches the move Grass Knot."
                     )   
            },      
            {       
                430,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM87",
                     identifier: "Machines",
                     description: "Teaches the move Swagger."
                     )   
            },      
            {       
                431,    
                new Item    
                    (   
                     id: 230, 
                     name: "TM88",
                     identifier: "Machines",
                     description: "Teaches the move Pluck/Sleep Talk."
                     )   
            },      
            {       
                432,    
                new Item    
                    (   
                     id: 233, 
                     name: "TM89",
                     identifier: "Machines",
                     description: "Teaches the move U-turn."
                     )   
            },      
            {       
                433,    
                new Item    
                    (   
                     id: 221, 
                     name: "TM90",
                     identifier: "Machines",
                     description: "Teaches the move Substitute."
                     )   
            },      
            {       
                434,    
                new Item    
                    (   
                     id: 238, 
                     name: "TM91",
                     identifier: "Machines",
                     description: "Teaches the move Flash Cannon."
                     )   
            },      
            {       
                435,    
                new Item    
                    (   
                     id: 232, 
                     name: "TM92",
                     identifier: "Machines",
                     description: "Teaches the move Trick Room."
                     )   
            },      
            {       
                436,    
                new Item    
                    (   
                     id: 224, 
                     name: "TM93",
                     identifier: "Machines",
                     description: "Teaches the move Wild Charge."
                     )   
            },      
            {       
                437,    
                new Item    
                    (   
                     id: 227, 
                     name: "TM94",
                     identifier: "Machines",
                     description: "Teaches the move Rock Smash."
                     )   
            },      
            {       
                438,    
                new Item    
                    (   
                     id: 237, 
                     name: "TM95",
                     identifier: "Machines",
                     description: "Teaches the move Snarl."
                     )   
            },      
            {       
                439,    
                new Item    
                    (   
                     id: 260, 
                     name: "Tamato Berry",
                     identifier: "Berries",
                     description: "Using it on a Pokémon makes it more friendly, but it also lowers its base Speed stat."
                     )   
            },      
            {       
                440,    
                new Item    
                    (   
                     id: 286, 
                     name: "Tanga Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Bug-type attack against the holding Pokémon."
                     )   
            },      
            {       
                441,    
                new Item    
                    (   
                     id: 137, 
                     name: "Thick Club",
                     identifier: "Hold items",
                     description: "An item to be held by CUBONE or MAROWAK. It is a hard bone of some sort that boosts the Attack stat."
                     )   
            },      
            {       
                442,    
                new Item    
                    (   
                     id: 343, 
                     name: "Thunderstone",
                     identifier: "General items",
                     description: "A peculiar stone that makes certain species of POKÉMON evolve. It has a thunderbolt pattern."
                     )   
            },      
            {       
                443,    
                new Item    
                    (   
                     id: 157, 
                     name: "Timer Ball",
                     identifier: "Pokeballs",
                     description: "A somewhat different BALL that becomes progressively better the more turns there are in a battle."
                     )   
            },      
            {       
                444,    
                new Item    
                    (   
                     id: 380, 
                     name: "TinyMushroom",
                     identifier: "General items",
                     description: "A small and rare mushroom. It is sought after by collectors."
                     )   
            },      
            {       
                445,    
                new Item    
                    (   
                     id: 122, 
                     name: "Toxic Orb",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a bizarre orb that badly poisons the holder in battle."
                     )   
            },      
            {       
                446,    
                new Item    
                    (   
                     id: 75, 
                     name: "Toxic Plate",
                     identifier: "Hold items",
                     description: "Increases power of Poison-type moves. Changes Arceus' type to Poison."
                     )   
            },      
            {       
                447,    
                new Item    
                    (   
                     id: 59, 
                     name: "TwistedSpoon",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a spoon imbued with telekinetic power that boosts Psychic-type moves."
                     )   
            },      
            {       
                448,    
                new Item    
                    (   
                     id: 146, 
                     name: "Ultra Ball",
                     identifier: "Pokeballs",
                     description: "An ultra-performance Ball that provides a higher Pokémon catch rate than a Great Ball."
                     )   
            },      
            {       
                449,    
                new Item    
                    (   
                     id: 351, 
                     name: "Up-Grade",
                     identifier: "General items",
                     description: "A transparent device filled with all sorts of data. It was produced by Silph Co."
                     )   
            },      
            {       
                450,    
                new Item    
                    (   
                     id: 278, 
                     name: "Wacan Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Electric-type attack against the holding Pokémon."
                     )   
            },      
            {       
                451,    
                new Item    
                    (   
                     id: 87, 
                     name: "Water Gem",
                     identifier: "Hold items",
                     description: "A gem with an essence of water. When held, it strengthens the power of a Water-type move only once."
                     )   
            },      
            {       
                452,    
                new Item    
                    (   
                     id: 344, 
                     name: "Water Stone",
                     identifier: "General items",
                     description: "A peculiar stone that makes certain species of Pokémon evolve. It is a clear, light blue."
                     )   
            },      
            {       
                453,    
                new Item    
                    (   
                     id: 272, 
                     name: "Watmel Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                454,    
                new Item    
                    (   
                     id: 67, 
                     name: "Wave Incense",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is incense with a curious aroma that boosts the power of Water-type moves."
                     )   
            },      
            {       
                455,    
                new Item    
                    (   
                     id: 264, 
                     name: "Wepear Berry",
                     identifier: "Berries",
                     description: "A Berry which is very rare in the Unova region. A maniac will buy it for a high price."
                     )   
            },      
            {       
                456,    
                new Item    
                    (   
                     id: 373, 
                     name: "White Flute",
                     identifier: "General items",
                     description: "A toy flute made from white glass. A maniac will buy it for a high price."
                     )   
            },      
            {       
                457,    
                new Item    
                    (   
                     id: 2, 
                     name: "White Herb",
                     identifier: "Hold items",
                     description: "An item to be held by a POKÉMON. It restores any lowered stat in battle. It can be used only once."
                     )   
            },      
            {       
                458,    
                new Item    
                    (   
                     id: 413, 
                     name: "Wht Apricorn",
                     identifier: "General items",
                     description: "A white Apricorn. It doesn't smell like anything."
                     )   
            },      
            {       
                459,    
                new Item    
                    (   
                     id: 12, 
                     name: "Wide Lens",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a magnifying lens that slightly boosts the accuracy of moves."
                     )   
            },      
            {       
                460,    
                new Item    
                    (   
                     id: 250, 
                     name: "Wiki Berry",
                     identifier: "Berries",
                     description: "If held by a Pokémon, it restores the user's HP in a pinch, but will cause confusion if it hates the taste."
                     )   
            },      
            {       
                461,    
                new Item    
                    (   
                     id: 14, 
                     name: "Wise Glasses",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. It is a thick pair of glasses that slightly boosts the power of special moves."
                     )   
            },      
            {       
                462,    
                new Item    
                    (   
                     id: 311, 
                     name: "X Accuracy",
                     identifier: "Battle items",
                     description: "An item that raises the accuracy of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                463,    
                new Item    
                    (   
                     id: 321, 
                     name: "X Accuracy 2",
                     identifier: "Battle items",
                     description: "It sharply raises the accuracy of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                464,    
                new Item    
                    (   
                     id: 327, 
                     name: "X Accuracy 3",
                     identifier: "Battle items",
                     description: "It drastically raises the accuracy of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                465,    
                new Item    
                    (   
                     id: 333, 
                     name: "X Accuracy 6",
                     identifier: "Battle items",
                     description: "It raises the accuracy of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                466,    
                new Item    
                    (   
                     id: 308, 
                     name: "X Attack",
                     identifier: "Battle items",
                     description: "An item that raises the Attack stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                467,    
                new Item    
                    (   
                     id: 320, 
                     name: "X Attack 2",
                     identifier: "Battle items",
                     description: "It sharply raises the Attack stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                468,    
                new Item    
                    (   
                     id: 326, 
                     name: "X Attack 3",
                     identifier: "Battle items",
                     description: "It drastically raises the Attack stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                469,    
                new Item    
                    (   
                     id: 332, 
                     name: "X Attack 6",
                     identifier: "Battle items",
                     description: "It raises the Attack stat of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                470,    
                new Item    
                    (   
                     id: 309, 
                     name: "X Defend",
                     identifier: "Battle items",
                     description: "An item that raises the Defense stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                471,    
                new Item    
                    (   
                     id: 319, 
                     name: "X Defend 2",
                     identifier: "Battle items",
                     description: "It sharply raises the Defense stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                472,    
                new Item    
                    (   
                     id: 325, 
                     name: "X Defend 3",
                     identifier: "Battle items",
                     description: "It drastically raises the Defense stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                473,    
                new Item    
                    (   
                     id: 331, 
                     name: "X Defend 6",
                     identifier: "Battle items",
                     description: "It raises the Defense stat of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                474,    
                new Item    
                    (   
                     id: 313, 
                     name: "X Sp. Def",
                     identifier: "Battle items",
                     description: "An item that raises the Sp. Def stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                475,    
                new Item    
                    (   
                     id: 318, 
                     name: "X Sp. Def 2",
                     identifier: "Battle items",
                     description: "It sharply raises the Sp. Def stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                476,    
                new Item    
                    (   
                     id: 324, 
                     name: "X Sp. Def 3",
                     identifier: "Battle items",
                     description: "It drastically raises the Sp. Def stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                477,    
                new Item    
                    (   
                     id: 330, 
                     name: "X Sp. Def 6",
                     identifier: "Battle items",
                     description: "It raises the Sp. Def stat of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                478,    
                new Item    
                    (   
                     id: 312, 
                     name: "X Special",
                     identifier: "Battle items",
                     description: "An item that raises the Sp. Atk stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                479,    
                new Item    
                    (   
                     id: 317, 
                     name: "X Special 2",
                     identifier: "Battle items",
                     description: "It sharply raises the Sp. Atk stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                480,    
                new Item    
                    (   
                     id: 323, 
                     name: "X Special 3",
                     identifier: "Battle items",
                     description: "It drastically raises the Sp. Atk stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                481,    
                new Item    
                    (   
                     id: 329, 
                     name: "X Special 6",
                     identifier: "Battle items",
                     description: "It raises the Sp. Atk stat of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                482,    
                new Item    
                    (   
                     id: 310, 
                     name: "X Speed",
                     identifier: "Battle items",
                     description: "An item that raises the Speed stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                483,    
                new Item    
                    (   
                     id: 316, 
                     name: "X Speed 2",
                     identifier: "Battle items",
                     description: "It sharply raises the Speed stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                484,    
                new Item    
                    (   
                     id: 322, 
                     name: "X Speed 3",
                     identifier: "Battle items",
                     description: "It drastically raises the Speed stat of a Pokémon in battle. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                485,    
                new Item    
                    (   
                     id: 328, 
                     name: "X Speed 6",
                     identifier: "Battle items",
                     description: "It raises the Speed stat of a Pokémon in battle immensely. It wears off if the Pokémon is withdrawn."
                     )   
            },      
            {       
                486,    
                new Item    
                    (   
                     id: 280, 
                     name: "Yache Berry",
                     identifier: "Berries",
                     description: "Weakens a supereffective Ice-type attack against the holding Pokémon."
                     )   
            },      
            {       
                487,    
                new Item    
                    (   
                     id: 426, 
                     name: "Yellow Flute",
                     identifier: "General items",
                     description: "A toy flute made from yellow glass. A maniac will buy it for a high price."
                     )   
            },      
            {       
                488,    
                new Item    
                    (   
                     id: 424, 
                     name: "Yellow Scarf",
                     identifier: "General items",
                     description: "An item to be held by a Pokémon. It boosts the Tough aspect of the holder in a Contest."
                     )   
            },      
            {       
                489,    
                new Item    
                    (   
                     id: 405, 
                     name: "Yellow Shard",
                     identifier: "General items",
                     description: "A small yellow shard. It appears to be from some sort of implement made long ago."
                     )   
            },      
            {       
                490,    
                new Item    
                    (   
                     id: 410, 
                     name: "Ylw Apricorn",
                     identifier: "General items",
                     description: "A yellow Apricorn. It has an invigorating scent."
                     )   
            },      
            {       
                491,    
                new Item    
                    (   
                     id: 71, 
                     name: "Zap Plate",
                     identifier: "Hold items",
                     description: "Increases power of Electric-type moves. Changes Arceus' type to Electric."
                     )   
            },      
            {       
                492,    
                new Item    
                    (   
                     id: 213, 
                     name: "Zinc",
                     identifier: "Medicine",
                     description: "A nutritious drink for Pokémon. It raises the base Sp. Def (Special Defense) stat of a single Pokémon."
                     )   
            },      
            {       
                493,    
                new Item    
                    (   
                     id: 20,
                     name: "Zoom Lens",
                     identifier: "Hold items",
                     description: "An item to be held by a Pokémon. If the holder moves after its target, its accuracy will be boosted."
                     )   
            }       

        };
    }
}