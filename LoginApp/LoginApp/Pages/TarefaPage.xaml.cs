using System.Collections.ObjectModel;

namespace LoginApp.Pages;

public partial class TarefaPage : ContentPage
{
    TarefaPage _tarefa;
	public TarefaPage()
	{
        Items = [];
		InitializeComponent();

    }
    
    ObservableCollection<string> Items;

    string Descritivo;

    private async void btnAdicionar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Descritivo))
            return;

        Items.Add(Descritivo);
        await DisplayAlert("Sucesso","Tarefa Adicionada","Ok");
    }
}