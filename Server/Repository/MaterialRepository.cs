using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NWSInventaire.Server.Data;
using NWSInventaire.Server.Models;

namespace NWSInventaire.Server.Repository
{
    public class MaterialRepository : RepositoryBase
    {
        public MaterialRepository(DataContext context) : base(context) { }

        public string GetAllStudent()
        {
            StudentList studentList = new StudentList();

            studentList.students = Context.students.ToList();

            return JsonConvert.SerializeObject(studentList);
        }

        public string TestMigration()
        {
            try
            {
                Console.WriteLine("Start Migrate");
                Context.Database.Migrate();
                DataContext.Migrated = true;
                Console.WriteLine("Migrate Finish");
                return "Migrate Finish";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Migrante Fail");
                Console.WriteLine(ex);
                return "Migrante Fail   " + ex.ToString();
            }
        }

    }
}
