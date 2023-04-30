# CIS560-Project-S23

## File Structure  
Inside the Window Forms Application, folder are arranged in the following structure:  

**Sql\Data:** Holds TSV files data was pulled from, format files controller BCPs, and Python scripts used to process and join TSVs before data is inserted into tables.  
**Sql\Procedures:** Contains SQL files that modify or lookup data in any of the tables. The four aggregating queries are also stored here.  
**Sql\Schemas:** Holds the file that creates the MovieDatabase schema  
**Sql\Tables:** Includes all the SQL files that created the tables in our database. Also contains an SQL script to drop all the tables.  
**Controllers:** The WindowController class in this folder passes information from the models to the views and controls logic related to logging in users.  
**Models:** Holds models representing things like movies and users.  
**Views:** GUIs for all the different winows used in the application are here.  
**Program.cs:** Entry point of the application. Delegates and objects for views are created here. A function to open a connection to the SQL server, create the schema, drop the tables, and create tables called RebuildDatabase() is here. Build copy procedures populate the tables with IMDb information by running the BCP command for the user before the login window runs. The fucntion to run the BCP commands is called BulkCopyData().  
