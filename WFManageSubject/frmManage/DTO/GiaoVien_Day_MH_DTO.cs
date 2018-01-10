using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.DTO
{
    class GiaoVien_Day_MH_DTO
    {
        private string _MaGV_Day;

        public string MaGV_Day
        {
            get { return _MaGV_Day; }
            set { _MaGV_Day = value; }
        }

        private string _MaMH_Day;

        public string MaMH_Day
        {
            get { return _MaMH_Day; }
            set { _MaMH_Day = value; }
        }
    }
}
