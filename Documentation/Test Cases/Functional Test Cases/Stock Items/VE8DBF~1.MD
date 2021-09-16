
<p><strong><u>Description</u></strong></p>
<p>&nbsp;Manage Stock Boolean = True upon exporting a stock item with the Availability is &quot;Set as Available (Track Qty)&quot;</p>
<p><strong><u>Prerequisites</u></strong></p>
<p>1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</p>
<p><strong><u>Detailed Steps to Test</u></strong></p>
<p>1. Create a Stock item by filling all the mandatory fields<br />2. Availability&quot; = Available (Track Qty)&quot;&nbsp;<strong>&lt;pAvailability&gt;</strong><br />3. Save the record, Prepare and Process<br />4. Open the record in WooCommerce and validate the validate Manage Stock Boolean value</p>
<p><strong><u>Expected Results</u></strong></p>
<p>The Manage stock Boolean should be 'True'</p>
<p><strong><u>Test Data</u></strong></p>
<p>&nbsp;<strong>&lt;pAvailability&gt;</strong></p>
