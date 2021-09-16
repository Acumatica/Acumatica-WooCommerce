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
<td>Milestone 1</td>
<td colspan="1">Completed</td></tr></tbody></table>
<p>&nbsp;</p>
<p><ac:structured-macro ac:macro-id="41ae7f82-7f0b-4c72-90d1-c30c3090dbb6" ac:name="toc" ac:schema-version="1" /></p>
<h2>Field Mapping Table</h2>
<table>
<tbody>
<tr>
<th colspan="8" style="text-align: center;">Acumatica (Target)</th>
<th colspan="3" style="text-align: center;">WooCommerce (Source)</th></tr>
<tr>
<th>Field Label</th>
<th colspan="1"><span>Acumatica Path</span></th>
<th colspan="1"><span>Mandatory</span></th>
<th>Column Name</th>
<th>Data Access Class</th>
<th colspan="1">Table</th>
<th>Framework</th>
<th>Comment</th>
<th>Field Name</th>
<th>Value Example</th>
<th colspan="1">WC Path</th></tr>
<tr>
<td>Ext Ref Nbr</td>
<td colspan="1"><span>Customer&gt;General&gt;Additional Account Info</span></td>
<td colspan="1">&nbsp;</td>
<td>AcctReferenceNbr</td>
<td>Customer</td>
<td colspan="1">&nbsp;</td>
<td>Customer&gt; AccountRef</td>
<td>id+&quot;-&quot;store_name<br />Important: The field may have content from another store. We don&rsquo;t override it but append id separating with a semicolon.</td>
<td>id</td>
<td>25</td>
<td colspan="1">Not visible from the store front-end</td></tr>
<tr>
<td>Customer ID</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">Y</td>
<td>AcctCD</td>
<td>Customer</td>
<td colspan="1"><span>BAccount</span></td>
<td>&nbsp;</td>
<td>Generated from Customer Autonumbering configuration</td>
<td>N/A</td>
<td>&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>Status</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">Y</td>
<td>Status</td>
<td><span>Customer</span></td>
<td colspan="1"><span>BAccount</span></td>
<td>&nbsp;</td>
<td>Set to 'Active'</td>
<td>N/A</td>
<td>&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>Customer Class</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">Y</td>
<td>CustomerClassID</td>
<td><span>Customer</span></td>
<td colspan="1"><span>BAccount</span></td>
<td>&nbsp;</td>
<td>Generated from Default Customer Class configuration for the store</td>
<td>N/A</td>
<td>&nbsp;</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>Account Email</td>
<td colspan="1"><span>Customer&gt;General&gt;</span><span>Primary Contact section</span></td>
<td colspan="1">&nbsp;</td>
<td>EMail</td>
<td>Contact</td>
<td colspan="1">&nbsp;</td>
<td>Customer&gt;PrimaryContact&gt;Email</td>
<td>Required email address saved in Contact Info section in WC</td>
<td>email</td>
<td><a href="mailto:john.doe@example.com">john.doe@example.com</a></td>
<td colspan="1">Users&gt;Contact Info&gt;Email (required)</td></tr>
<tr>
<td rowspan="2">Name</td>
<td rowspan="2"><span>Customer&gt;General&gt;Primary Contact section</span></td>
<td rowspan="2">Y</td>
<td rowspan="2">PrimaryContactID</td>
<td rowspan="2">Contact</td>
<td rowspan="2"><span>BAccount</span></td>
<td rowspan="2">Customer&gt;<span>PrimaryContact&gt;FullName</span></td>
<td rowspan="2">
<p>First_name +' '+ Last_name,</p>
<p>When only the <span>First_name is available it will be considered as the Last Name for the primary contact. (Since the Last Name is mandatory in AC) </span></p>
<p>*If the <span>Last_name</span> is not available '<span>username' will be taken.</span></p>
<p><span>(*This does not have a business Impact because when registering a customer to create an order in WC, <span>First_name &amp; <span>Last_name is mandatory. However, in WC customers can register only by giving user id and email address, but cannot create an order in WC)</span></span></span></p></td>
<td>first_name</td>
<td>John</td>
<td colspan="1"><span>Users&gt;Contact Info&gt;Name&gt;<span>First name</span></span></td></tr>
<tr>
<td>last_name</td>
<td>Doe</td>
<td colspan="1"><span>Users&gt;Contact Info&gt;Name&gt;<span>First name</span></span></td></tr>
<tr>
<td>&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>role</td>
<td>customer</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td>&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td>&nbsp;</td>
<td>&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td>&nbsp;</td>
<td>Not taken to Acumatica</td>
<td>username</td>
<td>john.doe</td>
<td colspan="1">&nbsp;</td></tr>
<tr>
<td class="highlight-grey" colspan="11" data-highlight-colour="grey"><strong>Billing </strong></td></tr>
<tr>
<td rowspan="2">Attention</td>
<td rowspan="2"><span>Contact&gt;Attention</span></td>
<td rowspan="2">&nbsp;</td>
<td rowspan="2">Attention</td>
<td rowspan="2">Contact</td>
<td rowspan="2"><span>Contact</span></td>
<td rowspan="2">Customer&gt;MainContact&gt;Attention</td>
<td rowspan="2">
<p>First_name +' '+ Last_name</p>
<p>If no values to the above fields empty, blank values should be fetched.</p></td>
<td>first_name</td>
<td>John</td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;First name</span></td></tr>
<tr>
<td>last_name</td>
<td>Doe</td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;Last name</span></td></tr>
<tr>
<td>Account Name</td>
<td colspan="1"><span>Customer&gt;General&gt;Account Info section</span></td>
<td colspan="1">&nbsp;</td>
<td>FullName</td>
<td>Contact</td>
<td colspan="1"><span>Contact</span></td>
<td>
<p>Customer&gt;<span>MainContact</span>&gt;</p>
<p>CompanyName</p></td>
<td>
<p>When &quot;company&quot; is null, Account Name should get the <span>First_name +' '+ Last_name (From <span>the Billing)</span></span></p>
<p><span><span>if the above values are null take the <span>username</span></span></span></p></td>
<td>company</td>
<td>&nbsp;</td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;<span style="color: rgb(29,35,39);">Company</span></span></td></tr>
<tr>
<td>Address Line 1</td>
<td colspan="1"><span>Customer&gt;General&gt;Account Address section</span></td>
<td colspan="1">&nbsp;</td>
<td>AddressLine1</td>
<td>Address</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;<span>MainContact</span>&gt;Address</td>
<td rowspan="6">&nbsp;</td>
<td>address_1</td>
<td>969 Market</td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;<span style="color: rgb(29,35,39);">Address line 1</span></span></td></tr>
<tr>
<td>Address Line 2</td>
<td colspan="1"><span>Customer&gt;General&gt;Account Address section</span></td>
<td colspan="1">&nbsp;</td>
<td>AddressLine2</td>
<td>Address</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;<span>MainContact</span>&gt;Address</td>
<td>address_2</td>
<td>&nbsp;</td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;<span style="color: rgb(29,35,39);">Address line 2</span></span></td></tr>
<tr>
<td>City</td>
<td colspan="1"><span>Customer&gt;General&gt;Account Address section</span></td>
<td colspan="1">&nbsp;</td>
<td>City</td>
<td>Address</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;<span>MainContact</span>&gt;Address</td>
<td>city</td>
<td>San Francisco</td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;<span style="color: rgb(29,35,39);">City</span></span></td></tr>
<tr>
<td>State</td>
<td colspan="1"><span>Customer&gt;General&gt;Account Address section</span></td>
<td colspan="1">&nbsp;</td>
<td>State</td>
<td>Address</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;<span>MainContact</span>&gt;Address</td>
<td>state</td>
<td>CA</td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;<span style="color: rgb(29,35,39);">State / County</span></span></td></tr>
<tr>
<td>Postal Code</td>
<td colspan="1"><span>Customer&gt;General&gt;Account Address section</span></td>
<td colspan="1">&nbsp;</td>
<td>PostalCode</td>
<td>Address</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;<span>MainContact</span>&gt;Address</td>
<td>postcode</td>
<td>94103</td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;<span style="color: rgb(29,35,39);">Postcode / ZIP</span></span></td></tr>
<tr>
<td>Country</td>
<td colspan="1"><span>Customer&gt;General&gt;Account Address section</span></td>
<td colspan="1">Y</td>
<td>CountryID</td>
<td>Address</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;Contact&gt;Address</td>
<td>country</td>
<td>US</td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;<span style="color: rgb(29,35,39);">Country / Region</span></span></td></tr>
<tr>
<td>EMail</td>
<td colspan="1"><span>Customer&gt;General&gt;Additional Account Info section</span></td>
<td colspan="1">&nbsp;</td>
<td>EMail</td>
<td>Contact</td>
<td colspan="1"><span>Contact</span></td>
<td>Customer&gt;<span>MainContact</span>&gt;Email</td>
<td>&nbsp;</td>
<td>email</td>
<td><a href="mailto:john.doe@example.com">john.doe@example.com</a></td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;<span style="color: rgb(29,35,39);">Email address</span></span></td></tr>
<tr>
<td>Business 1</td>
<td colspan="1"><span>Customer&gt;General&gt;Additional Account Info section</span></td>
<td colspan="1">&nbsp;</td>
<td>Phone1</td>
<td>Contact</td>
<td colspan="1"><span>Contact</span></td>
<td>Customer&gt;<span>MainContact</span>&gt;Phone1</td>
<td>&nbsp;</td>
<td>phone</td>
<td>(555) 555-5555</td>
<td colspan="1"><span>Users&gt;Customer billing address&gt;<span style="color: rgb(29,35,39);">Phone</span></span></td></tr>
<tr>
<td class="highlight-grey" colspan="11" data-highlight-colour="grey"><strong>Shipping </strong></td></tr>
<tr>
<td rowspan="2">Attention</td>
<td rowspan="2"><span>Customer&gt;Shipping&gt;Ship To Info section</span></td>
<td rowspan="2">&nbsp;</td>
<td rowspan="2">Attention</td>
<td rowspan="2">Contact</td>
<td rowspan="2"><span>Contact</span></td>
<td rowspan="2">
<p>Customer&gt;ShippingContact&gt;Attention</p></td>
<td rowspan="9">
<p>Refer below section &quot;<span style="color: rgb(0,0,0);">WooCommerce Address Mapping to Acumatica&quot;.</span></p>
<p><span style="color: rgb(0,0,0);">Fields in the Shipping object in the WC are mapped to fields in the &quot;Customer&gt;Shiiping tab&quot; in AC (one to one mapping)</span></p><br /><br /><br /><br /><br /><br /><br /><span style="color: rgb(0,0,0);">.</span></td>
<td>first_name</td>
<td>John</td>
<td colspan="1">Users&gt;Customer shipping address&gt;<span style="color: rgb(29,35,39);">First name</span></td></tr>
<tr>
<td>last_name</td>
<td>Doe</td>
<td colspan="1"><span>Users&gt;Customer shipping address&gt;<span style="color: rgb(29,35,39);">Last name</span></span></td></tr>
<tr>
<td>Account Name</td>
<td colspan="1"><span>Customer&gt;Shipping&gt;Ship To Info section</span></td>
<td colspan="1">&nbsp;</td>
<td>FullName</td>
<td>Contact</td>
<td colspan="1"><span>Contact</span></td>
<td>
<p>Customer&gt;ShippingContact&gt;</p>
<p>CompanyName</p></td>
<td>company</td>
<td>&nbsp;</td>
<td colspan="1"><span>Users&gt;Customer shipping address&gt;<span style="color: rgb(29,35,39);">Company</span></span></td></tr>
<tr>
<td>Address Line 1</td>
<td colspan="1"><span>Customer&gt;Shipping&gt;Ship To Address section</span></td>
<td colspan="1">&nbsp;</td>
<td>AddressLine1</td>
<td>Contact</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;ShippingContact&gt;Address</td>
<td>address_1</td>
<td>969 Market</td>
<td colspan="1"><span>Users&gt;Customer shipping address&gt;<span style="color: rgb(29,35,39);">Address line 1</span></span></td></tr>
<tr>
<td>Address Line 2</td>
<td colspan="1"><span>Customer&gt;Shipping&gt;Ship To Address section</span></td>
<td colspan="1">&nbsp;</td>
<td>AddressLine2</td>
<td>Contact</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;ShippingContact&gt;Address</td>
<td>address_2</td>
<td>&nbsp;</td>
<td colspan="1"><span>Users&gt;Customer shipping address&gt;<span style="color: rgb(29,35,39);">Address line 2</span></span></td></tr>
<tr>
<td>City</td>
<td colspan="1"><span>Customer&gt;Shipping&gt;Ship To Address section</span></td>
<td colspan="1">&nbsp;</td>
<td>City</td>
<td>Contact</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;ShippingContact&gt;Address</td>
<td>city</td>
<td>San Francisco</td>
<td colspan="1"><span>Users&gt;Customer shipping address&gt;<span style="color: rgb(29,35,39);">City</span></span></td></tr>
<tr>
<td>State</td>
<td colspan="1"><span>Customer&gt;Shipping&gt;Ship To Address section</span></td>
<td colspan="1">&nbsp;</td>
<td>State</td>
<td>Contact</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;ShippingContact&gt;Address</td>
<td>state</td>
<td>CA</td>
<td colspan="1"><span>Users&gt;Customer shipping address&gt;<span style="color: rgb(29,35,39);">State / County</span></span></td></tr>
<tr>
<td>Postal Code</td>
<td colspan="1"><span>Customer&gt;Shipping&gt;Ship To Address section</span></td>
<td colspan="1">&nbsp;</td>
<td>PostalCode</td>
<td>Contact</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;ShippingContact&gt;Address</td>
<td>postcode</td>
<td>94103</td>
<td colspan="1"><span>Users&gt;Customer shipping address&gt;<span style="color: rgb(29,35,39);">Postcode / ZIP</span></span></td></tr>
<tr>
<td>Country</td>
<td colspan="1"><span>Customer&gt;Shipping&gt;Ship To Address section</span></td>
<td colspan="1">Y</td>
<td>CountryID</td>
<td>Contact</td>
<td colspan="1"><span>Address</span></td>
<td>Customer&gt;ShippingContact&gt;Address</td>
<td>country</td>
<td>US</td>
<td colspan="1"><span>Users&gt;Customer shipping address&gt;<span style="color: rgb(29,35,39);">Country / Region</span></span></td></tr>
<tr>
<td colspan="1"><span>Business 1</span></td>
<td colspan="1"><span>Customer&gt;Shipping&gt;Ship To Address section</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span>Phone1</span></td>
<td colspan="1">Contact</td>
<td colspan="1"><span>Contact</span></td>
<td colspan="1"><span>Customer&gt;<span>ShippingContact&gt;Phone1</span></span></td>
<td rowspan="2">Since this is not mandatory from the AC and there is no field to map from WC, therefore, it was ignored</td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td><br /><br /></td></tr>
<tr>
<td colspan="1"><span>EMail</span></td>
<td colspan="1"><span>Customer&gt;Shipping&gt;Ship To Address section</span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1"><span>EMail</span></td>
<td colspan="1">Contact</td>
<td colspan="1"><span>Contact</span></td>
<td colspan="1"><span>Customer&gt;<span>ShippingContact&gt;Email</span></span></td>
<td colspan="1">&nbsp;</td>
<td colspan="1">&nbsp;</td>
<td>&nbsp;</td></tr></tbody></table>
<p><span style="color: rgb(0,0,0);"><br /></span></p>
<h2><span style="color: rgb(0,0,0);">WooCommerce Address Mapping to Acumatica</span></h2>
<p><strong><span style="color: rgb(0,0,0);">Address Definitions in WC</span></strong></p>
<table>
<tbody>
<tr>
<th>Billing</th>
<th>Shipping</th></tr>
<tr>
<td colspan="1"><img src="https://github.com/Acumatica/Acumatica-WooCommerce/tree/2021R109/Documentation/Mappings/Mapping%20Images/Customer1.png" /></td>
<td colspan="1"><img src="https://github.com/Acumatica/Acumatica-WooCommerce/tree/2021R109/Documentation/Mappings/Mapping%20Images/Customer2.png" /></td></tr></tbody></table>
<p>&nbsp;</p>
<p><strong><span style="color: rgb(0,0,0);">Option 01: Develop Address comparing method when exporting and importing customers. So the Billing and Shipping Address are compared before the import or export.</span></strong></p>

