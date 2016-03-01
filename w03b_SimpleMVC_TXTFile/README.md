Lab: Deploy MVC App to Azure

1) Use the demo exercise we developed in class involving the display of all processes and detail of an individual process.

2) Deploy this application into IIS running on your Azure virtual machine.

3) Make sure that the web site is accessable outside of the virtual machine using your own personal domain name and host w03 (Example: w03.goodle.ca). 

4) Also, make sure that you are able to register a user within your web application's localdb database that resides in the App_Data directory:

email == a@a.a
password== P@$$w0rd
This verifies that database access is working as intended.

Part 2: Add more funtionality

1) Create six text files in the /TextFiles directory named File1.txt .. File6.txt with content "File # 1" .. "File # 6"

2) Create a Files controller with two action methods index & content. The index view displays only the file names (without the path) in the /TextFiles directory in the form of links. When you click on any of the files, it displays the content of a file in the content view.

You are not allowed to use query strings to pass the filename from the view back to the controller. In other words use http://www.goodle.ca/files/display/text1 instead of http://www.goodle.ca/files/display?filename=text1.txt.
Also, you are not allowed to use any fully qualified file system absolute address in your code (Example: c:\work\lab is not allowed). You must, instead, use the MapPath function to translate relative URL addresses to absolute file system addresses.
3) Add a link on your home page's menu bar that points to the files/index action method with text "Text Files".
