
<p><u><strong>Description</strong></u></p>
<p><span style="color: rgb(0,0,0);">Payment record which has captured the payment manually (with a new card) and which made as a Guest Customer is imported to the Acumatica</span></p>
<p><u><strong>Prerequisites</strong></u></p>
<p>1. User has access to the ERP application<br />2. WooCommerce Connector is configured</p>
<p>3. Customer has access to the WooCommerce Web Application</p>
<p>4. Release payment setting is disabled for the payment method at WooCommerce Settings</p>
<p>5. Authorize.Net configuration related to the Acumatica and WooCommerce is completed</p>
<p>6. Transaction type has been marked as 'Authorization' in the <a href="http://Authorize.net">Authorize.net</a> plugin</p>
<p>Settings &gt; Payments &gt; Authorize.Net</p>
<p>WooCommerce Settings &gt; Payment</p>
<p>7. Credit Cards have been saved in the customer account</p>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<p>1. Login to the WooCommerce web application as the Registered Customer</p>
<p>2. Place an order and don't enable the check box in order to create a customer account</p>
<p>3. Select the payment methods as <a href="http://Authorize.net">Authorize.net</a> and Make any payment using the exiting card</p>
<p>4. Go to the WC admin application as the admin and open the order</p>
<p>5. Capture the payment via the capture payment button</p>
<p>6. Prepare and Process the payment</p>
<p>Commerce &gt; Processes</p>
<p>7. Open the payment record from Sync History</p>
<p>Commerce &gt; Inquiries</p>
<p>8. Validate the Payment Status and the Process Status</p>
<p><u><strong>Expected Results</strong></u></p>
<p>Payment Status =&nbsp;<strong>Balanced</strong></p>
<p>Process Status =&nbsp;<strong>Captured</strong></p>
<p><u><strong>Test Data</strong></u></p>
<p><strong>N/A</strong></p>
