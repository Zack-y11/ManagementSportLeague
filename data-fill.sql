/* 
use SportsLeagueDB;

INSERT INTO MatchStatus (Status) Values ('In Progress'), ('Completed');

SELECT * FROM Players;

SELECT * FROM Teams
SELECT * FROM Users

-- First create manager users for both teams
INSERT INTO Users (Name, Password, Email, RoleId)
VALUES 
    ('Barcelona Manager', 'barcelona', 'barca.manager@gmail.com', 
        (SELECT RoleId FROM Roles WHERE RolelName = 'Coach')),
    ('Madrid Manager', 'barcelona', 'madrid.manager@example.com', 
        (SELECT RoleId FROM Roles WHERE RolelName = 'Coach'));

SELECT * FROM Users


-- Then create the teams
INSERT INTO Teams (ManagerId, TeamName, Wins, Loses, Points)
VALUES
    ((SELECT UserId FROM Users WHERE Name = 'Barcelona Manager'), 
     'Barcelona', 0, 0, 0),
    ((SELECT UserId FROM Users WHERE Name = 'Madrid Manager'), 
     'Real Madrid', 0, 0, 0);

SELECT * FROM Teams;

-- CREATE MATCH BETWEEN BARCA AND MADRID
INSERT INTO Matches (HomeTeamId, AwayTeamId, StatusId, Score, MatchDate, Fouls, Corners)
SELECT 
    (SELECT TeamId FROM Teams WHERE TeamName = 'Real Madrid') as HomeTeamId,
    (SELECT TeamId FROM Teams WHERE TeamName = 'Barcelona') as AwayTeamId,
    (SELECT StatusId FROM MatchStatus WHERE Status = 'Scheduled') as StatusId,
    '0-0' as Score,  -- Initial score
    '2024-12-31' as MatchDate,
    0 as Fouls,      -- Initial fouls
    0 as Corners     -- Initial corners
;

-- GET THE RIVAL TEAM NAME AND MATCH DATE OF THE NEXT MATCH BASED ON THE COACH
SELECT 
    M.MatchDate,
    CASE 
        WHEN M.HomeTeamId = T.TeamId THEN AwayTeam.TeamName
        ELSE HomeTeam.TeamName
    END AS RivalTeamName
FROM Teams T
JOIN Matches M ON (T.TeamId = M.HomeTeamId OR T.TeamId = M.AwayTeamId)
JOIN Teams HomeTeam ON M.HomeTeamId = HomeTeam.TeamId
JOIN Teams AwayTeam ON M.AwayTeamId = AwayTeam.TeamId
JOIN MatchStatus MS ON M.StatusId = MS.StatusId
WHERE 
    T.ManagerId = 4
    AND M.MatchDate >= GETDATE()
    AND MS.Status = 'Scheduled'  -- Assuming this is the status for upcoming matches
ORDER BY 
    M.MatchDate ASC
;  -- Gets only the next match
*/

CREATE PROCEDURE GetNextMatchRivalTeamAndDate
@UserId INT
AS
BEGIN
	SELECT 
		M.MatchDate,
		CASE 
			WHEN M.HomeTeamId = T.TeamId THEN AwayTeam.TeamName
			ELSE HomeTeam.TeamName
		END AS RivalTeamName
	FROM Teams T
	JOIN Matches M ON (T.TeamId = M.HomeTeamId OR T.TeamId = M.AwayTeamId)
	JOIN Teams HomeTeam ON M.HomeTeamId = HomeTeam.TeamId
	JOIN Teams AwayTeam ON M.AwayTeamId = AwayTeam.TeamId
	JOIN MatchStatus MS ON M.StatusId = MS.StatusId
	WHERE 
		T.ManagerId = @UserId
		AND M.MatchDate >= GETDATE()
		AND MS.Status = 'Scheduled'  -- Assuming this is the status for upcoming matches
	ORDER BY 
		M.MatchDate ASC
	;  -- Gets only the next match
END;