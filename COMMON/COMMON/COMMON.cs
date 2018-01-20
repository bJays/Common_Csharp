using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON
{
    static public class Message
    {

        static public void DebugMsgBox(string DebugStr, string FuncName = null)
        {
            try
            {
                System.Windows.Forms.MessageBox.Show(DebugStr, string.Format("[DEBUG] Func:{0}", FuncName), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                ExceptionMsgBox(ex.Message, "DebugMsgBox");
            }
        }
        static public void ExceptionMsgBox(string ExceptionMsg, string FuncName = null, string UserStr = null)
        {
            try
            {
                string tStr = ExceptionMsg;

                if (UserStr != null)
                {
                    tStr += string.Format("\n\n[User Message]\n{0}", UserStr);
                }
                else
                {
                }

                System.Windows.Forms.MessageBox.Show(tStr, FuncName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
            catch (System.Exception ex)
            {
                //this.ExceptionMsgBox(ex.Message, "ExceptionMsgBox");
            }
        }

        static public void InformationMsgBox(string InfoStr, string FuncName = null)
        {
            try
            {
                System.Windows.Forms.MessageBox.Show(InfoStr, FuncName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                ExceptionMsgBox(ex.Message, "InformationMsgBox");
            }
        }
    }

    static public class UNIT
    {

    }

    static public class Func
    {
        static public long Str2Hex(string InputStr)
        {
            long tValue = 0;

            try
            {
                int CurPos;
                char c;

                if ((InputStr[0] == '0') && ((InputStr[1] == 'x') || (InputStr[1] == 'X')))
                {
                    CurPos = 2;
                }
                else
                {
                    CurPos = 0;
                }

                do
                {
                    tValue = (tValue << 4);
                    c = InputStr[CurPos];

                    if ((c >= '0') && (c <= '9'))
                    {
                        tValue += (c - '0');
                    }
                    else if ((c >= 'a') && (c <= 'f'))
                    {
                        tValue += (c - 'a' + 0xA);
                    }
                    else if ((c >= 'a') && (c <= 'F'))
                    {
                        tValue += (c - 'A' + 0xA);
                    }
                    else
                    {
                    }
                } while (c != ' ');
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox(ex.Message, "InformationMsgBox");
            }

            return tValue;
        }
    }
}
