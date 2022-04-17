using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceManager.helpers
{
    class Helper
    {
        private static bool _ShowPassword = false;
        public static bool ShowPassword {
            get {
                _ShowPassword = !_ShowPassword;
                return !_ShowPassword;
            }
            set { _ShowPassword = value; }
        }

        private static Bitmap _PasswordImage = Properties.Resources.view;
        public static Bitmap PasswordImage {
            get {
                _PasswordImage = _ShowPassword ? Properties.Resources.hidden : Properties.Resources.view;
                return _PasswordImage;
            }
            set { _PasswordImage = value; }
        }

        private static Login _LoginInstance = null;
        public static Login LoginInstance {
            get {
                return _LoginInstance;
            }
            set {
                _LoginInstance = value;
                _LoginInstance.Hide();
            }
        }

        public static void Quit(bool IsClose = true)
        {
            (IsClose ? (Action)_LoginInstance.Close : (Action)_LoginInstance.Show)();
        }
    }
}
