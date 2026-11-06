using System;

namespace Program
{
    class MotionSensor
    {
        public event Action OnMotionDetected;

        public void TriggerMotionSensor()
        {
            OnMotionDetected?.Invoke();
        }
        
    }
}
