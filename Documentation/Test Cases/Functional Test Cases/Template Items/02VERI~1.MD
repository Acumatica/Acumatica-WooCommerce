
<p><strong><u>Description</u></strong></p>
<p>user able to purchase template item of stock item and import to the accumatica with the sales order and export the shipment</p>
<p style="margin-left: 0.0in;"><strong><u>Prerequisites</u></strong>&nbsp;</p>
<p style="margin-left: 0.0in;">1. User has access to the ERP application<br />2. WooCommerce Connector is configured<br />3. User has opened the Template Items page in Acumatica</p>
<p style="margin-left: 0.0in;">4. The template items have been imported to the WooCommerce</p>
<p style="margin-left: 0.0in;">5. Tax is configured in the WC</p>
<p style="margin-left: 0.0in;">6. Coupon discount is configured in the WC</p>
<p style="margin-left: 0.0in;">7. Shipment is configured as a flat rate and the shipment taxes</p>
<p style="margin-left: 0.0in;">&nbsp;</p>
<p style="margin-left: 0.0in;"><strong><u>Detailed Steps to Test</u></strong>&nbsp;</p>
<p style="margin-left: 0.0in;">1. Login to the customer application as the registered user</p>
<p style="margin-left: 0.0in;">2. Add few template items to the cart based on selected options</p>
<p style="margin-left: 0.0in;">3. Go to the Checkout page</p>
<p style="margin-left: 0.0in;">4. Add a Coupon Discount to the cart</p>
<p style="margin-left: 0.0in;">5. Make sure the Shipment is added with the taxes</p>
<p style="margin-left: 0.0in;">6. Make sure the any other taxes added in to the checkout page</p>
<p style="margin-left: 0.0in;">7. Proceed to the checkout with the CC/Cash payment</p>
<p style="margin-left: 0.0in;">8. Go to the Processing screen and Prepare the Sales Order record.&nbsp;</p>
<p style="margin-left: 0.0in;">9. Process the record</p>
<p style="margin-left: 0.0in;">10. Open the sales order record and validate the purchased template item options have been imported to the accumatica correctly with the sales order</p>
<p style="margin-left: 0.0in;">11. Open the Payment record and validate the payment information related to the purchased items</p>
<p style="margin-left: 0.0in;">12. Create a Shipment record and Release the shipment and make sure the sales order status has been changed to the Completed status;</p>
<p style="margin-left: 0.0in;">13. Go to the process screen. Then prepare and process the Shipment entity</p>
<p style="margin-left: 0.0in;">14. Go to the WC and validate the sales order after the shipment exporting</p>
<p style="margin-left: 0.0in;">&nbsp;</p>
<p style="margin-left: 0.0in;"><strong><u>Expected Results</u></strong>&nbsp;</p>
<p style="margin-left: 0.0in;">10. The selected options of the template item for the sales order are accurately imported to the AC with the SO</p>
<p style="margin-left: 0.0in;">11. The payment information should be correct</p>
<p style="margin-left: 0.0in;">12. Sales order record should be changed to the Completed status once everything imported</p>
<p style="margin-left: 0.0in;">14. The status of the WC sales order has changed to the Completed status and the inventory also should be reduced related to the particular variant</p>
<p style="margin-left: 0.0in;">&nbsp;</p>
<p style="margin-left: 0.0in;"><strong><u>Test Data</u></strong></p>
