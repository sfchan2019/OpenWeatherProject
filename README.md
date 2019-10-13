# Open Weather API Test Project
## Table of Contents
* [Introduction](#introduction)
* [NuGet Packages](#nuget-packages)
* [Running the Test](#running-the-test)
* [Test Implementation](#test-implementation)

## Introduction
This project was created to test the Open Weather API using DTO design pattern and NUint.
The aim is to test the response from the API if it contains the correct data.

## NuGet Packages
 - [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) - A library that allows user to process data in Json format
 - [NUnit](https://www.nuget.org/packages/NUnit/) - NUnit is a unit-testing framework for all .Net languages.
 - [NUnit3TestAdapter](https://www.nuget.org/packages/NUnit3TestAdapter/) - NUnit 3 adapter for running tests in Visual Studio.
 - [RestSharp](https://www.nuget.org/packages/RestSharp/) - A library that allows user to handle connection between Restful APIs.

## Running the Test
1. Clone this project ```https://github.com/pgreene-spartaglobal/OpenWeatherMapTest.git```
2. Open **OpenWeatherMapTest.sln** 
3. Right click on the **'OpenWeatherMapTest'** Project file in the Solution Explorer and click **'Manage NuGet Packages..."**
4. Install all the NuGet packages mentioned in the earlier section
5. Click on **Test -> Windows -> Test Explorer** to open the test menu
6. Click on the Run All buttons in the Test Explorer

## Test Implementation
### Majority of the Tests
* Test the return value is in the correct data type
* Test the return value is in the correct range
* Test the return value is not empty
* Test the return value is matching the expected value

### Testing for Response Status
* Test that the status should be an OK status
* Test that the status should not be a Not Found status

### Testing for Json Attributes
* For each attribute in the result, test if the attribute has the correct data type
* For each attribute that is a numberical value
  * If the attribute is not an internal parameters from the API, test for the value is
    * Greater than 0,
    * or Greater than or equal to 0,
    * or in Range between number 1 and number 2
* For each attribute that is a string
  * Test the length of the string is Greater than 0
* For the attributes temp, temp_min, temp_max
  * Test temp is Greater than or Equal to temp_min
  * Test temp is Less than or Equal to temp_max
  * Test temp_min is Less than or Equal to temp_max
  * Test temp_max is Greater than or equal to temp_min

### Testing for Response Headers
* For each header, test if the value is in the correct data type
  * For each header that return a string value
    * Test the number of character is Greater than 0 so it is not empty
  * For each header that would return a constant/static value, check if it contains the correct value
    * i.e. Content-Type should always be "application/json; charset=utf-8"
  * For each header that return a numerical value 
    * Test that the value is Greater than 0

### Test that could not perform because of unknown boundery
* There are documentations missing about the boundary of attribute, therefore some boundary test could not be done
  * Length of the string
    * No specification of maximum number of character in the string
  * Mininum numerical value
    * No specification of the attribute about minimum value
    * However assumptions can be made for some attributes, i.e. ID should be positve (Greater than 0)
  * Maximum numerical value 
    * No specification of the attribute about maximum value
