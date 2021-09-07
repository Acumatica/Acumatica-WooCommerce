***Sales Category Export***
<p>Status: completed</p>
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

<p>During the synchronization of the Sales Category entity, sales category in the Acumatica is merged with an existing Product category in WooCommerce if the Name of the product category in WooCommerce matches the Description of the item sales category in Acumatica.</p>
<p><br />Before the initial syncing of Stock items/ Non-stock items or Template items, sales category entity should be synced. When new sales category created in Acumatica and if that category is assigned in a Stock/ Non-Stock item, just before syncing the items, Sale category entity sync should be completed. Otherwise in WooCommerce, that item's product category will be identified as &ldquo;Uncategorized&rdquo;</p>

![Screenshot](/Specifications/Spec%20Images/Sales%20Category1.png)


![Screenshot](/Specifications/Spec%20Images/Sales%20Category2.png)
  
![Screenshot](/Specifications/Spec%20Images/Sales%20Category3.png)

