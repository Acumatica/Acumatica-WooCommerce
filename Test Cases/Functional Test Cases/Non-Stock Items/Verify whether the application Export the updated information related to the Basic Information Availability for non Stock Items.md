
<p><strong><u>Description</u></strong></p>
<p>&nbsp;Export the updated information related to the configuration - Availability</p>
<p><strong><u>Prerequisites</u></strong></p>
<p>1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</p>
<p><strong><u>Detailed Steps to Test</u></strong></p>
<p>1. Go to the Stock Items<br />2. Search and open any record which is already exported and the Availability is 'Set as Available (Track Qty)' in Acumatica Stock Item Level<br />3. Go to the Availability drop down and change the value as<strong>&nbsp;&lt;pAvailability&gt;</strong><br />ECommerce Tab &gt; Availability<br />4. Go to the WooCommerce Storces and Click on the 'Inventory Settings'<br />5. Change the 'Default Visibility' ,<strong>&lt;pAvailabilityDefault&gt;</strong><br />6. Save the record, Prepare and Process<br />7. Open the record in WooCommerce and validate the Availability in the WC product level</p>
<p><strong><u>Expected Results</u></strong></p>
<p>&nbsp;The record of the WooCommerce should be updated and manage stock check box should be disabled</p>
<p><strong><u>Test Data</u></strong></p>
<p>&nbsp;&lt;pAvailability&gt; = 'Store Default'<br />&lt;pAvailabilityDefault&gt; = 'Set as Available (Don't Track Qty)'</p>
