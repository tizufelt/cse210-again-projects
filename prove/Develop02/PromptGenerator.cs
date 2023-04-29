using System;
public class promptGenerator{
    List<string> _questions = new List<string>() 
    { 
            "Who was the most interesting person you interacted with today?", 
            "What was the best part of your day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?" 
    };
        
        public promptGenerator()
        {

        }
        public string promptquestion(){
            // Random rnd = new Random();
            // return _questions(rnd.Next(_questions.Count));

            int size = _questions.Count;
            Random rnd = new Random();
            int randIndex = rnd.Next(size);
            string random = _questions[randIndex];
            Console.WriteLine(random);
            return random;
        }
    
}