using System;

namespace FizzBuzz.Services{
    public class FizzBuzzService
    {
        public void Generate(){
            return;
        }

        public string GenerateSingle(int number){
            if (number % 15 == 0){
                return "FizzBuzz";
            }
            else if (number % 3 == 0){
                return "Fizz";
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