
<p><strong><u>Description</u></strong></p>
<p>Validate the address importing to the acumatica with Shipping address and billing address</p>
<p><strong><u>Prerequisites</u></strong></p>
<p>&nbsp;The connector is configured for Acumatica and WooCommerce successfully</p>
<p>WooCommerce instance (client app) is up and running</p>
<p>Acumatica instance is up and running</p>
<p>Customer is accessible the WooCommerce Client application and privileged to place the orders</p>
<p><strong><u>Detailed Steps to Test</u></strong></p>
<ol>
<li>Go to the WooCommerce application by entering the &lt;pURL&gt; as a unregistered user</li>
<li>Login to the application as the registered User</li>
<li>Add product to the cart and navigate to the checkout page</li>
<li>Enter the Billing details<br />&lt;pBillingFirstName&gt;<br />&lt;pBillingLastName&gt;<br />&lt;pBillingCompany&gt;<br />&lt;pBillingAddress1&gt;<br />&lt;pBillingAddress2&gt;<br />&lt;pBillingCity&gt;<br />&lt;pBillingState&gt;<br />&lt;pBillingPostCode&gt;<br />&lt;pBillingCountry&gt;<br />&lt;pBillingEmail&gt;<br />&lt;pBillingPhone&gt;</li>
<li>Enter the Shipping Address<br />&lt;pShippingFirstName&gt;<br />&lt;pShippingLastName&gt;<br />&lt;pShippingCompany&gt;<br />&lt;pShippingAddress1&gt;<br />&lt;pShippingAddress2&gt;<br />&lt;pShippingCity&gt;<br />&lt;pShippingState&gt;<br />&lt;pShippingPostCode&gt;<br />&lt;pShippingCountry&gt;</li>
<li>Checkout the order</li>
<li>Import the customer data to the Acumatica</li>
<li>Validate the 'Shipping To Address' section under the Customer &gt; Shipping Tab of Acumatica with WC values</li>
<li>Validate the 'Billing To Address' section under the Customer &gt; Shipping Tab of Acumatica with WC values</li></ol>
<p><strong><u>Expected Results</u></strong></p>
<ol>
<li>Application should be opened in the browser and should be navigated to the landing page(Home)</li>
<li>User should be able to login to the application</li>
<li>User should be able to enter the Billing address details</li>
<li>User should be able to enter the Shipping address details</li>
<li>User should be able to place the order</li>
<li>Verify all the customer address detailed have been updated based on the details customer has entered</li>
<li>The WC shipping address values should be created in the 'Shipping to Address' section as per the field mapping&nbsp;</li>
<li>The WC Billing address values should be created in the 'Shipping to Address' section as per the field mapping&nbsp;</li></ol>
<p><strong><u>Test Data</u></strong></p>
<p>&nbsp;</p>
