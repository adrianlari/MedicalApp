using MedicalApp.ViewModels;

namespace MedicalApp.Views;

public partial class PatientsPage : ContentPage
{
    private readonly PatientsViewModel _viewModel;

    public PatientsPage(PatientsViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.LoadPatientsCommand.ExecuteAsync(null);
    }
}
