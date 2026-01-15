# SimamQuantTrader - Implementation Plan

## 1. System Architecture & Setup

### 1.1 Solution Structure
We will adopt a clean architecture approach with a centralized solution containing the following projects:
- **SimamQuantTrader.Launchpad** (formerly LSEHedgeFundTrader.WPF): The desktop client (Presentation Layer).
- **SimamQuantTrader.API**: ASP.NET Core Web API (Backend Layer).
- **SimamQuantTrader.Core**: Shared domain entities, interfaces, and DTOs.
- **SimamQuantTrader.Infrastructure**: Data access implementation (EF Core), external service integrations (Market Data).
- **SimamQuantTrader.Tests**: Unit and Integration tests.

### 1.2 Technology Stack
- **Frontend**: WPF (.NET 8), MVVM Community Toolkit, LiveCharts2 or SciChart (for performance).
- **Backend**: ASP.NET Core 8 Web API.
- **Database**: SQL Server (LocalDev), PostgreSQL (Production/AWS).
- **ORM**: Entity Framework Core.
- **Authentication**: JWT (JSON Web Tokens) for API security.
- **Dependency Injection**: Microsoft.Extensions.DependencyInjection.

---

## 2. Implementation Phases

### Phase 1: Foundation & Infrastructure
**Goal**: Establish the communication pipeline between WPF and API, and set up the database.

1.  **Solution Setup**:
    -   Create `SimamQuantTrader.API` project.
    -   Create `SimamQuantTrader.Core` (Class Library).
    -   Re-create WPF client as `SimamQuantTrader.Launchpad` (Modern .NET 8).
2.  **Database & Auth**:
    -   Design `User` schema (Identity).
    -   Implement JWT Authentication in API.
    -   Create Login View in WPF.
3.  **Basic Connectivity**:
    -   Create a `HealthCheck` endpoint in API. 
    -   Verify WPF can call API and handle authentication tokens.

### Phase 2: Core Front Office (Trading & Market Data)
**Goal**: Enable real-time data visualization and order placement.

1.  **Market Data**:
    -   Define `Ticker` and `Price` models.
    -   Implement a SignalR Hub in API for real-time price broadcasting.
    -   Create a Mock Market Data Service (or integrate external provider API) to feed random/live prices.
    -   **WPF**: Implement Real-time Chart using LiveCharts2/SciChart subscribed to SignalR.
2.  **Order Management System (OMS)**:
    -   Define `Order` and `Trade` entities (`Symbol`, `Quantity`, `Price`, `Side`, `Type`).
    -   **API**: `POST /api/orders/place`. Implement validation logic.
    -   **WPF**: Create Order Entry Form (Buy/Sell buttons, Quantity inputs).
    -   **WPF**: Display "Active Orders" generic grid.

### Phase 3: Portfolio & Position Management
**Goal**: Track holdings and calculate P&L.

1.  **Portfolio Engine**:
    -   Define `Portfolio` and `Position` entities.
    -   Implement `PositionService` to update holdings upon Trade Execution.
    -   Calculate Real-time P&L based on current market price vs. avg entry price.
2.  **Dashboard**:
    -   **WPF**: Create a main dashboard with Portfolio Summary (Total Equity, Daily P&L).
    -   **WPF**: Visual breakdown of Asset Allocation (Pie Chart).

### Phase 4: Middle Office (Risk & Compliance)
**Goal**: Ensure trading safety and regulatory adherence.

1.  **Compliance Engine**:
    -   Implement Pre-trade checks (e.g., "Max Order Value", "Restricted Symbol").
    -   Intercept `PlaceOrder` requests in API pipeline.
2.  **Risk Metrics**:
    -   Calculate Value at Risk (VaR) (simplified historical simulation).
    -   **WPF**: Risk Dashboard tab showing exposure per sector/asset class.

### Phase 5: Back Office & Reporting
**Goal**: Audit and administrative functions.

1.  **Reporting**:
    -   Generate Trade History reports (PDF/CSV export).
    -   **API**: Endpoints for historical trade data retrieval with filtering.
2.  **Audit Trails**:
    -   Log all critical user actions (Login, Order Place, Order Cancel) to an `AuditLog` table.

### Phase 6: Polish & Advanced Features
**Goal**: Enhance UX and Performance.

1.  **UI/UX Overhaul**:
    -   Apply "Premium" Dark Theme (Glassmorphism, Neon accents).
    -   Implement micro-animations for price updates (green flash for up, red for down).
2.  **Performance**:
    -   Optimize SignalR message payload (MessagePack).
    -   Ensure WPF UI thread remains responsive under high data load (Throttling updates).

---

## 3. Next Steps (Immediate Actions)
1.  **Scaffold the Projects**: Create the missing API and Shared libraries.
2.  **Define Core Entities**: Create the `Order`, `Portfolio`, and `MarketData` models in the Core library.
3.  **WPF Cleanup**: Ensure the WPF app is set up for MVVM (install `CommunityToolkit.Mvvm`).

