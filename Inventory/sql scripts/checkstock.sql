-- =============================================
-- Author:		José Cavalheiro
-- Create date: 21/04/2015
-- Description:	check stock procedure
-- =============================================
CREATE PROCEDURE CheckStock(@category VARCHAR(255), @option VARCHAR(255)) as
SELECT stock_quantity
FROM inventory
WHERE component_category=@category AND component_option=@option
FOR XML AUTO, XMLDATA;
