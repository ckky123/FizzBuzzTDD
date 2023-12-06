using System;

namespace FizzBuzz.Services{
    public class FizzBuzzService
    {
        public void Generate(){
            return;
        }

        public string GenerateSingle(int number){
            if (number % 3 == 0){
                return "Fizz";
            }
            else{
                return number.ToString();
            }
        }
    }
}