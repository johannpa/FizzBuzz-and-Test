﻿namespace FizzBuzz.Services
{
    public class FizzBuzzService
    {
        public string GetFizzBuzz(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "FizzBuzz";
            }
            else
            {

                if(value % 3 == 0)
                {
                    return "Fizz";
                }
                else
                {
                    if(value % 5 == 0)
                    {
                        return "Buzz";
                    }

                    return value.ToString();
                }
            }

        }
    }
}