using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VuaDuQua_QLMovie_Phan1.Models.CinemaEntities
{
    public class ShowDay
    {
        public int Id { get; set; }

        [DisplayName("Ngày Chiếu")]
        public DateTime Day { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}