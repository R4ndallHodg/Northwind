RESTORE DATABASE Northwind
FROM DISK = 'H:\Northwind.bak'
WITH FILE = 3,
MOVE 'Northwind'
to 'H:\ProgramData\Sql\MSSQL15.MSSQLSERVER\MSSQL\DATA\northwnd.mdf', move
'Northwind_log'
to 'H:\ProgramData\Sql\MSSQL15.MSSQLSERVER\MSSQL\DATA\northwnd.ldf', recovery

BACKUP DATABASE Northwind
TO DISK = 'H:\Northwind.bak'

use master

Restore Headeronly
FROM DISK = 'H:\Northwind.bak'
/* Estructuras de Control:
   Selectivas: if / Else
   Repetitivas: While 
   Tablas Temporales

   Establecer una tabla de amortización a partir de la solicitud
   de un préstamo bancario con los siguientes parámetros:
   Préstamo, Meses, Tasa Fija Anual
   */
   Use Northwind
   GO
   -- Declaración de la tabla temporal préstamo


   
   Create table Prestamo
   (IdPrestamo int primary key identity(1,1),
    Mes int,
	Fecha date,
	Principal float,
	Cuota float,
	Interes decimal(9,2),
	TasaInteres decimal(9,6),
	AportePrincipal float,
	SaldoFinal float)
	GO


Create or Alter procedure TablaAmortizacion @Principal DECIMAL, @Mes INT, @Interes DECIMAL(10,8), @Incremento DECIMAL(10,8)
	As
		-- Borrando la tabla temporal
		Truncate Table Prestamo
		-----------------------------------------
		-- Declaración de Variables

		Declare  @Fecha date,  @Cuota float,
				 @AportePrincipal float, @SaldoFinal float, @AjusteFecha int
		Declare @Contador int
		Set @Contador = 1
		set @AjusteFecha = 0

	 -- Cálculo de la cuota Fija / Inicializando la fecha
	  --Set @Interes = ((@Interes / 12)/100)
	  set @Cuota = (@Principal * @Interes) / (1 - (power(1 + (@Interes), (@Mes * -1))))
	  --Select @Cuota as Cuota
	  set @Fecha = Getdate()
	  -- Insertando valores a la tabla temporal con el ciclo mientras.
	  while (@Contador <=  @Mes)
	  Begin
		  Set @Fecha = Dateadd(month, 1, @Fecha)
		  if(datename(WEEKDAY, @Fecha) ='Domingo')
		  begin
			  Set @Fecha = Dateadd(day, 1, @Fecha)
			  set @AjusteFecha = 1
		  end

		  If (@Contador = @Mes)
		  Begin
			Set @Cuota = (Select SaldoFinal From Prestamo Where Mes = (@Mes-1)) + ((Select SaldoFinal From Prestamo Where Mes = (@Mes -1)) * @Interes)
		  End


		  If(@Contador = 1)
		  Begin
				Insert into Prestamo values
				(@Contador, @Fecha, @Principal, @Cuota, (@Principal * @Interes), @Interes,
				(@Cuota - (@Principal * @Interes)), (@principal - ((@Cuota - (@Principal * @Interes)))))
				--set @Principal = (@principal - (@Cuota - (@Principal * @Interes)))
				set @Contador = @Contador + 1
				Set @Interes = @Interes + @Incremento
				if (@AjusteFecha = 1)
				Begin
					Set @Fecha = Dateadd(day, -1, @Fecha)
					set @AjusteFecha = 0
				End
		  End
		  Else
		  Begin
			  Insert into Prestamo values
			  (@Contador, @Fecha, (Select SaldoFinal From Prestamo Where Mes = (@Contador -1)), @Cuota, ((Select SaldoFinal From Prestamo Where Mes = (@Contador -1)) * @Interes), @Interes,
			  (@Cuota - ((Select SaldoFinal From Prestamo Where Mes = (@Contador -1)) * @Interes)), ((Select SaldoFinal From Prestamo Where Mes = (@Contador -1)) - (@Cuota - ((Select SaldoFinal From Prestamo Where Mes = (@Contador -1)) * @Interes))))
			   --set @Principal = (@principal - (@Cuota - (@Principal * @Interes)))
			   set @Contador = @Contador + 1
			   Set @Interes = @Interes + @Incremento
			   if (@AjusteFecha = 1)
			   Begin
				Set @Fecha = Dateadd(day, -1, @Fecha)
				set @AjusteFecha = 0
			   End
		  End
	  End
	  go

CREATE OR ALTER procedure EnviarCorreo @correo NVARCHAR(30)
AS
BEGIN
	EXECUTE msdb.dbo.sp_send_dbmail
	@profile_name = 'DBA MAIL',
	@recipients = @correo,
	@subject = 'Tabla de Amortización',
	@body = 'Estimado Cliente, sirva la presente para.....',
	@execute_query_database = 'Northwind',
	@Query = 'Select  Mes as Mes,
			  Fecha as Fecha,
			  CAST(Principal AS DECIMAL (18,2)) as Principal,
			  CAST(Cuota AS DECIMAL (18,2)) as Cuota,
			  CAST(Interes AS DECIMAL (18,2)) as Interés,
			  TasaInteres as [Tasa de Interes],
			  CAST(AportePrincipal AS DECIMAL (18,2)) as [Aporte al Principal],
			  CAST(SaldoFinal AS DECIMAL (18,2)) as [Saldo Final]
			  from Prestamo',
	@query_result_header = 1,
	@attach_query_result_as_file = 1
END

EXECUTE TablaAmortizacion 20000000, 18, 0.01, 0.0005
EXECUTE EnviarCorreo 'randallhodgson8@gmail.com'

TRUNCATE TABLE Prestamo