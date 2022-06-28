using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmStatisticsForm : Form
    {
        public frmStatisticsForm(frmMainWindow obj1)
        {
            objectOfMain = obj1;
            InitializeComponent();
        }
        private void DisableStatisticsButtons(object sender, FormClosingEventArgs e)
        {
            objectOfMain.btnStatiticsSum.Enabled = objectOfMain.btnStatiticsAverage.Enabled = objectOfMain.btnStandardDeviation.Enabled = objectOfMain.btnEnterStatiticsBoxEntry.Enabled = false;
        }
        private void ClearAllStatisticEntries(object sender, EventArgs e)
        {
            lbxStatisticsEntries.Items.Clear();
            lblStataticsEntryCount.Text = "n=0";
        }
        private void DeleteSelectedEntry(object sender, EventArgs e)
        {
            if (lbxStatisticsEntries.Items.Count != 0 && lbxStatisticsEntries.SelectedIndex!=-1)
            {
                lbxStatisticsEntries.Items.RemoveAt(lbxStatisticsEntries.SelectedIndex);
                lblStataticsEntryCount.Text = "n=" + lbxStatisticsEntries.Items.Count;
            }
            
        }
        private void CopySelectedEntryToMainWindowTextBox(object sender, EventArgs e)
        {
            if(lbxStatisticsEntries.SelectedIndex!=-1)
            objectOfMain.txtResult.Text=lbxStatisticsEntries.Items[lbxStatisticsEntries.SelectedIndex].ToString();
        }
        private void FocusToMainWindowForm(object sender, EventArgs e)
        {
            Application.OpenForms[0].Focus();
        }

        private void frmStatisticsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
