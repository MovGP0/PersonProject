using System;
using PersonProject.Model;

namespace PersonProject.WebForms
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            var firstName = FirstNameTextBox.Text;
            var lastName = LastNameTextBox.Text;

            using (var repository = new PersonRepository())
            { 
                var person = new Person
                {
                    FirstName = firstName,
                    LastName = lastName
                };

                repository.Create(person);
            }

            Page.Response.Redirect("~/Default.aspx");
        }
    }
}