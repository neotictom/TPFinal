CREATE PROCEDURE CambiarContraseña
(
    -- Add the parameters for the stored procedure here
    @Username varchar(50),
    @Contraseña varchar(50)
)
AS
BEGIN
    Update Usuario Set Password = @Contraseña Where Username = @Username
END
GO