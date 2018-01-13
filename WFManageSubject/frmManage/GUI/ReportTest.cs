using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmManage.DTO;
using frmManage.BLL;

namespace frmManage.GUI
{
    public partial class ReportTest : UserControl
    {
        BaiTap_KiemTra_BLL baiTap_KiemTraBUS = new BaiTap_KiemTra_BLL();
        public ReportTest()
        {
            InitializeComponent();
        }
        private void Report()
        {
            tbxExersice.Text = baiTap_KiemTraBUS.CountExercise();
            tbxTest.Text = baiTap_KiemTraBUS.CountTest();
            tbxGroup.Text = baiTap_KiemTraBUS.CountTest();
            tbxStudent.Text = baiTap_KiemTraBUS.CountTest();
        }
        private void ReportTest_Load(object sender, EventArgs e)
        {
            dgvInfoTest.DataSource = baiTap_KiemTraBUS.GetListTestChapter();
            Report();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}