using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.DTO
{
    class HocSinh_DTO
    {
        private string _MaHS;

        public string MaHS
        {
            get { return _MaHS; }
            set { _MaHS = value; }
        }

        private string _TenHS;

        public string TenHS
        {
            get { return _TenHS; }
            set { _TenHS = value; }
        }

        private string _MaNhom;

        public string MaNhom
        {
            get { return _MaNhom; }
            set { _MaNhom = value; }
        }
    }
}
