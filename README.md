CMCS 
(Claim Management & Coordination System)

Overview
CMCS (Claim Management & Coordination System) is a prototype ASP.NET Core MVC web application that streamlines lecturer claim submissions and manager/coordinator reviews.  

It was designed as part of an academic portfolio project and demonstrates:
Lecturer workflows — Submit claims, upload supporting documents, and track progress.  
Coordinator/Manager workflows — Review submitted claims, approve/reject, and manage statuses.  
UI/UX polish — Modern design with Bootstrap 5, Bootstrap Icons, and custom CSS variables.  


 Features
- Lecturer:
  - Submit a new claim (hours worked, rate, supporting PDF).  
  - Track status visually (stepper + progress bar).  
- Coordinator/Manager:
  - Review pending claims.  
  - Approve or reject with one click (prototype modals).  
- System:
  - Status workflow: `Draft → Submitted → PendingReview → Approved/Rejected`.  
  - Clean, responsive layout with custom color palette and typography.  


Tech Stack
Framework: ASP.NET Core MVC  
Language: C# (with Razor Views)  
Frontend: Bootstrap 5, Bootstrap Icons, Google Fonts, custom CSS (`site.css`)  
Data layer: In-memory static list (`List<Claim>`) for prototype (easily extendable to EF Core + database)  


Project Structure
Controllers/ClaimsController.cs — Handles claim submission, review, and status pages.  
Models/Claim.cs  — Defines claim data and workflow states.  
Views/Claims/Submit.cshtml — Lecturer submission page.  
Views/Claims/Review.cshtml — Coordinator/Manager review table.  
Views/Claims/Status.cshtml — Claim tracking with progress indicators.  
Views/Shared/_Layout.cshtml — Global layout (header, footer, nav).  
wwwroot/css/site.css` — Custom theme variables and component styles.  


