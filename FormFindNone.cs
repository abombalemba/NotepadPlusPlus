using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPFU_2_sem_programming {
    public partial class FormFindNone : Form {
        public FormFindNone(string text) {
            InitializeComponent();

            findNoneLabel.Text = String.Format("Не удается найти: \"{0}\"", text);
        }

        private void findNoneButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
