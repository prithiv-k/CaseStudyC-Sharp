-- Insert Stored Procedure
CREATE PROCEDURE sp_InsertEvent
    @EventName NVARCHAR(100),
    @EventCategory NVARCHAR(50),
    @EventDate DATE,
    @Description NVARCHAR(MAX),
    @Status NVARCHAR(50)
AS
BEGIN
    INSERT INTO EventDetails (EventName, EventCategory, EventDate, Description, Status)
    VALUES (@EventName, @EventCategory, @EventDate, @Description, @Status)
END
GO

-- Update Stored Procedure
CREATE PROCEDURE sp_UpdateEvent
    @EventId INT,
    @EventName NVARCHAR(100),
    @EventCategory NVARCHAR(50),
    @EventDate DATE,
    @Description NVARCHAR(MAX),
    @Status NVARCHAR(50)
AS
BEGIN
    UPDATE EventDetails
    SET EventName = @EventName,
        EventCategory = @EventCategory,
        EventDate = @EventDate,
        Description = @Description,
        Status = @Status
    WHERE EventId = @EventId
END
GO

-- Delete Stored Procedure
CREATE PROCEDURE sp_DeleteEvent
    @EventId INT
AS
BEGIN
    DELETE FROM EventDetails WHERE EventId = @EventId
END
GO



	select * from EventDetails