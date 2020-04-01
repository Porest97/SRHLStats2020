using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SRHLStats2020.Models.DataModels
{
    public class Series
    {
        public int Id { get; set; }


        [Display(Name = "Series")]
        public string SeriesName { get; set; }

        //[Display(Name = "District")]
        //public int? DistrictId { get; set; }
        //[Display(Name = "District")]
        //[ForeignKey("DistrictId")]
        //public District District { get; set; }

        //[Display(Name = "Status")]
        //public int? SeriesStatusId { get; set; }
        //[Display(Name = "Status")]
        //[ForeignKey("SeriesStatusId")]
        //public SeriesStatus SeriesStatus { get; set; }

        //[Display(Name = "Series ADMIN")]
        //public int? PersonId { get; set; }
        //[Display(Name = "Series ADMIN")]
        //[ForeignKey("PersonId")]
        //public Person Admin { get; set; }
    }
}
