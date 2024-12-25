using System.Collections.ObjectModel;

namespace ApplicationDevelopment.WebMVC.Data.Entities
{
    /// <summary>
    /// Job Type: FullTime, Part-time, Casual, Season, Mannual, Office
    /// Is the parent of Job (similar to Category and Product)
    /// </summary>
    public class JobType
    {
        public JobType()
        {
            Id = Guid.NewGuid();
            Jobs = new Collection<Job>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Position { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
