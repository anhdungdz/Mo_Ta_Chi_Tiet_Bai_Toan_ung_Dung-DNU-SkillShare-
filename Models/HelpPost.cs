using System.ComponentModel.DataAnnotations;

namespace DashboardDaiNam.Models
{
    public class HelpPost
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

}