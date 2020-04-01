using System.ComponentModel.DataAnnotations;

namespace SRHLStats2020.Models.DataModels
{
    public class MatchType
    {
        public int Id { get; set; }
        [Display(Name = "Type")]
        public string MatchTypeName { get; set; }
    }
}