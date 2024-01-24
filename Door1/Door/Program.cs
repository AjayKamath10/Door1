using DoorFunctionsLibrary;

namespace Door
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDoor Door1 = new SimpleDoor("door1");
            SmartDoor Door2 = new SmartDoor("door2");


            Buzzer buzzer = new Buzzer();
            Pager pager = new Pager();
            AutoClose autoClose = new AutoClose();

            Door2.TimerThresholdReachedEvent += buzzer.Buzz;
            Door2.TimerThresholdReachedEvent += pager.Notify;
            Door2.TimerThresholdReachedEvent += autoClose.Close;

            Door2.Open();
        }
    }
}
