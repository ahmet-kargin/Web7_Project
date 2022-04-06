USE AlSatData
GO

CREATE TRIGGER trgProductStockUpdate ON tblOrders FOR INSERT AS
BEGIN--c sharptaki { scope başlangıcı yerine düşünebilirsiniz.
	DECLARE @productID INT, @soldQuantity INT
	SELECT @productID=ProductID,@soldQuantity=SoldQuantity FROM inserted
	UPDATE tblProducts SET CurrentStock=CurrentStock-@soldQuantity
	WHERE ID=@productID AND CurrentStock >= @soldQuantity
END-- scope bitişi
GO