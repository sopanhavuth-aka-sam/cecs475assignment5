using _475_Lab_4_Part_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer {
    class Program
    {
        static void Main(string[] args)
        {
            IBusinessLayer businessLayer = new BusinessLayer();
            IList<Standard> allStandard = businessLayer.getAllStandards();
            foreach (Standard standard in allStandard)
            {
               Console.WriteLine(string.Format("{0} - {1}", standard.StandardId, standard.StandardName));
            }
         }
    }
}


