
<p><u><strong>Description</strong></u></p>
<p>The sales order billing address related to the customer should be imported to the acumatica upon importing the Sales Order record to the AC</p>
<p><u><strong>Prerequisites</strong></u></p>
<p>1. User has access to the ERP application<br />2. WooCommerce Connector is configured</p>
<p>3. Customer has access to the WooCommerce Web Application</p>
<p>4. Customer is registered with billing address and Shipping Address</p>
<p>&nbsp;</p>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<p>&nbsp;</p>
<p>1. Open the WC Client app</p>
<p>2. Login to the WooCommerce web application as the Registered Customer</p>
<p>3. Add some items to the cart</p>
<p>4. Select the payment method and proceed, Then place the order</p>
<p>5. Prepare and Process the payment</p>
<p>Commerce &gt; Processes</p>
<p>6. Open the payment record from Sync History</p>
<p>Commerce &gt; Inquiries</p>
<p>7. Validate the billing address as per the mapping document</p>
<p>&nbsp;</p>
<p><u><strong>Expected Results</strong></u></p>
<p>WC &lt;pfirst_name&gt; value with the 'Attention' field value in the AC sales should be mapped</p>
<p>WC &lt;plast_name&gt; value with the 'Attention' field value in the AC sales should be mapped; <strong>First_name +' '+ Last_name</strong></p>
<p>WC &lt;pcompany&gt; value with the 'Company' field value in the AC sales should be mapped.</p>
<p>WC &lt;paddress_1&gt; value with the 'Address Line 1' field value in the AC sales should be mapped</p>
<p>WC &lt;paddress_2&gt; value with the 'Address Line 2' field value in the AC sales should be mapped</p>
<p>WC &lt;pcity&gt; value with the 'City' field value in the AC sales should be mapped</p>
<p>WC &lt;pstate&gt; value with the 'State' field value in the AC sales should be mapped</p>
<p>WC &lt;ppostcode&gt; value with the 'Postal Code' field value in the AC sales should be mapped</p>
<p>WC &lt;pcountry&gt; value with the 'Postal Code' field value in the AC sales should be mapped</p>
<p>WC &lt;pemail&gt; value with the 'EMail' field value in the AC sales should be mapped</p>
<p>WC &lt;pemail&gt; value with the 'EMail' field value in the AC sales should be mapped</p>
<p>WC &lt;pphone&gt; value with the 'Business 1' field value in the AC sales should be mapped</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p><u><strong>Test Data</strong></u></p>
