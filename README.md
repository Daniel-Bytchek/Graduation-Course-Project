# Graduation-Course-Project
This is information system which represents library with its books and readers. The main goal if this project is to automate the process of borrowing books and tracking readers activity. This system is created for private and public libraries, and make the process of monitoring data much easier and better, than using paper journals for this.

You can read about my project in more detail in the document that is called Documentation.pdf.

ATTENTION!!! SYSTEM WILL NOT WORK WITHOUT HOSTED DB. I explained how to host it further in the text, but if you have no much experience you can just write on my email and I will describe how to do it individually (argonianseller@gmail.com). When I released system, I hosted DB server, but if its shut down, follow the instructions below.

There is file called librarydata.sql. This file accommodates all data that is used by system. To start the program with working db you need to host local db ( I was using phpmyadmin on MAMP ) and change your connection to db in "DB.cs" file. The right line is called - "MySqlConnection connection" and is located on 17 line of code (DB.cs).

Here is like mine connection string look like:
MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=librarydata");

Your connection string may look with different properties.

I have added file called "librarydata.sql". This file contains all data that program needs to work with. If you gonna host your own db, you need to import this file into your db.
