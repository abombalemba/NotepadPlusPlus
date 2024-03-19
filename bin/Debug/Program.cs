using System;
using System.Windows.Forms;

namespace KPFU_2_sem_programming_NotepadPlusPlus {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
