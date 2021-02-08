-- Marco Truffat
-- getProductModel
CREATE PROCEDURE spGetProductModelById
	@productModelId int
AS
BEGIN
	SET NOCOUNT ON;
    SELECT DISTINCT ProductModel.ProductModelID, ProductModel.Name, ProductPhoto.LargePhoto, Product.ListPrice FROM Production.ProductModel
    INNER JOIN Production.Product ON ProductModel.ProductModelID = Product.ProductModelID
    INNER JOIN Production.ProductProductPhoto ON Product.ProductID = ProductProductPhoto.ProductID
    INNER JOIN Production.ProductPhoto ON ProductProductPhoto.ProductPhotoID = ProductPhoto.ProductPhotoID
    WHERE Product.ProductModelID = @productModelId ORDER BY Product.ListPrice;
END
GO

-- Get all ProductModel Id and not null
CREATE PROCEDURE spGetAllProductModelId
AS
BEGIN
    SELECT DISTINCT Production.Product.ProductModelID FROM Production.Product 
    WHERE Production.Product.ProductModelID IS NOT NULL;
END
GO

-- Get product sizes from product Id
CREATE PROCEDURE spGetProductModelSizes
    @productModelId int
AS
BEGIN
    SELECT Production.Product.ProductID, Production.Product.Size FROM Production.Product 
    WHERE Production.Product.ProductModelID = @productModelId;
END
GO

