
<p><strong><u>Description</u></strong></p>
<p>Manage stock default value is set to false once the product is created for In stock Items and should not be override form the inventory settings</p>
<p><strong><u>Prerequisites</u></strong></p>
<p>1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</p>
<p><strong><u>Detailed Steps to Test</u></strong></p>
<p>1. Create a non-stock item in AC<br /> 2. Sync the record with the WC<br /> 3. Open the created record in the WC<br /> 4. Validate the Manage stock value</p>
<p><strong><u>Expected Results</u></strong></p>
<p>The Manage Stock value should be false</p>
<p><strong><u>Test Data</u></strong></p>
<p>&lt;pManageStock&gt;</p>
