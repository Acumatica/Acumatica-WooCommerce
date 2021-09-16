
<p><u><strong>Description</strong></u></p>
<p>Validate the data mapping upon importing a customer record without any addresses</p>
<p><u><strong>Prerequisites</strong></u></p>
<ol>
<li>The connector is configured for Acumatica and WooCommerce successfully</li>
<li>WooCommerce instance (client app) is up and running</li>
<li>Acumatica instance is up and running</li></ol>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<ol>
<li>Go to the WooCommerce application by entering the &lt;pURL&gt; as a unregistered user</li>
<li>Click on the customer Registration button</li>
<li>Enter the required general in the following&nbsp; fields<br />&lt;pUserName&gt;<br />&lt;pFirstName&gt;<br />&lt;pLastName&gt;<br />&lt;pEmailAddress&gt;<br />&lt;pPassword&gt;</li>
<li>Save/ Publish the Customer</li>
<li>Import the customer data to the Acumatica</li>
<li>Verify the customer data mapping against to the Customer Data Import Mapping</li></ol>
<p><u><strong>Expected Results</strong></u></p>
<ol>
<li>Application should be opened in the browser and should be navigated to the landing page(Home)</li>
<li>Application should be navigated to the customer registration page</li>
<li>User should be able to enter the general information</li>
<li>The record created in the WC successfully</li>
<li>User should be able to sync the from Acumatica based on the selected syncing process and Customer record created in the Acumatica</li>
<li>All the data should be correctly mapped with the acumatica relevant field as per the mapping design</li></ol>
<p><u><strong>Test Data</strong></u></p>
<p>&lt;pURL&gt;</p>
<p>&lt;pUserName&gt;<br />&lt;pFirstName&gt;<br />&lt;pLastName&gt;<br />&lt;pEmailAddress&gt;<br />&lt;pPassword&gt;</p>
