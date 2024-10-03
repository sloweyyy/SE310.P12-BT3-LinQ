USE [SE310.P12-LinQ]

select
    'data source=' + @@servername +
    ';initial catalog=' + db_name() +
    case type_desc
        when 'WINDOWS_LOGIN'
            then ';trusted_connection=true'
        else
            ';user id=' + suser_name() + ';password=<<YourPassword>>'
        end
        as ConnectionString
from sys.server_principals
where name = suser_name()

CREATE TABLE Product
(
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(50),
    Quantity INT,
    Price MONEY,
    Origin NVARCHAR(50),
    ExpiryDate DATE
)