namespace QuanLyDeTaiKhoaHoc.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<QuanLyDeTaiKhoaHoc.DAL.QuanLyDeTaiKhoaHocContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuanLyDeTaiKhoaHoc.DAL.QuanLyDeTaiKhoaHocContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
