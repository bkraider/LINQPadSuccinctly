<Query Kind="Statements">
  <Connection>
    <ID>4dbb632b-ebd3-46cb-896b-672cdead6e32</ID>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>uspostalcodes</Database>
  </Connection>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

var predicate = 
PredicateBuilder.False<Counties>();

predicate = predicate.Or(row =>
row.State_id > 0);

predicate = predicate.And(row =>
row.State_id < 20);

predicate = predicate.Or(row =>
row.County_name.Contains("Orange"));

var resultSet = Counties.Where(predicate);
resultSet.Dump();
