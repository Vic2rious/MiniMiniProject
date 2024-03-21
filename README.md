# MiniMiniProject
LOGIN PAGE (Form 1)


Event Handlers
ExitButton_Click: Closes the application when the "Exit" button is clicked, using Application.Exit().
LoginButton_Click: The core function for handling the login logic when the "Login" button is clicked.
LoginButton_Click Method
Database Connection: Establishes a connection to a SQL Server database using a SqlConnection object. The connection string specifies the data source, initial catalog (database name), and security type.
SQL Command: Prepares an SQL query to check the existence of a user with the provided username and password. It uses parameterized queries (@Username and @Password) to prevent SQL injection attacks.
Parameter Assignment: Adds values to the query parameters from the username and password text boxes.
Execution and Result Handling:
Executes the command using ExecuteScalar(), which is expected to return a single value: the count of records matching the query. It casts the result to an integer (int).
If the count is 1, it indicates the user is found. It then creates and displays a new form (Form2) and hides the current login form.
If the count is not 1, it shows a message box indicating "Invalid Credentials!"
SEARCH PAGE (Form 2)

The provided code snippet is from a Windows Forms application developed in C#, designed to interact with a SQL database containing records of computers and their characteristics (e.g., CPU, GPU, RAM, availability). This form allows users to search for computers based on selected criteria and displays the results in a DataGridView. Let's break down the main components and functionalities:
Class and Constructor
Namespace: MiniMini
Class: Form2, inherits from Form.
Constructor: Form2(string username) initializes the form, sets a welcome message for the user, and populates the DataGridView with the initial data from the database when the form loads.
Key Properties
bool CPU_ON, GPU_ON, RAM_ON, Availabilty_ON: Flags to indicate which search filters are active.
Key Methods
Constructor Form2(string username)
Establishes a connection to the SQL database using SqlConnection.
Executes a SQL query to fetch all computers' data from the database.
Populates the DataGridView with the fetched data.
button1_Click
Exits the application when the corresponding button is clicked.
Search
Constructs a dynamic SQL query based on the selected search criteria (CPU brand, GPU brand, RAM, and availability).
Executes the query and updates the DataGridView with the results.
Utilizes parameterized queries to prevent SQL injection.
selectQuery
Dynamically generates a SQL query string based on which search filters are active.
The method constructs the WHERE clause of the query by checking which selection boxes (CPU, GPU, RAM, Availability) have values selected and sets corresponding flags.
Returns the constructed SQL query string.
Clear_Click
Resets the selection boxes for CPU, GPU, RAM, and availability to their default states.
ReserveButton_Click
Opens a new form (Form3), for the purpose of reserving or further interacting with the selected computer record.
Selection Changed Events (AvailabilityBox_SelectedIndexChanged, RAMbox_SelectedIndexChanged, etc.)
Calls the Search method whenever the selection in any of the filter boxes changes, triggering a new search based on the selected criteria.

RESERVATION PAGE (Form 3)

The provided C# code represents a form (Form3) from a Windows Forms application that interacts with a SQL database. This form specifically deals with the reservation system for computers, displaying existing reservations, and allowing users to add or clear reservations based on certain criteria. Here's a breakdown of its functionality and key aspects:
Key Functionalities
Database Connection: Establishes a connection to a SQL database (phoney) to perform operations like fetching existing reservations, adding new reservations, and updating the availability of computers.
Form Initialization: Upon initialization, the form fetches and displays existing reservations from the Reservations table in a DataGridView.
Reserve Computers: Users can reserve a computer by entering details (ID, phone number, first name, last name, and email). The application checks if the computer is already reserved before proceeding with the reservation.
Clear Reservations: Allows users to clear an existing reservation by updating the computer's availability status and removing the reservation record.
Data Validation: Validates email and phone number inputs for correct format before processing reservations.
Methods and Events
ExitButton_Click: Exits the application.
ReturnButton_Click: Hides the current form, potentially returning to a previous form in the application.
ReserveButton_Click: Validates input fields, checks if the selected computer is already reserved, and if not, inserts a new reservation into the database and updates the computer's availability.
ClearButton_Click: Clears a reservation by setting the computer's availability to 'available' and deleting the reservation record.
Query: Executes a provided SQL query string to insert, update, or delete records in the database.
RefreshForm: Closes the current form and reopens it, effectively refreshing the displayed data.
IsReserved: Checks if a computer is already reserved by querying the database for a record with a matching ID and 'reserved' status.
EmailBox_Validating and PhoneBox_Validating: Validate the email and phone number inputs, respectively, ensuring they meet expected formats before processing. Utilizes regular expressions for email validation and a simple numerical check for phone numbers.
Considerations and Potential Improvements
SQL Injection: The code is susceptible to SQL injection, particularly in methods like ReserveButton_Click and ClearButton_Click where input values are directly concatenated into SQL query strings. Using parameterized queries is recommended to mitigate this risk.
Error Handling: While there's basic error handling in the Query method, more comprehensive checks and handling around database operations could improve robustness and user experience.
Data Validation: The application validates email and phone inputs but could also benefit from validating other inputs to ensure data integrity.
User Feedback and Usability: Enhancements in user feedback, such as more descriptive error messages and confirmations for successful operations, would improve usability.
Efficiency: The RefreshForm method closes and reopens the form to refresh data, which might not be the most efficient way to update the displayed information. Consider directly refreshing the DataGridView data source instead.


