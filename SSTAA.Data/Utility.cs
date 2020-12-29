using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace GothamSubway.Data
{
    public class Utility
    {
        public static bool MboxYesNo(string title, string question)
        {
            return XtraMessageBox.Show(question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }

        public static void Mbox(string title, string message)
        {
            XtraMessageBox.Show(message, title);
        }
    }
}