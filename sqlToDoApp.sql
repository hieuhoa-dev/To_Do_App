USE [ToDoApp]
GO

DROP TABLE IF EXISTS [dbo].[Job]; -- Xóa bảng nếu tồn tại

--Tạo bảng Job
CREATE TABLE [dbo].[Job] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    [NameJob] NVARCHAR(200) NULL,
    [ToDate] DATETIME NULL,
    [FromDate] DATETIME NULL,
    [Status] INT NULL,
    [Category] NVARCHAR(100) NULL,
    [LevelJob] INT NULL,
    [Notes] NVARCHAR(1000) NULL,
	[Delete] INT NULL,
	[TimeDelete] DATETIME NULL
);

--Tạo bảng JobChild
CREATE TABLE [dbo].[JobChild] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    [Name] NVARCHAR(200) NULL,
    [Status] INT NULL,
    [JobID] INT NOT NULL,
);

--Tạo bảng Notify
CREATE TABLE [dbo].[Notify] (
    [ID] INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Category] NVARCHAR(200) NULL,
    [NameJob] NVARCHAR(200) NULL
);

--Thủ tục lấy tất cả dữ liệu bảng Job
CREATE PROCEDURE [dbo].[Job_GetAll]
AS
SELECT * FROM Job

--Thủ tục lấy tất cả dữ liệu bảng JobChild
CREATE PROCEDURE [dbo].[JobChild_GetAll]
AS
SELECT * FROM JobChild

--Thủ tục lấy tất cả dữ liệu bảng Notify
CREATE PROCEDURE [dbo].[Notify_GetAll]
AS
SELECT * FROM Notify

--Thủ tục Insert, Update, Delete từ bảng Job
Create PROCEDURE [dbo].[Job_InsertUpdateDelete]
 @ID int output, -- Biến ID tự tăng, khi thêm xong phải lấy ra
 @NameJob nvarchar(200),
 @ToDate DateTime,
 @FromDate DateTime,
 @Status int,
 @Category nvarchar(100),
 @LevelJob Int,
 @Notes nvarchar(1000),
 @Delete INT,
 @TimeDelete DATETIME,
 @Action int -- Biến cho biết thêm, xóa, hay sửa
AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
BEGIN
INSERT INTO Job (NameJob,ToDate,FromDate, [Status],Category,LevelJob,Notes,[Delete],[TimeDelete])
VALUES (@NameJob, @ToDate,@FromDate, @Status,@Category,@LevelJob,@Notes,@Delete,@TimeDelete)
SET @ID = @@identity -- Thiết lập ID tự tăng
END
-- Nếu Action = 1, thực hiện cập nhật dữ liệu
ELSE IF @Action = 1
BEGIN
UPDATE Job SET NameJob = @NameJob, ToDate =@ToDate,
		FromDate =@FromDate,[Status] =@Status,Category =@Category,
		LevelJob = @LevelJob, Notes = @Notes,[Delete] = @Delete, TimeDelete =  @TimeDelete
WHERE [ID] = @ID
END
-- Nếu Action = 2, thực hiện xóa dữ liệu
ELSE IF @Action = 2
BEGIN
DELETE FROM Job WHERE [ID] = @ID
END


--Thủ tục Insert, Update, Delete từ bảng JobChild
Create PROCEDURE [dbo].[JobChild_InsertUpdateDelete]
 @ID int output, -- Biến ID tự tăng, khi thêm xong phải lấy ra
 @Name nvarchar(200),
 @Status int,
 @JobID Int,
 @Action int -- Biến cho biết thêm, xóa, hay sửa
AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
BEGIN
INSERT INTO JobChild ([Name], [Status],JobID)
VALUES (@Name, @Status, @JobID)
SET @ID = @@identity -- Thiết lập ID tự tăng
END
-- Nếu Action = 1, thực hiện cập nhật dữ liệu
ELSE IF @Action = 1
BEGIN
UPDATE JobChild SET [Name] = @Name,[Status] =@Status,JobID =@JobID
WHERE [ID] = @ID
END
-- Nếu Action = 2, thực hiện xóa dữ liệu
ELSE IF @Action = 2
BEGIN
DELETE FROM JobChild WHERE [ID] = @ID
END


--Thủ tục Insert, Update, Delete từ bảng Notify
Create PROCEDURE [dbo].[Notify_InsertUpdateDelete]
 @ID int output, -- Biến ID tự tăng, khi thêm xong phải lấy ra
 @Category NVARCHAR(200) NULL,
 @NameJob NVARCHAR(200) NULL,
 @Action int -- Biến cho biết thêm, xóa, hay sửa
AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
BEGIN
INSERT INTO Notify ([Category], NameJob)
VALUES (@Category, @NameJob)
SET @ID = @@identity -- Thiết lập ID tự tăng
END
-- Nếu Action = 1, thực hiện cập nhật dữ liệu
ELSE IF @Action = 1
BEGIN
UPDATE Notify SET [Category] = @Category,NameJob = @NameJob
WHERE [ID] = @ID
END
-- Nếu Action = 2, thực hiện xóa dữ liệu
ELSE IF @Action = 2
BEGIN
DELETE FROM Notify WHERE [ID] = @ID
END






