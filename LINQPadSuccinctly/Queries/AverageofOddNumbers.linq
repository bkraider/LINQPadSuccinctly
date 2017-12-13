<Query Kind="Statements">
  <Connection>
    <ID>4dbb632b-ebd3-46cb-896b-672cdead6e32</ID>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>uspostalcodes</Database>
  </Connection>
</Query>

int[] numbers = {1,1,2,3,5,8,13,21,34}; 
double average = numbers.Where(number => number % 2 == 1).Average(); 
Console.WriteLine(average);