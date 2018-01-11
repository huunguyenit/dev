using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmManage.DAL;
using frmManage.DTO;

namespace frmManage.BLL
{
    class HocSinh_BLL
    {
        ConnectDB connData = new ConnectDB();
        //Lấy danh sách học sinh load GUI Test
        public DataTable GetStudentLoad()
        {
            string sql = "select MaHS, TenHS from HocSinh";
            return connData.GetData(sql);
        }
    }
}
