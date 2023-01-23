using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static MoodAnalyzer createMoodAnalyser()
        {
            try
            {
                Type type = typeof(MoodAnalyzer);
                return (MoodAnalyzer)Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExpType.OBJECT_CREATION_ISSUE, "Unable to create object of MoodAnalyser");
            }
        }

        public static MoodAnalyzer createMoodAnalyser(string className)
        {
            try
            {
                Type type = Type.GetType(className);
                if (type == null)
                    throw new MoodAnalysisException(MoodAnalysisException.ExpType.NO_SUCH_CLASS, "No Such Class Error");
                return (MoodAnalyzer)Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExpType.OBJECT_CREATION_ISSUE, "Unable to create object of MoodAnalyser", e);
            }



        }
    }
}