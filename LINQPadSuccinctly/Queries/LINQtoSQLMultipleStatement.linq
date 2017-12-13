<Query Kind="Statements">
  <Connection>
    <ID>4dbb632b-ebd3-46cb-896b-672cdead6e32</ID>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>uspostalcodes</Database>
  </Connection>
</Query>

var places = Places.GroupBy( row =>
row.County_id);

var placesSorted = from place in places
orderby place.Key
select place;

placesSorted.Dump();