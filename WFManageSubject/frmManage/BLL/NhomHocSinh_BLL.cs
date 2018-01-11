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
    class NhomHocSinh_BLL
    {
        ConnectDB connData = new ConnectDB();

        public DataTable GetGroupLoad()
        {
            string sql = "select MaNhom, TenNhom from NhomHocSinh";
            return connData.GetData(sql);
        }
    }
}
