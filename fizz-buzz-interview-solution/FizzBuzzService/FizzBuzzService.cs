﻿using System;

namespace FizzBuzz.Services{
    internal class FizzRule
    {
        public bool Check(int number) => number % 3 == 0;
        public string Print() => "Fizz";
    }

    internal class BuzzRule
    {
        public bool Check(int number) => number % 5 == 0;
        public string Print() => "Buzz";
    }
    
    internal class FizzBuzzRule
    {
        public bool Check(int number) => number % 15 == 0;
        public string Print() => "FizzBuzz";
    }

    public class FizzBuzzService
    {
        public void Generate(){
            return;
        }

        public string GenerateSingle(int number){
            var FizzRule = new FizzRule();
            var BuzzRule = new BuzzRule();
            var FizzBuzzRule = new FizzBuzzRule();

            if (FizzBuzzRule.Check(number)){
                return FizzBuzzRule.Print();
            }
            else if (FizzRule.Check(number)){
                return FizzRule.Print();
            }
            else if (BuzzRule.Check(number)){
                return BuzzRule.Print();
            }
            else{
                return number.ToString();
            }
        }

    }
}