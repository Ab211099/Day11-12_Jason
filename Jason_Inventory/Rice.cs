using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jason_Inventory
{
    internal class Rice
    {
        public List<TypeofRice> typeofRice;
        public List<TypeofPulse> typeofPulse;
        public List<TypeofWheat> typeofWheat;
    }
    public class TypeofRice
    {
        //Properties of Rice
        public string Name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
    public class TypeofPulse
    {
        //Properties of pulse
        public string Name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
    public class TypeofWheat
    {
        //Properties of Rice
        public string Name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
}

