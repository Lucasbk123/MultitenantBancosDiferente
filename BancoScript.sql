IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521141440_Inicial')
BEGIN
    CREATE TABLE [Pessoas] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Pessoas] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521141440_Inicial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome') AND [object_id] = OBJECT_ID(N'[Pessoas]'))
        SET IDENTITY_INSERT [Pessoas] ON;
    EXEC(N'INSERT INTO [Pessoas] ([Id], [Nome])
    VALUES (1, N''Pessoa 1'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome') AND [object_id] = OBJECT_ID(N'[Pessoas]'))
        SET IDENTITY_INSERT [Pessoas] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521141440_Inicial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome') AND [object_id] = OBJECT_ID(N'[Pessoas]'))
        SET IDENTITY_INSERT [Pessoas] ON;
    EXEC(N'INSERT INTO [Pessoas] ([Id], [Nome])
    VALUES (2, N''Pessoa 2'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome') AND [object_id] = OBJECT_ID(N'[Pessoas]'))
        SET IDENTITY_INSERT [Pessoas] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521141440_Inicial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome') AND [object_id] = OBJECT_ID(N'[Pessoas]'))
        SET IDENTITY_INSERT [Pessoas] ON;
    EXEC(N'INSERT INTO [Pessoas] ([Id], [Nome])
    VALUES (3, N''Pessoa 3'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nome') AND [object_id] = OBJECT_ID(N'[Pessoas]'))
        SET IDENTITY_INSERT [Pessoas] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220521141440_Inicial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220521141440_Inicial', N'6.0.5');
END;
GO

COMMIT;
GO

