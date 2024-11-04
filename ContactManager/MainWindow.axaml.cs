using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ContactManager;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddItem_Click(object? sender, RoutedEventArgs e)
    {
        var newItem = new ListBoxItem { Content = $"{ContactsListBox.Items.Count + 1}. {NameTextBox.Text}, {SurnameTextBox.Text}, {NumberTextBox.Text}, {EmailTextBox.Text}" };
        ContactsListBox.Items.Add(newItem);
        NameTextBox.Text = "";
        SurnameTextBox.Text = "";
        NumberTextBox.Text = "";
        EmailTextBox.Text = "";
    }
}