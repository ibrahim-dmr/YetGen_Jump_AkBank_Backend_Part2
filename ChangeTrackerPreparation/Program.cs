using ChangeTrackerPreparation.Contexts;
using ChangeTrackerPreparation.Entities;
using ChangeTrackerPreparation.Enums;

Console.WriteLine("Change Tracker");

JobPost jobPost1 = new()
{
    Title = "Junior Developer",
    Company = "FoolTech",
    Description = "Bachelor's degree in Computer Science/Engineering or relevant areas, Minimum 3 years experience in " +
    "Net Framework & C# programming language (knowledge and experience in .NET Core is a big plus)",
    WorkMode = WorkMode.InOffice,
    CreatedOn = DateTime.Now,
};

JobHunterDbContext _context = new();

_context.JobPosts.Add(jobPost1);
