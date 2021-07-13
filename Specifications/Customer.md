***Customer Import***
<p>Status: Completed</p>
<table>
<thead>
<tr>
<th>
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">Version</div></div></th>
<th>
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">Description</div></div></th>
<th colspan="1">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">&nbsp;Status</div></div></th></tr></thead>
<tbody>
<tr>
<td>1.0</td>
<td>Development completed for M1</td>
<td colspan="1">Completed</td></tr></tbody></table>

<p><ac:structured-macro ac:macro-id="3aab4f84-b5d4-485e-918b-496e6a0fc15f" ac:name="toc" ac:schema-version="1" /></p>
<h2>WooCommerce Store Customer Settings&nbsp;</h2>
<p>New Screen &quot;BC201020&quot; will be created tor the WooCommerce Store.</p>
<p>The following shows the customer settings needed for the Acumatica WooCommerce connector. These settings will define values when syncing customers with the WooCommerce store.</p>
<p>&nbsp;</p>
<p><strong>WooCommerce Stores&gt; Customer Settings</strong></p>

![Screenshot](/Specifications/Spec%20Images/Customer1.png)

<h3><strong>Customer Class&nbsp;</strong></h3>
<p><span style="color: rgb(0,0,0);">The customer class that is assigned to new customers imported to Acumatica ERP from the WooCommerce store and thus used to provide their default settings.</span></p>
<h3><strong>Customer Autonumbering</strong><span style="color: rgb(0,0,0);">&nbsp;</span></h3>
<p><span style="color: rgb(0,0,0);">The user selects the numbering sequences to be used for generating identifiers for imported customers.</span></p>
<h3><span style="color: rgb(0,0,0);"><strong>Customer Numbering Template</strong></span></h3>
<p><span style="color: rgb(0,0,0);">If the company uses segmented keys that consist of multiple segments for customers, it is necessary to also specify the numbering templates in the&nbsp;</span><strong>Customer Numbering Template</strong><span style="color: rgb(0,0,0);">&nbsp;box and indicate which of the key segments should be auto-numbered.</span></p>
<h3><strong><span style="color: rgb(0,0,0);">Generic Guest Customer</span></strong></h3>
<p><span style="color: rgb(0,0,0);"><span style="color: rgb(0,0,0);">The generic customer account that appears on imported sales orders that were placed in the WooCommerce store as guest orders. This customer account is not exported to the WooCommerce store during the synchronization of customers.</span></span></p>
<h3><span style="color: rgb(0,0,0);">Customer Location</span></h3>
<p><span style="color: rgb(0,0,0);">WooCommerce does not support customer locations. Therefore, customer <strong>Location Autonumbering</strong> and <strong>Location Numbering Template </strong>settings were skipped in the WooCommerce store Customer Settings compared to other connectors.</span></p>
<p>&nbsp;</p>
<p></p>
<h3>Handling Customer Duplicates</h3>
<p><strong>Duplicates Merge by Email</strong></p>
<table>
<tbody>
<tr>
<th colspan="1">Considered Object</th>
<th>BigCommerce</th>
<th>Shopify</th></tr>
<tr>
<td colspan="1">Email Address</td>
<td>BC only have one email address on the &quot;<span style="color: rgb(52,49,63);">Customer Details&quot; section this will be taken to General/ Billing/ Shipping tabs in AC.</span></td>
<td><span>SH only have one email address on the &quot;</span><span style="color: rgb(52,49,63);">Customer Details&quot; section this will be taken to General/ Billing/ Shipping tabs in AC.</span></td></tr></tbody></table>
<p>In WC, it has separate email addresses for General and Billing objects. Therefore, the General email (Customer`s Contact Info section in WC) was mapped to the Primary Contact`s email address.</p>
<p>And to find the duplicate customers (the same customer coming from more than one store or from the same store) it is compared to the Billing email address in WC, which is mapped to the Main Contact in the AC.</p>
<p><strong>Reason</strong>: From the business perspective, all transactions are conducted using the Billing email address and documents are sent to the Billing email. Therefore, avoid duplicates Billing email address (mapped to MainContact) will be used, if the&nbsp;Billing email address is not available, the General email address mapped to Primary Contact is compared when importing customers from a WC Store.</p>
<p>If no email addresses are available (both email addresses are blank), a new customer will be created.</p>
<p>e.g: In&nbsp;<span>Shopify, a customer can be created without email, if the email is blank, even a customer can be created using an existing name, a new customer record will be created.</span></p>
<p><span><br /></span></p>
<p><strong>Duplicated Merge by Phone</strong></p>
<p><span style="color: rgb(0,0,0);">WC does not support Customer filtering by Phone</span></p>
<h3>When Customer Record has only the First Name</h3>
<table>
<tbody>
<tr>
<th colspan="1">Considered Object</th>
<th><span>BigCommerce</span></th>
<th><span>Shopify</span></th></tr>
<tr>
<td colspan="1">First Name</td>
<td>To save a customer record First Name, Last Name and Email address are mandatory.</td>
<td>To save customer record even First Name is enough and it is saved as the last name of the primary contact.</td></tr></tbody></table>
<p>In WC, a Customer record can be created with the User Name and the email address. Therefore following business logic should be applied,</p>
<p>First_Name and Last_Name are available for the customer importing from WC, those should be mapped to Last Name and Last Name fields in the Primary Contact.</p>
<p>When only the&nbsp;Last_Name is available&nbsp;for the customer importing from WC, that should be used as the&nbsp;Last Name field in the Primary Contact (similar to the Shopify approach).</p>
<p>When&nbsp;First_Name and Last_Name are not available user_name should be mapped to the&nbsp;Last Name field in the Primary Contact.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
