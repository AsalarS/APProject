using HomeCareObjects.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectFormApp;

namespace adminApp.Popup
{
    public partial class categoryDialogue : Form
    {
        HomeCareDBContext context;
        Category category;
        public categoryDialogue()
        {
            InitializeComponent();
            context = new HomeCareDBContext();
            category = new Category();
        }

        public categoryDialogue(int categoryID)
        {
            InitializeComponent();
            context = new HomeCareDBContext();
            this.category = context.Categories.Find(categoryID);

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void categoryDialogue_Load(object sender, EventArgs e)
        {
            try
            {

                ddlManager.DataSource = context.Users.Where(x => x.UserRole == "Manager").ToList();
                ddlManager.DisplayMember = "FullName";
                ddlManager.ValueMember = "UserID";
                ddlManager.SelectedItem = null;

                if (category != null && category.CategoryId > 0)
                {
                    txtCategoryId.Text = category.CategoryId.ToString();
                    ddlManager.SelectedValue = category.ManagerId;
                    nameTxt.Text = category.CategoryName;
                    descTxt.Text = category.Description;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                category.CategoryName = nameTxt.Text;
                category.Description = descTxt.Text;
                if(ddlManager.SelectedItem == null)
                {
                    MessageBox.Show("Please select a manager");
                    return;
                }

                category.ManagerId = Convert.ToInt32(ddlManager.SelectedValue.ToString());

                if (category != null && category.CategoryId > 0)
                {
                    context.Categories.Update(category);
                }
                else
                {
                    //add the order to the orders DBSet
                    context.Categories.Add(category);
                }
                //Execute the insert SQL
                context.SaveChanges();

                //Only if the insert was successful, we can 
                this.DialogResult = DialogResult.OK;
                //close the form
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ddlManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
