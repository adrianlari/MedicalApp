using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MedicalApp.Models;
using MedicalApp.Services;

namespace MedicalApp.ViewModels;

public partial class AppointmentsViewModel : ObservableObject
{
    private readonly IMedicalDataService _dataService;

    [ObservableProperty]
    private ObservableCollection<Appointment> appointments = new();

    [ObservableProperty]
    private bool isLoading;

    public AppointmentsViewModel(IMedicalDataService dataService)
    {
        _dataService = dataService;
    }

    [RelayCommand]
    public async Task LoadAppointmentsAsync()
    {
        IsLoading = true;
        try
        {
            var appointmentList = await _dataService.GetAppointmentsAsync();
            Appointments.Clear();
            foreach (var appointment in appointmentList)
            {
                Appointments.Add(appointment);
            }
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    public async Task BookAppointmentAsync()
    {
        await Shell.Current.GoToAsync("bookappointment");
    }
}
