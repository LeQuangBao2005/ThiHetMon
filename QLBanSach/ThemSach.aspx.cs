using QLBanSach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLBanSach
{
    public partial class ThemSach : System.Web.UI.Page
    {
        SachDAO sachDAO = new SachDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btXuLy_Click(object sender, EventArgs e)
        {
            try
            {
                int mdd = int.Parse(ddlChuDe.SelectedValue);
                string tenSach = txtTen.Text;
              
                int dongia = int.Parse(txtDonGia.Text);
                bool khuyenmai = chkKhuyenMai.Checked;

                
                string hinh = FHinh.FileName;
                string path = Server.MapPath("~/Bia_sach") + "/" + FHinh.FileName;
                FHinh.SaveAs(path);

             
                Sach sach = new Sach { TenSach = tenSach,  Dongia = dongia,KhuyenMai = khuyenmai, MaCD = mdd, Hinh = hinh };
                sachDAO.Insert(sach);



            }
            catch (Exception ex)
            {
              

            }


        }
    }
}