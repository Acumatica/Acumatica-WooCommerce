
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
<div class="tablesorter-header-inner">&nbsp;</div></div></div></div></th></tr></thead>
<tbody>
<tr>
<td>1.0</td>
<td>Milestone 1</td>
<td colspan="1">Completed</td></tr></tbody></table>
<h2>Relationship between AC and WC Tax Concepts</h2>

![Screenshot](/Specifications/Spec%20Images/Tax1.png)

<h2>WooCommerce Stores Taxes Configuration</h2>

![Screenshot](/Specifications/Spec%20Images/Tax2.png)

<h2 class="wikiH2 separator">Taxes Section</h2>
<div class="section sH2" style="margin-left: 2.0em;">
<p>&nbsp;</p>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<th>Element</th>
<th>Description</th></tr>
<tr>
<td><strong>Tax Synchronization</strong></td>
<td>A check box that indicates (if selected) that taxes should be synchronized between Acumatica ERP and the WooCommerce store during the export or import of sales orders. <span style="color: rgb(255,102,0);"><strong>If the checkbox is not selected Tax is not synchronised to Acumatica.</strong></span></td></tr>
<tr>
<td><strong>Default Tax Zone</strong></td>
<td>The identifier of the tax zone that is assigned by default to each sales order imported to Acumatica ERP from the WooCommerce store if <span style="color: rgb(255,102,0);"><strong>no other tax zone has been identified</strong></span> during the import of the order.<br />The box is available if the&nbsp;<strong>Tax Synchronization</strong>&nbsp;check box is selected.</td></tr>
<tr>
<td><strong>Use as Primary Tax Zone</strong></td>
<td>A check box that you select to indicate that the tax zone selected in&nbsp;<span style="color: rgb(255,102,0);"><strong>Default Tax Zone</strong>&nbsp;should be assigned to each sales order i</span>mported to Acumatica ERP from the WooCommerce store,<span style="color: rgb(255,102,0);"> regardless of whether any other tax zone has been identified</span> during the import of the order.<br />This box is available if the&nbsp;<strong>Default Tax Zone</strong>&nbsp;is specified.</td></tr></tbody></table>
<p>&nbsp;</p></div>
<h2 class="wikiH2 separator">Substitution Lists Section</h2>
<div class="section sH2" style="margin-left: 2.0em;">
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<th>Element</th>
<th>Description</th></tr>
<tr>
<td><strong>Tax List</strong></td>
<td>The substitution list to be used for mapping tax IDs between Acumatica ERP and the WooCommerce store.<br />During the import of each sales order, if the system cannot find the tax ID specified in the order, it checks if there is a mapped tax ID in the substitution list specified in this box.<br />Substitution lists are defined on the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(15))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=e1b0125f-cb2f-4451-91af-c5eeaff3b5ac">Substitution Lists</a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=SM206026">SM206026</a>) form.</td></tr>
<tr>
<td><strong>Tax Category List</strong></td>
<td>The substitution list to be used for mapping tax categories Acumatica ERP with tax classes in the WooCommerce store.<br />During the import of a sales order, if the system cannot find the tax category specified in the order, it checks if there is a mapped tax category in the substitution list specified in this box.<br />Substitution lists are defined on the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(15))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=e1b0125f-cb2f-4451-91af-c5eeaff3b5ac">Substitution Lists</a>&nbsp;form.</td></tr></tbody></table>
<p>&nbsp;</p>
<p>Following Substitution lists should be created to sync tax classes and tax codes from WC to AC.</p>
<ul>
<li>WCCTAXCLASSES</li>
<li>WCCTAXCODES</li></ul></div>
<h3>Sales Order Form Business Logic for Taxes (Handled by Commerce Framework)</h3>
<p>Sales Order form Should support 2 additional scenarios only for CB API (Graph.IsContractBasedAPI)</p>
<h4>External Tax Sync</h4>
<p><em>Synchronize Automatically</em><span>: An external tax calculation service, such as Avalara AvaTax, is used for tax calculation.</span></p>
<p><span>In this scenario taxes for the eCommerce order are calculated by the external tax provider.<br />Here we assume that tax reporting is done from the external system, so we trust incoming taxes and we prioritize it.</span></p>
<p>SalesOrder.IsTaxValid = true &amp; TaxZone.IsExternal = true</p>
<ol>
<li>Do not trigger Acumatica logic to calculate taxes (performance optimization). Taxes should remain empty</li>
<li>For every line in&nbsp;<strong>TaxDetail</strong>&nbsp;API object&nbsp;- Validated if Tax Code (TaxID) exists in Acumatica (Substitution List).&nbsp;If Tax Code does not exist - create missing in Acumatica using following data
<ol>
<li>Tax ID&nbsp;takes from TaxDetail.TaxIDCB AP field.</li>
<li>Tax Description takes from TaxDetail.Description CB AP field.</li>
<li><span style="color: rgb(0,0,0);">Tax Schedule</span>&nbsp;remains empty</li>
<li>Tax Categories remains empty</li>
<li>Tax Zone - add zone from order</li>
<li>Tax Expense Account - take from Tax Agency</li>
<li>Tax Type - Sales Tax</li></ol></li>
<li>Insert every tax line from the&nbsp;<strong>TaxDetail</strong>&nbsp;API object to Order Taxes. Tax Amount and Taxable Amount should be inserted as-is.</li>
<li><s>If LineNumber is provided then Tax should be linked to the particular line.</s></li>
<li><s>if LineNumber is&nbsp;0, then this tax is related to Freight Price</s></li>
<li>Leave taxes in Valid state - do not recalculate taxes or call external tax providers (performance optimization).</li>
<li>Save Order</li></ol>
<h4>Manual Tax Sync</h4>
<p>In this scenario taxes for the eCommerce order are calculated by internal rules of the eCommerce Store.&nbsp;<br />Here we assume that tax reporting is done in Acumatica. Because of that, we need to re-validate all taxes settings to meet Acumatica Configurations.</p>
<p>SalesOrder.IsTaxValid = true &amp; TaxZone.IsExternal = false</p>
<ol>
<li>Do not trigger Acumatica logic to calculate taxes (performance optimization). Taxes should remain empty</li>
<li>For every line in&nbsp;<strong>TaxDetail</strong>&nbsp;API object&nbsp;- Validated that tax code exists in Acumatica (Substitution List). If tax code does not exist throw and error -&nbsp; &quot;TaxID&nbsp;{0} is not found in the system&quot;.</li>
<li>Insert every tax line from the&nbsp;<strong>TaxDetail</strong>&nbsp;API object to Order Taxes. Tax Amount and Taxable Amount should be inserted as-is.</li>
<li><s>If LineNumber is provided, then Tax should be linked to the particular line.</s></li>
<li><s>if LineNumber is&nbsp;0, then this tax is related to Freight Price</s></li>
<li>Leave taxes in Valid state - do not recalculate taxes or call external tax providers&nbsp;(performance optimization).</li>
<li>Save Order</li></ol>
<h4>No Tax&nbsp;Sync</h4>
<p>Order.IsTaxValid&nbsp; = false</p>
<ol>
<li>Use standard logic of Sales Order - no changes needed.</li></ol>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
