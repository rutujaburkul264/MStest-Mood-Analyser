using System;
using System.Text;

namespace MoodAnalyserAssignment
{
    public class UC3_MoodAnalyser
    {
        private string message;
        public UC3_MoodAnalyser(string message)
        {
            this.message = message;
        }
        //UC1
        public UC3_MoodAnalyser()
        {
        }
        //UC2
        public string analyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            //UC3
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
