
<p><u><strong>Description</strong></u></p>
<p><span style="color: rgb(0,0,0);">Payment record which has captured automatically with a new card and which made as a new Customer is imported to the Acumatica</span></p>
<p><u><strong>Prerequisites</strong></u></p>
<p>1. User has access to the ERP application<br />2. WooCommerce Connector is configured</p>
<p>3. Customer has access to the WooCommerce Web Application</p>
<p>4. Release payment setting is disabled for the payment method at WooCommerce Settings</p>
<p>WooCommerce Settings &gt; Payment</p>
<p>5. Authorize.Net configuration related to the Acumatica and WooCommerce is completed</p>
<p>6. CC is not saved with the account</p>
<p>&nbsp;</p>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<p>&nbsp;</p>
<p>1. Transaction type has been marked as 'Authorization' in the&nbsp;<a class="external-link" href="http://authorize.net/" rel="nofollow">Authorize.net</a>&nbsp;plugin and enable the capture paid orders</p>
<p>Settings &gt; Payments &gt; Authorize.Net</p>
<p>2. Login to the WooCommerce web application as the New Customer</p>
<p>3. Place an order and <strong>enable the check box in order to create a customer account</strong></p>
<p>4. Select the payment methods as&nbsp;<a class="external-link" href="http://authorize.net/" rel="nofollow">Authorize.net</a>, enter a new card</p>
<p>5. Prepare and Process the payment</p>
<p>Commerce &gt; Processes</p>
<p>6. Open the payment record from Sync History</p>
<p>Commerce &gt; Inquiries</p>
<p>7. Validate the Payment Status and the Process Status</p>
<p><u><strong>Expected Results</strong></u></p>
<p>Payment Status =&nbsp;<strong>Balanced</strong></p>
<p>Process Status =&nbsp;<strong>Captured</strong></p>
<p><u><strong>Test Data</strong></u></p>
<p><strong>N/A</strong></p>
