using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListApp
{
    //class 
    public class TodoItem
    {
        //string with getter and setter
        public string TodoText { get; set; }
        //bool with getter and setter
        public bool Complete { get; set; }

        public TodoItem(string TodoText, bool Complete)
        {
            //todoitem contains todotext and completed or not
            this.TodoText = TodoText;
            this.Complete = Complete;
           
        }
    }
}