<table>
<tbody>
<tr>
<th>Customer Import</th>
<th>Customer Export</th>
<th colspan="1">Customer Update</th></tr>
<tr>
  
<td>
<ol>
<li><span style="color: rgb(0,0,0);">When WC Customer has Billing Address different to Shipping Address (empty Shipping Address or different address)</span><span 
style="color: rgb(0,0,0);"><strong><br />
  
![Screenshot](/Documentation/Mappings/Mapping%20Images/Customer3.png)<br /></strong></span></li></ol></td>
  
<td>
<ol>
<li><span style="color: rgb(0,0,0);">When Acumatica Customer has the same address for Billing and Shipping in AC, export them separately even the same address.</span><span style="color: rgb(0,0,0);"><strong><br />
  
 ![Screenshot](/Documentation/Mappings/Mapping%20Images/Customer4.png)<br /></strong></span></li></ol></td>
  
<td colspan="1">
<p>1.When Billing Override is enabled on AC, WC Billing address should update directly to AC Billing Address
  
![Screenshot](/Documentation/Mappings/Mapping%20Images/Customer5.png)</p></td></tr>
  
<tr>
<td colspan="1">
<p>2. When WC Customer has the same address for both Billing &amp; Shipping Addresses</p>
  

![Screenshot](/Documentation/Mappings/Mapping%20Images/Customer6.png)
  
