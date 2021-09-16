
<p><u><strong>Description</strong></u></p>
<p>Customer Account name created from the User name when there is no First name and the Last name created in WC</p>
<p><u><strong>Prerequisites</strong></u></p>
<ol>
<li>User has access to the ERP application</li>
<li>WooCommerce Connector is configured</li>
<li>Customer has access to the WooCommerce Web Application</li></ol>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<ol>
<li>Login to the WooCommerce admin panel as the admin</li>
<li>Go to the User module and Click on Add New&nbsp;</li>
<li>Create a customer with the primary information</li>
<li>Save the record</li>
<li>Login to the Acumatica application and navigate to the Commerce module</li>
<li>Prepare and Process the customer record<br />Commerce &gt; Processes</li>
<li>Open the Customer record from Sync History<br />Commerce &gt; Inquiries</li>
<li>Validate the customer record created</li>
<li>Go to the 'Bill-To-Info section</li>
<li>Validate the Attention field value</li></ol>
<p><u><strong>Expected Results</strong></u></p>
<p>The&nbsp;Attention field value should be created by First Name and the Last Name</p>
