using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1;

namespace WebApplication1.Controllers
{
    public class hocvienController : Controller
    {
        // GET: hocvien
        QuanLyTrungTamTiengAnh_AIEntities db = new QuanLyTrungTamTiengAnh_AIEntities();
        Service1 sv1 = new Service1();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult listhocvien()
        {
            try
            {
                var list = sv1.listhocvien();
                return View(list);
            }
            catch
            {
                return View();
            }
        }

        // Bổ sung thông tin
        [HttpPost]
        public ActionResult addhocvien(hocvienModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (!sv1.checkid(model.id_hocvien))
                    {
                        sv1.addhocvien(model);
                        ModelState.AddModelError("", "Thêm thành công");
                        return View();
                    }
                    else
                    {
                        ModelState.AddModelError("", "ID đã tồn tại");
                        return View();
                    }
                }
                catch
                {
                    ModelState.AddModelError("", "Thêm thất bại");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Dữ liệu không hợp lệ");
                return View();
            }
        }

        // Sửa thông tin
        [HttpGet]
        public ActionResult hocvienEdit(int id)
        {
            try
            {
                hocvienModel model = new hocvienModel();
                var obj = db.hocviens.Where(x => x.id_hocvien == id).FirstOrDefault();
                if (obj != null)
                {
                    model.id_hocvien = obj.id_hocvien;
                    model.ten = obj.ten;
                    model.ngaysinh = obj.ngaysinh;
                    model.email = obj.email;
                    model.sdt = obj.sdt;
                    model.diachi = obj.diachi;
                    model.ngaythamgia = obj.ngaythamgia;
                }
                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // Sửa thông tin
        [HttpPost]
        public ActionResult hocvienEdit(hocvienModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    sv1.updatehocvien(model);
                    return RedirectToAction("listhocvien", "hocvien", new { @id = model.id_hocvien });
                }
                catch
                {
                    ModelState.AddModelError("", "Sửa thất bại");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Dữ liệu không hợp lệ");
                return View();
            }
        }

        // Tìm kiếm thông tin
        [HttpGet]
        public ActionResult hocvienSearch(int id_hocvien)
        {
            try
            {
                var model = sv1.listhocvien().Where(x => x.id_hocvien == id_hocvien).ToList();
                if (model.Count == 0 && id_hocvien != 0)
                {
                    ViewBag.Info = "Không tìm thấy thông tin: " + id_hocvien;
                }
                else
                {
                    ViewBag.Info = "";
                }
                return View(model);
            }
            catch
            {
                return View();
            }
        }
        // Xóa thông tin
        public ActionResult hocvienDelete(int id)
        {
            try
            {
                sv1.deletehocvien(id);
                return RedirectToAction("listhocvien", "hocvien");
            }
            catch
            {
                return View();
            }
        }
    }
}
