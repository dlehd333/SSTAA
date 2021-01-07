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
    public partial class SeoulMapControl : DevExpress.XtraEditors.XtraUserControl
    {
        public SeoulMapControl()
        {
            InitializeComponent();
        }
        #region ButtonClicked event things for C# 3.0
        public event EventHandler<ButtonClickedEventArgs> ButtonClicked;

        protected virtual void OnButtonClicked(ButtonClickedEventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);
        }

        private ButtonClickedEventArgs OnButtonClicked(int districtNumber)
        {
            ButtonClickedEventArgs args = new ButtonClickedEventArgs(districtNumber);
            OnButtonClicked(args);

            return args;
        }

        private ButtonClickedEventArgs OnButtonClickedForOut()
        {
            ButtonClickedEventArgs args = new ButtonClickedEventArgs();
            OnButtonClicked(args);

            return args;
        }

        public class ButtonClickedEventArgs : EventArgs
        {
            public int DistrictNumber { get; set; }

            public ButtonClickedEventArgs()
            {
            }

            public ButtonClickedEventArgs(int districtNumber)
            {
                DistrictNumber = districtNumber;
            }
        }
        #endregion

        private void OccurEvent(object sender)
        {
            SimpleButton btn = sender as SimpleButton;
            InitializeButtonColor();
            btn.Appearance.BackColor = System.Drawing.Color.Transparent;
            ButtonClickedEventArgs args = new ButtonClickedEventArgs();
            args.DistrictNumber = Convert.ToInt32(btn.Tag);
            OnButtonClicked(args.DistrictNumber);
        }

        private void InitializeButtonColor()
        {
            foreach (var control in Controls)
            {
                if (control.GetType() == btnYongsanGu.GetType())
                    ((SimpleButton)control).Appearance.BackColor = Color.SteelBlue;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            OccurEvent(sender);
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            InitializeButtonColor();
        }
    }
}
