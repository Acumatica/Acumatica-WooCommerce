***Freight Management***
<p>Status: Completed </p>
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
<div class="tablesorter-header-inner">&nbsp;</div></div></div></th></tr></thead>
<tbody>
<tr>
<td>1.0</td>
<td>Draft</td>
<td colspan="1">Development completed </td></tr></tbody></table>
<p><ac:structured-macro ac:macro-id="97077dbe-a89e-4b44-b2f5-447979bec381" ac:name="toc" ac:schema-version="1" /></p>
<h2>Freight Management</h2>
<h3>Shipping Basic Data Concepts in WC &amp; AC</h3>

![Screenshot](/Specifications/Spec%20Images/Freight1.png)

<p>&nbsp;</p>
<p><strong>WC Shipping Basic Data/ Settings</strong></p>
<p>In WC any number of shipping zones can be created to denote geographical areas to where items to be shipped. And Shipping methods (more than one) can be assigned to a Shipping zone. In addition, when shipping classes are defined, there is the ability to define shipping cost at the shipping class level using the shipping method (e.g: Flat Rate). Eventually, a Shipping class can be assigned to a Product, so that the shipping cost will be calculated based on the shipping class &amp; shipping method connected.</p>
<p>&nbsp;</p>
<p><strong>AC Shipping&nbsp;<strong>Basic Data/ Settings</strong></strong></p>
<p>Ship Via, Shipping Terms &amp; Shipping Zone can be defined in the Customer Locations (AR303020) screen.</p>
<p>Ship Via &amp; Shipping Terms can be defined in the Customer Classes (AR201000) screen.</p>
<p>Ship Via Code on the sales order defines the <span style="color: rgb(0,0,255);">Freight Cost</span>.</p>
<p>To calculate the <span style="color: rgb(0,128,0);">Freight Price</span>, the system uses either default Shipping Term inherited from the Customers (AR303000)&nbsp;or shipping terms that user specify manually on the sales order. Freight price may include insurance, handling fees, or line handling fees.</p>
<h3>Shipping Settings in WooCommerce Stores Screen</h3>

![Screenshot](/Specifications/Spec%20Images/Freight2.png)

