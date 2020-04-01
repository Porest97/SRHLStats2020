using System.ComponentModel.DataAnnotations;

namespace SRHLStats2020.Models.DataModels
{
    public class MatchCategory
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string MatchCategoryName { get; set; }
    }
}