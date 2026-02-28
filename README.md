# MedConnect - Medical Management Mobile App

A cross-platform mobile application built with .NET MAUI for managing patients and medical appointments.

## 🏥 Features

### Current Features
- **Dashboard** - Overview of patients and appointments
  - Total patients count
  - Today's appointments
  - Upcoming appointments counter
  
- **Patient Management**
  - View all patients
  - Patient profiles with detailed information
  - Patient demographics (age, gender, blood type)
  - Medical history tracking
  - Allergy information

- **Appointment System**
  - View all appointments
  - Appointment scheduling
  - Doctor and specialty information
  - Appointment status tracking (Scheduled, Confirmed, In Progress, Completed, Cancelled)

### Architecture
- **MVVM Pattern** using CommunityToolkit.Mvvm
- **Dependency Injection** for services and ViewModels
- **Mock Data Service** for development/testing
- **Shell Navigation** for seamless page transitions

## 🛠️ Tech Stack

- **.NET 8.0**
- **.NET MAUI** (Multi-platform App UI)
- **C# 12**
- **XAML** for UI
- **CommunityToolkit.Mvvm** for MVVM implementation

## 📱 Supported Platforms

- ✅ Android (API 21+)
- ✅ iOS (11.0+)
- ✅ macOS Catalyst (13.1+)
- ✅ Windows (10.0.17763.0+)

## 🚀 Getting Started

### Prerequisites

- Visual Studio 2022 (17.8+) or Visual Studio Code
- .NET 8.0 SDK
- .NET MAUI workload installed

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/PulsarMoney/MedicalApp.git
   cd MedicalApp
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   
   For Android:
   ```bash
   dotnet build -t:Run -f net8.0-android
   ```
   
   For iOS (Mac only):
   ```bash
   dotnet build -t:Run -f net8.0-ios
   ```
   
   For Windows:
   ```bash
   dotnet build -t:Run -f net8.0-windows10.0.19041.0
   ```

### Visual Studio

1. Open `MedicalApp.sln` in Visual Studio 2022
2. Select your target platform (Android/iOS/Windows)
3. Press F5 to build and run

## 📂 Project Structure

```
MedicalApp/
├── Models/              # Data models
│   ├── Patient.cs
│   └── Appointment.cs
├── ViewModels/          # MVVM ViewModels
│   ├── MainViewModel.cs
│   ├── PatientsViewModel.cs
│   └── AppointmentsViewModel.cs
├── Views/               # XAML Views
│   ├── MainPage.xaml
│   ├── PatientsPage.xaml
│   └── AppointmentsPage.xaml
├── Services/            # Business logic & data access
│   ├── IMedicalDataService.cs
│   └── MockMedicalDataService.cs
├── Resources/           # Assets and styles
│   ├── Styles/
│   └── Images/
└── Platforms/           # Platform-specific code
    ├── Android/
    ├── iOS/
    └── Windows/
```

## 🎨 UI/UX Features

- **Modern Medical Theme** - Professional color scheme (Blue primary, Green secondary)
- **Card-based Dashboard** - Quick overview of key metrics
- **List Views** - Easy-to-scan patient and appointment lists
- **Status Badges** - Visual indicators for appointment status
- **Responsive Design** - Works on phones and tablets

## 🔮 Future Enhancements

- [ ] Real-time data synchronization
- [ ] Patient search and filtering
- [ ] Appointment booking form
- [ ] Doctor profiles
- [ ] Medical records (prescriptions, lab results)
- [ ] Push notifications for appointments
- [ ] Offline mode
- [ ] Multi-language support
- [ ] Dark mode theme
- [ ] Reports and analytics

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📄 License

This project is licensed under the MIT License.

## 👨‍💻 Created By

**Clawy** 🦾 - AI Assistant
Built for PulsarMoney

---

**Note:** This app currently uses mock data for demonstration purposes. To connect to a real backend, replace `MockMedicalDataService` with an actual API implementation.
