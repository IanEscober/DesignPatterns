namespace State.States
{
    using System;
    using State.Contexts;

    public class ClosedLidState : ILidState
    {
        private const int MAX_ANGLE = 3;
        private const int MAX_LEVEL = 80;
        private ILidState lidState;

        public static ILidState Instance => new ClosedLidState();

        public void Transition(IBinService binService)
        {
            binService.Transition(this.lidState);
        }

        public bool Validate(IBinService binService)
        {
            var (Angle, Level) = binService.GetSensorReadings();
            var isValidated = false;

            if (Angle <= MAX_ANGLE)
            {
                if(Level >= MAX_LEVEL)
                {
                    Console.WriteLine("Bin is full");
                    isValidated = true;
                }
                else
                {
                    Console.WriteLine("Bin is closed");
                    isValidated = true;
                }
            }

            this.lidState = Level >= MAX_LEVEL ? OverflowLidState.Instance : OpenLidState.Instance;
            return isValidated;
        }
    }
}
