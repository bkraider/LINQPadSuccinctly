<Query Kind="Expression">
  <Connection>
    <ID>4dbb632b-ebd3-46cb-896b-672cdead6e32</ID>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>uspostalcodes</Database>
  </Connection>
</Query>

Places.Take(10)

Places.Select(row => new {row.Place_id, row.Place_name, row.Postal_code})

Places
.Where(row => row.County_id == 1926)
.OrderBy(row => row.Place_name)
.Select(row => new 
{row.Place_id, row.Place_name, row.Postal_code})
