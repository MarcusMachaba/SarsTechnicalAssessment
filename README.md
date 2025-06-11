# SARS Technical Assessment 🧑‍💻

**Technologies**  
* **Frontend** — Vite + React 18 (TypeScript, Tailwind CSS, Framer Motion)  
* **Backend** — .NET 8 class library (`Sars.Rpn`) with xUnit tests  
* **Misc** — Fluent icons via `lucide-react`, MSBuild composite builds, project-level analyzers  

> **Clone • Install • Run** – the whole solution spins up in **< 30 seconds** on any machine with Node ≥ 18 and .NET SDK ≥ 8.

---

## 📁 Repository layout

```text
├── backend/
│   ├── Sars.Rpn/            # core library
│   └── Sars.Rpn.Tests/      # xUnit tests
│
├── console/
│   └── Rpn.Runner/          # demo REPL for quick manual checks
│
├── frontend/
│   └── reactapp_frontend/   # Vite React 18 + Tailwind app
│       ├── src/
│       │   ├── components/
│       │   ├── hooks/
│       │   └── ...
│       ├── tailwind.config.js
│       └── tsconfig.*.json
│
└── Directory.Build.props    # nullable + analyzer rules for all C# projects
```                                                      <!-- 👈 THIS closes the tree block -->

---

## 🚀 Quick-start (developer workflow)

```bash
# Clone + enter
git clone https://github.com/MarcusMachaba/SarsTechnicalAssessment.git
cd SarsTechnicalAssessment

# --- Frontend ---
cd frontend/reactapp_frontend
npm install            # installs React, Vite, Tailwind, etc.
npm run dev            # opens http://localhost:5173

# --- Backend ---
cd ../../backend/Sars.Rpn
dotnet test            # builds & runs all unit tests

# --- Console demo ---
cd ../../console/Rpn.Runner
dotnet run             # interactive RPN REPL
