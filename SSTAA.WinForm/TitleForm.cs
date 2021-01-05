using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSTAA.WinForm
{
    public partial class TitleForm : XtraForm
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        private void TitleForm_Click(object sender, EventArgs e)
        {
            //ShowChildForm(new SelectTownForm()); 는 메인폼에서 구현 계획
            //메인폼에 클릭 이벤트만 전달
        }
    }
}
