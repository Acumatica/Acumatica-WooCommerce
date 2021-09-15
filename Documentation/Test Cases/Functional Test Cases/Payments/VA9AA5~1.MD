
<p><u><strong>Description</strong></u></p>
<p><span style="color: rgb(0,0,0);">The required fields of the WooCommerce application&nbsp; should be mapped with the relevant field of the acumatica based on the payment mapping</span></p>
<p><u><strong>Prerequisites</strong></u></p>
<p>1. User has access to the ERP application<br />2. WooCommerce Connector is configured</p>
<p>3. Customer has access to the WooCommerce Web Application</p>
<p>4. Release payment setting is disabled for the payment method at WooCommerce Settings</p>
<p>WooCommerce Settings &gt; Payment</p>
<p>5. <strong>&lt;pPaymentMethod&gt;</strong> configuration related to the Acumatica and WooCommerce is completed</p>
<p>&nbsp;</p>
<p><u><strong>Detailed Steps to Test</strong></u></p>
<p>1. Transaction type has been marked as 'Authorization' in the&nbsp;<a class="external-link" href="http://authorize.net/" rel="nofollow">Authorize.net</a>&nbsp;plugin and enable the 'Capture Paid orders' check box</p>
<p>Settings &gt; Payments &gt; Authorize.Net</p>
<p>2. Login to the WooCommerce web application as the registered customer</p>
<p>3. Add items to the cart and go to the checkout page</p>
<p>4. Select the payment methods as <strong>&lt;pPaymentMethod&gt;</strong> and placethe order</p>
<p>5. Make sure the payment is captured if the payment method you have selected as a CC payment</p>
<p>6. Prepare and Process the payment</p>
<p>Commerce &gt; Processes</p>
<p>7. Open the payment record from Sync History</p>
<p>Commerce &gt; Inquiries</p>
<p>8. Validate the WC data with the acumatica relevant fields based on the mapping document</p>
<p>Validate the Woocommerce <strong>currency type</strong>&nbsp;&lt;pCurrency&gt;&nbsp; with the currency type imported to the payment record in Acumatica <strong>Currency</strong>,&nbsp;<em>Payments and Applications&gt;Currency</em></p>
<p>Woocommerce&nbsp;<strong>date_paid</strong>, &lt;pD<span>ate_paid&gt;</span> with the Acumatica <strong>Application Date</strong>;&nbsp;<em>Payments and Applications&gt;Payment Amount</em></p>
<p><span>Woocommerce <strong>total</strong>, &lt;pT<span>otal</span>&gt;&nbsp;with the Acumatica&nbsp;<strong>Payment Amount</strong>;&nbsp;<em>Payments and Applications&gt;Payment Amount</em></span></p>
<p>Woocommerce<strong> transaction_id</strong>, &lt;pT<span>ransaction_id</span>&gt;&nbsp;with the Acumatica&nbsp;<strong>Payment Ref.</strong>;&nbsp;<em>Payments and Applications&gt;Payment Ref.</em></p>
<p>Woocommerce <strong>payment_method_title</strong>, &lt;pP<span>ayment_method_title</span>&gt;&nbsp;with the Acumatica&nbsp;<strong>Payment Method</strong>;&nbsp;<em>Payments and Applications&gt;Payment Method</em></p>
<p><span><br /></span></p>
<p>Woocommerce API Line data of&nbsp;<span>&quot;<strong>wc_authorize_net_cim_credit_card_charge_captured&quot;,&quot;value&quot;/&nbsp;</strong><span><strong>&quot;_wc_authorize_net_cim_credit_card_capture_trans_id</strong>&quot; with the acumatica</span></span>,&nbsp;<span><strong>Tran. Type</strong>;&nbsp;</span><span>Payments and Applications&gt; Credit Card Processing Info</span></p>
<p>&nbsp;</p>
<p>Woocommerce <strong>total</strong>, &lt;pT<span>otal</span>&gt;&nbsp;with the Acumatica&nbsp;<span><strong>Tran. Amount</strong>;</span>&nbsp;<span>Payments and Applications&gt; Credit Card Processing Info</span></p>
<p>Woocommerce <strong>transaction_id</strong>, &lt;pTransaction_id&gt;&nbsp;with the Acumatica <span><strong>Proc. Center Tran. Nbr</strong>.</span>;&nbsp;Payments and Applications&gt; Credit Card Processing Info</p>
<p>Woocommerce <strong>date_paid</strong>, &lt;pD<span>ate_paid</span>&gt;&nbsp;with the Acumatica&nbsp;<strong>Tran. Time</strong>;&nbsp;Payments and Applications&gt; Credit Card Processing Info</p>
<p>&nbsp;</p>
<p><u><strong><br />Expected Results</strong></u></p>
<p>8. The Woo Commerce data should be imported to the accumatica payments correctly followed by the mapping document correctly</p>
<p><u><strong>Test Data</strong></u></p>
<p><strong>&lt;pPaymentMethod&gt;</strong>&nbsp; = Authorize,Net&nbsp;</p>
