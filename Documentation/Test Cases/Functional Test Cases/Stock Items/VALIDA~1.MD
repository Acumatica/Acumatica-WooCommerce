
<p><strong><u>Description</u></strong></p>
<p>&nbsp;Virtual Boolean = False upon export a stock item with ItemClass-&gt; Stock item Boolean=True</p>
<p><strong><u>Prerequisites</u></strong></p>
<p>1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</p>
<p><strong><u>Detailed Steps to Test</u></strong></p>
<p>1. Create a Stock item by filling all the mandatory fields<br />2. ItemClass-&gt; Stock item Boolean=True&nbsp;<strong>&lt;pItemClass&gt;</strong><br />3. Save the record, Prepare and Process<br />4. Open the record in WooCommerce and validate the validate the Virtual Boolean</p>
<p><strong><u>Expected Results</u></strong></p>
<p>The WC virtual boolean should be FALSE</p>
<p><strong><u>Test Data</u></strong></p>
<p>&nbsp;<strong>&lt;pItemClass&gt;</strong></p>
