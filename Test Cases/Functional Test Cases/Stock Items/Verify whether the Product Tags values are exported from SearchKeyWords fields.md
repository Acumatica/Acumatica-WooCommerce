
<p><strong><u>Description</u></strong></p>
<p>Product Tags values are exported from 'SearchKeyWords' fields</p>
<p><strong><u>Prerequisites</u></strong></p>
<p>1. User has access to the ERP application<br /> 2. WooCommerce Connector is configured<br /> 3. User has opened the Stock Items page in Acumatica</p>
<p><strong><u>Detailed Steps to Test</u></strong></p>
<p>1. Create a Stock item by filling all the mandatory fields<br />2. Set the Visibility =&nbsp;<strong>&lt;pVisibility&gt;</strong><br />3. Go to the Inventory Settings and set the visibility configuration;&nbsp;<strong>&lt;pVisibilityDefault&gt;</strong><br />WooCommerce Store &gt; Inventory Setting<br />3. Save the record, Prepare and Process<br />4. Open the record in WooCommerce and validate the visibility in the WC product level</p>
<table>
<tbody>
<tr>
<td><strong>&lt;pVisibility&gt;</strong></td>
<td><strong>&lt;pVisibilityDefault&gt;</strong></td>
<td><strong>Expected Results</strong></td></tr>
<tr>
<td rowspan="3">Store Default</td>
<td>Visible</td>
<td>Shop and search results</td></tr>
<tr>
<td>Featured</td>
<td>Shop and search results AND Featured Boolean = True</td></tr>
<tr>
<td>Invisible</td>
<td>Hidden</td></tr></tbody></table>
<p><strong><u>Expected Results</u></strong></p>
<p>The visibility should be created as&nbsp;<strong>&lt;pVisibilityDefault&gt;</strong>&nbsp;inside the WC product</p>
<p><strong><u>Test Data</u></strong></p>
<p>&nbsp;<strong>&lt;pVisibility&gt;</strong>&nbsp;Store Default<br /><strong>&lt;pVisibilityDefault&gt;</strong>&nbsp;= Visible</p>
