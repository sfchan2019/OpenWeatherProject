# Open Weather API Test Project
This repository was created to submit my Open Weather API test project.

## Testing for Json Attribute
* For each attribute in the result, test if the attribute has the correct data type.
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

