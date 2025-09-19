-------------------------------- SP Productos-----------------------------
CREATE PROCEDURE SP_ObtenerProducto
AS
BEGIN
	SELECT 
	P.IDProductos ID,
	P.Titulo NOMBRE,
	P.Descripcion,
	P.PrecioUnitario [PRECIO UNITARIO],
	P.Existencias
	FROM [dbo].[Productos] P
END
GO

CREATE PROCEDURE SP_ObtenerProductoID
	@ID INT
AS
BEGIN
	SELECT 
	P.IDProductos ID,
	P.Titulo NOMBRE,
	P.Descripcion,
	P.PrecioUnitario [PRECIO UNITARIO],
	P.Existencias
	FROM [dbo].[Productos] P
	WHERE P.IDProductos = @ID
END
GO

CREATE PROCEDURE SP_CantidadExistenciaProducto
AS
BEGIN
	SELECT 
	P.Titulo,
	P.Existencias
	FROM [dbo].[Productos] P
END
GO
-------------------------------- SP ventas-----------------------------
CREATE PROCEDURE SP_VentaDeProducto
	@Producto int
AS
BEGIN
	SELECT 
	V.IDVentas ID,
	P.Titulo NOMBRE,
	V.CantidadVendida CANTIDAD,
	P.PrecioUnitario PRECIO,
	P.PrecioUnitario * V.CantidadVendida TOTAL,
	CONVERT(varchar(10),V.Fecha,103) FECHA
	FROM [dbo].[Ventas] v
	INNER JOIN [dbo].[Productos] P
		ON V.IDProductos = P.IDProductos
	WHERE P.IDProductos = @Producto
END
GO


CREATE PROCEDURE SP_VentasTotales
AS
BEGIN
	SELECT 
	V.IDVentas ID,
	P.Titulo NOMBRE,
	V.CantidadVendida CANTIDAD,
	P.PrecioUnitario PRECIO,
	P.PrecioUnitario * V.CantidadVendida TOTAL,
	CONVERT(varchar(10),V.Fecha,103) FECHA
	FROM [dbo].[Ventas] V
	INNER JOIN [dbo].[Productos] P
		ON V.IDProductos = P.IDProductos
END
GO

CREATE PROCEDURE SP_VentasXArticulo
	@Id int
AS
BEGIN
	SELECT 
	V.IDVentas,
	SUM(v.CantidadVendida) [CANTIDAD VENTA],
	V.IDProductos IdProducto,
	P.Titulo,
	V.Fecha
	FROM [dbo].[Ventas] V
	INNER JOIN [dbo].[Productos] P
		ON V.[IDProductos] = P.[IDProductos]
	WHERE V.IDProductos = @Id
	GROUP BY P.Titulo, V.IDProductos,V.Fecha,V.IDVentas
END
GO

CREATE PROCEDURE SP_TopVentas
AS
BEGIN
	SELECT TOP 3
	V.IDVentas ID,
	P.Titulo NOMBRE,
	V.CantidadVendida CANTIDAD,
	P.PrecioUnitario PRECIO,
	P.PrecioUnitario * V.CantidadVendida TOTAL,
	CONVERT(varchar(10),V.Fecha,103) FECHA
	FROM [dbo].[Ventas] V
	INNER JOIN [dbo].[Productos] P
		ON V.IDProductos = P.IDProductos
	ORDER BY V.CantidadVendida DESC
END
GO

-------------------------------- PRUEBAS SP-----------------------------
EXECUTE dbo.SP_VentaDeProducto @Producto = 1
EXEC dbo.SP_CantidadExistenciaProducto @Producto = 2

EXEC dbo.SP_VentasXArticulo @Id = 2


SELECT 
SUM(v.CantidadVendida) [CANTIDAD VENTA],
P.Titulo
FROM [dbo].[Ventas] V
INNER JOIN [dbo].[Productos] P
	ON V.[IDProductos] = P.[IDProductos]
GROUP BY P.Titulo
select * from Ventas


SELECT V.IDVentas,P.Titulo FROM Ventas V INNER JOIN Productos P ON V.IDProductos= P.IDProductos ORDER BY P.Titulo


select * from dbo.Productos