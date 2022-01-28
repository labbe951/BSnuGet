# BSnuGet
This is a simple convertion nuget
===================================================================================================================

Step 1.
  * Install nuget called BSnugget

Step 2. 
  * Add a using statement, example: using BSnugget.Features;

step 3. 
  * Create a factory, example: var converterFactory = new ConverterFactory();

step 4. 
  * Get converter, example: var convertToKg1 = converterFactory.GetConverter("Converter");
  * It is crucial that the parameter in GetConverter is a string called Converterfor this to work, exapmle: "Converter" 

Step 5.
  * Optional create a variable and asign a number to it.
  * The number need to be of type double.

step 6.
  * Use one of the methods presented when writing convertToKg1.MethodToUse(variable or double)

step 7.
  * Console.Writeline your answer.

This is a code example.
=======================================================================================================================

using BSnugget.Features;

var converterFactory = new ConverterFactory();

var convertToKg1 = converterFactory.GetConverter("Converter");

var lbs = 100.0;

var kg = convertToKg1.ConvertLbsToKg(lbs);

Console.WriteLine($" This is the answer: {lbs} lbs = {Math.Round(kg, 2)} kg"); 

Console.ReadKey();
