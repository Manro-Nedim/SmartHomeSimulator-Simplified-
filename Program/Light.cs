using System;

namespace Program
{
    class Light : Device
    {
        public Light(string name) : base(name)
        {
            Type = "Light";
        }
        
        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine ($"[{Type} {Name}]: Light is turned on.");
        }
        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine($"[{Type} {Name}]: Light is turned off.");
        }
    }
}
