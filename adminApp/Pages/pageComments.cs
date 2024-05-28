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

namespace adminApp.Pages
{
    public partial class pageComments : Form
    {
        private HomeCareDBContext context;
        private SortType currentSortType;
        private bool isAscendingOrder;
        public pageComments()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
            currentSortType = SortType.Date; // Default to sorting by date
            isAscendingOrder = true; // Default to ascending order
        }

        private void pageComments_Load(object sender, EventArgs e)
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
                // Fetch Comments along with UserName, ServiceName, and CategoryName
                var comments = context.Comments
                .Select(c => new
                {
                    c.CommentText,
                    ServiceName = c.Request.Service.ServiceName,
                    ServiceId = c.Request.Service.ServiceId,
                    UserName = c.Request.Customer.Username, // Assuming Username is what you meant by FullName
                    UserId = c.Request.Customer.UserId,
                    c.CommentDate,
                    CategoryName = c.Request.Service.Category.CategoryName, // comment.Service.Category.CategoryName
                    categoryId = c.Request.Service.Category.CategoryId
                })
                .ToList();

                // Sort the comments based on the current sort type and order
                comments = currentSortType switch
                {
                    SortType.Date => isAscendingOrder
                        ? comments.OrderBy(c => c.CommentDate).ToList()
                        : comments.OrderByDescending(c => c.CommentDate).ToList(),
                    SortType.Category => isAscendingOrder
                        ? comments.OrderBy(c => c.CategoryName).ToList()
                        : comments.OrderByDescending(c => c.CategoryName).ToList(),
                    SortType.Service => isAscendingOrder
                        ? comments.OrderBy(c => c.ServiceName).ToList()
                        : comments.OrderByDescending(c => c.ServiceName).ToList(),
                    SortType.Customer => isAscendingOrder
                        ? comments.OrderBy(c => c.UserName).ToList()
                        : comments.OrderByDescending(c => c.UserName).ToList(),
                    _ => comments // Default case to handle missing patterns
                };


                flpComments.Controls.Clear(); // Clear existing controls
                flpComments.Refresh();

                foreach (var comment in comments) //Set Custom Row Values
                {
                    UCComments commentControl = new UCComments();
                    commentControl.Comment = comment.CommentText;
                    commentControl.ServiceName = comment.ServiceName;
                    commentControl.ServiceId = comment.ServiceId.ToString();
                    commentControl.UserName = comment.UserName;
                    commentControl.UserId = comment.UserId.ToString();
                    commentControl.Category = comment.CategoryName;
                    commentControl.CategoryId = comment.categoryId.ToString();
                    commentControl.Date = comment.CommentDate.ToString("yyyy-MM-dd");
                    commentControl.Time = comment.CommentDate.ToString("HH:mm:ss");

                    flpComments.Controls.Add(commentControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        /*---------------  Sort Buttons Visual & Functionality  --------------------*/

        // Sort by Service Name
        private void btnService_Click(object sender, EventArgs e)
        {
            UpdateSort(SortType.Service);
        }

        private void lblService_MouseEnter(object sender, EventArgs e)
        {
            hoverText(lblService, Color.FromArgb(85, 250, 190));//Hover Color
        }

        private void lblService_MouseLeave(object sender, EventArgs e)
        {
            hoverText(lblService, Color.FromArgb(131, 140, 163)); //Default Color
        }

        // Sort by Customer Name
        private void lblCustomer_Click(object sender, EventArgs e)
        {
            UpdateSort(SortType.Customer);
        }

        private void lblCustomer_MouseEnter(object sender, EventArgs e)
        {
            hoverText(lblCustomer, Color.FromArgb(85, 250, 190));//Hover Color
        }

        private void lblCustomer_MouseLeave(object sender, EventArgs e)
        {
            hoverText(lblCustomer, Color.FromArgb(131, 140, 163)); //Default Color
        }

        // Sort by Category Name
        private void lblCategory_Click(object sender, EventArgs e)
        {
            UpdateSort(SortType.Category);
        }

        private void lblCategory_MouseEnter(object sender, EventArgs e)
        {
            hoverText(lblCategory, Color.FromArgb(85, 250, 190));//Hover Color
        }

        private void lblCategory_MouseLeave(object sender, EventArgs e)
        {
            hoverText(lblCategory, Color.FromArgb(131, 140, 163)); //Default Color
        }

        // Sort by Date
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

    public enum SortType //enum for sorting
    {
        Date,
        Category,
        Service,
        Customer
    }

}
