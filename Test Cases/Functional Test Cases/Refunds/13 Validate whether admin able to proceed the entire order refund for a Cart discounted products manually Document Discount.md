
<p><u><strong>Description</strong></u></p>
<p>Admin able to proceed the entire order return with the discount manually&nbsp;</p>
<p><u><strong>Prerequisites</strong></u></p>
<p>1. User has access to the ERP application<br />2. WooCommerce Connector is configured</p>
<p>3. Customer has access to the WooCommerce Web Application</p>
<p>4. Shipping is configured in the wooCommerce</p>
<p>5. Item Discount is configured in the Woo Commerce</p>
<p>6. Document discount is selected in the Order Setting at WooCommerce Store Settings</p>
<p>&nbsp;</p>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<p>1. Open the WC Customer Application</p>
<p>2. Login to the WooCommerce web application as the Registered Customer</p>
<p>3. Add some items to the cart and add the Discount Code in the checkout page</p>
<p>4. Select the payment method as Cash on Delivery (Cash) and proceed, Then place the order</p>
<p>5. Prepare and Process the sales order from process screen</p>
<p>Commerce &gt; Processes</p>
<p>6. Open the Payment record from Sync History</p>
<p>Commerce &gt; Sync History</p>
<p>7. Make sure the payment Status is 'Open'</p>
<p>8. Make sure the Status has been changed as 'Open' in the Sales Order Record</p>
<p>9. Open the particular Sales Order record in the WC as the admin</p>
<p>10. Refund all the added quantities and all the Shipping and Shipping taxes</p>
<p>11. Select the refund source as Cash (Manual)</p>
<p>12. Make sure the Balance is 0</p>
<p>13. Prepare the Refund entity and Process it</p>
<p>14. Make sure the Refund entity is processed successfully</p>
<p>15. Go to the Sales Order record and validate the refunded items in the details tab</p>
<p>16. Open the Pre-payment record and validate the Balance</p>
<p>17. Make sure the customer payment document is created and validate the full amount</p>
<p>18. Validate the Freight Price in the Totals tab in the Sales Order</p>
<p>19. Validate the Discounted products also refunded</p>
<p>&nbsp;</p>
<p><u><strong>Expected Results</strong></u></p>
<p>15. The quantities have been changed as 0</p>
<p>16. The balance is 0 in the Pre-Payment</p>
<p>17. The customer payment document is created and Total order amount is recorded as the customer payment record</p>
<p>18. The&nbsp;Freight Price should be 0</p>
<p>19. The discounted products also refunded and displaying in the Details tab. The Discount amount and the Percentage in the Sales Order discount tab has been displayed as 0</p>
