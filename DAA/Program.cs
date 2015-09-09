using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA
{
    class Program
    {
        static void Main(string[] args)
        {
            string finalOutput = string.Empty;
            string outputString = string.Empty;
            int[] lastProgramTotalTime = new int[2];//program time, program region

            Console.Write("Input mn values");

            var inputMN = Console.ReadLine().Split(' ').Select(token => int.Parse(token));
            int[] mn = inputMN.ToArray();


            Console.Write("Input region sizes: ");
            var inputRegionSizes = Console.ReadLine().Split(' ').Select(token => int.Parse(token));
            int[] regionSizes = inputRegionSizes.ToArray();

            int[] regionTimes = new int[regionSizes.Length];

            for (int i = 0; i < regionSizes.Length; i++)
            {
                regionTimes[i] = 0;
            }

            int[][] input = new int[mn[1]][];



            for (int i = 0; i < mn[1]; i++)
            {
                Console.Write("Enter program data: ");
                var inputProgramData = Console.ReadLine().Split(' ').Select(token => int.Parse(token));

                int[] temp = inputProgramData.ToArray();

                input[i] = new int[temp.Length];

                for (int g = 0; g < temp.Length; g++)
                {
                    input[i][g] = temp[g];
                }
            }

            for (int h = 0; h < mn[1]; h++)
            {
                int[] temp2 = input[h];

                int[] size = temp2.Where((item, index) => index % 2 != 0).ToArray();
                int[] executionTimeArray = temp2.Where((item, index) => index % 2 == 0).ToArray();

                //remove the zeroth index val as it is not needed.
                int executionTime = executionTimeArray.Where((val, idx) => idx != 0).ToArray().Sum();
                int runningRegionIndex = 0;

                int count = 0;

                foreach (var item in regionSizes)
                {
                    if (item > size.Max())
                    {

                        runningRegionIndex = count;

                        int[] tempRegionTimes = new int[regionTimes.Length];

                        Array.Copy(regionTimes, tempRegionTimes, count);

                        //get the total running time and check to assing to lowest time
                        for (int z = count; z < regionTimes.Length; z++)
                        {
                            tempRegionTimes[z] += tempRegionTimes[z] + executionTime;
                        }

                        break;
                    }
                    else
                    {
                        count++;
                    }
                }

                //create output string
                outputString += "Program 1 runs in region" + runningRegionIndex + " from " + regionTimes[runningRegionIndex] + " to " + (regionTimes[runningRegionIndex] + executionTime + "\n");

                //increase region execution time
                regionTimes[runningRegionIndex] += executionTime;

            }

            Console.WriteLine(outputString);


        }
    }


}
