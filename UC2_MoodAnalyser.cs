using System;
using System.Text;

namespace MoodAnalyserAssignment
{
    public class UC2_MoodAnalyser
    {
        private string message;
        public UC2_MoodAnalyser(string message)
        {
            this.message = message;
        }
        public UC2_MoodAnalyser()
        {
        }
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
            catch (ArgumentNullException)
            {
               

            }
        }
    }
}
