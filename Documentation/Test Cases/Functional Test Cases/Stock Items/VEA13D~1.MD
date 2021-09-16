
<p><strong><u>Description</u></strong></p>
<p>application set the default configuration for Visibility when the visibility = 'Store Default' in the product level</p>
<p><strong><u>Prerequisites</u></strong></p>
<p>1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</p>
<p><strong><u>Detailed Steps to Test</u></strong></p>
<p>1. Create a Stock item by filling all the mandatory fields<br />2. Set the Availability =&nbsp;<strong>&lt;pAvailability&gt;</strong><br />3. Go to the Inventory Settings and set the visibility configuration;&nbsp;<strong>&lt;pAvailabilityDefault&gt;</strong><br />WooCommerce Store &gt; Inventory Setting<br />3. Save the record, Prepare and Process<br />4. Open the record in WooCommerce and validate the Availability in the WC product level</p>
<table>
<tbody>
<tr>
<td rowspan="2" style="text-align: center;"><strong>&lt;Availability&gt;</strong></td>
<td rowspan="2" style="text-align: center;"><strong>&lt;pAvailabilityDefault&gt;</strong></td>
<td colspan="2" style="text-align: center;"><strong>Expected Results</strong></td></tr>
<tr>
<td style="text-align: center;"><strong>&lt;pManage_stock&gt;</strong></td>
<td style="text-align: center;"><strong>&lt;pStock Status&gt;</strong></td></tr>
<tr>
<td rowspan="5">Store Default</td>
<td>Set as Available (Track Qty)</td>
<td>Yes</td>
<td>-</td></tr>
<tr>
<td>Set as Available (Don&rsquo;t Track Qty)</td>
<td>No</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Pre-Order</td>
<td>No</td>
<td>On Backorder</td></tr>
<tr>
<td>Do Not Update</td>
<td>No</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Unavailable</td>
<td>No</td>
<td>Out of Stock</td></tr></tbody></table>
<p><strong><u>Expected Results</u></strong></p>
<p>&nbsp;The visibility should be created as&nbsp;<strong>&lt;pAvaiabilityDefault&gt;</strong>&nbsp;inside the WC product</p>
<p><strong><u>Test Data</u></strong></p>
<p>&nbsp;<strong>&lt;pAvailability&gt;</strong>&nbsp;Store Default<br /><strong>&lt;pAvailabilityDefault&gt;</strong>&nbsp;= Visible</p>
