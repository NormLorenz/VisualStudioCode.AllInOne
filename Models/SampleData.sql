<Query Kind="SQL">
  <Connection>
    <ID>8600a094-5f03-4d50-aa21-2a67f231080b</ID>
    <Persist>true</Persist>
    <Server>(localdb)\v11.0</Server>
    <Database>Sales</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

USE Sales
GO

--ALTER DATABASE Sales
--SET SINGLE_USER
--WITH ROLLBACK IMMEDIATE;
--DROP DATABASE Sales
--GO

INSERT INTO dbo.Code (Display, Value)
	SELECT 'Unknown', '' UNION 
	SELECT 'Alabama', 'AL' UNION 
	SELECT 'Alaska', 'AK' UNION 
	SELECT 'Arizona', 'AZ' UNION 
	SELECT 'Arkansas', 'AR' UNION 
	SELECT 'California', 'CA' UNION 
	SELECT 'Colorado', 'CO' UNION 
	SELECT 'Connecticut', 'CT' UNION 
	SELECT 'Delaware', 'DE' UNION 
	SELECT 'Florida', 'FL' UNION 
	SELECT 'Georgia', 'GA' UNION 
	SELECT 'Hawaii', 'HI' UNION 
	SELECT 'Idaho', 'ID' UNION 
	SELECT 'Illinois', 'IL' UNION 
	SELECT 'Indiana', 'IN' UNION 
	SELECT 'Iowa', 'IA' UNION 
	SELECT 'Kansas', 'KS' UNION 
	SELECT 'Kentucky', 'KY' UNION 
	SELECT 'Louisiana', 'LA' UNION 
	SELECT 'Maine', 'ME' UNION 
	SELECT 'Maryland', 'MD' UNION 
	SELECT 'Massachusetts', 'MA' UNION 
	SELECT 'Michigan', 'MI' UNION 
	SELECT 'Minnesota', 'MN' UNION 
	SELECT 'Mississippi', 'MS' UNION 
	SELECT 'Missouri', 'MO' UNION 
	SELECT 'Montana', 'MT' UNION 
	SELECT 'Nebraska', 'NE' UNION 
	SELECT 'Nevada', 'NV' UNION 
	SELECT 'New Hampshire', 'NH' UNION 
	SELECT 'New Jersey', 'NJ' UNION 
	SELECT 'New Mexico', 'NM' UNION 
	SELECT 'New York', 'NY' UNION 
	SELECT 'North Carolina', 'NC' UNION 
	SELECT 'North Dakota', 'ND' UNION 
	SELECT 'Ohio', 'OH' UNION 
	SELECT 'Oklahoma', 'OK' UNION 
	SELECT 'Oregon', 'OR' UNION 
	SELECT 'Pennsylvania', 'PA' UNION 
	SELECT 'Rhode Island', 'RI' UNION 
	SELECT 'South Carolina', 'SC' UNION 
	SELECT 'South Dakota', 'SD' UNION 
	SELECT 'Tennessee', 'TN' UNION 
	SELECT 'Texas', 'TX' UNION 
	SELECT 'Utah', 'UT' UNION 
	SELECT 'Vermont', 'VT' UNION 
	SELECT 'Virginia', 'VA' UNION 
	SELECT 'Washington', 'WA' UNION 
	SELECT 'West Virginia', 'WV' UNION 
	SELECT 'Wisconsin', 'WI' UNION 
	SELECT 'Wyoming', 'WY' UNION 
	SELECT 'American Samoa', 'AS' UNION 
	SELECT 'District of Columbia', 'DC' UNION 
	SELECT 'Federated States of Micronesia', 'FM' UNION 
	SELECT 'Guam', 'GU' UNION 
	SELECT 'Marshall Islands', 'MH' UNION 
	SELECT 'Northern Mariana Islands', 'MP' UNION 
	SELECT 'Palau', 'PW' UNION 
	SELECT 'Puerto Rico', 'PR' UNION 
	SELECT 'Virgin Islands', 'VI' UNION 
	SELECT 'Armed Forces Africa', 'AE' UNION 
	SELECT 'Armed Forces Americas', 'AA' UNION 
	SELECT 'Armed Forces Canada', 'AE' UNION 
	SELECT 'Armed Forces Europe', 'AE' UNION 
	SELECT 'Armed Forces Middle East', 'AE' UNION 
	SELECT 'Armed Forces Pacific', 'AP'
GO

INSERT INTO  dbo.Product (Name, Category, Price)
	SELECT 'Tomato Soup', 'Groceries', 1.09 UNION
	SELECT 'Yo-yo', 'Toys', 3.75 UNION
	SELECT 'Hammer', 'Hardware', 16.99 UNION
	SELECT 'Wrench', 'Hardware', 24.99 UNION
	SELECT 'Eggs', 'Groceries', 2.50
GO
	
	
    		
			
			
			
			
			
			
			
			
			
			
			
			
			