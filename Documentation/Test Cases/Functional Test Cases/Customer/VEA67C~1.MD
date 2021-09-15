
<p><u><strong>Description</strong></u></p>
<p>override option in the shipping address of AC customer record is NOT enabled upon importing a Customer with Billing and Shipping address are equal</p>
<p><u><strong>Prerequisites</strong></u></p>
<ol>
<li>User has access to the ERP application</li>
<li>WooCommerce Connector is configured</li>
<li>Customer has access to the WooCommerce Web Application</li></ol>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<ol>
<li>Login to the WooCommerce admin panel as the admin</li>
<li>Go to the User module and Click on Add New&nbsp;</li>
<li>Create a customer with a Billing address and Shipping (Both should be same)</li>
<li>Save the record</li>
<li>Login to the Acumatica application and navigate to the Commerce module</li>
<li>Prepare and Process the customer record<br />Commerce &gt; Processes</li>
<li>Open the Customer record from Sync History<br />Commerce &gt; Inquiries</li>
<li>Validate the customer record created and the Override option</li></ol>
<p><u><strong>Expected Results</strong></u></p>
<p>The override option in the Shipping address section should not be enabled</p>
