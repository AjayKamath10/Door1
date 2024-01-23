﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorFunctionsLibrary
{
    public class SmartDoor : SimpleDoor
    {

        public event Action<SmartDoor> TimerThresholdReachedEvent;

        private int doorTimeThreshold;
        public bool buzzer { get; set; }
        public bool pager { get; set; }
        public bool autoClose { get; set; }
        public SmartDoor(string Name, double Price = 200, bool Buzzer = false, bool Pager = false, bool AutoClose = false) : base(Name, Price)
        {
            buzzer = Buzzer;
            pager = Pager;
            autoClose = AutoClose;

            price += CalculateAdditionalPrice(this);

        }

        public void SetTimer(int Time)
        {
            doorTimeThreshold = Time;
        }

        public void Open()
        {
            base.Open();
            TimerThresholdReachedEvent?.Invoke(this);

        }

        protected virtual void OnDoorOpenEvent()
        {
            //this.TimerThresholdReachedEvent +=
            //DoorOpenEvent?.Invoke();
        }

        //public void SimulateTimerCountdown()
        //{
        //    // Check if the door is open for more than the threshold
        //    if (state == DoorStates.OPEN && TimerThresholdReachedEvent <= 0)
        //    {
        //        // Notify subscribers
        //        TimerThresholdReachedEvent?.Invoke(this);
        //    }
        //    else if (DoorStates == DoorStates.OPEN)
        //    {
        //        // Decrease the timer threshold
        //        timerThreshold--;
        //    }
        


        private static double CalculateAdditionalPrice(SmartDoor This)
        {
            double additionalPrice = 0;
            additionalPrice += This.buzzer ? 50 : 0;
            additionalPrice += This.pager ? 100 : 0;
            additionalPrice += This.autoClose ? 150 : 0;

            return additionalPrice;
        }
    }
}
