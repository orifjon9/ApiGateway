### CatalogApi - 7001
### OrdersApi - 7002
### GatewayApi - 7000

ApiGatewayExample <br>
  ---->	CatalogApi <br>
  ----> OrderApi <br>
  ----> GatewayApi <br>


Configure Ocelot <br>
	add nuget package anf that called 'Ocelot' and add it to GatewayApi project <br>
	configure  <br>
	- add ocelot.json  <br>
	changes in Startup and Programm files  <br>
	links to ocelot docs http://threemammals.com/ocelot  <br>
		- add rules  <br>

http://localhost:7000/catalog-api/currencies  ======> 	http://localhost:7001/api/currencies  <br>
http://localhost:7000/orders-api/orders  ======>  http://localhost:7002/api/orders