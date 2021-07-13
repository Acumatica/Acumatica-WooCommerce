
<p><u><strong>Description</strong></u></p>
<p><span style="color: rgb(0,0,0);">Sync the record without capture the payment first. Then Re - Sync the same recor after capturing the payment from acumatica manually.&nbsp;</span></p>
<p><u><strong>Prerequisites</strong></u></p>
<p>1. User has access to the ERP application<br />2. WooCommerce Connector is configured</p>
<p>3. Customer has access to the WooCommerce Web Application</p>
<p><strong>4. Release payment setting is enabled for the payment method at WooCommerce Settings</strong></p>
<p>5. Authorize.Net configuration related to the Acumatica and WooCommerce is completed</p>
<p>6. Transaction type has been marked as 'Authorization' in the <a href="http://Authorize.net">Authorize.net</a> plugin</p>
<p>Settings &gt; Payments &gt; Authorize.Net</p>
<p>WooCommerce Settings &gt; Payment</p>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<p>1. Login to the WooCommerce web application as the Registered Customer</p>
<p>2. Place an order and <strong>enable the check box in order to create a customer account</strong></p>
<p>3. Select the payment methods as <a href="http://Authorize.net">Authorize.net</a> and enter a card id <strong>(Dont enable save card option)</strong></p>
<p>4. Prepare and Process the record. Validate the payment status and the Processing Status</p>
<p>4. Go to the WC admin application as the admin and open the order again</p>
<p>5. Capture the payment via the capture payment button</p>
<p>6. Again Prepare and Process the payment</p>
<p>Commerce &gt; Processes</p>
<p>7. Open the payment record from Sync History</p>
<p>Commerce &gt; Inquiries</p>
<p>8. Validate the Payment Status and the Process Status</p>
<p><u><strong>Expected Results</strong></u></p>
<p>Payment Status =&nbsp;<strong>Open</strong></p>
<p>Process Status =&nbsp;<strong>Captured</strong></p>
<p><u><strong>Test Data</strong></u></p>
<p><strong>N/A</strong></p>
