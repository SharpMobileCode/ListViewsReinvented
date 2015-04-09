using System.Threading.Tasks;
using System.Collections.Generic;

namespace ListViewsReinvented.Droid
{
    public static class CrewManifest
    {
        public static async Task<List<CrewMember>> GetAllCrewAsync()
        {
            return await Task.Factory.StartNew(() => GetAllCrew());
        }

        public static List<CrewMember> GetAllCrew()
        {
            var crewList = new List<CrewMember>();

            const int numberOfPermutations = 1;
            for(int i = 0; i < numberOfPermutations; i++)
            {
                crewList.Add(new CrewMember()
                {
                    Name = "Jean-Luc Picard",
                    Rank = "Captain",
                    Posting = "USS Enterprise-E",
                    Position = "Commanding Officer",
                    Species = "Human",
                    PhotoResourceId = Resource.Drawable.Picard,
                    Biography = "Jean-Luc Picard was born to Maurice and Yvette Picard in La Barre, France, on July 13, 2305, and dreamed of joining Starfleet. He and the rest of his family speak English, with English accents—the French language having become obscure by the 24th century, as mentioned in the Next Generation episode \"Code of Honor\". The young Picard failed his first Starfleet Academy entrance exam, and, upon admission, met with numerous ethical/scholastic difficulties during his cadet career, but (coached by groundskeeper Boothby) went on to flourish, developing a lifelong passion for archaeology, and became the first freshman to win the Academy marathon.[13] Shortly after graduation, Picard was stabbed in the heart by a Nausicaan, leaving the organ irreparable and requiring replacement with a parthenogenetic implant; this would prove near-fatal later.[13] Picard eventually served as first officer aboard the USS Stargazer, which he later commanded.[13] During that time, he invented a warp-speed starship tactic (employing faster-than-light optical illusion) that would become known as the Picard Maneuver.[13]"

                });

                crewList.Add(new CrewMember()
                {
                    Name = "William T. Riker",
                    Rank = "Captain",
                    Posting = "USS Titan",
                    Position = "Commanding Officer",
                    Species = "Human",
                    PhotoResourceId = Resource.Drawable.Riker,
                    Biography = "For the first two seasons, Riker is portrayed as a bold, confident and sometimes arrogant, ambitious young officer; however, over time Riker's character becomes more reserved, as experience teaches him the wisdom of a patient, careful approach. He becomes comfortable on the Enterprise, repeatedly turning down offers of his own command, and he learns to cherish the company of his fellow officers. Nonetheless, Riker retains a willingness to occasionally disregard the chain of command. Riker is usually referred to as \"Will\", although in early first-season episodes of TNG he is sometimes called \"Bill\" by Deanna Troi. He is also usually (and informally) called \"Number One\" by Captain Picard, because of his position as first officer on the Enterprise."
                });

                crewList.Add(new CrewMember()
                {
                    Name = "Deanna Troi",
                    Rank = "Commander",
                    Posting = "USS Titan",
                    Position = "Diplomatic Officer",
                    Species = "Betazoid/Human",
                    PhotoResourceId = Resource.Drawable.Troi,
                    Biography = "Deanna Troi was born on March 29, 2336, near Lake El-Nar, Betazed.[2] Deanna's parents are Betazoid Ambassador Lwaxana Troi (portrayed by Majel Barrett), and deceased human Starfleet officer Lt. Ian Andrew Troi (portrayed by Amick Byram). An older sister, Kestra, was accidentally drowned during Deanna's infancy (see \"Dark Page\"). Although Deanna Troi has little exposure to Earth culture, she attended Starfleet Academy from 2355 to 2359, as well as the University on Betazed, and earned an advanced degree in psychology"
                });

                crewList.Add(new CrewMember()
                {
                    Name = "Beverly Crusher",
                    Rank = "Commander",
                    Posting = "USS Enterpise-E",
                    Position = "Cheif Medical Officer",
                    Species = "Human",
                    PhotoResourceId = Resource.Drawable.Crusher_B,
                    Biography = "Beverly Crusher was born Beverly Howard on October 13, 2324 in Copernicus City, Luna.[2] Further back, before the colonization of Luna, her ancestors were Scottish-Americans. Following the death of her parents when she was very young, she lived with her grandmother, Felisa Howard on Arvada III, a colony planet until a great moon collision caused the planet to flood, forcing its evacuation. Resourceful Felisa, with her granddaughter's aid, used herbs, grasses, tree chemicals, and roots as medicines when synthetic medicines ran out for the injured."
                });

                crewList.Add(new CrewMember()
                {
                    Name = "Data",
                    Rank = "Lieutenant Commander",
                    Posting = "USS Enterpise-E",
                    Position = "Cheif Operations Officer",
                    Species = "Android",
                    PhotoResourceId = Resource.Drawable.Data,
                    Biography = "An artificial intelligence and synthetic life form designed and built by Doctor Noonien Soong, Data is a self-aware, sapient, sentient, and anatomically fully functional android who serves as the second officer and chief operations officer aboard the Federation starships USS Enterprise-D and USS Enterprise-E. His positronic brain allows him impressive computational capabilities. Data experienced ongoing difficulties during the early years of his life with understanding various aspects of human behavior[2] and was unable to feel emotion or understand certain human idiosyncrasies, inspiring him to strive for his own humanity. This goal eventually led to the addition of an \"emotion chip\", also created by Soong, to Data's positronic net.[3] Although Data's endeavor to increase his humanity and desire for human emotional experience is a significant plot point (and source of humor) throughout the series, he consistently shows a nuanced sense of wisdom, sensitivity, and curiosity, garnering immense respect from his peers and colleagues."
                });

                crewList.Add(new CrewMember()
                {
                    Name = "Geordi La Forge",
                    Rank = "Lieutenant Commander",
                    Posting = "USS Enterpise-E",
                    Position = "Cheif Engineer",
                    Species = "Human",
                    PhotoResourceId = Resource.Drawable.LaForge,
                    Biography = "Geordi La Forge is a Starfleet officer, who originally was the helmsman of the USS Enterprise-D during 2364, with the rank of lieutenant junior grade. He was promoted to the rank of lieutenant and later lieutenant commander and became the chief engineer of the Enterprise-D and later USS Enterprise-E, both under Captain Jean-Luc Picard. "
                });

                crewList.Add(new CrewMember()
                {
                    Name = "Worf",
                    Rank = "Lieutenant Commander",
                    Posting = "USS Enterpise-E",
                    Position = "Strategic Operations Officer",
                    Species = "Klingon",
                    PhotoResourceId = Resource.Drawable.Worf,
                    Biography = "Worf – son of Mogh, of the Klingon House of Martok, of the Human family Rozhenko; mate to K'Ehleyr, father to Alexander Rozhenko, and husband to Jadzia Dax; Starfleet officer and soldier of the Empire; bane of the House of Duras; slayer of Gowron; Federation ambassador to Qo'noS – was one of the most influential Klingons of the latter half of the 24th century. "
                });

                crewList.Add(new CrewMember()
                {
                    Name = "Wesley Crusher",
                    Rank = "Lieutenant, JG",
                    Posting = "USS Titan",
                    Position = "Engineering Officer",
                    Species = "Human",
                    PhotoResourceId = Resource.Drawable.Crusher_W,
                    Biography = "Lieutenant junior grade Wesley Robert Crusher was the gifted son of Starfleet officers Lieutenant Commander Jack Crusher and Doctor Beverly Crusher. After several years aboard the USS Enterprise-D and three years at Starfleet Academy, his Starfleet career was cut short when he dropped out of the Academy and continued on to a unique life, accompanying the transdimensional Tau Alphan The Traveler. (TNG: \"Encounter at Farpoint\", \"Final Mission\", \"The First Duty\", \"Rascals\", \"Journey's End\")\n\nCrusher eventually returned to Starfleet and, prior to 2379, he became a full-fledged officer, holding the rank of lieutenant junior grade in 2379."
                });

                crewList.Add(new CrewMember()
                {
                    Name = @"Miles O'Brien",
                    Rank = "Cheif Petty Officer",
                    Posting = "Starfleet Academy",
                    Position = "Academy Professor",
                    Species = "Human",
                    PhotoResourceId = Resource.Drawable.OBrien,
                    Biography = "Miles Edward O'Brien was a 24th century Human Starfleet non-commissioned officer who, following his service during the Federation-Cardassian War, served as transporter chief on board the USS Enterprise-D for several years before being promoted to chief of operations aboard starbase Deep Space 9. After the Dominion War, he accepted a teaching position at Starfleet Academy on Earth."
                });

                crewList.Add(new CrewMember()
                {
                    Name = "Reginald Barclay",
                    Rank = "Lieutenant Commander",
                    Posting = "Starfleet Command",
                    Position = "Pathfinder Project",
                    Species = "Human",
                    PhotoResourceId = Resource.Drawable.Barclay,
                    Biography = "Lieutenant Reginald \"Reg\" Barclay was a highly-talented Human Starfleet systems diagnostic engineer who lived in the 24th century. In his early days aboard the Enterprise-D, he frequently displayed nervous behavior, demonstrated a noticeable lack in confidence, stammered profusely, was extremely introverted, and occasionally bumbled. These traits engendered the derision of some of his shipmates on the USS Enterprise-D – with some even going as far as calling him \"Lieutenant Broccoli\" behind his back or, on unfortunate occasions, to his face."
                });
            }

            return crewList;
        }
    }
}

