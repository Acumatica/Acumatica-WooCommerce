Description

customer Billing Address/ Shipping address is updated in Acumatica upon updating the address partially from WC and Imported with the sync process

Prerequisites

User has access to the ERP application
WooCommerce Connector is configured
Customer has access to the WooCommerce Web Application
Detailed Steps to Test

Login to the WooCommerce admin panel as the admin
Go to the User module and Click on Add New 
Create a customer with billing address and shipping address (Two different data)
Save the record
Login to the Acumatica application and navigate to the Commerce module
Prepare and Process the customer record
Commerce > Processes
Open the Customer record from Sync History
Commerce > Inquiries
Validate the customer record created
Go back to the WC and Update the customer Billing address and the shipping address and save the record
Resync the customer record to the AC and validate the updated data in the AC customer billing and shipping addresses
Expected Results

The Billing address and the Shipping address have been updated
