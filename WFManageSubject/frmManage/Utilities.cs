using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using frmManage.BLL;
using frmManage.DTO;

namespace frmManage
{
    class Utilities
    {
        //Lấy mã kế tiếp
        public static string NextID(string lastID, string prefixID)
        {
            int nextID = int.Parse(lastID.Remove(0, prefixID.Length)) + 1;
            //int lengthNumerID = lastID.Length - prefixID.Length;
            int lengthNumberID = 3;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumberID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumberID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixID + zeroNumber + nextID.ToString();
                }
            }
            return prefixID + nextID;
        }

        #region Thong tin user
        public static GiaoVien_DTO user = new GiaoVien_DTO();
        #endregion
    }
}
