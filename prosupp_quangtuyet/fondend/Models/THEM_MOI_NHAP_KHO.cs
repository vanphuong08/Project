using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fondend.Models
{
    public class THEM_MOI_NHAP_KHO
    {
        [Key]
        public int ID { get; set; }
        public string TEN_SAN_PHAM { get; set; }
        public string MA_SAN_PHAM { get; set; }
        public string LOAI_SAN_PHAM { get; set; }
        public DateTime NGAY_NHAP_KHO { get; set; }
        public DateTime NGAY_LAP_PHIEU { get; set; }
        public string KICH_THUOC { get; set; }
        public string TRONG_LUONG { get; set; }
        public double GIA_NHAP { get; set; }
        public string KHO_NHAP_HANG { get; set; }
        public string MAU_SAC { get; set; }
    }
}