using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VuaDuQua_QLMovie_Phan1.Models.CinemaEntities
{
    public class Cinema
    {
        public int Id { get; set; }

        [DisplayName("Tên Rạp")]
        public string Name { get; set; }

        [DisplayName("Mô tả")]
        public string  Description { get; set; }

        public ICollection<Show> Shows { get; set; }

    }
}