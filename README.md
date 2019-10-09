# Open Weather API Test Project
This repository was created to submit my Open Weather API test project.

## Testing for Json Attribute
* For each attribute in the result, test if the attribute has the correct data type
* For each attribute that is a numberical value
  * If the attribute is not an internal parameters from the API, test for the value is
    * Greater than 0,
    * or Greater than or equal to 0,
    * or in Range between number1 and number2
* For each attribute that is a string
  * Test the length of the string is Greater than 0
* For the attributes temp, temp_min, temp_max
  * Test temp is Greater than or Equal to temp_min
  * Test temp is Less than or Equal to temp_max
  * Test temp_min is Less than or Equal to temp_max
  * Test temp_max is Greater than or equal to temp_min

## Testing for Response Headers
* For each header, test that the number of character is Greater than 0 so it is not empty
* For the Content-Type, test that it is returning json content
* For the Content-Length, test that the value is Greater than 0  

## Posible Tests should be carried out
* Format test
  * The attribute weather.icon should be in the format two digit number and an alphabetic character (01a)
  * The header Date should be in the format (Wed, 09 Oct 2019 10:57:28 GMT), short form of the day of the week, two digit number, short form of the month, year in four digit number, time in hh:mm:ss, name of the timezone. 

## Possible Test that would be failed but is reasonable
* Attributes that is under Rain or Snow in the result as they may not be included in the result because the weather is not rainning or snowwing
