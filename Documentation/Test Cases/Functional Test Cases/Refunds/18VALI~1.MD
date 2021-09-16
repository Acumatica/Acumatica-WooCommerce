
<p><u><strong>Description</strong></u></p>
<p>new credit line item created upon refund an amount when an order level refund is issued when the Original Sales Order Status is Completed</p>
<p>&nbsp;</p>
<p><u><strong>Prerequisites</strong></u></p>
<p>1. User has access to the ERP application<br />2. WooCommerce Connector is configured</p>
<p>3. Customer has access to the WooCommerce Web Application</p>
<p>4. Shipping is configured in the wooCommerce</p>
<p><span style="color: rgb(255,0,0);"><span style="color: rgb(0,0,0);">&nbsp;</span></span></p>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<p>1. Open the WC Customer Application</p>
<p>2. Login to the WooCommerce web application as the Registered Customer</p>
<p>3. Add some items to the cart</p>
<p>4. Select the payment method as Cash on Delivery (Cash) and proceed, Then place the order</p>
<p>5. Prepare and Process the sales order from process screen</p>
<p>Commerce &gt; Processes</p>
<p>6. Open the Payment record from Sync History</p>
<p>Commerce &gt; Sync History</p>
<p>7. Make sure the payment Status is 'Open'</p>
<p>8. Make sure the Status has been changed as 'Open' in the Sales Order Record</p>
<p>9. Create s Shipment and Confirm it; Make sure the Sales Order Status changed as 'Completed'</p>
<p>10. Open the particular Sales Order record in the WC as the admin</p>
<p>11. Refund all the added quantities and all the Shipping and Shipping taxes</p>
<p>12. Select the refund source as Cash (Manual)</p>
<p>13. Make sure the Balance is 0</p>
<p>14. Prepare the Refund entity and Process it</p>
<p>15. Make sure the Refund entity is processed successfully</p>
<p>16. Go to the Sales Order record and validate the refunded items in the details tab</p>
<p>17. Open the Pre-payment record and validate the Balance</p>
<p>18. Make sure the customer payment document is created and validate the full amount</p>
<p>19. Validate the Freight Price in the Totals tab in the Sales Order</p>
<p>20. Open the RC record created and credit lines has been created for each refund item</p>
