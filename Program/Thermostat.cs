using System;

namespace Program
{
    class Thermostat : Device
    {
        public event Action TemperatureChanged;
        public bool Warn {  get; private set; }
        public Thermostat(string name) : base(name) 
        {
            Type = "Thermostat";
        }
        public int CurrentTemperature { get; protected set; }
        public void SetTemperature()
        {
            Console.WriteLine($"[{Type} {Name}]: Please, set new temperature | Current temperature: {CurrentTemperature}°C.");
            int NewTemperature = Convert.ToInt32(Console.ReadLine());
            CurrentTemperature = NewTemperature;
            TriggerTemperatureChanged();
        }
        public void TemperatureChange()
        {
            if (CurrentTemperature > 30 && IsOn)
            {
                Console.WriteLine($"[{Type} {Name}]: Warning! Temperature above 30°C! Turning {Type} off...");
                TurnOff();
            }
            else Console.WriteLine($"[{Type} {Name}]: Temperature was changed to {CurrentTemperature}°C.");
        }

        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine($"[{Type} {Name}]: {Type} was turned on.");
        }
        public override void TurnOff()
        {
            base.TurnOff();
            Console.WriteLine($"[{Type} {Name}]: {Type} was turned off.");
        }
        public void ShowTemperature()
        {
            Console.WriteLine($"[{Type} {Name}]: Current temperature is {CurrentTemperature}°C.");
        }
        public void TriggerTemperatureChanged()
        {
            TemperatureChanged?.Invoke();
        }
    }
}
