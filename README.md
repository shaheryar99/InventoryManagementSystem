# Inventory Management System

## Inspiration:

This project was inspired by a non technical friend who owns a store. The idea behind this program was to create a basic management system where users can actively view, edit and add to their inventory. The GUI was designed to be simple, and easy to use for people that are not technical. It's meant to be a program that can be used without formal training or understanding of the concepts behind it. 

## Requirements: 

Maintaining the concept of simplicity, this program requires: An internet connection, a MySQL Database (local or remote) and a Windows computer capable of using the .NET framework.

## Startup:

The first time the program is launched, the user is prompted to add credentials for connection to a MySQL database, namely: the server, the username, the password and the database name. 
Upon connection, the program creates tables within the database that contain the information required to maintain the inventory levels. 
The database credentials are encrypted by the encryption class, then stored locally in the file db_list. The only plain text within that file is a friendly DB name assigned by the user.
If the file db_list exists, the user is prompted with a list of databases (provided there are multiple), upon selection the credentials for that particular database are loaded in from db_list, decrypted and a connection is established.
The user is also given the option to add or remove database(s), this removes the database credentials from the db_list file **_but_ does not remove ANY information from the remote database server.**

## Use: 

Once connected, the user is directed to the main screen where a ListView is populated with the information already present in the database. 
The user can then add an item by entering any of the following information: Item name, Item price, Item identifier (SKU number etc.), Quantity on hand & a description.
If the user clicks on any item attribute within the ListView, the text fields for that particular item are populated and the user can edit and update the information. 
The user can also search perform a search using item attributes by utilizing the search bar just above ListView. 

## Future Implementations: 

* POS Integration for automatic quantity updates upon sale/return. 
* Use of this system with a POS System for retrieving information such as Item name, description, price, identifier etc. 
* Ability to track changes to inventory levels and pricing (Item history). 
* Use of multiple identifiers such as barcode and SKU concurrently.
* Web based integration 

##### This project is free to use for anyone that so desires, all content and code used has either been referenced, or written by me. You are more than welcome and encouraged to edit & change anything within the code and design to fit your personal needs :). 
