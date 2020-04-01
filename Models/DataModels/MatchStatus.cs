using System.ComponentModel.DataAnnotations;

namespace SRHLStats2020.Models.DataModels
{
    public class MatchStatus
    {
        public int Id { get; set; }
        [Display(Name = "Status")]
        public string MatchStatusName { get; set; }
    }
}