<td colspan="1">
<p>2. When AC Customer`s billing address is overridden or different to each, export both addresses to WC</span></p>
  

 ![Screenshot](/Documentation/Mappings/Mapping%20Images/Customer7.png)
  
<td colspan="1">&nbsp;</td></tr></tbody></table>
<p><span style="color: rgb(255,0,0);">Limitation</span>: When comparing addresses, minor spelling changes are identified as a separate address. And WC shipping and billing addresses content are different from each other.</p>
<p><strong>Option 02: Shipping Address can be overridden always, so the empty address can be passed to both sides to avoid the limitation in Option 01.</strong></p>
<table>
<tbody>
<tr>
<th>Customer Import</th>
<th>Customer Export</th>
<th colspan="1">Customer Update</th></tr>
<tr>
<td>
<ol>
<li><span style="color: rgb(0,0,0);">Even shipping address from WooCommerce is empty or contain values, it will be overridden and mapped to AC`s Shipping address.</span></li>
  </ol>
  
 ![Screenshot](/Documentation/Mappings/Mapping%20Images/Customer8.png)<br />
  
<p><span style="color: rgb(0,0,0);"><br /></span></p>
<p><span style="color: rgb(0,0,0);">&nbsp;</span></p></td>
<td>
<p>&nbsp;</p>
  

 ![Screenshot](/Documentation/Mappings/Mapping%20Images/Customer9.png)
 
 </td>
<td colspan="1">
<ol>
<li>When Billing Override is enabled on AC, WC Billing address should update directly to AC Billing Address</li></ol>
  
![Screenshot](/Documentation/Mappings/Mapping%20Images/Customer10.png)

 </p></td></tr></tbody></table>
<p><strong><br /></strong></p>
<p><span style="color: rgb(255,0,0);">Limitation</span>: Shipping address always be overridden, even the same address is used for both purposes.</p>
<p>Note: Option 02 Selected for the development</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