<p><span style="color: rgb(0,0,0);">In this table, users should be able to define the mapping of each shipping option (which is a <strong>combination of a shipping zone and shipping method</strong>) defined in WooCommerce to the ship via code, and <strong>optionally</strong>, shipping zone and shipping terms defined in Acumatica ERP.&nbsp;</span></p>
<p>The&nbsp;<strong>Store Shipping Zone</strong>&nbsp;and&nbsp;<strong>Store Shipping Method</strong>&nbsp;columns of the table are populated with the settings from WooCommerce when the correct API credentials are entered and saved on the&nbsp;<strong>Connection Settings</strong>&nbsp;tab. The list of mappings can be updated in the following ways:<a class="wikilink anchorlink"></a></p>
<ul class="wikibulletlist" style="margin-left: 3.0em;">
<li class="wikibullet">The system automatically adds the shipping options (store shipping zones and store shipping methods) to the table or removes them from the table based on the shipping options that are active in the WooCommerce store. You can make changes to the settings in the&nbsp;<strong>Ship Via</strong>,&nbsp;<strong>Shipping Zone</strong>, and&nbsp;<strong>Shipping Terms</strong>&nbsp;columns. However, you cannot remove the automatically added shipping options by using the&nbsp;<strong>Delete Row</strong>&nbsp;button on the table toolbar.<br /><span style="color: rgb(255,0,0);">How to popular data into this table in the initial sync?</span></li>
<li class="wikibullet">You can manually add rows for active shipping options in the WooCommerce store by using the&nbsp;<strong>Add Row</strong>&nbsp;button on the table toolbar; you can also delete the manually added rows by using the&nbsp;<strong>Delete Row</strong>&nbsp;button on the table toolbar.</li>
<li class="wikibullet">The system automatically adds a shipping option to the table if, during the <span style="color: rgb(255,0,0);">sales order import</span>, the shipping zone and the shipping method specified in a particular sales order <span style="color: rgb(255,0,0);">is missing from the table</span>.</li></ul>
<p class="wikibullet"><u><strong>Field Descriptions</strong></u></p>
<table>
<tbody>
<tr>
<th>Column</th>
<th>Description</th></tr>
<tr>
<td><span style="color: rgb(255,0,0);"><strong>Store Shipping Zone</strong></span></td>
<td>The shipping zone that has been set up in the WooCommerce store.</td></tr>
<tr>
<td><strong>Store Shipping Method</strong></td>
<td>The shipping method for the specified shipping zone that has been set up in the WooCommerce store.<br />For each store shipping zone, one of the values in this column is always&nbsp;<em>None</em>&nbsp;even though this shipping method does not exist in the WooCommerce store.</td></tr>
<tr>
<td><strong>Ship Via</strong></td>
<td>The ship via code in Acumatica ERP is mapped to the combination of the store shipping zone and the store shipping method. The value selected in this column is assigned to orders imported into Acumatica ERP and is displayed on the&nbsp;<strong>Shipping Settings</strong>&nbsp;tab of the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(45))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=19e4021c-1b84-49fd-be12-0320c5f1c7e5">Sales Orders</a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=SO301000">SO301000</a>) form for these orders.</td></tr>
<tr>
<td><strong>Shipping Zone</strong></td>
<td>The identifier of the shipping zone in Acumatica ERP, which is defined on the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(45))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=cd4ddbe1-9bc3-460c-a9b5-050a05a9b2a3">Shipping Zones</a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=CS207510">CS207510</a>) form, that is mapped to the combination of the store shipping zone and the store shipping method. The value selected in this column is assigned to each sales order imported to Acumatica ERP with the store shipping zone and store shipping method specified in this row. This value is also inserted on the&nbsp;<strong>Shipping Settings</strong>&nbsp;tab of the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(45))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=19e4021c-1b84-49fd-be12-0320c5f1c7e5">Sales Orders</a>&nbsp;form for the sales order.<br />This value is <span style="color: rgb(255,0,0);">optional</span>. If the user leaves it empty, the&nbsp;<strong>Shipping Zone</strong>&nbsp;box on the&nbsp;<strong>Shipping Settings</strong>&nbsp;tab of the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(45))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=19e4021c-1b84-49fd-be12-0320c5f1c7e5">Sales Orders</a>&nbsp;form will not be populated when a sales order with the store shipping zone and store shipping method specified in the row is imported.</td></tr>
<tr>
<td><strong>Shipping Terms</strong></td>
<td>
<p>The identifier of the shipping terms in Acumatica ERP, which is defined on the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(45))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=705d3726-b8f8-4c96-8562-1b475d2fb653">Shipping Terms</a>&nbsp;(<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/?ScreenId=CS208000">CS208000</a>) form, that is mapped to the combination of the store shipping zone and store shipping method. The value selected in this column is assigned to each sales order imported to Acumatica ERP with the store shipping zone and store shipping method specified in this row. This value is also inserted in the&nbsp;<strong>Shipping Terms</strong>&nbsp;box on the&nbsp;<strong>Shipping Settings</strong>&nbsp;tab of the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(45))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=19e4021c-1b84-49fd-be12-0320c5f1c7e5">Sales Orders</a>&nbsp;form for the sales order.</p>
<p>This value is <span style="color: rgb(255,0,0);">optional</span>. If the user leaves it empty, the&nbsp;<strong>Shipping Terms</strong>&nbsp;box on the&nbsp;<strong>Shipping Settings</strong>&nbsp;tab of the&nbsp;<a class="wikilink pagelink" href="http://dlk1pde165/AcumaticaDB21R1Beta2/(W(45))/Wiki/ShowWiki.aspx?wikiname=HelpRoot_FormReference&amp;PageID=19e4021c-1b84-49fd-be12-0320c5f1c7e5">Sales Orders</a>&nbsp;form will not be populated when a sales order with the store shipping zone and store shipping method specified in the row is imported.</p></td></tr></tbody></table>
<h3>Business Logic - Fetching Freight Price</h3>
<ul>
<li>Shipping Term available in the Sales Order and Shipping Term (<strong>Invoice Freight Price Based On =&nbsp;<em>Shipment</em><span style="color: rgb(0,0,0);">&nbsp;)</span></strong><span style="color: rgb(0,0,0);">&gt; Freight Amount should be mapped to the &quot; Premium Freight Price&quot;&nbsp;</span></li>
<li>Shipping Term available in the Sales Order and Shipping Term (<strong>Invoice Freight Price Based On = S<em>ales Order</em><span style="color: rgb(0,0,0);">)</span></strong><span style="color: rgb(0,0,0);">&gt; Freight Amount should be mapped to the &quot;Freight Price&quot;&nbsp;<span style="color: rgb(0,0,0);">(with Override Freight Price)</span></span></li>
<li><span style="color: rgb(0,0,0);">Shipping Term not available in the Sales Order&gt;&nbsp;<span style="color: rgb(0,0,0);">Freight Amount should be mapped to the &quot;Freight Price&quot;&nbsp;<span style="color: rgb(0,0,0);">(with Override Freight Price)</span></span></span></li></ul>
<h3>Freight Management Configurations in WooCommerce (Reference Only)</h3>
<p><strong>Shipping Classes</strong></p>
<p><a href="https://docs.woocommerce.com/document/product-shipping-classes/?_ga=2.96408027.675806824.1615771092-1800054059.1612315574&amp;_gac=1.219325163.1612316890.CjwKCAiAjeSABhAPEiwAqfxURTR6woao1hOSwmWhGC9spVJApMU3k33p6wp4iMUywdYyI5lYdDDwvRoC22gQAvD_BwE">Shipping classes</a>&nbsp;can be used to&nbsp;group products of similar type&nbsp;and used by some shipping methods, such as Flat Rate Shipping, to provide different rates to different classes of product.</p>
<p>To add shipping classes, go to Settings&gt; Shipping tab&gt; Shipping Classes option</p>

![Screenshot](/Specifications/Spec%20Images/Freight3.png)

<p>Once the shipping class is added, and if the &quot;Flat Rate&quot; shipping method is used, the &quot;Edit&quot; option will be available in the related Shipping zones.</p>

![Screenshot](/Specifications/Spec%20Images/Freight4.png)

<p>Click on the &quot;Edit&quot; button to define shipping cost at the shipping class level.</p>

![Screenshot](/Specifications/Spec%20Images/Freight5.png)

<p><strong>Complex Shipping Rules</strong></p>
<p>Complex shipping rules are handled through the &quot;<a href="https://docs.woocommerce.com/document/table-rate-shipping/">Table Rate Shipping</a>&quot; extension. It was not considered in the development.</p>
<p>&nbsp;</p>
