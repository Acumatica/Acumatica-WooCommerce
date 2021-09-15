
<div class="wiki-content">
<p><u><strong>Description</strong></u></p>
<p>customer Billing Address/ Shipping address is updated in Acumatica upon updating the address partially from WC and Imported with the sync process</p>
<p><u><strong>Prerequisites</strong></u></p>
<ol>
<li>User has access to the ERP application</li>
<li>WooCommerce Connector is configured</li>
<li>Customer has access to the WooCommerce Web Application</li></ol>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<ol>
<li>Login to the WC customer app as the Guest customer</li>
<li>Place an order while enabling the check box create new account in the checkout page</li>
<li>Login to the Acumatica application and navigate to the Commerce module</li>
<li>Prepare and Process the customer record<br />Commerce &gt; Processes</li>
<li>Open the Customer record from Sync History<br />Commerce &gt; Inquiries</li>
<li>Validate the Sales order record and the customer record created in the AC</li></ol>
<p><u><strong>Expected Results</strong></u></p>
<p>New customer has been created in the AC alone with the new order</p></div>
<div>
<div><a class="like-button" href="https://wiki.acumatica.com/pages/viewpage.action?pageId=136249967"><span class="aui-icon aui-icon-small aui-iconfont-like" style="color: rgb(112,112,112);">&nbsp;</span></a></div></div>
