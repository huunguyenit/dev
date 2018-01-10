using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.DTO
{
    class HocSinh_Thi_Monhoc_DTO
    {
        private string _MaHS;

        public string MaHS
        {
            get { return _MaHS; }
            set { _MaHS = value; }
        }

        private int _DiemThi;

        public int DiemThi
        {
            get { return _DiemThi; }
            set { _DiemThi = value; }
        }

        private int _HocKy;

        public int HocKy
        {
            get { return _HocKy; }
            set { _HocKy = value; }
        }

        private string _MaMH;

        public string MaMH
        {
            get { return _MaMH; }
            set { _MaMH = value; }
        }
    }
}
