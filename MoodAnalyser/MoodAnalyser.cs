using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{


    public class MoodAnalyzer
    {
        private string message;

        public MoodAnalyzer() { }

        public MoodAnalyzer(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExpType.Null_Message, "User of Empty mood");
            }
            this.message = message;
        }

        public string analyseMood()
        {
            string Message = message.ToLower();

            if (Message.Contains("happy"))
            {
                return "HAPPY";
            }
            else if (Message.Contains("sad"))
            {
                return "SAD";
            }
            return "NEUTRAL";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            MoodAnalyzer otherMoodAnalyser = (MoodAnalyzer)obj;
            return message == otherMoodAnalyser.message;
        }
    }


}

