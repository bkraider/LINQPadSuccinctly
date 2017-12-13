<Query Kind="Expression">
  <Connection>
    <ID>4dbb632b-ebd3-46cb-896b-672cdead6e32</ID>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>uspostalcodes</Database>
  </Connection>
</Query>

Places.Where(row => row.County_id == 1926)

Places.GroupBy(row => row.County_id)