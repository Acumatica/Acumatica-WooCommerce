***Stock Items Export***
<p>Status: Completed</p>
<table>
<tbody>
<tr>
<th>Version</th>
<th>Description</th>
<th>Status</th></tr>
<tr>
<td>1.0</td>
<td>Completed</td>
<td>Completed</td></tr></tbody></table>
<p><ac:structured-macro ac:macro-id="f81e2ff3-b26c-4c5e-9db8-14176338fa5d" ac:name="toc" ac:schema-version="1" /></p>
<h2>WooCommerce configuration settings for Stock Items</h2>
<p>Under Inventory configuration page, following settings should be defined when exporting Stock Items and values which are defined in here will be used as default values when syncing.<strong><em> <u>These are the default setting that need for Milestone 1</u>.</em></strong></p>

![Screenshot](/Specifications/Spec%20Images/Stock1.png)

<h3>Default Stock Categories</h3>
<p>When exporting Stock items, can define default sales category in here and that value will be picked as the product category when creating a product in WooCommerce.&nbsp;Same field is available in stock item and if any value mentioned in there, Propriety will be given to that value. (B<span style="color: rgb(0,0,0);">efore stock items can be synchronized, sales categories assigned to the item must be synchronized</span>)</p>
<p>&nbsp;</p>
<h3>Default Non-Stock Categories</h3>
<p>When exporting Non-stock items, this value will be picked as the product category when creating a product in WooCommerce.&nbsp; 
 <a href="https://github.com/Acumatica/Acumatica-WooCommerce/blob/main/Specifications/Non-Stock%20Items.md"> Non-Stock Items Setup in WooCommerce</a></p>
<h3>Default Availability</h3>
<p>Default availability option can be defined here and when exporting stock items, this value will be used as the default Availability of the product.&nbsp;Same field is available in stock item under &quot;Ecommerce&quot; tab and if any value mentioned in there, Propriety will be given to that value.</p>
<p>&nbsp;</p>

![Screenshot](/Specifications/Spec%20Images/Stock2.png)

