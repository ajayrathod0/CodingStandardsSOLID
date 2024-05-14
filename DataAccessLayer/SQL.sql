create Database B22ASPDB
go
use B22ASPDB
go

create Table Product (
Id int primary key identity,
Name varchar(100),
Price decimal ,
ImagePath varchar(200),
CreateDate datetime
)

go


create procedure uspCreateProduct
@Name varchar(100), @Price decimal, @ImagePath varchar(200), 
@Status bit 
as
Begin
     begin try
	          Insert into Product values(@Name, @Price, @ImagePath, GetDate())
			  set @Status = 1
	 end try
	 begin catch
	          set @Status = 0
	 end catch
End

go


create proc uspUpdateProduct
 @Id int, @Name varchar(50), @Price varchar(30), @ImagePath int ,
@Status bit output
as
Begin
     Begin try 
	        Begin Transaction
	        if exists(Select Id from Product Where Id = @Id)
			  Begin
			     Update Product set Name = @Name, Price = @Price, ImagePath = @ImagePath
				 where Id = @Id

                 set @Status = 1
              end
			  else
			     begin
				      Set @Status = 0
			     end
             Commit
	 end try
	 Begin catch
	      Rollback
		  Set @Status = 0
	 end catch
end