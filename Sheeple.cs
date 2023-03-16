using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFamous
{
    public class Sheeple
    {
        public string SheepName { get; private set; }
        public bool Fan { get; private set; }
        public string FandomStatus { get; private set; }
        public int ExploitableFunds { get; private set; }

        public Sheeple(string sheepName, bool fan, string fandomStatus, int exploitableFunds)
        {
            SheepName = sheepName;
            Fan = fan;
            FandomStatus = fandomStatus;
            ExploitableFunds = exploitableFunds;
        }
        public static object ReadFans()
        {
            //https://stackoverflow.com/questions/4462921/how-to-create-a-property-for-a-listt
        }
    }
}
