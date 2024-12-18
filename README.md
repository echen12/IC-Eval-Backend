# IC-Eval-Backend

### Development Tasks (cross reference with appropriate branch):

- **BE-1**: Create and store JSON file somewhere in the project.
- **BE-2**: Create Minimal API to serve the JSON file from a GET endpoint.
- **BE-3**: Reconfigure development URL.

### Steps to Run the Application:

1. Clone the project.
2. Navigate to where you cloned the project and open the project folder.
3. Run the .sln file in Visual Studio.
4. Open the Developer Command Prompt and run `dotnet build`.
5. Run `dotnet watch` to start the application.
6. Navigate to the following URL: [http://localhost:5050/data](http://localhost:5050/data).
7. If you see the following JSON output:

    ```json
    {
      "title": "Sample Form",
      "fields": [
        {
          "type": "text",
          "label": "Name",
          "required": true
        },
        {
          "type": "email",
          "label": "Email",
          "required": true
        },
        {
          "type": "number",
          "label": "Age",
          "min": 18,
          "max": 100
        },
        {
          "type": "dropdown",
          "label": "Industry",
          "values": [ "Tech", "Production", "Health" ],
          "required": true
        },
        {
          "type": "checkbox",
          "label": "Subscribe to Newsletter",
          "required": false
        },
        {
          "type": "date",
          "label": "Date of Birth",
          "required": true
        },
        {
          "type": "datetime",
          "label": "Event Date",
          "required": true
        },
        {
          "type": "time",
          "label": "Preferred Time",
          "required": true
        },
        {
          "type": "textarea",
          "label": "Description",
          "required": false
        },
        {
          "type": "range",
          "label": "Satisfaction",
          "min": 1,
          "max": 10
        },
        {
          "type": "color",
          "label": "Favorite Color",
          "required": false
        },
        {
          "type": "radio",
          "label": "Gender",
          "values": [ "Male", "Female", "Other" ],
          "required": true
        }
      ]
    }
    ```

7. You're ready to start the front end of the project.
8. To update how a form is configured, paste a valid form configuration JSON to StaticFiles -> data.json