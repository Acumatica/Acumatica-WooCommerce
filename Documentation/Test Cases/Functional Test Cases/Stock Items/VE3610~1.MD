
<p><strong><u>Description</u></strong></p>
<p>&nbsp;Application Export the updated information related to the Basic Information</p>
<p><strong><u>Prerequisites</u></strong></p>
<p>1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</p>
<p><strong><u>Detailed Steps to Test</u></strong></p>
<p>1. Go to the Stock Items<br />2. Search and open any record which is already exported to the WC successfully<br />3. Change the following information,<br /><strong>&lt;pDescription&gt;</strong><br /><strong>&lt;pDefaultPrice&gt;</strong><br />4. Save the record, Prepare and Process<br />5. Open the record in WooCommerce and validate the Availability in the WC product level</p>
<p><strong><u>Expected Results</u></strong></p>
<p>&nbsp;The updated values should be changed in the WC application when user open the item</p>
<p><strong><u>Test Data</u></strong></p>
<p>&nbsp;&lt;pDescription&gt;<br />&lt;pDefaultPrice&gt;</p>
