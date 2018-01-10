using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.DTO
{
    class Bai_Nhom_DTO
    {
        private string _MaBaiNhom;

        public string MaBaiNhom
        {
            get { return _MaBaiNhom; }
            set { _MaBaiNhom = value; }
        }

        private string _MaNhomBKT;

        public string MaNhomBKT
        {
            get { return _MaNhomBKT; }
            set { _MaNhomBKT = value; }
        }

        private int _DiemKT_N;

        public int DiemKT_N
        {
            get { return _DiemKT_N; }
            set { _DiemKT_N = value; }
        }
    }
}
