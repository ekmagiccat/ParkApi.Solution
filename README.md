# Park API Search

#### _By_ _Eva Kemp_

## **Technologies Used**

- C#
- .NET 6
- Entity Framework Core version 6.0
- EFCore Design
- EFCore Migration
- Razor
- MySql
- Git
- Swagger
- Postman

## **Description**

A park search API that allows users to search for National and State parks by utilizing an API tool like Swagger or Postman.

## **Setup/Installation Requirements**

<details>
<summary> Initial Setup </summary>

- Clone this repository to your local machine.
  ```bash
  $ git clone https://github.com/ekmagiccat/ParkApi.Solution
  ```
- Open VS Code (or your IDE of choice).
- Open the top level directory you just cloned.
</details>

<details>
<summary> Database Setup </summary>

- Use a MySql RDBMS (like MySql Workbench) to import/upload the **\_\_**.sql file and create your database.
- In your ParkApi Directory, create a file with the name `appsettings.json` and copy and past the following code into this file:

  <pre><code>{
      "Logging": {
          "LogLevel": {
          "Default": "Information",
          "Microsoft.AspNetCore": "Warning"
          }
      },
      "AllowedHosts": "*",
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;park_api;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
      }
  }</code></pre>

- Use your personal UID and Password for your db connection and make sure you remove the brackets currently in place.
</details>

<details>
<summary> Finish Setup </summary>

- In your terminal:

  Change directory (cd) to ParkApi.

  ```bash
  $ dotnet build
  ```

  ```bash
  $ dotnet ef migrations add Initial
  ```

  ```bash
  $ dotnet ef database update
  ```

  ```bash
  $ dotnet run
  ```

  (or `dotnet watch run` to see edit and see edits in real time and utilize Swagger).

- A web page will automatically open in your browser at port 5000 or 5001
</details>

## API

### Query Parameters:

- parkId
- name
- location
- type

### Endpoints

<span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?page={number}

- Specify the page number parameter to see a list of parks.
- Example: `http://localhost:5000/api/parks?page=1`

#### Pagination

- Returns a list of 5 parks per page.
- To navigate between pages and see more park items, enter the page number parameter.
- Example: `http://localhost:5000/api/parks?page=2`
- If the page specified contains no data, the api call will return a blank response body [].

#### Query by parameter:

- Search for parks based on query specifications:

<span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks/{id} <br>

<span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?name={name} <br>

<span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?location={location} <br>

<span style="color: rgb(3, 132, 252); font-style: italic;">GET</span> /api/parks?type={type} <br>
<br>

<span style="color: green; font-style: italic;">POST</span> /api/Parks

- Allows user to add a new park to the list in JSON format.
- For example:
  {
  "parkId": 11,
  "name": "Arches National Park",
  "location": "Utah",
  "type": "National"
  }

- The format must be in JSON and have a parkId that isn't currently linked to another park.
  <br>

<span style="color: orange; font-style: italic;">PUT</span> /api/Parks/{id}

- Allows user to edit or update a park's details by specifying the ParkId.
- For example `http://localhost:5000/api/parks/2` would edit the park with a ParkId of 2.

  <br>
<span style="color: red; font-style: italic;">DELETE</span> /api/Parks/{id}

- Deletes a specific park from the list based on its ParkId.
- For example `http://localhost:5000/api/parks/4` would delete the park with the ParkId of 4.
  <br>

## Debugging

<details>
<summary> If the program does not run...</summary>

- Make sure you have the appropriate packages installed to run dotnet

  - In your Terminal, enter the following commands:<br>
    ```bash
     dotnet tool install --global dotnet-ef --version 6.0.0
    ```
    ```bash
     dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
    ```
    ```bash
     dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
    ```
    ```bash
     dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
    ```

</details>

## **Known Bugs**

- Accepts blank data when adding a park item.
- The user must include a page number to get a list of parks returned.

## License

MIT License

Copyright (c) _2023_ Eva Kemp

<details>
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

</details>
