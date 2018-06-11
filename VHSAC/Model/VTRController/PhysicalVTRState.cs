namespace VHSAC.Model.VTRController
{

    public enum PhysicalVTRState
    {
        Playing,
        PreparingToPlay,
        Stopping,
        Stopped,
        Unknown
    }

    public class PhysicalVTRStateConverter
    {

        private static readonly string STATE_PLAYING = "playing";
        private static readonly string STATE_PREPARING_TO_PLAY = "preparing to play";
        private static readonly string STATE_STOPPING = "stopping";
        private static readonly string STATE_STOPPED = "stopped";

        public static PhysicalVTRState Convert(string stateStr)
        {
            if (stateStr == STATE_PLAYING)
                return PhysicalVTRState.Playing;
            if (stateStr == STATE_PREPARING_TO_PLAY)
                return PhysicalVTRState.PreparingToPlay;
            if (stateStr == STATE_STOPPING)
                return PhysicalVTRState.Stopping;
            if (stateStr == STATE_STOPPED)
                return PhysicalVTRState.Stopped;
            return PhysicalVTRState.Unknown;
        }

    }

}
