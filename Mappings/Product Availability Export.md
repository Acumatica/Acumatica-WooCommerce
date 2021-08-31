
<p>Status: Work in Progress</p>
<table>
<thead>
<tr>
<th>
<div class="tablesorter-header-inner">Version</div></th>
<th>
<div class="tablesorter-header-inner">Description</div></th>
<th>
<div class="tablesorter-header-inner">Status</div></th></tr></thead>
<tbody>
<tr>
<td>1.0</td>
<td>Draft (Milestone 2)</td>
<td>Work in Progress</td></tr></tbody></table>
<p>&nbsp;</p>
<p>This document maps the Product Availability fields to WooCommerce.</p>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<th colspan="3" style="text-align: center;"><strong><span style="color: rgb(0,0,0);"><strong><span style="color: rgb(0,0,0);">Acumatica (</span></strong>Source)</span></strong></th>
<th style="text-align: center;"><strong><span style="color: rgb(0,0,0);">WooCommerce (Target)</span></strong></th>
<th>&nbsp;</th></tr>
<tr>
<th><strong><span style="color: rgb(0,0,0);">Field Name</span></strong></th>
<th><strong><span style="color: rgb(0,0,0);">Field Options</span></strong></th>
<th><strong><span style="color: rgb(0,0,0);">Acumatica Path</span></strong></th>
<th><strong><span style="color: rgb(0,0,0);">Field Name</span></strong></th>
<th><strong><span style="color: rgb(0,0,0);">Rules and Requirements</span></strong></th></tr>
<tr>
<td colspan="3"><strong>Stores Screen</strong></td>
<td>&nbsp;</td>
<td><em><strong>WooCommerce &ldquo;manage_stock&rdquo; Boolean should be = true</strong></em></td></tr>
<tr>
<td>Availability Mode</td>
<td>Possible Options:<br />- Available<br />- Available for Shipping<br />- On Hand</td>
<td>Stores &gt; Inventory Settings</td>
<td><span>stock_quantity</span></td>
<td>
<p>Value will depend on the Stores settings<br />Stores -&gt; Inventory Settings -&gt; Availability Mode</p>
<p>Use the setting to identify which Qty to pickup.</p></td></tr>
<tr>
<td colspan="1">Warehouse Mode</td>
<td colspan="1">
<p>Possible Options:<br />- Specific <span>Warehouses </span><br />- All <span>Warehouses </span></p></td>
<td colspan="1">Stores &gt; Inventory Settings</td>
<td colspan="1"><span>stock_quantity</span></td>
<td colspan="1">
<p>Use setting to identify the warehouse for inventory calculations:<br />- Specific - will use only one location for inventory calculations<br />- All - will use all locations and sum for total inventory</p></td></tr>
<tr>
<td colspan="3"><strong>Stock Item Screen and Non-Stock Item Screen</strong></td>
<td colspan="2">&nbsp;</td></tr>
<tr>
<td>Inventory ID</td>
<td>Inventory_id</td>
<td>Stock Item Summary</td>
<td><span>sku</span></td>
<td>To identify which record to be updated.</td></tr>
<tr>
<td>
<p>Stock Item</p></td>
<td>
<p><span style="color: rgb(0,0,0);">General Settings Tab --&gt; Warehouse Defaults</span></p></td>
<td>Product</td>
<td><em>manage_stock</em></td>
<td><em>manage_stock = </em>true</td></tr>
<tr>
<td colspan="1">Non-Stock Item</td>
<td colspan="1">
<p>General Settings Tab -&gt; Item Defaults</p></td>
<td colspan="1">Product</td>
<td colspan="1"><em>manage_stock</em></td>
<td colspan="1"><em>manage_stock = </em>False</td></tr>
<tr>
<td colspan="5"><strong>Inventory Level</strong></td></tr>
<tr>
<td>Availability</td>
<td>
<p>Possible Options:</p>
<ul>
<li>Store Default</li>
<li>Available - Track Qty</li>
<li>Available - Don't track Qty</li>
<li>Pre-order</li>
<li>Disabled</li></ul></td>
<td>eCommerce Tab&nbsp;&nbsp;</td>
<td>&nbsp;</td>
<td>
<p>Value depends on:<br />- Availability setting of Item from ecommerce tab<br />- When Qty Unavailable setting of Item from ecommerce tab<br />- Status of Item (if Item is inactive, not for sale or marked for deletion, availability is disabled)<br />{<ac:link><ri:page ri:content-title="Product Availability Entity" /><ac:plain-text-link-body><![CDATA[Available Qty Value Calculation]]></ac:plain-text-link-body></ac:link>}</p></td></tr>
<tr>
<td colspan="1">Qty on Hand</td>
<td colspan="1">
<p>&nbsp;</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span>stock_quantity</span></td>
<td colspan="1">The QtyonHand will depend on settings**</td></tr></tbody></table>
<p>&nbsp;</p>
<p>** If the Warehouse Mode in Stores is set to <span>All </span><span>Warehouses </span>, System should calculate the sum of QtyOnHand (depending on settings in Available mode) of all warehouses and put it in the <span>stock_quantity&nbsp;</span>field in the Inventory Level.<br /><br /></p>
<p>** If the Warehouse Mode is Stores is set to <span>Specific </span><span>Warehouses</span>, System should identify the warehouse(s) to select the QtyOnHand and combine those to the stock_quantity field in the Inventory Level.</p>
<p>&nbsp;</p>
<p><em><strong>In the case of Non-Stock items, the manage_stock&nbsp;will be set to False and would not require populating the Inventory Level. There is no inventory available.</strong></em></p>
<p>&nbsp;</p>