<h3>When Qty Unavailable</h3>
<p>Default value should appear when select &quot;Set as Available (Don't Track Qty)&quot; in Default Availability field.</p>
<p>&nbsp;</p>
<h2>Acumatica Item Availability in WooCommerce</h2>
<p>Product Availability functionality will be used as mentioned below,&nbsp;</p>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<td class="highlight-grey" data-highlight-colour="grey" style="text-align: center;">Acumatica</td>
<td class="highlight-grey" colspan="2" data-highlight-colour="grey" style="text-align: center;">WooCommerce</td></tr>
<tr>
<td class="highlight-grey" data-highlight-colour="grey">Availability</td>
<td class="highlight-grey" data-highlight-colour="grey">manage stock</td>
<td class="highlight-grey" data-highlight-colour="grey">Stock Status</td></tr>
<tr>
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
<p>&nbsp;</p>
<h2>Acumatica Item Visibility in WooCommerce</h2>
<p>Visibility of the product will be handled as below.&nbsp;</p>
<table>
<tbody>
<tr>
<td class="highlight-grey" data-highlight-colour="grey" style="text-align: center;">Acumatica</td>
<td class="highlight-grey" data-highlight-colour="grey" style="text-align: center;">WooCommerce</td></tr>
<tr>
<td class="highlight-grey" data-highlight-colour="grey" style="text-align: left;">Visibility&nbsp;</td>
<td class="highlight-grey" data-highlight-colour="grey" style="text-align: left;">Catalog Visibility</td></tr>
<tr>
<td>Visible</td>
<td>Shop and search results</td></tr>
<tr>
<td>Featured</td>
<td>This is a featured product</td></tr>
<tr>
<td>Invisible</td>
<td>Hidden</td></tr></tbody></table>
<h2>Acumatica Item Availability Vs Item Visibility Vs Item Status in WooCommerce</h2>
<table>
<tbody>
<tr>
<td class="highlight-grey" colspan="3" data-highlight-colour="grey" style="text-align: center;">Acumatica</td>
<td class="highlight-grey" colspan="5" data-highlight-colour="grey" style="text-align: center;">WooCommerce</td></tr>
<tr>
<td class="highlight-grey" data-highlight-colour="grey">Status</td>
<td class="highlight-grey" data-highlight-colour="grey">Visibility&nbsp;</td>
<td class="highlight-grey" data-highlight-colour="grey">Availability</td>
<td class="highlight-grey" data-highlight-colour="grey">Status</td>
<td class="highlight-grey" data-highlight-colour="grey">Catalog Visibility</td>
<td class="highlight-grey" data-highlight-colour="grey">Featured Product</td>
<td class="highlight-grey" data-highlight-colour="grey">manage stock</td>
<td class="highlight-grey" data-highlight-colour="grey">Stock Status</td></tr>
<tr>
<td rowspan="10">Active</td>
<td rowspan="5">Visible</td>
<td>Set as Available (Track Qty)</td>
<td>Published</td>
<td>Shop and search results</td>
<td>No</td>
<td>Yes</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Available (Don&rsquo;t Track Qty)</td>
<td>Published</td>
<td>Shop and search results</td>
<td>No</td>
<td>No</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Pre-Order</td>
<td>Published</td>
<td>Shop and search results</td>
<td>No</td>
<td>No</td>
<td>On Backorder</td></tr>
<tr>
<td>Do Not Update</td>
<td>Published</td>
<td>Shop and search results</td>
<td>No</td>
<td>N/A</td>
<td>N/A</td></tr>
<tr>
<td>Set as Unavailable</td>
<td>Published</td>
<td>Hidden</td>
<td>No</td>
<td>No</td>
<td>Out of Stock</td></tr>
<tr>
<td rowspan="5">Featured</td>
<td>Set as Available (Track Qty)</td>
<td>Published</td>
<td>Shop and search results</td>
<td>Yes</td>
<td>Yes</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Available (Don&rsquo;t Track Qty)</td>
<td>Published</td>
<td>Shop and search results</td>
<td>Yes</td>
<td>No</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Pre-Order</td>
<td>Published</td>
<td>Shop and search results</td>
<td>Yes</td>
<td>No</td>
<td>On Backorder</td></tr>
<tr>
<td>Do Not Update</td>
<td>Published</td>
<td>Shop and search results</td>
<td>Yes</td>
<td>N/A</td>
<td>N/A</td></tr>
<tr>
<td>Set as Unavailable</td>
<td>Published</td>
<td>Hidden</td>
<td>Yes</td>
<td>No</td>
<td>Out of Stock</td></tr>
<tr>
<td class="highlight-grey" colspan="3" data-highlight-colour="grey">&nbsp;</td>
<td class="highlight-grey" colspan="3" data-highlight-colour="grey">&nbsp;</td>
<td class="highlight-grey" colspan="2" data-highlight-colour="grey">&nbsp;</td></tr>
<tr>
<td rowspan="10">
<p>Inactive/No Sales/Marked for Deletion/</p>
<p><span>No Purchase/No Request</span></p></td>
<td rowspan="5">Visible</td>
<td>Set as Available (Track Qty)</td>
<td>Draft</td>
<td>Shop and search results</td>
<td>No</td>
<td>Yes</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Available (Don&rsquo;t Track Qty)</td>
<td>Draft</td>
<td>Shop and search results</td>
<td>No</td>
<td>No</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Pre-Order</td>
<td>Draft</td>
<td>Shop and search results</td>
<td>No</td>
<td>No</td>
<td>On Backorder</td></tr>
<tr>
<td>Do Not Update</td>
<td>Draft</td>
<td>Shop and search results</td>
<td>No</td>
<td>N/A</td>
<td>N/A</td></tr>
<tr>
<td>Set as Unavailable</td>
<td>Draft</td>
<td>Hidden</td>
<td>No</td>
<td>No</td>
<td>Out of Stock</td></tr>
<tr>
<td rowspan="5">Featured</td>
<td>Set as Available (Track Qty)</td>
<td>Draft</td>
<td>Shop and search results</td>
<td>Yes</td>
<td>Yes</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Available (Don&rsquo;t Track Qty)</td>
<td>Draft</td>
<td>Shop and search results</td>
<td>Yes</td>
<td>No</td>
<td>In Stock</td></tr>
<tr>
<td>Set as Pre-Order</td>
<td>Draft</td>
<td>Shop and search results</td>
<td>Yes</td>
<td>No</td>
<td>On Backorder</td></tr>
<tr>
<td>Do Not Update</td>
<td>Draft</td>
<td>Shop and search results</td>
<td>Yes</td>
<td>N/A</td>
<td>N/A</td></tr>
<tr>
<td>Set as Unavailable</td>
<td>Draft</td>
<td>Hidden</td>
<td>Yes</td>
<td>No</td>
<td>Out of Stock</td></tr></tbody></table>
<p>&nbsp;</p>
<h2>Acumatica Item Attributes in WooCommerce</h2>
<p>When syncing stock items, attributes which are assigned in the Acumatica Stock item (Local Attributes- Attribute ID and Value) will be exported with the product. Those attributes will be displayed under &quot;Attributes&quot; tab in the WooCommerce product.</p>
<table>
<tbody>
<tr>
<td class="highlight-grey" data-highlight-colour="grey">Acumatica</td>
<td class="highlight-grey" data-highlight-colour="grey">WooCommerce</td></tr>
<tr>
<td>Attributes</td>
<td>&nbsp;</td></tr>
<tr>
<td>Attribute ID</td>
<td>Name</td></tr>
<tr>
<td>Value Description</td>
<td>Value(s)</td></tr></tbody></table>

![Screenshot](/Specifications/Spec%20Images/Stock3.png)

<p>&nbsp;</p>

