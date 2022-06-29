using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalModeless
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
            // 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요.", "장마철 입니다.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요.", "장마철 입니다.", MessageBoxButtons.YesNoCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요.", "장마철 입니다.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomForm frm = new CustomForm();
            // frm.MdiParent = this;
            // 모달창은 사용 불가
            frm.ShowDialog();
            // Modal 창을 띄울 때는 ShowDialog()
            // 해당 창에만 커서 동작 가능 -> 본체는 해당 창을 없앤 후 가능
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CustomForm frm = new CustomForm();
            frm.MdiParent = this;
            frm.Show();
            // Modeless 창을 띄울 때는 Show()
            // 해당 창 외에도 커서 동작 가능
        }
    }
}
