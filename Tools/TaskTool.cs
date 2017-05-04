using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
namespace Tools
{
    /// <summary>
    /// 处理线程的类
    /// </summary>
    public class TaskTool
    {
        public static void Invoke(Control c,MethodInvoker d) {
            c.Invoke(d);
        }

       
    }
}
