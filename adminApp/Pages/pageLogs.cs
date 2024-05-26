using adminApp.CustomRows;
using HomeCareObjects.Model;
using ProjectFormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp.Pages
{
    public partial class pageLogs : Form
    {
        HomeCareDBContext context;
        private SortType currentSortType;
        private bool isAscendingOrder;

        public pageLogs()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
            currentSortType = SortType.Date; // Default to sorting by date
            isAscendingOrder = true; // Default to ascending order

        }

        private void logsPage_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void UpdateSort(SortType sortType)
        {
            if (currentSortType == sortType)
            {
                isAscendingOrder = !isAscendingOrder; // Toggle the sorting order
            }
            else
            {
                currentSortType = sortType;
                isAscendingOrder = true; // Default to ascending order when changing sort type
            }
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                // Fetch logs along with UserName
                var logs = from log in context.Logs
                           join user in context.Users on log.UserId equals user.UserId
                           select new
                           {
                               log.Message,
                               log.Source,
                               UserName = user.FullName,
                               log.DateTime
                           };

                // Sort the logs based on the current sort type and order
                logs = currentSortType switch
                {
                    SortType.Date => isAscendingOrder
                        ? logs.OrderBy(l => l.DateTime)
                        : logs.OrderByDescending(l => l.DateTime),
                    SortType.Source => isAscendingOrder
                        ? logs.OrderBy(l => l.Source)
                        : logs.OrderByDescending(l => l.Source),
                    SortType.User => isAscendingOrder
                        ? logs.OrderBy(l => l.UserName)
                        : logs.OrderByDescending(l => l.UserName),
                    _ => logs
                };

                flpLogs.Controls.Clear(); // Clear existing controls
                flpLogs.Refresh();

                foreach (var log in logs)
                {
                    UCLogs logControl = new UCLogs();
                    logControl.logMessage = log.Message;
                    logControl.source = log.Source;
                    logControl.userName = log.UserName;
                    logControl.date = log.DateTime.ToString("yyyy-MM-dd");
                    logControl.time = log.DateTime.ToString("HH:mm:ss");

                    flpLogs.Controls.Add(logControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    /*---------------  Sort Buttons Visual & Functionality  --------------------*/

    //Source button
    private void lblSource_Click(object sender, EventArgs e)
        {
            UpdateSort(SortType.Source);
        }

        private void lblSource_MouseEnter(object sender, EventArgs e)
        {
            hoverText(lblSource, Color.FromArgb(85, 250, 190));//Hover Color
        }

        private void lblSource_MouseLeave(object sender, EventArgs e)
        {
            hoverText(lblSource, Color.FromArgb(131, 140, 163)); //Default Color
        }

        //User button
        private void lblUser_Click(object sender, EventArgs e)
        {
            UpdateSort(SortType.User); //TODO: Fix User sort error
        }

        private void lblUser_MouseEnter(object sender, EventArgs e)
        {
            hoverText(lblUser, Color.FromArgb(85, 250, 190));//Hover Color
        }

        private void lblUser_MouseLeave(object sender, EventArgs e)
        {
            hoverText(lblUser, Color.FromArgb(131, 140, 163)); //Default Color
        }

        //date time button
        private void lblDateTime_Click(object sender, EventArgs e)
        {
            UpdateSort(SortType.Date);
        }

        private void lblDateTime_MouseEnter(object sender, EventArgs e)
        {
            hoverText(lblDateTime, Color.FromArgb(85, 250, 190));//Hover Color
        }

        private void lblDateTime_MouseLeave(object sender, EventArgs e)
        {
            hoverText(lblDateTime, Color.FromArgb(131, 140, 163)); //Default Color
        }

        //Function to change the color of the text
        private void hoverText(Label lbl, Color clr)
        {
            lbl.ForeColor = clr;
        }
    }
    public enum SortType
    {
        Date,
        Source,
        User
    }
}
