<h1> Refunds Solution - Based on the WooCommerce Refunds Features
<h2><strong>WooCommerce Refunds Features/ Behaviour</strong></h2>
<p><br class="atl-forced-newline" /> WooCommerce Refunds handling process has more freedom compared to the BigCommerce and Shopify connectors. For instance, when refunding a sales order by Admin, the refund can be initiated in the following ways.</p>
<h4><strong>Without Quantity</strong></h4>
<p><br /> In this, a refund can be done without specifying the refund quantity and even can specify the refund amount for each item manually, even higher than the order line amount (maximum limit is Total Order Amount). <br class="atl-forced-newline" /> E.g.: the Order Line Amount is $70.30 but the refund can be done for $80 (maximum limit is Total Order Amount $2234.44). <br class="atl-forced-newline" /> 

![Screenshot](/Specifications/Spec%20Images/RefundsSol1.png)
  
  
  <br class="atl-forced-newline" /><br class="atl-forced-newline" /> <br class="atl-forced-newline" /> <strong>With Quantity</strong></p>
<p><br class="atl-forced-newline" /> Even the refund is initiated from the quantity, the admin can manipulate the refund amounts/quantity by manually adjusting the values. <br class="atl-forced-newline" /> E.g.: One quantity is refunded (the ideal amount should be $45.15 for 1 quantity), but the refund is done for $100 (the maximum limit is Total Order Amount $2256.22). <br class="atl-forced-newline" /> 
  
  ![Screenshot](/Specifications/Spec%20Images/RefundsSol2.png)
  
<p><strong>Summary</strong> <br class="atl-forced-newline" /> <strong>Note 1:</strong> Admin can manipulate the <ac:inline-comment-marker ac:ref="bec5fa87-5a4c-437c-bddd-b9f89f2ea69b">refund amoun</ac:inline-comment-marker>t with a maximum limit up to the Total Order Amount <br class="atl-forced-newline" /> <strong>Note 2:</strong> Admin can manipulate the quantity, even can set the higher number compared to original order quantity. <br class="atl-forced-newline" /> 
 
  ![Screenshot](/Specifications/Spec%20Images/RefundsSol3.png)
  
<h2><strong>Solution&nbsp;</strong></h2>
<ul>
<li>No quantity mentioned&gt; Consider as a Refund Amount Item (sync through the non-stock item)</li>
<li>The quantity mentioned&gt; Exceeds the Order Line Amount&gt; Exceeded Amount consider as a Refund Amount Item <strong>(One line for the entire order not per item)</strong></li>
<li>The quantity mentioned&gt; Not exceeds the Order Line Amount&gt; Proportionately assigned the amounts (order &amp; discount amounts) to the Sales Order or Return for Credit Order</li>
<li>Tax &amp; Shipping&gt; Exceeds the Order Line Amount&gt; Exceeded Amount consider as a Refund Amount Item <strong>(One line for the entire order not per item)</strong></li></ul>
<p><strong>Impact</strong></p>
<ul>
<li>Sales profitability calculation and printed forms, such as Sales Order/Quote, SO Invoice will display the extended price.</li>
<li>In option 2, exceed amount considered to be Refund Amount Item, therefore,<strong> less price manipulation</strong> compared to Option 3.<br />e.g: Option 3: The order total is $100 and one order line has $40, and the admin can refund $ 60. In this case, if the sales order is Open Extended Price will be set to -$20 ($40 - $60).</li></ul>
<h4><br class="atl-forced-newline" /> <strong>Scenario: Without Quantity</strong></h4>
<ol>
<li><strong>Open Sales Orders</strong></li></ol>
<p><br class="atl-forced-newline" /> If the refund amount exceeds the sales order line amount, this will sync to Acumatica as a Refund Amount Item (with minus Price). <br class="atl-forced-newline" /> And for the shipping charges and shipping taxes (if applicable), it will refund only the shipping charge and shipping taxes subject to the limit of the original order remaining will be added to the Refund Amount Item.</p>
<p><br class="atl-forced-newline" /> 
  
![Screenshot](/Specifications/Spec%20Images/RefundsSol4.png)
  
  <br class="atl-forced-newline" /> Create Refund Amount Item (with minus Price) to reflect the refund done.<br /> 
  
