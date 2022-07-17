using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PlannerApi.Infrastructure
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
