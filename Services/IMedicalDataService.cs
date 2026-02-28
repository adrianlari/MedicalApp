using MedicalApp.Models;

namespace MedicalApp.Services;

public interface IMedicalDataService
{
    Task<List<Patient>> GetPatientsAsync();
    Task<Patient?> GetPatientAsync(int id);
    Task<List<Appointment>> GetAppointmentsAsync();
    Task<List<Appointment>> GetPatientAppointmentsAsync(int patientId);
    Task<Appointment> AddAppointmentAsync(Appointment appointment);
    Task<Patient> AddPatientAsync(Patient patient);
}
