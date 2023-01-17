using System;
using System.Collections.Generic;
using System.Linq;
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
                else
                {
                    return "HAPPY";
                }

            }
            catch(Exception e)
            {
                return "HAPPY";
            }

                    }
    }


    
}

