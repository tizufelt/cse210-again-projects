using System;
public class Entry1{

        public string _entry;
        public string _prompt;
        public string _date;

        DateTime today = DateTime.Now;
        public void Writeprompt()
        {

         _date = today.ToString("MM/dd/yyyy");
         promptGenerator prompt1 = new promptGenerator();
         _prompt =prompt1.promptquestion();
        _entry = Console.ReadLine();
        }
        public void display(){
                Console.WriteLine($"Date:{_date}-Prompt:{_prompt}\n\t{_entry}");
        }

        public string something(){
                return $"{_date},{_prompt},{_entry}";
        }
        public void creatlist(string[] entrysomething){
                _date = entrysomething[0];
                _prompt = entrysomething[1];
                _entry = entrysomething[2];
        }
}
