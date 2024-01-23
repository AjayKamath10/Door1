using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorFunctionsLibrary
{
    public class Buzzer
    {
        public void Buzz(SmartDoor door)
        {
            Logger.Write($"Buzzer: door {door.name} is open");
        }

    }
}
