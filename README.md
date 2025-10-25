Customer Regisration Prototype 

Purpose- Demonstrating modern web development skills including: 
Asp,net core 9,0 MVC
Entitiy Framework core + MySql
Jquery/Ajax for Single Page/No refresh operations
Bootstrap for responsive UI
Docker for containerized deployment
Git & Github for version control and CI/CD rediness

Features - CRUD operations using AJAX (single page experiance no full page load)

Technology Used-
          | Backend | ASP.NET Core 9.0, C#, Entity Framework Core |
          | Frontend | Razor page, Bootstrap 5, jQuery AJAX |
          | Database | MySQL 8.0 |
          | Tools | Docker, Visual Studio , Git / GitHub |

Running the application-
    You can run this applcation both ways 
    1 Run Locally without docker (you need MySQL 8.0 and Visual Studio 2022)

    2 Run with Docker (this option run both App and my sql inside the Container -no setup needed
           Step 1- Clone the repository 
               git clone https://github.com/ashikasameera-rgb/ResponsiveSPATemplate.git
               cd CustomerRegistrationApp/CustomerRegistrationApp
           Step 2- Build and start container
               Docker-compose up --build
           Step 3- Open your browser at http://localhost:8080
