using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoListApp
{
    //class viewmodel
    class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();

        }
        //command to add todo
        public ICommand AddTodoCommand => new Command(AddTodoItem);
        //string newtodoinputvalue with getter and setter
        public string NewTodoInputValue { get; set; }
        //add todo
        void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoInputValue, false));
        }
        //command to remove todo
        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);
        public string RemoveTodoInputValue { get; set; }
        //method to remove chosen todo
        void RemoveTodoItem(object o)
        {
            TodoItem todoItemBeingRemoved = o as TodoItem;
            TodoItems.Remove(todoItemBeingRemoved);
        }

    }
}
