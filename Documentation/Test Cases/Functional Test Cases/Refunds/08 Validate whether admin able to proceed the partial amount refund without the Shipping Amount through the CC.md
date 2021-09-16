
<p><u><strong>Description</strong></u></p>
<p>admin able to proceed the partial amount refund without the Shipping Amount through the CC</p>
<p><u><strong>Prerequisites</strong></u></p>
<p>1. User has access to the ERP application<br />2. WooCommerce Connector is configured</p>
<p>3. Customer has access to the WooCommerce Web Application</p>
<p>4. Shipping is configured in the wooCommerce</p>
<p>5.&nbsp;<a class="external-link" href="http://authorize.net/" rel="nofollow">Authorize.net</a>&nbsp;plugin is installed in the WC and configured it</p>
<p>6.&nbsp;<a class="external-link" href="http://authorize.net/" rel="nofollow">Authorize.net</a>&nbsp;payment method related payment release check box is disabled in WooCommerce settings</p>
<p>7. Authorization is selected as the Transaction Type in the&nbsp; in the WooCommerce&nbsp;</p>
<p>&nbsp;</p>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<p>1. Open the WC Customer Application</p>
<p>2. Login to the WooCommerce web application as the Registered Customer</p>
<p>3. Add some items to the cart (2 Qty from Each for few inventory items(2))</p>
<p>4. Select the payment method as CC and proceed, Then place the order</p>
<p>5. Prepare and Process the sales order from process screen</p>
<p>Commerce &gt; Processes</p>
<p>6. Open the Payment record from Sync History</p>
<p>Commerce &gt; Sync History</p>
<p>7. Make sure the payment Status is 'Pending Processing'</p>
<p>8. Validate the card and Release the Payment</p>
<p>9. Open the related Sales Order record and Click on the &quot;Hold Button and then Un Hold it</p>
<p>10. Make sure the Status has been changed as 'Open' in the Sales Order Record</p>
<p>11. Open the particular Sales Order record after a day from order has been placed in the WC as the admin (Partial refunds through the <a href="http://Authorization.net">Authorization.net</a> wont be allowed )</p>
<p>12. Refund 1Qty from one inventory item and Refund Amount from other inventory item. DON'T refund the Shipping charges and&nbsp; shipping taxes</p>
<p>12.1. Select the refund source as credit card</p>
<p>13. Make sure the Balance is calculated by reducing the refunded amount in WC</p>
<p>14. Prepare the Refund entity and Process it</p>
<p>15. Make sure the Refund entity is processed successfully</p>
<p>16. Go to the Sales Order record and validate the refunded items/ amount in the details tab</p>
<p>17. Open the Pre-payment record and validate the Balance</p>
<p>18. Make sure the customer payment document is created and validate the full amount</p>
<p>19. Validate the Freight Price in the Totals tab in the Sales Order</p>
<p>20. Validate the tax amount in the Summary in the Sales Order Summary</p>
<p>21. Validate the Total amount in the Sales Order summary</p>
<p>&nbsp;</p>
<p><u><strong>Expected Results</strong></u></p>
<p>16. The quantities have been reduced in front of the relevant inventory item and amount refund is added as a new row in the details tab</p>
<p>17. The balance is added in the Pre-Payment from the remaining total after the refund in the WC Sales order</p>
<p>18. The customer payment document is created and refunded total is recorded as the customer payment record</p>
<p>19. The&nbsp;Freight Price should NOT be reduced</p>
<p>20. Tax has been adjusted after deducting the refunded tax amount</p>
<p>21. The Total amount has been displayed correctly after reducing the refunded amount from the Total</p>
