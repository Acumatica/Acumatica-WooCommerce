
<p><strong><u><span style="color: rgb(51,51,51);">Description</span></u></strong><span style="color: rgb(51,51,51);">&nbsp;</span></p>
<p><span style="color: rgb(51,51,51);">WC Product Status is 'Draft' when the Stock item status of the Acumatica is 'Inactive'</span></p>
<p style="margin-left: 0.0in;"><strong><u><span style="color: rgb(51,51,51);">Prerequisites</span></u></strong><span style="color: rgb(51,51,51);">&nbsp;</span></p>
<p style="margin-left: 0.0in;"><span style="color: rgb(51,51,51);">1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</span></p>
<p style="margin-left: 0.0in;"><strong><u><span style="color: rgb(51,51,51);">Detailed Steps to Test</span></u></strong><span style="color: rgb(51,51,51);">&nbsp;</span></p>
<p style="margin-left: 0.0in;">1. Create a non-Stock item by filling all the mandatory fields<br />2. Acumatica Stock Item Status = '<strong>Inactive</strong>'&nbsp;<strong>&lt;pStatus&gt;</strong><br />3. Save the record, Prepare and Process<br />4. Open the record in WooCommerce and validate the status of the product</p>
<p style="margin-left: 0.0in;"><strong><u><span style="color: rgb(51,51,51);">Expected Results</span></u></strong><span style="color: rgb(51,51,51);">&nbsp;</span></p>
<p style="margin-left: 0.0in;"><span style="color: rgb(51,51,51);">WC Product Status is 'Draft'</span></p>
<p style="margin-left: 0.0in;"><strong><u><span style="color: rgb(51,51,51);">Test Data</span></u></strong></p>
<p>Inactive</p>
<p style="margin-left: 0.0in;"><strong><u><span style="color: rgb(51,51,51);">&nbsp;</span></u></strong><span style="color: rgb(51,51,51);">&nbsp;</span></p>
