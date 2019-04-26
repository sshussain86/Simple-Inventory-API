# Getting started

This is a simple API

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (SimpleInventoryAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Simple%20Inventory%20API-CSharp&workspaceName=SimpleInventoryAPI&projectName=SimpleInventoryAPI.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the SimpleInventoryAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Simple%20Inventory%20API-CSharp&workspaceName=SimpleInventoryAPI&projectName=SimpleInventoryAPI.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Simple%20Inventory%20API-CSharp&workspaceName=SimpleInventoryAPI&projectName=SimpleInventoryAPI.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Simple%20Inventory%20API-CSharp&workspaceName=SimpleInventoryAPI&projectName=SimpleInventoryAPI.Tests)

### 3. Add reference of the library project

In order to use the SimpleInventoryAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Simple%20Inventory%20API-CSharp&workspaceName=SimpleInventoryAPI&projectName=SimpleInventoryAPI.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` SimpleInventoryAPI.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```SimpleInventoryAPI.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Simple%20Inventory%20API-CSharp&workspaceName=SimpleInventoryAPI&projectName=SimpleInventoryAPI.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Simple%20Inventory%20API-CSharp&workspaceName=SimpleInventoryAPI&projectName=SimpleInventoryAPI.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

SimpleInventoryAPIClient client = new SimpleInventoryAPIClient();
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [DevelopersController](#developers_controller)
* [AdminsController](#admins_controller)

## <a name="developers_controller"></a>![Class: ](https://apidocs.io/img/class.png "SimpleInventoryAPI.Tests.Controllers.DevelopersController") DevelopersController

### Get singleton instance

The singleton instance of the ``` DevelopersController ``` class can be accessed from the API Client.

```csharp
DevelopersController developers = client.Developers;
```

### <a name="search_inventory"></a>![Method: ](https://apidocs.io/img/method.png "SimpleInventoryAPI.Tests.Controllers.DevelopersController.SearchInventory") SearchInventory

> By passing in the appropriate options, you can search for
> available inventory in the system
> 


```csharp
Task<List<Standard.Models.InventoryItem>> SearchInventory(string searchString = null, int? skip = null, int? limit = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| searchString |  ``` Optional ```  | pass an optional search string for looking up inventory |
| skip |  ``` Optional ```  | number of records to skip for pagination |
| limit |  ``` Optional ```  | maximum number of records to return |


#### Example Usage

```csharp
string searchString = "searchString";
int? skip = 116;
int? limit = 116;

List<Standard.Models.InventoryItem> result = await developers.SearchInventory(searchString, skip, limit);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | bad input parameter |


[Back to List of Controllers](#list_of_controllers)

## <a name="admins_controller"></a>![Class: ](https://apidocs.io/img/class.png "SimpleInventoryAPI.Tests.Controllers.AdminsController") AdminsController

### Get singleton instance

The singleton instance of the ``` AdminsController ``` class can be accessed from the API Client.

```csharp
AdminsController admins = client.Admins;
```

### <a name="add_inventory"></a>![Method: ](https://apidocs.io/img/method.png "SimpleInventoryAPI.Tests.Controllers.AdminsController.AddInventory") AddInventory

> Adds an item to the system


```csharp
Task AddInventory(Standard.Models.InventoryItem body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Optional ```  | Inventory item to add |


#### Example Usage

```csharp
var body = new Standard.Models.InventoryItem();

await admins.AddInventory(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | invalid input, object invalid |
| 409 | an existing item already exists |


[Back to List of Controllers](#list_of_controllers)



