using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorFunctionsLibrary
{
    public class AutoClose
    {
        public void Close(SmartDoor Door) 
        {
            Door.Close();
            Logger.Write($"Door {Door.name} has been closed");
        }
    }
}
