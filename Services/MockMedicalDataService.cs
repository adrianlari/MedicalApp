using MedicalApp.Models;

namespace MedicalApp.Services;

public class MockMedicalDataService : IMedicalDataService
{
    private readonly List<Patient> _patients;
    private readonly List<Appointment> _appointments;
    private int _nextPatientId = 3;
    private int _nextAppointmentId = 3;

    public MockMedicalDataService()
    {
        _patients = new List<Patient>
        {
            new Patient
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1985, 5, 15),
                Gender = "Male",
                PhoneNumber = "+1-555-0101",
                Email = "john.doe@email.com",
                Address = "123 Main St, City",
                BloodType = "O+",
                Allergies = new List<string> { "Penicillin" },
                MedicalHistory = new List<string> { "Hypertension", "Diabetes Type 2" }
            },
            new Patient
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                DateOfBirth = new DateTime(1990, 8, 22),
                Gender = "Female",
                PhoneNumber = "+1-555-0102",
                Email = "jane.smith@email.com",
                Address = "456 Oak Ave, Town",
                BloodType = "A+",
                Allergies = new List<string>(),
                MedicalHistory = new List<string> { "Asthma" }
            }
        };

        _appointments = new List<Appointment>
        {
            new Appointment
            {
                Id = 1,
                PatientId = 1,
                Patient = _patients[0],
                DateTime = DateTime.Now.AddDays(2),
                DoctorName = "Dr. Sarah Johnson",
                Specialty = "Cardiology",
                Reason = "Regular checkup",
                Status = AppointmentStatus.Scheduled,
                Notes = "Bring previous test results"
            },
            new Appointment
            {
                Id = 2,
                PatientId = 2,
                Patient = _patients[1],
                DateTime = DateTime.Now.AddDays(5),
                DoctorName = "Dr. Michael Chen",
                Specialty = "Pulmonology",
                Reason = "Asthma follow-up",
                Status = AppointmentStatus.Confirmed,
                Notes = ""
            }
        };
    }

    public Task<List<Patient>> GetPatientsAsync()
    {
        return Task.FromResult(_patients);
    }

    public Task<Patient?> GetPatientAsync(int id)
    {
        return Task.FromResult(_patients.FirstOrDefault(p => p.Id == id));
    }

    public Task<List<Appointment>> GetAppointmentsAsync()
    {
        return Task.FromResult(_appointments.OrderBy(a => a.DateTime).ToList());
    }

    public Task<List<Appointment>> GetPatientAppointmentsAsync(int patientId)
    {
        return Task.FromResult(_appointments.Where(a => a.PatientId == patientId).ToList());
    }

    public Task<Appointment> AddAppointmentAsync(Appointment appointment)
    {
        appointment.Id = _nextAppointmentId++;
        _appointments.Add(appointment);
        return Task.FromResult(appointment);
    }

    public Task<Patient> AddPatientAsync(Patient patient)
    {
        patient.Id = _nextPatientId++;
        _patients.Add(patient);
        return Task.FromResult(patient);
    }
}
