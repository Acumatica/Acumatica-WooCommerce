***Sales Order Import***
<p>Status:&nbsp;<span>Completed</span></p>
<table>
<thead>
<tr>
<th>
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">Version</div></div></div></th>
<th>
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">Description</div></div></div></th>
<th colspan="1">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">
<div class="tablesorter-header-inner">&nbsp;Status</div></div></div></th></tr></thead>
<tbody>
<tr>
<td>1.0</td>
<td>Development completed for M1</td>
<td colspan="1">Completed</td></tr></tbody></table>
<p><ac:structured-macro ac:macro-id="97077dbe-a89e-4b44-b2f5-447979bec381" ac:name="toc" ac:schema-version="1" /></p>
<h2>WooCommerce Store Screen Settings</h2>
<p><span style="color: rgb(0,0,0);">Below settings used to define the default settings for the import of sales orders. And also map shipping zones and shipping rules between Acumatica ERP and the WooCommerce store, and specify if taxes should be synchronized between the two systems.</span></p>

![Screenshot](/Documentation/Specifications/Spec%20Images/SO1.png)

<p>&nbsp;</p>
<h2 class="wikiH2 separator">General Section</h2>
<div class="section sH2" style="margin-left: 2.0em;">
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<th>Element</th>
<th>Description</th></tr>
<tr>
<td><strong>Branch</strong></td>
<td>The branch that is inserted in the sales orders and payments imported to Acumatica ERP from the WooCommerce store.</td></tr></tbody></table>
<p>&nbsp;</p></div>
<h2 class="wikiH2 separator">Order Section</h2>
<div class="section sH2" style="margin-left: 2.0em;">
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<th>Element</th>
<th>Description</th></tr>
<tr>
<td><strong>Order Type for Import</strong></td>
<td>The order type in Acumatica ERP that is assigned to imported sales orders to indicate that the orders have originated in the WooCommerce store.</td></tr>
<tr>
<td><strong>Order Types for Export</strong></td>
<td>
<ul>
<li><em>This will be considered at the stage of Sales Order Export.</em></li></ul>
<p>The types of orders in Acumatica ERP to be exported to the WooCommerce store.<br />Orders of these types are exported to the WooCommercestore only if the synchronization direction of the&nbsp;<em>Sales Order</em>&nbsp;entity is set to&nbsp;<em>Export</em>&nbsp;or&nbsp;<em>Bidirectional</em>&nbsp;for that store on this form or on the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(50))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_Commerce&amp;PageID=4cde0075-c943-4f6a-b8be-ac265121b79b">Entities</a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=BC202000">BC202000</a>) form.<br />This box is available<span style="color: rgb(0,0,0);"> only if the&nbsp;<em>Custom Order Types</em>&nbsp;feature</span> is enabled on the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(50))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=c1555e43-1bc5-4f6f-ba9d-b323f94d8a6b">Enable/Disable Features</a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=CS100000">CS100000</a>) form.</p></td></tr>
<tr>
<td><strong>Return Order Type</strong></td>
<td>The order type that the system will use as a source of default settings for creating a retu<span style="color: rgb(0,0,0);">rn order when a refund is issued in the W</span>ooCommerce store. User should be able to select only an order type with the following settings on the&nbsp;<strong>Template Settings</strong>&nbsp;tab of the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(50))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=e6984218-4260-4438-99e1-aee2b3765369">Order Types</a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=SO201000">SO201000</a>) form:<a class="wikilink anchorlink"></a>
<ul class="wikibulletlist" style="margin-left: 3.0em;">
<li class="wikibullet"><strong>Automation Behavior</strong>:&nbsp;<em>RMA Order</em></li>
<li class="wikibullet"><strong>Default Operation</strong>:&nbsp;<em>Receipt</em></li>
<li class="wikibullet"><strong>AR Document Type</strong>:&nbsp;<em>Credit Memo</em></li></ul>
<p class="wikibullet"><em>This will be considered in Milestone 2 release.</em></p></td></tr>
<tr>
<td><strong>Refund Amount Item</strong></td>
<td>
<p>The non-stock item is <span style="color: rgb(0,0,0);">used to represent a refund amount in an imported sales order. The non-stock item selected in this box is excluded from synchronization and is not exported when the&nbsp;<em>Non-Stock Item</em>&nbsp;entity is synchronized. The non-stock item representing refund amounts should be exempt from taxes (that is, on the&nbsp;<strong>General</strong>&nbsp;tab of the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(50))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=bf68dd4f-63d4-460d-8dc0-9152f2bd6bf1"><span style="color: rgb(0,0,0);">Non-Stock Items</span></a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=IN202000"><span style="color: rgb(0,0,0);">IN202000</span></a>) form, in the&nbsp;<strong>Tax Category</strong>&nbsp;box, a category corresponding to tax-exempt items should be assigned). Also on this tab, the&nbsp;<strong>Require Receipt</strong>&nbsp;and&nbsp;<strong>Require Shipment</strong>&nbsp;check boxes must be cleared for the item.</span></p>
<p><span style="color: rgb(0,0,0);"><em>This will be considered in Milestone 2 release.</em></span></p></td></tr>
<tr>
<td><strong>Refund Reason Code</strong></td>
<td>
<p>The reason code that the system will insert in each return order line for a refund or return imported from the WooCommerce store. The reason code must have the&nbsp;<span style="color: rgb(0,0,0);"><em>Issue</em>&nbsp;</span>usage type specified on the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(50))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=fe53f1bf-3670-465e-8b7c-922d8246f123">Reason Codes</a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=CS211000">CS211000</a>) form.</p>
<p><em>This will be considered in Milestone 2 release.</em></p></td></tr>
<tr>
<td><strong>Order Time Zone</strong></td>
<td>The time zone the system will use for each sales order imported from the WooCommercestore when it is created in Acumatica ERP. The order time zone is needed to determine the correct date and time of the order if Acumatica ERP and the WooCommerce store are located in different time zones.</td></tr>
<tr>
<td><strong>Show Discounts In</strong></td>
<td>The level on which discounts appear in each sales order imported from WooCommerce. User can select either of the following options:<a class="wikilink anchorlink"></a>
<ul class="wikibulletlist" style="margin-left: 3.0em;">
<li class="wikibullet"><em>Line Discount</em>: Discounts applied to the order are distributed between the sales order lines and appear in the&nbsp;<strong>Discount Amount</strong>&nbsp;column on the&nbsp;<strong>Document Details</strong>&nbsp;tab of the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(50))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=19e4021c-1b84-49fd-be12-0320c5f1c7e5">Sales Orders</a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=SO301000">SO301000</a>) form.</li>
<li class="wikibullet"><em>Document Discount</em>: Discounts applied to the order are aggregated and displayed on the&nbsp;<strong>Discount Details</strong>&nbsp;tab of the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(50))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=19e4021c-1b84-49fd-be12-0320c5f1c7e5">Sales Orders</a>&nbsp;form.<br /><br /></li></ul>
<div class="GrayBox WarnBox">
<p><span>For document discounts to be imported correctly, the&nbsp;</span><em>Customer Discounts</em><span>&nbsp;feature must be enabled on the&nbsp;</span><a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(50))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=c1555e43-1bc5-4f6f-ba9d-b323f94d8a6b">Enable/Disable Features</a><span>&nbsp;(</span><a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=CS100000">CS100000</a><span>) form.</span></p>
<p>&nbsp;</p></div></td></tr>
<tr>
<td><strong>Gift Certificate Item</strong></td>
<td>
<p><s>The non-stock item in Acumatica ERP that is used to record the sale of gift certificates in the WooCommerce store. This item is excluded from synchronization (that is, it is not exported to the WooCommerce store during the synchronization of the&nbsp;<em>Non-Stock Item</em>&nbsp;entity).</s></p>
<p>Gift Certificate handling is an extension in WC, therefore, it was not considered in the mapping.</p></td></tr></tbody></table>
<p>&nbsp;</p></div>

<a href="https://github.com/Acumatica/Acumatica-WooCommerce/blob/2021R104/Documentation/Specifications/Discount%20Management.md"> Discounts/ Coupon Setup in WooCommerce</a>

<a href="https://github.com/Acumatica/Acumatica-WooCommerce/blob/2021R104/Documentation/Specifications/Tax%20Management.md"> Tax Management </a>

<a href="https://github.com/Acumatica/Acumatica-WooCommerce/blob/2021R104/Documentation/Specifications/Freight%20Management.md"> Freight Management</a>
