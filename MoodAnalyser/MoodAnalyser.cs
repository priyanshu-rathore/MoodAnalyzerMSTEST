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
        string message;

        public MoodAnalyzer(string message) {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else if(message.Contains("Happy"))
                {
                    return "HAPPY";
                }
                if(message.Contains(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExpType.Empty_Message, "User of Empty mood");
                }
               
                return default;

            }
            catch(NullReferenceException e)
            {
                return "null mood";
            }

                    }
    }

}

