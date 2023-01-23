using System.Runtime.Serialization;

namespace MoodAnalyser
{
    [Serializable]
    public class MoodAnalysisException : Exception
    {
        public enum ExpType
        {
            Empty_Message, Null_Message,
            OBJECT_CREATION_ISSUE,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }
        public readonly ExpType type;
        private Exception e;

        public MoodAnalysisException(ExpType type, string message) : base(message)
        {
            this.type = type;
        }

        public MoodAnalysisException(ExpType type, string message, Exception e) : this(type, message)
        {
            this.e = e;
        }
    }
}