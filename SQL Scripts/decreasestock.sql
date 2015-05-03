-- =============================================
-- Author:		José Cavalheiro
-- Create date: 21/04/2015
-- Description:	increase stock procedure
-- =============================================
CREATE PROCEDURE DecreaseStock(@category VARCHAR(255), @option VARCHAR(255)) as
UPDATE inventory
SET stock_quantity = stock_quantity - 1
WHERE component_category=@category AND component_option=@option AND stock_quantity > 0;
