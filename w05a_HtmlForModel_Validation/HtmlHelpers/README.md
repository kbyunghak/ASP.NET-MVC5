Step A
This lab involves the Northwind Product, Category and Supplier tables.
Using the Html.EditorForModel helper method, enable the creation, edit, 
and display of only the following columns of the Product entity. 

Product Name	
Supplier	Drop-down-list
Category	Drop-down-list
Unit Price	Two decimal places

Since you are not using code-first development, you must create a partial class for validation of the Product entity.

Change the CSS so that the input fields are placed beside labels. All your error messages must be displayed in red text.

Step B

Custom Validation Annotation
This lab is an extension of the previous lab.

Create a custom annotation that ensures that product name does not exceed n words. The value of n is to be passed as a parameter to the custom annotation. Apply the custom annotation to the ProductName property of the Product entity. To make it easy for your instructor to mark your lab, please set n=3.
