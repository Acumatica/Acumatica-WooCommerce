***Shipments Export***

<p><span style="color: rgb(0,0,0);">This topic provides reference information about the standard filtering and field mapping used for the&nbsp;</span><em>Shipment</em><span style="color: rgb(0,0,0);">&nbsp;entity during the synchronization between Acumatica ERP and WooCommerce.</span></p>
<p><span style="color: rgb(0,0,0);">&nbsp;</span></p>
<h3 class="wikiH1 separator">Shipment Filtering</h3>
<p><span style="color: rgb(0,0,0);"><span style="color: rgb(0,0,0);">When shipments are exported to WooCommerce (WC), the following conditions are met,</span></span></p>
<ul>
<li>The status of the shipment is&nbsp;<em>Confirmed</em>,&nbsp;<em>Invoiced</em>, or&nbsp;<em>Completed</em>.</li></ul>
<p><span style="color: rgb(0,0,0);">A shipment is skipped if any of the following conditions are met,</span></p>
<ul>
<li class="wikibullet">The sales order related to the shipment has not been synchronized.</li>
<li class="wikibullet">The status of the shipment is <em>Open.</em></li></ul>
<h3 class="wikiH1 separator">Shipment Export Mapping</h3>
<p><span style="color: rgb(0,0,0);"><span style="color: rgb(0,0,0);">&nbsp;</span></span></p>
<table>
<thead>
<tr>
<th colspan="8">Acumatica (Target)</th>
<th colspan="3">WooCommerce (Source)</th></tr></thead>
<tbody>
<tr>
<th>Field Label</th>
<th>Acumatica Path</th>
<th>Mandatory</th>
<th>Column Name</th>
<th>Data Access Class</th>
<th>Table</th>
<th>Framework</th>
<th>Comment</th>
<th>Field Name</th>
<th>Value Example</th>
<th>Description</th></tr>
<tr>
<td>
<p>Notes</p>
<p>(Sales Order (SO301000) form)</p></td>
<td>Sales Order &gt; Order Summary</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>SOOrder</td>
<td>SOOrder</td>
<td><span style="color: rgb(0,0,0);">SalesOrder&gt;</span></td>
<td>If the Tracking Number is available in the Shipment&gt; Packages tab, it should fetch to WC Sales Order <span>as an order note.</span></td>
<td>
<p><span>note</span></p>
<p><span>(Order Notes API)</span></p></td>
<td>&nbsp;</td>
<td><span>Order note content</span></td></tr>
<tr>
<td colspan="1">
<p>Status</p>
<p>(Shipments (SO302000) form)</p></td>
<td colspan="1">Shipment&gt; Shipment Summary</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">Status</td>
<td colspan="1">SOShipment</td>
<td colspan="1">SOShipment</td>
<td colspan="1">SOShipment&gt;</td>
<td colspan="1">If AC Shipment`s status is<em> Confirmed</em>,&nbsp;<em>Invoiced</em>, or&nbsp;<em>Completed</em>.&gt; Complete WC Sales Order</td>
<td colspan="1">
<pre class="highlight json tab-json"><code><span class="nl">status</span></code></pre>
<p>(Orders API)</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span>Order status. Options:&nbsp;</span><code>pending</code><span>,&nbsp;</span><code>processing</code><span>,&nbsp;</span><code>on-hold</code><span>,&nbsp;</span><code>completed</code><span>,&nbsp;</span><code>cancelled</code><span>,&nbsp;</span><code>refunded</code><span>,&nbsp;</span><code>failed</code><span>&nbsp;and&nbsp;</span><code>trash</code><span>. Default is&nbsp;</span><code>pending</code><span>.</span></td></tr></tbody></table>
<p><strong><span style="color: rgb(0,0,0);"><span style="color: rgb(0,0,0);"><br /></span></span></strong></p>
<p><strong><span style="color: rgb(0,0,0);"><span style="color: rgb(0,0,0);">Partial Shipments</span></span></strong></p>
<p><span style="color: rgb(0,0,0);"><span style="color: rgb(0,0,0);">When synchronising the partial shipments, WC`s sales order status will not be updated to &quot;Completed&quot; status. It will remain the WC sales order status as it is.</span></span></p>
<p><span style="color: rgb(0,0,0);"><span style="color: rgb(0,0,0);">Multiple Orders in one shipment are also supported in the synchronisation.</span></span></p>
<p><span style="color: rgb(0,0,0);"><span style="color: rgb(0,0,0);"><br /></span></span></p>
<p><strong><span style="color: rgb(0,0,0);">Back Order (Sales Order) Status</span></strong></p>
<p><span style="color: rgb(0,0,0);">Sales orders with Back Order status is not supported. Once the sales order is updated to a valid status shipment status will synchronise with the WC.</span></p>
