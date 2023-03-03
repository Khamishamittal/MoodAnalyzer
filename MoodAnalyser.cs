using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public  class MoodAnalyser
    {
        
            string message;

            public MoodAnalyser(string message)
            {
                this.message = message;
            }

            public string AnalyzeMood()
            {
                try
                {
                    if (this.message.Contains("Sad"))
                        return "SAD";
                    else
                        return "HAPPY";
                }
                catch (NullReferenceException)
                {

                    return "HAPPY";
                }

            }
        }
}

