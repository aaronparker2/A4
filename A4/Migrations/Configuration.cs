
namespace A4.Migrations
{
    using A4.Models;
    using A4.DAL;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<A4.DAL.CharacterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CharacterContext context)
        {

            var characters = new List<Character>
            {
                new Character{CharacterName="Hulk",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="The Increcible Hulk",Weight=1400,Height=90,
                    Description ="The Hulk possesses the capacity for nearly limitless physical strength. The gamma radiation that mutated the Hulk's body fortified his cellular structure and added, from some as yet unknown source, over 800 pounds of bone marrow and tissue to his body."},
                new Character{CharacterName="Thor",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="The Avengers",Weight=209,Height=75,
                    Description ="Thor's principal weapon is the enchanted hammer Mjolnir, one of the most formidable weapons known to man or god. Among the hammer's various enchantments are its indestructibility and the ability to summon all the elements of storm (wind, rain, thunder, and lightning). His hammer can be thrown both as a means of flight, and as a weapon that always returns to its wielder's hand. Thor's superhuman strength is matched with an immunity to all human diseases, superhuman speed, agility, and simulated flight when he hurls his enchanted hammer Mjolnir."},
                new Character{CharacterName="Spiderman",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="The Amazing Spiderman",Weight=160,Height=70,
                    Description ="Spider-Man possesses superhuman strength, reflexes, and equilibrium; the ability to cause parts of his body to stick with great tenacity to most surfaces; and a subconscious premonitional 'danger' sence. The irradiated Common House Spider (Achaearanea tepidariorum) which bit Peter Parker was apparently already mutated from prior exposure to certain frequencies of radiation and received a final, lethal dose during Parker's attendance of the exhibition. The radioactive, complex mutagenic enzymes in the spider's blood that were transferred at the time of the bite triggered numberous body-wide mutagenic changes within Parker."},
                new Character{CharacterName="The Thing",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="Fantastic Four",Weight=500,Height=72,
                    Description ="The Thing possesses superhuman strength, endurance, and durability. The mutagenic, specific-frequency cosmic ray bombardment caused his musculature, bone structure, internal organ composition, soft tissue structure, and skin to greatly increase in toughness and density. The Thing can exert himself at high levels for about an hour before the build-up of fatigue poisons in his blood impairs his strength. His reflexes have remained at their above average human levels despite his greater mass. The Thing's lungs are of greater volume and efficiency than a normal man's, enabling him to hold his breath underwater for up to nine minutes, The Thing's five senses can withstand greater amounts of sensory stimuli than he could when he was a normal human being, with no reduced sensitivity."},
                new Character{CharacterName="Silver Surfer",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="Silver Surfer",Weight=225,Height=76,
                    Description ="The Silver Surfer can endow himself with Class 100 strength, enabling him to lift (press) over 100 tons. He possesses the Power Cosmic which he can use to generate powerful force blasts or to rearrange molecules. The Surfer travels on a 'surfboard' which responds to his mental commands and is as indestructible as he is. He has a Cosmic Awareness which allows him to feel energy around him. "},
                new Character{CharacterName="Daredevil",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="Daredevil",Weight=200,Height=72,
                    Description ="Daredevil possesses the normal human strength of a man his age, height, and build who engages in intensive regular exercise. Daredevil's five sense are heightened to beyond that of even superhumanly enhanced sense. Although Murdock is blind, he can 'see' by means of his 'radar sense', which acts not unlike sonar. Daredevil is an Olympic level athlete and gymnast, possessing extraordinary agility, endurance, skill and balance. Daredevil's unique fighting style (a blend of ninjitsu, judo and American-style boxing) makes effective use of his Billy Club, which is used as both a baton and grappling hook."},
                new Character{CharacterName="Wolverine",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="X-Men",Weight=300,Height=63,
                    Description ="Wolverine is a mutant with a number of enhancements to his physiology. Wolverine possesses heightened senses, making him capable of seeing things at a maximum distance greater than that of a normal human. His hearing is enhanced in a similar manner, and he is able to recognize people and objects by scent, even if that person or object is hidden. Logan can use these enhanced senses to track anyone, with an impressive degree of success. He possesses retractable bone claws that are housed in his forearms," +
                " they are part of his skeleton system. At will Wolverine can release these claws through his skin between the knuckles on each hand. The skin between the knuckles tears and bleeds, but bleeding is quickly halted by his healing factor. The claws are naturally sharp and tougher than that of normal human bone structure. This allows Wolverine to be able to cut through most types of flesh and natural materials. (Note: While Wolverine possessed his adamantium skeleton, his claws were able to cut through almost any material without any fear of damage to the claws.)" +
                "Lastly, Wolverine possesses an accelerated healing factor based on his physiology. While most normal humans heal injuries over a long period of time, Wolverine's healing factor speeds up that natural process. Wolverine's natural healing has been advanced to the point where he can heal extensive injuries (such as broken limbs) in a matter of hours to days. This factor gives him a higher resistance to poisons and toxins, and he can recover from almost any injury. The more extensive the injury, the longer the healing time will be."},
                new Character{CharacterName="Colossus",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="X-Men",Weight=500,Height=90,
                    Description ="Colossus has agility, strength, speed, endurance, and reaction time superior to any Olympic athlete who ever competed. The Super-Soldier formula that he has metabolized has enhanced all of his bodily functions to the peak of human efficiency. Notably, his body eliminates the excessive build-up of fatigue-producing poisons in his muscles, granting him phenomenal endurance."},
                new Character{CharacterName="Captain America",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="The Avengers",Weight=220,Height=74,
                    Description ="Captain America has agility, strength, speed, endurance, and reaction time superior to any Olympic athlete who ever competed. The Super-Soldier formula that he has metabolized has enhanced all of his bodily functions to the peak of human efficiency. Notably, his body eliminates the excessive build-up of fatigue-producing poisons in his muscles, granting him phenomenal endurance. Captain America has mastered the martial art of American-style boxing and judo, and has combined these disciplines with his own unique hand-to-hand style of combat." +
                    " He engages in a daily regimen of rigorous exercise (including aerobics, weight lifting, gymnastics, and simulated combat) to keep himself in peek condition. Captain America is one of the finest human combatants Earth has ever known."},
                new Character{CharacterName="Venom",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="The Amazing Spiderman",Weight=795,Height=90,
                    Description ="The alien costume, which has grafted itself to the nervous system of Eddie Brock, somehow absorbed the powers of Spider-Man during its brief symbiotic relationship with him. These powers have now been transferred to Brock, so long as he wears the costume. Brock had conditioned himself to lift (press) almost 700 lbs. Before he came into contact with the costume. Once they merged, the costume added Spider-Man�s superhuman strength to Brock�s vast human strength, making him more powerful than Spider-Man. The alien costume also replicates Spider-Man�s ability to cling to walls by controlling the flux of inter-atomic attraction between molecular boundary layers. "+
                "Venom can also shoot strands of the alien�s substance in the form of 'webbing' at high pressure up to a distance of 70 feet. The alien�s substance seems to be composed of tough, flexible fibers of organic polymers, which regenerate swiftly after 'shedding.' The strands have extraordinary adhesive properties, which diminish rapidly once they abandon their living source. After about three hours, with no source to nourish them, the strands dry up like dead skin and dissolve into a powder. The strands possess a tensile strength of 125 pounds per square millimeter of cross section. " +
                "Venom also possesses an extrasensory ability similar to Spider-Man�s spider-sense. This response is not as complicated as Spider-Man�s inherent sense since the alien costume can detect danger from every direction and conduct Brock in plenty of time. It is not as efficient as Spider-Man�s spider-sense because it takes longer to communicate the danger, and Brock�s reflexes are not as fast as Spider-Man�s, even though they are enhanced by the alien costume. It is unknown whether Venom could dodge a gunshot or a barrage of bullets."},
                new Character{CharacterName="Electra",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="Daredevil",Weight=130,Height=69,
                    Description ="Electra possesses no superhuman abilities, Elektra is a consummate practitioner of the martial arts. She is a mistress of the skills of the ancient ninja of Japan, and an Olympic-level athlete and gymnast. Elektra wields a pair of three-pronged daggers called sais, though she also is proficient with, and makes use of, a multitude of martial-arts weaponry."},
                new Character{CharacterName="Storm",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="X-Men",Weight=127,Height=71,
                    Description ="Storm has the psionic ability to control the weather over limited areas. She can fly by creating winds strong enough to support her weight. Storm has limited immunity to extreme heat and cold."},
                new Character{CharacterName="Rogue",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="X-Men",Weight=120,Height=68,
                    Description ="Rogue possesses the superhuman ability to absorb the memories, knowledge, talents, personality, and physical abilities (whether superhuman or not) of another human being (or members of some sentient alien races) through physical contact of her skin with the skin of the other person. (Sometimes she also duplicates in herself outward physical characteristics of her victim.) The victim's abilities and memories are absorbed for a time sixty times longer than the amount of time Rogue was in physical contact with that person. The victim loses his or her abilities and memories for exactly the length of time that Rogue possesses them. Due to unknown factors Rogue has permanently absorbed certain superhuman powers from Ms. Marvel I. "},
                new Character{CharacterName="Invisible Woman",ReleaseDate=DateTime.Parse("2015-09-01"),ComicName="Fantastic Four",Weight=120,Height=66,
                    Description ="Susan Storm 'The Invisible Woman' psionic ability to manipulate ambient cosmic energy enables her to bend light around her body without distortion, thus rendering herself invisible. The cells of her body produce an unknown form of energy she can mentally project around other people and objects -- rending them invisible, as well. Richards' brain cells produce psionic force she can shape into relatively simple forms - such as rectangle planes, globes, cylinders, cones and domes. Also, she can mentally project protective fields that are highly resistant to concussive forces. And by projecting columns of psionic force beneath her, she can travel through the air. "},
            };
            characters.ForEach(s => context.Characters.AddOrUpdate(p => p.CharacterName, s));
            context.SaveChanges();
            var versions = new List<CharacterVersion>
            {
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Hulk").CharacterName,
                Version = "Savage Hulk"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Hulk").CharacterName,
                Version = "Gray Hulk"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Hulk").CharacterName,
                Version = "Red Hulk"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Hulk").CharacterName,
                Version = "Incredible Hulk"},

            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Thor").CharacterName,
                Version = "Asgardian Thor"},

            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Spiderman").CharacterName,
                Version = "Amazing Spiderman"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Spiderman").CharacterName,
                Version = "Spectacular Spiderman"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Spiderman").CharacterName,
                Version = "Scarlet Spider"},

            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "The Thing").CharacterName,
                Version = "Classic"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Silver Surfer").CharacterName,
                Version = "Black"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Daredevil").CharacterName,
                Version = "Dark"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Wolverine").CharacterName,
                Version = "Bone Claw"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Colossus").CharacterName,
                Version = "Classic"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Captain America").CharacterName,
                Version = "Classic"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Venom").CharacterName,
                Version = "License to kill"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Electra").CharacterName,
                Version = "Classic"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Storm").CharacterName,
                Version = "Extreme"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Rogue").CharacterName,
                Version = "Classic"},
            new CharacterVersion {CharacterName = characters.Single(c => c.CharacterName == "Invisible Woman").CharacterName,
                Version = "Classic"}

            };
            foreach (CharacterVersion e in versions)
            {
                var characterInDatabase = context.CharacterVersions.Where(
                s =>
                s.Character.CharacterName == e.CharacterName).SingleOrDefault();
                if (characterInDatabase == null)
                {
                    context.CharacterVersions.Add(e);
                }
            }
            context.SaveChanges();
        }
        //versions.ForEach(c => context.CharacterVersion.Add(c));
        //    context.SaveChanges();

            //var heroIdentitys = new List<HeroIdentity>
            //{
            //    new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Hulk").CharacterName,
            //        IdentityName = "Bruce Banner",
            //        Email = "bbanner@gmail.com"
            //    },
            //     new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Thor").CharacterName,
            //        IdentityName = "Thor Odinson",
            //        Email = "todinson@gmail.com"
            //    },
            //     new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Spiderman").CharacterName,
            //        IdentityName = "Peter Parker",
            //        Email = "pparker@gmail.com"
            //    },
            //    new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "The Thing").CharacterName,
            //        IdentityName = "Benjamin Grim",
            //        Email = "bgrim@gmail.com"
            //    },
            //    new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Silver Surfer").CharacterName,
            //        IdentityName = "Norrin Radd",
            //        Email = "nradd@gmail.com"
            //    },
            //    new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Daredevil").CharacterName,
            //        IdentityName = "Matt Murdock",
            //        Email = "mmurdock@gmail.com"
            //    },
            //       new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Wolverine").CharacterName,
            //        IdentityName = "James Howlett",
            //        Email = "jhowlett@gmail.com"
            //    },
            //    new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Colossus").CharacterName,
            //        IdentityName = "Peter Rasputin",
            //        Email = "prasputin@gmail.com"
            //    },
            //    new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Captain America").CharacterName,
            //        IdentityName = "Steve Rogers",
            //        Email = "srogers@gmail.com"
            //    },
            //    new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Venom").CharacterName,
            //        IdentityName = "Eddie Brock",
            //        Email = "ebrock@gmail.com"
            //    },
            //    new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Electra").CharacterName,
            //        IdentityName = "Elektra Natchios",
            //        Email = "enatchios@gmail.com"
            //    },
            //    new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Storm").CharacterName,
            //        IdentityName = "Bruce Banner",
            //        Email = "bbanner@gmail.com"
            //    },
            //    new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Rogue").CharacterName,
            //        IdentityName = "Bruce Banner",
            //        Email = "bbanner@gmail.com"
            //    },
            //     new HeroIdentity {
            //        CharacterName = characters.Single(s => s.CharacterName == "Invisible Woman").CharacterName,
            //        IdentityName = "Susan Storm",
            //        Email = "sstorm@gmail.com"
            //    }
            //};
            //heroIdentitys.ForEach(s => context.HeroIdentity.AddOrUpdate(p => p.CharacterName, s));

    }
}
