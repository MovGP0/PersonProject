using System;
using System.Web.UI;
using PersonProject.Model;

namespace PersonProject.WebForms
{
    public partial class Details : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var idAsString = Page.Request.Params["Id"];

            if (string.IsNullOrEmpty(idAsString))
            {
                return;
            }

            var id = int.Parse(idAsString);
            
            using (var repository = new PersonRepository())
            {
                var person = repository.GetById(id);

                FirstNameTextBox.Text = person.FirstName;
                LastNameTextBox.Text = person.LastName;
            }
        }
    }
}