using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fondend.Models
{
    public class DANH_SACH_KHO
    {
        [Key]
        public int ID { get; set; }
        public string TEN_KHO { get; set; }
        public string SO_DIEN_THOAI { get; set; }

        public string MA_KHO { get; set; }

        public string DIA_CHI { get; set; }


        
    }
}