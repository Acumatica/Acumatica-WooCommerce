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
<td>Development completed for M1</td>
<td colspan="1">Development completed</td></tr></tbody></table>
<p>&nbsp;</p>
<h2>WooCommerce Store Screen Settings</h2>
<p><span style="color: rgb(0,0,0);">Below settings used to define the settings for the import of payments.&nbsp;</span></p>

![Screenshot](/Documentation/Specifications/Spec%20Images/Payments1.png)

<p><span style="color: rgb(0,0,0);">&nbsp;</span></p>
<h2 class="wikiH1 separator">Payment Settings Section</h2>
<p class="wikiH1 separator">On this tab, you map the payment methods configured in the WooCommerce store with the payment methods defined in Acumatica ERP, as well as specify the cash accounts that should be used for transactions in currencies other than the base currency.</p>
<h2 class="wikiH2 separator">Base Currency Payment Methods Table</h2>
<p class="wikiH2 separator">This table is to map the payment methods defined in the WooCommerce store with the payment methods and base-currency cash accounts defined in Acumatica ERP. The&nbsp;<strong style="font-size: 14.0px;">Store Payment Method</strong><span style="font-size: 14.0px;">&nbsp;column is populated based on the settings from the WooCommerce store when the correct API credentials are entered and saved on the&nbsp;</span><strong style="font-size: 14.0px;">Connection Settings</strong><span style="font-size: 14.0px;">&nbsp;tab.</span></p>
<p class="wikiH2 separator"><span style="font-size: 14.0px;">&nbsp;</span>The table toolbar includes only standard buttons. For the list of standard buttons,&nbsp;</p>
<table>
<tbody>
<tr>
<th>Column</th>
<th>Description</th></tr>
<tr>
<td><strong>Active</strong></td>
<td>A check box that indicates (if selected) that payment processing is enabled for the payment method.<br />If this check box is cleared for a payment method, when an order is placed in the WooCommerce store and this payment method is selected at checkout, the corresponding payment is not imported from the WooCommerce store to Acumatica ERP.<br />This check box is cleared by default.</td></tr>
<tr>
<td><strong>Store Payment Method</strong></td>
<td>The payment method defined in the WooCommerce store. This column is populated automatically. However, you can manually add additional mappings of payment options, if necessary.<br />The system populates the table with the following store payment methods even if these store payment methods have not been configured in the WooCommerce store:</td></tr>
<tr>
<td><strong>Payment Method ID</strong></td>
<td>The identifier of the payment method in Acumatica ERP that corresponds to the store payment method.</td></tr>
<tr>
<td><strong>Cash Account</strong></td>
<td>The cash account associated with the payment method in Acumatica ERP. Only cash accounts in the base currency can be selected.<br />Cash accounts in other currencies can be specified in the&nbsp;<strong>Multiсurrency Cash Accounts</strong>&nbsp;table.</td></tr>
<tr>
<td><strong>Proc. Center ID</strong></td>
<td>The processing center configured in Acumatica ERP for the card-based payment method selected in the&nbsp;<strong>Payment Method ID</strong>&nbsp;column and the cash account in the base currency selected in the&nbsp;<strong>Cash Account</strong>&nbsp;column.</td></tr>
<tr>
<td><strong>Currency</strong></td>
<td>The identifier of the currency of the cash account.<br />This column is not available for editing. The system inserts the currency when the cash account is selected in the&nbsp;<strong>Cash Account</strong>&nbsp;column.</td></tr>
<tr>
<td><strong>Release Payments</strong></td>
<td>A check box that you select to indicate that payments should be automatically released as soon as they are imported to Acumatica ERP. If this check box is selected for a card-based payment method associated with a credit card processing center in Acumatica ERP (that is, for the payment method for which a processing center is selected in the&nbsp;<strong>Proc. Center ID</strong>&nbsp;colu<span style="color: rgb(0,0,0);">mn), only payments that have been captured in the store will be automatically released on import.</span></td></tr>
<tr>
<td><strong>Process Refunds</strong></td>
<td><span style="color: rgb(0,0,0);">A check box that you select to indicate that refunds issued in the store for an offline payment method should be imported to Acumatica ERP. (Implement with the Refunds entity)</span></td></tr></tbody></table>
<p class="wikiH2 separator"><strong>Create Payment from Order</strong> feature (available in the BigComemerce) is not considered here because in WC payment sync,payment-related data is fetching from the WC Order API and WC does not have a separate API for the payment.</p>
<h2 class="wikiH2 separator">Multiсurrency Cash Accounts Table</h2>
<p class="wikiH2 separator">This table is to select additional cash accounts for transactions in <strong>currencies other than the base currency</strong>. For each non-base currency used in store transactions, the user should specify an <strong>additional cash account.</strong> To do this, you add a row and select the appropriate cash account; the system automatically fills in the applicable currency. This table is displayed only if the&nbsp;<em style="font-size: 14.0px;">Multicurrency Accounting</em><span style="font-size: 14.0px;">&nbsp;feature is enabled on the&nbsp;</span><a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(46))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=c1555e43-1bc5-4f6f-ba9d-b323f94d8a6b">Enable/Disable Features</a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=CS100000">CS100000</a>) form.</p>
<p class="wikiH2 separator"><span style="font-size: 14.0px;">&nbsp;</span>The table toolbar includes only standard buttons. For the list of standard buttons,</p>
<p><span style="color: rgb(0,0,0);">&nbsp;</span></p>
<table>
<tbody>
<tr>
<th>Column</th>
<th>Description</th></tr>
<tr>
<td><strong>Cash Account</strong></td>
<td>An additional cash account to be used when an order with a payment is imported from the WooCommerce store to Acumatica ERP if the payment method used for the purchase is mapped in the&nbsp;<strong>Base Currency Payment Methods</strong>&nbsp;table and is active, and currency of the transaction is different than the base currency.</td></tr>
<tr>
<td><strong>Currency</strong></td>
<td>The identifier of the non-base currency of the cash account.<br />The system fills in the currency identifier when you select a cash account. This column is not available for editing.</td></tr>
<tr>
<td><strong>Proc. Center ID</strong></td>
<td>The processing center configured in Acumatica ERP for the card-based payment method selected in the&nbsp;<strong>Payment Method ID</strong>&nbsp;column of the&nbsp;<strong>Base Currency Payment Methods</strong>&nbsp;table and the cash account in the non-base currency selected in the&nbsp;<strong>Cash Account</strong>&nbsp;column of this table.</td></tr></tbody></table>


