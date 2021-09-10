
<p><strong><u>Description</u></strong></p>
<p>&nbsp;Manage Stock Boolean = False upon exporting a stock item with the Availability is &quot;Don&rsquo;t Track Qty)&quot;&nbsp;</p>
<p><strong><u>Prerequisites</u></strong></p>
<p>1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</p>
<p><strong><u>Detailed Steps to Test</u></strong></p>
<p>1. Create a Non-Stock item by filling all the mandatory fields<br />2. Availability&quot; = Available (Don&rsquo;t Track Qty)&quot;<strong>&nbsp;&lt;pAvailability&gt;</strong><br />3. Save the record, Prepare and Process<br />4. Open the record in WooCommerce and validate the validate Manage Stock Boolean value and the Manage Stock Boolean value</p>
<table>
<tbody>
<tr>
<td><strong>&lt;pAvailability&gt;</strong></td>
<td><strong>&lt;pManage_stock&gt;</strong></td>
<td><strong>&lt;pStock Status&gt;</strong></td></tr>
<tr>
<td><s>Set as Available (Track Qty)</s></td>
<td><s>Yes</s></td>
<td><s>-</s></td></tr>
<tr>
<td>Set as Available (Don&rsquo;t Track Qty)</td>
<td>No</td>
<td>In Stock</td></tr>
<tr>
<td><s>Set as Pre-Order</s></td>
<td><s>No</s></td>
<td><s>On Backorder</s></td></tr>
<tr>
<td>Do Not Update</td>
<td>No</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Unavailable</td>
<td>No</td>
<td>Out of Stock</td></tr></tbody></table>
<p>&nbsp;</p>
<p><strong><u>Expected Results</u></strong></p>
<p>The Manage stock Boolean should be 'False'</p>
<p><strong><u>Test Data</u></strong></p>
<p><strong>&lt;pManageStock&gt;</strong></p>
<p><strong>&lt;pStockStatus&gt;</strong></p>
<p><strong><strong>&lt;pAvailability&gt;</strong></strong></p>
