using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace VuaDuQua_QLMovie_Phan1.Models.CinemaEntities
{
    public class Movie
    {
        public int Id { get; set; }

        [DisplayName("Tên Phim")]
        public string Name { get; set; }

        [DisplayName("Hình Ảnh")]
        public string Image { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}