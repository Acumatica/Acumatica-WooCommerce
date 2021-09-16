<p>Status:Completed</p>
<table>
<tbody>
<tr>
<th>Version</th>
<th>Description</th>
<th>Status</th></tr>
<tr>
<td>1.0</td>
<td>Milestone 2</td>
<td>Completed</td></tr></tbody></table>
<h2>WooCommerce configuration settings for Non-Stock Items</h2>
<p>Under Inventory configuration page, following settings should be defined when exporting Non-stock Items and values which are defined in here will be used as default values when syncing<strong><em>.</em></strong></p>

![Screenshot](/Documentation/Specifications/Spec%20Images/NonStock1.png)

<h3>Default Stock Categories</h3>
<p>When exporting Stock items, can define default sales category in here and that value will be picked as the product category when creating a product in WooCommerce.&nbsp;Same field is available in stock item and if any value mentioned in there, Propriety will be given to that value. (B<span style="color: rgb(0,0,0);">efore stock items can be synchronized, sales categories assigned to the item must be synchronized</span>)</p>
<p>&nbsp;</p>
<h3><strong>Default Non-Stock Categories</strong></h3>
<p>When exporting Non-stock items, this value will be picked as the product category when creating a product in WooCommerce.&nbsp;Same field is available in Non-stock item and if any value mentioned in there, Propriety will be given to that value. (B<span style="color: rgb(0,0,0);">efore Non-stock items can be synchronized, sales categories assigned to the item must be synchronized</span>)</p>
<p>&nbsp;</p>
<h3>Default Availability</h3>
<p>Default availability option can be defined here and when exporting Non-stock items, this value will be used as the default Availability of the product.&nbsp;Same field is available in Non-stock item under &quot;Ecommerce&quot; tab and if any value mentioned in there, Propriety will be given to that value.</p>

![Screenshot](/Documentation/Specifications/Spec%20Images/NonStock2.png)

<h3>When Qty Unavailable</h3>
<p>Default value should appear when select &quot;Set as Available (Don't Track Qty)&quot; in Default Availability field.</p>
<p>&nbsp;</p>
<h2>Non-stock items in Acumatica Sales Orders</h2>
<p>&nbsp;</p>
<ul>
<li>When syncing Sales orders, as per stock items, Non-stock item sales orders can be created by using the same procedure.<br /><br /></li>
<li>According to the value which is in &ldquo;Require shipment&rdquo; field in Acumatica Non-stock item card, System will allow user to create the shipment or not.<br /><br /></li>
<li>If Shipment cannot be created, Acumatica user can create the invoice directly.<br /><br /></li>
<li>In that case there will be no Shipment tracking number in Acumatica side.<br /><br /></li>
<li>So, in shipment entity for Non-Stock items, there might be shipments available or there might not be any shipments.<br /><br /></li>
<li>If there are no shipments, when syncing shipment entity, <strong>invoice</strong> can be updated in the shipment sync and by using that, relevant WooCommerce order status can be changed.<br /><br />
  
  ![Screenshot](/Documentation/Specifications/Spec%20Images/NonStock3.png)
  
<h2><strong>Notes</strong></h2>
<p>Acumatica Item Visibility,&nbsp;Item Availability,&nbsp;Item Status and&nbsp;Item Attributes will be worked same as the Stock Item Entity</p>
  
<p>Inventory ID(s) which contains more than one spaces consecutively will not be synced due to the limitation in WooCommerce Products API.</P?


