using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CompanyApp
{
    public class EntryPoint
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            EmployeeDataHolder edh = new EmployeeDataHolder();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BusinessReportForm());
        }
    }
}
