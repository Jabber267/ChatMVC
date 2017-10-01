# ChatAssessment
Basic Chat Application


Setup:
1. Open the OpenComs.sql script in SQL and run the query. This will create the required database and tables.
2. Open the Solution file Chat.sln in Visual Studio.
3. In the solution explorer there are two edmx files, one for the Chat project and one for the ChatService project. Double click on one of them to open it. No right click anywhere in the designer and choose Update Model from Database in the context menu.
4. In the Update Wizard click New Connection.
5. Select your database server you created the OpenComs database in as the server name.
6. Choose your SQL login method and input credentials as required.
7. Select OpenComes in the database dropdown and Click OK then click next.
8. On the next window, click on the Refresh tab.
9. Open the Tables tree and select MessageBoard and click Finish.
10. Repeat step 3-9 for the 2nd edmx file.
11. Connection strings should now be set up for both projects.
12. Build and run the application and it should open up in your chosen web browser.

