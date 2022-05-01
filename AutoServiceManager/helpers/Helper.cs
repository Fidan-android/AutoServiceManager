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

        private static List<BaseForm> _BackStack = new List<BaseForm>();
        public static BaseForm BackStack
        {
            get
            {
                var last = _BackStack.Last();
                _BackStack.Remove(last);
                return last;
            }
            set
            {
                _BackStack.Add(value);
                _BackStack.Last().Hide();
            }
        }

        public static void Quit(bool IsClose = true)
        {
            (IsClose ? (Action)_BackStack.First().Close : BackStack.Show)();
        }

        public static int UserId = 0;
        public static int OrderId = 0;
    }
}
