
<p>Status: Completed</p>
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
<p>&nbsp;</p>
<p>Template Item sync will be same as Stock Item Entity and Non-Stock Item Entity item synchronization. System will use the same inventory settings when syncing and additionally will consider below mention conditions,</p>
<ul>
<li>WooCommerce &ldquo;Product Data Type&rdquo; always should be equal to &ldquo;variable Product&rdquo;</li>
<li>WooCommerce &ldquo;SKU&rdquo; should be same value in &ldquo;Template ID&rdquo; in Acumatica</li>
<li>WooCommerce Attributes should create with &ldquo;Used for variations&rdquo; Boolean true.</li></ul>
<h2>Acumatica Template Item Attributes,</h2>
<p>Template item Attributes can be accessed through Configuration tab in Acumatica Template item. Those are the attributes that can be used for WooCommerce variable products when syncing the Template item.</p>
<p>Template Item Attribute values can be access through Item creation tab in Acumatica and those can be used as Attribute values in WooCommerce for relevant attribute.</p>
<p>&nbsp;</p>
<h2>Creating Variations in WooCommerce</h2>
<p>When creating variants in WooCommerce, values to the dropdowns (Attribute values) should select by mapping the attributes in WooCommerce with the Attributes in Acumatica and pick the value for that mapped attribute.</p>
<p>This mapping can be access through Matrix Items in Template item.</p>

![Screenshot](/Specifications/Spec%20Images/Template1.png)

![Screenshot](/Specifications/Spec%20Images/Template2.png)

<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</p>
<p>Note : Inventory ID(s) which contains more than one spaces consecutively will not be synced due to the limitation in WooCommerce Products API.</p>
