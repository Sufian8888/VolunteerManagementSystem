USE VMS;
CREATE TABLE [Admin]
(
AName varchar(10),
APassword VARCHAR(10) PRIMARY KEY,
);

INSERT INTO [Admin]
VALUES
('ADIL','ADIL123');
SELECT * FROM Admin;
DROP TABLE VOLUNTEER;
CREATE TABLE VOLUNTEER
(
Volunteer_ID VARCHAR (5)Primary Key,
V_Name VARCHAR(20),
Email VARCHAR(20),
Skills VARCHAR(10),
V_Availability VARCHAR(10),
Registration_Date VARCHAR(10),
ProjectID VARCHAR(10) Foreign Key (ProjectID) REFERENCES PROJECT(ProjectID),
);
	INSERT INTO VOLUNTEER(Volunteer_ID,V_Name,Email,Skills,V_Availability,Registration_Date,ProjectID)
	VALUES
	('V-1','Ahmad','MahamadV-1@gmail.com','C++,Web','8 HOURS',10/10/2020,'P-1'),
	('V-2','Ali','MaliV-2@gmail.com','C#,App','8 HOURS',10/10/2020,'P-2');
CREATE TABLE PROJECT 
(
ProjectID VARCHAR(10) Primary Key,
ProjectName VARCHAR(20),
Description VARCHAR(20),
);
INSERT INTO PROJECT(ProjectID,ProjectName,Description)
VALUES
('P-1','RECORD SYSTEM','C++'),
('P-2','APP GAME','FLUTTER');
CREATE TABLE ASSIGNMENT 
(
AssignmentID VARCHAR(5)Primary KeY,
Volunteer_ID VARCHAR (5)Foreign Key (Volunteer_ID) REFERENCES VOLUNTEER(Volunteer_ID),
ProjectID VARCHAR(10) Foreign Key (ProjectID) REFERENCES PROJECT(ProjectID),
AssignmentDate DATE ,
);


--// some OPERATION Performing in Sql
SELECT PROJECT.ProjectName,PROJECT.Description,VOLUNTEER.Volunteer_ID,VOLUNTEER.V_Name,VOLUNTEER.Email
FROM PROJECT,VOLUNTEER
WHERE PROJECT.ProjectID=VOLUNTEER.ProjectID;
SELECT * FROM VOLUNTEER;
DELETE FROM VOLUNTEER WHERE VOLUNTEER.V_Name = 'Ahmad';





SELECT VOLUNTEER.Volunteer_ID, VOLUNTEER.V_Name, VOLUNTEER.Email, VOLUNTEER.Skills,
       VOLUNTEER.V_Availability, VOLUNTEER.Registration_Date,
       PROJECT.ProjectID, PROJECT.ProjectName, PROJECT.Description
FROM VOLUNTEER
INNER JOIN PROJECT ON VOLUNTEER.ProjectID = PROJECT.ProjectID;


SELECT ASSIGNMENT.AssignmentID, VOLUNTEER.Volunteer_ID, VOLUNTEER.V_Name, PROJECT.ProjectID, PROJECT.ProjectName, ASSIGNMENT.AssignmentDate
FROM ASSIGNMENT
INNER JOIN VOLUNTEER ON ASSIGNMENT.Volunteer_ID = VOLUNTEER.Volunteer_ID
INNER JOIN PROJECT ON ASSIGNMENT.ProjectID = PROJECT.ProjectID;


CREATE PROCEDURE GetVolunteerInfo
    @VolunteerID VARCHAR(5)
AS
BEGIN
    SELECT Volunteer_ID, V_Name, Email, Skills, V_Availability, Registration_Date, ProjectID
    FROM VOLUNTEER
    WHERE Volunteer_ID = @VolunteerID;
END;

EXEC GetVolunteerInfo @VolunteerID = 'V-1';
