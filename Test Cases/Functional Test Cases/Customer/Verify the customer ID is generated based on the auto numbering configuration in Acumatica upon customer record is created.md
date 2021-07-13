
<div class="wiki-content">
<p><u><strong>Description</strong></u></p>
<p>customer ID is generated based on the auto numbering configuration in Acumatica upon customer record is created</p>
<p><u><strong>Prerequisites</strong></u></p>
<ol>
<li>User has access to the ERP application</li>
<li>WooCommerce Connector is configured</li>
<li>Customer has access to the WooCommerce Web Application</li>
<li>AC Auto numbering configurations are already created</li></ol>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<ol>
<li>Login to the WooCommerce admin panel as the admin</li>
<li>Go to the User module and Click on Add New&nbsp;</li>
<li>Create a customer with all the required fields</li>
<li>Save the record</li>
<li>Login to the Acumatica application and navigate to the Commerce module</li>
<li>go to the Customer Settings related to the WooCommerce Store Settings<br />Commerce &gt; WooCommerce Stores &gt; Customer Settings</li>
<li>Select the Customer Auto Numbering and Customer Numbering Template</li>
<li>Save the changes</li>
<li>Prepare and Process the customer record<br />Commerce &gt; Processes</li>
<li>Open the Customer record from Sync History<br />Commerce &gt; Inquiries</li>
<li>Validate the customer record created</li>
<li>Validate the Customer ID based on the configurations of Auto numbering</li></ol>
<p><u><strong>Expected Results</strong></u></p>
<p>The customer ID should be generated based on the customer auto numbering configurations</p></div>
<div>
<div><a class="like-button" href="https://wiki.acumatica.com/pages/viewpage.action?pageId=136249967"><span class="aui-icon aui-icon-small aui-iconfont-like" style="color: rgb(112,112,112);">&nbsp;</span></a></div></div>
