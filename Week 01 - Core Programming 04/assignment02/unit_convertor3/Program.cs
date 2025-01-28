using System;
class UnitConverter
{
public static double ConvertFarhenheitToCelsius(double farhenheit) => (farhenheit - 32) * 5 / 9;
public static double ConvertCelsiusToFarhenheit(double celsius) => (celsius * 9 / 5) + 32;
public static double ConvertPoundsToKilograms(double pounds) => pounds * 0.453592;
public static double ConvertKilogramsToPounds(double kilograms) => kilograms * 2.20462;
public static double ConvertGallonsToLiters(double gallons) => gallons * 3.78541;
public static double ConvertLitersToGallons(double liters) => liters * 0.264172;
}
