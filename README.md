# DIExample Project

This is a simple C# Console Application that demonstrates **Dependency Injection** using `Teacher` and `ClassRoom` classes. The project uses constructor injection to pass dependencies between classes.


## Project Structure
The project includes the following classes and interfaces:
- **IOgretmen (Interface)**: Defines the properties and methods for a teacher.
- **Teacher (Class)**: Implements the `IOgretmen` interface and stores teacher's name.
- **ClassRoom (Class)**: Takes a `Teacher` instance through constructor injection and provides methods to access the teacher's information.

### Class Details:
- **IOgretmen**: Interface that has:
  - `FirstName`: Stores the teacher's first name.
  - `LastName`: Stores the teacher's last name.
  - `GetInfo()`: Returns teacher's full name.

- **Teacher**: Implements the `IOgretmen` interface:
  - Constructor: Initializes `FirstName` and `LastName`.
  - `GetInfo()`: Returns teacher's full name in the format `"Öğretmen: FirstName LastName"`.

- **ClassRoom**: 
  - Constructor: Accepts a `Teacher` instance (dependency injection).
  - `GetTeacherInfo()`: Calls `GetInfo()` from the `Teacher` class to return teacher information.

