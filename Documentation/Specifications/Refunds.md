
<h2>WooCommerce Refunds Features &amp; Process</h2>
<p><a href="https://docs.woocommerce.com/document/woocommerce-refunds/">https://docs.woocommerce.com/document/woocommerce-refunds/</a></p>
<h4>Note</h4>
<p>The CC related transaction cannot be partially refunded until it is settled in the payment gateway (Authrized.net).</p>

![Screenshot](/Documentation/Specifications/Spec%20Images/Refund1.png)

<p>&nbsp;</p>
<p>This process is where the Admin creates the refund through a series of steps in the Refund Process.</p>
<ol>
<li>The Admin chooses the Refund Type:&nbsp;
<ol>
<li>Refund individual items (item-specific) - Full Refund Item</li>
<li>Refund individual items (item-specific) - Partial Refund Item</li>
<li>Refund entire order</li></ol></li>
<li>Admin specifies the items to be refunded and <strong>shipping amount</strong>&nbsp;accordingly.</li>
<li>Admin selects the refund payment option:
<ol>
<li><strong>Automatic</strong> - Process through WC and Payment Gateway</li>
<li><strong>Manual</strong> - Merchant&nbsp;<span>needs to return the money manually to your customer&nbsp;</span></li></ol></li></ol>
<p>&nbsp;</p>
<h2>Refunds Transaction Scenarios in WC</h2>
<ol>
<li><strong>Item Return</strong></li></ol>
<ul>
<li>Without Quantity</li></ul>

![Screenshot](/Documentation/Specifications/Spec%20Images/Refund2.png)

<p style="margin-left: 30.0px;">Data appeared on Refunds API - without quantity</p>

<table>
<tbody>
<tr>
<th style="margin-left: 30.0px;">Quantity</th>
<th style="margin-left: 30.0px;">Taxes</th></tr>
<tr style="margin-left: 30.0px;">
<td colspan="1" style="margin-left: 30.0px;">
  
![Screenshot](/Documentation/Specifications/Spec%20Images/Refund3.png) </td>
  
<td colspan="1" style="margin-left: 30.0px;">
 
![Screenshot](/Documentation/Specifications/Spec%20Images/Refund4.png)
 
  </td></tr></tbody></table>
<p>&nbsp;</p>
<ul>
<li>With Quantity</li></ul>
<p>

![Screenshot](/Documentation/Specifications/Spec%20Images/Refund5.png)

</p>
<p style="margin-left: 30.0px;">Data appeared on Refunds API - with quantity</p>
<table>
<tbody>
<tr>
<th>Quantity</th>
<th>Taxes</th></tr>
<tr>
<td colspan="1">
 
 ![Screenshot](/Documentation/Specifications/Spec%20Images/Refund6.png)
  
 </td>
<td colspan="1"><ac:image ac:height="250">
  
![Screenshot](/Documentation/Specifications/Spec%20Images/Refund7.png)
  
  </td></tr></tbody></table>
<p style="margin-left: 30.0px;"><strong>2. Shipping Charge Return</strong></p>

 ![Screenshot](/Documentation/Specifications/Spec%20Images/Refund8.png)

<p style="margin-left: 30.0px;">Data appeared on Refunds API - with shipping charge and shipping tax</p>
<table>
<tbody>
<tr>
<th>Shipping Charge</th>
<th>Shipping Tax</th></tr>
<tr>
<td>
  
![Screenshot](/Documentation/Specifications/Spec%20Images/Refund9.png) 
  
 </td>
<td>
  
![Screenshot](/Documentation/Specifications/Spec%20Images/Refund10.png)
  
  </td></tr></tbody></table>
<p style="margin-left: 30.0px;"><strong>3. Discounts Return</strong></p>
<p style="margin-left: 30.0px;">In the below example, Unit Price $ 45.15, after the discount unit price is $35.15. But in WC, we can refund an amount that is more than the unit price amount ($ 50 were returned per unit).</p>

<p>
  
![Screenshot](/Documentation/Specifications/Spec%20Images/Refund11.png)

