using System;

namespace Program
{
    abstract class Device
    {
        public Device(string name)
        {
            Name = name;
            IsOn = false;
            Type = null;
        }

        public string Name { get; set; }
        public bool IsOn { get; protected set; }
        public string Type { get; protected set; }
        public virtual void TurnOn()
        {
            if (!IsOn)
                IsOn = true;
            Console.WriteLine($"{Name} was turned on.");
        }
        public virtual void TurnOff()
        {
            if (IsOn)
                IsOn = false;
            Console.WriteLine($"{Name} was turned off.");
        }
    }
}
