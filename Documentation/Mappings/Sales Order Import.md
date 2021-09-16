***Sales Order Import***
<p>Status: Completed</p>
<table>
<thead>
<tr>
<th>
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">Version</div></div></div></th>
<th>
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">Description</div></div></div></th>
<th colspan="1">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">&nbsp;Status</div></div></div></th></tr></thead>
<tbody>
<tr>
<td>1.0</td>
<td>Milestone 1</td>
<td colspan="1">Completed</td></tr></tbody></table>
<table>
<tbody>
<tr>
<th colspan="8">Acumatica (Target)</th>
<th colspan="3">WooCommerce (Source)</th></tr>
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
<td><span>External Reference</span></td>
<td><span>Sales Order &gt; Order Summary</span></td>
<td>&nbsp;</td>
<td><span>CustomerRefNbr</span></td>
<td><span>SOOrder</span></td>
<td><span>SOOrder</span></td>
<td><span style="color: rgb(0,0,0);">SalesOrder&gt;</span>
<div><span style="color: rgb(0,0,0);">ExternalRef</span></div></td>
<td><span>id+&quot;-&quot;store_name</span></td>
<td>id</td>
<td>&nbsp;</td>
<td>Unique identifier for the resource.READ-ONLY</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>parent_id</td>
<td>&nbsp;</td>
<td>Parent order ID.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>
<p>Not taken to Acumatica</p></td>
<td>number</td>
<td>&nbsp;</td>
<td>Order number.READ-ONLY</td></tr>
<tr>
<td colspan="1">Description</td>
<td colspan="1">Sales Order&gt; Description</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">OrderDesc</td>
<td colspan="1"><span>SOOrder</span></td>
<td colspan="1">SOOrder</td>
<td colspan="1">SalesOrder&gt;
<div>Description</div></td>
<td colspan="1">
<p><span>&quot;store_name&quot; <span>| Order: &quot;id&quot; <span>| <span>Status: &quot;Status&quot;</span></span></span></span></p>
<p>e.g: SWEETSTOREDAN | Order: 150 | Status: Awaiting Payment</p>
<p>Once the description is saved, it will not be updated again automatically.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td><ac:inline-comment-marker ac:ref="b8e9aff0-4ddd-4114-b7ae-0a4a77a090e1">order_key</ac:inline-comment-marker></td>
<td>&nbsp;</td>
<td>Order key.READ-ONLY</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>created_via</td>
<td>&nbsp;</td>
<td>Shows where the order was created.READ-ONLY</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>version</td>
<td>&nbsp;</td>
<td>Version of WooCommerce which last updated the order.READ-ONLY</td></tr>
<tr>
<td>Order Type</td>
<td>Sales Order &gt; Order Summary</td>
<td>Y</td>
<td>OrderType</td>
<td>SOOrder</td>
<td><span>SOOrder</span></td>
<td>SalesOrder&gt;<span>OrderType</span></td>
<td>Defaulted from the WooCommerce Stores&gt; Order Settings tab&gt;Order section&gt; Order Type Import</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td colspan="1">
<p><ac:inline-comment-marker ac:ref="a69d31e0-b652-4134-a6f3-63fd86a376b0">Order Nbr.</ac:inline-comment-marker></p></td>
<td colspan="1"><span>Sales Order &gt; Order Summary</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">OrderNbr</td>
<td colspan="1"><span>SOOrder</span></td>
<td colspan="1"><span>SOOrder</span></td>
<td colspan="1"><span>SalesOrder&gt;OrderNbr</span></td>
<td colspan="1">
<p>The identifier is generated based on the numbering sequence defined for sales orders.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>Status</td>
<td>Sales Order &gt; Order Summary</td>
<td>&nbsp;</td>
<td>Status</td>
<td>SOOrder</td>
<td>SOOrder</td>
<td><span>SalesOrder&gt;<span>Status</span></span></td>
<td>
<p>Import sales orders irrespective of the WC`s Sales Order status. Import filtering can be applied to restrict if any status is not needed.</p>
<p><span>Pending payment, </span><span>Processing, </span><span>On-hold, </span><span>Completed, <span>Failed and trash &gt; Open Status</span></span></p>
<p><span><span><br /></span></span></p>
<p><span><span>Cancelled, Refunded&gt; Cancelled Status.</span></span></p>
<p><span><span>(Refunds will be implemented with the Refunds Entity Import)</span></span></p></td>
<td>status</td>
<td>&nbsp;</td>
<td>
<p><ac:inline-comment-marker ac:ref="471eebd3-296a-4e94-8401-26212c4318ac">Order status.</ac:inline-comment-marker> Options: <br /> <ac:inline-comment-marker ac:ref="540d9824-7e2d-4eaf-9fa2-b572d4f6aa90">Pending</ac:inline-comment-marker>, <br /> Processing, <br /> On-hold, <br /> Completed, <br /> Cancelled, <br /> Refunded, <br /> Failed and trash.</p>
<p>Default is pending.</p></td></tr>
<tr>
<td>Currency</td>
<td>Sales Order &gt; Order Summary</td>
<td>&nbsp;</td>
<td>CuryID</td>
<td>SOOrder</td>
<td><span style="color: rgb(0,0,0);">SOOrder</span></td>
<td><span style="color: rgb(0,0,0);">SalesOrder&gt;</span>
<div><span style="color: rgb(0,0,0);">CurrencyID</span></div></td>
<td>
<p>To use a currency other than the base currency,</p>
<p>currency override must be enabled for the customer (Enable: <ac:inline-comment-marker ac:ref="862f1372-f67a-4ab3-a39d-0d55daacac66">Multi-currency accounting)</ac:inline-comment-marker></p></td>
<td>currency</td>
<td>&nbsp;</td>
<td>Currency the order was created with, in ISO format. Options: AED&hellip;..Default is USD.</td></tr>
<tr>
<td>Project</td>
<td>Sales Order &gt; Order Summary</td>
<td>Y</td>
<td>ProjectID</td>
<td>SOOrder</td>
<td>SOOrder</td>
<td><span style="color: rgb(0,0,0);">SalesOrder&gt;Project</span></td>
<td>Non-project code &quot;X&quot; will default from the <span style="color: rgb(0,0,0);">&nbsp;</span><a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(71))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=de2ca225-4a0c-4129-b09d-3f3ed05198f9">Projects Preferences</a><span style="color: rgb(0,0,0);">&nbsp;(</span><a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=PM101000">PM101000</a><span style="color: rgb(0,0,0);">) form.</span></td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>
<p>&nbsp;</p>
<p><span>date_created_gmt</span></p></td>
<td>&nbsp;</td>
<td>
<p>&nbsp;</p>
<p>The date the order was created, as GMT.</p></td></tr>
<tr>
<td>Date</td>
<td>Sales Order &gt; Order Summary</td>
<td>Y</td>
<td>OrderDate</td>
<td>SOOrder</td>
<td>SOOrder<span style="color: rgb(255,0,0);">&nbsp;</span></td>
<td><span style="color: rgb(0,0,0);">SalesOrder&gt;</span>Date</td>
<td>&nbsp;</td>
<td rowspan="2">date_created</td>
<td rowspan="2">&nbsp;</td>
<td rowspan="2">The date the order was created, in the site's timezone.</td></tr>
<tr>
<td>Requested On</td>
<td>Sales Order &gt; Order Summary</td>
<td>Y</td>
<td>RequestDate</td>
<td>SOOrder</td>
<td>SOOrder<span style="color: rgb(255,0,0);">&nbsp;</span></td>
<td><span style="color: rgb(0,0,0);"><span style="color: rgb(0,0,0);">SalesOrder&gt;</span></span>
<div>RequestedOn</div></td>
<td><span style="color: rgb(0,0,0);">The date when the customer wants to receive the goods</span></td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>date_modified</td>
<td>&nbsp;</td>
<td>The date the order was last modified, in the site's timezone.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>date_modified_gmt</td>
<td>&nbsp;</td>
<td>The date the order was last modified, as GMT.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>discount_total</td>
<td>&nbsp;</td>
<td>Total discount amount for the order.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>discount_tax</td>
<td>&nbsp;</td>
<td>Total discount tax amount for the order.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>shipping_total</td>
<td>&nbsp;</td>
<td>Total shipping amount for the order.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>shipping_tax</td>
<td>&nbsp;</td>
<td>Total shipping tax amount for the order.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>cart_tax</td>
<td>&nbsp;</td>
<td>Sum of line item taxes only.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>total</td>
<td>&nbsp;</td>
<td>Grand total.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>total_tax</td>
<td>&nbsp;</td>
<td>Sum of all taxes.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>prices_include_tax</td>
<td>&nbsp;</td>
<td>True the prices included tax during checkout.</td></tr>
<tr>
<td>Customer</td>
<td>Sales Order &gt; Order Summary</td>
<td>Y</td>
<td>CustomerID</td>
<td>SOOrder</td>
<td>SOOrder</td>
<td><span>Sales Order&gt;<span>CustomerID</span></span></td>
<td>
<p>If an order is a guest order, the customer account selected in the <strong>Generic Guest Customer</strong> box on the <strong>Customer Settings</strong> tab of the WooCommerce Stores form is used.</p></td>
<td>customer_id</td>
<td>&nbsp;</td>
<td>User ID who owns the order. 0 for guests. Default is 0.</td></tr>
<tr>
<td colspan="1">Location</td>
<td colspan="1"><span>Sales Order &gt; Order Summary</span></td>
<td colspan="1">Y</td>
<td colspan="1">CustomerLocationID</td>
<td colspan="1"><span>SOOrder</span></td>
<td colspan="1">
<div>SOOrder</div></td>
<td colspan="1"><span>Sales Order&gt;<span>LocationID</span></span></td>
<td colspan="1">
<p>The primary location is used.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>customer_ip_address</td>
<td>&nbsp;</td>
<td>Customer's IP address.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>customer_user_agent</td>
<td>&nbsp;</td>
<td>User-agent of the customer.</td></tr>
<tr>
<td>Notes</td>
<td>Sales Order &gt; Order Summary</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>SOOrder</span></td>
<td><span>SOOrder</span></td>
<td><span>Sales Order&gt;<span>Note</span></span></td>
<td>
<p>The note should appear in the form title bar.</p>
<p>e.g:</p>
<p>Customer Note: (from customer_note (Order API))</p>
<p>Note to Customer: <span>(when </span><span class="hljs-attr" style="font-family: monospace;">customer_note=</span> <span style="color: rgb(252,194,140);">true </span>(Order Notes API))</p>
<p>Private Note: <span>(<span>when </span><span class="hljs-attr">customer_note=</span><span>&nbsp;</span><span style="color: rgb(252,194,140);">false</span> (Order Notes API))</span></p></td>
<td>
<p>customer_note (from Order &amp; Order Notes API)</p>
<p>&nbsp;</p></td>
<td>&nbsp;</td>
<td>Note left by customer during checkout.</td></tr>
<tr>
<th colspan="10">billing</th>
<th>&nbsp;</th></tr>
<tr>
<td colspan="1">
<p>Override Address</p></td>
<td colspan="1">
<p>Sales Order&gt;Financial Settings tab &gt; Bill-To Address section</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">OverrideAddress</td>
<td colspan="1"><span>SOBillingContact</span></td>
<td colspan="1"><span>SOBillingContact</span></td>
<td colspan="1"><span>Sales Order&gt; BillToContact</span></td>
<td colspan="1">
<p>The check box is selected.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1">
<p>Override Contact</p></td>
<td colspan="1">
<p>Sales Order&gt;Financial Settings tab &gt; Bill-To Contact section</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span>OverrideContact</span></td>
<td colspan="1"><span>SOBillingContact</span></td>
<td colspan="1"><span>SOBillingContact</span></td>
<td colspan="1"><span>Sales Order&gt; BillToContact</span></td>
<td colspan="1">
<p>The check box is selected.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td rowspan="2">Attention</td>
<td rowspan="2">Sales Order&gt;Financial Settings&gt;Bill To Contact section</td>
<td rowspan="2">&nbsp;</td>
<td rowspan="2">Attention</td>
<td rowspan="2"><span>SOBillingContact</span></td>
<td rowspan="2">SOBillingContact</td>
<td rowspan="2">Sales Order&gt; BillToContact</td>
<td rowspan="2">First_name +' '+ Last_name</td>
<td>first_name</td>
<td>John</td>
<td>&nbsp;</td></tr>
<tr>
<td>last_name</td>
<td>Doe</td>
<td>&nbsp;</td></tr>
<tr>
<td>Company Name</td>
<td>Sales Order&gt;Financial Settings&gt;Bill To Contact section</td>
<td>&nbsp;</td>
<td>FullName</td>
<td><span>SOBillingContact</span></td>
<td>SOBillingContact</td>
<td>Sales Order&gt; BillToContact</td>
<td>If the WC`s company name is null, blank should be updated to the Company Name field</td>
<td>company</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>Address Line 1</td>
<td>Sales Order&gt;Financial Settings&gt;Bill To Address section</td>
<td>&nbsp;</td>
<td>AddressLine1</td>
<td><span>SOBillingContact</span></td>
<td>SOBillingAddress</td>
<td>Sales Order&gt; BillToAddress</td>
<td rowspan="6">
<p>One to one mapping to each field and <span>If the WC`s field is null, blank should be updated.</span></p></td>
<td>address_1</td>
<td>969 Market</td>
<td>&nbsp;</td></tr>
<tr>
<td>Address Line 2</td>
<td>Sales Order&gt;Financial Settings&gt;Bill To Address section</td>
<td>&nbsp;</td>
<td>AddressLine2</td>
<td><span>SOBillingContact</span></td>
<td>SOBillingAddress</td>
<td>Sales Order&gt; BillToAddress</td>
<td>address_2</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>City</td>
<td>Sales Order&gt;Financial Settings&gt;Bill To Address section</td>
<td>&nbsp;</td>
<td>City</td>
<td><span>SOBillingContact</span></td>
<td>SOBillingAddress</td>
<td>Sales Order&gt; BillToAddress</td>
<td>city</td>
<td>San Francisco</td>
<td>&nbsp;</td></tr>
<tr>
<td>State</td>
<td>Sales Order&gt;Financial Settings&gt;Bill To Address section</td>
<td>&nbsp;</td>
<td>State</td>
<td><span>SOBillingContact</span></td>
<td>SOBillingAddress</td>
<td>Sales Order&gt; BillToAddress</td>
<td>state</td>
<td>CA</td>
<td>&nbsp;</td></tr>
<tr>
<td>Postal Code</td>
<td>Sales Order&gt;Financial Settings&gt;Bill To Address section</td>
<td>&nbsp;</td>
<td>PostalCode</td>
<td><span>SOBillingContact</span></td>
<td>SOBillingAddress</td>
<td>Sales Order&gt; BillToAddress</td>
<td>postcode</td>
<td>94103</td>
<td>&nbsp;</td></tr>
<tr>
<td>Country</td>
<td>Sales Order&gt;Financial Settings&gt;Bill To Address section</td>
<td>Y</td>
<td>CountryID</td>
<td><span>SOBillingContact</span></td>
<td>SOBillingAddress</td>
<td>Sales Order&gt; BillToAddress</td>
<td>country</td>
<td>US</td>
<td>&nbsp;</td></tr>
<tr>
<td>EMail</td>
<td>Sales Order&gt;Financial Settings&gt;Bill To Contact section</td>
<td>&nbsp;</td>
<td>EMail</td>
<td><span>SOBillingContact</span></td>
<td>SOBillingContact</td>
<td>Sales Order&gt; BillToContact</td>
<td>&nbsp;</td>
<td>email</td>
<td><a href="mailto:john.doe@example.com">john.doe@example.com</a></td>
<td>&nbsp;</td></tr>
<tr>
<td>Business 1</td>
<td>Sales Order&gt;Financial Settings&gt;Bill To Contact section</td>
<td>&nbsp;</td>
<td>Phone1</td>
<td><span>SOBillingContact</span></td>
<td>SOBillingContact</td>
<td>Sales Order&gt; BillToContact</td>
<td>&nbsp;</td>
<td>phone</td>
<td>(555) 555-5555</td>
<td>&nbsp;</td></tr>
<tr>
<th colspan="10">shipping</th>
<th>&nbsp;</th></tr>
<tr>
<td colspan="1">
<p>Override Contact</p></td>
<td colspan="1">
<p>Shipping Settings tab &gt; Ship To Contact section</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">OverrideContact</td>
<td colspan="1"><span>SOShippingContact</span></td>
<td colspan="1"><span>SOShippingContact</span></td>
<td colspan="1"><span>Sales Order&gt; ShipToContact</span></td>
<td colspan="1">
<p>The check box is selected.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1">
<p>Override Address</p></td>
<td colspan="1">
<p>Shipping Settings tab &gt; Ship To Address section</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">OverrideAddress</td>
<td colspan="1"><span>SOShippingContact</span></td>
<td colspan="1"><span>SOShippingContact</span></td>
<td colspan="1"><span>Sales Order&gt; ShipToContact</span></td>
<td colspan="1">
<p>The check box is selected.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td rowspan="2">Attention</td>
<td rowspan="2">Sales Order&gt;Shipping Settings&gt;Ship To Contact section</td>
<td rowspan="2">&nbsp;</td>
<td rowspan="2">Attention</td>
<td rowspan="2"><span>SOShippingContact</span></td>
<td rowspan="2">SOShippingContact</td>
<td rowspan="2">Sales Order&gt; ShipToContact</td>
<td rowspan="2"><span>First_name +' '+ Last_name</span></td>
<td>first_name</td>
<td>John</td>
<td>&nbsp;</td></tr>
<tr>
<td>last_name</td>
<td>Doe</td>
<td>&nbsp;</td></tr>
<tr>
<td>Company Name</td>
<td>Sales Order&gt;Shipping Settings&gt;Ship To Contact section</td>
<td>&nbsp;</td>
<td>FullName</td>
<td><span>SOShippingContact</span></td>
<td>SOShippingContact</td>
<td>Sales Order&gt; ShipToContact</td>
<td><span>If the WC`s company name is null, blank should be updated to the Company Name field</span></td>
<td>company</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>Address Line 1</td>
<td>Sales Order&gt;Shipping Settings&gt;Ship To Address section</td>
<td>&nbsp;</td>
<td>AddressLine1</td>
<td><span>SOShippingContact</span></td>
<td>SOShippingAddress</td>
<td>Sales Order&gt; ShipToAddress</td>
<td rowspan="6"><span>One to one mapping to each field and </span><span>If the WC`s field is null, blank should be updated.</span></td>
<td>address_1</td>
<td>969 Market</td>
<td>&nbsp;</td></tr>
<tr>
<td>Address Line 2</td>
<td>Sales Order&gt;Shipping Settings&gt;Ship To Address section</td>
<td>&nbsp;</td>
<td>AddressLine2</td>
<td><span>SOShippingContact</span></td>
<td>SOShippingAddress</td>
<td>Sales Order&gt; ShipToAddress</td>
<td>address_2</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>City</td>
<td>Sales Order&gt;Shipping Settings&gt;Ship To Address section</td>
<td>&nbsp;</td>
<td>City</td>
<td><span>SOShippingContact</span></td>
<td>SOShippingAddress</td>
<td>Sales Order&gt; ShipToAddress</td>
<td>city</td>
<td>San Francisco</td>
<td>&nbsp;</td></tr>
<tr>
<td>State</td>
<td>Sales Order&gt;Shipping Settings&gt;Ship To Address section</td>
<td>&nbsp;</td>
<td>State</td>
<td><span>SOShippingContact</span></td>
<td>SOShippingAddress</td>
<td>Sales Order&gt; ShipToAddress</td>
<td>state</td>
<td>CA</td>
<td>&nbsp;</td></tr>
<tr>
<td>Postal Code</td>
<td>Sales Order&gt;Shipping Settings&gt;Ship To Address section</td>
<td>&nbsp;</td>
<td>PostalCode</td>
<td><span>SOShippingContact</span></td>
<td>SOShippingAddress</td>
<td>Sales Order&gt; ShipToAddress</td>
<td>postcode</td>
<td>94103</td>
<td>&nbsp;</td></tr>
<tr>
<td>Country</td>
<td>Sales Order&gt;Shipping Settings&gt;Ship To Address section</td>
<td>Y</td>
<td>CountryID</td>
<td><span>SOShippingContact</span></td>
<td>SOShippingAddress</td>
<td>Sales Order&gt; ShipToAddress</td>
<td>country</td>
<td>US</td>
<td>&nbsp;</td></tr>
<tr>
<th>&nbsp;</th>
<th>&nbsp;</th>
<th>&nbsp;</th>
<th>&nbsp;</th>
<th>&nbsp;</th>
<th>&nbsp;</th>
<th>&nbsp;</th>
<th>&nbsp;</th>
<th>&nbsp;</th>
<th>&nbsp;</th>
<th>&nbsp;</th></tr>
<tr>
<td>Payment Method</td>
<td>Sales Order&gt; Financial Settings tab</td>
<td>&nbsp;</td>
<td>PaymentMethodID</td>
<td>SOOrder</td>
<td>SOOrder</td>
<td>
<div>Sales Order&gt; PaymentMethod</div></td>
<td>
<p>WooCommerce Stores&gt;Payment Settings&gt;Payment Method Mapping, need this value to check the payment method mapped.</p>
<p>(Implemented with the 'Payment' Entity)</p></td>
<td>payment_method</td>
<td>&nbsp;</td>
<td>Payment method ID.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>payment_method_title</td>
<td>&nbsp;</td>
<td>Payment method title.</td></tr>
<tr>
<td colspan="1">
<p>Ship Via</p></td>
<td colspan="1">
<p>Sales Order&gt; Shipping Settings tab &gt; Shipping Information section</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">ShipVia</td>
<td colspan="1"><span>SOOrder</span></td>
<td colspan="1">SOOrder</td>
<td colspan="1">Sales Order&gt;
<div>ShipVia</div></td>
<td colspan="1">
<p>The ship via code mapped to the store&rsquo;s shipping method in the <strong>Shipping Zone Mapping</strong> table on the <strong>Order Settings</strong> tab of the WooCommerce Stores form is used.</p>
<p>If the mapping is inactive, default values fetch to the Sales Order will be used.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1">
<p>Shipping Terms</p></td>
<td colspan="1">
<p>Sales Order&gt; Shipping Settings tab &gt; Shipping Information section</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">ShipTermsID</td>
<td colspan="1"><span>SOOrder</span></td>
<td colspan="1">SOOrder</td>
<td colspan="1">ShippingSettings&gt;
<div>ShippingTerms</div></td>
<td colspan="1">
<p>The shipping terms mapped to the store&rsquo;s shipping method in the <strong>Shipping Zone Mapping</strong> table on the <strong>Order Settings</strong> tab of the <span>WooCommerce Stores </span>form are used.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1">
<p>Shipping Zone</p></td>
<td colspan="1">
<p>Sales Order&gt;Shipping Settings tab &gt; Shipping Information section</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">ShipZoneID</td>
<td colspan="1"><span>SOOrder</span></td>
<td colspan="1">SOOrder</td>
<td colspan="1">ShippingSettings&gt;
<div>ShippingZone</div></td>
<td colspan="1">
<p>The shipping zone mapped to the store&rsquo;s shipping method in the <strong>Shipping Zone Mapping</strong> table on the <strong>Order Settings</strong> tab of the <span>WooCommerce Stores </span>form is used.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>Override Freight Price</td>
<td>Sales Order&gt; Totals tab &gt; Freight Info section</td>
<td>&nbsp;</td>
<td>OverrideFreightAmount</td>
<td>SOOrder</td>
<td>SOOrder</td>
<td>Totals&gt;
<div>OverrideFreightAmount</div></td>
<td>This check box is&nbsp;selected if the shipping terms allow freight calculation on orders.</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>Branch</td>
<td>Sales Order&gt; Financial Settings&gt; Financial Information Section</td>
<td>Y</td>
<td>BranchID</td>
<td><span>SOOrder</span></td>
<td><span>SOOrder</span></td>
<td>FinancialSettings&gt;Branch</td>
<td>
<p>The branch specified in the General section on the Order Settings tab of the WooCommerce Stores form is used.</p></td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>transaction_id</td>
<td>&nbsp;</td>
<td>Unique transaction ID.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Will be considered in Payment Entity</td>
<td>date_paid</td>
<td>&nbsp;</td>
<td>The date the order was paid, in the site's timezone.READ-ONLY</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Will be considered in Payment Entity</span></td>
<td>date_paid_gmt</td>
<td>&nbsp;</td>
<td>The date the order was paid, as GMT.READ-ONLY</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>date_completed</td>
<td>&nbsp;</td>
<td>The date the order was completed, in the site's timezone.READ-ONLY</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>date_completed_gmt</td>
<td>&nbsp;</td>
<td>The date the order was completed, as GMT.READ-ONLY</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>cart_hash</td>
<td>&nbsp;</td>
<td>MD5 hash of cart items to ensure orders are not modified.READ-ONLY</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>meta_data</td>
<td>&nbsp;</td>
<td>Meta data. See Order - Meta data properties</td></tr>
<tr>
<th class="highlight-grey" colspan="10" data-highlight-colour="grey">line_items</th>
<th class="highlight-grey" data-highlight-colour="grey">&nbsp;</th></tr>
<tr>
<td colspan="1">Branch</td>
<td colspan="1">Sales Order&gt;
<p>Document Details tab&gt;Branch</p></td>
<td colspan="1">Y</td>
<td colspan="1">BranchID</td>
<td colspan="1">SOLine</td>
<td colspan="1">SOLine</td>
<td colspan="1">SalesOrderDetail&gt;Branch</td>
<td colspan="1">
<p>The branch specified in the <strong>General</strong> section on the <strong>Order Settings</strong> tab of the WooCommerce Stores form is used.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>id</td>
<td>&nbsp;</td>
<td>Item ID.</td></tr>
<tr>
<td>Line Description</td>
<td><span>Sales Order&gt;Document Details</span><span> tab&gt; Line Description</span></td>
<td>&nbsp;</td>
<td>TranDesc</td>
<td>SOLine</td>
<td>SOLine</td>
<td>SalesOrderDetail&gt;LineDescription</td>
<td>&nbsp;</td>
<td>name</td>
<td>&nbsp;</td>
<td>Product name.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>
<p>&nbsp;</p></td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>product_id</td>
<td>&nbsp;</td>
<td>Product ID</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>If variation id exists, it will identify the product as a matrix item</td>
<td><ac:inline-comment-marker ac:ref="a88a1d4c-7ce6-40dc-92fc-b694916f51bd">variation_id</ac:inline-comment-marker></td>
<td>&nbsp;</td>
<td>Variation ID, if applicable.</td></tr>
<tr>
<td>Quantity</td>
<td>Sales Order&gt;Document Details tab&gt; Qunatity</td>
<td>
<p>&nbsp;</p></td>
<td>OrderQty</td>
<td>SOLine</td>
<td>SOLine</td>
<td>SalesOrderDetail&gt;OrderQty</td>
<td>&nbsp;</td>
<td>quantity</td>
<td>&nbsp;</td>
<td>Quantity ordered.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>tax_class</td>
<td>&nbsp;</td>
<td>Slug of the tax class of product.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>subtotal</td>
<td>&nbsp;</td>
<td>Line subtotal (before discounts).</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>subtotal_tax</td>
<td>&nbsp;</td>
<td>Line subtotal tax (before discounts).</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>total</td>
<td>&nbsp;</td>
<td>Line total (after discounts).</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>total_tax</td>
<td>&nbsp;</td>
<td>Line total tax (after discounts).</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>taxes</td>
<td>&nbsp;</td>
<td><a href="https://woocommerce.github.io/woocommerce-rest-api-docs/#order-taxes-properties">Line taxes. See&nbsp;Order - Taxes properties</a></td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Ignored since tax rates in Acumatica appeared in the Tax Details tab</td>
<td>id</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>total</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica, price not taken to AC because when coupon is added price shows the discount deducted price.</span></td>
<td>price</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>meta_data</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td><span>Inventory ID</span></td>
<td><span>Sales Order&gt;Document Details tab&gt; Inventory ID</span></td>
<td><span>Y</span></td>
<td><span>InventoryID</span></td>
<td><span>SOLine</span></td>
<td><span>SOLine</span></td>
<td><span>SalesOrderDetail&gt;InventoryID</span></td>
<td><span>Note: Gift Certificate handling is an extension in WC, therefore, it was not considered in the mapping.</span></td>
<td><ac:inline-comment-marker ac:ref="2318715c-4528-49b7-a4f3-8ce03eb50b81">sku</ac:inline-comment-marker></td>
<td>&nbsp;</td>
<td>Product SKU.</td></tr>
<tr>
<td colspan="1">Manual Price</td>
<td colspan="1"><span>Sales Order&gt;Document Details</span><span> tab&gt; Manual Price</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">ManualPrice</td>
<td colspan="1"><span>SOLine</span></td>
<td colspan="1"><span>SOLine</span></td>
<td colspan="1"><span>SalesOrderDetail&gt;</span></td>
<td colspan="1">The checkbox should be enabled</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>Unit Price</td>
<td><span>Sales Order&gt;Document Details</span><span> tab&gt; Unit Price</span></td>
<td>&nbsp;</td>
<td>CuryUnitPrice</td>
<td>SOLine</td>
<td>SOLine</td>
<td>SalesOrderDetail&gt;<ac:inline-comment-marker ac:ref="f5a8dded-1fa4-4abd-8f91-a627233df9f1">UnitPrice</ac:inline-comment-marker></td>
<td>To get the Unit Price subtotal should be divided by quantity. It will give the price before any coupons applied.</td>
<td>
<pre class=" microlight"><span>subtotal</span></pre></td>
<td>&nbsp;</td>
<td>Product price.</td></tr>
<tr>
<td>Discount Amount</td>
<td>Sales Order&gt; Document Details tab &gt; Discount Amount</td>
<td>&nbsp;</td>
<td>CuryDiscAmt</td>
<td>SOLine</td>
<td>SOLine</td>
<td>SalesOrderDetail&gt;DiscountAmount</td>
<td>Used if discounts are configured to appear on the line level on the Order Settings tab of the WooCommerce Stores form. <br /> <strong>Discount Amount = &ldquo;subtotal&rdquo; &ndash; &ldquo;total&rdquo;</strong></td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<th colspan="10">tax_lines</th>
<th>&nbsp;</th></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>id</td>
<td>&nbsp;</td>
<td>Item ID.</td></tr>
<tr>
<td>Tax ID</td>
<td>Sales Order&gt; Tax Details tab</td>
<td>&nbsp;</td>
<td>TaxID</td>
<td>SOTaxTran</td>
<td>SOTaxTran</td>
<td>TaxDetails&gt; TaxID</td>
<td>
<p>Tax ID should be mapped using the Substitution Lists. However, this will be based on the Taxes Settings used in the WooCommerce Stores <span>(this is handled by the commerce framework),</span>.</p>
<p>Refer: <ac:link><ri:page ri:content-title="Tax Management" /></ac:link></p></td>
<td>rate_code</td>
<td>&nbsp;</td>
<td>Tax rate code.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>rate_id</td>
<td>&nbsp;</td>
<td>Tax rate ID.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>label</td>
<td>&nbsp;</td>
<td>Tax rate label.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>compound</td>
<td>&nbsp;</td>
<td>Show if is a compound tax rate.</td></tr>
<tr>
<td rowspan="2">Tax Amount</td>
<td rowspan="2">Sales Order&gt; Tax Details tab</td>
<td rowspan="2"><br /><br /></td>
<td rowspan="2">CuryTaxAmt</td>
<td rowspan="2">SOTaxTran</td>
<td rowspan="2">SOTaxTran</td>
<td rowspan="3">TaxDetails&gt;TaxAmount<br /><br /><br /></td>
<td rowspan="2"><span>tax_total + <span>shipping_tax_total = Tax Amount</span></span><br /><br /></td>
<td>tax_total</td>
<td>&nbsp;</td>
<td>Tax total (not including shipping taxes).</td></tr>
<tr>
<td>shipping_tax_total</td>
<td>&nbsp;</td>
<td>Shipping tax total.</td></tr>
<tr>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">
<p>Rate percent only available when tax is calculated by WC, when an external tax calculation system is used rate_percent = 0</p>
<p>In that case, calculation should be used,</p>
<pre class=" microlight"><code>(tax_total related to each tax rate in tax_lines /</code></pre>
<pre class=" microlight"><code>taxable amount in each line_items </code>related to each tax rate)</pre>
<pre class=" microlight"><code> </code></pre></td>
<td colspan="1"><ac:inline-comment-marker ac:ref="4a8dde74-44c0-474a-a56a-cfbf3696619c">rate_percent</ac:inline-comment-marker></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>meta_data</td>
<td>&nbsp;</td>
<td>Meta data. See Order - Meta data properties</td></tr>
<tr>
<th colspan="10">shipping_lines</th>
<th>&nbsp;</th></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>id</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>method_title</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>WooCommerce Stores&gt;Order Settings&gt;Shipping Option Mapping, need this value to check &amp; map the shipping basic data to AC</span></td>
<td>method_id</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>
<p>Freight Price</p>
<p>or</p>
<p>Premium Freight Price</p></td>
<td>Sales Order&gt; Totals tab &gt; Freight Info section</td>
<td>&nbsp;</td>
<td>
<p>CuryFreightAmt</p>
<p>or</p>
<p>CuryPremiumFreightAmt</p></td>
<td>SOOrder</td>
<td>SOOrder</td>
<td>
<p>Totals&gt; PremiumFreight</p>
<p>or</p>
<p>Totals&gt; FreightCost</p></td>
<td>
<p>This mapping is used if the shipping terms allow freight calculation on order. Refer to the below logic (this is handled by the commerce framework),</p>
<ul>
<li>Shipping Term available in the Sales Order and Shipping Term (<strong>Invoice Freight Price Based On =&nbsp;<em>Shipment</em><span style="color: rgb(0,0,0);">&nbsp;)</span></strong><span style="color: rgb(0,0,0);">&gt; Freight Amount should be mapped to the &quot; Premium Freight Price&quot;</span></li>
<li>Shipping Term available in the Sales Order and Shipping Term (<strong>Invoice Freight Price Based On =&nbsp;S<em>ales Order</em><span style="color: rgb(0,0,0);">)</span></strong><span style="color: rgb(0,0,0);">&gt; Freight Amount should be mapped to the &quot;Freight Price&quot; (with Override Freight Price)</span></li>
<li><span style="color: rgb(0,0,0);">Shipping Term not available in the Sales Order&gt;&nbsp;Freight Amount should be mapped to the &quot;Freight Price&quot; <span style="color: rgb(0,0,0);">(with Override Freight Price)</span></span></li></ul></td>
<td>total</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>total_tax</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>taxes</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>meta_data</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<th colspan="10">fee_lines</th>
<th>&nbsp;</th></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>id</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>name</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>tax_class</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>tax_status</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>total</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>total_tax</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>taxes</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>meta_data</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<th colspan="10">coupon_lines</th>
<th>&nbsp;</th></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>id</td>
<td>&nbsp;</td>
<td>Item ID.</td></tr>
<tr>
<td colspan="1">
<p>Disable Automatic Discount Update</p></td>
<td colspan="1">Sales Order&gt; Discount Details tab&gt; Disable Automatic Discount Update</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">DisableAutomaticDiscountCalculation</td>
<td colspan="1">SOOrder</td>
<td colspan="1">SOOrder</td>
<td colspan="1">SalesOrder&gt; DisableAutomaticDiscountUpdate</td>
<td colspan="1">&nbsp;
<p>The check box is selected.</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>External Discount Code</td>
<td>Sales Order&gt; Discount Details tab&gt; External Discount Code</td>
<td>&nbsp;</td>
<td>ExtDiscCode</td>
<td>SOOrder</td>
<td>SOOrder</td>
<td>
<div>SalesOrdersDiscountDetails&gt; ExternalDiscountCode</div></td>
<td>&nbsp;</td>
<td>code</td>
<td>&nbsp;</td>
<td>Coupon code.</td></tr>
<tr>
<td>Discount Amt.</td>
<td>Sales Order&gt; Discount Details tab&gt; Discount Amt.</td>
<td>&nbsp;</td>
<td>CuryDiscountAmt</td>
<td>SOOrder</td>
<td>SOOrder</td>
<td>
<div>SalesOrdersDiscountDetails&gt; DiscountAmount</div></td>
<td>If discounts are configured to appear on the <strong>document level</strong> on the Order Settings tab of the WooCommerce Stores form, all product line discounts are displayed on the Discount Details tab <strong>grouped by discount code</strong> (one row per discount code).</td>
<td><span>discount</span></td>
<td>&nbsp;</td>
<td><span>Discount total.</span></td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Not taken to Acumatica</span></td>
<td>discount_tax</td>
<td>&nbsp;</td>
<td>Discount total tax.</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>meta_data</td>
<td>&nbsp;</td>
<td>Meta data. See Order - Meta data properties</td></tr>
<tr>
<th colspan="10">refunds</th>
<th>&nbsp;</th></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>Will be considered in Refunds entity</td>
<td>id</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Will be considered in Refunds entity</span></td>
<td>reason</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Will be considered in Refunds entity</span></td>
<td>total</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td><span>Will be considered in Refunds entity</span></td>
<td>set_paid</td>
<td>&nbsp;</td>
<td>Define if the order is paid. It will set the status to processing and reduce stock items. Default is false.WRITE-ONLY</td></tr></tbody></table>
<p>&nbsp;</p>
<h2>Sales Order Status</h2>
<p><u>WooCommerce Sales Order Status diagram (Reference Purpose Only)</u></p>

![Screenshot](/Documentation/Mappings/Mapping%20Images/SO1.png)

<p>An order s<span>tatus&nbsp;</span>starting with &ldquo;Pending payment&rdquo; and ending with &ldquo;Completed.&rdquo; The following order statuses are used:</p>
<ul>
<li><span>Pending payment</span>&nbsp;&mdash; Order received, no payment initiated. Awaiting payment (unpaid).</li>
<li><span>Failed</span>&nbsp;&mdash; Payment failed or was declined (unpaid) or requires authentication (SCA). Note that this status may not show immediately and instead show as&nbsp;<span>Pending</span>&nbsp;until verified (e.g., PayPal).</li>
<li><span>Processing</span>&nbsp;&mdash; Payment received (paid) and stock has been reduced; order is awaiting fulfillment. All product orders require processing, except those that only contain products which are both&nbsp;<a href="https://docs.woocommerce.com/document/digitaldownloadable-product-handling/">Virtual and Downloadable</a>.</li>
<li><span>Completed</span>&nbsp;&mdash; Order fulfilled and complete &ndash; requires no further action.</li>
<li><span>On hold</span>&nbsp;&mdash; Awaiting payment &ndash; stock is reduced, but you need to confirm payment.</li>
<li><span>Canceled</span>&nbsp;&mdash; Canceled by an admin or the customer &ndash; stock is increased, <ac:inline-comment-marker ac:ref="8b8d7bc6-a65d-47c2-a23d-c16bc279d092">no further action required.</ac:inline-comment-marker></li>
<li><span>Refunded</span>&nbsp;&mdash; Refunded by an admin&nbsp;&ndash; no further action required.</li>
<li><span>Authentication required</span>&nbsp;&mdash; Awaiting action by the customer to authenticate the transaction and/or complete SCA requirements.<br /><br /></li></ul>
<p><u>Acumatica Sales Order Flow&nbsp;(Reference Purpose Only)</u></p>

![Screenshot](/Documentation/Mappings/Mapping%20Images/SO2.png)

<p><strong>Sales Order Import - Order Status</strong></p>
<p>The following status will be applied to the Sales Order when importing WC Sales Orders into AC,</p>

![Screenshot](/Documentation/Mappings/Mapping%20Images/SO3.png)

<p><u><strong>When Sales Order is Trashed by WC Admin</strong></u></p>
<p>If WC admin makes a Sales Order trashed, that sales order should not be sync to AC. However, if the admin trash a sales order which already synced to the AC, since this is a special scenario initiated by WC admin, it is recommended to manually handle this scenario. Therefore, other than syncing the order to the Deleted tab in the Sync History page, nothing should be handled from the AC side when synchronising the order.</p>
<p><u><strong>When Sales Order is Failed by Payment Gateway</strong></u></p>
<p>Sales Order should be filtered&nbsp;from AC in the Sync History screen. And if the sales order processed (sync) again from the&nbsp;Sync History screen, it should be processed as an &quot;Open&quot; status Sales Order in AC, but the Payment should not be synced (since payment is already failed).</p>
<p><u><strong>When Sales Order is Cancelled</strong></u></p>
<p>Sales Order should be filtered&nbsp;from AC in the Sync History screen.&nbsp;And if the sales order processed (sync) again from the&nbsp;Sync History screen, it should be processed as a &quot;Canceled&quot; status Sales Order in AC. but in the Payment, Applied To Order value should be shown as &quot;0&quot;.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
