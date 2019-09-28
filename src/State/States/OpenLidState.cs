namespace State.States
{
    using System;
    using State.Contexts;

    public class OpenLidState : ILidState
    {
        private const int MIN_ANGLE = 3;
        private const int MAX_LEVEL = 80;
        private ILidState lidState;

        public static ILidState Instance => new OpenLidState();

        public void Transition(IBinService binService)
        {
            binService.Transition(this.lidState);
        }

        public bool Validate(IBinService binService)
        {
            var (Angle, Level) = binService.GetSensorReadings();
            var isValidated = false;

            if (Angle >= MIN_ANGLE && Level <= MAX_LEVEL)
            {
                Console.WriteLine("Bin is open");
                isValidated = true;
            }

            this.lidState = Level >= MAX_LEVEL ? OverflowLidState.Instance : ClosedLidState.Instance;
            return isValidated;
        }
    }
}
