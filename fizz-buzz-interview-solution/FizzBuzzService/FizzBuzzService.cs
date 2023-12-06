using System;

namespace FizzBuzz.Services{
    internal class FizzRule
    {
        public bool Check(int number) => number % 3 == 0;
        public string Print() => "Fizz";
    }

    public class FizzBuzzService
    {
        public void Generate(){
            return;
        }

        public string GenerateSingle(int number){
            var FizzRule = new FizzRule();

            if (number % 15 == 0){
                return "FizzBuzz";
            }
            else if (FizzRule.Check(number)){
                return FizzRule.Print();
            }
            else if(number % 5 == 0){
                return "Buzz";
            }
            else{
                return number.ToString();
            }
        }

    }
}