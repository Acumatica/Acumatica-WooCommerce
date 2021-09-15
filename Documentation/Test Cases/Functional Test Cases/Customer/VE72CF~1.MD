
<div class="wiki-content">
<p><u><strong>Description</strong></u></p>
<p>Customer ID of the WooCommerce is created in the Acumatica as the ExtReferenceNbr upon importing any new customer record</p>
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
<li>Validate the&nbsp;ExtReferenceNbr&nbsp; of the General section</li></ol>
<p><u><strong>Expected Results</strong></u></p>
<p>ExtReferenceNbr should be created from WC <strong>Customer ID + &lt;pStoreName&gt;</strong></p></div>
<div>
<div><a class="like-button" href="https://wiki.acumatica.com/pages/viewpage.action?pageId=136249970"><span class="aui-icon aui-icon-small aui-iconfont-like" style="color: rgb(112,112,112);">&nbsp;</span></a></div></div>
