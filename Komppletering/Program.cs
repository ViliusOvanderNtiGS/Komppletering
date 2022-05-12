using System;
using System.Collections.Generic;

namespace Komppletering
{
    class Program
    {
        static void Main(string[] args)
        {

            bool gameContinues = true;
            int currentRoom = 0;


            while (gameContinues == true)
            {
                if (currentRoom == 0)
                {
                    Console.WriteLine("Vad vill du titta på?");
                    Console.WriteLine();
                    Console.WriteLine("1: List");
                    Console.WriteLine();
                    Console.WriteLine("2: Stack");
                    Console.WriteLine();
                    Console.WriteLine("3: Dictionary");
                    string whatRoom = Console.ReadLine();

                    if (whatRoom == "1")
                    {
                        currentRoom = 1;
                    }
                    else if (whatRoom == "2")
                    {
                        currentRoom = 2;
                    }
                    else if (whatRoom == "3")
                    {
                        currentRoom = 3;
                    }
                }
                else if (currentRoom == 1) //List
                {
                    List<string> myList = new List<string>();
                    Console.Clear();

                    myList.Add("Hej");
                    myList.Add("på");
                    myList.Add("dig");

                    Console.WriteLine(myList[0]);
                    Console.WriteLine(myList[1]);
                    Console.WriteLine(myList[2]);
                    Console.WriteLine();

                    Console.WriteLine("Så här många saker finns i listan: " + myList.Count);
                    Console.ReadLine();


                }
                else if (currentRoom == 2) // Stack
                {
                    Stack<int> myStack = new Stack<int>();
                    Console.Clear();
                    myStack.Push(1);
                    myStack.Push(2);
                    myStack.Push(3);

                    Console.WriteLine("Det som är högst upp på högen: " + myStack.Peek());
                    Console.WriteLine();


                    Console.WriteLine("1: Pop");
                    Console.WriteLine("2: Push");

                    string whatAction = Console.ReadLine();
                    if (whatAction == "1")
                    {
                        myStack.Pop();
                        Console.WriteLine("Du poppade det som var högst upp");
                        Console.WriteLine("Det som är högst upp nu är: " + myStack.Peek());
                        Console.ReadLine();

                    }
                    else if (whatAction == "2")
                    {
                        Console.WriteLine("Säg ett nummer");
                        string x = Console.ReadLine();




                        //tryparse
                        int xResultat;
                        bool lyckad = int.TryParse(x, out xResultat);
                        if (lyckad == true)
                        {

                            myStack.Push(Convert.ToInt32(x));
                            Console.WriteLine("Du pushade: " + myStack.Peek());
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Det är inget nummer");
                            Console.ReadLine();
                        }







                    }

                }
                else if (currentRoom == 3) // Dictionary
                {
                    Dictionary<string, int> dndStats = new Dictionary<string, int>();
                    Console.Clear();

                    dndStats.Add("Strength", 20);
                    dndStats.Add("Intelligence", 12);
                    dndStats.Add("Dexterity", 12);
                    dndStats.Add("Wisdom", 9);
                    dndStats.Add("Charisma", 10);
                    dndStats.Add("Constitution", 18);

                    //Console.WriteLine("Vad för stat vill du se?");
                    /*Console.WriteLine("1: Strength");
                    Console.WriteLine("2: Intelligence");
                    Console.WriteLine("3: Dexterity");
                    Console.WriteLine("4: Wisdom");
                    Console.WriteLine("5: Charisma");
                    Console.WriteLine("6: Constitution");*/
                    //string key = Console.ReadLine();

                    foreach (string key in dndStats.Keys)
                    {
                        Console.WriteLine($"{key}: {dndStats[key]}");

                    }
                    Console.ReadLine();


                    /*
                                        //Console.WriteLine("Strength:");
                                        Console.WriteLine("Strength: " + dndStats["Strength"]);

                                        Console.WriteLine("Dexterity: " + dndStats["Dexterity"]);

                                        Console.WriteLine("Constitution: " + dndStats["Constitution"]);

                                        Console.WriteLine("Intelligence: " + dndStats["Intelligence"]);

                                        Console.WriteLine("Wisdom: " + dndStats["Wisdom"]);

                                        Console.WriteLine("Charisma: " + dndStats["Charisma"]);


                                        Console.ReadLine();*/
                }


            }

        }
    }
}
