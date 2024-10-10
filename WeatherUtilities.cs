namespace MyUtilities
{
    class WeatherUtilities
    {
        public static float ConvertFahrenheitToCelsius(float temperatureFahrenheit)
        {
            var temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;
            return temperatureCelsius;
        }

        public static float ConvertCelsiusToFahrenheit(float temperatureCelsius)
        {
            var temperatureFahrenheit = temperatureCelsius * 1.8f + 32;
            return temperatureFahrenheit;
        }

        //Lower the index, better the comfort
        public static float CalculateComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            var comfortIndex = (temperatureFahrenheit + humidityPercent) / 4;
            return comfortIndex;
        }

        public static void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = ConvertCelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine("Comfort Index for " + location + ": " + CalculateComfortIndex(temperatureFahrenheit, humidity));
        }
    }
}