using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampiMY301.EntityLayer.Concrete
{
    public class Category
    {
        // Field - Variable - Property
        /*
        int x; // Field

        public int y { get; set; } // Property

        void test()
        {
            int z; // Variable
        }
        */

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
