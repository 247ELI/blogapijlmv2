# Blog BackEnd API - Project Overview 
## Project Goal

Create a backend for Blog Application:

- Support full CRUD operations 
- All users to create account and login 
- Deploy to Azure
- Uses SCRUM workflow concepts
- Introduces Azure DevOps practices 

## Stack

    - Back end will be in .Net 9, ASP.NET Core, EF Core, SQL Server.
    - Front End will be done in Next JS with TypeScript (To be done by. Jacob) flowbite(tailwind). Deploy with TBA (Vercel or Azure)

## Application Features 

### user Capabilities 

    - Create an account 
    - Login 
    - Delete account

### Blog Features 

    - View all published blog posts
    - Filter blog posts
    - Create new posts
    - Edit existing posts
    - Delete posts
    - Publish/ Unpublish posts

### Pages (Frontend Connected to API)

    - Create Account Page
    - Blog View post page of polished items
    - Dashboard page (this is the profile page will edit, delete, and publish anf unpublish our blog posts)  

- **Blog Page**
        - Display all published blog items 

    - **DashBoard**
        - User profile page
        - Create blog posts
        - Edit blog posts
        - Delete blog posts

    ## Project Folder Structure

    ### Controllers 

    #### UserController

    Handles all users interactions.

    Endpoints:

    - Login
    - Add user
    - Update user
    - Delete user

    ### BlogController  

    Handles all blog operations.

    Endpoints:

    - Create Blog Item (C)
    - Get All Blog Items (R)
    - Get Blog Items By Category (R)
    - Get Blog Items By Tag (R)
    - Get Blog Items By Date (R)
    - Get Published Blog Items (R)
    - Update Blog Items (U)
    - Delete Blog Items (D)
    - Get Blog Items by UserId

    >Delete will be used for soft delete / publish logic

    --- 

    ## Models 

    ### UserModel
    
```csharp

int Id
int UserId 
string PublisherName
string Title 
string Image 
string Description 
string Date
string Category 
string Tags
bool IsPublished
bool IsDeleted

## Items Saved to our DB
### We need a way to sign in with our username and password 

```csharp

### LoginModel

    string Username
    string Password 

### Create AccountModel
    int Id = 0
    string Username 
    string Password 

### PasswordModel

    string Salt
    string Hash

```

### Services
    Context/Folder 
    - DataContext
    - UserService/file
        -GetUserByName
        - Login
        - AddUser
        - UpdateUser
        - DeleteUser
### BlogItemService

    - AddBlogitems
    - GetAllBlogItems
    - GetBlogItemsByCategory
    - GetBlogItemsByTags
    - GetBlogItemsByDate
    - GetPublishedBlogItems
    - UpdateBlogItems
    - DeleteBlogItems
    - GetUserById

### PasswordService

    - Hash Password
    - Very Hash
