using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmManage.DAL
{
    class ConnectDB
    {
        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataTable dt;

        // Tạo constructor goi kết nối khi new lớp ConnectData
        public ConnectDB()
        {
            Connect();
        }

        //Khai bao chuoi ket noi CSDL
        private string strConnect = @"Data Source=MAYTINH-AF360J5\SQLEXPRESS;Initial Catalog=QLNoiDungMH;Integrated Security=True";
        //Kết nối
        public void Connect()
        {
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open(); // Mo ket noi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới Cơ Sở Dữ Liệu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Hàm đếm giá trị từ Database theo câu lệnh sql truyền vao
        public string CountData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            string kq = null;
            try
            {
                kq = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                kq = null;
            }
            cmd.Dispose();

            return kq;
        }
        //Hàm lấy dữ liệu từ Database theo câu lệnh sql truyền vào
        public DataTable GetData(string sql)
        {
            // Tạo dataApdapter, thực hiện câu lệnh query
            da = new SqlDataAdapter(sql, conn);
            // Đổ dữ liệu vào DataTable
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Hàm Thêm, Cập nhật, Xóa dữ liệu theo câu lệnh sql đưa vào
        public bool RunSQL(string sql)
        {
            int numRecordsEffect = 0;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                numRecordsEffect = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI ĐÂY NÀY : " + ex.Message, "Thông báo lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (numRecordsEffect > 0)
                return true;
            return false;
        }

        //Hàm kiểm tra sự tồn tại
        public bool CheckForExistence(string nameTable, string nameFiled, string value)
        {
            string sql = "SELECT * FROM " + nameTable + " WHERE " + nameFiled + " = '" + value + "'";
            GetData(sql);
            // Đếm số dòng trả về, nếu > 0  tức tồn tại value
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        // Lấy mã cuối cùng
        public string GetLastID(string nameTable, string nameFiled)
        {
            Connect();
            string sql = "SELECT TOP (1) " + nameFiled + " FROM " + nameTable + " ORDER BY " + nameFiled + " DESC";
            GetData(sql);
            // thực hiện câu truy vấn trên
            return dt.Rows[0][nameFiled].ToString();
        }
    }
}
