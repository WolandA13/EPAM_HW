USE [TotalizatorDB];
GO

INSERT INTO [Results] ([Name], [Coefficient], [SportEventId])
VALUES
('1st team winning', 1.84, 1),
('2nd team winning', 1.5, 1),
('Draw', 2.0, 1),
('1st team winning', 1.4, 2),
('2nd team winning', 1.7, 2),
('Draw', 1.2, 2),
('1st team winning', 2.2, 3),
('2nd team winning', 1.1, 3),
('Draw', 1.2, 3)
GO