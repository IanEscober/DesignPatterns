namespace State.Contexts
{
    using System;
    using State.States;

    public class BinService : IBinService
    {
        private ILidState lidState;
        private readonly int angle;
        private readonly int level;

        public BinService(int angle, int level)
        {
            this.lidState = ClosedLidState.Instance;
            this.angle = angle;
            this.level = level;
        }

        public (int Angle, int Level) GetSensorReadings()
        {
            return (this.angle, this.level);
        }

        public void Transition(ILidState lidState)
        {
            this.lidState = lidState ?? throw new NullReferenceException(nameof(lidState));
        }

        public void Validate()
        {
            var isValidated = this.lidState.Validate(this);

            while (!isValidated)
            {
                this.lidState.Transition(this);
                isValidated = this.lidState.Validate(this);
            }
        }
    }
}
