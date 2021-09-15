
<p><u><strong>Description</strong></u></p>
<p>override option in the Acumatica Customer shipping address should be enabled when the WooCommerce Shipping address is empty</p>
<p><u><strong>Prerequisites</strong></u></p>
<ol>
<li>User has access to the ERP application</li>
<li>WooCommerce Connector is configured</li>
<li>Customer has access to the WooCommerce Web Application</li></ol>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<ol>
<li>Login to the WooCommerce admin panel as the admin</li>
<li>Go to the User module and Click on Add New&nbsp;</li>
<li>Create a customer without the shipping address</li>
<li>Save the record</li>
<li>Login to the Acumatica application and navigate to the Commerce module</li>
<li>Prepare and Process the customer record<br />Commerce &gt; Processes</li>
<li>Open the Customer record from Sync History<br />Commerce &gt; Inquiries</li>
<li>Validate the customer record created and the Override Option</li></ol>
<p><u><strong>Expected Results</strong></u></p>
<p>The override option in the acumatica should be enabled upon importing the customer record without a shipping address</p>
