USE AlSatData
GO

CREATE TRIGGER trgProductStockUpdate ON tblOrders FOR INSERT AS
BEGIN--c sharptaki { scope baþlangýcý yerine düþünebilirsiniz.
	DECLARE @productID INT, @soldQuantity INT
	SELECT @productID=ProductID,@soldQuantity=SoldQuantity FROM inserted
	UPDATE tblProducts SET CurrentStock=CurrentStock-@soldQuantity
	WHERE ID=@productID AND CurrentStock >= @soldQuantity
END-- scope bitiþi
GO