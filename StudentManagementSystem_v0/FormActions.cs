using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_v0
{
    class FormActions
    {
        public FormActions()
        {

        }
        public static void ExitApplication()
        {
            Application.Exit();
        }
        public static void MaxNormForm(Form _form)
        {
            if (_form.WindowState == FormWindowState.Maximized)
            {
                _form.WindowState = FormWindowState.Normal;                

            }
            else
            {
                _form.WindowState = FormWindowState.Maximized;
            }
            
        }
        public static void MinimizeForm(Form _form)
        {
            _form.WindowState = FormWindowState.Minimized;
        }

    }
}
