
<div class="wiki-content">
<p><u><strong>Description</strong></u></p>
<p>admin able to proceed the partial amount refund without the Shipping Amount Manually</p>
<p><u><strong>Prerequisites</strong></u></p>
<p>1. User has access to the ERP application<br />2. WooCommerce Connector is configured</p>
<p>3. Customer has access to the WooCommerce Web Application</p>
<p>4. Shipping is configured in the wooCommerce</p>
<p>&nbsp;</p>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<p>1. Open the WC Customer Application</p>
<p>2. Login to the WooCommerce web application as the Registered Customer</p>
<p>3. Add some items to the cart with 2 Qty and Two inventory items</p>
<p>4. Select the payment method as Cash on Delivery (Cash) and proceed, Then place the order</p>
<p>5. Prepare and Process the sales order from process screen</p>
<p>Commerce &gt; Processes</p>
<p>6. Open the Payment record from Sync History</p>
<p>Commerce &gt; Sync History</p>
<p>7. Make sure the payment Status is 'Open'</p>
<p>8. Make sure the Status has been changed as 'Open' in the Sales Order Record</p>
<p>9. Open the particular Sales Order record in the WC as the admin</p>
<p>10. Refund 1 Qty from the first inventory item and&nbsp; amount from the 2nd inventory item. Then&nbsp; Don't refund the Shipping and Shipping taxes</p>
<p>11. Select the refund source as Cash (Manual)</p>
<p>12. Make sure the Balance has been reduced</p>
<p>13. Prepare the Refund entity and Process it</p>
<p>14. Make sure the Refund entity is processed successfully</p>
<p>15. Go to the Sales Order record and validate the refunded items in the details tab</p>
<p>16. Open the Pre-payment record and validate the Balance</p>
<p>17. Make sure the customer payment document is created and validate the full amount</p>
<p>18. Validate the Freight Price in the Totals tab in the Sales Order</p>
<p>&nbsp;</p>
<p><u><strong>Expected Results</strong></u></p>
<p>15. The quantities have been reduced in front of the relevant inventory item and amount refund is added as a new row in the details tab</p>
<p>16. The balance is added in the Pre-Payment from the remaining total after the refund in the WC Sales order</p>
<p>17. The customer payment document is created and refunded total is recorded as the customer payment record</p>
<p>18. The&nbsp;Freight Price should be NOT be reduced</p>
<p>19. Tax has been adjusted after deducting the refunded tax amount</p>
<p>20. The Total amount has been displayed correctly after reducing the refunded amount from the Total</p></div>
<div>
<div><a class="like-button" href="https://wiki.acumatica.com/display/AD/06+Validate+whether+admin+able+to+proceed+the+partial+amount+refund+with+the+Shipping+Amount+Manually"><span class="aui-icon aui-icon-small aui-iconfont-like" style="color: rgb(112,112,112);">&nbsp;</span></a></div></div>
