using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class hocvienModel
    {
        [Display(Name = "ID Học Viên")]
        [Required(ErrorMessage = "ID Học Viên không được để trống")]
        public int id_hocvien { get; set; }
        [Display(Name = "Tên Học Viên")]
        [Required(ErrorMessage = "Tên Học Viên không được để trống")]
        public string ten { get; set; }
        [Display(Name = "Ngày Sinh")]
        [Required(ErrorMessage = "Ngày Sinh không được để trống")]
        public DateTime ngaysinh { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        public string email { get; set; }
        [Display(Name = "Số Điện Thoại")]
        [Required(ErrorMessage = "Số Điện Thoại không được để trống")]
        public string sdt { get; set; }
        [Display(Name = "Địa Chỉ")]
        [Required(ErrorMessage = "Địa Chỉ không được để trống")]
        public string diachi { get; set; }
        [Display(Name = "Ngày Tham Gia")]
        [Required(ErrorMessage = "Ngày Tham Gia không được để trống")]
        public DateTime ngaythamgia { get; set; }
    }
}
