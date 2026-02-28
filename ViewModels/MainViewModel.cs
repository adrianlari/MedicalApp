using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MedicalApp.Services;
using MedicalApp.Models;

namespace MedicalApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IMedicalDataService _dataService;

    [ObservableProperty]
    private int totalPatients;

    [ObservableProperty]
    private int upcomingAppointments;

    [ObservableProperty]
    private int todayAppointments;

    public MainViewModel(IMedicalDataService dataService)
    {
        _dataService = dataService;
    }

    public async Task LoadDashboardDataAsync()
    {
        var patients = await _dataService.GetPatientsAsync();
        var appointments = await _dataService.GetAppointmentsAsync();

        TotalPatients = patients.Count;
        UpcomingAppointments = appointments.Count(a => a.DateTime > DateTime.Now);
        TodayAppointments = appointments.Count(a => a.DateTime.Date == DateTime.Today);
    }
}
