namespace State.States
{
    using System;
    using State.Contexts;

    public class OverflowLidState : ILidState
    {
        private const int MIN_ANGLE = 3;
        private const int MIN_LEVEL = 80;
        private ILidState lidState;

        public static ILidState Instance => new OverflowLidState();

        public void Transition(IBinService binService)
        {
            binService.Transition(this.lidState);
        }

        public bool Validate(IBinService binService)
        {
            var (Angle, Level) = binService.GetSensorReadings();
            var isValidated = false;

            if (Angle >= MIN_ANGLE && Level >= MIN_LEVEL)
            {
                Console.WriteLine("Bin is overflowing");
                isValidated = true;
            }

            this.lidState = Angle <= MIN_ANGLE ? ClosedLidState.Instance : OpenLidState.Instance;
            return isValidated;
        }
    }
}
