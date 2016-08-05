using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Array_List_timers
{
    class Program
    {
        static void writeAndWait(String statement, int millisecondsToWait)
        {
            Console.WriteLine(statement);
            Thread.Sleep(millisecondsToWait);
            return;
        }


        static void Main(string[] args)
        {

            //I am using ArrayLists because they will store as many values as needed wether it be 1 or 1,000,000 or more
            ArrayList Name; //Declaring Name  
            ArrayList Time; //Declaring Time
            ArrayList Path; //Declaring Path

            Name = new ArrayList(); //Name will be used to store the names of the timers the user inputs
            Time = new ArrayList(); //Time will be used to store the times of the timers the user inputs
            Path = new ArrayList(); //Path will be used to store the path line of the timers the user inuts;


            writeAndWait("Hello, to add Timers that will run in sync, you simple need to enter then name, press enter, and then the", 500);
            writeAndWait("time you wish the timer to run in minutes, then you need to add a number 1-9(start at one)", 500);
            writeAndWait("All timers with the same ending numbers will run in sync. And all numbers will run a-sync. ", 500);
            writeAndWait("So Timers with 1 will run at the same time as the timers with 2.", 500);
            writeAndWait("type Exit to leave after naming your last timer", 250);
            // string Vname;//Delacring Vname 
            // Vname = Console.ReadLine();
            // Name.Add(Vname.ToString());

            string VName;
            string VTime;
            int ITime;
            string VPath;
            int IPath;
            bool Endloop;
            Endloop = false;
            int counter;
            counter = 0;
            int totalcount = 0;
            int count = 0;
            int pathslot = 0; // used to call up each slot in array path
            int pathline = 1; // use to determin what path a timer is on and assgin it to its array
            int path1count = 0;// counting the number  of time 1 appers in the array
            int path2count = 0;
            int path3count = 0;
            int path4count = 0;
            int path5count = 0;
            int path6count = 0;
            int path7count = 0;
            int path8count = 0;
            int path9count = 0;

            //Declaring nine 2D arrays one for each path
            int[,] pathone = new int[path1count, 2];
            int[,] pathtwo = new int[path2count, 2];
            int[,] paththree = new int[path3count, 2];
            int[,] pathfour = new int[path4count, 2];
            int[,] pathfive = new int[path5count, 2];
            int[,] pathsix = new int[path6count, 2];
            int[,] pathseven = new int[path7count, 2];
            int[,] patheight = new int[path8count, 2];
            int[,] pathnine = new int[path9count, 2];

            while (Endloop == false)
            {
                //VName input will kick out if user inputs Exit
                VName = Console.ReadLine();
                if (VName == "Exit") // cant find out how to make this a biconditional statment (If this or this happens) 
                {
                    Endloop = true;
                    break;
                }
                Name.Add(VName.ToString());

                //VTime input has no break code because you only want to kick out at the naming Phase
                VTime = Console.ReadLine();
                ITime = int.Parse(VTime);
                Time.Add(ITime);

                //Path input also has no break code because you only want to kick it out a naming Phase
                VPath = Console.ReadLine();
                IPath = int.Parse(VPath);
                Path.Add(IPath);
                counter += 1;

            }

            #region pathcount loops
            foreach (int value in Path)
            {
                totalcount++;
                if (value == 1)
                {
                    pathone[0, 0] = Name[totalcount]; //Tryibng to use the value of totalcount as the row number for the array name 
                    pathone[0, 1] = Time[0]; //Why the hell cant I access this array? 
                }

                foreach (int value in Path) // how do I make a statment that will look at every satment in the array(It worked when there was only one foreach loop but when I added more i wigged out
                {
                    if (value == 2) ++count;
                    path2count = count;
                    count = 1;
                }

                foreach (int value in Path)
                {
                    if (value == 3) ++count;
                    path3count = count;
                    count = 1;
                }

                foreach (int value in Path)
                {
                    if (value == 4) ++count;
                    path4count = count;
                    count = 1;
                }

                foreach (int value in Path)
                {
                    if (value == 5) ++count;
                    path5count = count;
                    count = 1;
                }

                foreach (int value in Path)
                {
                    if (value == 6) ++count;
                    path6count = count;
                    count = 1;
                }

                foreach (int value in Path)
                {
                    if (value == 7) ++count;
                    path7count = count;
                    count = 1;
                }

                foreach (int value in Path)
                {
                    if (value == 8) ++count;
                    path8count = count;
                    count = 1;
                }

                foreach (int value in Path)
                {
                    if (value == 9) ++count;
                    path9count = count;
                    count = 1;
                }
            #endregion



            }
        }
    }
}

