using System.Runtime.Serialization;

namespace MoodAnalyser
{
    [Serializable]
    public class MoodAnalysisException : Exception
    {
        public enum ExpType
        {
            Empty_Message, Null_Message
        }
        public readonly ExpType type;

        public MoodAnalysisException(ExpType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}