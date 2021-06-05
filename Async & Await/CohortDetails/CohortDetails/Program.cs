using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohortDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            string CohortName = "INTADM21DF006";
            int count = 25;
            string mode = "OBL";
            string track = ".NET";
            string currentmodule = "ASP.NET CORE";
            GetCohortDetails(CohortName, count,mode,track,currentmodule);
            //Incorrect order
            GetCohortDetails(mode, count, CohortName, currentmodule, track);
            //using Named Parameters
            GetCohortDetails(CohortName: CohortName,Genc_Count: count,Mode: mode,Track: track,CurrentModule: currentmodule);
            //named parameters in different orders
            GetCohortDetails( Genc_Count: count, CohortName: CohortName,  Track: track, Mode: mode, CurrentModule: currentmodule);
            Console.ReadKey();
        }
        public static void GetCohortDetails(string CohortName,int Genc_Count,string Mode,string Track,string CurrentModule)
        {
            Console.WriteLine("It is {0} with {1} GenCs undergoing training for {2} thru {3}. The current module of training is {4}",CohortName,Genc_Count,Track,Mode,CurrentModule);
        }
    }
}
