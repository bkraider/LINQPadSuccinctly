<Query Kind="Statements">
  <Connection>
    <ID>4dbb632b-ebd3-46cb-896b-672cdead6e32</ID>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>uspostalcodes</Database>
  </Connection>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

var resultSet = Counties.Where(row =>
(row.State_id > 0 && row.State_id < 20));
resultSet.Dump();
