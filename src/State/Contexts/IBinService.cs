namespace State.Contexts
{
    using State.States;

    public interface IBinService
    {
        (int Angle, int Level) GetSensorReadings();
        void Transition(ILidState lidState);
        void Validate();
    }
}