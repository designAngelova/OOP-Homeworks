using System;
using System.Windows.Forms;
using CompanyApp.Interfaces;
using WordReportGenerator;


namespace CompanyApp
{
    public partial class BusinessReportForm : Form
    {
        public BusinessReportForm()
        {
            InitializeComponent();
        }

        private void ImportData(object sender, EventArgs e)
        {
            if (reports.Nodes.Count == 0)
            {
                TreeNode salesReport = reports.Nodes.Add("Sales Reports");
                TreeNode projectReport = reports.Nodes.Add("Project Reports");

                foreach (var employee in EmployeeDataHolder.Employees)
                {
                    if (employee.GetType() == typeof (SalesEmployee))
                    {
                        salesReport.Nodes.Add(employee.FirstName + " " + employee.LastName + "`s Report").Tag = employee;         
                    }

                    if (employee.GetType() == typeof(Developer))
                    {
                        projectReport.Nodes.Add(employee.FirstName + " " + employee.LastName + "`s Report").Tag = employee;
                    }
                }
            }
        }

        private void DrawReportNodes(object sender, DrawTreeNodeEventArgs e)
        {
            
        }

        private void ShowReportInfo(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                reportInfo.Text = e.Node.Tag.ToString();
            } 
        }

        private void ExportReportsToWord(object sender, EventArgs e)
        {
            foreach (TreeNode node in reports.Nodes)
            {
                foreach (TreeNode childNode in node.Nodes)
                {
                    if (childNode.Checked)
                    {
                        DocumentGenerator.GenerateReport((IEmployee) childNode.Tag);
                    }
                }
            }
        }

        private void ShowAboutWindow(object sender, EventArgs e)
        {
            CompanyAppAboutBox aboutBox = new CompanyAppAboutBox();
            aboutBox.Show();
        }
    }
}
