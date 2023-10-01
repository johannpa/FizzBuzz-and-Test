namespace FizzBuzz.Services
{
    public class FizzBuzzService
    {
        public string GetFizzBuzz(int value)
        {
            string result = string.Empty;
            
            if(value % 3 == 0)
            {
                result = "Fizz";
            }
                
            if(value % 5 == 0)
            {
                result += "Buzz";
            }

            if(string.IsNullOrEmpty(result))
            {
                result = value.ToString();
            }

            return result;

        }
    }
}