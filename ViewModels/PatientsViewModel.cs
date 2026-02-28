using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MedicalApp.Models;
using MedicalApp.Services;

namespace MedicalApp.ViewModels;

public partial class PatientsViewModel : ObservableObject
{
    private readonly IMedicalDataService _dataService;

    [ObservableProperty]
    private ObservableCollection<Patient> patients = new();

    [ObservableProperty]
    private Patient? selectedPatient;

    [ObservableProperty]
    private bool isLoading;

    public PatientsViewModel(IMedicalDataService dataService)
    {
        _dataService = dataService;
    }

    [RelayCommand]
    public async Task LoadPatientsAsync()
    {
        IsLoading = true;
        try
        {
            var patientList = await _dataService.GetPatientsAsync();
            Patients.Clear();
            foreach (var patient in patientList)
            {
                Patients.Add(patient);
            }
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    public async Task ViewPatientDetailsAsync(Patient patient)
    {
        SelectedPatient = patient;
        // Navigate to patient details page
        await Shell.Current.GoToAsync($"patientdetails?patientId={patient.Id}");
    }
}
