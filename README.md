# Open Weather API Test Project
This repository was created to submit my Open Weather API test project.

## Testing for Json Attribute
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

## Testing for Response Headers
* For each header, test if the value is in the correct data type
  * For each header that return a string value
    * Test the number of character is Greater than 0 so it is not empty
  * For each header that would return a constant/static value, check if it contains the correct value
    * i.e. Content-Type should always be "application/json; charset=utf-8"
  * For each header that return a numerical value 
    * Test that the value is Greater than 0

## Posible Tests should be carried out
* Format Test
  * The attribute weather.icon should be in the format two digit number and an alphabetic character (01a)
  * The header Date should be in the format (Wed, 09 Oct 2019 10:57:28 GMT), short form of the day of the week, two digit number, short form of the month, year in four digit number, time in hh:mm:ss, name of the timezone

## Possible Test that would be failed but is reasonable
* Attributes that is under Cloud, Rain, or Snow in the result as they may not be included in the result because the existence of these attributes are based on the weather

## Test that could not perform because of unknown boundery
* There are documentations missing about the boundary of attribute, therefore some boundary test could not be done
  * Length of the string
    * No specification of maximum number of character in the string
  * Mininum numerical value
    * No specification of the attribute about minimum value
    * However assumptions can be made for some attributes, i.e. ID should be positve (Greater than 0)
  * Maximum numerical value 
    * No specification of the attribute about maximum value
