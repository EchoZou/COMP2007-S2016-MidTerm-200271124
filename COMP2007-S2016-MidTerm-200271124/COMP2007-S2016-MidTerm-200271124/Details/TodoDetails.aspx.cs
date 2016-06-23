using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements required for EF DB access
using COMP2007_S2016_MidTerm_200271124.Models;
using System.Web.ModelBinding;

namespace COMP2007_S2016_MidTerm_200271124
{
    public partial class TodoDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.GetTodo();
            }
        }

        protected void GetTodo()
        {
            // populate teh form with existing data from the database
            int TodoID = Convert.ToInt32(Request.QueryString["TodoID"]);

            // connect to the EF DB
            using (TodoConnection db = new TodoConnection())
            {
                // populate the object
                Todo updatedTodo = (from todo in db.Todos
                                       where todo.TodoID == TodoID
                                       select todo).FirstOrDefault();

                //check info
                if (updatedTodo != null)
                {
                    TodoNameTextBox.Text = updatedTodo.TodoName;
                    TodoNotesTextBox.Text = updatedTodo.TodoNotes;
                   
                    //checkbox


                }
            }
        }

        //cancel button go back
        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Details/TodoList.aspx");
        }

        //save button to save and go back
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to connect to the server
            using (TodoConnection db = new TodoConnection())
            {
                
                //new record
                Todo newTodo = new Todo();

                int TodoID = 0;

                if (Request.QueryString.Count > 0) // our URL has a StudentID in it
                {
                    // get the id from the URL
                    TodoID = Convert.ToInt32(Request.QueryString["TodoID"]);

                    // get the selected todo from EF DB
                    newTodo = (from todo in db.Todos
                               where todo.TodoID == TodoID
                               select todo).FirstOrDefault();
                }

                // add form data to the new student record
                newTodo.TodoName = TodoNameTextBox.Text;
                newTodo.TodoNotes = TodoNotesTextBox.Text;          
                
                //newTodo.checkBox



                //insert new todo into the database
                if (TodoID == 0)
                {
                    db.Todos.Add(newTodo);
                }


                // save changes
                db.SaveChanges();

                // Redirect back 
                Response.Redirect("~/Details/TodoList.aspx");
            }
        }
    }
}