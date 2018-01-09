using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmManage.BLL;
using frmManage.DTO;

namespace frmManage.GUI
{
    public partial class InfoSubject : UserControl
    {
        private TacGia_BLL tgBUS = new TacGia_BLL();
        private bool add = false, update = false;

        //Xóa dữ liệu trên textbox
        public void cleantxt()
        {
            txtTenTG.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
        }

        //Binding dữ liệu lên textbox
        public void binding()
        {
            txtMaTG.DataBindings.Clear();
            txtMaTG.DataBindings.Add("Text", dgvTacGia.DataSource, "MaTG");
            txtTenTG.DataBindings.Clear();
            txtTenTG.DataBindings.Add("Text", dgvTacGia.DataSource, "HoTenTG");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvTacGia.DataSource, "DiaChiTG");
            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", dgvTacGia.DataSource, "DienThoaiTG");
        }

        //Lấy Thông tin Tác Giả
        private TacGia_DTO LayTTTG()
        {
            TacGia_DTO tg = new TacGia_DTO();
            tg.MaTG = txtMaTG.Text;
            tg.HoTenTG = txtTenTG.Text;
            tg.DiaChiTG = txtDiaChi.Text;
            tg.DienThoaiTG = txtSdt.Text;
            return tg;
        }
        public InfoSubject()
        {
            InitializeComponent();
        }
    }
}
