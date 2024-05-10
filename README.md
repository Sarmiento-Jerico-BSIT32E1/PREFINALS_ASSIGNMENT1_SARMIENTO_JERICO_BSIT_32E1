## Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered)
Conceptual Understanding:
 
### Have you heard of the Onion Architecture principle in software design?
No, because I'm not familiar with this architecture 

### Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?
No, because I'm not familiar with this MVC so that's why I'm not familiar with that 

### Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?
No, since I don't have a broad understanding of how Web APIs work.

###Application & Bottlenecks: Onion Architecture:

### 1. Benefits: (1-3 keywords) 
-Separation of Concerns -Testability -Flexibility

Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
- Onion Architecture in .NET Core promotes cleaner, more testable applications by separating concerns and promoting loose coupling between layers.
  
### Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern)
-  Yes I have encountered some challenges regarding Onion Architecture as I'm blindly doing things I have no clear information regarding the ASP.MVC & how to apply the onion architecture for the given projects.

### MVC: Components: (1-3 keywords each)
1. Model
2. View
3. Controller

### Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
1. Model: Represents the data and core logic of your application. It handles data access, business rules, and any calculations needed.
2. View: Focuses on how the data is presented to the user. It doesn't contain any application logic, just the UI elements that display information.
3. Controller: Acts as an intermediary between the Model and the View. It receives user input, updates the Model as needed, and instructs the View on how to update itself based on changes in the Model.

### Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)
-Yes, I have a gist of idea what each purpose is but on how to connect it is my problem or challenges I have encountered on MVC projects.

### Web API: ## Differences from MVC: (Yes/No and Briefly Explain)
- Web APIs primarily focus on providing data and services to be consumed by other applications, whereas traditional MVC applications are oriented towards serving dynamic web pages directly to users. Web APIs typically use lightweight data exchange formats like JSON or XML for communication, while MVC applications generate HTML for rendering in web browsers.
### Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.

### Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)
-Yes, since i don't have a starter knowledge about how API's work in the structure of onion architecture and MVC.
