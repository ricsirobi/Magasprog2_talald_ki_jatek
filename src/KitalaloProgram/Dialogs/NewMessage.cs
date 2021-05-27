using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitalaloProgram.Dialogs
{
    public enum MessageBoxButton
    {
        OK = 0,
        OKCancel = 1,
        YesNo = 4,
        YesNoCancel = 3
    }
    public enum MessageBoxIcons
    {
        Asterisk = 64,
        Error = 16,
        Exclamation = 48,
        Hand = 16,
        Information = 64,
        None = 0,
        Question = 32,
        Stop = 16,
        Warning = 48
    }
    class NewMessage
    {
        DialogResult newDialog;
        public NewMessage(string msg, string name, MessageBoxButton buttonType, MessageBoxIcons iconType)
        {
            newDialog = MessageBox.Show(msg, name, (MessageBoxButtons)buttonType, (MessageBoxIcon)iconType);
        }
    }
}
