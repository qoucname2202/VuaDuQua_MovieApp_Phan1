using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VuaDuQua_QLMovie_Phan1.Models.CinemaEntities
{
    public class ShowTime
    {
        public int Id { get; set; }

        [DisplayName("Giờ Chiếu")]
        [Required(ErrorMessage = "Vui lòng nhập thời gian")]
        public string Time { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}