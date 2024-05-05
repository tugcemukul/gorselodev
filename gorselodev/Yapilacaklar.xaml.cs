using System.Collections.ObjectModel;
using System.Text.Json;

namespace gorselodev;

public partial class Yapilacaklar : ContentPage
{
    private ObservableCollection<TodoItem> TodoItems { get; set; }

    public Yapilacaklar()
    {
        InitializeComponent();

        TodoItems = new ObservableCollection<TodoItem>();
        todoListView.ItemsSource = TodoItems;
    }

    private async void AddButton_Clicked(object sender, EventArgs e)
    {

        string newNote = await DisplayPromptAsync("Not Ekle", "Yeni notu girin:");

        if (!string.IsNullOrWhiteSpace(newNote))
        {
            TodoItems.Add(new TodoItem { Note = newNote });
        }
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {

        var button = (Button)sender;
        var todoItem = (TodoItem)button.BindingContext;
        TodoItems.Remove(todoItem);
    }

    private async void EditButton_Clicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var todoItem = (TodoItem)button.BindingContext;

        string updatedNote = await DisplayPromptAsync("Not D�zenle", "Notu g�ncelle:", initialValue: todoItem.Note);

        if (!string.IsNullOrWhiteSpace(updatedNote))
        {
            // Notu g�ncelle
            todoItem.Note = updatedNote;

            // Koleksiyonu g�ncelle
            var index = TodoItems.IndexOf(todoItem);
            TodoItems[index] = todoItem;
        }
    }


    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        
    }
}


public class TodoItem
{
    public string Note { get; set; }
    public bool IsCompleted { get; set; }
}