</p>
<p>&nbsp;</p>
<p>Data appeared on Refunds API - There is not tag for discounts, just only the refunded amounts will appear.</p>
<table>
<tbody>
<tr>
<th>Discount</th></tr>
<tr>
<td colspan="1">
  
![Screenshot](/Documentation/Specifications/Spec%20Images/Refund12.png)
  
</td></tr></tbody></table>
<h3><strong>Solution - Import Process in Acumatica</strong></h3>
<p>
  
![Screenshot](/Documentation/Specifications/Spec%20Images/Refund13.png)
  
</p>
<p>Once a Refund is processed in WooCommerce, the following actions happen to transfer the Refund into Acumatica:</p>
<ol>
<li>The Prepare Data screen is invoked to Import Refunds. Record is imported.</li>
<li>The Process Data screen is invoked and begins the Syncing process.
<ol>
<li>If the Original Sales Order Status is Completed&nbsp;the following will happen:
<ol>
<li>The process creates a new credit order as per the Return for Credit order type specified in the WooCommerce Stores screen (ex: RC, or any new order type that&nbsp;uses the RC template). See <span style="color: rgb(0,51,102);">Note<sup>1</sup>.</span></li>
<li>If a product is refunded, a new line is created using the product code in the refund record to create a credit line item.</li>
<li><span style="color: rgb(0,0,0);">If an amount&nbsp;is being refunded&nbsp;(with no product quantity) and an order level refund is issued, a new line using the Refund Amount Item in the WC Stores screen will be created as a credit line item.&nbsp;</span></li>
<li>If a refund is being issued for Shipping, the amount of the refund will be added to the Freight Price in the Totals tab creating a credit for Shipping.&nbsp;No items will be needed. But the refund is given exceeding the shipping amount or the shipping taxes, those will be added to the refund amount item.</li>
<li>If the refund includes both a product and shipping, a new line will be required for the product AND a freight amount will be populated in the Totals tab.</li>
<li>In every case, the Refund Reason code specified in the WC Stores Order Settings is applied to the&nbsp;credit line item. This also provides the GL accounts required to record the refund amount for accounting.<br /><br /></li></ol></li>
<li>If the Original Sales Order Status is Open or On-Hold the following happens:
<ol>
<li>The process identifies the original order and edits the order by using the order_id in the refund record and searching for the sales order in Acumatica with that value in the External Reference field in the SO header.</li>
<li>If a product is refunded,&nbsp;the order line for the item being refunded will be adjusted by reducing the original qty by qty refunded (in refund record).&nbsp;
<ul>
<li>The item_id in the refund record (when item_type = PRODUCT) will be used to identify the item.</li>
<li>If there is more than one line with the same inventory_id, the qty and price will be used to help identify the correct line item.</li></ul></li>
<li><span style="color: rgb(0,0,0);">If shipping is being refunded, the original shipping amount will be reduced by changing the Freight Price amount&nbsp;(original amount - refund amount)&nbsp;in the Totals tab.&nbsp;But the refund is given exceeding the shipping amount or the shipping taxes, those will be added to the refund amount item.</span></li>
<li>If an amount is being refunded (with no product quantity) and there is an order level refund issued, a new line using the Refund Amount Item in the WC Stores screen will be created as a credit line item.&nbsp;<br /><br /></li></ol></li>
<li>If the Order status is not in (Open, On-Hold, Completed) the syncing fails and an error is raised indicating the order status is invalid. See the message in the Error Handling section.</li></ol></li></ol>
<p style="margin-left: 30.0px;">Note<sup>1</sup>: In the case, a credit order type order is created to offset a completed sales order, the Credit must be applied to the original sales order in Acumatica Receivables, outside the scope of the eCommerce Edition.</p>
<p style="margin-left: 30.0px;">Note<sup>2</sup>: Where a Customer Refund is applied to a Payment record for an order, the amount of the Customer Refund reduces the Balance of the payment directly. See Payment Priority for application to multiple payments.</p>
<p style="margin-left: 30.0px;"><span style="color: rgb(0,51,102);">Note: For the Return for Credit order, the External ID field in the header should equal the External ID for the original sales order.&nbsp;</span></p>
<p>&nbsp;</p>
