# Ironhorse Invoice Assistant

A Windows desktop application built with **C# and .NET (WinForms)** to automate invoice preparation, batch image processing, and internal workflow tasks for **Ironhorse Loading & Securement Consultants**.

This application is designed to eliminate repetitive manual steps such as resizing invoice photos, organizing files, and managing persistent application settings.

This project is being developed and maintained by a **single developer** and follows a **Clean Architecture–inspired structure** to ensure the codebase remains organized, maintainable, and scalable as the application grows.

---

# Purpose

This application was created to solve real operational problems in a logistics and transload services business.

Key goals:

• Automate repetitive invoice preparation tasks
• Batch resize and optimize images for email and billing systems
• Persist user settings between sessions
• Reduce manual file management
• Provide a reliable internal business tool
• Serve as a professional portfolio project demonstrating .NET architecture and design practices

---

# Architecture Overview

This solution follows **Clean Architecture principles**, separating responsibilities into distinct layers.

```text
src/
├── IronhorseInvoiceAssistant.Domain/
├── IronhorseInvoiceAssistant.Application/
├── IronhorseInvoiceAssistant.Infrastructure/
└── IronhorseInvoiceAssistant.WinForms/
```

Dependencies always point inward:

```text
WinForms → Application → Domain
Infrastructure → Application → Domain
```

This ensures business logic remains independent from UI and system-level concerns.

---

# Layer Responsibilities

## Domain Layer

Core business models and logic.

Contains:

• Application settings models
• Business entities
• Value objects
• Interfaces defining contracts

This layer contains **no UI, file system, or external dependencies**.

Example:

```text
Domain/
├── Models/
│   └── AppSettingsModel.cs
```

---

## Application Layer

Coordinates workflows and defines application behavior.

Contains:

• Application services
• Interfaces for persistence and infrastructure
• Workflow logic

Example:

```text
Application/
├── Services/
│   └── SettingsService.cs
```

This layer defines **what the application does**, not how external systems implement it.

---

## Infrastructure Layer

Handles external and system-level operations.

Contains:

• JSON settings storage
• File system access
• Image processing services
• Path and directory management

Example:

```text
Infrastructure/
├── Services/
│   └── SettingsService.cs
├── Infrastructure/
│   └── SettingsPath.cs
```

This layer implements interfaces defined in Application.

---

## WinForms Layer (UI)

Handles user interaction and presentation.

Contains:

• Forms
• UI controls
• Event handlers

Example:

```text
WinForms/
├── MainWindow.cs
```

This layer acts as the **composition root**, connecting Application and Infrastructure.

---

# Why Clean Architecture (Even as a Solo Developer)

Even though this project is maintained by one developer, using a structured architecture provides major long-term benefits:

• Prevents tightly coupled code
• Makes features easier to add safely
• Improves testability
• Makes debugging easier
• Keeps responsibilities clearly separated
• Reflects professional, production-level development practices

---

# Key Features

Current functionality:

• Batch image resizing
• Adjustable image quality settings
• Persistent user settings stored in JSON
• Automatic settings loading on startup
• Source and destination folder selection
• Error handling and validation

Planned features:

• Invoice generation helpers
• Automated report generation
• Database support

---

# Technologies Used

• C#
• .NET
• Windows Forms
• System.Text.Json
• SixLabors.ImageSharp
• Visual Studio

---

# Example Settings File

Settings are stored in the user's LocalAppData folder:

```json
{
  "version": 1,
  "lastSourcePath": "C:\\Invoices\\Source",
  "lastDestinationPath": "C:\\Invoices\\Processed",
  "defaultWidth": 1200,
  "defaultHeight": 1200,
  "defaultQuality": 90
}
```

---

# Project Status

Active development.

This application is used internally and continues to evolve as new operational needs arise.

---

# Author

CB