using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_qlnhahang
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private string tk;
        public Home(string tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CustomMessBox mb = new CustomMessBox("Bạn có muốn rời nhà hàng FOODIE!");
            mb.ShowDialog();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangeInfo form = new ChangeInfo(tk);
            form.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.Transparent;
            btnChangePass.BackColor = Color.Transparent;
            btnExit.BackColor = Color.Transparent;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            CustomMessBox mb = new CustomMessBox("Phần mềm quản lý nhà hàng của chúng tôi là một giải pháp toàn diện và dễ sử dụng để quản lý mọi khía cạnh của hoạt động nhà hàng. Với giao diện thân thiện và dễ sử dụng, phần mềm giúp bạn tối ưu hóa quy trình làm việc, tăng cường hiệu suất và cải thiện trải nghiệm của khách hàng.\r\n\r\nGiao diện người dùng được thiết kế một cách trực quan và thân thiện, cho phép bạn nhanh chóng thao tác và tiếp cận các chức năng quản lý quan trọng.");
            mb.ShowDialog();
        }
    }
}
