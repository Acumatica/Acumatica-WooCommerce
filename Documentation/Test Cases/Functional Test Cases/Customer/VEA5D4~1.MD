
<div class="wiki-content">
<p><u><strong>Description</strong></u></p>
<p>new record is NOT created in acumatica upon user made an update from WC in Customer Billing Address/ Shipping Address</p>
<p><u><strong>Prerequisites</strong></u></p>
<ol>
<li>User has access to the ERP application</li>
<li>WooCommerce Connector is configured</li>
<li>Customer has access to the WooCommerce Web Application</li></ol>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<ol>
<li>Login to the WooCommerce admin panel as the admin</li>
<li>Go to the User module and Click on Add New&nbsp;</li>
<li>Create a customer with billing address and shipping address (Two different data)</li>
<li>Save the record</li>
<li>Login to the Acumatica application and navigate to the Commerce module</li>
<li>Prepare and Process the customer record<br />Commerce &gt; Processes</li>
<li>Open the Customer record from Sync History<br />Commerce &gt; Inquiries</li>
<li>Validate the customer record created</li>
<li>Go back to the WC and Update the customer Names, Contact numbers, Billing address and the shipping address and save the record</li>
<li>Resync the customer record to the AC and validate the updated data in the AC customer billing and shipping addresses</li></ol>
<p><u><strong>Expected Results</strong></u></p>
<p>New record should not be created in acumatica upon user made an update from WC in Customer record</p></div>
<div>
<div><a class="like-button" href="https://wiki.acumatica.com/pages/viewpage.action?pageId=136249967"><span class="aui-icon aui-icon-small aui-iconfont-like" style="color: rgb(112,112,112);">&nbsp;</span></a></div></div>
