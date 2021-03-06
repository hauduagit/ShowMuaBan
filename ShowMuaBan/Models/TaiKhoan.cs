﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShowMuaBan.Models
{
    public class TaiKhoan
    {
        [Key]
        [Display(Name = "Id người đăng")]
        [Column(Order =1)]
        public int NguoiDangId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        [Required]
        [Display(Name = "Họ tên người đăng")]
        public string HoTen { get; set; }

        [Required]
        [Display(Name = "Tên đăng nhập")]
        [EmailAddress]
        public string TenDangNhap { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }

        [Display(Name = "Ghi nhớ thông tin?")]
        public bool RememberMe { get; set; }

       

        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        [Required]
        [StringLength(12)]
        public string SoDienThoai { get; set; }

        public virtual ICollection<DanhMuc> DanhMucs { get; set; }

    }
}