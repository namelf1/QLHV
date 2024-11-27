using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Data.Entity;

namespace ClassLibrary1
{
    public class Service1
    {
        //Kết nối tới database
        public static QuanLyTrungTamTiengAnh_AIEntities db = new QuanLyTrungTamTiengAnh_AIEntities();
        //Lấy danh sách học viên
        public List<hocvienModel> listhocvien()
        {
            var list= db.hocviens.Select(x => new hocvienModel()
                        {
                            id_hocvien = x.id_hocvien,
                            ten = x.ten,
                            ngaysinh = x.ngaysinh,
                            email = x.email,
                            sdt = x.sdt,
                            diachi = x.diachi,
                            ngaythamgia = x.ngaythamgia
                        }).ToList();
            return list;
        }
        //Thêm học viên
        public void addhocvien(hocvienModel model)
        {
            var obj = new hocvien();
                obj.id_hocvien=model.id_hocvien;
                obj.ten = model.ten;
                obj.ngaysinh = model.ngaysinh;
                obj.email = model.email;
                obj.sdt = model.sdt;
                obj.diachi = model.diachi;
                obj.ngaythamgia = model.ngaythamgia;
                db.hocviens.Add(obj);
            db.SaveChanges();
        }
        //Cập nhật thông tin
        public void updatehocvien(hocvienModel model)
        {
            var obj = db.hocviens.Where(x=>x.id_hocvien == model.id_hocvien).FirstOrDefault() ;
            obj.ten = model.ten;
            obj.ngaysinh = model.ngaysinh;
            obj.email = model.email;
            obj.sdt = model.sdt;
            obj.diachi = model.diachi;
            obj.ngaythamgia = model.ngaythamgia;
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa học viên
        public void deletehocvien(int id)
        {
            var obj = db.hocviens.Where(x => x.id_hocvien == id).FirstOrDefault();
            db.hocviens.Remove(obj);
            db.SaveChanges();
        }
        //Kiểm tra trùng id
        public bool checkid(int id)
        {
            var obj = db.hocviens.Where(x => x.id_hocvien == id).FirstOrDefault();
            if (obj != null)
                return true;
            else return false;
        }
    }
}
