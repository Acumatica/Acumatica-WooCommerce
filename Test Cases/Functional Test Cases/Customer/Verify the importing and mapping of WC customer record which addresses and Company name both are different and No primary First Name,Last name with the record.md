
<p><u><strong>Description</strong></u></p>
<p>Mapping of WC customer with created record in the AC which the addresses and Company name both are different and No primary First Name,Last name with the record</p>
<p><u><strong>Prerequisites</strong></u></p>
<ol>
<li>User has access to the ERP application</li>
<li>WooCommerce Connector is configured</li>
<li>Customer has access to the WooCommerce Web Application</li></ol>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<ol>
<li>Login to the WooCommerce admin panel as the admin</li>
<li>Go to the User module and Click on Add New&nbsp;</li>
<li>Create a customer with Shipping and Billing addresses but make sure the those are different</li>
<li>Leave the to customer primary First Name and the Last name fields are empty</li>
<li>Save the record</li>
<li>Login to the Acumatica application and navigate to the Commerce module</li>
<li>Prepare and Process the customer record<br />Commerce &gt; Processes</li>
<li>Open the Customer record from Sync History<br />Commerce &gt; Inquiries</li>
<li>Validate the customer record created</li>
<li>Verify the record</li></ol>
<p><u><strong>Expected Results</strong></u></p>
<p>Addresses should be imported correctly to the billing address and shipping address columns</p>
<p>The account name should be created from the Company name given with the billing address</p>
<p><u><strong>Test Data</strong></u></p>
<p><u><strong><br /></strong></u></p>
