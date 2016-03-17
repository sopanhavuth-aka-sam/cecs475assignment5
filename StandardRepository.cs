using _475_Lab_4_Part_3;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer {
   public class StandardRepository : Repository<Standard>, IStandardRepository {
      //constructor
      public StandardRepository () : base(new SchoolDBEntities()) {

      }
   }

}