using System.ComponentModel.DataAnnotations;

namespace PlannerApi.Infrastructure
{
    public class TestEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
