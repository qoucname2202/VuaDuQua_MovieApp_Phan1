using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VuaDuQua_QLMovie_Phan1.Models.CinemaEntities
{
    public class Seat
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Chỗ Ngồi")]
        public int SeatNo { get; set; }

        [DisplayName("Trạng Thái")]
        public bool Status { get; set; }

        [DisplayName("Giá")]
        public double Price { get; set; }
    
        public ICollection<Reservation> Reservations { get; set; }
    }
}