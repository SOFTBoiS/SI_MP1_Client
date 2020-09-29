# Mini Project 1 client

## Authors

Adam Saidane - cph-as410@cphbusiness.dk  
Emil Valbak Hermansen - email  
Sebastian Lundsgaard Larsen - cph-sl281@cphbusiness.dk  

## About

We have created an application where users can enter their name and search for images. When they search for images we send a request to our SOAP client that uses an external web service to provide images for the search query.  
Our REST server handles creation of search history. Search history is saved as the first url in the search query, and the name of the person searching for images.

## Before running the client:

1. Clone, follow the instructions and run the SOAP server:  
   https://github.com/SOFTBoiS/SI_MP1_SOAP_server
2. Clone, follow the instructions and run the REST server:  
   https://github.com/SOFTBoiS/SI_MP1_REST_server

3. If there is no refference to the SOAP server on the client:  
   Follow the Client part of the following guide, to add the server as a Service Reference:  
   https://github.com/AdamSai/WCF_Introduction#client

## How to use

1. Enter your name in the left input field and your search query in the right input field and click the search button.
2. To view your search history, after making a search click on the navigation bar on the left and click on the newly appeared `History` navigation button.
