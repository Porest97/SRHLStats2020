using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SRHLStats2020.Models.DataModels
{
    public class Team
    {
        public int Id { get; set; }

        [Display(Name = "Team")]
        public string TeamName { get; set; }

        [Display(Name = "Club")]
        public int? ClubId { get; set; }
        [Display(Name = "Club")]
        [ForeignKey("ClubId")]
        public Club Club { get; set; }
    }
}
