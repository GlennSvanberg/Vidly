namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'25bcebc3-41ae-494b-a0e9-5136db9a52b1', N'admin@vidly.com', 0, N'AG1PmEay9g3V6H0l45cn3EyJ7uy/aDMfZ+phlClbCspyVeN0XfiXkGJtzcsxuS8c5w==', N'da5ba199-5570-413e-9f2b-916a01cdae81', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3065fa8f-0945-4b5f-a458-75ccd8644a81', N'guest@vidly.com', 0, N'ANugDo6VFFr9HE8jY71psjQ+Xcg8qnDk0RBM/2fLjIS0e28X0qzaLZ5eq2dUZYOB/A==', N'b977068a-f050-417f-8973-6a5b7101a56c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'77633070-5509-44c0-9b96-459894b2a0e6', N'CanManageMovies')

INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'25bcebc3-41ae-494b-a0e9-5136db9a52b1', N'77633070-5509-44c0-9b96-459894b2a0e6')



");
        }

    public override void Down()
        {
        }
    }
}
