namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5f0ee41b-7547-4697-8095-b753c537a5ba', N'admin@vidly.com', 0, N'AAnpYsYFuCXODuJd1T+Dq7IgirSjiJOAGtxiQCh8blJWZ89a2uTCDg8xop2/1+Xj/Q==', N'4f7d32b8-2878-4db4-ba46-ee17676bf1af', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'69008d1d-c759-42af-b959-8b648cae7312', N'guest@vidly.com', 0, N'AMMyP2O7t5Vyr/qsg0oPLsqlqqxrWx5prlaOXk12HO1Z3/yI5RyIiwaYMQoeMWMQ7Q==', N'516b329a-700d-448d-bbc2-6fcdcc21355b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ca8d50c4-532e-4b51-8e2f-9e9f0f359298', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5f0ee41b-7547-4697-8095-b753c537a5ba', N'ca8d50c4-532e-4b51-8e2f-9e9f0f359298')

");
        }
        
        public override void Down()
        {
        }
    }
}
