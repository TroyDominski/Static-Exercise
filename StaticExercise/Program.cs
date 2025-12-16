namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(37);
            Console.WriteLine(celcius);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(77);
            Console.WriteLine(fahrenheit);

        }
    }
}