![Screenshot](/Specifications/Spec%20Images/RefundsSol5.png)
  
  <br class="atl-forced-newline" /> <br class="atl-forced-newline" /> <br class="atl-forced-newline" /> <strong>Scenario: With Quantity</strong></p>
<ol>
<li><strong>Open Sales Orders - Not Exceeding the Order Line total</strong></li></ol>
<p><br class="atl-forced-newline" /> When an order is refunded with quantity only or refunded with quantity plus entering an amount, Acumatica Sales Order will be adjusted the &quot;Extended Price&quot; remaining the original sales order quantity. <br class="atl-forced-newline" /> 
  
 ![Screenshot](/Specifications/Spec%20Images/RefundsSol6.png)
  
 <br class="atl-forced-newline" /> <span style="color: rgb(255,0,0);"><strong>Note 1:</strong></span> Amount = $70.30 - $60 =$10.30<br /> <span style="color: rgb(0,102,255);"><strong>Note 2:</strong></span> Extended Price and Quantity will be adjusted to reflect the remaining amount after the refund is applied. Unit Price will not be modified since if it is modified it will affect the costing calculations. <br class="atl-forced-newline" /> 
  
 <![Screenshot](/Specifications/Spec%20Images/RefundsSol7.png)
 
<p><strong>2. Open Sales Orders - Exceeding the Order Line total</strong></p>
<p><br class="atl-forced-newline" /> Whenever refund amount exceeds the particular sales order line amount, Extended Price set to &quot;0&quot; and Refund Amount Item will be created for the exceeding amount. However, WC Sales Order quantity will be reflected in AC as well. <br /> 
  
 ![Screenshot](/Specifications/Spec%20Images/RefundsSol8.png)
 
  <br class="atl-forced-newline" /> <span style="color: rgb(0,102,255);"><strong>Note:</strong></span> Refund Item Amount $ 70.30-$80=$9.7 <br class="atl-forced-newline" /> <span style="color: rgb(229,53,39);"><strong>Note:</strong></span> Quantity should reflect the WC Sales Order Qty (after refund qty), Extended Price set to &quot;0&quot; <br class="atl-forced-newline" /> 
  
![Screenshot](/Specifications/Spec%20Images/RefundsSol9.png)
  
<p><strong>3. Completed Sales Orders - Not Exceeding the Order Line total</strong></p>
<p>Similar to the &quot;Open&quot; Sales Orders - Not Exceeding the Order Line total&quot; scenario, a new RC Type Sales Order will be created in AC to show the refund amount. <br/> 
  
![Screenshot](/Specifications/Spec%20Images/RefundsSol10.png)
  
  <br class="atl-forced-newline" /> 
  
 ![Screenshot](/Specifications/Spec%20Images/RefundsSol11.png)
  
  <br class="atl-forced-newline" /> <br class="atl-forced-newline" /><br class="atl-forced-newline" /></p>
<p><strong>4. Completed Sales Orders - Exceeding the Order Line total</strong></p>
<br class="atl-forced-newline" /> New RC Type Sales Order will be created in AC to show the refund amount. And refund the order line item up to the original sales order value and Refund Amount Item will be created for the exceeding amount. <br class="atl-forced-newline" /> 
  
  ![Screenshot](/Specifications/Spec%20Images/RefundsSol12.png)
  
 <br class="atl-forced-newline" /> 
  
 ![Screenshot](/Specifications/Spec%20Images/RefundsSol13.png)
  
 <br class="atl-forced-newline" /><br />
<p><strong>When multiple refunds are done to the same Sales Order in WC</strong>.&nbsp;<strong>And original Sales Order is synced and at Completed status in AC,</strong></p>
<ol>
<li>For the first refund &ndash; Create a new RC Order</li>
<li>After the first refund</li></ol>
<ul>
<li style="list-style-type: none;background-image: none;">
<ul>
<li>RC is open &ndash; Create a new RC order &amp; create a new customer refund</li>
<li>RC is completed - Create a new RC Order &amp; create a new customer refund</li></ul></li></ul>
<p>&nbsp;</p>
