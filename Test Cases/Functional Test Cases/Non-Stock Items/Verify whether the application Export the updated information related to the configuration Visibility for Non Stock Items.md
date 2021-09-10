
<p><strong><u>Description</u></strong></p>
<p>application Export the updated information related to the Basic Information -&nbsp;<strong>Visibility</strong></p>
<p><strong><u>Prerequisites</u></strong></p>
<p>1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</p>
<p><strong><u>Detailed Steps to Test</u></strong></p>
<p>1. Go to the Non-Stock Items<br />2. Search and open any record which is already exported and the Visibility is 'Visible' in Acumatica Stock Item Level<br />3. Go to the Visibility drop down and change the value as 'Store Default'<br />ECommerce Tab &gt; Visibility<br />4. Go to the WooCommerce Storces and Click on the 'Inventory Settings'<br />5. Change the 'Default Visibility' ,<strong>&lt;pVisibilityDefault&gt;</strong><br />6. Save the record, Prepare and Process<br />7. Open the record in WooCommerce</p>
<p><strong><u>Expected Results</u></strong></p>
<p>&nbsp;The record of the WooCommerce should be updated and Featured check box should be enabled.</p>
<p><strong><u>Test Data</u></strong></p>
<p>&nbsp;&lt;pVisibility&gt;<br />&lt;pVisibilityDefault&gt; = Featured</p>
