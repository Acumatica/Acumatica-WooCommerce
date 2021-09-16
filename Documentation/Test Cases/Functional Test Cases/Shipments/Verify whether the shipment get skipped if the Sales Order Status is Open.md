
<p><u><strong>Description</strong></u></p>
<p>&nbsp;&nbsp;shipment get skipped if the Sales Order Status is 'Open'</p>
<p><u><strong>Prerequisites</strong></u></p>
<ol>
<li>User is privileged to access the both of the applications, Acumatica and the Woo Commerce</li>
<li>The WooCommerce Connector has configured correctly with the acumatica commerce module</li></ol>
<p><u><strong>Detailed Test Steps</strong></u></p>
<ol>
<li>Create an order in the WooCommerce and import to the Acumatica</li>
<li>Capture and validate the payment</li>
<li>Make sure the AC Order Status is 'Open'</li>
<li>create a shipment for the order</li>
<li>Add a tracking number</li>
<li>Export the shipment record to the WooCommerce</li>
<li>Validate the exported details to the WC</li></ol>
<p><u><strong>Expected Results</strong></u></p>
<p>The shipment records with Open status should be skipped</p>
