
<p>Status: Work in Progress</p>
<table>
<tbody>
<tr>
<th>Version</th>
<th>Description</th>
<th>Status</th></tr>
<tr>
<td>1.0</td>
<td>Milestone 2</td>
<td>Work in Progress</td></tr></tbody></table>
<p><ac:structured-macro ac:macro-id="928e781e-c6f5-45f8-aa9b-a7ad69284d26" ac:name="toc" ac:schema-version="1" /></p>
<h1>WooCommerce configuration settings for Availability</h1>

<p>Under Inventory configuration page, following settings should be defined when exporting stock Availability and values which are defined in here will be used as default values when syncing.</p>

![Screenshot](/Specifications/Spec%20Images/Availability1.png) 
![Screenshot](/Specifications/Spec%20Images/Availability2.png)

<h2>Availability Mode</h2>

<li>Available - In the Inventory setup when &quot;Available&quot; is selected, system calculates total quantity in &quot;Available&quot; column in&nbsp;<strong>Inventory Summary (IN401000) </strong> Screen
  
  ![Screenshot](/Specifications/Spec%20Images/Availability3.png)
  
<li>Available for shipping - In the Inventory setup when &quot;Available for shipping&quot; is selected, system&nbsp;calculates total quantity in &quot;Available for Shipment&quot; column in&nbsp;<strong>Inventory Summary (IN401000) </strong> Screen 
  
![Screenshot](/Specifications/Spec%20Images/Availability4.png)
  
<li>On Hand -&nbsp;In the Inventory setup when &quot;On Hand&quot; is selected, system&nbsp;calculates total quantity in &quot;On Hand&quot; column in&nbsp;<strong>Inventory Summary (IN401000) </strong> Screen 
  
 ![Screenshot](/Specifications/Spec%20Images/Availability5.png)
  
<h2>Warehouse Mode</h2>
<p>&nbsp;</p>
<ol>
<li>All Warehouses -&nbsp;In the Inventory setup &quot;All Warehouses&quot; is selected,&nbsp;when picking the value according to the Availability mode, system should show all the warehouse in&nbsp;<strong>Inventory Summary (IN401000)&nbsp;</strong>screen.
  
  ![Screenshot](/Specifications/Spec%20Images/Availability6.png)
  
<li>Specific Warehouses - In the Inventory setup &quot;Specific Warehouses&quot; is selected, when picking the value according to the Availability mode, system should take the values according to the warehouses filled in Inventory settings<br /><br />
  
  ![Screenshot](/Specifications/Spec%20Images/Availability7.png)
  ![Screenshot](/Specifications/Spec%20Images/Availability8.png)
  
<p><em><strong>Value pick from any of the above-mentioned fields should be updated in WooCommerce Products API &ldquo;stock_quantity&rdquo; field. In Order to do that WooCommerce &ldquo;manage_stock&rdquo; Boolean should be = true. This is applicable for WooCommerce products variations also.</strong></em></p>

  ![Screenshot](/Specifications/Spec%20Images/Availability9.png)
  
  ![Screenshot](/Specifications/Spec%20Images/Availability10.png)
  
<h1><br /><br />Available Qty Calculation</h1>
<p>Available Qty Value Calculation will depend on,</p>
<ul>
<li>
<p>Availability setting of Item from ecommerce tab&nbsp;<br /><br />Depend on the value selected in this field, when syncing availability, particular WooCommerce item following fields should get updated as below.<br /><br /></p>
<table>
<tbody>
<tr>
<td class="highlight-grey" data-highlight-colour="grey" style="text-align: center;">Acumatica</td>
<td class="highlight-grey" colspan="3" data-highlight-colour="grey" style="text-align: center;">WooCommerce</td></tr>
<tr>
<td class="highlight-grey" data-highlight-colour="grey">Availability</td>
<td class="highlight-grey" data-highlight-colour="grey">manage stock</td>
<td class="highlight-grey" data-highlight-colour="grey">Stock Status</td>
<td class="highlight-grey" colspan="1" data-highlight-colour="grey">Stock quantity field get update</td></tr>
<tr>
<td>Set as Available (Track Qty)</td>
<td>Yes</td>
<td>-</td>
<td colspan="1">Yes</td></tr>
<tr>
<td>Set as Available (Don&rsquo;t Track Qty)</td>
<td>No</td>
<td>In Stock</td>
<td colspan="1">No</td></tr>
<tr>
<td>Do Not Update</td>
<td>No</td>
<td>In Stock</td>
<td colspan="1">No</td></tr>
<tr>
<td>Set as Unavailable</td>
<td>No</td>
<td>Out of Stock</td>
<td colspan="1">No</td></tr></tbody></table></li></ul>
<ul>
<li>Qty Unavailable setting of Item from ecommerce tab</li></ul>
<p><br />If Availability = &quot;Set As Available - Track Qty&quot; after calculating the Availability and if there is no stock available in the inventory, following mapping should consider.<br /><br /></p>
<table>
<tbody>
<tr>
<td class="highlight-grey" data-highlight-colour="grey" style="text-align: center;">Acumatica</td>
<td class="highlight-grey" data-highlight-colour="grey" style="text-align: center;">WooCommerce</td></tr>
<tr>
<td class="highlight-grey" data-highlight-colour="grey">When Qty Unavailable</td>
<td class="highlight-grey" data-highlight-colour="grey"><span>Stock quantity field get update</span></td></tr>
<tr>
<td>Do Nothing</td>
<td><span>-</span></td></tr>
<tr>
<td>Set as Disabled</td>
<td><span>Yes (as 0 - Out of Stock)</span></td></tr></tbody></table>
<p>&nbsp;</p>
<ul>
<li>Status of Item<br /><br />If Item status = inactive, not for sale or marked for deletion, those items availability should be disabled.&nbsp;<br /><br /><br />
