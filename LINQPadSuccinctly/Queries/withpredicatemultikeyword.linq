<Query Kind="Statements">
  <Connection>
    <ID>4dbb632b-ebd3-46cb-896b-672cdead6e32</ID>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>uspostalcodes</Database>
  </Connection>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

var keywords = new List<string> 
{"Orange", "York", "Fernando"};

var predicate = 
PredicateBuilder.False<Counties>();

foreach(string keyword in keywords)
{
	predicate = predicate.Or(row =>
	row.County_name.Contains(keyword));
}

var resultSet = Counties.Where(predicate).OrderBy(row => row.County_name);
resultSet.Dump();
