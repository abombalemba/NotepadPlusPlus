using System;
using System.Drawing;
using System.Windows.Forms;

namespace KPFU_2_sem_programming_NotepadPlusPlus {
    public partial class FormAbout : Form
    {
        public FormAbout() {
            InitializeComponent();

            this.Icon = new Icon(FormMain.pathIconBlue);
        }
    }
}
