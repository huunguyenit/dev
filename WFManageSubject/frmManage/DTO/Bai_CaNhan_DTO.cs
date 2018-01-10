using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.DTO
{
    class Bai_CaNhan_DTO
    {
        private string _MaBai_CN;

        public string MaBai_CN
        {
            get { return _MaBai_CN; }
            set { _MaBai_CN = value; }
        }

        private string _MaHS_CN;

        public string MaHS_CN
        {
            get { return _MaHS_CN; }
            set { _MaHS_CN = value; }
        }

        private int _DiemKT_CN;

        public int DiemKT_CN
        {
            get { return _DiemKT_CN; }
            set { _DiemKT_CN = value; }
        }
    }
}
