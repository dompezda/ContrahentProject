The Contrahent Projekt is application builded from 3 pieces:
  a) WEB API (.Net Core) - provide methods to display data from database (GET), to add new data to database (POST), to update existing data (PUT) and to delete data from database (DELETE).
  b) SQL Database - contains the app data
  c) Angular Frontend - WebPages wrote in Angular, that displaying data and provide the possibility to interact with app
  
  Basic app screen:<br>
  a) display database data - Views that enable to display, delete and edit data<br>
  ![image](https://user-images.githubusercontent.com/32547421/135588078-7f25d42f-9938-48ea-a756-e0f32da045b8.png)
  ![image](https://user-images.githubusercontent.com/32547421/135588121-262064a9-3126-468d-81a9-0671ad117e6d.png)
  <br>
  b) adding new data (modal window)<br>
  ![image](https://user-images.githubusercontent.com/32547421/135588340-5a3cd8b5-ba59-4c3f-9968-9fc455380ac1.png)
  <br>
  c) editing existing data<br>
  ![image](https://user-images.githubusercontent.com/32547421/135588392-a0ccaf31-f3b8-4e1e-85d7-40265db6a914.png)

Before running app:<br>
a) add migrations <br>
b) update database<br>
c) check apiurl in Angular (SharedService)<br>
