using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    public class AnswerGenerator
    {
        private static string[] answers = { "Yes Definitely" , "Signs Point To Yes" , "Most Likely" , "Without A Doubt" ,
                "Reply Hazy, Try Again" , "Ask again later" , "Cannot predict now" , "Better Not Tell You Now",
                "My Reply Is No" , "My Sources Say No" , "Outlook Not So Good" , "Very Doubtful" };

        private static string[] thinkingMessages = { 
            "The Magic 8 Ball is pondering your question...","Shaking the Magic 8 Ball... Hold on.",
            "Consulting the spirits... Please wait.", "The future is unclear... Let me check again.",
            "The Magic 8 Ball is deep in thought...", "Rolling the mystical dice... Almost ready.",
            "Hmmm... This one is tricky.", "I must ask the cosmic forces... Give me a moment..." };

        public static string GenerateAnswer()
        {
            var rand = new Random();
            string randomAnswer = answers[rand.Next(answers.Length)];
            return $"{randomAnswer}";
        }

        public static string ThinkingMessageGenerate()
        {
            var rand = new Random();
            string randomThinkingMessage = thinkingMessages[rand.Next(thinkingMessages.Length)];
            return $"{randomThinkingMessage}";
        }
    }
}
