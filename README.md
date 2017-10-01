# ChatMVC
Basic Chat Application


Setup:
1. Open the OpenComs.sql script in SQL and run the query. This will create the required database and tables.
2. Open the Solution file Chat.sln in Visual Studio.
3. In the solution explorer there are two edmx files, one for the Chat project and one for the ChatService project. Double click on one of them to open it. 
4. Now right click anywhere in the designer and choose Update Model from Database in the context menu.
5. In the Update Wizard click New Connection.
6. Select your database server you created the OpenComs database in as the server name.
7. Choose your SQL login method and input credentials as required.
8. Select OpenComes in the database dropdown and Click OK then click next.
9. On the next window, click on the Refresh tab.
10. Open the Tables tree and select MessageBoard and click Finish.
11. Repeat step 3-9 for the 2nd edmx file.
12. Connection strings should now be set up for both projects.
13. Build and run the application and it should open up in your chosen web browser.

