# HowTo-OracleAdo Access
20.06.2021 
Just a Howto access Oracle DB from DotnetCore only with nuget Packages.

## About
Simple Access Oracle Database without any other Client Software Installation.
No Dependency to TNSNames, 
No Dependency to ODBC DataSource.
Just Import an Access.


## Usage
2 Nuget Package need:
1.    ODP.NetCore
1.1.  Install-Package ODP.NetCore -Version 2.0.12
1.2.  https://www.nuget.org/packages/ODP.NetCore/

2.  Oracle Managed Access
2.1 Install-Package Oracle.ManagedDataAccess.Core -Version 3.21.1
2.2 https://www.nuget.org/packages/Oracle.ManagedDataAccess.Core


The Oracle Database must be available on Port 1521 with user dummy. Containing a Table name foo(id int) with 3 Rows in this table.


Press F5 to start
Time : 450 ms - 20.06.2021 

## Contributing
Just a howTo. Sorry

## License
[MIT](https://choosealicense.com/licenses/mit/)