What is the target of Azure SQL Databases.
Azure SQL Databases target online transaction processing (OLTP; that is, data entry and retrieval transactions) workloads.

By default, how many logical SQL Database servers can you have per Azure subscription?
By default, you can have up to six logical SQL Database servers per Azure subscription.

Why does the connection string set the TrustServerCertificate property to False and the Encrypt property to True?
This is to provide additional protection while accessing SQL Database over the Internet. Doing so helps thwart potential man-in the-middle attacks. SQL Database will force the connection to be encrypted regardless of the setting.

What are transient errors?
Transient errors are errors that are intermittent and likely will be resolved if the command is retried. These errors are more common with SQL Database than with databases accessed via a local area network (LAN). This is due to the inherently unreliable network that is the Internet and the fact that as a managed service, SQL Database might periodically undergo maintenance activities that could cause connections to drop temporarily.

What three things contribute to the total cost for running a SQL Server deployment on Azure Virtual Machines?
The cost for SQL Server in Azure Virtual Machines can be represented as Total cost = Windows Server cost + SQL Server license cost + Azure Storage cost. If you have your own SQL Server license, you can use that instead of paying the per-minute charge associated with using a SQL Server license obtained from an Azure Virtual Machines image. In this case, you pay only for the Windows Server license and any related Azure Storage costs.

Why do you need to be concerned about high availability and disaster recovery for SQL Server in Azure Virtual Machines?
Azure provides high-availability features for the VMs, but not necessarily for SQL Server running on the VM. It is possible for the VM to be online but the SQL Server instance to be offline, unhealthy, or both. Additionally, it is possible for the VM to unavailable due to hardware failure or software upgrades. Therefore, a practiced HADR strategy should be considered.

What are six SQL Server features that are not currently supported in SQL Database (according to the book)?
SQL Server features that are not currently supported in SQL Database are: 
Windows authentication.
FILESTREAM data.
Database mirroring.
Extended stored procedures.
SQL Server Agent/Jobs.
SQL Server Reporting Services (SSRS) and SQL Server Integration Services (SSIS) are not supported. Alternatively, run a SQL Server on-premises or in an Azure VM and connect to a SQL database.
T-SQL features: 
USE statement is not supported. To change databases, a new connection must be established.
Common language runtime (CLR).
Cross-database queries using three or four part names.

Name four factors to consider when choosing between SQL Database and SQL Server in Azure Virtual Machines.
Factors to consider when choosing between SQL Database and SQL Server in Azure Virtual Machines are database size, existing application versus new application, level of administrative control (including hardware infrastructure), business continuity strategy, and hybrid scenarios, just to name a few.

Who did Microsoft collaborate with to bring their ClearDb database as a service for MySQL to the Azure platform?
Microsoft has collaborated with SuccessBricks to bring SuccessBricks’ ClearDb database as a service for MySQL to the Azure platform.

What two options exist in Azure if you don’t need a relational database management system (RDBMS)–based data storage solution such as SQL Database or SQL Server in Azure Virtual Machines?
Azure provides two NoSQL options: DocumentDB and Azure Table storage.