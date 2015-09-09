using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA
{


     //#region attributes 

     //       int totalRunTime = 0;

     //       #endregion


     //       #region GetInputParas

     //       Console.WriteLine("# of Regions: ");
     //       int noOfRegions = int.Parse(Console.ReadLine());

     //       Console.WriteLine("# of Programs: ");
     //       int noOfPrograms = int.Parse(Console.ReadLine()); 

     //       #endregion

     //       #region GetSizeOfEachRegion

     //       List<int> sizeOfRegions = new List<int>();
     //       List<int> timeOfEachRegion = new List<int>();


     //       for (int i = 0; i < noOfRegions; i++)
     //       {
     //           Console.WriteLine("Size Of Region " + i + " : ");
     //           sizeOfRegions.Add(int.Parse(Console.ReadLine()));
     //           timeOfEachRegion.Add(0);
     //       }

     //       #endregion


     //       #region GetProgramsToCheck

     //       for (int i = 0; i < noOfPrograms; i++)
     //       {
     //           var input = Console.ReadLine().Split(' ').Select(token => int.Parse(token));

     //           int[] arr = input.ToArray();
                
     //           int noOfInputs = arr[0];

     //           int[] size = input.Where((item, index) => index % 2 != 0).ToArray();
     //           int[] executionTime = input.Where((item, index) => index % 2 == 0).ToArray();

     //           //remove the zeroth index val as it is not needed.
     //           executionTime =  executionTime.Where((val, idx) => idx != 0).ToArray();

     //           int runningRegionIndex = 0;

     //           //check the region that can run this
     //           //assume region size is entered in asending order

     //           int count = 0;

     //           foreach (var item in sizeOfRegions)
     //           {
     //               if (item > size.Max())
     //               {
     //                   runningRegionIndex = count;
     //               }
     //               else
     //               {
     //                   count++;
     //               }
     //           }

     //           Console.WriteLine();
                
                


     //       }




     //       #endregion






     //       //to pause program's exit
     //       Console.ReadLine();


}
