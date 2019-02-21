using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayWelcomeScreen();
			DisplayMenu();
			DisplayClosingScreen();
		}

		static SeaMonster InitializeSeaMonster()
		{
			return new SeaMonster()
			{
				Id = 34,
				Name = "Suzy",
				Age = 473,
                Height = 40.5,
                Weight = 600,
				HasGills = true,
				HomeSea = "Baltic Sea"
			};
		}
		static SpaceMonster InitializeSpaceMonster()
		{
			return new SpaceMonster
			{
				Id = 56,
				Name = "Sid",
				Age = 18,
                Height = 7.5,
                Weight = 50,
                OwnsSpaceship = false,
                NeedOxygen = false,
				Galaxy = "Andromeda"
			};
		}

        static CircusMonster InitializeCircusMonster()
        {
            return new CircusMonster
            {
                Id = 60,
                Name = "Jenny",
                Age = 45,
                Height = 30.5,
                Weight = 200,
                HasTent = true,
                NumOfPerformances = 5,
                Specialty = "Invisible Legs"
            };
        }

        private static void DisplayMenu()
		{
			bool exitMenu = false;
			string menuSelection;
			SeaMonster mySeaMonster;
			SpaceMonster mySpaceMonster;
            CircusMonster myCircusMonster;

			mySeaMonster = InitializeSeaMonster();
			mySpaceMonster = InitializeSpaceMonster();
            myCircusMonster = InitializeCircusMonster();

			do
			{
				DisplayHeader("Menu");
				Console.WriteLine("A) Display Monsters");
				Console.WriteLine("B) Edit Monsters");
				Console.WriteLine("C) Exit");
				Console.WriteLine();
				Console.Write("Enter Selection: ");

				menuSelection = Console.ReadLine().ToUpper();

				switch (menuSelection)
				{
					case "A":
						DisplayMonsterInfoScreen(mySeaMonster, mySpaceMonster, myCircusMonster);
						break;
					case "B":
						DisplayEditSeaMonster(mySeaMonster);
						DisplayEditSpaceMonster(mySpaceMonster);
                        DisplayEditCircusMonster(myCircusMonster);
						break;
					case "C":
                        exitMenu = true;
                        break;
					default:
						Console.WriteLine("Please Enter a Proper Selection.");
						DisplayContinuePrompt();
						break;
				}
			} while (!exitMenu);
		}

        private static void DisplayEditCircusMonster(CircusMonster myCircusMonster)
        {
            int userResponseNum;
            double userResponseNum1;
            string userResponse;
            bool loop = true;

            DisplayHeader("Edit Circus Monster");
            Console.WriteLine();

            while (loop)
            {
                Console.Write("Id: ");

                if (int.TryParse(Console.ReadLine(), out userResponseNum))
                {
                    myCircusMonster.Id = userResponseNum;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid whole number.");

                }
            }
            Console.Write("Name: ");
            myCircusMonster.Name = Console.ReadLine();
            while (!loop)
            {
                Console.Write("Age: ");
                if (int.TryParse(Console.ReadLine(), out userResponseNum))
                {
                    myCircusMonster.Age = userResponseNum;
                    loop = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid whole number.");
                }
            }
            while (loop)
            {
                Console.Write("Height: ");

                if (double.TryParse(Console.ReadLine(), out userResponseNum1))
                {
                    myCircusMonster.Height = userResponseNum1;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");

                }
            }
            while (!loop)
            {
                Console.Write("Weight: ");

                if (double.TryParse(Console.ReadLine(), out userResponseNum1))
                {
                    myCircusMonster.Weight = userResponseNum1;
                    loop = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");

                }
            }
            while (loop)
            {
                Console.Write("Number of Performances: ");
                if (int.TryParse(Console.ReadLine(), out userResponseNum))
                {
                    myCircusMonster.NumOfPerformances = userResponseNum;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid whole number.");
                }
            }
            while (!loop)
            {
                Console.Write("Owns a Tent: ");
                userResponse = Console.ReadLine().ToUpper();

                if (userResponse == "YES")
                {
                    myCircusMonster.HasTent = true;
                    loop = true;
                }
                else if (userResponse == "NO")
                {
                    myCircusMonster.HasTent = false;
                    loop = true;
                }
                else
                {
                    Console.WriteLine("Please enter Yes or No.");
                }

            }
            Console.Write("Specialty: ");
            myCircusMonster.Specialty = Console.ReadLine();
        }

        private static void DisplayEditSpaceMonster(SpaceMonster mySpaceMonster)
		{
			int userResponseNum;
            double userResponseNum1;
			string userResponse;
			bool loop = true;

			DisplayHeader("Edit Space Monster");
			Console.WriteLine();

			while (loop)
			{
				Console.Write("Id: ");

				if (int.TryParse(Console.ReadLine(), out userResponseNum))
				{
					mySpaceMonster.Id = userResponseNum;
					loop = false;
				}
				else
				{
					Console.WriteLine("Please enter a valid whole number.");

				}
			}
            Console.Write("Name: ");
			mySpaceMonster.Name = Console.ReadLine();
			while (!loop)
			{
				Console.Write("Age: ");
				if (int.TryParse(Console.ReadLine(), out userResponseNum))
				{
					mySpaceMonster.Age = userResponseNum;
					loop = true;
				}
				else
				{
					Console.WriteLine("Please enter a valid whole number.");
				}
			}
            while (loop)
            {
                Console.Write("Height: ");

                if (double.TryParse(Console.ReadLine(), out userResponseNum1))
                {
                    mySpaceMonster.Height = userResponseNum1;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");

                }
            }
            while (!loop)
            {
                Console.Write("Weight: ");

                if (double.TryParse(Console.ReadLine(), out userResponseNum1))
                {
                    mySpaceMonster.Weight = userResponseNum1;
                    loop = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");

                }
            }
            while (loop)
            {
                Console.Write("Owns a Spaceship: ");
                userResponse = Console.ReadLine().ToUpper();

                if (userResponse == "YES")
                {
                    mySpaceMonster.OwnsSpaceship = true;
                    loop = false;
                }
                else if (userResponse == "NO")
                {
                    mySpaceMonster.OwnsSpaceship = false;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter Yes or No.");
                }

            }
            while (loop)
            {
                Console.Write("Needs Oxygen: ");
                userResponse = Console.ReadLine().ToUpper();

                if (userResponse == "YES")
                {
                    mySpaceMonster.NeedOxygen = true;
                    loop = false;
                }
                else if (userResponse == "NO")
                {
                    mySpaceMonster.NeedOxygen = false;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter Yes or No.");
                }

            }
            Console.Write("Galaxy: ");
			mySpaceMonster.Galaxy = Console.ReadLine();
		}

		private static void DisplayEditSeaMonster(SeaMonster mySeaMonster)
		{
			int userResponseNum;
            double userResponseNum1;
			string userResponse;
			bool loop = true;

			DisplayHeader("Edit Sea Monster");
			Console.WriteLine();

			while (loop)
			{
				Console.Write("Id: ");

				if (int.TryParse(Console.ReadLine(), out userResponseNum))
				{
					mySeaMonster.Id = userResponseNum;
					loop = false;
				}
				else
				{
					Console.WriteLine("Please enter a valid whole number.");

				}
			}
			Console.Write("Name: ");
			mySeaMonster.Name = Console.ReadLine();
			while (!loop)
			{
				Console.Write("Age: ");
				if (int.TryParse(Console.ReadLine(), out userResponseNum))
				{
					mySeaMonster.Age = userResponseNum;
					loop = true;
				}
				else
				{
					Console.WriteLine("Please enter a valid whole number.");
				}
			}
            while (loop)
            {
                Console.Write("Height: ");

                if (double.TryParse(Console.ReadLine(), out userResponseNum1))
                {
                    mySeaMonster.Height = userResponseNum1;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");

                }
            }
            while (!loop)
            {
                Console.Write("Weight: ");

                if (double.TryParse(Console.ReadLine(), out userResponseNum1))
                {
                    mySeaMonster.Weight = userResponseNum1;
                    loop = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");

                }
            }
			while (loop)
			{
				Console.Write("Has Gills: ");
				userResponse = Console.ReadLine().ToUpper();

				if (userResponse == "YES")
				{
					mySeaMonster.HasGills = true;
					loop = false;
				}
				else if (userResponse == "NO")
				{
					mySeaMonster.HasGills = false;
					loop = false;
				}
				else
				{
					Console.WriteLine("Please enter Yes or No.");
				}

			}
            Console.Write("Home Sea: ");
			mySeaMonster.HomeSea = Console.ReadLine();
		}

		private static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster, CircusMonster circusMonster)
		{
			DisplayHeader("Monster Info");

			Console.WriteLine("Sea Monster");
			DisplaySeaMonsterInfo(seaMonster);

			Console.WriteLine();
			Console.WriteLine("Space Monster");
			DisplaySpaceMonsterInfo(spaceMonster);

            Console.WriteLine();
            Console.WriteLine("Circus Monster");
            DisplayCircusMonsterInfo(circusMonster);

			DisplayContinuePrompt();
		}

        private static void DisplayCircusMonsterInfo(CircusMonster circusMonster)
        {
            Console.WriteLine($"Id: {circusMonster.Id}");
            Console.WriteLine($"Name: {circusMonster.Name}");
            Console.WriteLine($"Age: {circusMonster.Age}");
            Console.WriteLine($"Height: {circusMonster.Height}");
            Console.WriteLine($"Weight: {circusMonster.Weight}");
            Console.WriteLine($"Number of Performances: {circusMonster.NumOfPerformances}");
            Console.WriteLine($"Owns a Tent: {circusMonster.HasTent}");
            Console.WriteLine($"Specialty: {circusMonster.Specialty}");
            Console.WriteLine($"Is Happy: {(circusMonster.IsHappy() ? "Yes" : "No")}");
            Console.WriteLine(circusMonster.Roar());
            Console.WriteLine(circusMonster.Greeting());

            Console.WriteLine($"You introduce yourself and {circusMonster.Name} does a {circusMonster.MonsterPerformResponse()}");
        }

        private static void DisplaySpaceMonsterInfo(SpaceMonster spaceMonster)
		{
			Console.WriteLine($"Id: {spaceMonster.Id}");
			Console.WriteLine($"Name: {spaceMonster.Name}");
			Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Height: {spaceMonster.Height}");
            Console.WriteLine($"Weight: {spaceMonster.Weight}");
            Console.WriteLine($"Owns a Spaceship: {(spaceMonster.OwnsSpaceship ? "Yes" : "NO")}");
            Console.WriteLine($"Needs Oxygen: {(spaceMonster.NeedOxygen ? "Yes" : "No")}");
			Console.WriteLine($"Galaxy: {spaceMonster.Galaxy}");
			Console.WriteLine($"Is Happy: {(spaceMonster.IsHappy() ? "Yes" : "No")}");
            Console.WriteLine(spaceMonster.Roar());
            Console.WriteLine(spaceMonster.Greeting());

			Console.WriteLine($"You attacked {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()}");
		}

		private static void DisplaySeaMonsterInfo(SeaMonster seaMonster)
		{
			Console.WriteLine($"Id: {seaMonster.Id}");
			Console.WriteLine($"Name: {seaMonster.Name}");
			Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Height: {seaMonster.Height}");
            Console.WriteLine($"Weight: {seaMonster.Weight}");
            Console.WriteLine($"Home Sea: {seaMonster.HomeSea}");
			Console.WriteLine($"Has Gills: {(seaMonster.HasGills ? "Yes" : "No")}");
			Console.WriteLine($"Is Happy: {(seaMonster.IsHappy() ? "Yes" : "No")}");
            Console.WriteLine(seaMonster.Roar());
            Console.WriteLine(seaMonster.Greeting());
		}

		static void DisplayContinuePrompt()
		{
			Console.WriteLine();
			Console.WriteLine("Press any key to continue.");
			Console.ReadKey();
		}

		static void DisplayWelcomeScreen()
		{
			Console.Clear();

			Console.WriteLine("\n\nWelcome\n\n");

			DisplayContinuePrompt();
		}

		static void DisplayHeader(string headerText)
		{
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine(headerText);
			Console.WriteLine();
		}

		static void DisplayClosingScreen()
		{
			DisplayHeader("Closing Screen");
			Console.WriteLine();
			Console.WriteLine("Its been great.");
			Console.WriteLine();
			DisplayContinuePrompt();
		}
	}
}
