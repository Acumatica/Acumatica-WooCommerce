
<p><u><strong>Description</strong></u></p>
<p><span style="color: rgb(0,0,0);">The status =&nbsp;&lt;pWC_Order_Status&gt; of WooCommerce sales order imported to the acumatica and created a Sales Order with the &quot;Status&quot; = 'Open'.</span></p>
<p><span style="color: rgb(0,0,0);">The WC orders which have been created as &quot;<span style="color: rgb(0,0,0);">Pending payment,&nbsp;Processing,&nbsp;On-hold,&nbsp;Completed,&nbsp;Failed and trash&quot; will be imported to the acumatica Sales Orders as &quot;Open&quot; status records.</span></span></p>
<p><span style="color: rgb(0,0,0);"><br /></span></p>
<p><u><strong>Prerequisites</strong></u></p>
<p>1. User has access to the ERP application<br />2. WooCommerce Connector is configured</p>
<p>3. Customer has access to the WooCommerce Web Application</p>
<p>4. Payment configuration related to the Acumatica and WooCommerce is completed</p>
<p>5. Tax configuration related to the Acumatica and WC are completed</p>
<p>6. Shipment configurations related to the Acumatica and WC are completed</p>
<p>&nbsp;</p>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<p>1. Open the WC client application and the Acumatica ERP</p>
<p>2. Login to the WooCommerce web application as the Registered or Guest Customer</p>
<p>3. Add some items to the cart</p>
<p>4. Select the payment methods as preferred; &lt;pPaymentMethod&gt;</p>
<p>5. Go to the WC admin application as the admin and open the order</p>
<p>6. Make sure the Order Status is = &lt;pWC_OrderStatus&gt;</p>
<p>7. Prepare and Process the payment</p>
<p>Commerce &gt; Processes</p>
<p>8. Open the Sales Order record from Sync History</p>
<p>Commerce &gt; Inquiries</p>
<p>9. Validate the Order Status and Payment Status</p>
<p>&nbsp;</p>
<p><u><strong>Expected Results</strong></u></p>
<p>9. The acumatica Order Status should be created as &quot;Open&quot;</p>
<p>&nbsp;</p>
<p><u><strong>Test Data</strong></u></p>
<p><span style="color: rgb(0,0,0);">&lt;pWC_Order_Status&gt; =&nbsp;Pending payment,&nbsp;Processing,&nbsp;On-hold,&nbsp;Completed,&nbsp;Failed and trash</span></p>
