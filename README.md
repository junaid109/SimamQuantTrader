# SimamQuantTrader

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen.svg)]()
[![Platform](https://img.shields.io/badge/platform-WPF%20%7C%20ASP.NET%20Core-blue.svg)]()
[![License](https://img.shields.io/badge/license-MIT-blue.svg)]()

**SimamQuantTrader** is a high-performance institutional trading platform designed for real-time market data visualization, order management, and portfolio risk analysis. Built on the latest **.NET 8** stack, it features a decoupled architecture with a WPF desktop client ("Launchpad") and a scalable ASP.NET Core Web API backend.

## 🚀 Features

### Front Office
- **Real-Time Market Data**: Live streaming of tickers and price updates via SignalR.
- **Order Management System (OMS)**: Low-latency order placement, modification, and cancellation.
- **Advanced Visualization**: Interactive financial charts (Candlestick, Line) utilizing LiveCharts2/SciChart.

### Middle Office
- **Risk Management**: Real-time position tracking and P&L calculation.
- **Compliance**: Pre-trade risk checks and exposure monitoring.

### Back Office
- **Reporting**: Comprehensive trade history and audit trails.
- **Security**: Role-based access control (RBAC) and secure JWT authentication.

## 🏗 Architecture

The solution follows a **Clean Architecture** approach, ensuring separation of concerns and testability.

| Project | Description |
|Args|Description|
|---|---|
| **SimamQuantTrader.Launchpad** | The WPF Desktop Client (Presentation Layer) using CommunityToolkit.MVVM. |
| **SimamQuantTrader.API** | ASP.NET Core 8 Web API (Backend Layer) handling business logic and data access. |
| **SimamQuantTrader.Core** | Shared library containing Domain Entities, Interfaces, and DTOs. |
| **SimamQuantTrader.Infrastructure** | Data access implementation (EF Core) and external service integrations. |

## 🛠 Technology Stack

- **Framework**: .NET 8
- **Desktop Client**: WPF (Windows Presentation Foundation)
- **Web API**: ASP.NET Core 8
- **Database**: SQL Server / PostgreSQL
- **ORM**: Entity Framework Core
- **Real-time Communication**: SignalR
- **Charting**: LiveCharts2 / SciChart

## 💻 Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (v17.8+) or [VS Code](https://code.visualstudio.com/)
- SQL Server (LocalDB or Developer Edition)

### Installation

1.  **Clone the repository**
    ```bash
    git clone https://github.com/junaid109/SimamQuantTrader.git
    cd SimamQuantTrader
    ```

2.  **Build the Solution**
    ```bash
    dotnet build
    ```

3.  **Run the API**
    Navigate to the API project and start it:
    ```bash
    cd SimamQuantTrader.API
    dotnet run
    ```

4.  **Run the Client**
    Open a new terminal, navigate to the Launchpad project, and start it:
    ```bash
    cd SimamQuantTrader.Launchpad
    dotnet run
    ```

## 🤝 Contributing

We welcome contributions! Please follow these steps:
1.  Fork the repository.
2.  Create a feature branch (`git checkout -b feature/NewFeature`).
3.  Commit your changes (`git commit -m 'Add some NewFeature'`).
4.  Push to the branch (`git push origin feature/NewFeature`).
5.  Open a Pull Request.

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
