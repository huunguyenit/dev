using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.DTO
{
    class GiaoVien_DTO
    {
        private string _MaGV;

        public string MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }
        private string _TenGV;

        public string TenGV
        {
            get { return _TenGV; }
            set { _TenGV = value; }
        }
        private int _GioiTinh;

        public int GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        private int _Admin;

        public int Admin
        {
            get { return _Admin; }
            set { _Admin = value; }
        }
    }
}
