# SimpleNotesApi

**SimpleNotesApi** is a clean and lightweight RESTful API built with ASP.NET Core 8.0, designed to manage personal notes with full CRUD functionality. The project uses SQLite for data persistence and includes Swagger UI for easy testing and API documentation.

---

## Features

- Create, Read, Update, and Delete (CRUD) operations on notes
- Built with modern C# and ASP.NET Core 8.0
- SQLite database integration for simple and efficient data storage
- Auto-generated Swagger UI for API exploration and testing
- Ready for containerization with Docker (optional)
- Designed with best practices for maintainability and scalability

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Optional: [Docker Desktop](https://www.docker.com/products/docker-desktop) (for containerized development)

### Running the API locally

1. Clone this repository:
   ```bash
   git clone https://github.com/Pospa20CZ/SimpleNotesApi_Patrik_Pospisil.git
   cd SimpleNotesApi_Patrik_Pospisil
   ```
2. Restore dependencies and run the project:
   ```bash
   dotnet restore
   dotnet run
   ```
3. Open your browser and navigate to:
   ```
   http://localhost:5245/swagger
   ```
   to access the interactive Swagger UI.

---

## API Endpoints

| Method | Endpoint          | Description              |
|--------|-------------------|--------------------------|
| GET    | /api/Notes        | Retrieve all notes        |
| GET    | /api/Notes/{id}   | Retrieve a note by ID     |
| POST   | /api/Notes        | Create a new note         |
| PUT    | /api/Notes/{id}   | Update an existing note   |
| DELETE | /api/Notes/{id}   | Delete a note by ID       |

---

## Contributing

Contributions are welcome! Feel free to submit issues or pull requests for improvements or bug fixes.

---

## Author

**Patrik Pospisil**  
GitHub Profile: [https://github.com/Pospa20CZ](https://github.com/Pospa20CZ)  
Email: your.email@example.com

---

## License

This project is licensed under the MIT License. See the LICENSE file for details.

---

Thank you for checking out SimpleNotesApi! Feel free to reach out if you have any questions or feedback.
