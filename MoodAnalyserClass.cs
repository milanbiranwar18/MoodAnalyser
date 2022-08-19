using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public  class MoodAnalyserClass
    {
        public string message;

        public MoodAnalyserClass(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (this.message.Contains("SAD"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
