***Payments Import***
<p>Status: Completed</p>
<table>
<thead>
<tr>
<th>
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">Version</div></div></div></div></th>
<th>
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">Description</div></div></div></div></th>
<th colspan="1">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">&nbsp;Status</div></div></div></div></th></tr></thead>
<tbody>
<tr>
<td>1.0</td>
<td>Milestone 01</td>
<td colspan="1">Completed</td></tr></tbody></table>
<p>In WooCommerce, there is no separate API to get the payment data. Data related to payment is available on the Order API.</p>
<p>Filters are applied during the import of payments to Acumatica ERP. A payment is skipped if any of the following is true:</p>
<ul class="wikibulletlist" style="margin-left: 3.0em;">
<li class="wikibullet">The store payment method is not configured in the&nbsp;<strong>Payment Methods</strong>&nbsp;section of the&nbsp;<strong>Payment Settings</strong>&nbsp;tab of the WooCommerce Store form.</li>
<li class="wikibullet">The sales order related to the payment has not been synchronized.</li></ul>
<p>&nbsp;</p>
<table>
<thead>
<tr>
<th colspan="8">Acumatica (Target)</th>
<th colspan="3">WooCommerce (Source)</th></tr></thead>
<tbody>
<tr>
<th>Field Label</th>
<th>Acumatica Path</th>
<th>Mandatory</th>
<th>Column Name</th>
<th>Data Access Class</th>
<th>Table</th>
<th>Framework</th>
<th>Comment</th>
<th>Field Name</th>
<th>Value Example</th>
<th>Description</th></tr>
<tr>
<td>Type</td>
<td>Payments and Applications&gt; Type</td>
<td>&nbsp;</td>
<td>DocType</td>
<td>ARPayment</td>
<td>ARPayment</td>
<td>Payments-&gt; Type</td>
<td><span style="color: rgb(0,0,0);">Default:&nbsp;</span><em>Prepayment</em></td>
<td>N/A</td>
<td>&nbsp;</td>
<td>&nbsp;</td></tr>
<tr>
<td colspan="1">Customer</td>
<td colspan="1"><span>Payments and Applications&gt;Customer</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">CustomerID</td>
<td colspan="1">ARPayment</td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; CustomerID</span></td>
<td colspan="1"><span style="color: rgb(0,0,0);">The customer ID is the same as the customer ID on the related sales order.</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1">Location</td>
<td colspan="1"><span>Payments and Applications&gt;Location</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">CustomerLocationID</td>
<td colspan="1"><span>ARPayment</span></td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; </span><span>CustomerLocationID</span></td>
<td colspan="1"><span style="color: rgb(0,0,0);">The location is the same as the location on the related order.</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1">Currency</td>
<td colspan="1"><span>Payments and Applications&gt;<span>Currency</span></span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span>ARPayment</span></td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; </span>CurrencyID</td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span>currency</span></td>
<td colspan="1">USD</td>
<td colspan="1"><span>Currency the order was created with, in ISO format.&nbsp;</span></td></tr>
<tr>
<td colspan="1">Application Date</td>
<td colspan="1"><span>Payments and Applications&gt;<span>Application Date</span></span></td>
<td colspan="1">Y</td>
<td colspan="1">AdjDate</td>
<td colspan="1"><span>ARPayment</span></td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; </span>ApplicationDate</td>
<td colspan="1"><span style="color: rgb(0,0,0);">The payment transaction date is used.</span></td>
<td colspan="1"><span>date_paid</span></td>
<td colspan="1">2017-03-22T16:28:08</td>
<td colspan="1"><span>The date the order was paid, in the site's timezone.</span></td></tr>
<tr>
<td colspan="1">Payment Amount</td>
<td colspan="1"><span>Payments and Applications&gt;<span>Payment Amount</span></span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">CuryOrigDocAmt</td>
<td colspan="1"><span>ARPayment</span></td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; PaymentAmount </span></td>
<td colspan="1"><span style="color: rgb(0,0,0);">The payment transaction amount is used.</span></td>
<td colspan="1">total</td>
<td colspan="1">29.35</td>
<td colspan="1"><span>Grand total.</span></td></tr>
<tr>
<td colspan="1">Payment Ref.</td>
<td colspan="1"><span>Payments and Applications&gt;<span>Payment Ref.</span></span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">ExtRefNbr</td>
<td colspan="1"><span>ARPayment</span></td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; PaymentRef</span></td>
<td colspan="1"><span style="color: rgb(0,0,0);">If&nbsp;</span><strong>GatewayTransactionId</strong><span style="color: rgb(0,0,0);">&nbsp;is empty,&nbsp;</span><strong>Order_Id</strong><span style="color: rgb(0,0,0);">&nbsp;is used.</span></td>
<td colspan="1"><span style="color: rgb(0,0,0);">transaction_id</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span>Unique transaction ID.</span></td></tr>
<tr>
<td colspan="1">Payment Method</td>
<td colspan="1"><span>Payments and Applications&gt;<span>Payment Method</span></span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">PaymentMethodID</td>
<td colspan="1"><span>ARPayment</span></td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; PaymentMethod</span></td>
<td colspan="1">
<p><span style="color: rgb(0,0,0);">The payment method that is mapped to the store&rsquo;s payment method on the&nbsp;</span><strong>Payment Methods</strong><span style="color: rgb(0,0,0);">&nbsp;tab of the&nbsp;WooCommerce Stores</span><span style="color: rgb(0,0,0);">&nbsp;form.</span></p>
<p><span style="color: rgb(0,0,0);">If the Store Payment Method is not available in the order, payment should not be synced to AC.</span></p></td>
<td colspan="1">payment_method_title</td>
<td colspan="1">Direct Bank Transfer</td>
<td colspan="1"><span>Payment method title.</span></td></tr>
<tr>
<td colspan="1">Cash Account</td>
<td colspan="1"><span>Payments and Applications&gt;<span>Cash Account</span></span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">CashAccountID</td>
<td colspan="1"><span>ARPayment</span></td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; CashAccount</span></td>
<td colspan="1"><span style="color: rgb(0,0,0);">The cash account corresponds to the payment method that is mapped to the store&rsquo;s payment methods used for the purchase and the transaction currency of the sales order.</span></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1">Description</td>
<td colspan="1"><span>Payments and Applications&gt;<span>Description</span></span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">DocDesc</td>
<td colspan="1"><span>ARPayment</span></td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; Description</span></td>
<td colspan="1"><span style="color: rgb(0,0,0);">Default:&nbsp;</span><em>WooCommerce; Payment Method: &lt;the <span>payment_method_title </span>used for purchase&gt;; Order: &lt;id (order)&gt;; Payment ID<span style="color: rgb(0,0,0);">: &lt;transaction_id&gt;</span></em></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1">Branch</td>
<td colspan="1"><span>Payments and Applications&gt;Financial Details tab</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">BranchID</td>
<td colspan="1"><span>ARPayment</span></td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; BranchID</span></td>
<td colspan="1"><span style="color: rgb(0,0,0);">The branch specified in the&nbsp;</span><strong>General</strong><span style="color: rgb(0,0,0);">&nbsp;section on the&nbsp;</span><strong>Order Settings</strong><span style="color: rgb(0,0,0);">&nbsp;tab of the&nbsp;<span style="color: rgb(0,0,0);">WooCommerce Stores</span></span><span style="color: rgb(0,0,0);">&nbsp;form.</span></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1">Status</td>
<td colspan="1"><span>Payments and Applications&gt;Status</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">Status</td>
<td colspan="1"><span>ARPayment</span></td>
<td colspan="1">ARPayment</td>
<td colspan="1"><span>Payments-&gt; Status</span></td>
<td colspan="1"><span style="color: rgb(0,0,0);">The status depends on the state of the&nbsp;</span><strong>Release Payment</strong><span style="color: rgb(0,0,0);">&nbsp;check box in the row of the payment method in the&nbsp;</span><strong>Base Currency Payment Methods</strong><span style="color: rgb(0,0,0);">&nbsp;table on the&nbsp;</span><strong>Payment Methods</strong><span style="color: rgb(0,0,0);">&nbsp;tab of the&nbsp;<span style="color: rgb(0,0,0);">WooCommerce Stores</span></span><span style="color: rgb(0,0,0);">&nbsp;form. If the check box is selected, the status is&nbsp;</span><em>Open</em><span style="color: rgb(0,0,0);">&nbsp;(meaning that the payment is released). If the check box is cleared, the status is&nbsp;</span><em>Balanced</em><span style="color: rgb(0,0,0);">&nbsp;(indicating that the payment is not released).</span></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<th colspan="11">Credit Card Processing Info</th></tr>
<tr>
<td colspan="1"><strong>Tran. Nbr.</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">TranNbr</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span style="color: rgb(0,0,0);">The number assigned by Acumatica ERP to identify a record about a transaction operation, which is added, for example, when you click&nbsp;</span><strong>Capture</strong><span style="color: rgb(0,0,0);">&nbsp;on the form toolbar or click the&nbsp;</span><strong>Authorize</strong><span style="color: rgb(0,0,0);">&nbsp;action.</span></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>Proc. Center</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">Y</td>
<td colspan="1">ProcessingCenterID</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">
<p><span style="color: rgb(0,0,0);">The processing center that processed the transaction operation.</span></p>
<p>The value should be fetched from the WooCommerce Stores screen&gt;Payment tab&gt;Payment Method Mapping table&gt; Proc. Center column mapped.</p></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>Tran. Type</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">TranType</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">
<p><span>When using <a href="http://Authorized.net">Authorized.net</a> (Skyverge) plugin following WC Order API tags are used to identify the Transaction Type,</span></p>
<p>Refer below mapping to identify logic related to transactions types.</p></td>
<td colspan="1">
<p>&quot;_wc_authorize_net_cim_credit_card_charge_captured&quot;,&quot;value&quot;</p>
<p>or</p>
<p>&quot;_wc_authorize_net_cim_credit_card_capture_trans_id&quot;</p></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>Tran. Status</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">TranStatus</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span style="color: rgb(0,0,0);">Since Order API sends the status of the approved transaction, it should use the &quot;Approved&quot; status </span></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>Tran. Amount</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">Amount</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span style="color: rgb(0,0,0);">The amount of the transaction.</span></td>
<td colspan="1"><span>total</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>Expire On (Est.)</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">FundHoldExpDate</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">
<p><span style="color: rgb(0,0,0);">The estimated date on which the funds hold of active pre-authorization of the external transaction will expire.</span><br /><span style="color: rgb(0,0,0);">This column appears on the form if the transaction has the&nbsp;</span><em>Authorize Only</em><span style="color: rgb(0,0,0);">&nbsp;type specified in the&nbsp;</span><strong>Tran. Type</strong><span style="color: rgb(0,0,0);">&nbsp;column of the current tab.</span></p>
<p><span style="color: rgb(0,0,0);">This value not available in the WC Order API, therefore, not considered.</span></p></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>Proc. Center Tran. Nbr.</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">PCTranNumber</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span style="color: rgb(0,0,0);">The number assigned by the processing center to uniquely identify a transaction.</span></td>
<td colspan="1">&quot;transaction_id&quot;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>Proc. Center Auth. Nbr.</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">AuthNumber</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span style="color: rgb(0,0,0);">The authorization number returned for the transaction by the processing center.</span></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>Proc. Center Response Reason</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">PCResponseReasonText</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">
<p><span style="color: rgb(0,0,0);">The response received for the transaction operation from the processing center.</span></p>
<p><span style="color: rgb(0,0,0);">Value &quot;Imported External Transaction&quot; should be used.</span></p></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>Tran. Time</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">Y</td>
<td colspan="1">StartTime</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span style="color: rgb(0,0,0);">The time when the transaction operation was performed.</span></td>
<td colspan="1">&quot;date_paid&quot;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>Proc. Status</strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">ProcStatus</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span style="color: rgb(0,0,0);">The status of the processing of the transaction operation, such as&nbsp;</span><em>Open</em><span style="color: rgb(0,0,0);">,&nbsp;</span><em>Completed</em><span style="color: rgb(0,0,0);">, or&nbsp;</span><em>Error</em><span style="color: rgb(0,0,0);">. In this case, it should be <em>Completed.</em></span></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td colspan="1"><strong>CVV Verification <strong>(<span style="color: rgb(32,33,36);">Card Verification Value)</span></strong></strong></td>
<td colspan="1"><span>Payments and Applications&gt; Credit Card Processing Info</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">CVVVerificationStatus</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">Following status is used when processing the CC transaction for the first time,<br />
<ul class="wikibulletlist" style="margin-left: 3.0em;">
<li class="wikibullet"><em>Required but Not Verified</em>: CVV verification was used, but the CVV code could not be verified.</li></ul>
<p class="wikibullet">After the first time, the following status is used,</p>
<ul class="wikibulletlist" style="margin-left: 3.0em;">
<li class="wikibullet"><em>Skipped Due to Prior Verification</em>: The CVV code had been verified previously and was skipped for the current operation.</li></ul></td>
<td colspan="1"><span>N/A</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td></tr></tbody></table>
<h2>CC Transaction Type Identification Logic</h2>
<table>
<tbody>
<tr>
<th colspan="1">Payment Status</th>
<th>Processing Status</th>
<th>CC Transaction Type</th>
<th colspan="6">Description</th>
<th>Logic</th></tr>
<tr>
<td colspan="1">Pending Processing</td>
<td>Pre-Authorized</td>
<td>Authorize Only</td>
<td colspan="6">The payment was authorized when the order was placed but has not yet been captured.</td>
<td>&quot;key&quot;: &quot;_wc_authorize_net_cim_credit_card_charge_captured&quot;,&quot;value&quot;: &quot;<strong>no</strong>&quot;</td></tr>
<tr>
<td rowspan="2">Balanced</td>
<td rowspan="2">Captured</td>
<td>Authorize and Capture</td>
<td colspan="6">The payment was captured when the order was placed</td>
<td>&quot;key&quot;: &quot;_wc_authorize_net_cim_credit_card_charge_captured&quot;,<br /> &quot;value&quot;: &quot;<strong>yes</strong>&quot;<br /> And following tag is not avaible in Order API, &quot;_wc_authorize_net_cim_credit_card_capture_trans_id&quot;,</td></tr>
<tr>
<td>Capture Authorized</td>
<td colspan="6">The payment was authorized when the order was placed, and then the funds were captured in the control panel of the store.</td>
<td>&quot;key&quot;: &quot;_wc_authorize_net_cim_credit_card_charge_captured&quot;,<br /> &quot;value&quot;: &quot;<strong>yes</strong>&quot;<br /> <br /> &quot;key&quot;: &quot;_wc_authorize_net_cim_credit_card_capture_trans_id&quot;,<br /> &quot;value&quot;: &quot;<strong>60168297151</strong>&quot; (This tag is only available for Capture Authorised trans types only)</td></tr></tbody></table>
