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
    class MonHoc_BLL
    {
        ConnectDB connectData = new ConnectDB();

        //Lấy danh sách Môn học load sang combobox
        public DataTable GetSubjectLoad()
        {
            string sql = "select MaMH, TenMH from MonHoc";
            return connectData.GetData(sql);
        }
    }
}
