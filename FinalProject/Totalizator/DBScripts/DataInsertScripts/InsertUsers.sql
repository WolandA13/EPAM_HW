USE [TotalizatorDB];
GO

INSERT INTO [Users] ([Email], [Password], [RoleId])
VALUES 
('admin@admin.admin', 'admin', 1),
('moderator@moder.moder', 'moderator', 2),
('user@user.user', 'user', 3)
GO