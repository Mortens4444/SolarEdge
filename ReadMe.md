# SolarEdge Monitoring App (.NET MAUI Blazor Hybrid)

A cross-platform mobile and desktop application built with **.NET MAUI** and **Blazor Hybrid** to monitor SolarEdge PV systems using the official Monitoring API.

## 🚀 Features

* **Real-time Site Overview**: Displays site status, peak power, and system type.
* **Hardware Details**: Shows information about the primary solar modules (manufacturer, model, and power).
* **Location Insights**: Provides installation address, coordinates, and timezone.
* **Active Alerts**: Fetches and displays system alerts (requires API permissions).
* **Secure Storage**: Sensitive information like API Keys and Site IDs are stored using the device's native **SecureStorage** (Keychain for iOS, Keystore for Android).
* **Cross-Platform**: Runs on Android, iOS, Windows, and macOS from a single codebase.

## 🛠️ Technology Stack

* **Framework**: [.NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/)
* **UI Logic**: [Blazor Hybrid](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/) (HTML5, CSS3, Razor)
* **Styling**: Bootstrap 5 & Bootstrap Icons
* **Data Handling**: Strongly typed C# Models with `System.Net.Http.Json`

## 📋 Prerequisites

To run this project, you will need:

* **Visual Studio 2022** with the ".NET Multi-platform App UI development" workload.
* A **SolarEdge API Key** and **Site ID**. You can obtain these from the SolarEdge Monitoring Portal under *Admin > Site Setup > API Access*.

## ⚙️ Setup & Installation

1. **Clone the repository:**
```bash
git clone https://github.com/yourusername/SolarEdgeMonitor.git

```

2. **Open the solution:**
Open `SolarEdgeMonitor.sln` in Visual Studio.

3. **Run the application:**
Select your target platform (Android Emulator, iOS Simulator, or Windows Machine) and press **F5**.

4. **Configure API:**
Once the app is running, navigate to the **Settings** page and enter your `Site ID` and `API Key`.