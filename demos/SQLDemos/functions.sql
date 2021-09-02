-- functions can be scalar of table valued.

--scalar functions can be create, called, and they return a single value.
CREATE FUNCTION GetMaxValue(@num1 INT, @num2 INT)
RETURNS INT
AS
BEGIN
	RETURN 
	CASE
	WHEN @num1>@num2 THEN @num1
	ELSE @num2
	END
END

SELECT dbo.GetMaxValue(10,101) AS MaximumValue;

-----------------
--Table Valued Functions
CREATE FUNCTION AllOrders()
RETURNS TABLE
AS
	RETURN (SELECT * FROM Orders);

SELECT * FROM AllOrders() AS AllTheOrders;

--function with a
CREATE FUNCTION AllOrdersUnderMax(@max INT)
RETURNS TABLE
AS
	RETURN (SELECT * FROM Orders WHERE totalAmount < @max);

--query the function with some filtering as to what is displayed.
SELECT CustomerID, totalAmount As totsAmounts FROM AllOrdersUnderMax(45);

