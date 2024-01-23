using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorFunctionsLibrary
{
    public class Pager
    {
        public void Notify(SmartDoor door)
        {
            Logger.Write($"Pager: door {door.name} is open");
        }
    }
}
